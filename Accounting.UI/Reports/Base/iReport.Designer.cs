namespace Accounting
{
    partial class iReport
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
            this.components = new System.ComponentModel.Container();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
            this.lblCriteria = new DevExpress.XtraReports.UI.XRLabel();
            this.lblTitle = new DevExpress.XtraReports.UI.XRLabel();
            this.lblCompany = new DevExpress.XtraReports.UI.XRLabel();
            this.lblInfo = new DevExpress.XtraReports.UI.XRLabel();
            this.PageHeader = new DevExpress.XtraReports.UI.PageHeaderBand();
            this.ReportFooter = new DevExpress.XtraReports.UI.ReportFooterBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.lblPageInfo = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pCompany = new DevExpress.XtraReports.Parameters.Parameter();
            this.pTitle = new DevExpress.XtraReports.Parameters.Parameter();
            this.pCriteria = new DevExpress.XtraReports.Parameters.Parameter();
            this.bsReport = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Dpi = 100F;
            this.Detail.HeightF = 26.04167F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Dpi = 100F;
            this.TopMargin.HeightF = 25F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.Dpi = 100F;
            this.BottomMargin.HeightF = 25F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // ReportHeader
            // 
            this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblCriteria,
            this.lblTitle,
            this.lblCompany,
            this.lblInfo});
            this.ReportHeader.Dpi = 100F;
            this.ReportHeader.HeightF = 78.125F;
            this.ReportHeader.Name = "ReportHeader";
            // 
            // lblCriteria
            // 
            this.lblCriteria.AutoWidth = true;
            this.lblCriteria.Dpi = 100F;
            this.lblCriteria.LocationFloat = new DevExpress.Utils.PointFloat(0F, 54.16667F);
            this.lblCriteria.Multiline = true;
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCriteria.SizeF = new System.Drawing.SizeF(805.0001F, 21.25F);
            this.lblCriteria.StylePriority.UseFont = false;
            this.lblCriteria.StylePriority.UseTextAlignment = false;
            this.lblCriteria.Text = "lblCriteria";
            this.lblCriteria.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Right;
            this.lblTitle.Dpi = 100F;
            this.lblTitle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.lblTitle.LocationFloat = new DevExpress.Utils.PointFloat(418.375F, 0F);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblTitle.SizeF = new System.Drawing.SizeF(386.6251F, 43.45834F);
            this.lblTitle.StylePriority.UseBorders = false;
            this.lblTitle.StylePriority.UseFont = false;
            this.lblTitle.StylePriority.UseTextAlignment = false;
            this.lblTitle.Text = "Report Title";
            this.lblTitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            // 
            // lblCompany
            // 
            this.lblCompany.AutoWidth = true;
            this.lblCompany.Dpi = 100F;
            this.lblCompany.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.lblCompany.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.lblCompany.Name = "lblCompany";
            this.lblCompany.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblCompany.SizeF = new System.Drawing.SizeF(384.375F, 26.45834F);
            this.lblCompany.StylePriority.UseFont = false;
            this.lblCompany.StylePriority.UseTextAlignment = false;
            this.lblCompany.Text = "Company Name";
            this.lblCompany.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // lblInfo
            // 
            this.lblInfo.CanGrow = false;
            this.lblInfo.Dpi = 100F;
            this.lblInfo.Font = new System.Drawing.Font("Courier New", 6F);
            this.lblInfo.LocationFloat = new DevExpress.Utils.PointFloat(0F, 26.45834F);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblInfo.SizeF = new System.Drawing.SizeF(384.375F, 17F);
            this.lblInfo.StylePriority.UseBorders = false;
            this.lblInfo.StylePriority.UseFont = false;
            this.lblInfo.StylePriority.UseTextAlignment = false;
            this.lblInfo.Text = "lblInfo";
            this.lblInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            this.lblInfo.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.lblInfo_BeforePrint);
            // 
            // PageHeader
            // 
            this.PageHeader.Dpi = 100F;
            this.PageHeader.HeightF = 51.04167F;
            this.PageHeader.Name = "PageHeader";
            // 
            // ReportFooter
            // 
            this.ReportFooter.Dpi = 100F;
            this.ReportFooter.HeightF = 48.95833F;
            this.ReportFooter.Name = "ReportFooter";
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.lblPageInfo});
            this.PageFooter.Dpi = 100F;
            this.PageFooter.HeightF = 30.20833F;
            this.PageFooter.Name = "PageFooter";
            // 
            // lblPageInfo
            // 
            this.lblPageInfo.AnchorHorizontal = DevExpress.XtraReports.UI.HorizontalAnchorStyles.Left;
            this.lblPageInfo.AnchorVertical = DevExpress.XtraReports.UI.VerticalAnchorStyles.Bottom;
            this.lblPageInfo.Dpi = 100F;
            this.lblPageInfo.Font = new System.Drawing.Font("Courier New", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPageInfo.LocationFloat = new DevExpress.Utils.PointFloat(2.999969F, 13.20833F);
            this.lblPageInfo.Name = "lblPageInfo";
            this.lblPageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.lblPageInfo.SizeF = new System.Drawing.SizeF(100F, 17F);
            this.lblPageInfo.StylePriority.UseFont = false;
            this.lblPageInfo.StylePriority.UseTextAlignment = false;
            this.lblPageInfo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // pCompany
            // 
            this.pCompany.Name = "pCompany";
            // 
            // pTitle
            // 
            this.pTitle.Name = "pTitle";
            // 
            // pCriteria
            // 
            this.pCriteria.Name = "pCriteria";
            // 
            // iReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.PageHeader,
            this.ReportFooter,
            this.PageFooter});
            this.DataSource = this.bsReport;
            this.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margins = new System.Drawing.Printing.Margins(9, 10, 25, 25);
            this.PageHeight = 1169;
            this.PageWidth = 827;
            this.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Parameters.AddRange(new DevExpress.XtraReports.Parameters.Parameter[] {
            this.pCompany,
            this.pTitle,
            this.pCriteria});
            this.ShowPrintMarginsWarning = false;
            this.Version = "16.1";
            ((System.ComponentModel.ISupportInitialize)(this.bsReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        public DevExpress.XtraReports.UI.XRLabel lblCompany;
        protected DevExpress.XtraReports.UI.DetailBand Detail;
        protected DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        protected DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        protected DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
        protected DevExpress.XtraReports.UI.PageHeaderBand PageHeader;
        protected DevExpress.XtraReports.UI.ReportFooterBand ReportFooter;
        protected DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        public DevExpress.XtraReports.UI.XRLabel lblCriteria;
        public DevExpress.XtraReports.UI.XRLabel lblTitle;
        private DevExpress.XtraReports.Parameters.Parameter pCompany;
        private DevExpress.XtraReports.Parameters.Parameter pTitle;
        private DevExpress.XtraReports.Parameters.Parameter pCriteria;
        public System.Windows.Forms.BindingSource bsReport;
        public DevExpress.XtraReports.UI.XRPageInfo lblPageInfo;
        public DevExpress.XtraReports.UI.XRLabel lblInfo;
    }
}
