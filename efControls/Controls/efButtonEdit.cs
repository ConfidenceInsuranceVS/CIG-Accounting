using DevExpress.XtraEditors;
using System;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efButtonEdit : ButtonEdit, IControl
    {
        static efButtonEdit()
        {
            RepositoryItemefButtonEdit.RegisterefButtonEdit();
        }

        public efButtonEdit()
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

        public override string EditorTypeName { get { return "efButtonEdit"; } }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemefButtonEdit Properties
        {
            get { return base.Properties as RepositoryItemefButtonEdit; }
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            switch (DisplayType)
            {
                case Enums.DisplayType.Numeric:
                    Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                    Properties.Appearance.Options.UseTextOptions = true;
                    Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    Properties.Mask.EditMask = "N2";
                    Properties.Mask.UseMaskAsDisplayFormat = true;
                    break;

                case Enums.DisplayType.ShortDate:
                    Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
                    Properties.Appearance.Options.UseTextOptions = false;
                    Properties.Mask.EditMask = "dd/MM/yyyy";
                    Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
                    Properties.Mask.UseMaskAsDisplayFormat = true;
                    break;

                case Enums.DisplayType.Time:
                    Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
                    Properties.Appearance.Options.UseTextOptions = false;
                    Properties.Mask.EditMask = "[0-9][0-9]:[0-9][0-9]";
                    Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
                    Properties.Mask.UseMaskAsDisplayFormat = true;
                    break;

                case Enums.DisplayType.Default:
                    Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Default;
                    Properties.Appearance.Options.UseTextOptions = false;
                    Properties.Mask.EditMask = "";
                    Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
                    Properties.Mask.UseMaskAsDisplayFormat = false;
                    break;
            }

            ToolTip = string.IsNullOrEmpty(ToolTip) ? Properties.NullValuePrompt : ToolTip;
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

        [Category("xProperties"), Browsable(true)]
        public Enums.DisplayType DisplayType { get; set; }

        [Category("xProperties")]
        public bool HighLighted { get; set; }

        private void Properties_Leave(object sender, EventArgs e)
        {
            var ef = FindForm() as efBaseForm;
            if (ef != null)
            {
                if (!Properties.ReadOnly) { ef.ValidationProvider.Validate(this); }
            }
        }
    }
}
