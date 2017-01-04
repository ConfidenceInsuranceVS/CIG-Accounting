namespace Accounting
{
    partial class FormVoucherType
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVoucherType));
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.txtCode = new efControls.efTextBox();
            this.lciCode = new efControls.lci();
            this.txtDescription = new efControls.efTextBox();
            this.lciDescription = new efControls.lci();
            this.txtType = new efControls.efTextBox();
            this.lciType = new efControls.lci();
            this.spnOrder = new efControls.efSpinner();
            this.lciOrder = new efControls.lci();
            this.chkRV = new efControls.efCheckBox();
            this.lciRV = new efControls.lci();
            this.chkCN = new efControls.efCheckBox();
            this.lciCN = new efControls.lci();
            this.chkPV = new efControls.efCheckBox();
            this.lciPV = new efControls.lci();
            this.chkDN = new efControls.efCheckBox();
            this.lciDN = new efControls.lci();
            this.chkJV = new efControls.efCheckBox();
            this.lciJV = new efControls.lci();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.colDescription = new efControls.efGridColumn();
            this.colType = new efControls.efGridColumn();
            this.colOrderID = new efControls.efGridColumn();
            this.colJV = new efControls.efGridColumn();
            this.colRV = new efControls.efGridColumn();
            this.colPV = new efControls.efGridColumn();
            this.colCN = new efControls.efGridColumn();
            this.colDN = new efControls.efGridColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnOrder.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkJV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
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
            this.gcSearch.Size = new System.Drawing.Size(562, 165);
            // 
            // gvSearch
            // 
            this.gvSearch.Appearance.SelectedRow.Options.UseForeColor = true;
            this.gvSearch.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDescription,
            this.colType,
            this.colOrderID,
            this.colJV,
            this.colRV,
            this.colPV,
            this.colCN,
            this.colDN});
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
            this.gvSearch.OptionsView.ShowAutoFilterRow = true;
            this.gvSearch.OptionsView.ShowColumnHeaders = true;//samir  BU 7/12/2016-1
            this.gvSearch.OptionsView.ShowDetailButtons = false;
            this.gvSearch.OptionsView.ShowGroupPanel = false;
            this.gvSearch.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvSearch.OptionsView.ShowIndicator = false;
            this.gvSearch.VisibleAutoFilterRow = true;
            // 
            // colSearch
            // 
            this.colSearch.AppearanceHeader.Options.UseTextOptions = true;
            this.colSearch.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colSearch.FieldName = "Code";
            this.colSearch.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colSearch.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colSearch.Width = 34;//samir  BU 7/12/2016-1
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
            this.barDockControlTop.Size = new System.Drawing.Size(566, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 300);
            this.barDockControlBottom.Size = new System.Drawing.Size(566, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 269);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Location = new System.Drawing.Point(566, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 269);
            // 
            // barManager
            // 
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
            this.sccMain.Horizontal = false;
            this.sccMain.Location = new System.Drawing.Point(0, 31);
            this.sccMain.Size = new System.Drawing.Size(566, 269);
            this.sccMain.SplitterPosition = 215;
            // 
            // lcSearch
            // 
            this.lcSearch.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(945, 154, 250, 350);
            this.lcSearch.Size = new System.Drawing.Size(566, 215);
            this.lcSearch.Controls.SetChildIndex(this.gcSearch, 0);
            // 
            // lcgSearch
            // 
            this.lcgSearch.Size = new System.Drawing.Size(566, 215);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.chkJV);
            this.lcMain.Controls.Add(this.chkDN);
            this.lcMain.Controls.Add(this.chkPV);
            this.lcMain.Controls.Add(this.chkCN);
            this.lcMain.Controls.Add(this.chkRV);
            this.lcMain.Controls.Add(this.spnOrder);
            this.lcMain.Controls.Add(this.txtType);
            this.lcMain.Controls.Add(this.txtDescription);
            this.lcMain.Controls.Add(this.txtCode);
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(1189, 49, 250, 700);
            this.lcMain.Size = new System.Drawing.Size(566, 49);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciCode,
            this.lciDescription,
            this.lciType,
            this.lciOrder,
            this.lciRV,
            this.lciCN,
            this.lciPV,
            this.lciDN,
            this.lciJV,
            this.emptySpaceItem1});
            this.lcgMain.Size = new System.Drawing.Size(566, 49);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            this.imageCollection.InsertGalleryImage("sortasc_16x16.png", "office2013/data/sortasc_16x16.png", DevExpress.Images.ImageResourceCache.Default.GetImage("office2013/data/sortasc_16x16.png"), 16);
            this.imageCollection.Images.SetKeyName(16, "sortasc_16x16.png");
            // 
            // bciPosted
            // 
            this.bciPosted.ItemAppearance.Pressed.BackColor = System.Drawing.Color.Transparent;
            this.bciPosted.ItemAppearance.Pressed.Options.UseBackColor = true;
            // 
            // bsSearch
            // 
            this.bsSearch.DataSource = typeof(Accounting.VoucherTypeSearchList);
            // 
            // txtCode
            // 
            this.txtCode.AllowLeadingSpace = false;
            this.txtCode.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "Code", true));
            this.txtCode.DefaultState = efControls.Enums.ControlState.Default;
            this.txtCode.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtCode.EnterMoveNextControl = true;
            this.txtCode.Information = null;
            this.txtCode.Location = new System.Drawing.Point(59, 2);
            this.txtCode.MenuManager = this.barManager;
            this.txtCode.Name = "txtCode";
            this.txtCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCode.Size = new System.Drawing.Size(50, 20);
            this.txtCode.StyleController = this.lcMain;
            this.txtCode.TabIndex = 4;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "Required!";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Critical;
            this.ValidationProvider.SetValidationRule(this.txtCode, conditionValidationRule1);
            this.txtCode.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCode_Validating);
            // 
            // lciCode
            // 
            this.lciCode.Control = this.txtCode;
            this.lciCode.IsRequired = null;
            this.lciCode.Location = new System.Drawing.Point(0, 0);
            this.lciCode.Name = "lciCode";
            this.lciCode.Size = new System.Drawing.Size(111, 24);
            this.lciCode.Text = "Code";
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
            this.txtDescription.Location = new System.Drawing.Point(170, 2);
            this.txtDescription.MenuManager = this.barManager;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(394, 20);
            this.txtDescription.StyleController = this.lcMain;
            this.txtDescription.TabIndex = 5;
            // 
            // lciDescription
            // 
            this.lciDescription.Control = this.txtDescription;
            this.lciDescription.IsRequired = null;
            this.lciDescription.Location = new System.Drawing.Point(111, 0);
            this.lciDescription.Name = "lciDescription";
            this.lciDescription.Size = new System.Drawing.Size(455, 24);
            this.lciDescription.Text = "Description";
            this.lciDescription.TextSize = new System.Drawing.Size(53, 13);
            // 
            // txtType
            // 
            this.txtType.AllowLeadingSpace = false;
            this.txtType.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "Type", true));
            this.txtType.DefaultState = efControls.Enums.ControlState.Default;
            this.txtType.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtType.EnterMoveNextControl = true;
            this.txtType.Information = null;
            this.txtType.Location = new System.Drawing.Point(59, 26);
            this.txtType.MenuManager = this.barManager;
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(50, 20);
            this.txtType.StyleController = this.lcMain;
            this.txtType.TabIndex = 6;
            // 
            // lciType
            // 
            this.lciType.Control = this.txtType;
            this.lciType.IsRequired = null;
            this.lciType.Location = new System.Drawing.Point(0, 24);
            this.lciType.Name = "lciType";
            this.lciType.Size = new System.Drawing.Size(111, 25);
            this.lciType.Text = "Type";
            this.lciType.TextSize = new System.Drawing.Size(53, 13);
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
            this.spnOrder.Location = new System.Drawing.Point(170, 26);
            this.spnOrder.MenuManager = this.barManager;
            this.spnOrder.Name = "spnOrder";
            this.spnOrder.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spnOrder.Properties.Mask.EditMask = "f0";
            this.spnOrder.Size = new System.Drawing.Size(50, 20);
            this.spnOrder.StyleController = this.lcMain;
            this.spnOrder.TabIndex = 7;
            // 
            // lciOrder
            // 
            this.lciOrder.Control = this.spnOrder;
            this.lciOrder.IsRequired = null;
            this.lciOrder.Location = new System.Drawing.Point(111, 24);
            this.lciOrder.Name = "lciOrder";
            this.lciOrder.Size = new System.Drawing.Size(111, 25);
            this.lciOrder.Text = "Order";
            this.lciOrder.TextSize = new System.Drawing.Size(53, 13);
            // 
            // chkRV
            // 
            this.chkRV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "RV", true));
            this.chkRV.DefaultState = efControls.Enums.ControlState.Default;
            this.chkRV.EnterMoveNextControl = true;
            this.chkRV.HighLighted = false;
            this.chkRV.Location = new System.Drawing.Point(411, 26);
            this.chkRV.MenuManager = this.barManager;
            this.chkRV.Name = "chkRV";
            this.chkRV.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkRV.Properties.Appearance.Options.UseBackColor = true;
            this.chkRV.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkRV.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkRV.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkRV.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkRV.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkRV.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkRV.Properties.Caption = "RV";
            this.chkRV.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkRV.Size = new System.Drawing.Size(35, 19);
            this.chkRV.StyleController = this.lcMain;
            this.chkRV.TabIndex = 8;
            this.chkRV.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciRV
            // 
            this.lciRV.Control = this.chkRV;
            this.lciRV.IsRequired = null;
            this.lciRV.Location = new System.Drawing.Point(409, 24);
            this.lciRV.Name = "lciRV";
            this.lciRV.Size = new System.Drawing.Size(39, 25);
            this.lciRV.Text = "RV";
            this.lciRV.TextSize = new System.Drawing.Size(0, 0);
            this.lciRV.TextVisible = false;
            // 
            // chkCN
            // 
            this.chkCN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "CN", true));
            this.chkCN.DefaultState = efControls.Enums.ControlState.Default;
            this.chkCN.EnterMoveNextControl = true;
            this.chkCN.HighLighted = false;
            this.chkCN.Location = new System.Drawing.Point(488, 26);
            this.chkCN.MenuManager = this.barManager;
            this.chkCN.Name = "chkCN";
            this.chkCN.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkCN.Properties.Appearance.Options.UseBackColor = true;
            this.chkCN.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkCN.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkCN.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkCN.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkCN.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkCN.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkCN.Properties.Caption = "CN";
            this.chkCN.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkCN.Size = new System.Drawing.Size(36, 19);
            this.chkCN.StyleController = this.lcMain;
            this.chkCN.TabIndex = 9;
            this.chkCN.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciCN
            // 
            this.lciCN.Control = this.chkCN;
            this.lciCN.IsRequired = null;
            this.lciCN.Location = new System.Drawing.Point(486, 24);
            this.lciCN.Name = "lciCN";
            this.lciCN.Size = new System.Drawing.Size(40, 25);
            this.lciCN.Text = "CN";
            this.lciCN.TextSize = new System.Drawing.Size(0, 0);
            this.lciCN.TextVisible = false;
            // 
            // chkPV
            // 
            this.chkPV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "PV", true));
            this.chkPV.DefaultState = efControls.Enums.ControlState.Default;
            this.chkPV.EnterMoveNextControl = true;
            this.chkPV.HighLighted = false;
            this.chkPV.Location = new System.Drawing.Point(450, 26);
            this.chkPV.MenuManager = this.barManager;
            this.chkPV.Name = "chkPV";
            this.chkPV.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkPV.Properties.Appearance.Options.UseBackColor = true;
            this.chkPV.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkPV.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkPV.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkPV.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkPV.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkPV.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkPV.Properties.Caption = "PV";
            this.chkPV.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkPV.Size = new System.Drawing.Size(34, 19);
            this.chkPV.StyleController = this.lcMain;
            this.chkPV.TabIndex = 10;
            this.chkPV.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciPV
            // 
            this.lciPV.Control = this.chkPV;
            this.lciPV.IsRequired = null;
            this.lciPV.Location = new System.Drawing.Point(448, 24);
            this.lciPV.Name = "lciPV";
            this.lciPV.Size = new System.Drawing.Size(38, 25);
            this.lciPV.Text = "PV";
            this.lciPV.TextSize = new System.Drawing.Size(0, 0);
            this.lciPV.TextVisible = false;
            // 
            // chkDN
            // 
            this.chkDN.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "DN", true));
            this.chkDN.DefaultState = efControls.Enums.ControlState.Default;
            this.chkDN.EnterMoveNextControl = true;
            this.chkDN.HighLighted = false;
            this.chkDN.Location = new System.Drawing.Point(528, 26);
            this.chkDN.MenuManager = this.barManager;
            this.chkDN.Name = "chkDN";
            this.chkDN.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkDN.Properties.Appearance.Options.UseBackColor = true;
            this.chkDN.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkDN.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkDN.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkDN.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkDN.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkDN.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkDN.Properties.Caption = "DN";
            this.chkDN.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkDN.Size = new System.Drawing.Size(36, 19);
            this.chkDN.StyleController = this.lcMain;
            this.chkDN.TabIndex = 11;
            this.chkDN.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciDN
            // 
            this.lciDN.Control = this.chkDN;
            this.lciDN.IsRequired = null;
            this.lciDN.Location = new System.Drawing.Point(526, 24);
            this.lciDN.Name = "lciDN";
            this.lciDN.Size = new System.Drawing.Size(40, 25);
            this.lciDN.Text = "DN";
            this.lciDN.TextSize = new System.Drawing.Size(0, 0);
            this.lciDN.TextVisible = false;
            // 
            // chkJV
            // 
            this.chkJV.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.bsMaster, "JV", true));
            this.chkJV.DefaultState = efControls.Enums.ControlState.Default;
            this.chkJV.EnterMoveNextControl = true;
            this.chkJV.HighLighted = false;
            this.chkJV.Location = new System.Drawing.Point(374, 26);
            this.chkJV.MenuManager = this.barManager;
            this.chkJV.Name = "chkJV";
            this.chkJV.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkJV.Properties.Appearance.Options.UseBackColor = true;
            this.chkJV.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkJV.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkJV.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkJV.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkJV.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkJV.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkJV.Properties.Caption = "JV";
            this.chkJV.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkJV.Size = new System.Drawing.Size(33, 19);
            this.chkJV.StyleController = this.lcMain;
            this.chkJV.TabIndex = 12;
            this.chkJV.ValueType = efControls.Enums.ValueType.Boolean;
            // 
            // lciJV
            // 
            this.lciJV.Control = this.chkJV;
            this.lciJV.IsRequired = null;
            this.lciJV.Location = new System.Drawing.Point(372, 24);
            this.lciJV.Name = "lciJV";
            this.lciJV.Size = new System.Drawing.Size(37, 25);
            this.lciJV.Text = "JV";
            this.lciJV.TextSize = new System.Drawing.Size(0, 0);
            this.lciJV.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(222, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(150, 25);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // colDescription
            // 
            this.colDescription.AlwaysDisabled = false;
            this.colDescription.AppearanceHeader.Options.UseTextOptions = true;
            this.colDescription.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDescription.CustomData = "";
            this.colDescription.EditDisabled = false;
            this.colDescription.FieldName = "Description";
            this.colDescription.Name = "colDescription";
            this.colDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 250;
            // 
            // colType
            // 
            this.colType.AlwaysDisabled = false;
            this.colType.AppearanceHeader.Options.UseTextOptions = true;
            this.colType.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colType.CustomData = "";
            this.colType.EditDisabled = false;
            this.colType.FieldName = "Type";
            this.colType.Name = "colType";
            this.colType.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colType.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colType.Visible = true;
            this.colType.VisibleIndex = 2;
            this.colType.Width = 40;
            // 
            // colOrderID
            // 
            this.colOrderID.AlwaysDisabled = false;
            this.colOrderID.AppearanceHeader.Options.UseTextOptions = true;
            this.colOrderID.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colOrderID.CustomData = "";
            this.colOrderID.EditDisabled = false;
            this.colOrderID.FieldName = "OrderID";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colOrderID.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colOrderID.Visible = true;
            this.colOrderID.VisibleIndex = 3;
            this.colOrderID.Width = 30;
            // 
            // colJV
            // 
            this.colJV.AlwaysDisabled = false;
            this.colJV.AppearanceHeader.Options.UseTextOptions = true;
            this.colJV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colJV.CustomData = "";
            this.colJV.EditDisabled = false;
            this.colJV.FieldName = "JV";
            this.colJV.Name = "colJV";
            this.colJV.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colJV.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colJV.Visible = true;
            this.colJV.VisibleIndex = 4;
            this.colJV.Width = 30;
            // 
            // colRV
            // 
            this.colRV.AlwaysDisabled = false;
            this.colRV.AppearanceHeader.Options.UseTextOptions = true;
            this.colRV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colRV.CustomData = "";
            this.colRV.EditDisabled = false;
            this.colRV.FieldName = "RV";
            this.colRV.Name = "colRV";
            this.colRV.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colRV.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colRV.Visible = true;
            this.colRV.VisibleIndex = 5;
            this.colRV.Width = 30;
            // 
            // colPV
            // 
            this.colPV.AlwaysDisabled = false;
            this.colPV.AppearanceHeader.Options.UseTextOptions = true;
            this.colPV.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colPV.CustomData = "";
            this.colPV.EditDisabled = false;
            this.colPV.FieldName = "PV";
            this.colPV.Name = "colPV";
            this.colPV.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colPV.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colPV.Visible = true;
            this.colPV.VisibleIndex = 6;
            this.colPV.Width = 30;
            // 
            // colCN
            // 
            this.colCN.AlwaysDisabled = false;
            this.colCN.AppearanceHeader.Options.UseTextOptions = true;
            this.colCN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCN.CustomData = "";
            this.colCN.EditDisabled = false;
            this.colCN.FieldName = "CN";
            this.colCN.Name = "colCN";
            this.colCN.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colCN.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colCN.Visible = true;
            this.colCN.VisibleIndex = 7;
            this.colCN.Width = 30;
            // 
            // colDN
            // 
            this.colDN.AlwaysDisabled = false;
            this.colDN.AppearanceHeader.Options.UseTextOptions = true;
            this.colDN.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colDN.CustomData = "";
            this.colDN.EditDisabled = false;
            this.colDN.FieldName = "DN";
            this.colDN.Name = "colDN";
            this.colDN.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.colDN.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            this.colDN.Visible = true;
            this.colDN.VisibleIndex = 8;
            this.colDN.Width = 30;
            // 
            // FormVoucherType
            // 
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(566, 327);
            this.MaximumSize = new System.Drawing.Size(994, 643);
            this.MinimumSize = new System.Drawing.Size(444, 293);
            this.Name = "FormVoucherType";
            this.Text = "Voucher Type Management";
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
            ((System.ComponentModel.ISupportInitialize)(this.txtCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spnOrder.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkRV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciRV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciCN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkPV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciPV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkDN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkJV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciJV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private efControls.efCheckBox chkJV;
        private efControls.efCheckBox chkDN;
        private efControls.efCheckBox chkPV;
        private efControls.efCheckBox chkCN;
        private efControls.efCheckBox chkRV;
        private efControls.efSpinner spnOrder;
        private efControls.efTextBox txtType;
        private efControls.efTextBox txtDescription;
        private efControls.efTextBox txtCode;
        private efControls.lci lciCode;
        private efControls.lci lciDescription;
        private efControls.lci lciType;
        private efControls.lci lciOrder;
        private efControls.lci lciRV;
        private efControls.lci lciCN;
        private efControls.lci lciPV;
        private efControls.lci lciDN;
        private efControls.lci lciJV;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private efControls.efGridColumn colDescription;
        private efControls.efGridColumn colType;
        private efControls.efGridColumn colOrderID;
        private efControls.efGridColumn colJV;
        private efControls.efGridColumn colRV;
        private efControls.efGridColumn colPV;
        private efControls.efGridColumn colCN;
        private efControls.efGridColumn colDN;
    }
}
