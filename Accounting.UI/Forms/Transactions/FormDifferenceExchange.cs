using System;
using System.Linq;
using efControls;
using System.Collections.Generic;
using efControls.Data;
using static Accounting.AccountingServices;
using System.Transactions;
using System.Windows.Forms;

namespace Accounting
{
    public partial class FormDifferenceExchange : efBaseForm
    {
        DateTime? fDate;
        string description;
        int dAccountID, cAccountID, typeID;
        AccountingEntities ae;
        List<ExchangeDifference> Diffs;
        List<Journalchild> jcs;
        Journalparent jp;
        public FormDifferenceExchange()
        {
            InitializeComponent();
            ae = new AccountingEntities(App.MainConnectionString);

            bsAccounts.DataSource = ae.Chartofaccounts.Select(c => new ucAccounts { ID = c.ID, Code = c.Code, Description = c.Description, CodeDescription = string.Empty }).ToList();
            bsBanks.DataSource = ae.Banks.Select(c => new ucBanks { ID = c.ID, Code = c.Code, Description = c.Description, CodeDescription = string.Empty }).ToList();
            bsCurrencies.DataSource = ae.Currencies.ToList();

            colSC.Visible = App.HasSubCompanies;
            colDescription.Width = App.HasSubCompanies == false ? colDescription.Width + colSC.Width : colDescription.Width;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            txtDescription.Text = XML.Read(App.PreferencesFile, "Application", "DOXDescription");
            cboAccountDebit.EditValue = int.Parse(XML.Read(App.PreferencesFile, "Application", "DOXNEGATIF"));
            cboAccountCredit.EditValue = int.Parse(XML.Read(App.PreferencesFile, "Application", "DOXPOSITIF"));
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            fDate = deFrom.EditValue == null ? (DateTime?)null : (DateTime)deFrom.EditValue;
            description = txtDescription.Text;
            dAccountID = cboAccountDebit.id;
            cAccountID = cboAccountCredit.id;
            bsDifference.Clear();

            try
            {
                if (fDate == null | string.IsNullOrEmpty(description) | dAccountID == 0 | cAccountID == 0)
                    throw new Exception("Missing Data ...");

                var tType = ae.Vouchertypes.FirstOrDefault(c => c.Type == "D");
                typeID = tType == null ? 0 : tType.ID;
                if (typeID == 0)
                    throw new Exception("Type Not Found ...");

                Diffs = ae.ExchangeDifference(App.WorkingYear, fDate, 0, 0, App.LocalCurreny, App.ForeignCurreny)
                            .OrderBy(c => c.Account).ThenBy(c => c.Currencyid)
                            .ToList();

                prepareVouchers();
            }
            catch (Exception ex)
            {
                Alert.ShowMessage(ex.Message);
            }
        }
        private void btnDifference_Click(object sender, EventArgs e)
        {
            if (Alert.ShowDialogMessage("This will replace any difference of exchange JV with the same date, Continue?") == System.Windows.Forms.DialogResult.No)
                return;

            lcMain.Enabled = false;
            var message = "Operation Completed Successfully";
            try
            {
                TransactionOptions top = new TransactionOptions();
                top.IsolationLevel = IsolationLevel.ReadCommitted;
                top.Timeout = new TimeSpan(0, 15, 0);

                List<SubCompany> scs;
                using (var se = new SecurityEntities(App.SecurityConnectionString)) { scs = se.SubCompanies.OrderBy(c => c.Code).ToList(); };

                var jvtype = ae.Vouchertypes.FirstOrDefault(c => c.Code == "EX");
                var typeid = jvtype.ID;
                var typecode = jvtype.Code;

                var recs = jcs.Select(c => new { c.Recstamp }).Distinct().ToList();

                int line = 0;
                int? reference1 = 0, reference2 = 0;
                Splash.Show(this);
                foreach (var rec in recs)
                {
                    reference1 = reference2 = 0;
                    var scID = scs.FirstOrDefault(s => s.Code == rec.Recstamp).ID;
                    var scCode = rec.Recstamp; ;

                    List<Journalparent> jps = ae.Journalparents
                        .Where(c => c.YDate == App.WorkingYear
                                & c.Jvdate == (DateTime)deFrom.EditValue
                                & c.Vouchertypeid == typeid
                                & c.SC == scID)
                        .ToList();

                    using (var ts = new TransactionScope(TransactionScopeOption.Required, top))
                    {
                        if (jps.Count == 0)
                        {
                            reference1 = getNextReference(typeid, scID);
                            reference2 = reference1 + 1;
                        }
                        else
                        {
                            foreach (var jp in jps)
                            {
                                if (reference1 == 0)
                                    reference1 = jp.Reference;
                                else
                                    reference2 = jp.Reference;

                                ae.Journalparents.Remove(jp);
                                ae.SaveChanges();
                            }
                        }

                        #region 1st
                        var jcs1st = jcs.Where(c => c.Amount1st != 0 & c.Recstamp == scCode).ToList();
                        if (jcs1st.Count == 0)
                        {
                            reference2 = reference1;
                        }
                        else
                        {
                            Splash.SetDescription(string.Format("Creating Voucher {0} {1} {2}", scCode, typecode, reference1));
                            jp = new Journalparent()
                            {
                                Vouchertypeid = typeid,
                                SC = scID,
                                Reference = reference1,
                                Rate2nd = 1500,
                                Jvdate = (DateTime)deFrom.EditValue,
                                CreatedByID = App.UserID,
                                Creationdate = DateTime.Now
                            };
                            ae.Journalparents.Add(jp);
                            ae.SaveChanges();

                            line = 0;
                            Splash.SetMaximum(jcs1st.Count);
                            foreach (var jpc in jcs1st)
                            {
                                Splash.SetProgress(jcs1st.IndexOf(jpc));
                                line += 1;
                                jpc.Line = line;
                                jp.Journalchilds.Add(jpc);
                                ae.SaveChanges();
                            }
                        }
                        #endregion

                        #region 2nd
                        var jcs2nd = jcs.Where(c => c.Amount2nd != 0 & c.Recstamp == scCode).ToList();
                        if (jcs2nd.Count > 0)
                        {
                            Splash.SetDescription(string.Format("Creating Voucher {0} {1} {2}", scCode, typecode, reference2));
                            jp = new Journalparent()
                            {
                                Vouchertypeid = typeid,
                                SC = scID,
                                Reference = reference2,
                                Rate2nd = 1500,
                                Jvdate = (DateTime)deFrom.EditValue,
                                CreatedByID = App.UserID,
                                Creationdate = DateTime.Now
                            };
                            ae.Journalparents.Add(jp);
                            ae.SaveChanges();

                            line = 0;
                            Splash.SetMaximum(jcs2nd.Count);
                            foreach (var jpc in jcs2nd)
                            {
                                Splash.SetProgress(jcs2nd.IndexOf(jpc));
                                line += 1;
                                jpc.Line = line;
                                jp.Journalchilds.Add(jpc);
                                ae.SaveChanges();
                            }
                        }
                        #endregion

                        ts.Complete();
                    }
                }
                Splash.Close();
            }
            catch (Exception)
            {
                message = "Error Occured!! Nothing Changed";
            }
            lcMain.Enabled = true;
            MessageBox.Show(message);
            Close();
        }
        private int getNextReference(int vID, int sc)
        {
            int jvRef = -1;

            if (App.HasSubCompanies)
                jvRef = getMaxReference(ae, App.WorkingYear, vID, sc) + 1;
            else
                jvRef = getMaxReference(ae, App.WorkingYear, vID) + 1;
            return jvRef;
        }
        private void prepareVouchers()
        {

            jcs = new List<Journalchild>();
            int line = 0;
            foreach (var Diff in Diffs)
            {
                #region Local 1st
                if (Diff.Difference1st > 0)
                {
                    line += 1;
                    jcs.Add(new Journalchild()
                    {
                        Line = line,
                        Accountid = Diff.AccountID,
                        Currencyid = Diff.Currencyid,
                        Ratecurrency = Diff.Rate,
                        Dc = "D",
                        Recstamp = Diff.SC,
                        Description = string.Format("{0} {1}", txtDescription.Text, deFrom.Text),
                        Amount1st = Math.Abs((decimal)Diff.Difference1st),
                        Amount2nd = 0,
                        Amount = 0
                    });

                    line += 1;
                    jcs.Add(new Journalchild()
                    {
                        Line = line,
                        Accountid = (int)cboAccountCredit.EditValue,
                        Currencyid = App.LocalCurreny,
                        Ratecurrency = Diff.Rate,
                        Dc = "C",
                        Recstamp = Diff.SC,
                        Description = string.Format("{0} {1} @ {2}", txtDescription.Text, deFrom.Text, Diff.Account),
                        Amount1st = Math.Abs((decimal)Diff.Difference1st),
                        Amount2nd = 0,
                        Amount = Math.Abs((decimal)Diff.Difference1st)
                    });
                }

                if (Diff.Difference1st < 0)
                {
                    line += 1;
                    jcs.Add(new Journalchild()
                    {
                        Line = line,
                        Accountid = Diff.AccountID,
                        Currencyid = Diff.Currencyid,
                        Ratecurrency = Diff.Rate,
                        Dc = "C",
                        Recstamp = Diff.SC,
                        Description = string.Format("{0} {1}", txtDescription.Text, deFrom.Text, Diff.Account),
                        Amount1st = Math.Abs((decimal)Diff.Difference1st),
                        Amount2nd = 0,
                        Amount = 0
                    });

                    line += 1;
                    jcs.Add(new Journalchild()
                    {
                        Line = line,
                        Accountid = (int)cboAccountDebit.EditValue,
                        Currencyid = App.LocalCurreny,
                        Ratecurrency = Diff.Rate,
                        Dc = "D",
                        Recstamp = Diff.SC,
                        Description = string.Format("{0} {1} @ {2}", txtDescription.Text, deFrom.Text, Diff.Account),
                        Amount1st = Math.Abs((decimal)Diff.Difference1st),
                        Amount2nd = 0,
                        Amount = Math.Abs((decimal)Diff.Difference1st)
                    });
                }
                #endregion

                #region Local 2nd
                if (Diff.Difference2nd > 0)
                {
                    line += 1;
                    jcs.Add(new Journalchild()
                    {
                        Line = line,
                        Accountid = Diff.AccountID,
                        Currencyid = Diff.Currencyid,
                        Ratecurrency = Diff.Rate,
                        Dc = "D",
                        Recstamp = Diff.SC,
                        Description = string.Format("{0} {1}", txtDescription.Text, deFrom.Text),
                        Amount2nd = Math.Abs((decimal)Diff.Difference2nd),
                        Amount1st = 0,
                        Amount = 0
                    });

                    line += 1;
                    jcs.Add(new Journalchild()
                    {
                        Line = line,
                        Accountid = (int)cboAccountCredit.EditValue,
                        Currencyid = App.ForeignCurreny,
                        Ratecurrency = Diff.Rate,
                        Dc = "C",
                        Recstamp = Diff.SC,
                        Description = string.Format("{0} {1} @ {2}", txtDescription.Text, deFrom.Text, Diff.Account),
                        Amount2nd = Math.Abs((decimal)Diff.Difference2nd),
                        Amount1st = 0,
                        Amount = Math.Abs((decimal)Diff.Difference2nd)
                    });
                }

                if (Diff.Difference2nd < 0)
                {
                    line += 1;
                    jcs.Add(new Journalchild()
                    {
                        Line = line,
                        Accountid = Diff.AccountID,
                        Currencyid = Diff.Currencyid,
                        Ratecurrency = Diff.Rate,
                        Dc = "C",
                        Recstamp = Diff.SC,
                        Description = string.Format("{0} {1}", txtDescription.Text, deFrom.Text, Diff.Account),
                        Amount2nd = Math.Abs((decimal)Diff.Difference2nd),
                        Amount1st = 0,
                        Amount = 0
                    });

                    line += 1;
                    jcs.Add(new Journalchild()
                    {
                        Line = line,
                        Accountid = (int)cboAccountDebit.EditValue,
                        Currencyid = App.ForeignCurreny,
                        Ratecurrency = Diff.Rate,
                        Dc = "D",
                        Recstamp = Diff.SC,
                        Description = string.Format("{0} {1} @ {2}", txtDescription.Text, deFrom.Text, Diff.Account),
                        Amount2nd = Math.Abs((decimal)Diff.Difference2nd),
                        Amount = Math.Abs((decimal)Diff.Difference2nd),
                        Amount1st = 0
                    });
                }
                #endregion
            }

            bsDifference.DataSource = jcs;
        }
    }
}
