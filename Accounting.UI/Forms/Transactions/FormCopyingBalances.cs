using System;
using System.Linq;
using efControls;
using System.Collections.Generic;

namespace Accounting
{
    public partial class FormCopyingBalances : efBaseForm
    {
        public FormCopyingBalances()
        {
            InitializeComponent();
            txtDescription.Text = XML.Read(App.PreferencesFile, "Application", "EOYDescription");
            esInfo.Text = string.Format("Attention - This will create/update the {0} opening voucher", App.WorkingYear + 1);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fillResult(string value)
        {
            lstResult.Items.Add(value);
            lstResult.SelectedIndex = lstResult.ItemCount - 1;
            lstResult.Refresh();
        }
        private void btn1to5_Click(object sender, EventArgs e)
        {
            if (Alert.ShowDialogMessage("Are You Sure To Proceed?") == System.Windows.Forms.DialogResult.No) { return; }
            lstResult.Items.Clear();
            try
            {
                using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
                {
                    Journalparent jp = null;
                    decimal? cl1st = 0, cl2nd = 0;
                    var jvtype = ae.Vouchertypes.FirstOrDefault(c => c.Type == "O").ID;
                    jp = ae.Journalparents.FirstOrDefault(c => c.YDate == App.WorkingYear + 1 & c.Vouchertypeid == jvtype);
                    if (jp != null)
                    {
                        if ((bool)jp.Isposted) { throw new Exception("Posted Record, Unpost to proceed !!"); }
                        for (int i = jp.Journalchilds.Count - 1; i >= 0; i--)
                        {
                            jp.Journalchilds.Remove(jp.Journalchilds[i]);
                        }
                        fillResult("Starting Update");
                    }
                    else
                    {
                        jp = new Journalparent()
                        {
                            Vouchertypeid = jvtype,
                            Reference = 1,
                            Jvdate = new DateTime(App.WorkingYear + 1, 1, 1),
                            Rate2nd = 1500
                        };
                        ae.Journalparents.Add(jp);
                        fillResult("Opening Voucher Created");
                    }

                    Journalchild jc;
                    var jvs = ae.AccountBalance(App.WorkingYear, "1", "6", null, null, 0, null).ToList();
                    int line = 1;
                    foreach (AccountBalance jv in jvs)
                    {
                        if (jv.Debit1st + jv.Credit1st + jv.Debit2nd + jv.Credit2nd == 0)
                            continue;

                        jc = new Journalchild()
                        {
                            Line = line,
                            Ratecurrency = ae.Currencies.FirstOrDefault(c => c.ID == jv.Currencyid).Rate,
                            Amount = Math.Abs((decimal)(jv.Debit - jv.Credit)),
                            Dc = jv.Debit - jv.Credit > 0 ? "D" : "C",
                            Amount1st = Math.Abs((decimal)(jv.Debit1st - jv.Credit1st)),
                            Amount2nd = Math.Abs((decimal)(jv.Debit2nd - jv.Credit2nd)),
                            Description = txtDescription.Text,
                            Accountid = jv.Accountid,
                            Currencyid = jv.Currencyid,
                            Voucherid = jp.ID
                        };
                        if (jc.Dc == "D")
                        {
                            cl1st += jc.Amount1st ?? 0;
                            cl2nd += jc.Amount2nd ?? 0;
                        }
                        else
                        {
                            cl1st -= jc.Amount1st ?? 0;
                            cl2nd -= jc.Amount2nd ?? 0;
                        }
                        ae.Journalchilds.Add(jc);
                        fillResult(string.Format("{0} : {1} {2}", ae.Chartofaccounts.FirstOrDefault(c => c.ID == jc.Accountid).Code, jc.Amount, jc.Dc));
                        line += 1;
                    }

                    jvs = ae.AccountBalance(App.WorkingYear, "8", "9", null, null, 0, null).ToList();
                    foreach (AccountBalance jv in jvs)
                    {
                        if (jv.Debit1st + jv.Credit1st + jv.Debit2nd + jv.Credit2nd == 0)
                            continue;

                        jc = new Journalchild()
                        {
                            Line = line,
                            Ratecurrency = ae.Currencies.FirstOrDefault(c => c.ID == jv.Currencyid).Rate,
                            Amount = Math.Abs((decimal)(jv.Debit - jv.Credit)),
                            Dc = jv.Debit - jv.Credit > 0 ? "D" : "C",
                            Amount1st = Math.Abs((decimal)(jv.Debit1st - jv.Credit1st)),
                            Amount2nd = Math.Abs((decimal)(jv.Debit2nd - jv.Credit2nd)),
                            Description = txtDescription.Text,
                            Accountid = jv.Accountid,
                            Currencyid = jv.Currencyid,
                            Voucherid = jp.ID
                        };
                        if (jc.Dc == "D")
                        {
                            cl1st += jc.Amount1st ?? 0;
                            cl2nd += jc.Amount2nd ?? 0;
                        }
                        else
                        {
                            cl1st -= jc.Amount1st ?? 0;
                            cl2nd -= jc.Amount2nd ?? 0;
                        }
                        ae.Journalchilds.Add(jc);
                        fillResult(string.Format("{0} : {1} {2}", ae.Chartofaccounts.FirstOrDefault(c => c.ID == jc.Accountid).Code, jc.Amount, jc.Dc));
                        line += 1;
                    }

                    jc = new Journalchild()
                    {
                        Line = line,
                        Dc = cl1st < 0 ? "D" : "C",
                        Amount1st = Math.Abs((decimal)cl1st),
                        Amount2nd = Math.Abs((decimal)cl2nd),
                        Description = txtDescription.Text,
                        Accountid = ae.Chartofaccounts.FirstOrDefault(c => c.Code == "999999999").ID,
                        Voucherid = jp.ID
                    };

                    ae.Journalchilds.Add(jc);
                    fillResult(string.Format("{0} : {1} {2}", ae.Chartofaccounts.FirstOrDefault(c => c.ID == jc.Accountid).Code, jc.Amount, jc.Dc));
                    ae.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Alert.ShowMessage(ex.Message);
            }
        }
    }
}
