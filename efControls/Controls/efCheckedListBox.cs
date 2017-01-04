using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efCheckedListBox : CheckedListBoxControl
    {
        public efCheckedListBox()
        {
            InitializeComponent();
            StyleController = App.styleController;
        }

        protected override void OnCreateControl()
        {
            MultiColumn = true;
            CheckOnClick = true;
            IncrementalSearch = true;

            base.OnCreateControl();
        }
    }
}
