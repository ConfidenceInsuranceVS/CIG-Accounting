using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efControlNavigator : ControlNavigator
    {
        #region xProperties
        [Category("xProperties"), Browsable(true)]
        public bool showButtons { get; set; }

        [Category("xProperties"), Browsable(true)]
        public bool showPager { get; set; }

        [Category("xProperties"), Browsable(true)]
        public bool showNavigator { get; set; }

        [Category("xProperties"), Browsable(true)]
        public bool showText { get; set; }
        #endregion
        public efControlNavigator()
        {
            showNavigator = showText = true;
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();

            Buttons.Append.Visible = Buttons.CancelEdit.Visible = Buttons.Edit.Visible = Buttons.Remove.Visible = Buttons.EndEdit.Visible = showButtons;
            Buttons.NextPage.Visible = Buttons.PrevPage.Visible = showPager;
            Buttons.First.Visible = Buttons.Prev.Visible = Buttons.Next.Visible = Buttons.Last.Visible = showNavigator;
            TextLocation = showText ? NavigatorButtonsTextLocation.Center : NavigatorButtonsTextLocation.None;


        }
    }
}
