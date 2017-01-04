using efControls;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;

namespace Accounting
{
    public class VfpConnection
    {
        public static OleDbConnection dbcConnection(string path, string target)
        {
            return new OleDbConnection(string.Format(@"Provider=VFPOLEDB.1;Exclusive=NO;Data Source={0}\{1}.dbc", path, target));
        }
        public static OleDbConnection dbfConnection(string table)
        {
            var path = XML.Read(App.PreferencesFile, "General", "VfpPath");
            return new OleDbConnection(string.Format(@"Provider=VFPOLEDB.1;Exclusive=NO;Data Source={0}\{1}.dbf", path, table));
        }
        public static OleDbConnection dbfConnection()
        {
            return new OleDbConnection(@"Provider=VFPOLEDB.1;Exclusive=NO;Data Source=c:\");
        }
    }
}
