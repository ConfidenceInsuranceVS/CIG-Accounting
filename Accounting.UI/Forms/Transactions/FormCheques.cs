using System;
using System.Linq;
using efControls;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using System.IO;

namespace Accounting
{
    public partial class FormCheques : efBaseForm
    {
        public int currencyID;
        public decimal amount;
        public string beneficiary;
        public DateTime date;
        public FormCheques()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            fillValues();
        }
        private void fillValues()
        {
            cboCurrencies.EditValue = currencyID;
            txtAmount.EditValue = amount;
            txtName.EditValue = beneficiary;
            deDate.EditValue = date;
            txtTafkit.Text = NumberToWords.getExpression(amount.ToString(), DataFormServices.getCurrencyName((int)cboCurrencies.EditValue));
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void chkCo_CheckedChanged(object sender, EventArgs e)
        {
            peCo.Visible = chkCo.Checked;
        }
        private void chkFirst_CheckedChanged(object sender, EventArgs e)
        {
            lblFirst.Visible = chkFirst.Checked;
        }
        private string getReportFile()
        {
            var file = string.Format("{0}\\ChequeReport.repx", App.AllUsersPath);
            if (!File.Exists(file))
            {
                Alert.Show("File Not Found !!", "Attention !!", Enums.AlertType.Critical);
                file = string.Empty;
            }

            return file;
        }
        private void btnPreview_Click(object sender, EventArgs e)
        {
            print(false);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            print(true);
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            cboCurrencies.EditValue = null;
            txtAmount.EditValue = null;
            txtName.EditValue = null;
            deDate.EditValue = null;
            txtTafkit.Text = string.Empty;
        }
        private void btnDesign_Click(object sender, EventArgs e)
        {
            XtraReport rep = XtraReport.FromFile(getReportFile(), true);
            ReportDesignTool des = new ReportDesignTool(rep);

            des.ShowDesigner();
        }
        private void print(bool toprint)
        {
            var file = getReportFile();
            if (!string.IsNullOrEmpty(file))
            {
                XtraReport rep = XtraReport.FromFile(file, true);
                rep.Parameters["Amount"].Value = string.IsNullOrEmpty(txtAmount.Text) ? string.Empty : txtAmount.Text.PadLeft(15,'*');
                rep.Parameters["Currency"].Value = cboCurrencies.Text;
                rep.Parameters["FromTo"].Value = txtName.Text;
                rep.Parameters["Tafkit"].Value = txtTafkit.Text;
                rep.Parameters["Date"].Value = deDate.Text;
                rep.RequestParameters = false;
                if (toprint)
                    rep.Print();
                else
                    rep.ShowPreview();
            }
        }
        private void cboCurrencies_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                if ((int)cboCurrencies.EditValue != currencyID)
                    BackColor = System.Drawing.Color.LightPink;
                else
                    BackColor = System.Drawing.Color.Cornsilk;
                txtTafkit.Text = NumberToWords.getExpression(amount.ToString(), DataFormServices.getCurrencyName((int)cboCurrencies.EditValue));
            }
            catch (Exception)
            {
                txtTafkit.Text = string.Empty;
            }
        }
        private void txtAmount_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtTafkit.Text = NumberToWords.getExpression(amount.ToString(), DataFormServices.getCurrencyName((int)cboCurrencies.EditValue));
            }
            catch (Exception)
            {
                txtTafkit.Text = string.Empty;
            }
        }

        private void btnRecall_Click(object sender, EventArgs e)
        {
            fillValues();
        }
    }
}
