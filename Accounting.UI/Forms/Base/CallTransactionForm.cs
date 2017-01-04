using System;
using System.Linq;
using System.Data.Entity;
using efControls;
using efControls.Data;
using DevExpress.XtraBars;
using System.Windows.Forms;
using System.IO;

namespace Accounting
{
    public class CallTransactionForm
    {
        public static void callTransactionForm(FormMain mForm, int year, string type, int id)
        {
            if (year != App.WorkingYear)
                Alert.Show("Not In Current Year", Enums.AlertType.Warning);
            else
            {
                dynamic frm = null;
                switch (type)
                {
                    case "RV":
                        frm = new FormReceiptVouchers(id);
                        break;
                    case "PV":
                        frm = new FormPaymentVouchers(id);
                        break;
                    case "CN":
                        frm = new FormCreditNotes(id);
                        break;
                    case "DN":
                        frm = new FormDebitNotes(id);
                        break;
                    default:
                        frm = new FormJournalVouchers(id);
                        break;
                }
                mForm.getFormRights(frm, mForm.ribbon.Items["bbiJV"].Id);
                mForm.showForm(frm);
            }
        }

        public static void convertPdfNames()
        {
            AccountingEntities ae = new AccountingEntities(App.MainConnectionString);
            SecurityEntities se = new SecurityEntities(App.SecurityConnectionString);

            var fbd = new FolderBrowserDialog() { RootFolder = Environment.SpecialFolder.MyComputer, Description = "Select PDF Path" };
            fbd.ShowDialog();
            //AllUsersPath = string.Format(@"{0}\{1}", fbd.SelectedPath, Name);

            DirectoryInfo directory = new DirectoryInfo(fbd.SelectedPath);
            FileInfo[] files = directory.GetFiles("*.pdf");
            foreach (var file in files)
            {
                //Alert.Show(Enums.AlertType.None, file.Name);
                var aa = file.Name.Substring(0, 1);
                var bb = file.Name.Substring(1, 2);
                var cc = int.Parse(file.Name.Substring(3).Replace(".pdf", string.Empty));

                var sc = se.SubCompanies.FirstOrDefault(c => c.Code == aa).ID;
                var tp = ae.Vouchertypes.FirstOrDefault(c => c.Code == bb).ID;
                var fileid = ae.Journalparents.FirstOrDefault(c => c.YDate == 2015 & c.SC == sc & c.Vouchertypeid == tp & c.Reference == cc).ID;

                var source = file.FullName;
                var destin = file.FullName.Replace(file.Name, string.Format("{0}.pdf", App.Int2Guid(fileid)));
                File.Move(source, destin);
            }
        }
    }
}