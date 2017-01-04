using efControls;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace Accounting
{
    public class App : efControls.App
    {
        public static int LocalCurreny { get; set; }
        public static int ForeignCurreny { get; set; }
        public static string JVDocuments { get; set; }
        public static int WorkingYear { get; set; }
        public static int CompanyID { get; set; }
        public static bool HasSubCompanies { get; set; }
        public static int AccLength { get; set; }
        public static void setAppParameters()
        {
            XML.Write(App.ParametersFile, "General", "Name", "C.I.G");
            XML.Write(App.ParametersFile, "General", "Header", "C.I.G");
            XML.Write(App.ParametersFile, "General", "HeaderCIG", "C.I.G. Confidence Insurance Group s.a.l");
        }

        //public static string getJVDocumentsPath()
        //{
        //    var path = string.Format("{0}\\Documents\\{1}\\{2}", App.AllUsersPath, App.CompanyID, App.WorkingYear);
        //    if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }
        //    return path;
        //}
        public static string getConnectionString(string dbName)
        {
            SqlConnectionStringBuilder cn = new SqlConnectionStringBuilder()
            {
                DataSource = XML.Read(App.PreferencesFile, "General", "DataSource"),
                UserID = SecurityService.Decrypt(XML.Read(App.PreferencesFile, "General", "UserName")),
                Password = SecurityService.Decrypt(XML.Read(App.PreferencesFile, "General", "UserPassword")),
                InitialCatalog = dbName
            };
            return cn.ConnectionString;
        }

    }
}
