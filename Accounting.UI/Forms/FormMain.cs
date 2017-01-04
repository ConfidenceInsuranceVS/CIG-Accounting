using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using System;
using System.Linq;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using efControls;
using efControls.Data;
using System.IO;
using DevExpress.XtraSplashScreen;

namespace Accounting
{
    public partial class FormMain : efMainForm
    {
        IFormExtensions de;
        public FormMain()
        {
            InitializeComponent();
            Size = new Size(1024, 768);
            StartPosition = FormStartPosition.CenterScreen;
            populateForms();
            barCompanyAndYear.Caption = string.Format("{0} [{1}] - {2}", App.CompanyName, App.WorkingYear, DateTime.Now);
            barLoggedInAs.Caption = string.Format("Logged As {0}", App.UserName);
            directClick = false;
            de = new AllFormExtensions<User>();
            Text = string.Format("{0} [{1}]", App.CompanyName, App.WorkingYear);
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            de.logFormIn(guid, string.IsNullOrEmpty(Text) ? Name : Text);
        }
        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            de.logFormOut(guid);
        }
        private void btnSystemMonitor_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            directClick = true;
            var frm = new efPreferences();
            frm.ShowDialog();
        }
        private void btnDatabase_ItemClick(object sender, ItemClickEventArgs e)
        {
            SplashScreenManager.ShowForm((efMainForm)MdiParent, typeof(efWaitForm), false, false, false);
            directClick = true;
            var frm = new FormSetConnections();
            frm.ShowDialog();
        }
        private void ribbon_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (e.Item.GetType() != typeof(BarButtonItem)) { return; }
            if (directClick)
                directClick = false;
            else
            {
                if (string.IsNullOrEmpty(e.Item.Description)) { return; }

                var frmName = string.Format("{0}.{1}", App.Name, e.Item.Description);
                var frm = (efBaseForm)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(frmName);
                if (frm == null) { return; }
                getFormRights(frm, e.Item.Id);
                showForm(frm);
            }
        }
        private void bbiExit_ItemClick(object sender, ItemClickEventArgs e)
        {
            directClick = true;
            Close();
        }
     
        private void bbiLogout_ItemClick(object sender, ItemClickEventArgs e)
        {
            directClick = true;
            logout = true;
            if (MdiChildren.Length == 0)
            {
                System.Diagnostics.Process.Start(Application.ExecutablePath);
                Application.Exit();
                //Application.Exit();
                //Application.Restart();
            }
            else
            {
                logout = false;
                Alert.Show("Please close all forms to be able to logout!", Enums.AlertType.Warning);
            }
        }
        private void btnPasswordChange_ItemClick(object sender, ItemClickEventArgs e)
        {
            directClick = true;
            var frm = new FormChangePassword() { StartPosition = FormStartPosition.CenterParent };
            frm.ShowDialog();
        }

        #region PopulateForms
        private string _panel, _group, _form;
        private int _bid;
        private void populateForms()
        {
            using (SecurityEntities sc = new SecurityEntities(App.SecurityConnectionString))
            {
                foreach (RibbonPage rp in ribbon.Pages)
                {
                    _panel = rp.Text;
                    foreach (RibbonPageGroup rpg in rp.Groups)
                    {
                        _group = rpg.Text;
                        foreach (var link in rpg.ItemLinks)
                        {
                            if (link.GetType() == typeof(BarButtonItemLink))
                            {
                                updateForm(sc, (BarButtonItemLink)link);
                            }
                            else if (link.GetType() == typeof(BarSubItemLink))
                            {
                                foreach (var bsi in ((BarSubItemLink)link).VisibleLinks)
                                {
                                    if (bsi.GetType() == typeof(BarButtonItemLink))
                                    {
                                        foreach (var bs in ((BarButtonItemLink)bsi).Links)
                                        {
                                            updateForm(sc, (BarButtonItemLink)bsi);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void updateForm(SecurityEntities sc, BarButtonItemLink link)
        {
            _form = link.Item.Description;
            if (string.IsNullOrEmpty(_form)) { return; }

            _bid = link.ItemId;

            var ff = sc.Forms.Where(c => c.ID == _bid).FirstOrDefault();
            if (ff == null)
            {
                ff = new efControls.Data.Form() { ID = _bid };
                sc.Forms.Add(ff);
            }
            ff.Panel = _panel;
            ff.FormGroup = _group;
            ff.FormName = link.Item.Description;

            sc.SaveChanges();
        }
        #endregion
        public void getFormRights(efBaseForm frm, int Id)
        {
            var sc = new SecurityEntities(App.SecurityConnectionString);
            if (App.UserName.ToUpper() == "ADMINISTRATOR")
            {
                frm.DenyAccess = false;
                frm.AllowAdd = frm.AllowEdit = frm.AllowDelete = frm.AllowPrint = true;
            }
            else
            {
                var priv = sc.UserRoles.Where(c => c.UserID == App.UserID & c.FormID == Id)
                    .Select(p => new { p.Allowed, p.CanAdd, p.CanDelete, p.CanEdit, p.CanPrint })
                    .FirstOrDefault();

                if (priv == null)
                {
                    priv = sc.GroupRoles.Where(c => c.GroupID == App.UserGroupID & c.FormID == Id)
                        .Select(p => new { p.Allowed, p.CanAdd, p.CanDelete, p.CanEdit, p.CanPrint })
                        .FirstOrDefault();
                }
                if (priv == null)
                {
                    return;
                }
                frm.DenyAccess = priv.Allowed == null ? true : !(bool)priv.Allowed;
                frm.AllowAdd = priv.CanAdd == null ? false : (bool)priv.CanAdd;
                frm.AllowEdit = priv.CanEdit == null ? false : (bool)priv.CanEdit;
                frm.AllowDelete = priv.CanDelete == null ? false : (bool)priv.CanDelete;
                frm.AllowPrint = priv.CanPrint == null ? false : (bool)priv.CanPrint;
            }
        }
    }
}
