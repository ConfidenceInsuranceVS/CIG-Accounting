using efControls.Data;
using System;
using System.Linq;

namespace efControls
{
    public partial class FormGroupRoles : efDataSearchForm
    {
        private GroupRole gr;

        public FormGroupRoles()
        {
            InitializeComponent();

            de = new efFormExtensions<Group>() { f = this };
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //esSearch.QueryableSource = dbContext.Set<Group>();
            //esSearch.DefaultSorting = "Description";
        }

        #region C.R.U.D
        protected override void onFormNew()
        {
            base.onFormNew();
            chkAllowAll.Focus();
        }
        protected override void onFormEdit()
        {
            base.onFormEdit();
            chkAllowAll.Focus();
        }
        #endregion

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            //populateForms();
        }
        private void populateForms()
        {
            var grps = dbContext.Set<Group>().ToList();
            foreach (var grp in grps)
            {
                var forms = dbContext.Set<Form>().ToList();
                foreach (var form in forms)
                {
                    var groupRoles = dbContext.Set<GroupRole>().Where(g => g.GroupID == grp.ID & g.FormID == form.ID).ToList();
                    if (groupRoles.Count == 0)
                    {
                        gr = new GroupRole()
                        {
                            GroupID = grp.ID,
                            FormID = form.ID
                        };
                        dbContext.Set<GroupRole>().Add(gr);
                    }
                    dbContext.SaveChanges();
                }
            }
        }

        private void chkAllowAll_CheckedChanged(object sender, EventArgs e)
        {
            checkUncheck(cboPanels.Text, "ALLOW");
        }
        private void chkAddAll_CheckedChanged(object sender, EventArgs e)
        {
            checkUncheck(cboPanels.Text, "ADD");
        }
        private void chkEditAll_CheckedChanged(object sender, EventArgs e)
        {
            checkUncheck(cboPanels.Text, "EDIT");
        }
        private void chkDeleteAll_CheckedChanged(object sender, EventArgs e)
        {
            checkUncheck(cboPanels.Text, "DELETE");
        }
        private void chkPrintAll_CheckedChanged(object sender, EventArgs e)
        {
            checkUncheck(cboPanels.Text, "PRINT");
        }
        private void checkUncheck(string panel, string column)
        {
            var rec = (Group)bsMaster.Current;
            var grs = dbContext.Set<GroupRole>().Where(g => g.GroupID == rec.ID & (string.IsNullOrEmpty(panel) ? true : g.Form.Panel == panel)).ToList();
            foreach (var gr in grs)
            {
                switch (column)
                {
                    case "ALLOW":
                        gr.Allowed = (bool)chkAllowAll.EditValue;
                        break;
                    case "ADD":
                        gr.CanAdd = (bool)chkAddAll.EditValue;
                        break;
                    case "EDIT":
                        gr.CanEdit = (bool)chkEditAll.EditValue;
                        break;
                    case "DELETE":
                        gr.CanDelete = (bool)chkDeleteAll.EditValue;
                        break;
                    case "PRINT":
                        gr.CanPrint = (bool)chkPrintAll.EditValue;
                        break;
                }
            }
            Refresh();
        }
    }
}
