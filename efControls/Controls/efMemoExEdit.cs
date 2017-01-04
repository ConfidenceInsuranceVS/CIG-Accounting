using DevExpress.XtraEditors;
using System;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efMemoExEdit : MemoExEdit, IControl
    {
        public efMemoExEdit()
        {
            DefaultState = Enums.ControlState.Default;
            Properties.ShowIcon = false;
            Properties.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Ellipsis;
            Text = Text.Trim();

            Properties.Leave += Properties_Leave;
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

        public override void Refresh()
        {
            base.Refresh();
            Enabled = true;

            var ef = FindForm() as efBaseForm;
            Properties.ReadOnly = Functions.setControlState(DefaultState, ef == null ? Enums.State.Edit : ef.xState);
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

        [Category("xProperties")]
        public Enums.ControlState DefaultState { get; set; }

        [Category("xProperties"),
        Browsable(false)]
        public string LastEditValue { get; set; }
    }
}
