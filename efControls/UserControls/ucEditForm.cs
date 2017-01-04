using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraEditors.DXErrorProvider;
using System.Windows.Forms;

namespace efControls
{
    public partial class ucEditForm : EditFormUserControl
    {
        public ucEditForm()
        {
            InitializeComponent();

            txtDescription.Validating += TxtDescription_Validating;
            txtCode.Validating += TxtCode_Validating;
        }
        protected override bool ProcessDialogKey(Keys keyData)
        {
            if (keyData == Keys.Escape && this.Visible) { return false; }
            return base.ProcessDialogKey(keyData);
        }
        private void TxtCode_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var f = FindForm() as efBaseForm;
            var c = sender as efTextBox;
            if (string.IsNullOrEmpty(c.Text))
                f.setControlError(c, "Code is Required", e);
            else
                f.clearControlError(c, e);
        }
        private void TxtDescription_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var f = FindForm() as efBaseForm;
            var c = sender as efTextBox;
            if (string.IsNullOrEmpty(c.Text))
                f.setControlError(c, "Description is Required", e);
            else
                f.clearControlError(c, e);
        }
    }
}
