namespace Accounting
{
    partial class FormCurrencies
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCurrencies));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.txtcode = new efControls.efTextBox();
            this.lciCode = new efControls.lci();
            this.txtDescription = new efControls.efTextBox();
            this.lciDescription = new efControls.lci();
            this.txtRate = new efControls.efTextBox();
            this.lciRate = new efControls.lci();
            this.bsDetails = new System.Windows.Forms.BindingSource(this.components);
            this.simpleSeparator1 = new DevExpress.XtraLayout.SimpleSeparator();
            this.gcRates = new efControls.efGridControl();
            this.gvRates = new efControls.efGridView();
            this.colYdate = new efControls.efGridColumn();
            this.colMdate = new efControls.efGridColumn();
            this.colDdate = new efControls.efGridColumn();
            this.colRatedate = new efControls.efGridColumn();
            this.colRate = new efControls.efGridColumn();
            this.riRate = new efControls.RepositoryItemefTextBox();
            this.lciGridRates = new efControls.lci();
            this.sbdcGridDetails = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.lciGridToolbar = new efControls.lci();
            this.ucControlNavigator = new efControls.ucControlNavigator();
            this.lciControlNavigator = new efControls.lci();
            this.spnOrder = new efControls.efSpinner();
            this.lciOrder = new efControls.lci();
            this.gvToolbar = new DevExpress.XtraBars.Bar();
            this.bbigvAdd = new DevExpress.XtraBars.BarButtonItem();
            this.bbigvDelete = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.gcSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaster)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdController)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sccMain)).BeginInit();
            this.sccMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcSearch)).BeginInit();
            this.lcSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).BeginInit();
            this.lcMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSearch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridRates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridToolbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciControlNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSearch
            // 
            this.gcSearch.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            gridLevelNode1.RelationName = "Level1";
            this.gcSearch.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcSearch.Size = new System.Drawing.Size(116, 277);
            // 
            // gvSearch
            // 
            this.gvSearch.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvSearch.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvSearch.OptionsBehavior.ReadOnly = true;
            this.gvSearch.OptionsCustomization.AllowColumnMoving = false;
            this.gvSearch.OptionsCustomization.AllowColumnResizing = false;
            this.gvSearch.OptionsDetail.EnableMasterViewMode = false;
            this.gvSearch.OptionsEditForm.ActionOnModifiedRowChange = DevExpress.XtraGrid.Views.Grid.EditFormModifiedAction.Nothing;
            this.gvSearch.OptionsEditForm.ShowOnDoubleClick = DevExpress.Utils.DefaultBoolean.False;
            this.gvSearch.OptionsEditForm.ShowOnEnterKey = DevExpress.Utils.DefaultBoolean.False;
            this.gvSearch.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.gvSearch.OptionsEditForm.ShowUpdateCancelPanel = DevExpress.Utils.DefaultBoolean.False;
            this.gvSearch.OptionsFilter.UseNewCustomFilterDialog = true;
            this.gvSearch.OptionsFind.AllowFindPanel = false;
            this.gvSearch.OptionsMenu.EnableColumnMenu = false;
            this.gvSearch.OptionsMenu.EnableFooterMenu = false;
            this.gvSearch.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvSearch.OptionsNavigation.AutoFocusNewRow = true;
            this.gvSearch.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvSearch.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gvSearch.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.NeverAnimate;
            this.gvSearch.OptionsView.EnableAppearanceEvenRow = true;
            this.gvSearch.OptionsView.ShowColumnHeaders = false;
            this.gvSearch.OptionsView.ShowDetailButtons = false;
            this.gvSearch.OptionsView.ShowGroupPanel = false;
            this.gvSearch.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvSearch.OptionsView.ShowIndicator = false;
            // 
            // colSearch
            // 
            this.colSearch.AppearanceHeader.Options.UseTextOptions = true;
            this.colSearch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSearch.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSearch.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // toolBar
            // 
            this.toolBar.OptionsBar.AllowQuickCustomization = false;
            this.toolBar.OptionsBar.DisableClose = true;
            this.toolBar.OptionsBar.DisableCustomization = true;
            this.toolBar.OptionsBar.DrawDragBorder = false;
            this.toolBar.OptionsBar.RotateWhenVertical = false;
            this.toolBar.OptionsBar.UseWholeRow = true;
            // 
            // statusBar
            // 
            this.statusBar.OptionsBar.AllowQuickCustomization = false;
            this.statusBar.OptionsBar.DisableClose = true;
            this.statusBar.OptionsBar.DisableCustomization = true;
            this.statusBar.OptionsBar.DrawDragBorder = false;
            this.statusBar.OptionsBar.DrawSizeGrip = true;
            this.statusBar.OptionsBar.MultiLine = true;
            this.statusBar.OptionsBar.UseWholeRow = true;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.Size = new System.Drawing.Size(507, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 358);
            this.barDockControlBottom.Size = new System.Drawing.Size(507, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 327);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Location = new System.Drawing.Point(507, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 327);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.gvToolbar});
            this.barManager.DockControls.Add(this.sbdcGridDetails);
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbigvAdd,
            this.bbigvDelete});
            this.barManager.OptionsLayout.AllowAddNewItems = false;
            // 
            // bsMaster
            // 
            this.bsMaster.DataSource = this.bsSearch;
            // 
            // bdController
            // 
            this.bdController.LookAndFeel.SkinName = "Office 2010 Blue";
            this.bdController.PropertiesBar.AllowLinkLighting = false;
            this.bdController.PropertiesBar.DefaultGlyphSize = new System.Drawing.Size(16, 16);
            this.bdController.PropertiesBar.DefaultLargeGlyphSize = new System.Drawing.Size(32, 32);
            // 
            // sccMain
            // 
            this.sccMain.Location = new System.Drawing.Point(0, 31);
            this.sccMain.Size = new System.Drawing.Size(507, 327);
            // 
            // lcSearch
            // 
            this.lcSearch.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(678, 161, 250, 350);
            this.lcSearch.Size = new System.Drawing.Size(120, 327);
            this.lcSearch.Controls.SetChildIndex(this.gcSearch, 0);
            // 
            // lcgSearch
            // 
            this.lcgSearch.Size = new System.Drawing.Size(120, 327);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.spnOrder);
            this.lcMain.Controls.Add(this.ucControlNavigator);
            this.lcMain.Controls.Add(this.sbdcGridDetails);
            this.lcMain.Controls.Add(this.gcRates);
            this.lcMain.Controls.Add(this.txtRate);
            this.lcMain.Controls.Add(this.txtDescription);
            this.lcMain.Controls.Add(this.txtcode);
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1076, 143, 314, 700);
            this.lcMain.Size = new System.Drawing.Size(382, 327);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCode,
            this.simpleSeparator1,
            this.lciGridRates,
            this.lciGridToolbar,
            this.lciControlNavigator,
            this.lciRate,
            this.lciDescription,
            this.lciOrder});
            this.lcgMain.Size = new System.Drawing.Size(382, 327);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("addfile_16x16.png", "office2013/actions/addfile_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/addfile_16x16.png"), 16);
            this.imageCollection.Images.SetKeyName(16, "addfile_16x16.png");
            this.imageCollection.InsertGalleryImage("deletelist_16x16.png", "office2013/actions/deletelist_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/deletelist_16x16.png"), 17);
            this.imageCollection.Images.SetKeyName(17, "deletelist_16x16.png");
            // 
            // bciPosted
            // 
            this.bciPosted.ItemAppearance.Pressed.BackColor = System.Drawing.Color.Transparent;
            this.bciPosted.ItemAppearance.Pressed.Options.UseBackColor = true;
            // 
            // bsSearch
            // 
            this.bsSearch.DataSource = typeof(Accounting.CurrencySearchList);
            // 
            // txtcode
            // 
            this.txtcode.AllowLeadingSpace = false;
            this.txtcode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "Code", true));
            this.txtcode.DefaultState = efControls.Enums.ControlState.EditDisabled;
            this.txtcode.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtcode.EnterMoveNextControl = true;
            this.txtcode.Information = null;
            this.txtcode.Location = new System.Drawing.Point(2, 18);
            this.txtcode.MenuManager = this.barManager;
            this.txtcode.Name = "txtcode";
            this.txtcode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcode.Properties.MaxLength = 3;
            this.txtcode.Size = new System.Drawing.Size(54, 20);
            this.txtcode.StyleController = this.lcMain;
            this.txtcode.TabIndex = 5;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Required !";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.ValidationProvider.SetValidationRule(this.txtcode, conditionValidationRule1);
            this.txtcode.Validating += new System.ComponentModel.CancelEventHandler(this.txtcode_Validating);
            // 
            // lciCode
            // 
            this.lciCode.Control = this.txtcode;
            this.lciCode.CustomizationFormText = "Code";
            this.lciCode.IsRequired = null;
            this.lciCode.Location = new System.Drawing.Point(0, 0);
            this.lciCode.Name = "lciCode";
            this.lciCode.Size = new System.Drawing.Size(58, 40);
            this.lciCode.Text = "Code";
            this.lciCode.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciCode.TextSize = new System.Drawing.Size(53, 13);
            // 
            // txtDescription
            // 
            this.txtDescription.AllowLeadingSpace = false;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "Description", true));
            this.txtDescription.DefaultState = efControls.Enums.ControlState.Default;
            this.txtDescription.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Information = null;
            this.txtDescription.Location = new System.Drawing.Point(60, 18);
            this.txtDescription.MenuManager = this.barManager;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.MaxLength = 20;
            this.txtDescription.Size = new System.Drawing.Size(320, 20);
            this.txtDescription.StyleController = this.lcMain;
            this.txtDescription.TabIndex = 6;
            // 
            // lciDescription
            // 
            this.lciDescription.Control = this.txtDescription;
            this.lciDescription.CustomizationFormText = "Description";
            this.lciDescription.IsRequired = null;
            this.lciDescription.Location = new System.Drawing.Point(58, 0);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(324, 40);
            this.lciDescription.Text = "Description";
            this.lciDescription.TextLocation = DevExpress.Utils.Locations.Top;
            this.lciDescription.TextSize = new System.Drawing.Size(53, 13);
            // 
            // txtRate
            // 
            this.txtRate.AllowLeadingSpace = false;
            this.txtRate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "Rate", true));
            this.txtRate.DefaultState = efControls.Enums.ControlState.Default;
            this.txtRate.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txtRate.EnterMoveNextControl = true;
            this.txtRate.Information = null;
            this.txtRate.Location = new System.Drawing.Point(59, 44);
            this.txtRate.MenuManager = this.barManager;
            this.txtRate.Name = "txtRate";
            this.txtRate.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtRate.Properties.Mask.EditMask = "N2";
            this.txtRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtRate.Properties.MaxLength = 20;
            this.txtRate.Size = new System.Drawing.Size(97, 20);
            this.txtRate.StyleController = this.lcMain;
            this.txtRate.TabIndex = 7;
            // 
            // lciRate
            // 
            this.lciRate.Control = this.txtRate;
            this.lciRate.CustomizationFormText = "Rate";
            this.lciRate.IsRequired = null;
            this.lciRate.Location = new System.Drawing.Point(0, 42);
            this.lciRate.Name = "lciRate";
            this.lciRate.Size = new System.Drawing.Size(158, 24);
            this.lciRate.Text = "Rate";
            this.lciRate.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciRate.TextSize = new System.Drawing.Size(53, 13);
            // 
            // bsDetails
            // 
            this.bsDetails.DataSource = this.bsMaster;
            // 
            // simpleSeparator1
            // 
            this.simpleSeparator1.AllowHotTrack = false;
            this.simpleSeparator1.CustomizationFormText = "simpleSeparator1";
            this.simpleSeparator1.Location = new System.Drawing.Point(0, 40);
            this.simpleSeparator1.Name = "simpleSeparator1";
            this.simpleSeparator1.Size = new System.Drawing.Size(382, 2);
            // 
            // gcRates
            // 
            this.gcRates.DataSource = this.bsDetails;
            this.gcRates.DefaultState = efControls.Enums.ControlState.Default;
            this.gcRates.EmbeddedNavigatorHideButtons = false;
            this.gcRates.Location = new System.Drawing.Point(39, 86);
            this.gcRates.MainView = this.gvRates;
            this.gcRates.MenuManager = this.barManager;
            this.gcRates.Name = "gcRates";
            this.gcRates.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riRate});
            this.gcRates.Size = new System.Drawing.Size(304, 186);
            this.gcRates.TabIndex = 23;
            this.gcRates.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRates});
            // 
            // gvRates
            // 
            this.gvRates.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colYdate,
            this.colMdate,
            this.colDdate,
            this.colRatedate,
            this.colRate});
            this.gvRates.GridControl = this.gcRates;
            this.gvRates.HighLightFocusedRow = true;
            this.gvRates.Name = "gvRates";
            this.gvRates.OptionsBehavior.ReadOnly = true;
            this.gvRates.OptionsCustomization.AllowColumnMoving = false;
            this.gvRates.OptionsDetail.EnableMasterViewMode = false;
            this.gvRates.OptionsFind.AllowFindPanel = false;
            this.gvRates.OptionsMenu.EnableColumnMenu = false;
            this.gvRates.OptionsMenu.EnableFooterMenu = false;
            this.gvRates.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvRates.OptionsNavigation.AutoFocusNewRow = true;
            this.gvRates.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvRates.OptionsView.ColumnAutoWidth = false;
            this.gvRates.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRates.OptionsView.ShowGroupPanel = false;
            this.gvRates.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvRates.OptionsView.ShowIndicator = false;
            this.gvRates.ParentForm = null;
            this.gvRates.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvRates.VisibleAutoFilterRow = false;
            this.gvRates.VisibleGroupPanel = false;
            this.gvRates.VisibleIndicator = false;
            // 
            // colYdate
            // 
            this.colYdate.AlwaysDisabled = false;
            this.colYdate.AppearanceCell.BackColor = System.Drawing.Color.FloralWhite;
            this.colYdate.AppearanceCell.Options.UseBackColor = true;
            this.colYdate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colYdate.AppearanceHeader.Options.UseFont = true;
            this.colYdate.AppearanceHeader.Options.UseTextOptions = true;
            this.colYdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colYdate.Caption = "Year";
            this.colYdate.CustomData = "";
            this.colYdate.EditDisabled = false;
            this.colYdate.FieldName = "YDate";
            this.colYdate.Name = "colYdate";
            this.colYdate.OptionsColumn.AllowEdit = false;
            this.colYdate.OptionsColumn.ReadOnly = true;
            this.colYdate.Visible = true;
            this.colYdate.VisibleIndex = 0;
            this.colYdate.Width = 45;
            // 
            // colMdate
            // 
            this.colMdate.AlwaysDisabled = false;
            this.colMdate.AppearanceCell.BackColor = System.Drawing.Color.FloralWhite;
            this.colMdate.AppearanceCell.Options.UseBackColor = true;
            this.colMdate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colMdate.AppearanceHeader.Options.UseFont = true;
            this.colMdate.AppearanceHeader.Options.UseTextOptions = true;
            this.colMdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMdate.Caption = "Month";
            this.colMdate.CustomData = "";
            this.colMdate.EditDisabled = false;
            this.colMdate.FieldName = "MDate";
            this.colMdate.Name = "colMdate";
            this.colMdate.OptionsColumn.AllowEdit = false;
            this.colMdate.OptionsColumn.ReadOnly = true;
            this.colMdate.Visible = true;
            this.colMdate.VisibleIndex = 1;
            this.colMdate.Width = 45;
            // 
            // colDdate
            // 
            this.colDdate.AlwaysDisabled = false;
            this.colDdate.AppearanceCell.BackColor = System.Drawing.Color.FloralWhite;
            this.colDdate.AppearanceCell.Options.UseBackColor = true;
            this.colDdate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colDdate.AppearanceHeader.Options.UseFont = true;
            this.colDdate.AppearanceHeader.Options.UseTextOptions = true;
            this.colDdate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDdate.Caption = "Day";
            this.colDdate.CustomData = "";
            this.colDdate.EditDisabled = false;
            this.colDdate.FieldName = "DDate";
            this.colDdate.Name = "colDdate";
            this.colDdate.OptionsColumn.AllowEdit = false;
            this.colDdate.OptionsColumn.ReadOnly = true;
            this.colDdate.Visible = true;
            this.colDdate.VisibleIndex = 2;
            this.colDdate.Width = 45;
            // 
            // colRatedate
            // 
            this.colRatedate.AlwaysDisabled = false;
            this.colRatedate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colRatedate.AppearanceHeader.Options.UseFont = true;
            this.colRatedate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRatedate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRatedate.Caption = "Date";
            this.colRatedate.CustomData = "";
            this.colRatedate.EditDisabled = false;
            this.colRatedate.FieldName = "Ratedate";
            this.colRatedate.Name = "colRatedate";
            this.colRatedate.Visible = true;
            this.colRatedate.VisibleIndex = 3;
            this.colRatedate.Width = 66;
            // 
            // colRate
            // 
            this.colRate.AlwaysDisabled = false;
            this.colRate.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colRate.AppearanceHeader.Options.UseFont = true;
            this.colRate.AppearanceHeader.Options.UseTextOptions = true;
            this.colRate.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRate.Caption = "Rate";
            this.colRate.ColumnEdit = this.riRate;
            this.colRate.CustomData = "";
            this.colRate.EditDisabled = false;
            this.colRate.FieldName = "Rate";
            this.colRate.Name = "colRate";
            this.colRate.Visible = true;
            this.colRate.VisibleIndex = 4;
            // 
            // riRate
            // 
            this.riRate.AutoHeight = false;
            this.riRate.Mask.EditMask = "n4";
            this.riRate.Mask.IgnoreMaskBlank = false;
            this.riRate.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riRate.Mask.UseMaskAsDisplayFormat = true;
            this.riRate.MaxLength = 25;
            this.riRate.Name = "riRate";
            // 
            // lciGridRates
            // 
            this.lciGridRates.Control = this.gcRates;
            this.lciGridRates.CustomizationFormText = "efLayoutControlItem3";
            this.lciGridRates.IsRequired = null;
            this.lciGridRates.Location = new System.Drawing.Point(0, 66);
            this.lciGridRates.Name = "lciGridRates";
            this.lciGridRates.Padding = new DevExpress.XtraLayout.Utils.Padding(39, 39, 20, 20);
            this.lciGridRates.Size = new System.Drawing.Size(382, 226);
            this.lciGridRates.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridRates.TextVisible = false;
            // 
            // sbdcGridDetails
            // 
            this.sbdcGridDetails.CausesValidation = false;
            this.sbdcGridDetails.Location = new System.Drawing.Point(2, 294);
            this.sbdcGridDetails.Name = "sbdcGridDetails";
            this.sbdcGridDetails.Size = new System.Drawing.Size(185, 31);
            this.sbdcGridDetails.Text = "standaloneBarDockControl1";
            // 
            // lciGridToolbar
            // 
            this.lciGridToolbar.Control = this.sbdcGridDetails;
            this.lciGridToolbar.IsRequired = null;
            this.lciGridToolbar.Location = new System.Drawing.Point(0, 292);
            this.lciGridToolbar.Name = "lciGridToolbar";
            this.lciGridToolbar.Size = new System.Drawing.Size(189, 35);
            this.lciGridToolbar.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridToolbar.TextVisible = false;
            // 
            // ucControlNavigator
            // 
            this.ucControlNavigator.AlwaysEnabled = false;
            this.ucControlNavigator.Appearance.BackColor = System.Drawing.SystemColors.Control;
            this.ucControlNavigator.Appearance.Options.UseBackColor = true;
            this.ucControlNavigator.Location = new System.Drawing.Point(191, 294);
            this.ucControlNavigator.MaximumSize = new System.Drawing.Size(0, 26);
            this.ucControlNavigator.MinimumSize = new System.Drawing.Size(185, 26);
            this.ucControlNavigator.Name = "ucControlNavigator";
            this.ucControlNavigator.NavigatableControl = this.gcRates;
            this.ucControlNavigator.Size = new System.Drawing.Size(189, 26);
            this.ucControlNavigator.TabIndex = 26;
            // 
            // lciControlNavigator
            // 
            this.lciControlNavigator.Control = this.ucControlNavigator;
            this.lciControlNavigator.IsRequired = null;
            this.lciControlNavigator.Location = new System.Drawing.Point(189, 292);
            this.lciControlNavigator.Name = "lciControlNavigator";
            this.lciControlNavigator.Size = new System.Drawing.Size(193, 35);
            this.lciControlNavigator.TextSize = new System.Drawing.Size(0, 0);
            this.lciControlNavigator.TextVisible = false;
            // 
            // spnOrder
            // 
            this.spnOrder.AllowLeadingSpace = false;
            this.spnOrder.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "OrderID", true));
            this.spnOrder.DefaultState = efControls.Enums.ControlState.Default;
            this.spnOrder.DisplayType = efControls.Enums.DisplayType.Default;
            this.spnOrder.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.spnOrder.EnterMoveNextControl = true;
            this.spnOrder.Information = null;
            this.spnOrder.Location = new System.Drawing.Point(315, 44);
            this.spnOrder.MenuManager = this.barManager;
            this.spnOrder.Name = "spnOrder";
            this.spnOrder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnOrder.Properties.Mask.EditMask = "f0";
            this.spnOrder.Size = new System.Drawing.Size(65, 20);
            this.spnOrder.StyleController = this.lcMain;
            this.spnOrder.TabIndex = 30;
            // 
            // lciOrder
            // 
            this.lciOrder.Control = this.spnOrder;
            this.lciOrder.IsRequired = null;
            this.lciOrder.Location = new System.Drawing.Point(158, 42);
            this.lciOrder.Name = "lciOrder";
            this.lciOrder.Padding = new DevExpress.XtraLayout.Utils.Padding(100, 2, 2, 2);
            this.lciOrder.Size = new System.Drawing.Size(224, 24);
            this.lciOrder.Text = "Order";
            this.lciOrder.TextLocation = DevExpress.Utils.Locations.Left;
            this.lciOrder.TextSize = new System.Drawing.Size(53, 13);
            // 
            // gvToolbar
            // 
            this.gvToolbar.BarName = "Custom 4";
            this.gvToolbar.DockCol = 0;
            this.gvToolbar.DockRow = 0;
            this.gvToolbar.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.gvToolbar.FloatLocation = new System.Drawing.Point(499, 492);
            this.gvToolbar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbigvAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbigvDelete)});
            this.gvToolbar.OptionsBar.DrawBorder = false;
            this.gvToolbar.OptionsBar.DrawDragBorder = false;
            this.gvToolbar.OptionsBar.UseWholeRow = true;
            this.gvToolbar.StandaloneBarDockControl = this.sbdcGridDetails;
            this.gvToolbar.Text = "Custom 4";
            // 
            // bbigvAdd
            // 
            this.bbigvAdd.Caption = "Add";
            this.bbigvAdd.Id = 33;
            this.bbigvAdd.ImageIndex = 16;
            this.bbigvAdd.Name = "bbigvAdd";
            this.bbigvAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbigvAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbigvAdd_ItemClick);
            // 
            // bbigvDelete
            // 
            this.bbigvDelete.Caption = "Delete";
            this.bbigvDelete.Id = 34;
            this.bbigvDelete.ImageIndex = 17;
            this.bbigvDelete.Name = "bbigvDelete";
            this.bbigvDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.bbigvDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbigvDelete_ItemClick);
            // 
            // FormCurrencies
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(507, 385);
            this.Name = "FormCurrencies";
            this.PrintableGrid = this.gvRates;
            this.Text = "Currencies Management";
            ((System.ComponentModel.ISupportInitialize)(this.gcSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMaster)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bdController)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sccMain)).EndInit();
            this.sccMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcSearch)).EndInit();
            this.lcSearch.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcMain)).EndInit();
            this.lcMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lcgMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSearch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridRates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridToolbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciControlNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private efControls.efTextBox txtRate;
        private efControls.efTextBox txtDescription;
        private efControls.efTextBox txtcode;
        private efControls.lci lciCode;
        private efControls.lci lciRate;
        private efControls.lci lciDescription;
        private System.Windows.Forms.BindingSource bsDetails;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator1;
        private efControls.efGridControl gcRates;
        private efControls.efGridView gvRates;
        private efControls.efGridColumn colRatedate;
        private efControls.efGridColumn colRate;
        private efControls.efGridColumn colYdate;
        private efControls.efGridColumn colMdate;
        private efControls.efGridColumn colDdate;
        private efControls.lci lciGridRates;
        private efControls.RepositoryItemefTextBox riRate;
        private DevExpress.XtraBars.StandaloneBarDockControl sbdcGridDetails;
        private efControls.lci lciGridToolbar;
        private efControls.ucControlNavigator ucControlNavigator;
        private efControls.lci lciControlNavigator;
        private efControls.efSpinner spnOrder;
        private efControls.lci lciOrder;
        private DevExpress.XtraBars.Bar gvToolbar;
        private DevExpress.XtraBars.BarButtonItem bbigvAdd;
        private DevExpress.XtraBars.BarButtonItem bbigvDelete;
    }
}
