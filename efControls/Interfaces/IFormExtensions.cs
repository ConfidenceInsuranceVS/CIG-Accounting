using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace efControls
{
    public interface IFormExtensions
    {
        void GetMasterData(int id);
        bool CheckChanges(string table);
        void showUserInfo(object p);
        DbContext getDbContext(bool isSecurity);
        void GetSearchData();
        void xRefreshRecord();
        bool xRecordExist(int id);
        void xRefreshContext();
        void xSave();
        void xDelete();
        void xEdit();
        void logFormOut(Guid guid);
        void logFormIn(Guid guid, string name);
        void setPosition<T>(int id) where T : ITableAll;
    }
}
