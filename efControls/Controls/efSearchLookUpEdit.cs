using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.ComponentModel;
using System.Drawing;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efSearchLookUpEdit : SearchLookUpEdit, IControl
    {
        static efSearchLookUpEdit()
        {
            RepositoryItemefSearchLookUpEdit.RegisterefSearchLookUpEdit();
        }

        public efSearchLookUpEdit()
        {
            DefaultState = Enums.ControlState.Default;
            EnterMoveNextControl = true;
            Properties.Enter += Properties_Enter;
            Properties.Leave += efSearchLookUpEdit_Leave;
            Properties.QueryPopUp += Properties_QueryPopUp;
            Properties.LookUpPopupForm.FindTextBox.KeyPress += FindTextBox_KeyPress;
            StyleController = App.styleController;
        }

        void Properties_Enter(object sender, EventArgs e)
        {
            SelectAll();
        }
        private void FindTextBox_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (e.KeyChar ==  (char)13)
            {
                //PopupSearchLookUpEditForm form = PopupForm;
                GridView gridView = Properties.View;
                if (gridView.RowCount > 0)
                {
                    EditValue = gridView.GetRowCellValue(0, Properties.ValueMember);
                    gridView.FocusedRowHandle = 0;
                    ClosePopup();
                }
            }
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemefSearchLookUpEdit.efSearchLookUpEditName;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemefSearchLookUpEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemefSearchLookUpEdit;
            }
        }

        protected override void Refresh(bool resetCache)
        {
            base.Refresh(resetCache);
            Enabled = true;

            var ef = FindForm() as efBaseForm;
            Properties.ReadOnly = Functions.setControlState(DefaultState, ef == null ? Enums.State.Edit : ef.xState);
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            Properties.View.OptionsView.ShowGroupPanel = false;
            Properties.View.OptionsView.ShowIndicator = false;
            Properties.View.OptionsView.EnableAppearanceOddRow = true;
            Properties.View.OptionsView.ShowAutoFilterRow = false;
            Properties.View.OptionsView.ShowColumnHeaders = true;
            Properties.View.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            //
            Properties.View.OptionsFilter.AllowFilterEditor = false;
            //
            Properties.View.OptionsFind.AllowFindPanel = false;
            Properties.View.OptionsFind.ShowClearButton = false;
            Properties.View.OptionsFind.ShowCloseButton = false;
            Properties.View.OptionsFind.ShowFindButton = false;
            //
            Properties.View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            Properties.View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            //
            Properties.View.OptionsCustomization.AllowColumnMoving = false;
            Properties.View.OptionsCustomization.AllowColumnResizing = false;
            Properties.View.OptionsCustomization.AllowFilter = false;
            Properties.View.OptionsCustomization.AllowRowSizing = false;
            //
            Properties.View.OptionsSelection.EnableAppearanceFocusedCell = false;
        }

        [Category("xProperties")]
        public Enums.ControlState DefaultState { get; set; }

        [Category("xProperties"), Browsable(true)]
        public int DropdownWidth { get; set; }

        private void efSearchLookUpEdit_Leave(object sender, EventArgs e)
        {
            var ef = FindForm() as efBaseForm;
            if (ef != null)
            {
                if (!Properties.ReadOnly) { ef.ValidationProvider.Validate(this); }
            }
        }

        void Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            SearchLookUpEdit editor = (SearchLookUpEdit)sender;
            RepositoryItemSearchLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(DropdownWidth == 0 ? editor.Width : DropdownWidth, properties.PopupFormSize.Height);
        }
    }
}
