namespace efControls
{
    partial class FormUserRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserRoles));
            this.bsRoles = new System.Windows.Forms.BindingSource(this.components);
            this.gcRoles = new efControls.efGridControl();
            this.gvRoles = new efControls.efGridView();
            this.colPanel = new efControls.efGridColumn();
            this.colGroup = new efControls.efGridColumn();
            this.colFormName = new efControls.efGridColumn();
            this.colAllowed = new efControls.efGridColumn();
            this.colCanAdd = new efControls.efGridColumn();
            this.colCanEdit = new efControls.efGridColumn();
            this.colCanDelete = new efControls.efGridColumn();
            this.colCanPrint = new efControls.efGridColumn();
            this.lciGrid = new efControls.lci();
            this.bsForms = new System.Windows.Forms.BindingSource(this.components);
            this.lciForms = new efControls.lci();
            this.cboForms = new efControls.efComboBox();
            this.btnAddForm = new efControls.efButton();
            this.lciAdd = new efControls.lci();
            this.btnDeleteForm = new efControls.efButton();
            this.lciDelete = new efControls.lci();
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
            ((System.ComponentModel.ISupportInitialize)(this.bsRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciForms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboForms.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // gcSearch
            // 
            this.gcSearch.EmbeddedNavigator.Buttons.Append.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Edit.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.First.ImageIndex = 0;
            this.gcSearch.EmbeddedNavigator.Buttons.First.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Last.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Next.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.NextPage.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Prev.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.PrevPage.Visible = false;
            this.gcSearch.EmbeddedNavigator.Buttons.Remove.Visible = false;
            gridLevelNode1.RelationName = "Level1";
            this.gcSearch.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gcSearch.Size = new System.Drawing.Size(116, 268);
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
            this.colSearch.FieldName = "Name";
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
            this.barDockControlTop.Size = new System.Drawing.Size(763, 31);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 349);
            this.barDockControlBottom.Size = new System.Drawing.Size(763, 27);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 31);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 318);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.Location = new System.Drawing.Point(763, 31);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 318);
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
            this.sccMain.Location = new System.Drawing.Point(0, 31);
            this.sccMain.Size = new System.Drawing.Size(763, 318);
            // 
            // lcSearch
            // 
            this.lcSearch.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(448, 27, 250, 350);
            this.lcSearch.Size = new System.Drawing.Size(120, 318);
            this.lcSearch.Controls.SetChildIndex(this.gcSearch, 0);
            // 
            // lcgSearch
            // 
            this.lcgSearch.Size = new System.Drawing.Size(120, 318);
            // 
            // lcMain
            // 
            this.lcMain.Controls.Add(this.btnDeleteForm);
            this.lcMain.Controls.Add(this.btnAddForm);
            this.lcMain.Controls.Add(this.gcRoles);
            this.lcMain.Controls.Add(this.cboForms);
            this.lcMain.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(692, 321, 250, 350);
            this.lcMain.Size = new System.Drawing.Size(638, 318);
            // 
            // lcgMain
            // 
            this.lcgMain.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.lciGrid,
            this.lciForms,
            this.lciAdd,
            this.lciDelete});
            this.lcgMain.Size = new System.Drawing.Size(638, 318);
            // 
            // imageCollection
            // 
            this.imageCollection.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("imageCollection.ImageStream")));
            // 
            // bciPosted
            // 
            this.bciPosted.ItemAppearance.Pressed.BackColor = System.Drawing.Color.Transparent;
            this.bciPosted.ItemAppearance.Pressed.Options.UseBackColor = true;
            // 
            // bsSearch
            // 
            this.bsSearch.DataSource = typeof(efControls.Data.User);
            // 
            // bsRoles
            // 
            this.bsRoles.DataMember = "UserRoles";
            this.bsRoles.DataSource = this.bsMaster;
            // 
            // gcRoles
            // 
            this.gcRoles.DataSource = this.bsRoles;
            this.gcRoles.DefaultState = efControls.Enums.ControlState.Default;
            this.gcRoles.EmbeddedNavigatorHideButtons = false;
            this.gcRoles.Location = new System.Drawing.Point(2, 28);
            this.gcRoles.MainView = this.gvRoles;
            this.gcRoles.MenuManager = this.barManager;
            this.gcRoles.Name = "gcRoles";
            this.gcRoles.Size = new System.Drawing.Size(634, 288);
            this.gcRoles.TabIndex = 4;
            this.gcRoles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvRoles});
            // 
            // gvRoles
            // 
            this.gvRoles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colPanel,
            this.colGroup,
            this.colFormName,
            this.colAllowed,
            this.colCanAdd,
            this.colCanEdit,
            this.colCanDelete,
            this.colCanPrint});
            this.gvRoles.GridControl = this.gcRoles;
            this.gvRoles.HighLightFocusedRow = true;
            this.gvRoles.Name = "gvRoles";
            this.gvRoles.OptionsBehavior.ReadOnly = true;
            this.gvRoles.OptionsCustomization.AllowColumnMoving = false;
            this.gvRoles.OptionsCustomization.AllowColumnResizing = false;
            this.gvRoles.OptionsDetail.EnableMasterViewMode = false;
            this.gvRoles.OptionsFind.AllowFindPanel = false;
            this.gvRoles.OptionsMenu.EnableColumnMenu = false;
            this.gvRoles.OptionsMenu.EnableFooterMenu = false;
            this.gvRoles.OptionsMenu.EnableGroupPanelMenu = false;
            this.gvRoles.OptionsNavigation.AutoFocusNewRow = true;
            this.gvRoles.OptionsNavigation.EnterMoveNextColumn = true;
            this.gvRoles.OptionsView.ColumnAutoWidth = false;
            this.gvRoles.OptionsView.EnableAppearanceEvenRow = true;
            this.gvRoles.OptionsView.ShowGroupPanel = false;
            this.gvRoles.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            this.gvRoles.OptionsView.ShowIndicator = false;
            this.gvRoles.OptionsView.ShowViewCaption = true;
            this.gvRoles.ParentForm = null;
            this.gvRoles.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gvRoles.VisibleAutoFilterRow = false;
            this.gvRoles.VisibleGroupPanel = false;
            this.gvRoles.VisibleIndicator = false;
            // 
            // colPanel
            // 
            this.colPanel.AlwaysDisabled = false;
            this.colPanel.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colPanel.AppearanceHeader.Options.UseFont = true;
            this.colPanel.Caption = "Panel";
            this.colPanel.CustomData = "";
            this.colPanel.EditDisabled = false;
            this.colPanel.FieldName = "Form.Panel";
            this.colPanel.Name = "colPanel";
            this.colPanel.Visible = true;
            this.colPanel.VisibleIndex = 0;
            this.colPanel.Width = 92;
            // 
            // colGroup
            // 
            this.colGroup.AlwaysDisabled = false;
            this.colGroup.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colGroup.AppearanceHeader.Options.UseFont = true;
            this.colGroup.Caption = "Group";
            this.colGroup.CustomData = "";
            this.colGroup.EditDisabled = false;
            this.colGroup.FieldName = "Form.FormGroup";
            this.colGroup.Name = "colGroup";
            this.colGroup.Visible = true;
            this.colGroup.VisibleIndex = 1;
            this.colGroup.Width = 92;
            // 
            // colFormName
            // 
            this.colFormName.AlwaysDisabled = false;
            this.colFormName.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colFormName.AppearanceHeader.Options.UseFont = true;
            this.colFormName.Caption = "Form Name";
            this.colFormName.CustomData = "";
            this.colFormName.EditDisabled = false;
            this.colFormName.FieldName = "Form.FormName";
            this.colFormName.Name = "colFormName";
            this.colFormName.OptionsFilter.AllowAutoFilter = false;
            this.colFormName.OptionsFilter.AllowFilter = false;
            this.colFormName.Visible = true;
            this.colFormName.VisibleIndex = 2;
            this.colFormName.Width = 184;
            // 
            // colAllowed
            // 
            this.colAllowed.AlwaysDisabled = false;
            this.colAllowed.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colAllowed.AppearanceHeader.Options.UseFont = true;
            this.colAllowed.AppearanceHeader.Options.UseTextOptions = true;
            this.colAllowed.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colAllowed.Caption = "Allow";
            this.colAllowed.CustomData = "";
            this.colAllowed.EditDisabled = false;
            this.colAllowed.FieldName = "Allowed";
            this.colAllowed.Name = "colAllowed";
            this.colAllowed.OptionsFilter.AllowAutoFilter = false;
            this.colAllowed.OptionsFilter.AllowFilter = false;
            this.colAllowed.Visible = true;
            this.colAllowed.VisibleIndex = 3;
            this.colAllowed.Width = 40;
            // 
            // colCanAdd
            // 
            this.colCanAdd.AlwaysDisabled = false;
            this.colCanAdd.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCanAdd.AppearanceHeader.Options.UseFont = true;
            this.colCanAdd.AppearanceHeader.Options.UseTextOptions = true;
            this.colCanAdd.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanAdd.Caption = "Add";
            this.colCanAdd.CustomData = "";
            this.colCanAdd.EditDisabled = false;
            this.colCanAdd.FieldName = "CanAdd";
            this.colCanAdd.Name = "colCanAdd";
            this.colCanAdd.OptionsFilter.AllowAutoFilter = false;
            this.colCanAdd.OptionsFilter.AllowFilter = false;
            this.colCanAdd.Visible = true;
            this.colCanAdd.VisibleIndex = 4;
            this.colCanAdd.Width = 40;
            // 
            // colCanEdit
            // 
            this.colCanEdit.AlwaysDisabled = false;
            this.colCanEdit.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCanEdit.AppearanceHeader.Options.UseFont = true;
            this.colCanEdit.AppearanceHeader.Options.UseTextOptions = true;
            this.colCanEdit.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanEdit.Caption = "Edit";
            this.colCanEdit.CustomData = "";
            this.colCanEdit.EditDisabled = false;
            this.colCanEdit.FieldName = "CanEdit";
            this.colCanEdit.Name = "colCanEdit";
            this.colCanEdit.OptionsFilter.AllowAutoFilter = false;
            this.colCanEdit.OptionsFilter.AllowFilter = false;
            this.colCanEdit.Visible = true;
            this.colCanEdit.VisibleIndex = 5;
            this.colCanEdit.Width = 40;
            // 
            // colCanDelete
            // 
            this.colCanDelete.AlwaysDisabled = false;
            this.colCanDelete.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCanDelete.AppearanceHeader.Options.UseFont = true;
            this.colCanDelete.AppearanceHeader.Options.UseTextOptions = true;
            this.colCanDelete.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanDelete.Caption = "Delete";
            this.colCanDelete.CustomData = "";
            this.colCanDelete.EditDisabled = false;
            this.colCanDelete.FieldName = "CanDelete";
            this.colCanDelete.Name = "colCanDelete";
            this.colCanDelete.OptionsFilter.AllowAutoFilter = false;
            this.colCanDelete.OptionsFilter.AllowFilter = false;
            this.colCanDelete.Visible = true;
            this.colCanDelete.VisibleIndex = 6;
            this.colCanDelete.Width = 45;
            // 
            // colCanPrint
            // 
            this.colCanPrint.AlwaysDisabled = false;
            this.colCanPrint.AppearanceHeader.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.colCanPrint.AppearanceHeader.Options.UseFont = true;
            this.colCanPrint.AppearanceHeader.Options.UseTextOptions = true;
            this.colCanPrint.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.colCanPrint.Caption = "Print";
            this.colCanPrint.CustomData = "";
            this.colCanPrint.EditDisabled = false;
            this.colCanPrint.FieldName = "CanPrint";
            this.colCanPrint.Name = "colCanPrint";
            this.colCanPrint.OptionsFilter.AllowAutoFilter = false;
            this.colCanPrint.OptionsFilter.AllowFilter = false;
            this.colCanPrint.Visible = true;
            this.colCanPrint.VisibleIndex = 7;
            this.colCanPrint.Width = 40;
            // 
            // lciGrid
            // 
            this.lciGrid.Control = this.gcRoles;
            this.lciGrid.CustomizationFormText = "efLayoutControlItem1";
            this.lciGrid.IsRequired = null;
            this.lciGrid.Location = new System.Drawing.Point(0, 26);
            this.lciGrid.Name = "lciGrid";
            this.lciGrid.Size = new System.Drawing.Size(638, 292);
            this.lciGrid.TextSize = new System.Drawing.Size(0, 0);
            this.lciGrid.TextVisible = false;
            // 
            // bsForms
            // 
            this.bsForms.DataSource = typeof(efControls.Data.Form);
            // 
            // lciForms
            // 
            this.lciForms.Control = this.cboForms;
            this.lciForms.CustomizationFormText = "Select Form";
            this.lciForms.IsRequired = null;
            this.lciForms.Location = new System.Drawing.Point(0, 0);
            this.lciForms.Name = "lciForms";
            this.lciForms.Size = new System.Drawing.Size(464, 26);
            this.lciForms.Text = "Select Form";
            this.lciForms.TextSize = new System.Drawing.Size(56, 13);
            // 
            // cboForms
            // 
            this.cboForms.DefaultState = efControls.Enums.ControlState.Default;
            this.cboForms.EnterMoveNextControl = true;
            this.cboForms.Location = new System.Drawing.Point(62, 2);
            this.cboForms.MenuManager = this.barManager;
            this.cboForms.Name = "cboForms";
            this.cboForms.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboForms.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboForms.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormGroup", "Form Group", 50, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FormName", "Form Name", 150, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.cboForms.Properties.DataSource = this.bsForms;
            this.cboForms.Properties.DisplayMember = "FormName";
            this.cboForms.Properties.Name = "efComboBox";
            this.cboForms.Properties.NullText = "Select Form From Below And Assign Permissions";
            this.cboForms.Properties.ReadOnly = true;
            this.cboForms.Properties.ValueMember = "ID";
            this.cboForms.Size = new System.Drawing.Size(400, 20);
            this.cboForms.StyleController = this.lcMain;
            this.cboForms.TabIndex = 5;
            // 
            // btnAddForm
            // 
            this.btnAddForm.DefaultState = efControls.Enums.ControlState.Default;
            this.btnAddForm.HighLighted = false;
            this.btnAddForm.Location = new System.Drawing.Point(466, 2);
            this.btnAddForm.Name = "btnAddForm";
            this.btnAddForm.Size = new System.Drawing.Size(83, 22);
            this.btnAddForm.StyleController = this.lcMain;
            this.btnAddForm.TabIndex = 6;
            this.btnAddForm.Text = "Add Form";
            this.btnAddForm.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lciAdd
            // 
            this.lciAdd.Control = this.btnAddForm;
            this.lciAdd.CustomizationFormText = "lciAdd";
            this.lciAdd.IsRequired = null;
            this.lciAdd.Location = new System.Drawing.Point(464, 0);
            this.lciAdd.Name = "lciAdd";
            this.lciAdd.Size = new System.Drawing.Size(87, 26);
            this.lciAdd.TextSize = new System.Drawing.Size(0, 0);
            this.lciAdd.TextVisible = false;
            // 
            // btnDeleteForm
            // 
            this.btnDeleteForm.DefaultState = efControls.Enums.ControlState.Default;
            this.btnDeleteForm.HighLighted = false;
            this.btnDeleteForm.Location = new System.Drawing.Point(553, 2);
            this.btnDeleteForm.Name = "btnDeleteForm";
            this.btnDeleteForm.Size = new System.Drawing.Size(83, 22);
            this.btnDeleteForm.StyleController = this.lcMain;
            this.btnDeleteForm.TabIndex = 7;
            this.btnDeleteForm.Text = "Delete Form";
            this.btnDeleteForm.Click += new System.EventHandler(this.btnDeleteForm_Click);
            // 
            // lciDelete
            // 
            this.lciDelete.Control = this.btnDeleteForm;
            this.lciDelete.CustomizationFormText = "lciDelete";
            this.lciDelete.IsRequired = null;
            this.lciDelete.Location = new System.Drawing.Point(551, 0);
            this.lciDelete.Name = "lciDelete";
            this.lciDelete.Size = new System.Drawing.Size(87, 26);
            this.lciDelete.TextSize = new System.Drawing.Size(0, 0);
            this.lciDelete.TextVisible = false;
            // 
            // FormUserRoles
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 376);
            this.MaximumSize = new System.Drawing.Size(1008, 647);
            this.MinimumSize = new System.Drawing.Size(506, 301);
            this.Name = "FormUserRoles";
            this.Text = "User Roles Management";
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
            ((System.ComponentModel.ISupportInitialize)(this.bsRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gcRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRoles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciForms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboForms.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lciDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private efControls.efGridControl gcRoles;
        private System.Windows.Forms.BindingSource bsRoles;
        private efControls.lci lciGrid;
        private efControls.efGridView gvRoles;
        private efControls.efGridColumn colPanel;
        private efControls.efGridColumn colFormName;
        private efControls.efGridColumn colAllowed;
        private efControls.efGridColumn colCanAdd;
        private efControls.efGridColumn colCanEdit;
        private efControls.efGridColumn colCanDelete;
        private efControls.efGridColumn colCanPrint;
        private System.Windows.Forms.BindingSource bsForms;
        private efControls.efButton btnAddForm;
        private efControls.lci lciForms;
        private efControls.lci lciAdd;
        private efControls.efGridColumn colGroup;
        private efControls.efButton btnDeleteForm;
        private efControls.lci lciDelete;
        private efComboBox cboForms;
    }
}