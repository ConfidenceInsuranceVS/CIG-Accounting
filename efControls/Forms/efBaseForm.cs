using DevExpress.XtraEditors;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraSplashScreen;
using DevExpress.XtraWaitForm;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace efControls
{
    public partial class efBaseForm : XtraForm, IForm
    {
        protected Guid guid;
        protected efMainForm xFrm;
        protected bool isMoveLast = true;
        protected IFormExtensions de;

        #region xProperties
        [Category("xProperties"), Browsable(false)]
        public bool SuperUser { get; set; }
        [Category("xProperties"), Browsable(false)]
        public bool AllowAdd { get; set; }
        [Category("xProperties"), Browsable(false)]
        public bool AllowEdit { get; set; }
        [Category("xProperties"), Browsable(false)]
        public bool AllowDelete { get; set; }
        [Category("xProperties"), Browsable(false)]
        public bool AllowPrint { get; set; }
        [Category("xProperties"), Browsable(false)]
        public bool AllowPost { get; set; }
        [Category("xProperties"), Browsable(false)]
        public bool DenyAccess { get; set; }
        [Category("xProperties"), Browsable(false)]
        private Enums.State Xstate;
        public Enums.State xState
        {
            get
            {
                return Xstate;
            }
            set
            {
                Xstate = value;
                FormRefresh();
            }
        }

        #endregion

        public efBaseForm()
        {
            InitializeComponent();

            guid = Guid.NewGuid();
            xFrm = (efMainForm)MdiParent;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            if (base.DesignMode) { return; }

            if (de != null) { de.logFormIn(guid, string.IsNullOrEmpty(Text) ? Name : Text); }
            SplashScreenManager.CloseForm(false);
            User32.LockWindowUpdate(IntPtr.Zero);
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            if (Alert.ShowDialogMessage("Are you sure you want to quit?") == DialogResult.No)
                e.Cancel = true;
            else
                base.OnClosing(e);
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            if (base.DesignMode) { return; }
            if (de != null) { de.logFormOut(guid); }
        }
        protected virtual void FormRefresh() { }
        public bool isActiveForm() { return MdiParent.ActiveMdiChild.Handle == Handle; }
        protected void clearValidation()
        {
            ep.ClearErrors();
            lblFocus.Focus();
            //
           // var cvr = new ConditionValidationRule() { ConditionOperator = ConditionOperator.None };
            var al = new ArrayList((ICollection)ValidationProvider.GetInvalidControls());
            foreach (Control c in al)
            {
              //  ValidationProvider.SetValidationRule(c, cvr);
                ValidationProvider.RemoveControlError(c);
            }
        }
        protected static void RefreshControl(Control ctrl)
        {
            foreach (Control ctl in ctrl.Controls)
            {
                ctl.Refresh();
                if (ctl.HasChildren)
                    RefreshControl(ctl);
            }
        }
        protected virtual void PostEditors(Control ctrl)
        {
            foreach (Control ctl in ctrl.Controls)
            {
                if (ctl.GetType() == typeof(efGridControl))
                    foreach (efGridView gv in ((efGridControl)ctl).Views) { if (gv.OptionsBehavior.ReadOnly == false) { gv.PostEditor(); } }
                else
                    PostEditors(ctl);
            }
        }
        public void setControlError(Control c, string errorText, CancelEventArgs e)
        {
            c.Focus();
            ep.SetError(c, errorText, ErrorType.Default);
            e.Cancel = true;
        }
        public void clearControlError(Control c, CancelEventArgs e)
        {
            ep.SetError(c, string.Empty, ErrorType.None);
            e.Cancel = false;
        }
        private Point getClientLocation()
        {
            MdiClient client = null;
            foreach (Control ctl in MdiParent.Controls)
            {
                if (ctl is MdiClient)
                {
                    client = ctl as MdiClient;
                    break;
                }
            }

            return client.PointToScreen(Location);
        }
        public Point getWaitFormLocation<T>() where T : WaitForm, new()
        {
            var loc = getClientLocation();
            var p = new Point(loc.X, loc.Y);
            using (T wpf = new T())
            {
                var left = (Width - int.Parse(typeof(T).GetProperty("Width").GetValue(wpf, null).ToString())) / 2;
                var top = (Height - int.Parse(typeof(T).GetProperty("Height").GetValue(wpf, null).ToString())) / 2;
                p.X += left;
                p.Y += top;
            }
            return p;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (xState == Enums.State.None) { Close(); }
        }
    }
}
