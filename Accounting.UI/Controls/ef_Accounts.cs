using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Popup;
using DevExpress.XtraGrid;
using System.Windows.Forms;

namespace Accounting
{
    [UserRepositoryItem("Registeref_Accounts")]
    public class RepositoryItemef_Accounts : RepositoryItemGridLookUpEdit
    {
        static RepositoryItemef_Accounts()
        {
            Registeref_Accounts();
        }

        public const string CustomEditName = "ef_Accounts";

        public RepositoryItemef_Accounts()
        {
            Popup += EfAccounts_Popup;
            QueryPopUp += EfAccounts_QueryPopUp;
            QueryCloseUp += EfAccounts_QueryCloseUp;

            MaxLength = App.AccLength;
            ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;
            ValidateOnEnterKey = true;
            TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            NullText = "";
            NullValuePrompt = "Select Account";
            NullValuePromptShowForEmptyValue = true;
            ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;

            View.OptionsView.EnableAppearanceEvenRow = true;
            View.OptionsView.ShowAutoFilterRow = true;
            View.OptionsView.ShowColumnHeaders = false;
            View.OptionsView.ShowFooter = false;
            View.OptionsView.ShowIndicator = false;
            View.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            View.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;

        }
        private void EfAccounts_QueryPopUp(object sender, CancelEventArgs e)
        {
            var bs = (BindingSource)DataSource;
            if (bs.Count == 0) { e.Cancel = true; }
        }
        private void EfAccounts_QueryCloseUp(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var gl = sender as GridLookUpEdit;
            if (gl.Properties.View.RowCount > 0 && gl.Properties.View.FocusedRowHandle < 0)
                gl.Properties.View.FocusedRowHandle = 0;
        }
        private void EfAccounts_Popup(object sender, EventArgs e)
        {
            var gl = sender as GridLookUpEdit;
            gl.Properties.View.FocusedRowHandle = GridControl.AutoFilterRowHandle;
            gl.Properties.View.FocusedColumn = gl.Properties.View.Columns[0];
            gl.Properties.View.ShowEditor();
            gl.Properties.View.Columns[0].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void Registeref_Accounts()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(ef_Accounts), typeof(RepositoryItemef_Accounts), typeof(ef_AccountsViewInfo), new ef_AccountsPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemef_Accounts source = item as RepositoryItemef_Accounts;
                if (source == null) return;
                //
            }
            finally
            {
                EndUpdate();
            }
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }

    [ToolboxItem(true)]
    public class ef_Accounts : GridLookUpEdit
    {
        static ef_Accounts()
        {
            RepositoryItemef_Accounts.Registeref_Accounts();
        }

        public ef_Accounts()
        {
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemef_Accounts Properties
        {
            get
            {
                return base.Properties as RepositoryItemef_Accounts;
            }
        }

        private List<ucAccounts> fillBindingsource(AccountingEntities lc)
        {
            return lc.Chartofaccounts
                .Where(c => c.isParent == false)
                .Select(c => new ucAccounts { ID = c.ID, Code = c.Code, Description = c.Description, CodeDescription = c.Code + "\t" + c.Description })
                .OrderBy(c => c.Code).ToList();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            EnterMoveNextControl = true;

            Properties.ValidateOnEnterKey = true;
            Properties.MaxLength = App.AccLength;
            Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            Properties.NullText = "";
            Properties.NullValuePrompt = "Select Account";
            Properties.NullValuePromptShowForEmptyValue = true;
            Properties.ShowDropDown = DevExpress.XtraEditors.Controls.ShowDropDown.Never;

            Properties.View.OptionsView.EnableAppearanceEvenRow = true;
            Properties.View.OptionsView.ShowAutoFilterRow = true;
            Properties.View.OptionsView.ShowColumnHeaders = false;
            Properties.View.OptionsView.ShowFooter = false;
            Properties.View.OptionsView.ShowIndicator = false;
            Properties.View.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            Properties.View.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            
            //Properties.View.Columns[0].OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains;
       }
        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemef_Accounts.CustomEditName;
            }
        }

        protected override PopupBaseForm CreatePopupForm()
        {
            return new ef_AccountsPopupForm(this);
        }
    }

    public class ef_AccountsViewInfo : GridLookUpEditBaseViewInfo
    {
        public ef_AccountsViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class ef_AccountsPainter : ButtonEditPainter
    {
        public ef_AccountsPainter()
        {
        }
    }

    public class ef_AccountsPopupForm : PopupGridLookUpEditForm
    {
        public ef_AccountsPopupForm(ef_Accounts ownerEdit) : base(ownerEdit)
        {
        }
    }
}
