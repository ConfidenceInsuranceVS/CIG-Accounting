using DevExpress.XtraSplashScreen;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace efControls
{
    public partial class efMainForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        protected bool logout;
        protected bool directClick;
        public Size mfSize;
        public Point mfLocation;

        public virtual void formClosed() { }

        [Category("xProperties"),
        Browsable(false)]
        public Guid guid { get; set; }
        public efMainForm()
        {
            InitializeComponent();
            KeyPreview = true;
            App.xFrm = this;
        }
        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            GetMdiClientWindowInfo();
            //var back = XML.Read(App.PreferencesFile, "General", "Background");
            //if (!string.IsNullOrEmpty(back))
            //{

            //    BackgroundImage = new Bitmap(back);
            //    int style = int.Parse(XML.Read(App.PreferencesFile, "General", "BackgroundStyle"));
            //    switch (style)
            //    {
            //        case 0:
            //            BackgroundImageLayout = ImageLayout.Tile;
            //            break;
            //        case 1:
            //            BackgroundImageLayout = ImageLayout.Center;
            //            break;
            //        case 2:
            //            BackgroundImageLayout = ImageLayout.Stretch;
            //            break;
            //        case 3:
            //            BackgroundImageLayout = ImageLayout.Zoom;
            //            break;
            //    }
            //}
        }
        public void showForm(efBaseForm frm)
        {
            SplashScreenManager.ShowForm((efMainForm)MdiParent, typeof(efWaitForm), false, false, false);
            User32.LockWindowUpdate(Handle);
            try
            {
                if (frm.DenyAccess)
                    throw new Exception("Not Allowed");
                formPreferences(frm);
                frm.MdiParent = this;
                frm.StartPosition = FormStartPosition.CenterScreen;
                frm.Show();
            }
            catch (Exception ex)
            {
                Functions.LogException(ex.ToString());
                Alert.Show(ex.Message, Enums.AlertType.Critical);
                Splash.Close();
                frm.Close();
            }
        }
        public virtual void formPreferences(efBaseForm frm) { }
        public void efMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout) { return; }

            if (ActiveMdiChild != null)
            {
                Alert.Show("Close All Forms Than Retry", Enums.AlertType.Warning);
                e.Cancel = true;
                return;
            }

            var sure = Alert.ShowDialogMessage("Are you sure you want to exit to windows?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (sure == DialogResult.Yes)
                formClosed();
            else
                e.Cancel = true;
        }

        private void bbiThemes_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            efPreferences frm = new efPreferences();
            frm.ShowDialog();
        }

        private void bbiLogout_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            directClick = true;
            logout = true;
            if (MdiChildren.Length == 0)
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
            }
            else
            {
                logout = false;
                Alert.Show("Please close all forms to be able to logout!", Enums.AlertType.Warning);
            }
        }

        private void bbiExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            directClick = true;
            Close();
        }

        private void btnPassword_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            directClick = true;
            changePassword();
        }
        protected virtual void changePassword()// modified by samir ref UE-21/12/2016-2 there was no code
        {
            directClick = true; // added by samir ref UE-21/12/2016-2 there was no code

            var frm = new Forms.SecurityForms.FormChangeUserPassword { StartPosition = FormStartPosition.CenterParent };// added by samir ref UE-21/12/2016-2

            frm.Tag = App.UserID;// added by samir ref UE-21/12/2016-2
            frm.ShowDialog();// added by samir ref UE-21/12/2016-2
        }

        private void GetMdiClientWindowInfo()
        {
            foreach (Control ctl in this.Controls)
                if (ctl is MdiClient)
                {
                    mfSize = new Size(ctl.Size.Width - 10, ctl.Size.Height - 10);
                    mfLocation = PointToScreen(new Point(ctl.Location.X + 5, ctl.Location.Y - 25));
                }
        }

        private void efMainForm_ResizeEnd(object sender, EventArgs e)
        {
            GetMdiClientWindowInfo();
        }
    }
}
