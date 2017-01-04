using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efComboBox : LookUpEdit, IControl
    {
        static efComboBox()
        {
            RepositoryItemefComboBox.RegisterefComboBox();
        }

        public efComboBox()
            : base()
        {
            DefaultState = Enums.ControlState.Default;
            EnterMoveNextControl = true;

            Properties.Leave += efComboBox_Leave;
            Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;

            ToolTip = string.IsNullOrEmpty(ToolTip) ? Properties.NullValuePrompt : ToolTip;
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

        public override string EditorTypeName { get { return "efComboBox"; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemefComboBox Properties
        {
            get
            {
                return base.Properties as RepositoryItemefComboBox;
            }
        }

        protected override void Refresh(bool resetCache)
        {
            base.Refresh(resetCache);
            var ef = FindForm() as efBaseForm;
            Properties.ReadOnly = Functions.setControlState(DefaultState, ef == null ? Enums.State.Edit : ef.xState);
        }
        private void efComboBox_Leave(object sender, EventArgs e)
        {
            var ef = FindForm() as efBaseForm;
            if (ef != null)
            {
                if (!Properties.ReadOnly) { ef.ValidationProvider.Validate(this); }
            }
        }

        [Category("xProperties")]
        public Enums.ControlState DefaultState { get; set; }

    }
}
