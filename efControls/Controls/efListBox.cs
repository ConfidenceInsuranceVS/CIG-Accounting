using System;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efListBox : ListBoxControl
    {
        public efListBox()
        {
            InitializeComponent();
            StyleController = App.styleController;
        }
    }
}
