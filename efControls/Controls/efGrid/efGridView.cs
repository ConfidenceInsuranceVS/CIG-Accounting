using DevExpress.Utils;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace efControls
{
    public class efGridView : GridView
    {
        #region xProperties
        [Category("xProperties"), Browsable(true)]
        public bool VisibleAutoFilterRow { get; set; }

        [Category("xProperties"), Browsable(true)]
        public bool VisibleGroupPanel { get; set; }

        [Category("xProperties"), Browsable(true)]
        public bool VisibleIndicator { get; set; }

        [Category("xProperties"), Browsable(true)]
        public bool HighLightFocusedRow { get; set; }

        [Category("xProperties"), Browsable(true)]
        public efDataForm ParentForm { get; set; }
        #endregion

        public efGridView() : this(null)
        {
            ShowingEditor += efGridView_ShowingEditor;
            FocusedRowChanged += efGridView_FocusedRowChanged;
            EditFormPrepared += EfGridView_EditFormPrepared;

            OptionsBehavior.AutoExpandAllGroups = true;
            OptionsBehavior.Editable = false;
            //
            OptionsMenu.EnableColumnMenu = false;
            OptionsMenu.EnableFooterMenu = false;
            OptionsMenu.EnableGroupPanelMenu = false;
            //
            OptionsView.EnableAppearanceEvenRow = true;
            OptionsView.EnableAppearanceOddRow = false;
            OptionsView.ShowHorizontalLines = DefaultBoolean.False;
            OptionsView.ColumnAutoWidth = false;
            OptionsView.ShowButtonMode = ShowButtonModeEnum.Default;
            OptionsView.ShowIndicator = false;
            OptionsView.ShowGroupPanel = false;
            OptionsView.ShowAutoFilterRow = false;
            OptionsView.NewItemRowPosition = NewItemRowPosition.None;
            //
            OptionsEditForm.ActionOnModifiedRowChange = EditFormModifiedAction.Nothing;
            OptionsEditForm.ShowOnDoubleClick = DefaultBoolean.False;
            OptionsEditForm.ShowOnEnterKey = DefaultBoolean.False;
            OptionsEditForm.ShowOnF2Key = DefaultBoolean.False;
            OptionsEditForm.ShowUpdateCancelPanel = DefaultBoolean.False;
            //
            OptionsFind.AllowFindPanel = false;
            //
            OptionsNavigation.EnterMoveNextColumn = true;
            //
            OptionsCustomization.AllowColumnMoving = true;
            //
            VertScrollVisibility = ScrollVisibility.Always;
            //
            HighLightFocusedRow = true;
        }
        private void EfGridView_EditFormPrepared(object sender, EditFormPreparedEventArgs e)
        {
            foreach (efGridColumn col in Columns)
            {
                if (col.EditDisabled)
                {
                    if (ParentForm.xState == Enums.State.New)
                        e.BindableControls[col].Enabled = true;
                    else
                        e.BindableControls[col].Enabled = false;
                }
                else if (col.AlwaysDisabled)
                {
                    e.BindableControls[col].Enabled = false;
                }
            }
        }
        public efGridView(GridControl gc) : base(gc)
        {
        }

        #region Overrides
        protected override void OnEndInit()
        {
            base.OnEndInit();

            OptionsSelection.EnableAppearanceFocusedRow = HighLightFocusedRow;
            OptionsView.ShowIndicator = VisibleIndicator;
            OptionsView.ShowGroupPanel = VisibleGroupPanel;
            OptionsView.ShowAutoFilterRow = VisibleAutoFilterRow;
            OptionsBehavior.Editable = OptionsBehavior.ReadOnly = true;
        }
        protected override string ViewName { get { return "efGridView"; } }
        protected override GridColumnCollection CreateColumnCollection() { return new efGridColumnCollection(this); }
        #endregion
        private void efGridView_ShowingEditor(object sender, CancelEventArgs e)
        {
            var pForm = (efBaseForm)((efGridControl)GridControl).FindForm();
            if (pForm == null) { return; }
            if (pForm != null && pForm.xState == Enums.State.None) { return; }

            if (pForm.xState != Enums.State.None) { OptionsCustomization.AllowSort = OptionsBehavior.ReadOnly; }
        }
        private void efGridView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            if (e.FocusedRowHandle < 0 | e.PrevFocusedRowHandle == e.FocusedRowHandle) { return; }
            if (IsRowVisible(e.FocusedRowHandle) == (RowVisibleState.Hidden | RowVisibleState.Partially)) { MakeRowVisible(e.FocusedRowHandle); }
        }
        public virtual void Refresh()
        {
            OptionsBehavior.ReadOnly = Functions.setControlState(((efGridControl)GridControl).DefaultState, ParentForm.xState);
            //
            OptionsCustomization.AllowSort = OptionsBehavior.ReadOnly;

            if (VisibleAutoFilterRow)
            {
                if (!OptionsBehavior.ReadOnly)
                {
                    ClearColumnsFilter();
                    OptionsView.ShowAutoFilterRow = false;
                }
                else
                    OptionsView.ShowAutoFilterRow = true;
            }

            foreach (efGridColumn col in Columns)
            {
                if (col.AlwaysDisabled)
                {
                    col.OptionsColumn.ReadOnly = true;
                    col.OptionsColumn.AllowEdit = false;
                }
                col.OptionsColumn.AllowSort = OptionsBehavior.ReadOnly ? DefaultBoolean.True : DefaultBoolean.False;
            }
            UpdateCurrentRow();
        }
    }
}