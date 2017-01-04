using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.EntityClient;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace efControls
{
    public class App
    {
        public static Guid guid { get; set; }
        public static efMainForm xFrm { get; set; }
        public static int UserID { get; set; }
        public static int UserGroupID { get; set; }
        public static int AdminGroupID { get; set; }
        public static string UserCode { get; set; }
        public static string UserName { get; set; }
        public static int UserLevel { get; set; }
        public static string Name { get; set; }
        public static string UserPath { get; set; }
        public static string AllUsersPath { get; set; }
        public static string PreferencesFile { get; set; }
        public static string LocalPreferencesFile { get; set; }
        public static string ParametersFile { get; set; }
        public static string CompanyCode { get; set; }
        public static string CompanyName { get; set; }
        public static string SecurityConnectionString { get; set; }
        public static string MainConnectionString { get; set; }
        public static string SecurityModel { get; set; }
        public static string ApplicationModel { get; set; }
        public static bool PrintSubtitle { get; set; }
        public static bool ShowUserInfo { get; set; }
        public static string getSecurityConnectionString()
        {
            string result = string.Empty;
            try
            {
                EntityConnectionStringBuilder entityString = new EntityConnectionStringBuilder() { Provider = "System.Data.SqlClient" };
                SqlConnectionStringBuilder cn = new SqlConnectionStringBuilder()
                {
                    DataSource = XML.Read(App.PreferencesFile, "General", "DataSource"),
                    UserID = SecurityService.Decrypt(XML.Read(App.PreferencesFile, "General", "UserName")),
                    Password = SecurityService.Decrypt(XML.Read(App.PreferencesFile, "General", "UserPassword")),
                    InitialCatalog = XML.Read(App.PreferencesFile, "General", "SecurityCatalog")
                };

                SecurityModel = "Data.SecurityModel";

                entityString.Metadata = string.Format("res://*/{0}.csdl|res://*/{0}.ssdl|res://*/{0}.msl", SecurityModel);
                entityString.ProviderConnectionString = cn.ConnectionString;
                result = entityString.ConnectionString;
            }
            catch (Exception)
            {
                result = string.Empty;
            }

            return result;
        }
        public static string getMainConnectionString(string dbName)
        {
            var result = string.Empty;
            string[] sd = dbName.Split('.');
            try
            {
                EntityConnectionStringBuilder entityString = new EntityConnectionStringBuilder() { Provider = "System.Data.SqlClient" };
                SqlConnectionStringBuilder cn = new SqlConnectionStringBuilder()
                {
                    DataSource = XML.Read(App.PreferencesFile, "General", "DataSource"),
                    UserID = SecurityService.Decrypt(XML.Read(App.PreferencesFile, "General", "UserName")),
                    Password = SecurityService.Decrypt(XML.Read(App.PreferencesFile, "General", "UserPassword")),
                    InitialCatalog = dbName
                };

                ApplicationModel = string.Format("{0}Model", sd[0]);

                entityString.Metadata = string.Format("res://*/{0}.csdl|res://*/{0}.ssdl|res://*/{0}.msl",  ApplicationModel);
                entityString.ProviderConnectionString = cn.ConnectionString;
                    result = entityString.ConnectionString;
            }
            catch (Exception)
            {
                result = string.Empty; 
            }

            return result;
        }
        public static void setPaths()
        {
            UserPath = string.Format(@"{0}\CIG\{1}", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), Name);
            if (!Directory.Exists(UserPath)) { Directory.CreateDirectory(UserPath); }
        }
        //public static void setPreferencesFile()
        //{
        //    PreferencesFile = UserPath + "\\Preferences.XML";
        //    if (!File.Exists(PreferencesFile)) { XML.Write(PreferencesFile, "General", "CompanyName", CompanyName); }
        //    //
        //    AllUsersPath = XML.Read(PreferencesFile, "General", "AllUsersPath");
        //    if (string.IsNullOrEmpty(AllUsersPath))
        //    {
        //        var fbd = new FolderBrowserDialog() { RootFolder = Environment.SpecialFolder.MyComputer, Description = "Select All Users Path Folder" };
        //        fbd.ShowDialog();
        //        AllUsersPath = string.Format(@"{0}\{1}", fbd.SelectedPath, Name);
        //        if (!Directory.Exists(AllUsersPath)) { Directory.CreateDirectory(AllUsersPath); }
        //        XML.Write(PreferencesFile, "General", "AllUsersPath", AllUsersPath);
        //    }
        //    //
        //    var LockPath = XML.Read(App.PreferencesFile, "General", "LockPath");
        //    if (string.IsNullOrEmpty(LockPath))
        //    {
        //        LockPath = string.Format(@"{0}Lock", AllUsersPath);
        //        if (!Directory.Exists(LockPath)) { Directory.CreateDirectory(LockPath); }
        //        XML.Write(App.PreferencesFile, "General", "LockPath", LockPath);
        //    }
        //    //
        //    ParametersFile = AllUsersPath + "\\Parameters.XML";
        //    if (!File.Exists(ParametersFile)) { XML.Write(PreferencesFile, "General", "AllUsersParams", ParametersFile); }
        //}
        public static void setPreferencesFile()
        {
            LocalPreferencesFile =  string.Format("{0}\\Preferences.XML", UserPath);
            //
            AllUsersPath = XML.Read(LocalPreferencesFile, "General", "AllUsersPath");
            if (string.IsNullOrEmpty(AllUsersPath))
            {
                var fbd = new FolderBrowserDialog() { RootFolder = Environment.SpecialFolder.MyComputer, Description = "Select All Users Path Folder" };
                fbd.ShowDialog();
                AllUsersPath = string.Format(@"{0}\{1}", fbd.SelectedPath, Name);
                if (!Directory.Exists(AllUsersPath)) { Directory.CreateDirectory(AllUsersPath); }
                XML.Write(LocalPreferencesFile, "General", "AllUsersPath", AllUsersPath);
                AllUsersPath = XML.Read(LocalPreferencesFile, "General", "AllUsersPath");
            }
            //

            PreferencesFile = string.Format("{0}\\Preferences.XML", AllUsersPath);
            if (!File.Exists(PreferencesFile))
            {
                XML.Write(PreferencesFile, "General", "CompanyName", CompanyName); 
                XML.Write(PreferencesFile, "Defaults", "Style", "Office 2016 Colorful");
                XML.Write(PreferencesFile, "Defaults", "Font", "Tahoma");
                XML.Write(PreferencesFile, "Defaults", "FontSize", "8");
                XML.Write(PreferencesFile, "Defaults", "FontStyle", "false");
                XML.Write(PreferencesFile, "Defaults", "BackColorRed", "-2365967");
                XML.Write(PreferencesFile, "Defaults", "ForeColorRed", "-14401439");
                XML.Write(PreferencesFile, "Defaults", "BorderColorRed", "-1872887");
            }

            var LockPath = XML.Read(App.PreferencesFile, "General", "LockPath");
            if (string.IsNullOrEmpty(LockPath))
            {
                LockPath = string.Format(@"{0}\Lock", AllUsersPath);
                if (!Directory.Exists(LockPath)) { Directory.CreateDirectory(LockPath); }
                XML.Write(App.PreferencesFile, "General", "LockPath", LockPath);
            }
        }


        #region Application Visual Styles
        public static StyleController styleController { get; set; }
        public static Font font { get; set; }
        public static int fontsize { get; set; }
        public static bool fontstyle { get; set; }
        public static Color controlBackcolor { get; set; }
        public static Color controlForecolor { get; set; }
        public static Color controlBordercolor { get; set; }

        public static int screenHeight { get; set; }
        public static int screenWidth { get; set; }
        public static void setVisualStyles()
        {
            font = App.getFonts();

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.Skins.SkinManager.EnableMdiFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            DevExpress.Utils.AppearanceObject.DefaultFont = font;
            if (!string.IsNullOrEmpty(App.UserCode))
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(XML.Read(PreferencesFile, "Users", App.UserCode, "Style"));
            else
                DevExpress.LookAndFeel.UserLookAndFeel.Default.SetSkinStyle(XML.Read(PreferencesFile, "Defaults", "Style"));

            styleController = new StyleController();
            styleController.LookAndFeel.UseDefaultLookAndFeel = true;
            styleController.ButtonsStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            //styleController.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat;
            //
            styleController.Appearance.BorderColor = Color.Transparent;
            //
            //styleController.AppearanceDisabled.Font = font;
            styleController.AppearanceDisabled.BackColor = Color.LightGray;
            styleController.AppearanceDisabled.ForeColor = Color.DimGray;
            styleController.AppearanceDisabled.BorderColor = Color.Transparent;
            //
            styleController.AppearanceReadOnly.BackColor = Color.FloralWhite;
            styleController.AppearanceReadOnly.ForeColor = Color.Gray;
            styleController.AppearanceReadOnly.BorderColor = Color.Transparent;
            //
            styleController.AppearanceFocused.BackColor = getControlColor("Back");
            styleController.AppearanceFocused.ForeColor = getControlColor("Fore");
            styleController.AppearanceFocused.BorderColor = getControlColor("Border");

        }
        public static Font getFonts()
        {
            string fontName;
            int fontSize;
            FontStyle fontStyle;

            try
            {
                if (!string.IsNullOrEmpty(App.UserCode))
                {
                    fontName = XML.Read(PreferencesFile, "Users", App.UserCode, "Font");
                    fontSize = int.Parse(XML.Read(PreferencesFile, "Users", App.UserCode, "FontSize"));
                    fontStyle = bool.Parse(XML.Read(PreferencesFile, "Users", App.UserCode, "FontStyle")) == true ? FontStyle.Bold : FontStyle.Regular;
                }
                else
                {
                    fontName = XML.Read(PreferencesFile, "Defaults", "Font");
                    fontSize = int.Parse(XML.Read(PreferencesFile, "Defaults", "FontSize"));
                    fontStyle = bool.Parse(XML.Read(PreferencesFile, "Defaults", "FontStyle")) == true ? FontStyle.Bold : FontStyle.Regular;
                }
            }
            catch (Exception)
            {
                fontName = "Tahoma";
                fontSize = 8;
                fontStyle = FontStyle.Regular;
            }
            return new Font(fontName, fontSize, fontStyle);
        }
        public static Color getControlColor(string flag)
        {
            Color color;
            try
            {
                if (!string.IsNullOrEmpty(App.UserCode))
                    color = Color.FromArgb(int.Parse(XML.Read(PreferencesFile, "Users", App.UserCode, string.Format("{0}ColorRed", flag))));
                else
                    color = Color.FromArgb(int.Parse(XML.Read(PreferencesFile, "Defaults", string.Format("{0}ColorRed", flag))));
            }
            catch (Exception)
            {
                color = SystemColors.ActiveBorder;
            }
            return color;
        }
        #endregion
        public static Guid Int2Guid(int value)
        {
            byte[] bytes = new byte[16];
            BitConverter.GetBytes(value).CopyTo(bytes, 0);
            return new Guid(bytes);
        }

        public static int Guid2Int(Guid value)
        {
            byte[] b = value.ToByteArray();
            int bint = BitConverter.ToInt32(b, 0);
            return bint;
        }

    }
}
