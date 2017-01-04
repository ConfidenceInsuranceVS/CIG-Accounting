using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using efControls;
using System.ComponentModel;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using static Accounting.AccountingServices;

namespace Accounting
{
    public partial class cboAccounts : efGridLookUpEdit
    {

        private DevExpress.XtraGrid.Views.Grid.GridView efGridView;
        private DevExpress.XtraGrid.Columns.GridColumn colCodeDescription;

        [Category("xProperties"), Browsable(true)]
        public string StartWith { get; set; }

        [Category("xProperties"), Browsable(true)]
        public string AccountStatusFlag { get; set; }

        [Category("xProperties"), Browsable(true)]
        public bool ShowContextImage { get; set; }

        [Category("xProperties"), Browsable(true)]
        public bool ShowAccountNumber { get; set; }

        [Category("xProperties"), Browsable(true)]
        public BindingSource bs { get; set; }

        public int id;
        public string Code, Description;

        //public string AccountName = string.Empty;
        public cboAccounts()
        {
            InitializeComponent();
            EnterMoveNextControl = true;
            //
            ShowContextImage = true;
            ShowAccountNumber = true;
            //
            EditValueChanged += CboAccounts_EditValueChanged;
            QueryPopUp += CboAccounts_QueryPopUp;
            QueryCloseUp += CboAccounts_QueryCloseUp;
            Popup += CboAccounts_Popup;
            CloseUp += CboAccounts_CloseUp;
        }

        private void CboAccounts_CloseUp(object sender, DevExpress.XtraEditors.Controls.CloseUpEventArgs e)
        {
            var gl = sender as GridLookUpEdit;
            gl.Properties.View.ActiveFilterString = string.Empty;
        }

        private void CboAccounts_Popup(object sender, EventArgs e)
        {
            var gl = sender as GridLookUpEdit;
            gl.Properties.View.FocusedRowHandle = GridControl.AutoFilterRowHandle;
            gl.Properties.View.FocusedColumn = gl.Properties.View.Columns[0];
            gl.Properties.View.ShowEditor();
            gl.Properties.View.Columns[0].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            //gl.Properties.View.ActiveFilterString = Text;
        }

        private void CboAccounts_QueryCloseUp(object sender, CancelEventArgs e)
        {
            var gl = sender as GridLookUpEdit;
            if (gl.Properties.View.RowCount > 0 && gl.Properties.View.FocusedRowHandle < 0)
                gl.Properties.View.FocusedRowHandle = 0;
        }

        private void CboAccounts_QueryPopUp(object sender, CancelEventArgs e)
        {
            var bs = (BindingSource)Properties.DataSource;
            if (bs.Count == 0) { e.Cancel = true; }
        }

        //private void CboAccounts_EditValueChanged(object sender, EventArgs e) // modified by samir with rafic 6/12
        //{
        //    var edit = sender as GridLookUpEdit;
        //    var row = (ucAccounts)edit.GetSelectedDataRow();

        //    if (EditValue == null || row == null)
        //        clear();
        //    else
        //    {
        //        id = row.ID;
        //        Code = row.Code;
        //        Description = row.Description;
        //    }
        //}

        private void CboAccounts_EditValueChanged(object sender, EventArgs e) // added by Samir with Rafic  UE-6/12/2016-1
        {
            var ge = sender as efGridLookUpEdit;
            try
            {
                var row = bs.List.OfType<ucAccounts>().FirstOrDefault(c => c.ID == (int)ge.EditValue);
                if (row != null)
                {
                    id = row.ID;
                    Code = row.Code;
                    Description = row.Description;
                }
            }
            catch (Exception)
            {
                clear();
            }
        }



        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            if (IsDesignMode) { return; }

            if (bs == null)
            {
                bs = new BindingSource();
                bs.DataSource = getAccounts(StartWith, AccountStatusFlag);
            }

            Properties.DataSource = bs;
            Properties.DisplayMember = ShowAccountNumber ? "CodeDescription" : "Description";
            Properties.ValueMember = "ID";

            if (Properties.Buttons.Count > 0)
            {
                for (int i = 0; i < Properties.Buttons.Count; i++)
                    Properties.Buttons.RemoveAt(i);
            }
            //
            EnterMoveNextControl = true;
            ToolTip = "...";
            ToolTipTitle = "Press [CTRL+DELETE] To Clear Value ...";
            ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            //
            efGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            colCodeDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            colCodeDescription.FieldName = ShowAccountNumber ? "CodeDescription" : "Description";
            colCodeDescription.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
            colCodeDescription.Visible = true;
            colCodeDescription.VisibleIndex = 1;
            efGridView.Columns.Add(colCodeDescription);
            // 
            Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            Properties.ValidateOnEnterKey = true;
            Properties.MaxLength = App.AccLength;
            Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            Properties.ContextImage = ShowContextImage ? global::Accounting.Properties.Resources.ZoomOut_16x16 : null;
            Properties.ContextImageAlignment = ShowContextImage ? ContextImageAlignment.Far : ContextImageAlignment.Near;
            Properties.NullText = string.Empty;
            Properties.NullValuePrompt = "Select Account Or Leave Blank";
            Properties.NullValuePromptShowForEmptyValue = true;
            Properties.PopupFormMinSize = new System.Drawing.Size(350, 200);
            //
            Properties.View = efGridView;
            Properties.View.OptionsView.EnableAppearanceEvenRow = true;
            Properties.View.OptionsView.ShowAutoFilterRow = true;
            Properties.View.OptionsView.ShowColumnHeaders = false;
            Properties.View.OptionsView.ShowFooter = false;
            Properties.View.OptionsView.ShowIndicator = false;
            Properties.View.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            Properties.View.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
        }
        public void clear()
        {
            EditValue = null;
            Code = Description = string.Empty;
            id = 0;
        }

    }
}
