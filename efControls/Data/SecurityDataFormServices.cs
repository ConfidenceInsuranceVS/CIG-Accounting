using efControls.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace efControls
{
    public static class SecurityDataFormServices
    {
        public static bool CheckChanges<U>(efDataForm f, string table) where U : class,ITableAll
        {
            return false;
        }
    }
    public class SecurityDataFormServices<U> : efFormExtensions<U>
        where U : class, ITableAll, ITableSome
    {
        public override bool CheckChanges(string table) { return SecurityDataFormServices.CheckChanges<U>(f, table); }
        public override DbContext getDbContext(bool isSecurity)
        {
            return new SecurityEntities(App.SecurityConnectionString);
        }
    }
}
