using DevExpress.XtraEditors;
using System;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efDateEdit : DateEdit, IControl
    {
        static efDateEdit()
        {
            RepositoryItemefDateEdit.RegisterefDateEdit();
        }
        public efDateEdit()
            : base()
        {
            DefaultState = Enums.ControlState.Default;
            DisplayType = Enums.DisplayType.Default;
            EnterMoveNextControl = true;
            Properties.Leave += Properties_Leave;
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

        public override string EditorTypeName
        {
            get
            {
                return "efDateEdit";
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemefDateEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemefDateEdit;
            }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            switch (DisplayType)
            {
                case Enums.DisplayType.ShortDate:
                    Properties.Mask.EditMask = "dd/MM/yyyy";
                    break;
                case Enums.DisplayType.LongDate:
                    Properties.Mask.EditMask = "dd/MM/yyyy mm:ss";
                    break;
            }
            Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
            Properties.Appearance.Options.UseTextOptions = false;
            Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            Properties.Mask.UseMaskAsDisplayFormat = true;
            Properties.Buttons.Clear();
            ToolTip = string.IsNullOrEmpty(ToolTip) ? Properties.NullValuePrompt : ToolTip;
        }

        public override void Refresh()
        {
            base.Refresh();
            Enabled = true;

            var ef = FindForm() as efBaseForm;
            Properties.ReadOnly = Functions.setControlState(DefaultState, ef == null ? Enums.State.Edit : ef.xState);
        }
        private void Properties_Leave(object sender, EventArgs e)
        {
            var ef = FindForm() as efBaseForm;
            if (ef != null)
            {
                if (!Properties.ReadOnly) { ef.ValidationProvider.Validate(this); }
            }
        }

        [Category("xProperties")]
        public Enums.ControlState DefaultState { get; set; }

        [Category("xProperties"),
        Browsable(true)]
        public Enums.DisplayType DisplayType { get; set; }

        [Category("xProperties"),
        Browsable(true)]
        public bool AllowLeadingSpace { get; set; }

        [Category("xProperties"),
        Browsable(true)]
        public string Information { get; set; }

    }
}