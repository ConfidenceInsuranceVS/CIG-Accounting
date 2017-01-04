using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;

namespace Accounting
{
    public partial class AccountingEntities
    {
        public AccountingEntities(String connectionString) : base(connectionString)
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 180;
        }
    }
}
