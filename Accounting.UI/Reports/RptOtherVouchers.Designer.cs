namespace Accounting.Reports
{
    partial class RptOtherVouchers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.xrLabel20 = new DevExpress.XtraReports.UI.XRLabel();
            this.formattingRule1 = new DevExpress.XtraReports.UI.FormattingRule();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.efReportLabel1 = new efControls.efReportLabel();
            this.efReportLabel2 = new efControls.efReportLabel();
            this.efReportLabel3 = new efControls.efReportLabel();
            this.efReportLabel4 = new efControls.efReportLabel();
            this.efReportLabel5 = new efControls.efReportLabel();
            this.efReportLabel6 = new efControls.efReportLabel();
            this.efReportLabel7 = new efControls.efReportLabel();
            this.efReportLabel8 = new efControls.efReportLabel();
            this.efReportLabel9 = new efControls.efReportLabel();
            this.efReportLabel10 = new efControls.efReportLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // lblCompany
            // 
            this.lblCompany.StylePriority.UseFont = false;
            this.lblCompany.StylePriority.UseTextAlignment = false;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.efReportLabel8,
            this.efReportLabel7,
            this.efReportLabel5,
            this.efReportLabel6,
            this.efReportLabel4,
            this.efReportLabel3,
            this.efReportLabel2,
            this.efReportLabel1});
            this.Detail.HeightF = 114.5833F;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel20});
            this.ReportHeader.HeightF = 66.66666F;
            this.ReportHeader.Controls.SetChildIndex(this.lblInfo, 0);
            this.ReportHeader.Controls.SetChildIndex(this.lblCompany, 0);
            this.ReportHeader.Controls.SetChildIndex(this.lblTitle, 0);
            this.ReportHeader.Controls.SetChildIndex(this.lblCriteria, 0);
            this.ReportHeader.Controls.SetChildIndex(this.xrLabel20, 0);
            // 
            // PageHeader
            // 
            this.PageHeader.BorderColor = System.Drawing.Color.Silver;
            this.PageHeader.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.PageHeader.BorderWidth = 6F;
            this.PageHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.PageHeader.HeightF = 39.99999F;
            this.PageHeader.StylePriority.UseBorderColor = false;
            this.PageHeader.StylePriority.UseBorders = false;
            this.PageHeader.StylePriority.UseBorderWidth = false;
            // 
            // ReportFooter
            // 
            this.ReportFooter.HeightF = 0F;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.efReportLabel10,
            this.efReportLabel9});
            this.PageFooter.HeightF = 120.8333F;
            this.PageFooter.Controls.SetChildIndex(this.lblPageInfo, 0);
            this.PageFooter.Controls.SetChildIndex(this.efReportLabel9, 0);
            this.PageFooter.Controls.SetChildIndex(this.efReportLabel10, 0);
            // 
            // lblCriteria
            // 
            this.lblCriteria.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteria.LocationFloat = new DevExpress.Utils.PointFloat(0F, 43.45834F);
            this.lblCriteria.SizeF = new System.Drawing.SizeF(306.7578F, 21.25F);
            this.lblCriteria.StylePriority.UseFont = false;
            this.lblCriteria.StylePriority.UseTextAlignment = false;
            // 
            // lblTitle
            // 
            this.lblTitle.LocationFloat = new DevExpress.Utils.PointFloat(409.3749F, 0F);
            this.lblTitle.StylePriority.UseBorders = false;
            this.lblTitle.StylePriority.UseFont = false;
            this.lblTitle.StylePriority.UseTextAlignment = false;
            // 
            // bsReport
            // 
            this.bsReport.DataSource = typeof(Accounting.Journalchild);
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(2.999973F, 13.20833F);
            this.lblPageInfo.SizeF = new System.Drawing.SizeF(35.41668F, 17F);
            this.lblPageInfo.StylePriority.UseFont = false;
            this.lblPageInfo.StylePriority.UseTextAlignment = false;
            this.lblPageInfo.Visible = false;
            // 
            // lblInfo
            // 
            this.lblInfo.StylePriority.UseBorders = false;
            this.lblInfo.StylePriority.UseFont = false;
            this.lblInfo.StylePriority.UseTextAlignment = false;
            // 
            // xrLabel20
            // 
            this.xrLabel20.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Journalparent.Jvdate", "{0:d MMMM, yyyy}")});
            this.xrLabel20.Dpi = 100F;
            this.xrLabel20.LocationFloat = new DevExpress.Utils.PointFloat(612.375F, 48.70834F);
            this.xrLabel20.Name = "xrLabel20";
            this.xrLabel20.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel20.SizeF = new System.Drawing.SizeF(176.625F, 16F);
            this.xrLabel20.StylePriority.UseTextAlignment = false;
            this.xrLabel20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // formattingRule1
            // 
            this.formattingRule1.Name = "formattingRule1";
            // 
            // xrPanel1
            // 
            this.xrPanel1.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Double;
            this.xrPanel1.Borders = ((DevExpress.XtraPrinting.BorderSide)((((DevExpress.XtraPrinting.BorderSide.Left | DevExpress.XtraPrinting.BorderSide.Top) 
            | DevExpress.XtraPrinting.BorderSide.Right) 
            | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.xrPanel1.BorderWidth = 6F;
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1});
            this.xrPanel1.Dpi = 100F;
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(582.8333F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(206.1667F, 38.70833F);
            this.xrPanel1.StylePriority.UseBorderDashStyle = false;
            this.xrPanel1.StylePriority.UseBorders = false;
            this.xrPanel1.StylePriority.UseBorderWidth = false;
            // 
            // xrLabel1
            // 
            this.xrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Amount")});
            this.xrLabel1.Dpi = 100F;
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10F, 8.708318F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(188.75F, 23F);
            this.xrLabel1.StylePriority.UseBorders = false;
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "xrLabel1";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.xrLabel1.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.xrLabel1_BeforePrint);
            // 
            // efReportLabel1
            // 
            this.efReportLabel1.addDoubleDots = true;
            this.efReportLabel1.DisplayType = efControls.Enums.DisplayType.Default;
            this.efReportLabel1.Dpi = 100F;
            this.efReportLabel1.isBold = false;
            this.efReportLabel1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.efReportLabel1.Name = "efReportLabel1";
            this.efReportLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.efReportLabel1.paddingSize = 20;
            this.efReportLabel1.SizeF = new System.Drawing.SizeF(139.5833F, 23F);
            this.efReportLabel1.Text = "Received From";
            this.efReportLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.efReportLabel1.WordWrap = false;
            // 
            // efReportLabel2
            // 
            this.efReportLabel2.addDoubleDots = true;
            this.efReportLabel2.DisplayType = efControls.Enums.DisplayType.Default;
            this.efReportLabel2.Dpi = 100F;
            this.efReportLabel2.isBold = false;
            this.efReportLabel2.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 36.00001F);
            this.efReportLabel2.Name = "efReportLabel2";
            this.efReportLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.efReportLabel2.paddingSize = 20;
            this.efReportLabel2.SizeF = new System.Drawing.SizeF(139.5833F, 23F);
            this.efReportLabel2.Text = "The amount of";
            this.efReportLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.efReportLabel2.WordWrap = false;
            // 
            // efReportLabel3
            // 
            this.efReportLabel3.addDoubleDots = false;
            this.efReportLabel3.DisplayType = efControls.Enums.DisplayType.Default;
            this.efReportLabel3.Dpi = 100F;
            this.efReportLabel3.isBold = false;
            this.efReportLabel3.LocationFloat = new DevExpress.Utils.PointFloat(160.4167F, 10.00001F);
            this.efReportLabel3.Name = "efReportLabel3";
            this.efReportLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.efReportLabel3.paddingSize = 0;
            this.efReportLabel3.SizeF = new System.Drawing.SizeF(592.7083F, 23F);
            this.efReportLabel3.Text = "efReportLabel3";
            this.efReportLabel3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.efReportLabel3.WordWrap = false;
            this.efReportLabel3.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.efReportLabel3_BeforePrint);
            // 
            // efReportLabel4
            // 
            this.efReportLabel4.addDoubleDots = false;
            this.efReportLabel4.DisplayType = efControls.Enums.DisplayType.Default;
            this.efReportLabel4.Dpi = 100F;
            this.efReportLabel4.isBold = false;
            this.efReportLabel4.LocationFloat = new DevExpress.Utils.PointFloat(160.4167F, 36.00001F);
            this.efReportLabel4.Multiline = true;
            this.efReportLabel4.Name = "efReportLabel4";
            this.efReportLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.efReportLabel4.paddingSize = 0;
            this.efReportLabel4.SizeF = new System.Drawing.SizeF(592.7083F, 23F);
            this.efReportLabel4.Text = "efReportLabel3";
            this.efReportLabel4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.efReportLabel4.WordWrap = false;
            this.efReportLabel4.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.efReportLabel4_BeforePrint);
            // 
            // efReportLabel5
            // 
            this.efReportLabel5.addDoubleDots = true;
            this.efReportLabel5.DisplayType = efControls.Enums.DisplayType.Default;
            this.efReportLabel5.Dpi = 100F;
            this.efReportLabel5.isBold = false;
            this.efReportLabel5.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 61.99999F);
            this.efReportLabel5.Name = "efReportLabel5";
            this.efReportLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.efReportLabel5.paddingSize = 20;
            this.efReportLabel5.SizeF = new System.Drawing.SizeF(139.5833F, 23F);
            this.efReportLabel5.Text = "Being";
            this.efReportLabel5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.efReportLabel5.WordWrap = false;
            // 
            // efReportLabel6
            // 
            this.efReportLabel6.addDoubleDots = false;
            this.efReportLabel6.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Description")});
            this.efReportLabel6.DisplayType = efControls.Enums.DisplayType.Default;
            this.efReportLabel6.Dpi = 100F;
            this.efReportLabel6.isBold = false;
            this.efReportLabel6.LocationFloat = new DevExpress.Utils.PointFloat(160.4166F, 61.99999F);
            this.efReportLabel6.Name = "efReportLabel6";
            this.efReportLabel6.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.efReportLabel6.paddingSize = 0;
            this.efReportLabel6.SizeF = new System.Drawing.SizeF(592.7083F, 23F);
            this.efReportLabel6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.efReportLabel6.WordWrap = false;
            // 
            // efReportLabel7
            // 
            this.efReportLabel7.addDoubleDots = false;
            this.efReportLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Journalparent.Details")});
            this.efReportLabel7.DisplayType = efControls.Enums.DisplayType.Default;
            this.efReportLabel7.Dpi = 100F;
            this.efReportLabel7.isBold = false;
            this.efReportLabel7.LocationFloat = new DevExpress.Utils.PointFloat(160.4167F, 87.99999F);
            this.efReportLabel7.Multiline = true;
            this.efReportLabel7.Name = "efReportLabel7";
            this.efReportLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.efReportLabel7.paddingSize = 0;
            this.efReportLabel7.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.efReportLabel7.SizeF = new System.Drawing.SizeF(592.7083F, 23F);
            this.efReportLabel7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.efReportLabel7.WordWrap = false;
            this.efReportLabel7.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.efReportLabel7_BeforePrint);
            // 
            // efReportLabel8
            // 
            this.efReportLabel8.addDoubleDots = true;
            this.efReportLabel8.DisplayType = efControls.Enums.DisplayType.Default;
            this.efReportLabel8.Dpi = 100F;
            this.efReportLabel8.isBold = false;
            this.efReportLabel8.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 88F);
            this.efReportLabel8.Name = "efReportLabel8";
            this.efReportLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.efReportLabel8.paddingSize = 20;
            this.efReportLabel8.ProcessNullValues = DevExpress.XtraReports.UI.ValueSuppressType.SuppressAndShrink;
            this.efReportLabel8.SizeF = new System.Drawing.SizeF(139.5833F, 23F);
            this.efReportLabel8.Text = "Details";
            this.efReportLabel8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.efReportLabel8.WordWrap = false;
            this.efReportLabel8.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.efReportLabel8_BeforePrint);
            // 
            // efReportLabel9
            // 
            this.efReportLabel9.addDoubleDots = false;
            this.efReportLabel9.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.efReportLabel9.DisplayType = efControls.Enums.DisplayType.Default;
            this.efReportLabel9.Dpi = 100F;
            this.efReportLabel9.isBold = false;
            this.efReportLabel9.LocationFloat = new DevExpress.Utils.PointFloat(49.58334F, 9.999974F);
            this.efReportLabel9.Name = "efReportLabel9";
            this.efReportLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.efReportLabel9.paddingSize = 0;
            this.efReportLabel9.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.efReportLabel9.StylePriority.UseBorders = false;
            this.efReportLabel9.StylePriority.UseTextAlignment = false;
            this.efReportLabel9.Text = "Accountant";
            this.efReportLabel9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.efReportLabel9.WordWrap = false;
            // 
            // efReportLabel10
            // 
            this.efReportLabel10.addDoubleDots = false;
            this.efReportLabel10.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.efReportLabel10.DisplayType = efControls.Enums.DisplayType.Default;
            this.efReportLabel10.Dpi = 100F;
            this.efReportLabel10.isBold = false;
            this.efReportLabel10.LocationFloat = new DevExpress.Utils.PointFloat(615.375F, 9.999974F);
            this.efReportLabel10.Name = "efReportLabel10";
            this.efReportLabel10.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.efReportLabel10.paddingSize = 0;
            this.efReportLabel10.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.efReportLabel10.StylePriority.UseBorders = false;
            this.efReportLabel10.StylePriority.UseTextAlignment = false;
            this.efReportLabel10.Text = "Cashier";
            this.efReportLabel10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            this.efReportLabel10.WordWrap = false;
            // 
            // RptOtherVouchers
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter,
            this.PageFooter});
            this.FormattingRuleSheet.AddRange(new DevExpress.XtraReports.UI.FormattingRule[] {
            this.formattingRule1});
            this.Margins = new System.Drawing.Printing.Margins(14, 17, 25, 25);
            this.Version = "16.1";
            ((System.ComponentModel.ISupportInitialize)(this.bsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.XRLabel xrLabel20;
        private DevExpress.XtraReports.UI.FormattingRule formattingRule1;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private efControls.efReportLabel efReportLabel3;
        private efControls.efReportLabel efReportLabel2;
        private efControls.efReportLabel efReportLabel1;
        private efControls.efReportLabel efReportLabel4;
        private efControls.efReportLabel efReportLabel8;
        private efControls.efReportLabel efReportLabel7;
        private efControls.efReportLabel efReportLabel5;
        private efControls.efReportLabel efReportLabel6;
        private efControls.efReportLabel efReportLabel10;
        private efControls.efReportLabel efReportLabel9;

    }
}
