using System;
using System.Linq;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;

namespace efControls.Data   
{
    public partial class SecurityEntities
    {
        public SecurityEntities(String connectionString) : base(connectionString)
        {
            ((IObjectContextAdapter)this).ObjectContext.CommandTimeout = 180;
        }
    }
}
