using efControls.Data;
using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;

namespace efControls
{
    public class efFormExtensions<U> : IDisposable, IFormExtensions
        where U : class, ITableAll
    {
        public efDataForm f;
        public void Dispose()
        {
            if (f != null)
            {
                f.Dispose();
                f = null;
            }
        }
        public virtual bool CheckChanges(string table) { return false; }
        public virtual void GetSearchData() { }
        public virtual void GetMasterData(int id)
        {
            if (f.dbContext == null) { f.dbContext = getDbContext(f.isSecurity); }
            f.bsMaster.DataSource = f.dbContext.Set<U>().FirstOrDefault(b => b.ID == id);
        }
        public virtual void xRefreshRecord()
        {
            try
            {
                f.dbContext.Entry<U>((U)f.bsMaster.Current).Reload();
                f.bsMaster.ResetBindings(false);
            }
            catch (Exception ex)
            {
                Alert.Show(ex.Message, Enums.AlertType.Critical);
            }
        }
        public virtual bool xRecordExist(int id) { return f.dbContext.Set<U>().Where(c => c.ID == id).FirstOrDefault() != null; }
        public virtual void xRefreshContext()
        {
            var context = ((IObjectContextAdapter)f.dbContext).ObjectContext;
            var refreshableObjects = f.dbContext.ChangeTracker.Entries().Where(c => c.State == EntityState.Modified).Select(c => c.Entity).ToList();
            context.Refresh(RefreshMode.StoreWins, refreshableObjects);
        }
        public virtual void xSave()
        {
            switch (f.xState)
            {
                case Enums.State.New:
                    f.dbContext.InsertRecord<U>((U)f.bsMaster.Current);
                    break;
                case Enums.State.Edit:
                    f.dbContext.UpdateRecord<U>((U)f.bsMaster.Current);
                    break;
                default:
                    break;
            }
        }
        public virtual void xDelete()
        {
            f.dbContext.DeleteRecord<U>((U)f.bsMaster.Current);
        }
        public virtual void xEdit()
        {
            //f.dbContext.Entry<U>((U)f.bsMaster.Current).Reload();
        }
        public virtual void showUserInfo(object p) { }
        public virtual void logFormOut(Guid guid) { }
        public virtual void logFormIn(Guid guid, string name) { }
        public virtual DbContext getDbContext(bool isSecurity)
        {
            return new SecurityEntities(App.SecurityConnectionString);
        }
        public void setPosition<T>(int id) where T : ITableAll
        {
            if (id > 0)
            {
                f.bsSearch.Position = f.bsSearch.List.IndexOf(f.bsSearch.List.OfType<T>().FirstOrDefault(c => c.ID == id));
                f.NavigationGrid.MakeRowVisible(f.NavigationGrid.FocusedRowHandle);
            }
        }
    }
}