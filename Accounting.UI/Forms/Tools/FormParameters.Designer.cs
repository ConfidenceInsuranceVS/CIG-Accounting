namespace Accounting
{
    partial class FormParameters
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormParameters));
            this.lcParameters = new efControls.efLayoutControl();
            this.btnRefresh = new efControls.efButton();
            this.formImages = new DevExpress.Utils.ImageCollection(this.components);
            this.cboAccountsPos = new Accounting.cboAccounts();
            this.cboAccountsPosView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cboAccountsNeg = new Accounting.cboAccounts();
            this.cboAccountsNegView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtDE = new efControls.efTextBox();
            this.txtEOY = new efControls.efTextBox();
            this.cmdExit = new efControls.efButton();
            this.cmdSave = new efControls.efButton();
            this.chkUserInfo = new efControls.efCheckBox();
            this.chkSubtitle = new efControls.efCheckBox();
            this.lcgParameters = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciSubTitle = new efControls.lci();
            this.lciSave = new efControls.lci();
            this.lciExit = new efControls.lci();
            this.lciEOY = new efControls.lci();
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.lciUserInfo = new efControls.lci();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.simpleSeparator3 = new DevExpress.XtraLayout.SimpleSeparator();
            this.lcgDE = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDE = new efControls.lci();
            this.lciNegatif = new efControls.lci();
            this.lciPositif = new efControls.lci();
            this.lciRefresh = new efControls.lci();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.txt1stLocal = new efControls.efTextBox();
            this.lci1stAmount = new efControls.lci();
            this.txt2ndLocal = new efControls.efTextBox();
            this.lci2ndAmount = new efControls.lci();
            this.lcgWarning = new DevExpress.XtraLayout.LayoutControlGroup();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcParameters)).BeginInit();
            this.lcParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountsPos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountsPosView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountsNeg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountsNegView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEOY.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUserInfo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubtitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgParameters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEOY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDE)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNegatif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPositif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt1stLocal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci1stAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt2ndLocal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci2ndAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgWarning)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // lcParameters
            // 
            this.lcParameters.Controls.Add(this.txt2ndLocal);
            this.lcParameters.Controls.Add(this.txt1stLocal);
            this.lcParameters.Controls.Add(this.btnRefresh);
            this.lcParameters.Controls.Add(this.cboAccountsPos);
            this.lcParameters.Controls.Add(this.cboAccountsNeg);
            this.lcParameters.Controls.Add(this.txtDE);
            this.lcParameters.Controls.Add(this.txtEOY);
            this.lcParameters.Controls.Add(this.cmdExit);
            this.lcParameters.Controls.Add(this.cmdSave);
            this.lcParameters.Controls.Add(this.chkUserInfo);
            this.lcParameters.Controls.Add(this.chkSubtitle);
            this.lcParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lcParameters.Location = new System.Drawing.Point(0, 0);
            this.lcParameters.Name = "lcParameters";
            this.lcParameters.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1114, 383, 250, 350);
            this.lcParameters.Root = this.lcgParameters;
            this.lcParameters.Size = new System.Drawing.Size(585, 257);
            this.lcParameters.TabIndex = 0;
            this.lcParameters.Text = "efLayoutControl1";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DefaultState = efControls.Enums.ControlState.Default;
            this.btnRefresh.HighLighted = false;
            this.btnRefresh.ImageIndex = 2;
            this.btnRefresh.ImageList = this.formImages;
            this.btnRefresh.Location = new System.Drawing.Point(15, 211);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(25, 31);
            this.btnRefresh.StyleController = this.lcParameters;
            this.btnRefresh.TabIndex = 12;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // formImages
            // 
            this.formImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("formImages.ImageStream")));
            this.formImages.InsertGalleryImage("export_16x16.png", "office2013/export/export_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/export/export_16x16.png"), 0);
            this.formImages.Images.SetKeyName(0, "export_16x16.png");
            this.formImages.InsertGalleryImage("loadfrom_16x16.png", "office2013/actions/loadfrom_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/loadfrom_16x16.png"), 1);
            this.formImages.Images.SetKeyName(1, "loadfrom_16x16.png");
            this.formImages.InsertGalleryImage("convert_16x16.png", "office2013/actions/convert_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/convert_16x16.png"), 2);
            this.formImages.Images.SetKeyName(2, "convert_16x16.png");
            // 
            // cboAccountsPos
            // 
            this.cboAccountsPos.bs = null;
            this.cboAccountsPos.DefaultState = efControls.Enums.ControlState.Default;
            this.cboAccountsPos.DropdownWidth = 0;
            this.cboAccountsPos.EnterMoveNextControl = true;
            this.cboAccountsPos.Location = new System.Drawing.Point(102, 180);
            this.cboAccountsPos.Name = "cboAccountsPos";
            this.cboAccountsPos.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboAccountsPos.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("cboAccountsPos.Properties.ContextImage")));
            this.cboAccountsPos.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.cboAccountsPos.Properties.NullText = "";
            this.cboAccountsPos.Properties.NullValuePrompt = "Select Account Or Leave Blank";
            this.cboAccountsPos.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboAccountsPos.Properties.PopupFormMinSize = new System.Drawing.Size(350, 200);
            this.cboAccountsPos.Properties.ValidateOnEnterKey = true;
            this.cboAccountsPos.Properties.View = this.cboAccountsPosView;
            this.cboAccountsPos.ShowAccountNumber = true;
            this.cboAccountsPos.ShowContextImage = true;
            this.cboAccountsPos.Size = new System.Drawing.Size(468, 20);
            this.cboAccountsPos.StartWith = null;
            this.cboAccountsPos.StyleController = this.lcParameters;
            this.cboAccountsPos.TabIndex = 11;
            this.cboAccountsPos.ToolTip = "...";
            this.cboAccountsPos.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cboAccountsPos.ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
            // 
            // cboAccountsPosView
            // 
            this.cboAccountsPosView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboAccountsPosView.Name = "cboAccountsPosView";
            this.cboAccountsPosView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountsPosView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountsPosView.OptionsCustomization.AllowColumnMoving = false;
            this.cboAccountsPosView.OptionsCustomization.AllowColumnResizing = false;
            this.cboAccountsPosView.OptionsCustomization.AllowFilter = false;
            this.cboAccountsPosView.OptionsFilter.AllowFilterEditor = false;
            this.cboAccountsPosView.OptionsFind.AllowFindPanel = false;
            this.cboAccountsPosView.OptionsFind.ShowClearButton = false;
            this.cboAccountsPosView.OptionsFind.ShowCloseButton = false;
            this.cboAccountsPosView.OptionsFind.ShowFindButton = false;
            this.cboAccountsPosView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboAccountsPosView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboAccountsPosView.OptionsView.EnableAppearanceOddRow = true;
            this.cboAccountsPosView.OptionsView.ShowAutoFilterRow = true;
            this.cboAccountsPosView.OptionsView.ShowGroupPanel = false;
            this.cboAccountsPosView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountsPosView.OptionsView.ShowIndicator = false;
            this.cboAccountsPosView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // cboAccountsNeg
            // 
            this.cboAccountsNeg.bs = null;
            this.cboAccountsNeg.DefaultState = efControls.Enums.ControlState.Default;
            this.cboAccountsNeg.DropdownWidth = 0;
            this.cboAccountsNeg.EnterMoveNextControl = true;
            this.cboAccountsNeg.Location = new System.Drawing.Point(102, 156);
            this.cboAccountsNeg.Name = "cboAccountsNeg";
            this.cboAccountsNeg.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboAccountsNeg.Properties.ContextImage = ((System.Drawing.Image)(resources.GetObject("cboAccountsNeg.Properties.ContextImage")));
            this.cboAccountsNeg.Properties.ContextImageAlignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.cboAccountsNeg.Properties.NullText = "";
            this.cboAccountsNeg.Properties.NullValuePrompt = "Select Account Or Leave Blank";
            this.cboAccountsNeg.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboAccountsNeg.Properties.PopupFormMinSize = new System.Drawing.Size(350, 200);
            this.cboAccountsNeg.Properties.ValidateOnEnterKey = true;
            this.cboAccountsNeg.Properties.View = this.cboAccountsNegView;
            this.cboAccountsNeg.ShowAccountNumber = true;
            this.cboAccountsNeg.ShowContextImage = true;
            this.cboAccountsNeg.Size = new System.Drawing.Size(468, 20);
            this.cboAccountsNeg.StartWith = null;
            this.cboAccountsNeg.StyleController = this.lcParameters;
            this.cboAccountsNeg.TabIndex = 10;
            this.cboAccountsNeg.ToolTip = "...";
            this.cboAccountsNeg.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cboAccountsNeg.ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
            // 
            // cboAccountsNegView
            // 
            this.cboAccountsNegView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboAccountsNegView.Name = "cboAccountsNegView";
            this.cboAccountsNegView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountsNegView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountsNegView.OptionsCustomization.AllowColumnMoving = false;
            this.cboAccountsNegView.OptionsCustomization.AllowColumnResizing = false;
            this.cboAccountsNegView.OptionsCustomization.AllowFilter = false;
            this.cboAccountsNegView.OptionsFilter.AllowFilterEditor = false;
            this.cboAccountsNegView.OptionsFind.AllowFindPanel = false;
            this.cboAccountsNegView.OptionsFind.ShowClearButton = false;
            this.cboAccountsNegView.OptionsFind.ShowCloseButton = false;
            this.cboAccountsNegView.OptionsFind.ShowFindButton = false;
            this.cboAccountsNegView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboAccountsNegView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboAccountsNegView.OptionsView.EnableAppearanceOddRow = true;
            this.cboAccountsNegView.OptionsView.ShowAutoFilterRow = true;
            this.cboAccountsNegView.OptionsView.ShowGroupPanel = false;
            this.cboAccountsNegView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountsNegView.OptionsView.ShowIndicator = false;
            this.cboAccountsNegView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // txtDE
            // 
            this.txtDE.AllowLeadingSpace = false;
            this.txtDE.DefaultState = efControls.Enums.ControlState.Default;
            this.txtDE.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtDE.EnterMoveNextControl = true;
            this.txtDE.Information = null;
            this.txtDE.Location = new System.Drawing.Point(102, 132);
            this.txtDE.Name = "txtDE";
            this.txtDE.Size = new System.Drawing.Size(468, 20);
            this.txtDE.StyleController = this.lcParameters;
            this.txtDE.TabIndex = 9;
            // 
            // txtEOY
            // 
            this.txtEOY.AllowLeadingSpace = false;
            this.txtEOY.DefaultState = efControls.Enums.ControlState.Default;
            this.txtEOY.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtEOY.EnterMoveNextControl = true;
            this.txtEOY.Information = null;
            this.txtEOY.Location = new System.Drawing.Point(99, 36);
            this.txtEOY.Name = "txtEOY";
            this.txtEOY.Size = new System.Drawing.Size(474, 20);
            this.txtEOY.StyleController = this.lcParameters;
            this.txtEOY.TabIndex = 8;
            // 
            // cmdExit
            // 
            this.cmdExit.DefaultState = efControls.Enums.ControlState.Default;
            this.cmdExit.HighLighted = false;
            this.cmdExit.ImageIndex = 1;
            this.cmdExit.ImageList = this.formImages;
            this.cmdExit.Location = new System.Drawing.Point(480, 211);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.Size = new System.Drawing.Size(90, 31);
            this.cmdExit.StyleController = this.lcParameters;
            this.cmdExit.TabIndex = 7;
            this.cmdExit.Text = "Exit";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.DefaultState = efControls.Enums.ControlState.Default;
            this.cmdSave.HighLighted = false;
            this.cmdSave.ImageIndex = 0;
            this.cmdSave.ImageList = this.formImages;
            this.cmdSave.Location = new System.Drawing.Point(380, 211);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(90, 31);
            this.cmdSave.StyleController = this.lcParameters;
            this.cmdSave.TabIndex = 6;
            this.cmdSave.Text = "Save";
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // chkUserInfo
            // 
            this.chkUserInfo.DefaultState = efControls.Enums.ControlState.Default;
            this.chkUserInfo.EnterMoveNextControl = true;
            this.chkUserInfo.HighLighted = false;
            this.chkUserInfo.Location = new System.Drawing.Point(294, 12);
            this.chkUserInfo.Name = "chkUserInfo";
            this.chkUserInfo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkUserInfo.Properties.Appearance.Options.UseBackColor = true;
            this.chkUserInfo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkUserInfo.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkUserInfo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkUserInfo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkUserInfo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkUserInfo.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkUserInfo.Properties.Caption = "Show User Info";
            this.chkUserInfo.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkUserInfo.Size = new System.Drawing.Size(279, 19);
            this.chkUserInfo.StyleController = this.lcParameters;
            this.chkUserInfo.TabIndex = 5;
            this.chkUserInfo.ValueType = efControls.Enums.ValueType.Boolean;
            this.chkUserInfo.CheckedChanged += new System.EventHandler(this.chkUserInfo_CheckedChanged);
            // 
            // chkSubtitle
            // 
            this.chkSubtitle.DefaultState = efControls.Enums.ControlState.Default;
            this.chkSubtitle.EnterMoveNextControl = true;
            this.chkSubtitle.HighLighted = false;
            this.chkSubtitle.Location = new System.Drawing.Point(12, 12);
            this.chkSubtitle.Name = "chkSubtitle";
            this.chkSubtitle.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkSubtitle.Properties.Appearance.Options.UseBackColor = true;
            this.chkSubtitle.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkSubtitle.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkSubtitle.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkSubtitle.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkSubtitle.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkSubtitle.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkSubtitle.Properties.Caption = "Print Subtitle";
            this.chkSubtitle.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkSubtitle.Size = new System.Drawing.Size(278, 19);
            this.chkSubtitle.StyleController = this.lcParameters;
            this.chkSubtitle.TabIndex = 4;
            this.chkSubtitle.ValueType = efControls.Enums.ValueType.Boolean;
            this.chkSubtitle.CheckedChanged += new System.EventHandler(this.chkSubtitle_CheckedChanged);
            // 
            // lcgParameters
            // 
            this.lcgParameters.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.lcgParameters.GroupBordersVisible = false;
            this.lcgParameters.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciSubTitle,
            this.lciSave,
            this.lciExit,
            this.lciEOY,
            this.simpleSeparator1,
            this.lciUserInfo,
            this.simpleSeparator2,
            this.simpleSeparator3,
            this.lcgDE,
            this.lciRefresh,
            this.emptySpaceItem1,
            this.lcgWarning});
            this.lcgParameters.Location = new System.Drawing.Point(0, 0);
            this.lcgParameters.Name = "Root";
            this.lcgParameters.Size = new System.Drawing.Size(585, 257);
            this.lcgParameters.TextVisible = false;
            // 
            // lciSubTitle
            // 
            this.lciSubTitle.Control = this.chkSubtitle;
            this.lciSubTitle.IsRequired = null;
            this.lciSubTitle.Location = new System.Drawing.Point(0, 0);
            this.lciSubTitle.Name = "lciSubTitle";
            this.lciSubTitle.Size = new System.Drawing.Size(282, 23);
            this.lciSubTitle.TextSize = new System.Drawing.Size(0, 0);
            this.lciSubTitle.TextVisible = false;
            // 
            // lciSave
            // 
            this.lciSave.Control = this.cmdSave;
            this.lciSave.IsRequired = null;
            this.lciSave.Location = new System.Drawing.Point(365, 196);
            this.lciSave.MinSize = new System.Drawing.Size(1, 1);
            this.lciSave.Name = "lciSave";
            this.lciSave.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciSave.Size = new System.Drawing.Size(100, 41);
            this.lciSave.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSave.TextSize = new System.Drawing.Size(0, 0);
            this.lciSave.TextVisible = false;
            // 
            // lciExit
            // 
            this.lciExit.Control = this.cmdExit;
            this.lciExit.IsRequired = null;
            this.lciExit.Location = new System.Drawing.Point(465, 196);
            this.lciExit.MinSize = new System.Drawing.Size(1, 1);
            this.lciExit.Name = "lciExit";
            this.lciExit.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciExit.Size = new System.Drawing.Size(100, 41);
            this.lciExit.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciExit.TextSize = new System.Drawing.Size(0, 0);
            this.lciExit.TextVisible = false;
            // 
            // lciEOY
            // 
            this.lciEOY.Control = this.txtEOY;
            this.lciEOY.IsRequired = null;
            this.lciEOY.Location = new System.Drawing.Point(0, 24);
            this.lciEOY.Name = "lciEOY";
            this.lciEOY.Size = new System.Drawing.Size(565, 24);
            this.lciEOY.Text = "E.O.Y Description";
            this.lciEOY.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciEOY.TextSize = new System.Drawing.Size(84, 13);
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 195);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(565, 1);
            // 
            // lciUserInfo
            // 
            this.lciUserInfo.Control = this.chkUserInfo;
            this.lciUserInfo.IsRequired = null;
            this.lciUserInfo.Location = new System.Drawing.Point(282, 0);
            this.lciUserInfo.Name = "lciUserInfo";
            this.lciUserInfo.Size = new System.Drawing.Size(283, 23);
            this.lciUserInfo.TextSize = new System.Drawing.Size(0, 0);
            this.lciUserInfo.TextVisible = false;
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(0, 23);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(565, 1);
            // 
            // simpleSeparator3
            // 
            this.simpleSeparator3.AllowHotTrack = false;
            this.simpleSeparator3.Location = new System.Drawing.Point(0, 97);
            this.simpleSeparator3.Name = "simpleSeparator3";
            this.simpleSeparator3.Size = new System.Drawing.Size(565, 1);
            // 
            // lcgDE
            // 
            this.lcgDE.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciDE,
            this.lciNegatif,
            this.lciPositif});
            this.lcgDE.Location = new System.Drawing.Point(0, 98);
            this.lcgDE.Name = "lcgDE";
            this.lcgDE.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgDE.Size = new System.Drawing.Size(565, 97);
            this.lcgDE.Text = "Difference Of Exchange";
            // 
            // lciDE
            // 
            this.lciDE.Control = this.txtDE;
            this.lciDE.IsRequired = null;
            this.lciDE.Location = new System.Drawing.Point(0, 0);
            this.lciDE.Name = "lciDE";
            this.lciDE.Size = new System.Drawing.Size(559, 24);
            this.lciDE.Text = "Description";
            this.lciDE.TextSize = new System.Drawing.Size(84, 13);
            // 
            // lciNegatif
            // 
            this.lciNegatif.Control = this.cboAccountsNeg;
            this.lciNegatif.IsRequired = null;
            this.lciNegatif.Location = new System.Drawing.Point(0, 24);
            this.lciNegatif.Name = "lciNegatif";
            this.lciNegatif.Size = new System.Drawing.Size(559, 24);
            this.lciNegatif.Text = "- Diff. Account";
            this.lciNegatif.TextSize = new System.Drawing.Size(84, 13);
            // 
            // lciPositif
            // 
            this.lciPositif.Control = this.cboAccountsPos;
            this.lciPositif.IsRequired = null;
            this.lciPositif.Location = new System.Drawing.Point(0, 48);
            this.lciPositif.Name = "lciPositif";
            this.lciPositif.Size = new System.Drawing.Size(559, 24);
            this.lciPositif.Text = "+ Diff. Account";
            this.lciPositif.TextSize = new System.Drawing.Size(84, 13);
            // 
            // lciRefresh
            // 
            this.lciRefresh.Control = this.btnRefresh;
            this.lciRefresh.IsRequired = null;
            this.lciRefresh.Location = new System.Drawing.Point(0, 196);
            this.lciRefresh.MinSize = new System.Drawing.Size(1, 1);
            this.lciRefresh.Name = "lciRefresh";
            this.lciRefresh.Padding = new DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5);
            this.lciRefresh.Size = new System.Drawing.Size(35, 41);
            this.lciRefresh.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciRefresh.TextSize = new System.Drawing.Size(0, 0);
            this.lciRefresh.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(35, 196);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(330, 41);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // txt1stLocal
            // 
            this.txt1stLocal.AllowLeadingSpace = false;
            this.txt1stLocal.DefaultState = efControls.Enums.ControlState.Default;
            this.txt1stLocal.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txt1stLocal.EnterMoveNextControl = true;
            this.txt1stLocal.Information = null;
            this.txt1stLocal.Location = new System.Drawing.Point(102, 82);
            this.txt1stLocal.Name = "txt1stLocal";
            this.txt1stLocal.Size = new System.Drawing.Size(134, 20);
            this.txt1stLocal.StyleController = this.lcParameters;
            this.txt1stLocal.TabIndex = 13;
            // 
            // lci1stAmount
            // 
            this.lci1stAmount.Control = this.txt1stLocal;
            this.lci1stAmount.IsRequired = null;
            this.lci1stAmount.Location = new System.Drawing.Point(0, 0);
            this.lci1stAmount.Name = "lci1stAmount";
            this.lci1stAmount.Size = new System.Drawing.Size(225, 24);
            this.lci1stAmount.Text = "1st Local";
            this.lci1stAmount.TextSize = new System.Drawing.Size(84, 13);
            // 
            // txt2ndLocal
            // 
            this.txt2ndLocal.AllowLeadingSpace = false;
            this.txt2ndLocal.DefaultState = efControls.Enums.ControlState.Default;
            this.txt2ndLocal.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txt2ndLocal.EnterMoveNextControl = true;
            this.txt2ndLocal.Information = null;
            this.txt2ndLocal.Location = new System.Drawing.Point(436, 82);
            this.txt2ndLocal.Name = "txt2ndLocal";
            this.txt2ndLocal.Size = new System.Drawing.Size(134, 20);
            this.txt2ndLocal.StyleController = this.lcParameters;
            this.txt2ndLocal.TabIndex = 14;
            // 
            // lci2ndAmount
            // 
            this.lci2ndAmount.Control = this.txt2ndLocal;
            this.lci2ndAmount.IsRequired = null;
            this.lci2ndAmount.Location = new System.Drawing.Point(334, 0);
            this.lci2ndAmount.Name = "lci2ndAmount";
            this.lci2ndAmount.Size = new System.Drawing.Size(225, 24);
            this.lci2ndAmount.Text = "2nd Local";
            this.lci2ndAmount.TextSize = new System.Drawing.Size(84, 13);
            // 
            // lcgWarning
            // 
            this.lcgWarning.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lci1stAmount,
            this.lci2ndAmount,
            this.emptySpaceItem2});
            this.lcgWarning.Location = new System.Drawing.Point(0, 48);
            this.lcgWarning.Name = "lcgWarning";
            this.lcgWarning.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgWarning.Size = new System.Drawing.Size(565, 49);
            this.lcgWarning.Text = "Warning Ceiling On JVs Amounts";
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(225, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(109, 24);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormParameters
            // 
            this.ClientSize = new System.Drawing.Size(585, 257);
            this.ControlBox = false;
            this.Controls.Add(this.lcParameters);
            this.Name = "FormParameters";
            this.Text = "Application Parameters";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcParameters)).EndInit();
            this.lcParameters.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.formImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountsPos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountsPosView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountsNeg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountsNegView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEOY.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkUserInfo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkSubtitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgParameters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciEOY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciUserInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDE)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNegatif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPositif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt1stLocal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci1stAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt2ndLocal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci2ndAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgWarning)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private efControls.efLayoutControl lcParameters;
        private DevExpress.XtraLayout.LayoutControlGroup lcgParameters;
        private efControls.efButton cmdExit;
        private efControls.efButton cmdSave;
        private efControls.efCheckBox chkUserInfo;
        private efControls.efCheckBox chkSubtitle;
        private efControls.lci lciSubTitle;
        private efControls.lci lciUserInfo;
        private efControls.lci lciSave;
        private efControls.lci lciExit;
        private DevExpress.Utils.ImageCollection formImages;
        private efControls.efTextBox txtEOY;
        private efControls.lci lciEOY;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private cboAccounts cboAccountsPos;
        private cboAccounts cboAccountsNeg;
        private efControls.efTextBox txtDE;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator3;
        private efControls.lci lciDE;
        private efControls.lci lciNegatif;
        private efControls.lci lciPositif;
        private DevExpress.XtraLayout.LayoutControlGroup lcgDE;
        private efControls.efButton btnRefresh;
        private DevExpress.XtraGrid.Views.Grid.GridView cboAccountsPosView;
        private DevExpress.XtraGrid.Views.Grid.GridView cboAccountsNegView;
        private efControls.lci lciRefresh;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private efControls.efTextBox txt2ndLocal;
        private efControls.efTextBox txt1stLocal;
        private DevExpress.XtraLayout.LayoutControlGroup lcgWarning;
        private efControls.lci lci1stAmount;
        private efControls.lci lci2ndAmount;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}
