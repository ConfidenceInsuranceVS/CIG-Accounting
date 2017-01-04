namespace Accounting
{
    partial class FormCheques
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheques));
            this.chkCo = new efControls.efCheckBox();
            this.btnExit = new efControls.efButton();
            this.txtAmount = new efControls.efTextBox();
            this.chkFirst = new efControls.efCheckBox();
            this.btnPrint = new efControls.efButton();
            this.btnPreview = new efControls.efButton();
            this.deDate = new efControls.efDateEdit();
            this.txtName = new efControls.efTextBox();
            this.txtTafkit = new efControls.efMultilineTextbox();
            this.peCo = new DevExpress.XtraEditors.PictureEdit();
            this.efLabel1 = new efControls.efLabel();
            this.efLabel2 = new efControls.efLabel();
            this.efLabel3 = new efControls.efLabel();
            this.efLabel4 = new efControls.efLabel();
            this.efLabel5 = new efControls.efLabel();
            this.efLabel6 = new efControls.efLabel();
            this.lblFirst = new efControls.efLabel();
            this.efLabel8 = new efControls.efLabel();
            this.efLabel9 = new efControls.efLabel();
            this.cboCurrencies = new Accounting.cboCurrencies();
            this.btnDesign = new efControls.efButton();
            this.btnClear = new efControls.efButton();
            this.btnRecall = new efControls.efButton();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFirst.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTafkit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCurrencies.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // chkCo
            // 
            this.chkCo.DefaultState = efControls.Enums.ControlState.Default;
            this.chkCo.EnterMoveNextControl = true;
            this.chkCo.HighLighted = false;
            this.chkCo.Location = new System.Drawing.Point(202, 12);
            this.chkCo.Name = "chkCo";
            this.chkCo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkCo.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkCo.Properties.Appearance.Options.UseBackColor = true;
            this.chkCo.Properties.Appearance.Options.UseFont = true;
            this.chkCo.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkCo.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkCo.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkCo.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkCo.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkCo.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkCo.Properties.Caption = "&& Co.";
            this.chkCo.Properties.Name = "efCheckBox";
            this.chkCo.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkCo.Size = new System.Drawing.Size(162, 20);
            this.chkCo.TabIndex = 0;
            this.chkCo.ValueType = efControls.Enums.ValueType.Boolean;
            this.chkCo.CheckedChanged += new System.EventHandler(this.chkCo_CheckedChanged);
            // 
            // btnExit
            // 
            this.btnExit.DefaultState = efControls.Enums.ControlState.Default;
            this.btnExit.HighLighted = false;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(573, 214);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(95, 22);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "&Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.AllowLeadingSpace = false;
            this.txtAmount.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.txtAmount.DisplayType = efControls.Enums.DisplayType.Numeric;
            this.txtAmount.EnterMoveNextControl = true;
            this.txtAmount.Information = null;
            this.txtAmount.Location = new System.Drawing.Point(542, 9);
            this.txtAmount.MaximumSize = new System.Drawing.Size(126, 22);
            this.txtAmount.MinimumSize = new System.Drawing.Size(126, 22);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtAmount.Properties.Appearance.Options.UseFont = true;
            this.txtAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAmount.Properties.Mask.EditMask = "N2";
            this.txtAmount.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmount.Size = new System.Drawing.Size(126, 22);
            this.txtAmount.TabIndex = 3;
            this.txtAmount.EditValueChanged += new System.EventHandler(this.txtAmount_EditValueChanged);
            // 
            // chkFirst
            // 
            this.chkFirst.DefaultState = efControls.Enums.ControlState.Default;
            this.chkFirst.EditValue = true;
            this.chkFirst.EnterMoveNextControl = true;
            this.chkFirst.HighLighted = false;
            this.chkFirst.Location = new System.Drawing.Point(202, 38);
            this.chkFirst.Name = "chkFirst";
            this.chkFirst.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.chkFirst.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.chkFirst.Properties.Appearance.Options.UseBackColor = true;
            this.chkFirst.Properties.Appearance.Options.UseFont = true;
            this.chkFirst.Properties.AppearanceDisabled.BackColor = System.Drawing.Color.Transparent;
            this.chkFirst.Properties.AppearanceDisabled.Options.UseBackColor = true;
            this.chkFirst.Properties.AppearanceFocused.BackColor = System.Drawing.Color.Transparent;
            this.chkFirst.Properties.AppearanceFocused.Options.UseBackColor = true;
            this.chkFirst.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Transparent;
            this.chkFirst.Properties.AppearanceReadOnly.Options.UseBackColor = true;
            this.chkFirst.Properties.Caption = "First Beneficiary";
            this.chkFirst.Properties.Name = "efCheckBox";
            this.chkFirst.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkFirst.Size = new System.Drawing.Size(162, 20);
            this.chkFirst.TabIndex = 1;
            this.chkFirst.ValueType = efControls.Enums.ValueType.Boolean;
            this.chkFirst.CheckedChanged += new System.EventHandler(this.chkFirst_CheckedChanged);
            // 
            // btnPrint
            // 
            this.btnPrint.DefaultState = efControls.Enums.ControlState.Default;
            this.btnPrint.HighLighted = false;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(476, 214);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(95, 22);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "&Print";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.DefaultState = efControls.Enums.ControlState.Default;
            this.btnPreview.HighLighted = false;
            this.btnPreview.Image = ((System.Drawing.Image)(resources.GetObject("btnPreview.Image")));
            this.btnPreview.Location = new System.Drawing.Point(379, 214);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(95, 22);
            this.btnPreview.TabIndex = 7;
            this.btnPreview.Text = "Pre&view";
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // deDate
            // 
            this.deDate.AllowLeadingSpace = false;
            this.deDate.DefaultState = efControls.Enums.ControlState.Default;
            this.deDate.DisplayType = efControls.Enums.DisplayType.Default;
            this.deDate.EditValue = null;
            this.deDate.EnterMoveNextControl = true;
            this.deDate.Information = null;
            this.deDate.Location = new System.Drawing.Point(176, 214);
            this.deDate.Name = "deDate";
            this.deDate.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.deDate.Properties.Appearance.Options.UseFont = true;
            this.deDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.deDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.deDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.deDate.Size = new System.Drawing.Size(93, 22);
            this.deDate.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.AllowLeadingSpace = false;
            this.txtName.DefaultState = efControls.Enums.ControlState.Default;
            this.txtName.DisplayType = efControls.Enums.DisplayType.Default;
            this.txtName.EnterMoveNextControl = true;
            this.txtName.Information = null;
            this.txtName.Location = new System.Drawing.Point(120, 94);
            this.txtName.Name = "txtName";
            this.txtName.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtName.Properties.Appearance.Options.UseFont = true;
            this.txtName.Size = new System.Drawing.Size(548, 22);
            this.txtName.TabIndex = 4;
            // 
            // txtTafkit
            // 
            this.txtTafkit.DefaultState = efControls.Enums.ControlState.AlwaysDisabled;
            this.txtTafkit.EditValue = "";
            this.txtTafkit.EnterMoveNextControl = true;
            this.txtTafkit.Location = new System.Drawing.Point(120, 122);
            this.txtTafkit.Name = "txtTafkit";
            this.txtTafkit.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtTafkit.Properties.Appearance.Options.UseFont = true;
            this.txtTafkit.Properties.ReadOnly = true;
            this.txtTafkit.Size = new System.Drawing.Size(548, 86);
            this.txtTafkit.TabIndex = 5;
            // 
            // peCo
            // 
            this.peCo.EditValue = global::Accounting.Properties.Resources.andco1;
            this.peCo.Location = new System.Drawing.Point(-39, -40);
            this.peCo.Name = "peCo";
            this.peCo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peCo.Properties.Appearance.Options.UseBackColor = true;
            this.peCo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peCo.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.peCo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.peCo.Size = new System.Drawing.Size(168, 163);
            this.peCo.TabIndex = 0;
            this.peCo.Visible = false;
            // 
            // efLabel1
            // 
            this.efLabel1.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.efLabel1.DefaultState = efControls.Enums.ControlState.Default;
            this.efLabel1.HtmlLook = false;
            this.efLabel1.Location = new System.Drawing.Point(120, 71);
            this.efLabel1.Name = "efLabel1";
            this.efLabel1.Size = new System.Drawing.Size(134, 16);
            this.efLabel1.TabIndex = 21;
            this.efLabel1.Text = "Pay against this cheque";
            // 
            // efLabel2
            // 
            this.efLabel2.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.efLabel2.DefaultState = efControls.Enums.ControlState.Default;
            this.efLabel2.HtmlLook = false;
            this.efLabel2.Location = new System.Drawing.Point(25, 124);
            this.efLabel2.Name = "efLabel2";
            this.efLabel2.Size = new System.Drawing.Size(66, 16);
            this.efLabel2.TabIndex = 22;
            this.efLabel2.Text = "The sum of";
            // 
            // efLabel3
            // 
            this.efLabel3.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.efLabel3.DefaultState = efControls.Enums.ControlState.Default;
            this.efLabel3.HtmlLook = false;
            this.efLabel3.Location = new System.Drawing.Point(25, 97);
            this.efLabel3.Name = "efLabel3";
            this.efLabel3.Size = new System.Drawing.Size(88, 16);
            this.efLabel3.TabIndex = 23;
            this.efLabel3.Text = "To the order of";
            // 
            // efLabel4
            // 
            this.efLabel4.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.efLabel4.DefaultState = efControls.Enums.ControlState.Default;
            this.efLabel4.HtmlLook = false;
            this.efLabel4.Location = new System.Drawing.Point(539, 71);
            this.efLabel4.Name = "efLabel4";
            this.efLabel4.Size = new System.Drawing.Size(129, 17);
            this.efLabel4.TabIndex = 24;
            this.efLabel4.Text = "إدفعوا مقابل هذا الشك";
            // 
            // efLabel5
            // 
            this.efLabel5.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.efLabel5.DefaultState = efControls.Enums.ControlState.Default;
            this.efLabel5.HtmlLook = false;
            this.efLabel5.Location = new System.Drawing.Point(674, 97);
            this.efLabel5.Name = "efLabel5";
            this.efLabel5.Size = new System.Drawing.Size(22, 17);
            this.efLabel5.TabIndex = 25;
            this.efLabel5.Text = "لأمر";
            // 
            // efLabel6
            // 
            this.efLabel6.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.efLabel6.DefaultState = efControls.Enums.ControlState.Default;
            this.efLabel6.HtmlLook = false;
            this.efLabel6.Location = new System.Drawing.Point(674, 124);
            this.efLabel6.Name = "efLabel6";
            this.efLabel6.Size = new System.Drawing.Size(58, 17);
            this.efLabel6.TabIndex = 26;
            this.efLabel6.Text = "مبلغا قدره";
            // 
            // lblFirst
            // 
            this.lblFirst.Appearance.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblFirst.DefaultState = efControls.Enums.ControlState.Default;
            this.lblFirst.HtmlLook = false;
            this.lblFirst.Location = new System.Drawing.Point(303, 12);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(163, 17);
            this.lblFirst.TabIndex = 27;
            this.lblFirst.Text = "يدفع للمستفيد الأول فقط";
            // 
            // efLabel8
            // 
            this.efLabel8.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.efLabel8.DefaultState = efControls.Enums.ControlState.Default;
            this.efLabel8.HtmlLook = false;
            this.efLabel8.Location = new System.Drawing.Point(144, 217);
            this.efLabel8.Name = "efLabel8";
            this.efLabel8.Size = new System.Drawing.Size(26, 16);
            this.efLabel8.TabIndex = 28;
            this.efLabel8.Text = "Date";
            // 
            // efLabel9
            // 
            this.efLabel9.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.efLabel9.DefaultState = efControls.Enums.ControlState.Default;
            this.efLabel9.HtmlLook = false;
            this.efLabel9.Location = new System.Drawing.Point(275, 217);
            this.efLabel9.Name = "efLabel9";
            this.efLabel9.Size = new System.Drawing.Size(20, 17);
            this.efLabel9.TabIndex = 29;
            this.efLabel9.Text = "في";
            // 
            // cboCurrencies
            // 
            this.cboCurrencies.DefaultState = efControls.Enums.ControlState.AlwaysEnabled;
            this.cboCurrencies.EnterMoveNextControl = true;
            this.cboCurrencies.Location = new System.Drawing.Point(488, 9);
            this.cboCurrencies.MaximumSize = new System.Drawing.Size(52, 22);
            this.cboCurrencies.MinimumSize = new System.Drawing.Size(52, 22);
            this.cboCurrencies.Name = "cboCurrencies";
            this.cboCurrencies.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.cboCurrencies.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.cboCurrencies.Properties.Appearance.Options.UseFont = true;
            this.cboCurrencies.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cboCurrencies.Properties.Name = "efComboBox";
            this.cboCurrencies.Size = new System.Drawing.Size(52, 22);
            this.cboCurrencies.TabIndex = 2;
            this.cboCurrencies.ValueToDisplay = Accounting.cboCurrencies.DisplayValue.Code;
            this.cboCurrencies.EditValueChanged += new System.EventHandler(this.cboCurrencies_EditValueChanged);
            // 
            // btnDesign
            // 
            this.btnDesign.DefaultState = efControls.Enums.ControlState.Default;
            this.btnDesign.HighLighted = false;
            this.btnDesign.Image = ((System.Drawing.Image)(resources.GetObject("btnDesign.Image")));
            this.btnDesign.Location = new System.Drawing.Point(13, 214);
            this.btnDesign.Name = "btnDesign";
            this.btnDesign.Size = new System.Drawing.Size(23, 23);
            this.btnDesign.TabIndex = 30;
            this.btnDesign.ToolTip = "Design Report";
            this.btnDesign.Click += new System.EventHandler(this.btnDesign_Click);
            // 
            // btnClear
            // 
            this.btnClear.DefaultState = efControls.Enums.ControlState.Default;
            this.btnClear.HighLighted = false;
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.Location = new System.Drawing.Point(38, 214);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(23, 23);
            this.btnClear.TabIndex = 31;
            this.btnClear.ToolTip = "Clear Values";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRecall
            // 
            this.btnRecall.DefaultState = efControls.Enums.ControlState.Default;
            this.btnRecall.HighLighted = false;
            this.btnRecall.Image = ((System.Drawing.Image)(resources.GetObject("btnRecall.Image")));
            this.btnRecall.Location = new System.Drawing.Point(63, 214);
            this.btnRecall.Name = "btnRecall";
            this.btnRecall.Size = new System.Drawing.Size(23, 23);
            this.btnRecall.TabIndex = 32;
            this.btnRecall.ToolTip = "Refill Values";
            this.btnRecall.Click += new System.EventHandler(this.btnRecall_Click);
            // 
            // FormCheques
            // 
            this.Appearance.BackColor = System.Drawing.Color.Cornsilk;
            this.Appearance.Options.UseBackColor = true;
            this.ClientSize = new System.Drawing.Size(738, 246);
            this.ControlBox = false;
            this.Controls.Add(this.btnRecall);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDesign);
            this.Controls.Add(this.efLabel9);
            this.Controls.Add(this.efLabel8);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.efLabel6);
            this.Controls.Add(this.efLabel5);
            this.Controls.Add(this.efLabel4);
            this.Controls.Add(this.deDate);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.txtTafkit);
            this.Controls.Add(this.efLabel3);
            this.Controls.Add(this.efLabel2);
            this.Controls.Add(this.efLabel1);
            this.Controls.Add(this.peCo);
            this.Controls.Add(this.chkCo);
            this.Controls.Add(this.chkFirst);
            this.Controls.Add(this.cboCurrencies);
            this.Controls.Add(this.txtAmount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormCheques";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cheques Printout";
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkCo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkFirst.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTafkit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.peCo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cboCurrencies.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit peCo;
        private efControls.efCheckBox chkCo;
        private efControls.efCheckBox chkFirst;
        private cboCurrencies cboCurrencies;
        private efControls.efTextBox txtAmount;
        private efControls.efTextBox txtName;
        private efControls.efMultilineTextbox txtTafkit;
        private efControls.efDateEdit deDate;
        private efControls.efButton btnPreview;
        private efControls.efButton btnPrint;
        private efControls.efButton btnExit;
        private efControls.efLabel efLabel1;
        private efControls.efLabel efLabel2;
        private efControls.efLabel efLabel3;
        private efControls.efLabel efLabel4;
        private efControls.efLabel efLabel5;
        private efControls.efLabel efLabel6;
        private efControls.efLabel lblFirst;
        private efControls.efLabel efLabel8;
        private efControls.efLabel efLabel9;
        private efControls.efButton btnDesign;
        private efControls.efButton btnClear;
        private efControls.efButton btnRecall;
    }
}
