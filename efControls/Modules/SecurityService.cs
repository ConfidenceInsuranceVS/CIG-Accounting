using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Diagnostics;
using efControls.Data;

namespace efControls
{
    public class SecurityService
    {
        private readonly static byte[] _salt = Encoding.ASCII.GetBytes("o6806642kbM7c5");
        private readonly static string sharedSecret = "Cr!pT0";
        /// <summary>
        /// Encrypt the given string using AES.  The string can be decrypted using 
        /// DecryptStringAES().  The sharedSecret parameters must match.
        /// </summary>
        /// <param name="plainText">The text to encrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for encryption.</param>
        public static string Encrypt(string plainText)
        {
            if (string.IsNullOrEmpty(plainText))
            {
                throw new ArgumentNullException("plainText");
            }
            if (string.IsNullOrEmpty(sharedSecret))
            {
                throw new ArgumentNullException("sharedSecret");
            }
            string outStr = null;
            RijndaelManaged aesAlg = null;

            try
            {
                var key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                aesAlg = new RijndaelManaged();
                aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);

                var encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (var msEncrypt = new MemoryStream())
                {
                    msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);
                    using (var csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (var swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                    }
                    outStr = Convert.ToBase64String(msEncrypt.ToArray());
                }
            }
            finally
            {
                if (aesAlg != null)
                {
                    aesAlg.Clear();
                }
            }

            return outStr;
        }
        /// <summary>
        /// Decrypt the given string.  Assumes the string was encrypted using 
        /// EncryptStringAES(), using an identical sharedSecret.
        /// </summary>
        /// <param name="cipherText">The text to decrypt.</param>
        /// <param name="sharedSecret">A password used to generate a key for decryption.</param>
        public static string Decrypt(string cipherText)
        {
            if (string.IsNullOrEmpty(cipherText))
            {
                throw new ArgumentNullException("cipherText");
            }
            if (string.IsNullOrEmpty(sharedSecret))
            {
                throw new ArgumentNullException("sharedSecret");
            }
            RijndaelManaged aesAlg = null;

            string plaintext = null;

            try
            {
                var key = new Rfc2898DeriveBytes(sharedSecret, _salt);

                var bytes = Convert.FromBase64String(cipherText);
                using (var msDecrypt = new MemoryStream(bytes))
                {
                    aesAlg = new RijndaelManaged();
                    aesAlg.Key = key.GetBytes(aesAlg.KeySize / 8);
                    aesAlg.IV = ReadByteArray(msDecrypt);
                    var decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);
                    using (var csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (var srDecrypt = new StreamReader(csDecrypt))
                        {
                            plaintext = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            finally
            {
                if (aesAlg != null)
                {
                    aesAlg.Clear();
                }
            }

            return plaintext;
        }
        private static byte[] ReadByteArray(Stream s)
        {
            var rawLength = new byte[sizeof(int)];
            if (s.Read(rawLength, 0, rawLength.Length) != rawLength.Length)
            {
                throw new SystemException("Stream did not contain properly formatted byte array");
            }

            var buffer = new byte[BitConverter.ToInt32(rawLength, 0)];
            if (s.Read(buffer, 0, buffer.Length) != buffer.Length)
            {
                throw new SystemException("Did not read byte array properly");
            }

            return buffer;
        }
        public static bool checkPassword(string dbPass, string uiPass)
        {
            //Debug.WriteLine(Encryptmd5(uiPass));
            return Encryptmd5(uiPass) == dbPass;
        }
        public static string Encryptmd5(string pWord)
        {
            var bytes = Encoding.UTF8.GetBytes(pWord);
            MD5 md = MD5.Create();

            return BitConverter.ToString(md.ComputeHash(bytes)).Replace("-", "");
        }
        public static bool checkComplexity(string p)
        {
            return p.Length >= 8 && p.Count(c => char.IsDigit(c)) >= 1 && p.Count(c => char.IsSymbol(c)) >= 1;
        }
        public static List<DepartmentsSearchList> listDepartments()
        {
            using (var se = new SecurityEntities(App.SecurityConnectionString))
            {
                var dep = se.Departments
                      .ToList()
                      .GroupJoin(se.Users, Department => Department.CreatedByID ?? 0, user => user.ID, (x, y) => new { Department = x, cUser = y })
                      .SelectMany(xy => xy.cUser.DefaultIfEmpty(), (x, y) => new { Department = x.Department, cUser = y })
                      .GroupJoin(se.Users, Department => Department.Department.ModifiedByID ?? 0, user => user.ID, (x, y) => new { Department = x, mUser = y })
                      .SelectMany(xy => xy.mUser.DefaultIfEmpty(), (x, y) => new { Department = x.Department, mUser = y })
                      .Select(s => new DepartmentsSearchList()
                      {
                          Department = s.Department.Department,
                          ID = s.Department.Department.ID,
                          Description = s.Department.Department.Description,
                          Notes=s.Department.Department.Notes,
                          CreatedBy = s.Department.cUser == null ? string.Empty : string.Format("{0} {1}", s.Department.cUser.Code, s.Department.Department.Creationdate),
                          ModifiedBy = s.mUser == null ? string.Empty : string.Format("{0} {1}", s.mUser.Code, s.Department.Department.Modificationdate)
                      })
                      .OrderBy(s => s.Description)
                      .ToList();

                return dep;
            }
        }
      // public static List<UsersSearchList> listUsers()// added by Samir 1/12 stopped by samir 20/12/2016
            public static List<UsersSearchList> listUsers()//SecurityEntities ae) // added 20/12/2016
        {
            using (var se = new SecurityEntities(App.SecurityConnectionString))
            {
                var usr = se.Users
                      .ToList()
                      .GroupJoin(se.Users, User => User.CreatedByID ?? 0, user => user.ID, (x, y) => new { User = x, cUser = y })
                      .SelectMany(xy => xy.cUser.DefaultIfEmpty(), (x, y) => new { User = x.User, cUser = y })
                      .GroupJoin(se.Users, User => User.User.ModifiedByID ?? 0, user => user.ID, (x, y) => new { User = x, mUser = y })
                      .SelectMany(xy => xy.mUser.DefaultIfEmpty(), (x, y) => new { User = x.User, mUser = y })
                      .Select(s => new UsersSearchList()
                      {
                          User = s.User.User,
                          ID = s.User.User.ID,
                          Name = s.User.User.Name,
                          Password = s.User.User.Password,
                          LevelId = s.User.User.LevelID,
                          CreatedBy = s.User.cUser == null ? string.Empty : string.Format("{0} {1}", s.User.cUser.Code, s.User.User.Creationdate),
                          ModifiedBy = s.mUser == null ? string.Empty : string.Format("{0} {1}", s.mUser.Code, s.User.User.Modificationdate)
                      })
                      .OrderBy(s => s.Name)
                      .ToList();

                return usr;
            }
        }

        public static List<GroupsSearchList> listGroups()//added by Samir 1/12
        {
            using (var se = new SecurityEntities(App.SecurityConnectionString))
            {
                var grp = se.Groups
                      .ToList()
                      .GroupJoin(se.Users, Group => Group.CreatedByID ?? 0, user => user.ID, (x, y) => new { Group = x, cUser = y })
                      .SelectMany(xy => xy.cUser.DefaultIfEmpty(), (x, y) => new { Group = x.Group, cUser = y })
                      .GroupJoin(se.Users, Group => Group.Group.ModifiedByID ?? 0, user => user.ID, (x, y) => new { Group = x, mUser = y })
                      .SelectMany(xy => xy.mUser.DefaultIfEmpty(), (x, y) => new { Group = x.Group, mUser = y })
                      .Select(s => new GroupsSearchList()
                      {
                          Group = s.Group.Group,
                          ID = s.Group.Group.ID,
                          Description = s.Group.Group.Description,
                        
                          CreatedBy = s.Group.cUser == null ? string.Empty : string.Format("{0} {1}", s.Group.cUser.Code, s.Group.Group.Creationdate),
                          ModifiedBy = s.mUser == null ? string.Empty : string.Format("{0} {1}", s.mUser.Code, s.Group.Group.Modificationdate)
                      })
                      .OrderBy(s => s.Description)
                      .ToList();

                return grp;
            }
        }

        //public static List<UserRolesSearchList> listUserRoles()//added by Samir 1/12
        //{
        //    using (var se = new SecurityEntities(App.SecurityConnectionString))
        //    {
        //        //var usr = se.Users
        //        //     .ToList()
        //        //     .GroupJoin(se.Users, User => User.CreatedByID ?? 0, user => user.ID, (x, y) => new { User = x, cUser = y })
        //        //     .SelectMany(xy => xy.cUser.DefaultIfEmpty(), (x, y) => new { User = x.User, cUser = y })
        //        //     .GroupJoin(se.Users, User => User.User.ModifiedByID ?? 0, user => user.ID, (x, y) => new { User = x, mUser = y })
        //        //     .SelectMany(xy => xy.mUser.DefaultIfEmpty(), (x, y) => new { User = x.User, mUser = y })
        //        //     .Select(s => new UserRolesSearchList()
        //        //     {
        //        //         User = s.User.User,
        //        //         ID = s.User.User.ID,
        //        //         Name = s.User.User.Name,
        //        //         Password = s.User.User.Password,
        //        //         LevelId = s.User.User.LevelID,
        //        //         CreatedBy = s.User.cUser == null ? string.Empty : string.Format("{0} {1}", s.User.cUser.Code, s.User.User.Creationdate),
        //        //         ModifiedBy = s.mUser == null ? string.Empty : string.Format("{0} {1}", s.mUser.Code, s.User.User.Modificationdate)
        //        //     })
        //        //     .OrderBy(s => s.Name)
        //        //     .ToList();

        //        //return usr;
        //    }
        //}


    }
}
