using System;
using System.Collections.Generic;
using System.Linq;
using DevExpress.XtraNavBar;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efNavBarControl : NavBarControl
    {
        public efNavBarControl()
        {
            InitializeComponent();

            OptionsNavPane.ShowExpandButton = false;
            OptionsNavPane.ShowGroupImageInHeader = true;
            OptionsNavPane.ShowOverflowButton = false;
            OptionsNavPane.ShowOverflowPanel = false;
            PaintStyleKind = NavBarViewKind.NavigationPane;
        }

        
    }
}
