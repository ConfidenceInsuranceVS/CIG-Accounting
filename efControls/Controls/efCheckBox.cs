using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Drawing;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efCheckBox : CheckEdit, IControl
    {
        static efCheckBox()
        {
            RepositoryItemefCheckBox.RegisterefCheckBox();
        }

        public efCheckBox()
            : base()
        {
            DefaultState = Enums.ControlState.Default;
            EnterMoveNextControl = true;           
            
            Properties.Leave += Properties_Leave;

            Properties.Appearance.BackColor = Properties.AppearanceDisabled.BackColor =
            Properties.AppearanceFocused.BackColor = Properties.AppearanceReadOnly.BackColor = Color.Transparent;
        }
        protected override void OnLoaded()
        {
            base.OnLoaded();
            switch (ValueType)
            {
                case Enums.ValueType.Boolean:
                    Properties.ValueChecked = true;
                    Properties.ValueUnchecked = false;
                    break;

                case Enums.ValueType.Integer:
                    Properties.ValueChecked = 1;
                    Properties.ValueUnchecked = 0;
                    break;
            }
            Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
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
        public override string EditorTypeName
        {
            get
            {
                return "efCheckBox";
            }
        }
        private void Properties_Leave(object sender, System.EventArgs e)
        {
            var ef = FindForm() as efBaseForm;
            if (ef != null)
            {
                if (!Properties.ReadOnly) { ef.ValidationProvider.Validate(this); }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemefCheckBox Properties
        {
            get
            {
                return base.Properties as RepositoryItemefCheckBox;
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            var ef = FindForm() as efBaseForm;
            Properties.ReadOnly = Functions.setControlState(DefaultState, ef == null ? Enums.State.Edit : ef.xState);
        }

        [Category("xProperties")]
        public Enums.ControlState DefaultState { get; set; }

        [Category("xProperties")]
        public Enums.ValueType ValueType { get; set; }

        [Category("xProperties")]
        public bool HighLighted { get; set; }
    }
}
