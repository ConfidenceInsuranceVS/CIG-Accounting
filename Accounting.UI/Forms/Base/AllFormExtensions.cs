using System;
using System.Linq;
using System.Data.Entity;
using efControls;
using efControls.Data;

namespace Accounting
{
    public class AllFormExtensions<U> : efFormExtensions<U>
        where U : class, ITableAll
    {
        public override bool CheckChanges(string table) { return DataFormServices.CheckChanges<U>(f, table); }
        protected void callForm(string formName, int id)
        {
            using (SecurityEntities se = new SecurityEntities(App.SecurityConnectionString))
            {
                var mFrm = (FormMain)f.MdiParent;
                var frm = (efDataForm)System.Reflection.Assembly.GetExecutingAssembly().CreateInstance(formName);
                var fid = se.Forms.Where(c => c.FormName == frm.Name).FirstOrDefault().ID;

                mFrm.getFormRights(frm, fid);
                mFrm.showForm(frm);
            }
        }
        public override void showUserInfo(object p)
        {
            if (typeof(ITableSome).IsAssignableFrom(typeof(U)))
            {
                //f.bsiCreatedBy.Visibility = f.bsiModifiedBy.Visibility = BarItemVisibility.Never;
                try
                {
                    if (App.ShowUserInfo == false)
                        throw new Exception();

                    //var result = ((AccountingEntities)f.dbContext).getUserInfo(((ITableSome)p).CreatedByID, ((ITableSome)p).ModifiedByID).FirstOrDefault();
                    //if (result.cCode != null)
                    //{
                    //    f.bsiCreatedBy.Caption = string.Format("{0} - {1}", result.cCode, ((ITableSome)p).Creationdate);
                    //    f.bsiCreatedBy.Visibility = BarItemVisibility.Always;
                    //}

                    //if (result.mCode != null)
                    //{
                    //    f.bsiModifiedBy.Caption = string.Format("{0} - {1}", result.mCode, ((ITableSome)p).Modificationdate);
                    //    f.bsiModifiedBy.Visibility = BarItemVisibility.Always;
                    //}
                }
                catch (Exception)
                {
                    //f.bsiCreatedBy.Visibility = f.bsiModifiedBy.Visibility = BarItemVisibility.Never;
                }
            }

            if (typeof(ITablePosted).IsAssignableFrom(typeof(U)) && p != null)
            {
                var pos = ((ITablePosted)p).Isposted ?? false;
                //f.btnPosted.Visibility = pos == true ? BarItemVisibility.Always : BarItemVisibility.Never;
            }

        }
        public override DbContext getDbContext(bool isSecurity)
        {
            if (isSecurity)
                return new SecurityEntities(App.SecurityConnectionString);
            else
                return new AccountingEntities(App.MainConnectionString);
        }
        public override void logFormIn(Guid guid, string name)
        {
            using (var lc = new AccountingEntities(App.MainConnectionString))
            {
                var user = String.Format("{0}-{1}", Environment.MachineName, Environment.UserName);
                var al = new ActivityLogger()
                {
                    Guid = guid.ToString(),
                    UserID = App.UserID,
                    Machine = user,
                    FormName = name,
                    DateIn = DateTime.Now,
                    Remarks = "Opened ..."
                };
                lc.ActivityLoggers.Add(al);
                lc.SaveChanges();
            }
        }
        public override void logFormOut(Guid guid)
        {
            using (var lc = new AccountingEntities(App.MainConnectionString))
            {
                var log = lc.ActivityLoggers.Where(c => c.Guid == guid.ToString()).First();
                log.DateOut = DateTime.Now;
                log.Remarks = null;
                lc.SaveChanges();
            }
        }
    }
}