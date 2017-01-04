using efControls;
using efControls.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public static class DataFormServices
    {
        public static bool CheckChanges<U>(efDataForm f, string table) where U : class,ITableAll
        {
            return false;
        }
        public static List<User> fillUsers()
        {
            using (SecurityEntities se = new SecurityEntities(App.SecurityConnectionString))
            {
                return se.Users.OrderBy(c => c.Name).ToList();
            }
        }
        public static string getCurrencyName(int cID)
        {
            string result = string.Empty;
            using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
            {
                result = ae.Currencies.FirstOrDefault(c => c.ID == cID).Description;
            }
            return result;
        }

        public static string getCurrencyName(string cur)
        {
            string result = string.Empty;
            if (!string.IsNullOrEmpty(cur))
                using (AccountingEntities ae = new AccountingEntities(App.MainConnectionString))
                {
                    result = ae.Currencies.FirstOrDefault(c => c.Code == cur).Description;
                }
            return result;
        }

        //public static string GetUserInfo<U>(Enums.UserInfo eType, U rec) where U : class, ITableSome
        //{
        //    var result = string.Empty;
        //    try
        //    {
        //        using (SecurityEntities se = new SecurityEntities(App.SecurityConnectionString))
        //        {
        //            var user = se.Users
        //                .Select(c => new { c.ID, c.Name })
        //                .FirstOrDefault(u => u.ID == (eType == Enums.UserInfo.Created ? rec.CreatedByID : rec.ModifiedByID))
        //                .Name;
        //            result = string.Format("{0} - {1}", user, eType == Enums.UserInfo.Created ? rec.Creationdate : rec.Modificationdate);
        //        }
        //    }
        //    catch (Exception)
        //    {
        //    }
        //    return result;
        //}
    }

}
