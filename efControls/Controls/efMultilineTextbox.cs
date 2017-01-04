using DevExpress.XtraEditors;
using System;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efMultilineTextbox : MemoEdit, IControl
    {
        public efMultilineTextbox()
        {
            DefaultState = Enums.ControlState.Default;
            EnterMoveNextControl = false;//ref UE-15/12/2016-1 modified by samir 15/12/2016 it was set to true

            Properties.Leave += (Properties_Leave);
            TextChanged+=efMultilineTextbox_TextChanged;
            StyleController = App.styleController;
        }

        private void Properties_Leave(object sender, EventArgs e)
        {
            var ef = FindForm() as efBaseForm;
            if (ef != null)
            {
                if (!Properties.ReadOnly) { ef.ValidationProvider.Validate(this); }
            }
        }

        public bool toValidate()
        {
            bool result = true;
            try
            {
                if (Properties.ReadOnly | !((efBaseForm)FindForm()).isActiveForm()) { result = false; }
            }
            catch (Exception)
            {
                result = true;
            }
            return result;
        }

        public override void Refresh()
        {
            base.Refresh();
            Enabled = true;

            var ef = FindForm() as efBaseForm;
            Properties.ReadOnly = Functions.setControlState(DefaultState, ef == null ? Enums.State.Edit : ef.xState);
        }

        [Category("xProperties")]
        public Enums.ControlState DefaultState { get; set; }

        private void efMultilineTextbox_TextChanged(object sender, EventArgs e)
        {
            Text = Text.Trim();
        }

      
    }
}
