using DevExpress.XtraGrid.Views.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraGrid.Columns;

namespace efControls
{
    public partial class efGridViewSearch : efGridView
    {
        public efGridViewSearch()
        {
            InitializeComponent();

            FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFullFocus;
            //
            OptionsFilter.UseNewCustomFilterDialog = true;
            OptionsFilter.AllowFilterEditor = true;
            //
            OptionsBehavior.ReadOnly = true;
            OptionsBehavior.Editable = false;
            //
            OptionsView.ShowIndicator = false;
            OptionsView.ShowGroupPanel = false;
            OptionsView.ColumnAutoWidth = true;
            OptionsView.ShowColumnHeaders = false;
            OptionsView.ShowDetailButtons = false;
            OptionsView.ShowAutoFilterRow = true;
            OptionsView.AnimationType = GridAnimationType.NeverAnimate;
            OptionsView.EnableAppearanceEvenRow = true;
            OptionsView.ShowFilterPanelMode = ShowFilterPanelMode.Default;
            //
            OptionsCustomization.AllowFilter = true;
            OptionsCustomization.AllowColumnMoving = false;
            OptionsCustomization.AllowColumnResizing = false;
            //
            OptionsNavigation.AutoFocusNewRow = true;
            //
            OptionsSelection.EnableAppearanceFocusedCell = false; 
            //
            OptionsDetail.EnableMasterViewMode = false;
            //
            OptionsMenu.EnableColumnMenu = false;
            OptionsMenu.EnableFooterMenu = false;
            OptionsMenu.EnableGroupPanelMenu = false;
            // 
            ShowingEditor += EfGridViewSearch_ShowingEditor;
        }

        private void EfGridViewSearch_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
        }

        protected override void OnColumnAdded(GridColumn column)
        {
            base.OnColumnAdded(column);
            column.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
        }
        public override void Refresh()
        {
            //OptionsView.ShowAutoFilterRow = OptionsBehavior.ReadOnly ? VisibleAutoFilterRow : false;
            //if (!OptionsBehavior.ReadOnly) { ActiveFilter.Clear(); }
            //base.Refresh(frm);
        }
    }
}
