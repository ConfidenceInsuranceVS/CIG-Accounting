using System;
using System.Collections.Generic;
using DevExpress.XtraReports.UI;
using System.ComponentModel;

namespace efControls
{
    public partial class efReportLabel : XRLabel
    {
        public efReportLabel()
        {
            InitializeComponent();
            TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            WordWrap = false;
            CanGrow = true;
        }

        [Category("xProperties"),
        Browsable(true)]
        public Enums.DisplayType DisplayType { get; set; }

        [Category("xProperties"),
        Browsable(true)]
        public bool addDoubleDots { get; set; }

        [Category("xProperties"),
        Browsable(true)]
        public int paddingSize { get; set; }

        [Category("xProperties"),
        Browsable(true)]
        public bool isBold { get; set; }

        protected override void InitializeScripts()
        {
            if (addDoubleDots)
            {
                Text = Text.PadRight(paddingSize, ' ') + ":";
            }
            Font = new System.Drawing.Font("Courier New", 9, isBold ? System.Drawing.FontStyle.Bold : System.Drawing.FontStyle.Regular);
        }
    }
}
