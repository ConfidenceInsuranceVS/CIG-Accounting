using efControls;
using System;
using System.Linq;

namespace Accounting
{
    public static class LoggerService
    {
        public static void logFormIn(Guid guid, string name)
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
        public static void logFormOut(Guid guid)
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
