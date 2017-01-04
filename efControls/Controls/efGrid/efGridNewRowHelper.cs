using System;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;

namespace efControls
{
    public class efGridNewRowHelper
    {
        private readonly efGridView _View;
        private readonly efDataForm _Form;
        public efGridNewRowHelper(efDataForm form, efGridView view)
        {
            _View = view;
            _Form = form;
            view.GridControl.EditorKeyDown += GridControl_EditorKeyDown;
            view.GridControl.KeyDown += new KeyEventHandler(GridControl_KeyDown);
        }

        void GridControl_KeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = OnKeyDown(e.KeyValue, e.Modifiers);
        }
        void GridControl_EditorKeyDown(object sender, KeyEventArgs e)
        {
            e.Handled = OnKeyDown(e.KeyValue, e.Modifiers);
        }
        private bool OnKeyDown(int keyCode, Keys modifiers)
        {
            if (_View.FocusedColumn.VisibleIndex == _View.VisibleColumns.Count - 1)
            {
                if (_View.FocusedRowHandle == _View.RowCount - 1)
                {
                    if (modifiers == Keys.None & keyCode == 13)
                        _Form.onFormAddNewRow(_View);
                }
            }
            return false;
        }
    }
}
