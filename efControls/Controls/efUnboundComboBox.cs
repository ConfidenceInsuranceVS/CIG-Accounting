using DevExpress.XtraEditors;
using System;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efUnboundComboBox : ComboBoxEdit, IControl
    {
        static efUnboundComboBox()
        {
            RepositoryItemefUnboundComboBox.RegisterefUnboundComboBox();
        }

        public efUnboundComboBox()
            : base()
        {
            DefaultState = Enums.ControlState.Default;
            Text = Text.Trim();

            Properties.NullText = string.Empty;
            Properties.HighlightedItemStyle = HighlightStyle.Skinned;
            Properties.Leave += Properties_Leave;
            EnterMoveNextControl = true;
            StyleController = App.styleController;
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

        private void Properties_Leave(object sender, EventArgs e)
        {
            var ef = FindForm() as efBaseForm;
            if (ef != null)
            {
                if (!Properties.ReadOnly) { ef.ValidationProvider.Validate(this); }
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return "efUnboundComboBox";
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemefUnboundComboBox Properties
        {
            get
            {
                return base.Properties as RepositoryItemefUnboundComboBox;
            }
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

        [Category("xProperties")]
        public string colHeader1 { get; set; }

        [Category("xProperties")]
        public string colHeader2 { get; set; }
    }
}
