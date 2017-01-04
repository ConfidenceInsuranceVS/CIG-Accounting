using System;
using System.ComponentModel;
using System.Globalization;
using DevExpress.XtraEditors;
using System.Windows.Forms;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efTextBox : TextEdit, IControl
    {
        TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
        static efTextBox()
        {
            RepositoryItemefTextBox.RegisterefTextBox();
        }

        public efTextBox()
            : base()
        {
            DefaultState = Enums.ControlState.Default;
            DisplayType = Enums.DisplayType.Default;
            EnterMoveNextControl = true;
            Properties.Enter += Properties_Enter;
            Properties.Leave += Properties_Leave;
            StyleController = App.styleController;
        }

        void Properties_Enter(object sender, EventArgs e)
        {
            SelectAll();
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
        public override string EditorTypeName { get { return "efTextBox"; } }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemefTextBox Properties
        {
            get
            {
                return base.Properties as RepositoryItemefTextBox;
            }
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

                case Enums.DisplayType.Integer:
                    Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
                    Properties.Appearance.Options.UseTextOptions = true;
                    Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
                    Properties.Mask.EditMask = "f0";
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
                    Properties.Mask.EditMask = @"(0?\d|1\d|2[0-3])\:[0-5]\d";
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
        private void Properties_Leave(object sender, EventArgs e)
        {
            if (DisplayType == Enums.DisplayType.TitleCase)
                Text = textInfo.ToTitleCase(Text);

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
