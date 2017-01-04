using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace efControls
{
    public class Lock
    {
        public static string LockPath { get; set; }
        public static FileStream RecordLock(string formName, int id)
        {
            FileStream fs = null;
            string filename = LockFileName(formName, id);
            string user = string.Empty;
            try
            {
                string justFilename = (Path.GetFileName(filename)).Substring(0, 35);
                string[] fileNames = Directory.GetFiles(Path.GetDirectoryName(filename));
                var files = fileNames.Where(f => Path.GetFileName(f).StartsWith(justFilename));
                if (files != null)
                    foreach (var file in files)
                    {
                        user = Path.GetExtension(file).Substring(1);
                        File.Delete(file);
                    }

                fs = File.Create(filename, 1, FileOptions.DeleteOnClose);
            }
            catch (Exception)
            {
                throw new RlockException(user);
            }
            return fs;
        }
        private static string LockFileName(string formName, int id)
        {
            Guid result;
            var lockfile = string.Format(@"{0}{1}", formName, id);
            using (var md5 = MD5.Create())
            {
                var hash = md5.ComputeHash(Encoding.Default.GetBytes(lockfile));
                result = new Guid(hash);
            }
            return string.Format(@"{0}\{1}.{2}", XML.Read(App.PreferencesFile, "General", "LockPath"), result, App.UserName);
        }
        public static void DeleteTempFiles(string ext)
        {
            LockPath = XML.Read(App.PreferencesFile, "General", "LockPath");
            if (string.IsNullOrEmpty(LockPath))
            {
                LockPath = string.Format(@"{0}\Lock", App.AllUsersPath);
                XML.Write(App.PreferencesFile, "General", "LockPath", LockPath);
            }
            if (!Directory.Exists(LockPath))
            {
                Directory.CreateDirectory(LockPath);
            }
            var fileList = Directory.GetFiles(XML.Read(App.PreferencesFile, "General", "LockPath"), "*." + ext);
            foreach (string f in fileList)
            {
                try
                {
                    File.Delete(f);
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
    }
}
