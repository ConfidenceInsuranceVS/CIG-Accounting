using efControls.Data;
using System;
using System.Linq;

namespace efControls
{
    public partial class FormDepartments : efDataSearchForm
    {

        public FormDepartments()
        {
            InitializeComponent();
            de = new efFormExtensions<Department>() { f = this };
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            //esSearch.QueryableSource = dbContext.Set<Department>();
            //esSearch.DefaultSorting = "Description";

         
        }

        protected override void onFormLoadSearchData()
        {
            base.onFormLoadSearchData();
            var _id = currentID;
            var aa = SecurityService.listDepartments();
            bsSearch.DataSource = SecurityService.listDepartments();
            de.setPosition<Department>(_id);
            //
            bsMaster.DataMember = "Department";
        }
        #region C.R.U.D
        protected override string onFormGetDeleteString()// added 01/12
        {
            //var rec = (Bank)bsMaster.Current;
            //return string.Format("[{0}] [{1}]", rec.Code, rec.Description);
            var rec = (Department)bsMaster.Current;
            return string.Format("[{0}] [{1}]", rec.ID, rec.Description);
        }
        protected override void onFormEdit()
        {
            base.onFormEdit();
            nameefTextBox.Focus();
        }
        protected override void onFormNew()
        {
            base.onFormNew();
            nameefTextBox.Focus();
        }
        #endregion

        private void nameefTextBox_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (nameefTextBox.Properties.ReadOnly) { return; }

            var rec = (Department)bsMaster.Current;
            if (dbContext.Set<Department>().Where(c => c.Description == nameefTextBox.Text.TrimEnd() && c.ID != rec.ID).FirstOrDefault() != null)
            {
                ControlValidate(nameefTextBox);
                nameefTextBox.Text = string.Empty;
                e.Cancel = true;
            } 
        }

         
    }
}
