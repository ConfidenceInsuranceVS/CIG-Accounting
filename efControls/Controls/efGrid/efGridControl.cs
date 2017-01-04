using System;
using System.Linq;
using System.Drawing;
using System.ComponentModel;
using System.Collections.Generic;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Registrator;
using DevExpress.XtraGrid.Views.Base;

namespace efControls
{
    [ToolboxItem(true), ToolboxBitmap(typeof(GridControl))]
    public class efGridControl : GridControl
    {
        #region xProperties
        [Category("xProperties"), Browsable(true)]
        public bool EmbeddedNavigatorHideButtons { get; set; }

        [Category("xProperties"), Browsable(true)]
        public Enums.ControlState DefaultState { get; set; }
        #endregion

        public efGridControl() : base()
        {
            ProcessGridKey += EfGridControl_ProcessGridKey;
        }

        private void EfGridControl_ProcessGridKey(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (Name.ToUpper() != "GCSEARCH") { return; }
            
            var gv = (efGridView)MainView;
            if (gv.Name.ToUpper() != "GVSEARCH") { return; }
            if (gv.FocusedRowHandle != efGridControl.AutoFilterRowHandle) { return; }
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                gv.FocusedRowHandle = 0;
                e.Handled = true;
            }
        }

        protected override void RegisterAvailableViewsCore(InfoCollection collection)
        {
            base.RegisterAvailableViewsCore(collection);
            collection.Add(new efGridViewInfoRegistrator());
        }
        protected override BaseView CreateDefaultView() { return CreateView("efGridView"); }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            //
            if (base.DesignMode) { return; }

            if (UseEmbeddedNavigator == true)
                EmbeddedNavigator.Buttons.Append.Visible = EmbeddedNavigator.Buttons.CancelEdit.Visible =
                    EmbeddedNavigator.Buttons.EndEdit.Visible = EmbeddedNavigator.Buttons.Remove.Visible =
                        EmbeddedNavigator.Buttons.Edit.Visible = !EmbeddedNavigatorHideButtons;
        }
        public override void Refresh()
        {
            base.Refresh();
            try
            {
                foreach (efGridView v in Views)
                {
                    if (v.ParentForm == null) { v.ParentForm = (efDataForm)FindForm(); }
                    if (v.GetType() == typeof(efGridView)) { v.Refresh(); }
                }
            }
            catch (Exception)
            {
            }
        }
    }
}
