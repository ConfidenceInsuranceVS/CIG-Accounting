using efControls;
using efControls.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Accounting
{
    public static class SecurityServices
    {
        public static bool userCodeUsed(int id)
        {
            var result = false;
            var se = new AccountingEntities(App.MainConnectionString);
            try
            {
                if (userExists<Bank>(id)) { throw new Exception(); }
                if (userExists<Cashdistribution>(id)) { throw new Exception(); }
                if (userExists<Chartofaccount>(id)) { throw new Exception(); }
                if (userExists<Costcenter>(id)) { throw new Exception(); }
                if (userExists<Currency>(id)) { throw new Exception(); }
                if (userExists<description>(id)) { throw new Exception(); }
                if (userExists<Sector>(id)) { throw new Exception(); }
                if (userExists<Vouchertype>(id)) { throw new Exception(); }
                if (userExists<Journalparent>(id)) { throw new Exception(); }
            }
            catch (Exception)
            {
                result = true;
            }
            return result;
        }
        private static bool userExists<U>(int id) where U:class, ITableSome
        {
            var result = false;
            try
            {
                using (var se = new AccountingEntities(App.MainConnectionString))
                {
                    if (se.Set<U>().FirstOrDefault(c => c.CreatedByID == id) != null)
                        throw new Exception();
                    if (se.Set<U>().FirstOrDefault(c => c.ModifiedByID == id) != null)
                        throw new Exception();
                }
            }
            catch (Exception)
            {
                result = true;
            }
            return result;
        }

       
    }
}
