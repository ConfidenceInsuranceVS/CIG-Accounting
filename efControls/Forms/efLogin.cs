using DevExpress.XtraEditors;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace efControls
{
    public partial class efLogin : XtraForm
    {
        public bool lockscreen;
        public DialogResult dg = DialogResult.No;

        [Category("xProperties"),
        Browsable(false)]
        public Guid guid { get; set; }

        public virtual bool checkPassword() { return false; }

        public efLogin()
        {
            InitializeComponent();
        }
        protected override void OnLoad(EventArgs e)
        {
            Size = new System.Drawing.Size((int)(Screen.PrimaryScreen.Bounds.Width * 0.4), (int)(Screen.PrimaryScreen.Bounds.Height * 0.4));
            base.OnLoad(e);
        }
        private void efLogin_Shown(object sender, EventArgs e)
        {
            if (DesignMode) { return; }
            guid = Guid.NewGuid();
        }
        private void cboUsername_EditValueChanged(object sender, EventArgs e)
        {
            txtPassword.Text = string.Empty;
        }
        private void peClose_Click(object sender, EventArgs e)
        {
            dg = DialogResult.None;
            Close();
        }
        private void peMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void tsPassword_EditValueChanged(object sender, EventArgs e)
        {
            txtPassword.Properties.PasswordChar = (bool)tsPassword.EditValue ? '\0' : '●';
        }
    }
}
