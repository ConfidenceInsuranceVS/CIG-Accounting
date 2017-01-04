using System;
using System.Linq;
using efControls;
using System.Collections.Generic;
using efControls.Data;

namespace Accounting
{
    public partial class FormJournalChecker : efBaseForm
    {
        public FormJournalChecker()
        {
            InitializeComponent();

            using (SecurityEntities se = new SecurityEntities(App.SecurityConnectionString))
            {
                bsUsers.DataSource = se.Users.OrderBy(c => c.Name).ToList();
            };
        }
        protected override void OnShown(EventArgs e)
        {
            // txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;// samir 04/01/2017
            base.OnShown(e);
            gvResult.VisibleColumns[0].Width = 30;

        }
        private void jvChecker()
        {
            bsResult.Clear();
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                var jvType = (int?)cboVoucherTypes.EditValue ?? 0;

                Splash.Show(this);
                Splash.SetCaption("Please Wait ...");
                Splash.SetDescription("Collecting Data ...");
                var alljvs = ae.Journalparents
                    .Where(p => p.YDate == App.WorkingYear && (jvType != 0 ? p.Vouchertypeid == jvType : true))
                    .Join(ae.Vouchertypes, p => p.Vouchertypeid, v => v.ID, (p, v) => new { p.ID, v.Code, p.Reference })
                    .Join(ae.Journalchilds, p => p.ID, c => c.Voucherid, (p, c) => new
                    {
                        p.ID,
                        p.Code,
                        p.Reference,
                        c.Line,
                        c.Accountid,
                        c.Currencyid,
                        c.Dc,
                        c.Amount1st,
                        c.Amount2nd
                    }).ToList();
                //
                #region Accounts
                Splash.SetDescription("Checking For Empty Accounts ...");
                var Accounts = alljvs.Where(c => c.Accountid == null).ToList();
                foreach (var acc in Accounts)
                {
                    bsResult.Add(new voucherChecker()
                    {
                        Id = acc.ID,
                        Result = string.Format("Missing Account ==> {0} {1} @Line {2} ??", acc.Code, acc.Reference, acc.Line),
                        Type = acc.Code,
                        Reference = (int)acc.Reference
                    });
                }
                #endregion
                //
                #region Currencies
                Splash.SetDescription("Checking For Empty Currency ...");
                var Curs = alljvs.Where(c => c.Currencyid == null).ToList();
                foreach (var cur in Curs)
                {
                    bsResult.Add(new voucherChecker()
                    {
                        Id = cur.ID,
                        Result = string.Format("Missing Currency ==> {0} {1} @Line {2} ??", cur.Code, cur.Reference, cur.Line),
                        Type = cur.Code,
                        Reference = (int)cur.Reference
                    });
                }
                #endregion
                //
                var types = alljvs.Select(c => new { Type = c.Code }).Distinct();
                Splash.SetDescription("Grouping Data ...");
                var group = alljvs.GroupBy(p => new { p.ID, p.Dc, p.Code, p.Reference })
                    .Select(c => new
                    {
                        ID = c.Key.ID,
                        c.Key.Code,
                        c.Key.Reference,
                        db1st = c.Key.Dc == "D" ? c.Sum(v => v.Amount1st) : 0,
                        cd1st = c.Key.Dc == "C" ? c.Sum(v => v.Amount1st) : 0,
                        db2nd = c.Key.Dc == "D" ? c.Sum(v => v.Amount2nd) : 0,
                        cd2nd = c.Key.Dc == "C" ? c.Sum(v => v.Amount2nd) : 0
                    }).ToList();

                Splash.SetDescription("Calculating Difference ...");
                var diff = group.GroupBy(p => new { p.ID, p.Code, p.Reference })
                    .Select(c => new
                    {
                        ID = c.Key.ID,
                        c.Key.Code,
                        c.Key.Reference,
                        diff1st = c.Sum(v => v.db1st - v.cd1st),
                        diff2nd = c.Sum(v => v.db2nd - v.cd2nd)
                    }).Where(c => c.diff1st != 0 || c.diff2nd != 0).ToList();

                if (diff.Count != 0)
                {
                    foreach (var jv in diff)
                        bsResult.Add(new voucherChecker()
                        {
                            Id = jv.ID,
                            Result = string.Format("Voucher {0} {1} Not Balanced", jv.Code, jv.Reference),
                            Type = jv.Code,
                            Reference = (int)jv.Reference
                        });
                }
                //
                Splash.SetDescription("Checking For Missed References ...");
                var jvs = ae.Journalparents
                    .Where(c => c.YDate == App.WorkingYear && (jvType == 0 ? true : c.Vouchertypeid == jvType))
                    .Select(c => new { jvType = c.Vouchertype.Code, Reference = c.Reference, jvDate = c.Jvdate })
                    .OrderBy(c => c.jvType).ToList();
                types = jvs.Select(c => new { Type = c.jvType }).Distinct();
                foreach (var type in types)
                {
                    var jvTypes = jvs.Where(c => c.jvType == type.Type).ToList();
                    for (int i = 1; i < jvTypes.Max(c => c.Reference); i++)
                    {
                        if (jvTypes.FirstOrDefault(c => c.Reference == i) == null)
                            bsResult.Add(new voucherChecker()
                            {
                                Id = -1,
                                Result = string.Format("Missing Reference {0} {1}", type.Type, i),
                                Type = type.Type,
                                Reference = i
                            });
                    }
                }
                //
                Splash.SetDescription("Checking For Empty Types ...");
                jvs = ae.Journalparents
                    .Where(c => c.YDate == App.WorkingYear && c.Vouchertypeid == null)
                    .Select(c => new { jvType = c.Vouchertype.Code, Reference = c.Reference, jvDate = c.Jvdate })
                    .OrderBy(c => c.jvType).ToList();
                types = jvs.Select(c => new { Type = c.jvType }).Distinct();
                foreach (var type in types)
                {
                    var jvTypes = jvs.Where(c => c.jvType == type.Type).ToList();
                    foreach (var jvtype in jvTypes)
                    {
                        bsResult.Add(new voucherChecker()
                        {
                            Id = -1,
                            Result = string.Format("Missing Voucher Type for Reference {0} ??", jvtype.Reference)
                        });
                    }
                }
                //
                Splash.SetDescription("Checking For Empty Dates ...");
                jvs = ae.Journalparents
                    .Where(c => c.YDate == App.WorkingYear && c.Jvdate == null)
                    .Select(c => new { jvType = c.Vouchertype.Code, Reference = c.Reference, jvDate = c.Jvdate })
                    .OrderBy(c => c.jvType).ToList();
                types = jvs.Select(c => new { Type = c.jvType }).Distinct();
                foreach (var type in types)
                {
                    var jvTypes = jvs.Where(c => c.jvType == type.Type).ToList();
                    foreach (var jvtype in jvTypes)
                    {
                        bsResult.Add(new voucherChecker()
                        {
                            Id = 0,
                            Result = string.Format("Missing Date ==> {0} {1} ??", jvtype.jvType, jvtype.Reference),
                            Type = jvtype.jvType,
                            Reference = (int)jvtype.Reference
                        });
                    }
                }
                //
                Splash.Close();
            }
        }
        private void descriptionChecker()
        {
            bsResult.Clear();
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                var jvType = (int?)cboVoucherTypes.EditValue ?? 0;

                Splash.Show(this);
                Splash.SetCaption("Please Wait ...");
                Splash.SetDescription("Collecting Data ...");
                var alljvs = ae.CheckerDescription(jvType, App.WorkingYear);
                Splash.SetDescription("Checking For Description Problems ...");
                foreach (var jv in alljvs)
                {
                    bsResult.Add(new voucherChecker()
                    {
                        Id = jv.ID,
                        Result = string.Format("Check Description In ==> {0} {1}", jv.Type, jv.Reference),
                        Type = jv.Type,
                        Reference = (int)jv.Reference
                    });
                }
                Splash.Close();
            }
        }
        private void maturityChecker()
        {
            if (cboAccount.EditValue == null)
            {
                Alert.Show("Please Specify An Account Number To Continue", Enums.AlertType.Warning);
                cboAccount.Focus();
                return;
            }

            bsResult.Clear();
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                var jvType = (int?)cboVoucherTypes.EditValue ?? 0;
                var accountid = (int?)cboAccount.EditValue ?? 0;

                Splash.Show(this);
                Splash.SetCaption("Please Wait ...");
                Splash.SetDescription("Collecting Data ...");
                var alljvs = ae.CheckerMaturity(accountid, jvType, App.WorkingYear);
                Splash.SetDescription("Checking For Maturity Problems ...");
                foreach (var jv in alljvs)
                {
                    bsResult.Add(new voucherChecker()
                    {
                        Id = jv.ID,
                        Result = string.Format("Check {2}Maturity In ==> {0} {1}", jv.Type, jv.Reference, jv.Maturity == null ? "Empty " : "Bad "),
                        Type = jv.Type,
                        Reference = (int)jv.Reference
                    });
                }
                Splash.Close();
            }
        }
        private void currencyChecker()
        {
            bsResult.Clear();
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                var jvType = (int?)cboVoucherTypes.EditValue ?? 0;
                var accountid = (int?)cboAccount.EditValue ?? 0;

                Splash.Show(this);
                Splash.SetCaption("Please Wait ...");
                Splash.SetDescription("Collecting Data ...");
                var alljvs = ae.CheckerCurrencies(accountid, jvType, App.WorkingYear);
                Splash.SetDescription("Checking For Currencies Problems ...");
                foreach (var jv in alljvs)
                {
                    if (jv.Amount1st != jv.Amountr)
                        bsResult.Add(new voucherChecker()
                        {
                            Id = jv.ID,
                            Result = string.Format("Check Currencies [LL] In ==> {0} {1} Line {2}", jv.Type, jv.Reference, jv.Line),
                            Type = jv.Type,
                            Reference = (int)jv.Reference
                        });
                    if (jv.Amount2nd != jv.Amountf)
                        bsResult.Add(new voucherChecker()
                        {
                            Id = jv.ID,
                            Result = string.Format("Check Currencies [$] In ==> {0} {1} Line {2}", jv.Type, jv.Reference, jv.Line),
                            Type = jv.Type,
                            Reference = (int)jv.Reference
                        });
                }
                Splash.Close();
            }
        }
        private void editedAfterChecker()
        {
            if (string.IsNullOrEmpty(txtAmount.Text)) // added by samir BU 29/12/2016-4
            {
                Alert.Show("amount for time or date !!", Enums.AlertType.Warning);
                txtAmount.Focus();
                return;

            }
            bsResult.Clear();
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                var jvType = (int?)cboVoucherTypes.EditValue ?? 0;
                var accountid = (int?)cboAccount.EditValue ?? 0;

                Splash.Show(this);
                Splash.SetCaption("Please Wait ...");
                Splash.SetDescription("Collecting Data ...");
                dynamic alljvs;
                if (rgDT.SelectedIndex == 0)
                    alljvs = ae.CheckerEditedDate(accountid, jvType, (int?)cboUsers.EditValue, int.Parse(txtAmount.Text), App.WorkingYear);

                else
                 //   alljvs = ae.CheckerEditedHours(accountid, jvType, (int?)cboUsers.EditValue, int.Parse(txtAmount.Text), App.WorkingYear);
                alljvs = ae.CheckerEditedHours(accountid, jvType, (int?)cboUsers.EditValue,txtAmount.Text, App.WorkingYear);
                Splash.SetDescription("Checking For Currencies Problems ...");
                foreach (var jv in alljvs)
                {
                    bsResult.Add(new voucherChecker()
                    {
                        Id = jv.id,
                        Result = string.Format("{0} {1} CR. {2} {3} MD. {4} {5}", jv.Type, jv.Reference, jv.CName, jv.Creationdate, jv.MName, jv.Modificationdate),
                        Type = jv.Type,
                        Reference = (int)jv.Reference
                    });
                }
                Splash.Close();
            }
        }

        private void bbiConfirm_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch (rgChecker.SelectedIndex)
            {
                case 0:
                    jvChecker();
                    break;

                case 1:
                    descriptionChecker();
                    break;

                case 2:
                    maturityChecker();
                    break;

                case 3:
                    currencyChecker();
                    break;

                case 4:
                    editedAfterChecker();
                    break;
            }
        }
        private void bbiSaveChecked_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            var selected = bsResult.List.OfType<voucherChecker>()
                .Where(c => c.Ischecked).ToList();
        }
        private void bbiExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Close();
        }
        private void rgChecker_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearValidation(); // added by samir BU 29/12/2016-4 also on the designer I have set validationMode to Manual
            cboVoucherTypes.EditValue = cboAccount.EditValue = null;
            cboUsers.Enabled = txtAmount.Enabled = rgDT.Enabled = rgChecker.SelectedIndex == 4;
            if (rgDT.SelectedIndex == 0)// added by samir 04/01/2017
            {
                //  txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;// samir

                txtAmount.Properties.Mask.EditMask = " ##0;";
                txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                txtAmount.ToolTip = "fill number for date";
                txtAmount.EditValue = "0";// new System.DateTime(2017, 1, 4, 0, 0, 0, 0);


            }
            else
            {

                this.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                txtAmount.Properties.Mask.EditMask = "HH:mm";
                txtAmount.ToolTip = "fill time HH:mm";
                txtAmount.EditValue = new System.DateTime(2017, 1, 4, 0, 0, 0, 0);
            }
        }

        private void gvResult_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
            if (e.Clicks == 2)
            {
                var rec = (voucherChecker)bsResult.Current;
                if (rec.Id == -1) { return; }
                //de.callTransactionForm(((DateTime)rec.JvDate).Year, rec.Type, (int)rec.Reference, rec.Sc); //check with Rafic why code is commented UE-12/12/2016-3


                //var mForm = (FormMain)MdiParent;
                //    dynamic frm = null;
                //    switch (rec.Type)
                //    {
                //        case "RV":
                //            //frm = new FormReceiptVouchers(rec.Type, (int)rec.Reference);
                //            break;
                //        case "PV":
                //            frm = new FormPaymentVouchers(rec.Type, (int)rec.Reference);
                //            break;
                //        case "CN":
                //            frm = new FormCreditNotes(rec.Type, (int)rec.Reference);
                //            break;
                //        case "DN":
                //            frm = new FormDebitNotes(rec.Type, (int)rec.Reference);
                //            break;
                //        default:
                //            frm = null;
                //            //frm = new FormJournalVouchers(rec.Type, (int)rec.Reference);
                //            break;
                //    }
                //    mForm.getFormRights(frm, mForm.ribbon.Items["bbiJV"].Id);
                //    mForm.showForm(frm);
                //}
            }
        }

        private void rgDT_SelectedIndexChanged(object sender, EventArgs e) // added by samir 04/01/2017
        {

            if (rgDT.SelectedIndex == 0)
            {
                
                txtAmount.Properties.Mask.EditMask = " ##0;";
                txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                txtAmount.ToolTip = "fill number for date";
                txtAmount.EditValue = "0";// new System.DateTime(2017, 1, 4, 0, 0, 0, 0);


            }
            else
            {
                this.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                txtAmount.Properties.Mask.EditMask = "HH:mm";
                txtAmount.ToolTip = "fill time HH:mm";
                txtAmount.EditValue = new System.DateTime(2017, 1, 4, 0, 0, 0, 0);
            }

        }
    }
}
