using DevExpress.XtraGrid;
using efControls;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public partial class FormPaymentVouchers : FormTransactions
    {
        private string _type = string.Empty;
        private string _sc = string.Empty;
        private int _reference = 0;
        public FormPaymentVouchers()
        {
            InitializeComponent();

            lcgDetails.Expanded = true;
            lockName = "FormJournalVouchers";
            defaultType = "PV";
            btnCheque.Visibility = DevExpress.XtraBars.BarItemVisibility.Always;
        }
        public FormPaymentVouchers(int id)
        {
            lcgDetails.Expanded = true;
            _id = id;
            if (_id > 0) { isMoveLast = false; }
        }
        public FormPaymentVouchers(string type, int reference, string sc) : this()
        {
            _type = type;
            _reference = reference;
            _sc = sc;
        }
        private void btnCheque_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            try
            {
                if (!AllowAdd & App.UserLevel != 1) { throw new PrivilegeException(); }
                var rec = (Journalparent)bsMaster.Current;
                var child = rec.Journalchilds.Where(c => c.Dc == "D").FirstOrDefault();
                if (bsMaster != null)
                {
                    using (var form = new FormCheques())
                    {
                        form.currencyID = (int)child.Currencyid;
                        form.beneficiary = string.IsNullOrEmpty(rec.Fromto) ? child.Chartofaccount.Description : rec.Fromto;
                        form.amount = (decimal)child.Amount;
                        form.date = (DateTime)rec.Jvdate;

                        var result = form.ShowDialog();
                    }
                }
            }
            catch (Exception ex)
            {
                Alert.ShowMessage(string.Format("{0}\n\r{1}", ex.Message, ex.StackTrace));
                xState = Enums.State.None;
            }
            AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
        }
    }
}
