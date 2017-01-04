using System;
using System.Data.OleDb;
using System.Linq;

namespace efControls
{
    public class VfpConnection
    {
        public static OleDbConnection dbcConnection(string path, string target)
        {
            var connectionString = string.Format(@"Provider=VFPOLEDB.1;Exclusive=NO;Data Source={0}\{1}.dbc", path, target);
            var oc = new OleDbConnection(connectionString);
            return oc;
        }
        public static OleDbConnection dbfConnection(string path, string target)
        {
            var connectionString = string.Format(@"Provider=VFPOLEDB.1;Exclusive=NO;Data Source={0}\{1}.dbf", path, target);
            var oc = new OleDbConnection(connectionString);
            return oc;
        }
        public static OleDbConnection dbfConnection()
        {
            var connectionString = string.Format(@"Provider=VFPOLEDB.1;Exclusive=NO;Data Source=c:\");
            var oc = new OleDbConnection(connectionString);
            return oc;
        }
    }
}
