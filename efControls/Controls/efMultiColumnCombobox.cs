using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.ComponentModel;
using efControls;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efMultiColumnCombobox : LookUpEdit, IControl
    {
        static efMultiColumnCombobox()
        {
        }

        public efMultiColumnCombobox()
        {
            DefaultState = Enums.ControlState.Default;
            Text = Text.Trim();
            EnterMoveNextControl = true;
            Properties.Buttons.AddRange(new EditorButton[] {
            new EditorButton(ButtonPredefines.Combo),
            new EditorButton(ButtonPredefines.Left, string.Empty, -1, true, true, false, ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F2), new DevExpress.Utils.SerializableAppearanceObject(), string.Empty, null, null, true),
            new EditorButton(ButtonPredefines.Right, string.Empty, -1, true, true, false, ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.F3), new DevExpress.Utils.SerializableAppearanceObject(), string.Empty, null, null, true) });
            Properties.HeaderClickMode = HeaderClickMode.AutoSearch;
            Properties.HighlightedItemStyle = HighlightStyle.Skinned;
            Properties.Name = "efMultiColumnCombobox";
            Properties.PopupResizeMode = ResizeMode.LiveResize;
            Properties.PopupWidth = 300;
            Properties.SearchMode = SearchMode.AutoComplete;
            Properties.ShowFooter = false;
            Properties.TextEditStyle = TextEditStyles.Standard;
            Properties.ButtonClick += efMultiColumnCombobox_Properties_ButtonClick;
            Properties.Leave += efMultiColumnCombobox_Leave;
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

        private void efMultiColumnCombobox_Properties_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            switch (e.Button.Index)
            {
                case 1:
                    ClosePopup();
                    Properties.AutoSearchColumnIndex = 0;
                    ShowPopup();
                    break;

                case 2:
                    ClosePopup();
                    Properties.AutoSearchColumnIndex = 1;
                    ShowPopup();
                    break;

                default:
                    break;
            }
        }

        protected override void Refresh(bool resetCache)
        {
            base.Refresh(resetCache);
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

        private void efMultiColumnCombobox_Leave(object sender, EventArgs e)
        {
            var ef = FindForm() as efBaseForm;
            if (ef != null)
            {
                if (!Properties.ReadOnly) { ef.ValidationProvider.Validate(this); }
            }
        }
    }
}
