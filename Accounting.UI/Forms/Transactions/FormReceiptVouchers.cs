using System;
using System.Collections.Generic;
using System.Linq;
using efControls;

namespace Accounting
{
    public partial class FormReceiptVouchers : FormTransactions
    {
        public FormReceiptVouchers()
        {
            InitializeComponent();
            lcgDetails.Expanded = true;
            lockName = "FormJournalVouchers";
            defaultType = "RV";
            defaultDc = "C";

            beInstallments.DataBindings.Add("EditValue", bsMaster, "Instpay");
            riInstallments.ButtonClick += RiInstallments_ButtonClick;
        }
        public FormReceiptVouchers(int id) : this()
        {
            if(DesignMode | base.DesignMode) { return; }
            isMoveLast = false;
            //lcgDetails.Expanded = true;
            _id = id;
            //if (_id > 0) { isMoveLast = false; }
        }
        private void RiInstallments_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (xState != efControls.Enums.State.None) { return; }
            try
            {
                var rec = (Journalparent)bsMaster.Current;
                if (rec.Journalchilds.Count == 0) { return; }
                if (rec.Journalchilds.Where(c => c.Dc == "C").Count() == 0) { return; }
                if (rec.Journalchilds.Where(c => c.Dc == "C").Count() > 1) { throw new Exception("Multiple Credit Account Detected !!"); }

                var ins = rec.Journalchilds.FirstOrDefault(c => c.Dc == "C");
                ucInstallments f = new ucInstallments(this)
                {
                    broker = ins.Chartofaccount.Code,
                    type = rec.Vouchertype.Code,
                    reference = (int)rec.Reference,
                    ydate = (int)rec.YDate,
                    Voucherid = (int)rec.ID,
                    amount = (decimal)(ins.Amount2nd - rec.Instpay)
                };
                Controls.Add(f);
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message, Enums.AlertType.Information);
            }
        }

    }
}
