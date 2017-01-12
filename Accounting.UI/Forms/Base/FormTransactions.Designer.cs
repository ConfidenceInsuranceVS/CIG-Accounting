namespace Accounting
{
    partial class FormTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTransactions));
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.colDocument = new efControls.efGridColumn();
            this.ripceCollect = new efControls.RepositoryItemefPopupContainerEdit();
            this.pccCollect = new efControls.efPopupContainerControl();
            this.gcCollect = new efControls.efGridControl();
            this.bsCollect = new System.Windows.Forms.BindingSource(this.components);
            this.gvCollect = new efControls.efGridView();
            this.colDocument1 = new efControls.efGridColumn();
            this.colMaturity1 = new efControls.efGridColumn();
            this.colcur = new efControls.efGridColumn();
            this.colAmount1 = new efControls.efGridColumn();
            this.colBank = new efControls.efGridColumn();
            this.coldc1 = new efControls.efGridColumn();
            this.colDc = new efControls.efGridColumn();
            this.riDC = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.bsDetails = new System.Windows.Forms.BindingSource(this.components);
            this.txtFromTo = new efControls.efTextBox();
            this.lciFromTo = new efControls.lci();
            this.meDetails = new efControls.efMemoEdit();
            this.lciDetails = new efControls.lci();
            this.lcgDetails = new DevExpress.XtraLayout.LayoutControlGroup();
            this.cboVoucherTypes = new Accounting.cboVoucherTypes();
            this.lciType = new efControls.lci();
            this.lciReference = new efControls.lci();
            this.txtReference = new efControls.efButtonEdit();
            this.deDate = new efControls.efDateEdit();
            this.lciDate = new efControls.lci();
            this.txt2ndRate = new efControls.efTextBox();
            this.lci2ndRate = new efControls.lci();
            this.gcDetails = new efControls.efGridControl();
            this.gvDetails = new efControls.efGridView();
            this.colLine = new efControls.efGridColumn();
            this.colAccount = new efControls.efGridColumn();
            this.riAccounts = new Accounting.RepositoryItemef_Accounts();
            this.bsAccounts = new System.Windows.Forms.BindingSource(this.components);
            this.riAccountsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCodeDescription = new efControls.efGridColumn();
            this.colMaturity = new efControls.efGridColumn();
            this.rideMaturity = new efControls.RepositoryItemefDateEdit();
            this.colCurrencyid = new efControls.efGridColumn();
            this.riCurrencies = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.bsCurrencies = new System.Windows.Forms.BindingSource(this.components);
            this.colAmount = new efControls.efGridColumn();
            this.riAmounts = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.colDescription = new efControls.efGridColumn();
            this.ritxtDescription = new efControls.RepositoryItemefTextBox();
            this.colBankid = new efControls.efGridColumn();
            this.riBanks = new Accounting.RepositoryItemef_Accounts();
            this.bsBanks = new System.Windows.Forms.BindingSource(this.components);
            this.riBanksView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColBank = new efControls.efGridColumn();
            this.colAmount1st = new efControls.efGridColumn();
            this.colAmount2nd = new efControls.efGridColumn();
            this.colStatus = new efControls.efGridColumn();
            this.lciGridDetails = new efControls.lci();
            this.txtDebit1st = new efControls.efTextBox();
            this.lciDebit1st = new efControls.lci();
            this.txtCredit1st = new efControls.efTextBox();
            this.lciCredit1st = new efControls.lci();
            this.txtBalance1st = new efControls.efTextBox();
            this.lciBalance1st = new efControls.lci();
            this.txtDebit2nd = new efControls.efTextBox();
            this.lciDebit2nd = new efControls.lci();
            this.txtCredit2nd = new efControls.efTextBox();
            this.lciCredit2nd = new efControls.lci();
            this.txtBalance2nd = new efControls.efTextBox();
            this.lciBalance2nd = new efControls.lci();
            this.txtRate = new efControls.efTextBox();
            this.lciRate = new efControls.lci();
            this.lcgInfo = new DevExpress.XtraLayout.LayoutControlGroup();
            this.lciDescription = new efControls.lci();
            this.txtDescription = new efControls.efTextBox();
            this.Currency = new efControls.lci();
            this.cboCurrencies = new Accounting.cboCurrencies();
            this.lciAccounts = new efControls.lci();
            this.cboAccounts = new Accounting.cboAccounts();
            this.cboAccountsView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lciBanks = new efControls.lci();
            this.cboBanks = new Accounting.cboBanks();
            this.lcgBalances = new DevExpress.XtraLayout.LayoutControlGroup();
            this.pmGrid = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiInsert = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMoveUP = new DevExpress.XtraBars.BarButtonItem();
            this.bbiMoveDOWN = new DevExpress.XtraBars.BarButtonItem();
            this.beMoveTO = new DevExpress.XtraBars.BarEditItem();
            this.tiTxtMoveTO = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.riVoucherType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colReference = new efControls.efGridColumn();
            this.colRef = new efControls.efGridColumn();
            this.bbiNew = new DevExpress.XtraBars.BarButtonItem();
            this.GridBar = new DevExpress.XtraBars.Bar();
            this.btnGridAdd = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridDelete = new DevExpress.XtraBars.BarButtonItem();
            this.btnGridInsert = new DevExpress.XtraBars.BarButtonItem();
            this.btnCopyFrom = new DevExpress.XtraBars.BarButtonItem();
            this.btnCheque = new DevExpress.XtraBars.BarButtonItem();
            this.btnScan = new DevExpress.XtraBars.BarButtonItem();
            this.pmScan = new DevExpress.XtraBars.PopupMenu(this.components);
            this.bbiImportPDF = new DevExpress.XtraBars.BarButtonItem();
            this.sbdcGridBar = new DevExpress.XtraBars.StandaloneBarDockControl();
            this.lciGridBar = new efControls.lci();
            this.simpleSeparator2 = new DevExpress.XtraLayout.SimpleSeparator();
            this.ucControlNavigator = new efControls.ucControlNavigator();
            this.lciControlNavigator = new efControls.lci();
            this.chkNew = new efControls.efCheckBox();
            this.lciNEw = new efControls.lci();
            this.chkPrint = new efControls.efCheckBox();
            this.lciPrint = new efControls.lci();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.bsVoucherType = new System.Windows.Forms.BindingSource(this.components);
            this.cboSubCompanies = new Accounting.cboSubCompanies();
            this.lciSubCompanies = new efControls.lci();
            this.colSC = new efControls.efGridColumn();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.accBalances = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
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
            ((System.ComponentModel.ISupportInitialize)(this.ripceCollect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pccCollect)).BeginInit();
            this.pccCollect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gcCollect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCollect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCollect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromTo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDetails.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVoucherTypes.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReference)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt2ndRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci2ndRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAccountsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideMaturity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideMaturity.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrencies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAmounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritxtDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBanksView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebit1st.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDebit1st)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCredit1st.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCredit1st)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance1st.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBalance1st)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebit2nd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDebit2nd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCredit2nd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCredit2nd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance2nd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBalance2nd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Currency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCurrencies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccounts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccounts.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountsView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBanks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBanks.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBalances)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiTxtMoveTO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riVoucherType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmScan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciControlNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNew.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNEw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVoucherType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubCompanies.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubCompanies)).BeginInit();
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
            this.gcSearch.Size = new System.Drawing.Size(116, 403);
            // 
            // gvSearch
            // 
            this.gvSearch.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvSearch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colSC,
            this.colRef});
            this.gvSearch.OptionsBehavior.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.False;
            this.gvSearch.OptionsBehavior.AutoExpandAllGroups = true;
            this.gvSearch.OptionsBehavior.CacheValuesOnRowUpdating = DevExpress.Data.CacheRowValuesMode.Disabled;
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
            this.gvSearch.OptionsView.EnableAppearanceOddRow = true;
            this.gvSearch.OptionsView.ShowAutoFilterRow = true;
            this.gvSearch.OptionsView.ShowColumnHeaders = false;
            this.gvSearch.OptionsView.ShowDetailButtons = false;
            this.gvSearch.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.ShowAlways;
            this.gvSearch.OptionsView.ShowGroupPanel = false;
            this.gvSearch.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvSearch.OptionsView.ShowIndicator = false;
            this.gvSearch.VisibleAutoFilterRow = true;
            // 
            // colSearch
            // 
            this.colSearch.AppearanceHeader.Options.UseTextOptions = true;
            this.colSearch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSearch.FieldName = "JvType";
            this.colSearch.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSearch.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSearch.Width = 25;
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
            this.barDockControlTop.Size = new System.Drawing.Size(924, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 484);
            this.barDockControlBottom.Size = new System.Drawing.Size(924, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 453);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Location = new System.Drawing.Point(924, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 453);
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.GridBar});
            this.barManager.DockControls.Add(this.sbdcGridBar);
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiInsert,
            this.bbiMoveUP,
            this.bbiMoveDOWN,
            this.beMoveTO,
            this.bbiNew,
            this.btnGridAdd,
            this.btnGridDelete,
            this.btnGridInsert,
            this.btnScan,
            this.btnCheque,
            this.btnCopyFrom,
            this.bbiImportPDF});
            this.barManager.MaxItemId = 45;
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
            this.sccMain.Size = new System.Drawing.Size(924, 453);
            // 
            // lcSearch
            // 
            this.lcSearch.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(678, 161, 250, 350);
            this.lcSearch.Size = new System.Drawing.Size(120, 453);
            this.lcSearch.Controls.SetChildIndex(this.gcSearch, 0);
            // 
            // lcgSearch
            // 
            this.lcgSearch.Size = new System.Drawing.Size(120, 453);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.cboSubCompanies);
            this.lcMain.Controls.Add(this.cboBanks);
            this.lcMain.Controls.Add(this.cboAccounts);
            this.lcMain.Controls.Add(this.cboCurrencies);
            this.lcMain.Controls.Add(this.chkPrint);
            this.lcMain.Controls.Add(this.chkNew);
            this.lcMain.Controls.Add(this.ucControlNavigator);
            this.lcMain.Controls.Add(this.pccCollect);
            this.lcMain.Controls.Add(this.sbdcGridBar);
            this.lcMain.Controls.Add(this.txtDescription);
            this.lcMain.Controls.Add(this.txtRate);
            this.lcMain.Controls.Add(this.txtBalance2nd);
            this.lcMain.Controls.Add(this.txtCredit2nd);
            this.lcMain.Controls.Add(this.txtDebit2nd);
            this.lcMain.Controls.Add(this.txtBalance1st);
            this.lcMain.Controls.Add(this.txtCredit1st);
            this.lcMain.Controls.Add(this.txtDebit1st);
            this.lcMain.Controls.Add(this.gcDetails);
            this.lcMain.Controls.Add(this.txt2ndRate);
            this.lcMain.Controls.Add(this.deDate);
            this.lcMain.Controls.Add(this.cboVoucherTypes);
            this.lcMain.Controls.Add(this.meDetails);
            this.lcMain.Controls.Add(this.txtFromTo);
            this.lcMain.Controls.Add(this.txtReference);
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1200, 115, 250, 700);
            this.lcMain.Size = new System.Drawing.Size(799, 453);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lcgDetails,
            this.lciType,
            this.lciReference,
            this.lciDate,
            this.lci2ndRate,
            this.lciGridDetails,
            this.lcgInfo,
            this.lcgBalances,
            this.lciGridBar,
            this.simpleSeparator2,
            this.lciControlNavigator,
            this.lciNEw,
            this.lciPrint,
            this.emptySpaceItem1,
            this.lciSubCompanies});
            this.lcgMain.Size = new System.Drawing.Size(799, 453);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("addfile_16x16.png", "office2013/actions/addfile_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/addfile_16x16.png"), 16);
            this.imageCollection.Images.SetKeyName(16, "addfile_16x16.png");
            this.imageCollection.InsertGalleryImage("deletelist_16x16.png", "office2013/actions/deletelist_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/actions/deletelist_16x16.png"), 17);
            this.imageCollection.Images.SetKeyName(17, "deletelist_16x16.png");
            this.imageCollection.InsertGalleryImage("copy_16x16.png", "office2013/edit/copy_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/edit/copy_16x16.png"), 18);
            this.imageCollection.Images.SetKeyName(18, "copy_16x16.png");
            this.imageCollection.InsertGalleryImage("emptytablerowseparator_16x16.png", "office2013/reports/emptytablerowseparator_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/reports/emptytablerowseparator_16x16.png"), 19);
            this.imageCollection.Images.SetKeyName(19, "emptytablerowseparator_16x16.png");
            this.imageCollection.Images.SetKeyName(20, "scan-off.png");
            this.imageCollection.InsertGalleryImage("movedown_16x16.png", "office2013/arrows/movedown_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/movedown_16x16.png"), 21);
            this.imageCollection.Images.SetKeyName(21, "movedown_16x16.png");
            this.imageCollection.InsertGalleryImage("moveup_16x16.png", "office2013/arrows/moveup_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/arrows/moveup_16x16.png"), 22);
            this.imageCollection.Images.SetKeyName(22, "moveup_16x16.png");
            this.imageCollection.InsertGalleryImage("listmultilevel_16x16.png", "office2013/format/listmultilevel_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/format/listmultilevel_16x16.png"), 23);
            this.imageCollection.Images.SetKeyName(23, "listmultilevel_16x16.png");
            this.imageCollection.Images.SetKeyName(24, "Currency.png");
            this.imageCollection.Images.SetKeyName(25, "DebitCredit.png");
            this.imageCollection.InsertGalleryImage("currency_16x16.png", "office2013/miscellaneous/currency_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/miscellaneous/currency_16x16.png"), 26);
            this.imageCollection.Images.SetKeyName(26, "currency_16x16.png");
            // 
            // bciPosted
            // 
            this.bciPosted.ItemAppearance.Pressed.BackColor = System.Drawing.Color.Transparent;
            this.bciPosted.ItemAppearance.Pressed.Options.UseBackColor = true;
            // 
            // bsSearch
            // 
            this.bsSearch.DataSource = typeof(Accounting.JournalSearchList);
            // 
            // colDocument
            // 
            this.colDocument.AlwaysDisabled = false;
            this.colDocument.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.colDocument.AppearanceCell.Options.UseFont = true;
            this.colDocument.Caption = "Document";
            this.colDocument.ColumnEdit = this.ripceCollect;
            this.colDocument.CustomData = "";
            this.colDocument.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDocument.EditDisabled = false;
            this.colDocument.FieldName = "Document";
            this.colDocument.Name = "colDocument";
            this.colDocument.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDocument.Visible = true;
            this.colDocument.VisibleIndex = 2;
            this.colDocument.Width = 60;
            // 
            // ripceCollect
            // 
            this.ripceCollect.AutoHeight = false;
            this.ripceCollect.Mask.EditMask = "\\w\\w\\w\\w\\w\\w\\w \\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w\\w";
            this.ripceCollect.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.ripceCollect.MaxLength = 45;
            this.ripceCollect.Name = "ripceCollect";
            this.ripceCollect.NullValuePrompt = "Select Account";
            this.ripceCollect.NullValuePromptShowForEmptyValue = true;
            this.ripceCollect.PopupControl = this.pccCollect;
            this.ripceCollect.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // pccCollect
            // 
            this.pccCollect.Controls.Add(this.gcCollect);
            this.pccCollect.Location = new System.Drawing.Point(100, 106);
            this.pccCollect.Name = "pccCollect";
            this.pccCollect.Size = new System.Drawing.Size(390, 196);
            this.pccCollect.TabIndex = 1;
            // 
            // gcCollect
            // 
            this.gcCollect.DataSource = this.bsCollect;
            this.gcCollect.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.gcCollect.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gcCollect.EmbeddedNavigatorHideButtons = false;
            this.gcCollect.Location = new System.Drawing.Point(0, 0);
            this.gcCollect.MainView = this.gvCollect;
            this.gcCollect.MenuManager = this.barManager;
            this.gcCollect.Name = "gcCollect";
            this.gcCollect.Size = new System.Drawing.Size(390, 196);
            this.gcCollect.TabIndex = 0;
            this.gcCollect.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvCollect});
            this.gcCollect.DoubleClick += new System.EventHandler(this.gcCollect_DoubleClick);
            this.gcCollect.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gcCollect_KeyDown);
            // 
            // bsCollect
            // 
            this.bsCollect.DataSource = typeof(Accounting.Collect);
            // 
            // gvCollect
            // 
            this.gvCollect.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDocument1,
            this.colMaturity1,
            this.colcur,
            this.colAmount1,
            this.colBank,
            this.coldc1});
            this.gvCollect.GridControl = this.gcCollect;
            this.gvCollect.HighLightFocusedRow = true;
            this.gvCollect.Name = "gvCollect";
            this.gvCollect.OptionsBehavior.ReadOnly = true;
            this.gvCollect.OptionsView.ColumnAutoWidth = false;
            this.gvCollect.OptionsView.ShowAutoFilterRow = true;
            this.gvCollect.OptionsView.ShowGroupPanel = false;
            this.gvCollect.OptionsView.ShowIndicator = false;
            this.gvCollect.ParentForm = null;
            this.gvCollect.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvCollect.VisibleAutoFilterRow = true;
            this.gvCollect.VisibleGroupPanel = false;
            this.gvCollect.VisibleIndicator = false;
            // 
            // colDocument1
            // 
            this.colDocument1.AlwaysDisabled = false;
            this.colDocument1.AppearanceHeader.Options.UseTextOptions = true;
            this.colDocument1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDocument1.CustomData = "";
            this.colDocument1.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colDocument1.EditDisabled = false;
            this.colDocument1.FieldName = "Document";
            this.colDocument1.Name = "colDocument1";
            this.colDocument1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDocument1.Visible = true;
            this.colDocument1.VisibleIndex = 0;
            this.colDocument1.Width = 70;
            // 
            // colMaturity1
            // 
            this.colMaturity1.AlwaysDisabled = false;
            this.colMaturity1.AppearanceHeader.Options.UseTextOptions = true;
            this.colMaturity1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colMaturity1.CustomData = "";
            this.colMaturity1.EditDisabled = false;
            this.colMaturity1.FieldName = "Maturity";
            this.colMaturity1.Name = "colMaturity1";
            this.colMaturity1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMaturity1.Visible = true;
            this.colMaturity1.VisibleIndex = 1;
            this.colMaturity1.Width = 70;
            // 
            // colcur
            // 
            this.colcur.AlwaysDisabled = false;
            this.colcur.AppearanceHeader.Options.UseTextOptions = true;
            this.colcur.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colcur.Caption = "C";
            this.colcur.CustomData = "";
            this.colcur.EditDisabled = false;
            this.colcur.FieldName = "cur";
            this.colcur.Name = "colcur";
            this.colcur.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colcur.Visible = true;
            this.colcur.VisibleIndex = 2;
            this.colcur.Width = 71;
            // 
            // colAmount1
            // 
            this.colAmount1.AlwaysDisabled = false;
            this.colAmount1.AppearanceHeader.Options.UseTextOptions = true;
            this.colAmount1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAmount1.CustomData = "";
            this.colAmount1.EditDisabled = false;
            this.colAmount1.FieldName = "Amount";
            this.colAmount1.Name = "colAmount1";
            this.colAmount1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount1.Visible = true;
            this.colAmount1.VisibleIndex = 3;
            this.colAmount1.Width = 90;
            // 
            // colBank
            // 
            this.colBank.AlwaysDisabled = false;
            this.colBank.AppearanceHeader.Options.UseTextOptions = true;
            this.colBank.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colBank.CustomData = "";
            this.colBank.EditDisabled = false;
            this.colBank.FieldName = "Bank";
            this.colBank.Name = "colBank";
            this.colBank.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBank.Visible = true;
            this.colBank.VisibleIndex = 4;
            this.colBank.Width = 85;
            // 
            // coldc1
            // 
            this.coldc1.AlwaysDisabled = false;
            this.coldc1.AppearanceHeader.Options.UseTextOptions = true;
            this.coldc1.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.coldc1.Caption = "DC";
            this.coldc1.CustomData = "";
            this.coldc1.EditDisabled = false;
            this.coldc1.FieldName = "dc";
            this.coldc1.Name = "coldc1";
            this.coldc1.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.coldc1.Visible = true;
            this.coldc1.VisibleIndex = 5;
            this.coldc1.Width = 23;
            // 
            // colDc
            // 
            this.colDc.AlwaysDisabled = false;
            this.colDc.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.colDc.AppearanceCell.Options.UseFont = true;
            this.colDc.ColumnEdit = this.riDC;
            this.colDc.CustomData = "";
            this.colDc.EditDisabled = false;
            this.colDc.FieldName = "Dc";
            this.colDc.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colDc.ImageIndex = 25;
            this.colDc.Name = "colDc";
            this.colDc.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDc.Visible = true;
            this.colDc.VisibleIndex = 6;
            this.colDc.Width = 24;
            // 
            // riDC
            // 
            this.riDC.AutoHeight = false;
            this.riDC.Items.AddRange(new object[] {
            "D",
            "C"});
            this.riDC.Name = "riDC";
            this.riDC.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            // 
            // bsDetails
            // 
            this.bsDetails.DataSource = this.bsMaster;
            this.bsDetails.PositionChanged += new System.EventHandler(this.bsDetails_PositionChanged);
            // 
            // txtFromTo
            // 
            this.txtFromTo.AllowLeadingSpace = false;
            this.txtFromTo.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "Fromto", true));
            this.txtFromTo.DefaultState = efControls.Enums.ControlState.Default;
            this.txtFromTo.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtFromTo.EnterMoveNextControl = true;
            this.txtFromTo.Information = null;
            this.txtFromTo.Location = new System.Drawing.Point(56, 27);
            this.txtFromTo.MenuManager = this.barManager;
            this.txtFromTo.Name = "txtFromTo";
            this.txtFromTo.Properties.ReadOnly = true;
            this.txtFromTo.Size = new System.Drawing.Size(712, 20);
            this.txtFromTo.StyleController = this.lcMain;
            this.txtFromTo.TabIndex = 14;
            // 
            // lciFromTo
            // 
            this.lciFromTo.Control = this.txtFromTo;
            this.lciFromTo.CustomizationFormText = "lciFromTo";
            this.lciFromTo.IsRequired = null;
            this.lciFromTo.Location = new System.Drawing.Point(0, 0);
            this.lciFromTo.Name = "lciFromTo";
            this.lciFromTo.Size = new System.Drawing.Size(770, 24);
            this.lciFromTo.Text = "From/To";
            this.lciFromTo.TextSize = new System.Drawing.Size(50, 13);
            // 
            // meDetails
            // 
            this.meDetails.AllowLeadingSpace = false;
            this.meDetails.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "Details", true));
            this.meDetails.DefaultState = efControls.Enums.ControlState.Default;
            this.meDetails.DisplayType = efControls.Enums.DisplayType.Default;
            this.meDetails.Information = null;
            this.meDetails.Location = new System.Drawing.Point(56, 51);
            this.meDetails.MenuManager = this.barManager;
            this.meDetails.Name = "meDetails";
            this.meDetails.Properties.Appearance.Font = new System.Drawing.Font("Courier New", 8.25F);
            this.meDetails.Properties.Appearance.Options.UseFont = true;
            this.meDetails.Properties.ReadOnly = true;
            this.meDetails.Size = new System.Drawing.Size(712, 73);
            this.meDetails.StyleController = this.lcMain;
            this.meDetails.TabIndex = 28;
            // 
            // lciDetails
            // 
            this.lciDetails.AppearanceItemCaption.Options.UseTextOptions = true;
            this.lciDetails.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.lciDetails.Control = this.meDetails;
            this.lciDetails.CustomizationFormText = "lciDetails";
            this.lciDetails.IsRequired = null;
            this.lciDetails.Location = new System.Drawing.Point(0, 24);
            this.lciDetails.MaxSize = new System.Drawing.Size(0, 77);
            this.lciDetails.MinSize = new System.Drawing.Size(68, 77);
            this.lciDetails.Name = "lciDetails";
            this.lciDetails.Size = new System.Drawing.Size(770, 77);
            this.lciDetails.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDetails.Text = "Details";
            this.lciDetails.TextSize = new System.Drawing.Size(50, 13);
            // 
            // lcgDetails
            // 
            this.lcgDetails.CustomizationFormText = "lcgDetails";
            this.lcgDetails.ExpandButtonVisible = true;
            this.lcgDetails.Expanded = false;
            this.lcgDetails.GroupBordersVisible = false;
            this.lcgDetails.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.lcgDetails.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciFromTo,
            this.lciDetails});
            this.lcgDetails.Location = new System.Drawing.Point(0, 25);
            this.lcgDetails.Name = "lcgDetails";
            this.lcgDetails.Padding = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgDetails.Size = new System.Drawing.Size(799, 3);
            this.lcgDetails.Spacing = new DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0);
            this.lcgDetails.Text = "...";
            // 
            // cboVoucherTypes
            // 
            this.cboVoucherTypes.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "Vouchertypeid", true));
            this.cboVoucherTypes.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboVoucherTypes.EnterMoveNextControl = true;
            this.cboVoucherTypes.Filter = Accounting.cboVoucherTypes.jvFilter.JV;
            this.cboVoucherTypes.Location = new System.Drawing.Point(56, 2);
            this.cboVoucherTypes.MenuManager = this.barManager;
            this.cboVoucherTypes.Name = "cboVoucherTypes";
            this.cboVoucherTypes.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboVoucherTypes.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboVoucherTypes.Properties.Name = "efComboBox";
            this.cboVoucherTypes.Size = new System.Drawing.Size(157, 20);
            this.cboVoucherTypes.StyleController = this.lcMain;
            this.cboVoucherTypes.TabIndex = 31;
            this.cboVoucherTypes.EditValueChanged += new System.EventHandler(this.cboVoucherTypes_EditValueChanged);
            this.cboVoucherTypes.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cboVoucherTypes_EditValueChanging);
            // 
            // lciType
            // 
            this.lciType.Control = this.cboVoucherTypes;
            this.lciType.CustomizationFormText = "lciType";
            this.lciType.IsRequired = null;
            this.lciType.Location = new System.Drawing.Point(0, 0);
            this.lciType.MaxSize = new System.Drawing.Size(215, 24);
            this.lciType.MinSize = new System.Drawing.Size(215, 24);
            this.lciType.Name = "lciType";
            this.lciType.Size = new System.Drawing.Size(215, 25);
            this.lciType.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciType.Text = "Type";
            this.lciType.TextSize = new System.Drawing.Size(50, 13);
            // 
            // lciReference
            // 
            this.lciReference.Control = this.txtReference;
            this.lciReference.CustomizationFormText = "lciReference";
            this.lciReference.IsRequired = null;
            this.lciReference.Location = new System.Drawing.Point(243, 0);
            this.lciReference.MaxSize = new System.Drawing.Size(120, 0);
            this.lciReference.MinSize = new System.Drawing.Size(120, 25);
            this.lciReference.Name = "lciReference";
            this.lciReference.Size = new System.Drawing.Size(120, 25);
            this.lciReference.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciReference.Text = "Reference";
            this.lciReference.TextSize = new System.Drawing.Size(50, 13);
            // 
            // txtReference
            // 
            this.txtReference.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "Reference", true));
            this.txtReference.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtReference.DisplayType = efControls.Enums.DisplayType.Integer;
            this.txtReference.EnterMoveNextControl = true;
            this.txtReference.HighLighted = false;
            this.txtReference.Location = new System.Drawing.Point(299, 2);
            this.txtReference.MenuManager = this.barManager;
            this.txtReference.Name = "txtReference";
            this.txtReference.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtReference.Properties.Name = "efButtonEdit";
            this.txtReference.Properties.ReadOnly = true;
            this.txtReference.Size = new System.Drawing.Size(62, 20);
            this.txtReference.StyleController = this.lcMain;
            this.txtReference.TabIndex = 32;
            this.txtReference.TabStop = false;
            this.txtReference.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtReference_ButtonClick);
            // 
            // deDate
            // 
            this.deDate.AllowLeadingSpace = false;
            this.deDate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "Jvdate", true));
            this.deDate.DefaultState = efControls.Enums.ControlState.Default;
            this.deDate.DisplayType = efControls.Enums.DisplayType.Default;
            this.deDate.EditValue = null;
            this.deDate.EnterMoveNextControl = true;
            this.deDate.Information = null;
            this.deDate.Location = new System.Drawing.Point(419, 2);
            this.deDate.MenuManager = this.barManager;
            this.deDate.Name = "deDate";
            this.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.deDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deDate.Properties.ReadOnly = true;
            this.deDate.Size = new System.Drawing.Size(67, 20);
            this.deDate.StyleController = this.lcMain;
            this.deDate.TabIndex = 33;
            this.deDate.Validating += new System.ComponentModel.CancelEventHandler(this.deDate_Validating);
            this.deDate.Validated += new System.EventHandler(this.deDate_Validated);
            // 
            // lciDate
            // 
            this.lciDate.Control = this.deDate;
            this.lciDate.CustomizationFormText = "lciDate";
            this.lciDate.IsRequired = null;
            this.lciDate.Location = new System.Drawing.Point(363, 0);
            this.lciDate.MaxSize = new System.Drawing.Size(125, 24);
            this.lciDate.MinSize = new System.Drawing.Size(125, 24);
            this.lciDate.Name = "lciDate";
            this.lciDate.Size = new System.Drawing.Size(125, 25);
            this.lciDate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciDate.Text = "Date";
            this.lciDate.TextSize = new System.Drawing.Size(50, 13);
            // 
            // txt2ndRate
            // 
            this.txt2ndRate.AllowLeadingSpace = false;
            this.txt2ndRate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "Rate2nd", true));
            this.txt2ndRate.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txt2ndRate.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txt2ndRate.EnterMoveNextControl = true;
            this.txt2ndRate.Information = null;
            this.txt2ndRate.Location = new System.Drawing.Point(544, 2);
            this.txt2ndRate.MenuManager = this.barManager;
            this.txt2ndRate.Name = "txt2ndRate";
            this.txt2ndRate.Properties.Appearance.Options.UseTextOptions = true;
            this.txt2ndRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txt2ndRate.Properties.DisplayFormat.FormatString = "n2";
            this.txt2ndRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txt2ndRate.Properties.Mask.EditMask = "N2";
            this.txt2ndRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txt2ndRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txt2ndRate.Properties.ReadOnly = true;
            this.txt2ndRate.Size = new System.Drawing.Size(62, 20);
            this.txt2ndRate.StyleController = this.lcMain;
            this.txt2ndRate.TabIndex = 34;
            this.txt2ndRate.TabStop = false;
            // 
            // lci2ndRate
            // 
            this.lci2ndRate.Control = this.txt2ndRate;
            this.lci2ndRate.CustomizationFormText = "lciRate";
            this.lci2ndRate.IsRequired = null;
            this.lci2ndRate.Location = new System.Drawing.Point(488, 0);
            this.lci2ndRate.MaxSize = new System.Drawing.Size(120, 24);
            this.lci2ndRate.MinSize = new System.Drawing.Size(120, 24);
            this.lci2ndRate.Name = "lci2ndRate";
            this.lci2ndRate.Size = new System.Drawing.Size(120, 25);
            this.lci2ndRate.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lci2ndRate.Text = "Rate";
            this.lci2ndRate.TextSize = new System.Drawing.Size(50, 13);
            // 
            // gcDetails
            // 
            this.gcDetails.DataSource = this.bsDetails;
            this.gcDetails.DefaultState = efControls.Enums.ControlState.Default;
            this.gcDetails.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(30);
            this.gcDetails.EmbeddedNavigator.Padding = new System.Windows.Forms.Padding(10);
            this.gcDetails.EmbeddedNavigatorHideButtons = false;
            this.gcDetails.Font = new System.Drawing.Font("Tahoma", 7F);
            this.gcDetails.Location = new System.Drawing.Point(2, 30);
            this.gcDetails.MainView = this.gvDetails;
            this.gcDetails.MenuManager = this.barManager;
            this.gcDetails.Name = "gcDetails";
            this.gcDetails.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.riCurrencies,
            this.riDC,
            this.riAmounts,
            this.ritxtDescription,
            this.riAccounts,
            this.riBanks,
            this.rideMaturity,
            this.ripceCollect});
            this.gcDetails.Size = new System.Drawing.Size(795, 320);
            this.gcDetails.TabIndex = 30;
            this.gcDetails.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvDetails});
            // 
            // gvDetails
            // 
            this.gvDetails.Appearance.Preview.ForeColor = System.Drawing.Color.Blue;
            this.gvDetails.Appearance.Preview.Options.UseForeColor = true;
            this.gvDetails.Appearance.Preview.Options.UseTextOptions = true;
            this.gvDetails.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.gvDetails.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gvDetails.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.gvDetails.Appearance.SelectedRow.Options.UseFont = true;
            this.gvDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colLine,
            this.colAccount,
            this.colDocument,
            this.colMaturity,
            this.colCurrencyid,
            this.colAmount,
            this.colDc,
            this.colDescription,
            this.colBankid,
            this.colAmount1st,
            this.colAmount2nd,
            this.colStatus});
            this.gvDetails.GridControl = this.gcDetails;
            this.gvDetails.HighLightFocusedRow = false;
            this.gvDetails.Images = this.imageCollection;
            this.gvDetails.Name = "gvDetails";
            this.gvDetails.OptionsBehavior.ReadOnly = true;
            this.gvDetails.OptionsCustomization.AllowColumnMoving = false;
            this.gvDetails.OptionsDetail.EnableMasterViewMode = false;
            this.gvDetails.OptionsFind.AllowFindPanel = false;
            this.gvDetails.OptionsMenu.EnableColumnMenu = false;
            this.gvDetails.OptionsMenu.EnableFooterMenu = false;
            this.gvDetails.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvDetails.OptionsNavigation.AutoFocusNewRow = true;
            this.gvDetails.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvDetails.OptionsSelection.EnableAppearanceFocusedRow = false;
            this.gvDetails.OptionsSelection.EnableAppearanceHideSelection = false;
            this.gvDetails.OptionsView.AutoCalcPreviewLineCount = true;
            this.gvDetails.OptionsView.ColumnAutoWidth = false;
            this.gvDetails.OptionsView.ShowAutoFilterRow = true;
            this.gvDetails.OptionsView.ShowGroupPanel = false;
            this.gvDetails.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvDetails.ParentForm = this;
            this.gvDetails.PreviewFieldName = "Description";
            this.gvDetails.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colLine, DevExpress.Data.ColumnSortOrder.Ascending)});
            this.gvDetails.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvDetails.VisibleAutoFilterRow = true;
            this.gvDetails.VisibleGroupPanel = false;
            this.gvDetails.VisibleIndicator = true;
            this.gvDetails.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gvDetails_RowClick);
            this.gvDetails.RowCellStyle += new DevExpress.XtraGrid.Views.Grid.RowCellStyleEventHandler(this.gvDetails_RowCellStyle);
            this.gvDetails.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gvDetails_RowStyle);
            this.gvDetails.ShowingEditor += new System.ComponentModel.CancelEventHandler(this.gvDetails_ShowingEditor);
            this.gvDetails.ShownEditor += new System.EventHandler(this.gvDetails_ShownEditor);
            this.gvDetails.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gvDetails_FocusedRowChanged);
            this.gvDetails.FocusedColumnChanged += new DevExpress.XtraGrid.Views.Base.FocusedColumnChangedEventHandler(this.gvDetails_FocusedColumnChanged);
            this.gvDetails.CellValueChanged += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDetails_CellValueChanged);
            this.gvDetails.CellValueChanging += new DevExpress.XtraGrid.Views.Base.CellValueChangedEventHandler(this.gvDetails_CellValueChanging);
            this.gvDetails.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gvDetails_KeyDown);
            this.gvDetails.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.gvDetails_ValidatingEditor);
            // 
            // colLine
            // 
            this.colLine.AlwaysDisabled = true;
            this.colLine.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.colLine.AppearanceCell.Options.UseFont = true;
            this.colLine.Caption = " ";
            this.colLine.CustomData = "";
            this.colLine.DisplayFormat.FormatString = "n2";
            this.colLine.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colLine.EditDisabled = false;
            this.colLine.FieldName = "Line";
            this.colLine.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colLine.ImageIndex = 23;
            this.colLine.Name = "colLine";
            this.colLine.OptionsColumn.AllowEdit = false;
            this.colLine.OptionsColumn.AllowFocus = false;
            this.colLine.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colLine.OptionsColumn.ReadOnly = true;
            this.colLine.SortMode = DevExpress.XtraGrid.ColumnSortMode.Value;
            this.colLine.Visible = true;
            this.colLine.VisibleIndex = 0;
            this.colLine.Width = 25;
            // 
            // colAccount
            // 
            this.colAccount.AlwaysDisabled = false;
            this.colAccount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.colAccount.AppearanceCell.Options.UseFont = true;
            this.colAccount.Caption = "Account";
            this.colAccount.ColumnEdit = this.riAccounts;
            this.colAccount.CustomData = "";
            this.colAccount.EditDisabled = false;
            this.colAccount.FieldName = "Accountid";
            this.colAccount.Name = "colAccount";
            this.colAccount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAccount.Visible = true;
            this.colAccount.VisibleIndex = 1;
            this.colAccount.Width = 67;
            // 
            // riAccounts
            // 
            this.riAccounts.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.riAccounts.AutoHeight = false;
            this.riAccounts.DataSource = this.bsAccounts;
            this.riAccounts.DisplayMember = "Code";
            this.riAccounts.KeyMember = "ID";
            this.riAccounts.Name = "riAccounts";
            this.riAccounts.NullText = "";
            this.riAccounts.NullValuePrompt = "Select Account";
            this.riAccounts.NullValuePromptShowForEmptyValue = true;
            this.riAccounts.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.riAccounts.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.riAccounts.ValidateOnEnterKey = true;
            this.riAccounts.ValueMember = "ID";
            this.riAccounts.View = this.riAccountsView;
            // 
            // bsAccounts
            // 
            this.bsAccounts.DataSource = typeof(Accounting.ucAccounts);
            // 
            // riAccountsView
            // 
            this.riAccountsView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCodeDescription});
            this.riAccountsView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.riAccountsView.Name = "riAccountsView";
            this.riAccountsView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.riAccountsView.OptionsView.ShowGroupPanel = false;
            // 
            // colCodeDescription
            // 
            this.colCodeDescription.AlwaysDisabled = false;
            this.colCodeDescription.CustomData = "";
            this.colCodeDescription.EditDisabled = false;
            this.colCodeDescription.FieldName = "CodeDescription";
            this.colCodeDescription.Name = "colCodeDescription";
            this.colCodeDescription.Visible = true;
            this.colCodeDescription.VisibleIndex = 0;
            // 
            // colMaturity
            // 
            this.colMaturity.AlwaysDisabled = false;
            this.colMaturity.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.colMaturity.AppearanceCell.Options.UseFont = true;
            this.colMaturity.ColumnEdit = this.rideMaturity;
            this.colMaturity.CustomData = "";
            this.colMaturity.EditDisabled = false;
            this.colMaturity.FieldName = "Maturity";
            this.colMaturity.Name = "colMaturity";
            this.colMaturity.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colMaturity.Visible = true;
            this.colMaturity.VisibleIndex = 3;
            this.colMaturity.Width = 65;
            // 
            // rideMaturity
            // 
            this.rideMaturity.AutoHeight = false;
            this.rideMaturity.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.rideMaturity.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.rideMaturity.Name = "rideMaturity";
            // 
            // colCurrencyid
            // 
            this.colCurrencyid.AlwaysDisabled = false;
            this.colCurrencyid.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.colCurrencyid.AppearanceCell.Options.UseFont = true;
            this.colCurrencyid.ColumnEdit = this.riCurrencies;
            this.colCurrencyid.CustomData = "";
            this.colCurrencyid.EditDisabled = false;
            this.colCurrencyid.FieldName = "Currencyid";
            this.colCurrencyid.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.colCurrencyid.ImageIndex = 26;
            this.colCurrencyid.Name = "colCurrencyid";
            this.colCurrencyid.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCurrencyid.Visible = true;
            this.colCurrencyid.VisibleIndex = 4;
            this.colCurrencyid.Width = 25;
            // 
            // riCurrencies
            // 
            this.riCurrencies.AutoHeight = false;
            this.riCurrencies.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Description", "Description", 63, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.riCurrencies.DataSource = this.bsCurrencies;
            this.riCurrencies.DisplayMember = "Code";
            this.riCurrencies.Name = "riCurrencies";
            this.riCurrencies.NullText = " ";
            this.riCurrencies.ValueMember = "ID";
            this.riCurrencies.EditValueChanged += new System.EventHandler(this.riCurrencies_EditValueChanged);
            // 
            // bsCurrencies
            // 
            this.bsCurrencies.DataSource = typeof(Accounting.Currency);
            // 
            // colAmount
            // 
            this.colAmount.AlwaysDisabled = false;
            this.colAmount.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.colAmount.AppearanceCell.Options.UseFont = true;
            this.colAmount.ColumnEdit = this.riAmounts;
            this.colAmount.CustomData = "";
            this.colAmount.EditDisabled = false;
            this.colAmount.FieldName = "Amount";
            this.colAmount.Name = "colAmount";
            this.colAmount.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount.Visible = true;
            this.colAmount.VisibleIndex = 5;
            // 
            // riAmounts
            // 
            this.riAmounts.AutoHeight = false;
            this.riAmounts.DisplayFormat.FormatString = "n2";
            this.riAmounts.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riAmounts.EditFormat.FormatString = "n2";
            this.riAmounts.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.riAmounts.Mask.EditMask = "n2";
            this.riAmounts.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.riAmounts.Name = "riAmounts";
            // 
            // colDescription
            // 
            this.colDescription.AlwaysDisabled = false;
            this.colDescription.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.colDescription.AppearanceCell.Options.UseFont = true;
            this.colDescription.ColumnEdit = this.ritxtDescription;
            this.colDescription.CustomData = "";
            this.colDescription.EditDisabled = false;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 7;
            this.colDescription.Width = 206;
            // 
            // ritxtDescription
            // 
            this.ritxtDescription.AutoHeight = false;
            this.ritxtDescription.MaxLength = 80;
            this.ritxtDescription.Name = "ritxtDescription";
            // 
            // colBankid
            // 
            this.colBankid.AlwaysDisabled = false;
            this.colBankid.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.colBankid.AppearanceCell.Options.UseFont = true;
            this.colBankid.Caption = "Bank";
            this.colBankid.ColumnEdit = this.riBanks;
            this.colBankid.CustomData = "";
            this.colBankid.EditDisabled = false;
            this.colBankid.FieldName = "Bankid";
            this.colBankid.Name = "colBankid";
            this.colBankid.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colBankid.Visible = true;
            this.colBankid.VisibleIndex = 8;
            this.colBankid.Width = 40;
            // 
            // riBanks
            // 
            this.riBanks.AutoHeight = false;
            this.riBanks.DataSource = this.bsBanks;
            this.riBanks.DisplayMember = "Code";
            this.riBanks.Name = "riBanks";
            this.riBanks.NullText = "";
            this.riBanks.NullValuePrompt = "Select Bank";
            this.riBanks.NullValuePromptShowForEmptyValue = true;
            this.riBanks.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            this.riBanks.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.riBanks.ValidateOnEnterKey = true;
            this.riBanks.ValueMember = "ID";
            this.riBanks.View = this.riBanksView;
            // 
            // bsBanks
            // 
            this.bsBanks.DataSource = typeof(Accounting.ucBanks);
            // 
            // riBanksView
            // 
            this.riBanksView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColBank});
            this.riBanksView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.riBanksView.Name = "riBanksView";
            this.riBanksView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.riBanksView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColBank
            // 
            this.gridColBank.AlwaysDisabled = false;
            this.gridColBank.CustomData = "";
            this.gridColBank.EditDisabled = false;
            this.gridColBank.FieldName = "CodeDescription";
            this.gridColBank.Name = "gridColBank";
            this.gridColBank.Visible = true;
            this.gridColBank.VisibleIndex = 0;
            // 
            // colAmount1st
            // 
            this.colAmount1st.AlwaysDisabled = false;
            this.colAmount1st.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.colAmount1st.AppearanceCell.Options.UseFont = true;
            this.colAmount1st.Caption = "1st Local";
            this.colAmount1st.ColumnEdit = this.riAmounts;
            this.colAmount1st.CustomData = "";
            this.colAmount1st.DisplayFormat.FormatString = "n";
            this.colAmount1st.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount1st.EditDisabled = false;
            this.colAmount1st.FieldName = "Amount1st";
            this.colAmount1st.Name = "colAmount1st";
            this.colAmount1st.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount1st.Visible = true;
            this.colAmount1st.VisibleIndex = 9;
            this.colAmount1st.Width = 85;
            // 
            // colAmount2nd
            // 
            this.colAmount2nd.AlwaysDisabled = false;
            this.colAmount2nd.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 7F);
            this.colAmount2nd.AppearanceCell.Options.UseFont = true;
            this.colAmount2nd.Caption = "2nd Local";
            this.colAmount2nd.ColumnEdit = this.riAmounts;
            this.colAmount2nd.CustomData = "";
            this.colAmount2nd.DisplayFormat.FormatString = "n";
            this.colAmount2nd.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colAmount2nd.EditDisabled = false;
            this.colAmount2nd.FieldName = "Amount2nd";
            this.colAmount2nd.Name = "colAmount2nd";
            this.colAmount2nd.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colAmount2nd.Visible = true;
            this.colAmount2nd.VisibleIndex = 10;
            // 
            // colStatus
            // 
            this.colStatus.AlwaysDisabled = false;
            this.colStatus.AppearanceHeader.Options.UseTextOptions = true;
            this.colStatus.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colStatus.CustomData = "";
            this.colStatus.EditDisabled = false;
            this.colStatus.FieldName = "Chartofaccount.AccountStatu.Code";
            this.colStatus.Name = "colStatus";
            this.colStatus.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colStatus.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            // 
            // lciGridDetails
            // 
            this.lciGridDetails.Control = this.gcDetails;
            this.lciGridDetails.CustomizationFormText = "lciGridDetails";
            this.lciGridDetails.IsRequired = null;
            this.lciGridDetails.Location = new System.Drawing.Point(0, 28);
            this.lciGridDetails.Name = "lciGridDetails";
            this.lciGridDetails.Size = new System.Drawing.Size(799, 324);
            this.lciGridDetails.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridDetails.TextVisible = false;
            // 
            // txtDebit1st
            // 
            this.txtDebit1st.AllowLeadingSpace = false;
            this.txtDebit1st.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtDebit1st.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txtDebit1st.EnterMoveNextControl = true;
            this.txtDebit1st.Information = null;
            this.txtDebit1st.Location = new System.Drawing.Point(597, 386);
            this.txtDebit1st.MenuManager = this.barManager;
            this.txtDebit1st.Name = "txtDebit1st";
            this.txtDebit1st.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.txtDebit1st.Properties.Appearance.Options.UseFont = true;
            this.txtDebit1st.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDebit1st.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDebit1st.Properties.Mask.EditMask = "N2";
            this.txtDebit1st.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDebit1st.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDebit1st.Properties.ReadOnly = true;
            this.txtDebit1st.Size = new System.Drawing.Size(98, 18);
            this.txtDebit1st.StyleController = this.lcMain;
            this.txtDebit1st.TabIndex = 36;
            // 
            // lciDebit1st
            // 
            this.lciDebit1st.Control = this.txtDebit1st;
            this.lciDebit1st.CustomizationFormText = "lciDebit1st";
            this.lciDebit1st.IsRequired = null;
            this.lciDebit1st.Location = new System.Drawing.Point(0, 0);
            this.lciDebit1st.Name = "lciDebit1st";
            this.lciDebit1st.Size = new System.Drawing.Size(147, 22);
            this.lciDebit1st.Text = "Debit";
            this.lciDebit1st.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciDebit1st.TextSize = new System.Drawing.Size(40, 13);
            this.lciDebit1st.TextToControlDistance = 5;
            // 
            // txtCredit1st
            // 
            this.txtCredit1st.AllowLeadingSpace = false;
            this.txtCredit1st.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtCredit1st.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txtCredit1st.EnterMoveNextControl = true;
            this.txtCredit1st.Information = null;
            this.txtCredit1st.Location = new System.Drawing.Point(597, 408);
            this.txtCredit1st.MenuManager = this.barManager;
            this.txtCredit1st.Name = "txtCredit1st";
            this.txtCredit1st.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.txtCredit1st.Properties.Appearance.Options.UseFont = true;
            this.txtCredit1st.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCredit1st.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCredit1st.Properties.DisplayFormat.FormatString = "n2";
            this.txtCredit1st.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCredit1st.Properties.Mask.EditMask = "N2";
            this.txtCredit1st.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCredit1st.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCredit1st.Properties.ReadOnly = true;
            this.txtCredit1st.Size = new System.Drawing.Size(98, 18);
            this.txtCredit1st.StyleController = this.lcMain;
            this.txtCredit1st.TabIndex = 37;
            // 
            // lciCredit1st
            // 
            this.lciCredit1st.Control = this.txtCredit1st;
            this.lciCredit1st.CustomizationFormText = "lciCredit1st";
            this.lciCredit1st.IsRequired = null;
            this.lciCredit1st.Location = new System.Drawing.Point(0, 22);
            this.lciCredit1st.Name = "lciCredit1st";
            this.lciCredit1st.Size = new System.Drawing.Size(147, 22);
            this.lciCredit1st.Text = "Credit";
            this.lciCredit1st.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciCredit1st.TextSize = new System.Drawing.Size(40, 13);
            this.lciCredit1st.TextToControlDistance = 5;
            // 
            // txtBalance1st
            // 
            this.txtBalance1st.AllowLeadingSpace = false;
            this.txtBalance1st.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtBalance1st.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txtBalance1st.EnterMoveNextControl = true;
            this.txtBalance1st.Information = null;
            this.txtBalance1st.Location = new System.Drawing.Point(597, 430);
            this.txtBalance1st.MenuManager = this.barManager;
            this.txtBalance1st.Name = "txtBalance1st";
            this.txtBalance1st.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBalance1st.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.txtBalance1st.Properties.Appearance.Options.UseBackColor = true;
            this.txtBalance1st.Properties.Appearance.Options.UseFont = true;
            this.txtBalance1st.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBalance1st.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtBalance1st.Properties.DisplayFormat.FormatString = "n2";
            this.txtBalance1st.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBalance1st.Properties.Mask.EditMask = "N2";
            this.txtBalance1st.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBalance1st.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBalance1st.Properties.ReadOnly = true;
            this.txtBalance1st.Size = new System.Drawing.Size(98, 18);
            this.txtBalance1st.StyleController = this.lcMain;
            this.txtBalance1st.TabIndex = 38;
            // 
            // lciBalance1st
            // 
            this.lciBalance1st.Control = this.txtBalance1st;
            this.lciBalance1st.CustomizationFormText = "lciBalance1st";
            this.lciBalance1st.IsRequired = null;
            this.lciBalance1st.Location = new System.Drawing.Point(0, 44);
            this.lciBalance1st.Name = "lciBalance1st";
            this.lciBalance1st.Size = new System.Drawing.Size(147, 25);
            this.lciBalance1st.Text = "Balance";
            this.lciBalance1st.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.CustomSize;
            this.lciBalance1st.TextSize = new System.Drawing.Size(40, 13);
            this.lciBalance1st.TextToControlDistance = 5;
            // 
            // txtDebit2nd
            // 
            this.txtDebit2nd.AllowLeadingSpace = false;
            this.txtDebit2nd.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtDebit2nd.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txtDebit2nd.EnterMoveNextControl = true;
            this.txtDebit2nd.Information = null;
            this.txtDebit2nd.Location = new System.Drawing.Point(699, 386);
            this.txtDebit2nd.MenuManager = this.barManager;
            this.txtDebit2nd.Name = "txtDebit2nd";
            this.txtDebit2nd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.txtDebit2nd.Properties.Appearance.Options.UseFont = true;
            this.txtDebit2nd.Properties.Appearance.Options.UseTextOptions = true;
            this.txtDebit2nd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtDebit2nd.Properties.DisplayFormat.FormatString = "n2";
            this.txtDebit2nd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtDebit2nd.Properties.Mask.EditMask = "N2";
            this.txtDebit2nd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDebit2nd.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtDebit2nd.Properties.ReadOnly = true;
            this.txtDebit2nd.Size = new System.Drawing.Size(98, 18);
            this.txtDebit2nd.StyleController = this.lcMain;
            this.txtDebit2nd.TabIndex = 39;
            // 
            // lciDebit2nd
            // 
            this.lciDebit2nd.Control = this.txtDebit2nd;
            this.lciDebit2nd.CustomizationFormText = "lci9";
            this.lciDebit2nd.IsRequired = null;
            this.lciDebit2nd.Location = new System.Drawing.Point(147, 0);
            this.lciDebit2nd.Name = "lciDebit2nd";
            this.lciDebit2nd.Size = new System.Drawing.Size(102, 22);
            this.lciDebit2nd.TextSize = new System.Drawing.Size(0, 0);
            this.lciDebit2nd.TextVisible = false;
            // 
            // txtCredit2nd
            // 
            this.txtCredit2nd.AllowLeadingSpace = false;
            this.txtCredit2nd.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtCredit2nd.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txtCredit2nd.EnterMoveNextControl = true;
            this.txtCredit2nd.Information = null;
            this.txtCredit2nd.Location = new System.Drawing.Point(699, 408);
            this.txtCredit2nd.MenuManager = this.barManager;
            this.txtCredit2nd.Name = "txtCredit2nd";
            this.txtCredit2nd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.txtCredit2nd.Properties.Appearance.Options.UseFont = true;
            this.txtCredit2nd.Properties.Appearance.Options.UseTextOptions = true;
            this.txtCredit2nd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtCredit2nd.Properties.DisplayFormat.FormatString = "n2";
            this.txtCredit2nd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtCredit2nd.Properties.Mask.EditMask = "N2";
            this.txtCredit2nd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtCredit2nd.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtCredit2nd.Properties.ReadOnly = true;
            this.txtCredit2nd.Size = new System.Drawing.Size(98, 18);
            this.txtCredit2nd.StyleController = this.lcMain;
            this.txtCredit2nd.TabIndex = 40;
            // 
            // lciCredit2nd
            // 
            this.lciCredit2nd.Control = this.txtCredit2nd;
            this.lciCredit2nd.CustomizationFormText = "lci10";
            this.lciCredit2nd.IsRequired = null;
            this.lciCredit2nd.Location = new System.Drawing.Point(147, 22);
            this.lciCredit2nd.Name = "lciCredit2nd";
            this.lciCredit2nd.Size = new System.Drawing.Size(102, 22);
            this.lciCredit2nd.TextSize = new System.Drawing.Size(0, 0);
            this.lciCredit2nd.TextVisible = false;
            // 
            // txtBalance2nd
            // 
            this.txtBalance2nd.AllowLeadingSpace = false;
            this.txtBalance2nd.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtBalance2nd.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txtBalance2nd.EnterMoveNextControl = true;
            this.txtBalance2nd.Information = null;
            this.txtBalance2nd.Location = new System.Drawing.Point(699, 430);
            this.txtBalance2nd.MenuManager = this.barManager;
            this.txtBalance2nd.Name = "txtBalance2nd";
            this.txtBalance2nd.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtBalance2nd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.txtBalance2nd.Properties.Appearance.Options.UseBackColor = true;
            this.txtBalance2nd.Properties.Appearance.Options.UseFont = true;
            this.txtBalance2nd.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBalance2nd.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtBalance2nd.Properties.DisplayFormat.FormatString = "n2";
            this.txtBalance2nd.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBalance2nd.Properties.Mask.EditMask = "N2";
            this.txtBalance2nd.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtBalance2nd.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBalance2nd.Properties.ReadOnly = true;
            this.txtBalance2nd.Size = new System.Drawing.Size(98, 18);
            this.txtBalance2nd.StyleController = this.lcMain;
            this.txtBalance2nd.TabIndex = 41;
            // 
            // lciBalance2nd
            // 
            this.lciBalance2nd.Control = this.txtBalance2nd;
            this.lciBalance2nd.CustomizationFormText = "lci11";
            this.lciBalance2nd.IsRequired = null;
            this.lciBalance2nd.Location = new System.Drawing.Point(147, 44);
            this.lciBalance2nd.Name = "lciBalance2nd";
            this.lciBalance2nd.Size = new System.Drawing.Size(102, 25);
            this.lciBalance2nd.TextSize = new System.Drawing.Size(0, 0);
            this.lciBalance2nd.TextVisible = false;
            // 
            // txtRate
            // 
            this.txtRate.AllowLeadingSpace = false;
            this.txtRate.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDetails, "Ratecurrency", true));
            this.txtRate.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtRate.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txtRate.EnterMoveNextControl = true;
            this.txtRate.Information = null;
            this.txtRate.Location = new System.Drawing.Point(293, 433);
            this.txtRate.MenuManager = this.barManager;
            this.txtRate.Name = "txtRate";
            this.txtRate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.txtRate.Properties.Appearance.Options.UseFont = true;
            this.txtRate.Properties.Appearance.Options.UseTextOptions = true;
            this.txtRate.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtRate.Properties.DisplayFormat.FormatString = "n2";
            this.txtRate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtRate.Properties.Mask.EditMask = "N2";
            this.txtRate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtRate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtRate.Properties.ReadOnly = true;
            this.txtRate.Size = new System.Drawing.Size(66, 18);
            this.txtRate.StyleController = this.lcMain;
            this.txtRate.TabIndex = 44;
            // 
            // lciRate
            // 
            this.lciRate.Control = this.txtRate;
            this.lciRate.CustomizationFormText = "Rate";
            this.lciRate.IsRequired = null;
            this.lciRate.Location = new System.Drawing.Point(237, 44);
            this.lciRate.Name = "lciRate";
            this.lciRate.Size = new System.Drawing.Size(124, 22);
            this.lciRate.Text = "Rate";
            this.lciRate.TextSize = new System.Drawing.Size(50, 13);
            // 
            // lcgInfo
            // 
            this.lcgInfo.CustomizationFormText = "lcgInfo";
            this.lcgInfo.GroupBordersVisible = false;
            this.lcgInfo.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciRate,
            this.lciDescription,
            this.Currency,
            this.lciAccounts,
            this.lciBanks});
            this.lcgInfo.Location = new System.Drawing.Point(0, 387);
            this.lcgInfo.Name = "lcgInfo";
            this.lcgInfo.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgInfo.Size = new System.Drawing.Size(544, 66);
            this.lcgInfo.TextVisible = false;
            // 
            // lciDescription
            // 
            this.lciDescription.Control = this.txtDescription;
            this.lciDescription.CustomizationFormText = "lciDescription";
            this.lciDescription.IsRequired = null;
            this.lciDescription.Location = new System.Drawing.Point(0, 0);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(544, 22);
            this.lciDescription.TextSize = new System.Drawing.Size(0, 0);
            this.lciDescription.TextVisible = false;
            // 
            // txtDescription
            // 
            this.txtDescription.AllowLeadingSpace = false;
            this.txtDescription.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsDetails, "Description", true));
            this.txtDescription.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtDescription.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtDescription.EnterMoveNextControl = true;
            this.txtDescription.Information = null;
            this.txtDescription.Location = new System.Drawing.Point(2, 389);
            this.txtDescription.MenuManager = this.barManager;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7F);
            this.txtDescription.Properties.Appearance.Options.UseFont = true;
            this.txtDescription.Properties.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(540, 18);
            this.txtDescription.StyleController = this.lcMain;
            this.txtDescription.TabIndex = 51;
            // 
            // Currency
            // 
            this.Currency.Control = this.cboCurrencies;
            this.Currency.IsRequired = null;
            this.Currency.Location = new System.Drawing.Point(0, 44);
            this.Currency.MaxSize = new System.Drawing.Size(0, 22);
            this.Currency.MinSize = new System.Drawing.Size(108, 22);
            this.Currency.Name = "Currency";
            this.Currency.Size = new System.Drawing.Size(237, 22);
            this.Currency.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.Currency.TextSize = new System.Drawing.Size(50, 13);
            // 
            // cboCurrencies
            // 
            this.cboCurrencies.bs = this.bsCurrencies;
            this.cboCurrencies.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDetails, "Currencyid", true));
            this.cboCurrencies.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.cboCurrencies.EnterMoveNextControl = true;
            this.cboCurrencies.Location = new System.Drawing.Point(56, 433);
            this.cboCurrencies.MaximumSize = new System.Drawing.Size(0, 18);
            this.cboCurrencies.MenuManager = this.barManager;
            this.cboCurrencies.MinimumSize = new System.Drawing.Size(0, 18);
            this.cboCurrencies.Name = "cboCurrencies";
            this.cboCurrencies.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboCurrencies.Properties.Name = "efComboBox";
            this.cboCurrencies.Size = new System.Drawing.Size(179, 18);
            this.cboCurrencies.StyleController = this.lcMain;
            this.cboCurrencies.TabIndex = 64;
            this.cboCurrencies.ValueToDisplay = Accounting.cboCurrencies.DisplayValue.Description;
            // 
            // lciAccounts
            // 
            this.lciAccounts.Control = this.cboAccounts;
            this.lciAccounts.IsRequired = null;
            this.lciAccounts.Location = new System.Drawing.Point(0, 22);
            this.lciAccounts.MaxSize = new System.Drawing.Size(0, 22);
            this.lciAccounts.MinSize = new System.Drawing.Size(108, 22);
            this.lciAccounts.Name = "lciAccounts";
            this.lciAccounts.Size = new System.Drawing.Size(544, 22);
            this.lciAccounts.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciAccounts.Text = "Account";
            this.lciAccounts.TextSize = new System.Drawing.Size(50, 13);
            // 
            // cboAccounts
            // 
            this.cboAccounts.AccountStatusFlag = null;
            this.cboAccounts.bs = this.bsAccounts;
            this.cboAccounts.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDetails, "Accountid", true));
            this.cboAccounts.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.cboAccounts.DropdownWidth = 0;
            this.cboAccounts.EnterMoveNextControl = true;
            this.cboAccounts.Location = new System.Drawing.Point(56, 411);
            this.cboAccounts.MaximumSize = new System.Drawing.Size(0, 18);
            this.cboAccounts.MenuManager = this.barManager;
            this.cboAccounts.MinimumSize = new System.Drawing.Size(0, 18);
            this.cboAccounts.Name = "cboAccounts";
            this.cboAccounts.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboAccounts.Properties.NullText = "";
            this.cboAccounts.Properties.NullValuePrompt = "Select Account Or Leave Blank";
            this.cboAccounts.Properties.NullValuePromptShowForEmptyValue = true;
            this.cboAccounts.Properties.PopupFormMinSize = new System.Drawing.Size(350, 200);
            this.cboAccounts.Properties.ValidateOnEnterKey = true;
            this.cboAccounts.Properties.View = this.cboAccountsView;
            this.cboAccounts.ShowAccountNumber = false;
            this.cboAccounts.ShowContextImage = false;
            this.cboAccounts.Size = new System.Drawing.Size(486, 18);
            this.cboAccounts.StartWith = null;
            this.cboAccounts.StyleController = this.lcMain;
            this.cboAccounts.TabIndex = 66;
            this.cboAccounts.ToolTip = "...";
            this.cboAccounts.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            this.cboAccounts.ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
            // 
            // cboAccountsView
            // 
            this.cboAccountsView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.cboAccountsView.Name = "cboAccountsView";
            this.cboAccountsView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountsView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountsView.OptionsCustomization.AllowColumnMoving = false;
            this.cboAccountsView.OptionsCustomization.AllowColumnResizing = false;
            this.cboAccountsView.OptionsCustomization.AllowFilter = false;
            this.cboAccountsView.OptionsFilter.AllowFilterEditor = false;
            this.cboAccountsView.OptionsFind.AllowFindPanel = false;
            this.cboAccountsView.OptionsFind.ShowClearButton = false;
            this.cboAccountsView.OptionsFind.ShowCloseButton = false;
            this.cboAccountsView.OptionsFind.ShowFindButton = false;
            this.cboAccountsView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.cboAccountsView.OptionsView.EnableAppearanceEvenRow = true;
            this.cboAccountsView.OptionsView.EnableAppearanceOddRow = true;
            this.cboAccountsView.OptionsView.ShowAutoFilterRow = true;
            this.cboAccountsView.OptionsView.ShowGroupPanel = false;
            this.cboAccountsView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.cboAccountsView.OptionsView.ShowIndicator = false;
            this.cboAccountsView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            // 
            // lciBanks
            // 
            this.lciBanks.Control = this.cboBanks;
            this.lciBanks.IsRequired = null;
            this.lciBanks.Location = new System.Drawing.Point(361, 44);
            this.lciBanks.MaxSize = new System.Drawing.Size(0, 22);
            this.lciBanks.MinSize = new System.Drawing.Size(108, 22);
            this.lciBanks.Name = "lciBanks";
            this.lciBanks.Size = new System.Drawing.Size(183, 22);
            this.lciBanks.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciBanks.Text = "Bank";
            this.lciBanks.TextSize = new System.Drawing.Size(50, 13);
            // 
            // cboBanks
            // 
            this.cboBanks.bs = this.bsBanks;
            this.cboBanks.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsDetails, "Bankid", true));
            this.cboBanks.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.cboBanks.EnterMoveNextControl = true;
            this.cboBanks.Location = new System.Drawing.Point(417, 433);
            this.cboBanks.MaximumSize = new System.Drawing.Size(0, 18);
            this.cboBanks.MenuManager = this.barManager;
            this.cboBanks.MinimumSize = new System.Drawing.Size(0, 18);
            this.cboBanks.Name = "cboBanks";
            this.cboBanks.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboBanks.Properties.Name = "efComboBox";
            this.cboBanks.Size = new System.Drawing.Size(125, 18);
            this.cboBanks.StyleController = this.lcMain;
            this.cboBanks.TabIndex = 67;
            this.cboBanks.ValueToDisplay = Accounting.cboBanks.DisplayValue.Description;
            // 
            // lcgBalances
            // 
            this.lcgBalances.CustomizationFormText = "lcgBalances";
            this.lcgBalances.GroupBordersVisible = false;
            this.lcgBalances.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciBalance1st,
            this.lciCredit1st,
            this.lciDebit1st,
            this.lciDebit2nd,
            this.lciCredit2nd,
            this.lciBalance2nd});
            this.lcgBalances.Location = new System.Drawing.Point(550, 384);
            this.lcgBalances.Name = "lcgBalances";
            this.lcgBalances.Padding = new DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2);
            this.lcgBalances.Size = new System.Drawing.Size(249, 69);
            this.lcgBalances.TextVisible = false;
            // 
            // pmGrid
            // 
            this.pmGrid.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiInsert),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiMoveUP, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiMoveDOWN),
            new DevExpress.XtraBars.LinkPersistInfo(this.beMoveTO, true)});
            this.pmGrid.Manager = this.barManager;
            this.pmGrid.Name = "pmGrid";
            // 
            // bbiInsert
            // 
            this.bbiInsert.Caption = "Insert";
            this.bbiInsert.CategoryGuid = new System.Guid("6b6829b5-6b1f-4a88-af1f-6d37d7c20846");
            this.bbiInsert.Id = 32;
            this.bbiInsert.ImageIndex = 19;
            this.bbiInsert.Name = "bbiInsert";
            this.bbiInsert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiInsert_ItemClick);
            // 
            // bbiMoveUP
            // 
            this.bbiMoveUP.Caption = "Move UP";
            this.bbiMoveUP.CategoryGuid = new System.Guid("6b6829b5-6b1f-4a88-af1f-6d37d7c20846");
            this.bbiMoveUP.Id = 33;
            this.bbiMoveUP.ImageIndex = 22;
            this.bbiMoveUP.Name = "bbiMoveUP";
            this.bbiMoveUP.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMoveUP_ItemClick);
            // 
            // bbiMoveDOWN
            // 
            this.bbiMoveDOWN.Caption = "Move DOWN";
            this.bbiMoveDOWN.CategoryGuid = new System.Guid("6b6829b5-6b1f-4a88-af1f-6d37d7c20846");
            this.bbiMoveDOWN.Id = 34;
            this.bbiMoveDOWN.ImageIndex = 21;
            this.bbiMoveDOWN.Name = "bbiMoveDOWN";
            this.bbiMoveDOWN.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiMoveDOWN_ItemClick);
            // 
            // beMoveTO
            // 
            this.beMoveTO.Caption = "Move TO";
            this.beMoveTO.CategoryGuid = new System.Guid("6b6829b5-6b1f-4a88-af1f-6d37d7c20846");
            this.beMoveTO.Edit = this.tiTxtMoveTO;
            this.beMoveTO.Id = 36;
            this.beMoveTO.ImageIndex = 23;
            this.beMoveTO.Name = "beMoveTO";
            this.beMoveTO.EditValueChanged += new System.EventHandler(this.beMoveTO_EditValueChanged);
            // 
            // tiTxtMoveTO
            // 
            this.tiTxtMoveTO.AutoHeight = false;
            this.tiTxtMoveTO.Name = "tiTxtMoveTO";
            // 
            // riVoucherType
            // 
            this.riVoucherType.AutoHeight = false;
            this.riVoucherType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.riVoucherType.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Code", "Code", 35, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.riVoucherType.DisplayMember = "Code";
            this.riVoucherType.Name = "riVoucherType";
            this.riVoucherType.ValueMember = "Code";
            // 
            // colReference
            // 
            this.colReference.AlwaysDisabled = false;
            this.colReference.Caption = "gridColumn1";
            this.colReference.CustomData = "";
            this.colReference.EditDisabled = false;
            this.colReference.FieldName = "Reference";
            this.colReference.Name = "colReference";
            this.colReference.Visible = true;
            this.colReference.VisibleIndex = 1;
            // 
            // colRef
            // 
            this.colRef.AlwaysDisabled = false;
            this.colRef.CustomData = "";
            this.colRef.EditDisabled = false;
            this.colRef.FieldName = "Reference";
            this.colRef.Name = "colRef";
            this.colRef.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRef.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Equals;
            this.colRef.Visible = true;
            this.colRef.VisibleIndex = 2;
            this.colRef.Width = 52;
            // 
            // bbiNew
            // 
            this.bbiNew.Caption = "New";
            this.bbiNew.Id = 32;
            this.bbiNew.ImageIndex = 20;
            this.bbiNew.Name = "bbiNew";
            // 
            // GridBar
            // 
            this.GridBar.BarName = "GridBar";
            this.GridBar.DockCol = 0;
            this.GridBar.DockRow = 0;
            this.GridBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Standalone;
            this.GridBar.FloatLocation = new System.Drawing.Point(513, 534);
            this.GridBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGridAdd),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGridDelete, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnGridInsert, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCopyFrom, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnCheque, true),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnScan, true)});
            this.GridBar.OptionsBar.AllowQuickCustomization = false;
            this.GridBar.OptionsBar.DisableClose = true;
            this.GridBar.OptionsBar.DisableCustomization = true;
            this.GridBar.OptionsBar.DrawBorder = false;
            this.GridBar.OptionsBar.DrawDragBorder = false;
            this.GridBar.OptionsBar.UseWholeRow = true;
            this.GridBar.StandaloneBarDockControl = this.sbdcGridBar;
            this.GridBar.Text = "GridBar";
            // 
            // btnGridAdd
            // 
            this.btnGridAdd.Caption = "Add";
            this.btnGridAdd.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridAdd.Glyph")));
            this.btnGridAdd.Id = 34;
            this.btnGridAdd.ImageIndex = 16;
            this.btnGridAdd.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGridAdd.LargeGlyph")));
            this.btnGridAdd.Name = "btnGridAdd";
            this.btnGridAdd.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGridAdd.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGridAdd_ItemClick);
            // 
            // btnGridDelete
            // 
            this.btnGridDelete.Caption = "Delete";
            this.btnGridDelete.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridDelete.Glyph")));
            this.btnGridDelete.Id = 36;
            this.btnGridDelete.ImageIndex = 17;
            this.btnGridDelete.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGridDelete.LargeGlyph")));
            this.btnGridDelete.Name = "btnGridDelete";
            this.btnGridDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGridDelete.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGridDelete_ItemClick);
            // 
            // btnGridInsert
            // 
            this.btnGridInsert.Caption = "Insert";
            this.btnGridInsert.Glyph = ((System.Drawing.Image)(resources.GetObject("btnGridInsert.Glyph")));
            this.btnGridInsert.Id = 37;
            this.btnGridInsert.ImageIndex = 19;
            this.btnGridInsert.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("btnGridInsert.LargeGlyph")));
            this.btnGridInsert.Name = "btnGridInsert";
            this.btnGridInsert.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnGridInsert.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnGridInsert_ItemClick);
            // 
            // btnCopyFrom
            // 
            this.btnCopyFrom.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnCopyFrom.Caption = "Copy From";
            this.btnCopyFrom.Id = 43;
            this.btnCopyFrom.ImageIndex = 18;
            this.btnCopyFrom.Name = "btnCopyFrom";
            toolTipItem1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            toolTipItem1.Appearance.Options.UseImage = true;
            toolTipItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolTipItem1.Image")));
            toolTipItem1.Text = "Copy From";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnCopyFrom.SuperTip = superToolTip1;
            this.btnCopyFrom.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnCopyFrom_ItemClick);
            // 
            // btnCheque
            // 
            this.btnCheque.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnCheque.Caption = "Cheque";
            this.btnCheque.Id = 39;
            this.btnCheque.ImageIndex = 24;
            this.btnCheque.Name = "btnCheque";
            this.btnCheque.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            // 
            // btnScan
            // 
            this.btnScan.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.btnScan.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.DropDown;
            this.btnScan.Caption = "Scan";
            this.btnScan.DropDownControl = this.pmScan;
            this.btnScan.Glyph = ((System.Drawing.Image)(resources.GetObject("btnScan.Glyph")));
            this.btnScan.Id = 38;
            this.btnScan.ImageIndex = 20;
            this.btnScan.Name = "btnScan";
            this.btnScan.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnScan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnScan_ItemClick);
            // 
            // pmScan
            // 
            this.pmScan.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiImportPDF)});
            this.pmScan.Manager = this.barManager;
            this.pmScan.Name = "pmScan";
            // 
            // bbiImportPDF
            // 
            this.bbiImportPDF.Caption = "Import PDF";
            this.bbiImportPDF.Id = 44;
            this.bbiImportPDF.Name = "bbiImportPDF";
            this.bbiImportPDF.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.bbiImportPDF_ItemClick);
            // 
            // sbdcGridBar
            // 
            this.sbdcGridBar.CausesValidation = false;
            this.sbdcGridBar.Location = new System.Drawing.Point(2, 354);
            this.sbdcGridBar.Name = "sbdcGridBar";
            this.sbdcGridBar.Size = new System.Drawing.Size(540, 31);
            this.sbdcGridBar.Text = "standaloneBarDockControl1";
            // 
            // lciGridBar
            // 
            this.lciGridBar.Control = this.sbdcGridBar;
            this.lciGridBar.IsRequired = null;
            this.lciGridBar.Location = new System.Drawing.Point(0, 352);
            this.lciGridBar.Name = "lciGridBar";
            this.lciGridBar.Size = new System.Drawing.Size(544, 35);
            this.lciGridBar.TextSize = new System.Drawing.Size(0, 0);
            this.lciGridBar.TextVisible = false;
            // 
            // simpleSeparator2
            // 
            this.simpleSeparator2.AllowHotTrack = false;
            this.simpleSeparator2.Location = new System.Drawing.Point(544, 352);
            this.simpleSeparator2.Name = "simpleSeparator2";
            this.simpleSeparator2.Size = new System.Drawing.Size(6, 101);
            this.simpleSeparator2.Spacing = new DevExpress.XtraLayout.Utils.Padding(2, 2, 0, 0);
            // 
            // ucControlNavigator
            // 
            this.ucControlNavigator.AlwaysEnabled = true;
            this.ucControlNavigator.Location = new System.Drawing.Point(552, 354);
            this.ucControlNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ucControlNavigator.MaximumSize = new System.Drawing.Size(245, 28);
            this.ucControlNavigator.MinimumSize = new System.Drawing.Size(245, 28);
            this.ucControlNavigator.Name = "ucControlNavigator";
            this.ucControlNavigator.NavigatableControl = this.gcDetails;
            this.ucControlNavigator.Size = new System.Drawing.Size(245, 28);
            this.ucControlNavigator.TabIndex = 59;
            // 
            // lciControlNavigator
            // 
            this.lciControlNavigator.Control = this.ucControlNavigator;
            this.lciControlNavigator.ControlAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lciControlNavigator.FillControlToClientArea = false;
            this.lciControlNavigator.IsRequired = null;
            this.lciControlNavigator.Location = new System.Drawing.Point(550, 352);
            this.lciControlNavigator.MaxSize = new System.Drawing.Size(249, 32);
            this.lciControlNavigator.MinSize = new System.Drawing.Size(249, 32);
            this.lciControlNavigator.Name = "lciControlNavigator";
            this.lciControlNavigator.Size = new System.Drawing.Size(249, 32);
            this.lciControlNavigator.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciControlNavigator.TextSize = new System.Drawing.Size(0, 0);
            this.lciControlNavigator.TextVisible = false;
            // 
            // chkNew
            // 
            this.chkNew.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.chkNew.EnterMoveNextControl = true;
            this.chkNew.HighLighted = false;
            this.chkNew.Location = new System.Drawing.Point(705, 2);
            this.chkNew.MenuManager = this.barManager;
            this.chkNew.Name = "chkNew";
            this.chkNew.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkNew.Properties.Appearance.Options.UseBackColor = true;
            this.chkNew.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkNew.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkNew.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkNew.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkNew.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkNew.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkNew.Properties.Caption = "New";
            this.chkNew.Properties.Name = "efCheckBox";
            this.chkNew.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkNew.Size = new System.Drawing.Size(44, 19);
            this.chkNew.StyleController = this.lcMain;
            this.chkNew.TabIndex = 61;
            this.chkNew.TabStop = false;
            this.chkNew.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciNEw
            // 
            this.lciNEw.Control = this.chkNew;
            this.lciNEw.IsRequired = null;
            this.lciNEw.Location = new System.Drawing.Point(703, 0);
            this.lciNEw.MaxSize = new System.Drawing.Size(48, 23);
            this.lciNEw.MinSize = new System.Drawing.Size(48, 23);
            this.lciNEw.Name = "lciNEw";
            this.lciNEw.Size = new System.Drawing.Size(48, 25);
            this.lciNEw.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciNEw.TextSize = new System.Drawing.Size(0, 0);
            this.lciNEw.TextVisible = false;
            // 
            // chkPrint
            // 
            this.chkPrint.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.chkPrint.EnterMoveNextControl = true;
            this.chkPrint.HighLighted = false;
            this.chkPrint.Location = new System.Drawing.Point(753, 2);
            this.chkPrint.MenuManager = this.barManager;
            this.chkPrint.Name = "chkPrint";
            this.chkPrint.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkPrint.Properties.Appearance.Options.UseBackColor = true;
            this.chkPrint.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkPrint.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkPrint.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkPrint.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkPrint.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkPrint.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkPrint.Properties.Caption = "Print";
            this.chkPrint.Properties.Name = "efCheckBox";
            this.chkPrint.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chkPrint.Size = new System.Drawing.Size(44, 19);
            this.chkPrint.StyleController = this.lcMain;
            this.chkPrint.TabIndex = 62;
            this.chkPrint.TabStop = false;
            this.chkPrint.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciPrint
            // 
            this.lciPrint.Control = this.chkPrint;
            this.lciPrint.IsRequired = null;
            this.lciPrint.Location = new System.Drawing.Point(751, 0);
            this.lciPrint.MaxSize = new System.Drawing.Size(48, 23);
            this.lciPrint.MinSize = new System.Drawing.Size(48, 23);
            this.lciPrint.Name = "lciPrint";
            this.lciPrint.Size = new System.Drawing.Size(48, 25);
            this.lciPrint.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciPrint.TextSize = new System.Drawing.Size(0, 0);
            this.lciPrint.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(608, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(95, 25);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // bsVoucherType
            // 
            this.bsVoucherType.AllowNew = false;
            this.bsVoucherType.DataSource = typeof(Accounting.Vouchertype);
            // 
            // cboSubCompanies
            // 
            this.cboSubCompanies.bs = null;
            this.cboSubCompanies.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "SC", true));
            this.cboSubCompanies.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboSubCompanies.EnterMoveNextControl = true;
            this.cboSubCompanies.Location = new System.Drawing.Point(217, 2);
            this.cboSubCompanies.MenuManager = this.barManager;
            this.cboSubCompanies.Name = "cboSubCompanies";
            this.cboSubCompanies.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboSubCompanies.Properties.Name = "efComboBox";
            this.cboSubCompanies.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.cboSubCompanies.Size = new System.Drawing.Size(24, 20);
            this.cboSubCompanies.StyleController = this.lcMain;
            this.cboSubCompanies.TabIndex = 69;
            this.cboSubCompanies.Visible = false;
            this.cboSubCompanies.EditValueChanged += new System.EventHandler(this.cboSubCompanies_EditValueChanged);
            this.cboSubCompanies.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.cboSubCompanies_EditValueChanging);
            // 
            // lciSubCompanies
            // 
            this.lciSubCompanies.Control = this.cboSubCompanies;
            this.lciSubCompanies.IsRequired = null;
            this.lciSubCompanies.Location = new System.Drawing.Point(215, 0);
            this.lciSubCompanies.MaxSize = new System.Drawing.Size(28, 24);
            this.lciSubCompanies.MinSize = new System.Drawing.Size(28, 24);
            this.lciSubCompanies.Name = "lciSubCompanies";
            this.lciSubCompanies.Size = new System.Drawing.Size(28, 25);
            this.lciSubCompanies.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.lciSubCompanies.TextSize = new System.Drawing.Size(0, 0);
            this.lciSubCompanies.TextVisible = false;
            // 
            // colSC
            // 
            this.colSC.AlwaysDisabled = false;
            this.colSC.AppearanceHeader.Options.UseTextOptions = true;
            this.colSC.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSC.CustomData = "";
            this.colSC.EditDisabled = false;
            this.colSC.FieldName = "SC";
            this.colSC.MinWidth = 15;
            this.colSC.Name = "colSC";
            this.colSC.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSC.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSC.Visible = true;
            this.colSC.VisibleIndex = 1;
            this.colSC.Width = 15;
            // 
            // accBalances
            // 
            this.accBalances.AppearanceCaption.Font = new System.Drawing.Font("Courier New", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accBalances.AppearanceCaption.ForeColor = System.Drawing.Color.OrangeRed;
            this.accBalances.AppearanceCaption.Options.UseFont = true;
            this.accBalances.AppearanceCaption.Options.UseForeColor = true;
            this.accBalances.AppearanceText.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accBalances.AppearanceText.Options.UseFont = true;
            this.accBalances.AutoHeight = true;
            this.accBalances.FormDisplaySpeed = DevExpress.XtraBars.Alerter.AlertFormDisplaySpeed.Fast;
            this.accBalances.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.BottomLeft;
            this.accBalances.FormMaxCount = 1;
            this.accBalances.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.MoveHorizontal;
            this.accBalances.Images = this.imageCollection;
            this.accBalances.LookAndFeel.SkinMaskColor = System.Drawing.Color.Blue;
            this.accBalances.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.Magenta;
            this.accBalances.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.accBalances.LookAndFeel.UseDefaultLookAndFeel = false;
            this.accBalances.ShowPinButton = false;
            this.accBalances.ShowToolTips = false;
            // 
            // FormTransactions
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(924, 511);
            this.MinimumSize = new System.Drawing.Size(926, 540);
            this.Name = "FormTransactions";
            this.Text = "Journal Vouchers";
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
            ((System.ComponentModel.ISupportInitialize)(this.ripceCollect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pccCollect)).EndInit();
            this.pccCollect.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gcCollect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCollect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvCollect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riDC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFromTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciFromTo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.meDetails.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboVoucherTypes.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciReference)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtReference.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt2ndRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lci2ndRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAccountsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideMaturity.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rideMaturity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCurrencies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riAmounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ritxtDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riBanksView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebit1st.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDebit1st)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCredit1st.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCredit1st)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance1st.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBalance1st)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebit2nd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDebit2nd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCredit2nd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCredit2nd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalance2nd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBalance2nd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Currency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCurrencies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAccounts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccounts.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboAccountsView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciBanks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboBanks.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lcgBalances)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiTxtMoveTO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riVoucherType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pmScan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGridBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.simpleSeparator2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciControlNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkNew.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciNEw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPrint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsVoucherType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboSubCompanies.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciSubCompanies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private efControls.efTextBox txtFromTo;
        private efControls.lci lciFromTo;
        private efControls.efMemoEdit meDetails;
        private efControls.lci lciDetails;
        private efControls.efTextBox txtBalance2nd;
        private efControls.efTextBox txtCredit2nd;
        private efControls.efTextBox txtDebit2nd;
        private efControls.efTextBox txtBalance1st;
        private efControls.efTextBox txtCredit1st;
        private efControls.efTextBox txtDebit1st;
        private efControls.efGridControl gcDetails;
        private efControls.efGridView gvDetails;
        private efControls.efGridColumn colAccount;
        private efControls.efGridColumn colDocument;
        private efControls.efGridColumn colMaturity;
        private efControls.efGridColumn colCurrencyid;
        private efControls.efGridColumn colAmount;
        private efControls.efGridColumn colDc;
        private efControls.efGridColumn colDescription;
        private efControls.efGridColumn colBankid;
        private efControls.efGridColumn colAmount1st;
        private efControls.efGridColumn colAmount2nd;
        private efControls.efTextBox txt2ndRate;
        private efControls.lci lciType;
        private efControls.lci lciReference;
        private efControls.lci lciDate;
        private efControls.lci lci2ndRate;
        private efControls.lci lciGridDetails;
        private efControls.lci lciDebit1st;
        private efControls.lci lciCredit1st;
        private efControls.lci lciBalance1st;
        private efControls.lci lciDebit2nd;
        private efControls.lci lciCredit2nd;
        private efControls.lci lciBalance2nd;
        private efControls.efTextBox txtRate;
        private DevExpress.XtraLayout.LayoutControlGroup lcgInfo;
        private efControls.lci lciRate;
        private DevExpress.XtraLayout.LayoutControlGroup lcgBalances;
        private efControls.efTextBox txtDescription;
        private efControls.lci lciDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riCurrencies;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox riDC;
        private efControls.efGridColumn colLine;
        private DevExpress.XtraBars.BarButtonItem bbiInsert;
        private DevExpress.XtraBars.BarButtonItem bbiMoveUP;
        private DevExpress.XtraBars.BarButtonItem bbiMoveDOWN;
        private DevExpress.XtraBars.BarEditItem beMoveTO;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit tiTxtMoveTO;
        private DevExpress.XtraBars.PopupMenu pmGrid;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit riVoucherType;
        private System.Windows.Forms.BindingSource bsCollect;
        private efControls.efGridColumn colReference;
        protected System.Windows.Forms.BindingSource bsAccounts;
        protected System.Windows.Forms.BindingSource bsCurrencies;
        protected System.Windows.Forms.BindingSource bsBanks;
        protected DevExpress.XtraLayout.LayoutControlGroup lcgDetails;
        private DevExpress.XtraBars.BarButtonItem bbiNew;
        public cboVoucherTypes cboVoucherTypes;
        public efControls.efDateEdit deDate;
        private DevExpress.XtraBars.BarButtonItem btnGridAdd;
        private DevExpress.XtraBars.BarButtonItem btnGridDelete;
        private DevExpress.XtraBars.BarButtonItem btnGridInsert;
        private DevExpress.XtraBars.BarButtonItem btnScan;
        private DevExpress.XtraBars.StandaloneBarDockControl sbdcGridBar;
        private efControls.lci lciGridBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit riAmounts;
        private DevExpress.XtraLayout.SimpleSeparator simpleSeparator2;
        private efControls.efPopupContainerControl pccCollect;
        private efControls.efGridControl gcCollect;
        private efControls.efGridView gvCollect;
        private efControls.efGridColumn colDocument1;
        private efControls.efGridColumn colMaturity1;
        private efControls.efGridColumn colcur;
        private efControls.efGridColumn colAmount1;
        private efControls.efGridColumn colBank;
        private efControls.efGridColumn coldc1;
        private efControls.RepositoryItemefTextBox ritxtDescription;
        public efControls.efGridColumn colRef;
        private RepositoryItemef_Accounts riAccounts;
        private DevExpress.XtraGrid.Views.Grid.GridView riAccountsView;
        private efControls.efGridColumn colCodeDescription;
        private RepositoryItemef_Accounts riBanks;
        private DevExpress.XtraGrid.Views.Grid.GridView riBanksView;
        private efControls.efGridColumn gridColBank;
        private efControls.ucControlNavigator ucControlNavigator;
        private efControls.lci lciControlNavigator;
        public DevExpress.XtraBars.BarButtonItem btnCheque;
        private efControls.efCheckBox chkPrint;
        private efControls.efCheckBox chkNew;
        private efControls.lci lciNEw;
        private efControls.lci lciPrint;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private efControls.RepositoryItemefDateEdit rideMaturity;
        private efControls.RepositoryItemefPopupContainerEdit ripceCollect;
        private cboCurrencies cboCurrencies;
        private efControls.lci Currency;
        private cboBanks cboBanks;
        private cboAccounts cboAccounts;
        private efControls.lci lciAccounts;
        private efControls.lci lciBanks;
        private DevExpress.XtraGrid.Views.Grid.GridView cboAccountsView;
        private DevExpress.XtraBars.BarButtonItem btnCopyFrom;
        public efControls.efButtonEdit txtReference;
        private efControls.efGridColumn colStatus;
        protected System.Windows.Forms.BindingSource bsVoucherType;
        private cboSubCompanies cboSubCompanies;
        private efControls.lci lciSubCompanies;
        public efControls.efGridColumn colSC;
        private DevExpress.XtraBars.PopupMenu pmScan;
        private DevExpress.XtraBars.BarButtonItem bbiImportPDF;
        public DevExpress.XtraBars.Bar GridBar;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DevExpress.XtraBars.Alerter.AlertControl accBalances;
        protected internal System.Windows.Forms.BindingSource bsDetails;
        private efControls.RepositoryItemefPopupContainerEdit repositoryItemeDocument1;
    }
}
