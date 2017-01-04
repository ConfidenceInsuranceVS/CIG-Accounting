using efControls;
using System;
using System.Collections.Generic;
using System.Linq;
using efControls.Data;
using System.IO;

namespace Accounting
{
    public static class AccountingServices
    {
        public static DateTime getMaxDate(int wYear)
        {
            DateTime mDate;
            using(var ae = new AccountingEntities(App.MainConnectionString))
            {
                mDate = (DateTime)ae.Journalparents.Where(c => c.YDate == wYear).Max(c => c.Jvdate);
            }
            return mDate;
        }

        #region getMaxReference
        public static int getMaxReference(AccountingEntities ae, int workingYear, int vID)
        {
            return ae.Journalparents
                .Where(c => c.Vouchertypeid == vID & c.YDate == workingYear)
                .Max(c => c.Reference) ?? 0;
        }
        public static int getMaxReference(AccountingEntities ae, int workingYear, int vID, int scID)
        {
            return ae.Journalparents
                .Where(c => c.Vouchertypeid == vID & c.YDate == workingYear & c.SC == scID)
                .Max(c => c.Reference) ?? 0;
        }
        #endregion

        #region getVoucherTypes
        public static List<ucVoucherTypes> getVoucherTypes()
        {
            List<ucVoucherTypes> lst = null;
            using (var ae = new AccountingEntities(App.MainConnectionString))
            {
                lst = getVoucherTypesList(ae);
            }
            return lst;
        }
        public static List<ucVoucherTypes> getVoucherTypes(AccountingEntities ae)
        {
            return getVoucherTypesList(ae);
        }
        private static List<ucVoucherTypes> getVoucherTypesList(AccountingEntities ae)
        {
            return ae.Vouchertypes
                    .AsEnumerable()
                    .Select(c => new ucVoucherTypes
                    {
                        ID = c.ID,
                        Code = c.Code,
                        Description = c.Description
                    })
                    .OrderBy(c => c.Code).ToList();
        }
        #endregion

        #region getCurrencies
        public static List<ucCurrencies> getCurrencies()
        {
            List<ucCurrencies> lst = null;
            using (var ae = new AccountingEntities(App.MainConnectionString))
            {
                lst = getCurrenciesList(ae);
            }
            return lst;
        }
        public static List<ucCurrencies> getCurrencies(AccountingEntities ae)
        {
            return getCurrenciesList(ae);
        }
        private static List<ucCurrencies> getCurrenciesList(AccountingEntities ae)
        {
            return ae.Currencies
                    .AsEnumerable()
                    .Select(c => new ucCurrencies
                    {
                        ID = c.ID,
                        Code = c.Code,
                        Description = c.Description
                    })
                    .OrderBy(c => c.OrderID)
                    .ThenBy(c => c.Description)
                    .ToList();
        }
        #endregion

        #region getAccounts
        public static List<ucAccounts> getAccounts(string sw, string f)
        {
            List<ucAccounts> lst = null;
            using (var ae = new AccountingEntities(App.MainConnectionString))
            {
                lst = getAccountsList(ae, sw, f);
            }
            return lst;
        }
        public static List<ucAccounts> getAccounts(AccountingEntities ae, string sw, string f)
        {
            return getAccountsList(ae, sw, f);
        }
        private static List<ucAccounts> getAccountsList(AccountingEntities ae, string sw, string f)
        {
            return ae.Chartofaccounts
                    .Where(c => c.isParent == false)
                    .Where(c => f == null ? true : c.AccountStatu.Code == f)
                    .Where(c => sw == null ? true : c.Code.StartsWith(sw))
                    .AsEnumerable()
                    .Select(c => new ucAccounts
                    {
                        ID = c.ID,
                        Code = c.Code,
                        Description = c.Description,
                        CodeDescription = string.Format("{0}\t{1}", c.Code, c.Description)
                    })
                    .OrderBy(c => c.Code).ToList();
        }
        #endregion

        #region getChartOfAccount
        public static List<Chartofaccount> getChartOfAccount() // added by samir 28/11
        {
            List<Chartofaccount> lst = null;
            using (var ae = new AccountingEntities(App.MainConnectionString))
            {
                lst = ae.Chartofaccounts.ToList();
            }
            return lst;
        }
        #endregion

        #region getSectors
        public static List<Sector> getSectors() // added by samir 28/11
        {
            List<Sector> lst = null;
            using (var ae = new AccountingEntities(App.MainConnectionString))
            {
                lst = ae.Sectors.ToList();
            }
            return lst;
        }
        #endregion

        #region getAccountType
        public static List<AccountType> getAccountType() // added by samir 28/11
        {
            List<AccountType> lst = null;
            using (var ae = new AccountingEntities(App.MainConnectionString))
            {
                lst = ae.AccountTypes.ToList();
            }
            return lst;
        }
        #endregion
          
        #region getBanks
        public static List<ucBanks> getBanks()
        {
            List<ucBanks> lst = null;
            using (var ae = new AccountingEntities(App.MainConnectionString))
            {
                lst = getBanksList(ae);
            }
            return lst;
        }
        public static List<ucBanks> getBanks(AccountingEntities ae)
        {
            return getBanksList(ae);
        }
        private static List<ucBanks> getBanksList(AccountingEntities ae)
        {
            return ae.Banks
                    .AsEnumerable()
                    .Select(c => new ucBanks
                    {
                        ID = c.ID,
                        Code = c.Code,
                        Description = c.Description,
                        CodeDescription = string.Format("{0}\t{1}", c.Code, c.Description)
                    })
                    .OrderBy(c => c.Code).ToList();
        }
        #endregion

        public static List<SubCompany> getSubCompanies()
        {
            List<SubCompany> lst = null;
            using (var se = new SecurityEntities(App.SecurityConnectionString))
            {
                lst = se.SubCompanies.OrderBy(c => c.Code).ToList();
            }
            return lst;
        }
        public static int getDefaultSubCompanyID()
        {
            int id = -1;
            try
            {
                using (var se = new SecurityEntities(App.SecurityConnectionString))
                {
                    id = se.SubCompanies.FirstOrDefault(c => c.CompanyID == App.CompanyID && c.isDefault == true).ID;
                }
            }
            catch (Exception)
            {
                id = -1;
            }
            return id;
        }
        public static int getDefaultSubCompanyID(string code)
        {
            int id = -1;
            try
            {
                using (var se = new SecurityEntities(App.SecurityConnectionString))
                {
                    id = se.SubCompanies.FirstOrDefault(c => c.CompanyID == App.CompanyID && c.Code == code).ID;
                }
            }
            catch (Exception)
            {
                id = -1;
            }
            return id;
        }
        public static string getDefaultSubCompanyCode()
        {
            string code = string.Empty;
            try
            {
                using (var se = new SecurityEntities(App.SecurityConnectionString))
                {
                    code = se.SubCompanies.FirstOrDefault(c => c.CompanyID == App.CompanyID && c.isDefault == true).Code;
                }
            }
            catch (Exception)
            {
                code = string.Empty;
            }
            return code;
        }
        public static string getSubCompanyCode(int id)
        {
            string code = string.Empty;
            try
            {
                using (var se = new SecurityEntities(App.SecurityConnectionString))
                {
                    code = se.SubCompanies.FirstOrDefault(c => c.CompanyID == App.CompanyID && c.ID == id).Code;
                }
            }
            catch (Exception)
            {
                code = string.Empty;
            }
            return code;
        }
        //
        public static int getDefaultVoucherTypeID(string defaultType)
        {
            int id = -1;
            try
            {
                using (var ae = new AccountingEntities(App.MainConnectionString))
                {
                    id = ae.Vouchertypes.FirstOrDefault(c => c.Code == defaultType).ID;
                }
            }
            catch (Exception)
            {
                id = -1;
            }
            return id;
        }
        public static string getfileName(int id)
        {
            string fileName = string.Empty;
            var path = string.Format("{0}\\Documents\\{1}\\{2}", App.AllUsersPath, App.CompanyID, App.WorkingYear);
            if (!Directory.Exists(path)) { Directory.CreateDirectory(path); }

            fileName = string.Format("{0}\\{1}.PDF", path, App.Int2Guid(id));
            return fileName;
        }

        #region Search Lists
        public static List<JournalSearchList> listJVs(AccountingEntities ae, int year, string jvType)
        {
            using (var se = new SecurityEntities(App.SecurityConnectionString))
            {
                var alljvs = ae.Journalparents
                    .Where(p => p.YDate == 2016)
                    .Where(string.Format("Vouchertype.{0} == true", jvType))
                    .ToList()
                    .GroupJoin(se.SubCompanies, jp => jp.SC, co => co.ID, (x, y) => new { jp = x, co = y })
                    .SelectMany(xy => xy.co.DefaultIfEmpty(), (x, y) => new { jp = x.jp, co = y })
                    .GroupJoin(se.Users, jp => jp.jp.CreatedByID, user => user.ID, (x, y) => new { jp = x, cUser = y })
                    .SelectMany(xy => xy.cUser.DefaultIfEmpty(), (x, y) => new { jp = x.jp, cUser = y })
                    .GroupJoin(se.Users, jp => jp.jp.jp.ModifiedByID, user => user.ID, (x, y) => new { jp = x, mUser = y })
                    .SelectMany(xy => xy.mUser.DefaultIfEmpty(), (x, y) => new { jp = x.jp, mUser = y })
                    .Select(s => new JournalSearchList()
                    {
                        JV = s.jp.jp.jp,
                        ID = s.jp.jp.jp.ID,
                        JvType = s.jp.jp.jp.Vouchertype.Code,
                        Reference = s.jp.jp.jp.Reference,
                        SC = s.jp.jp.co.Code,
                        CreatedBy = s.jp.cUser == null ? string.Empty : string.Format("{0} {1}", s.jp.cUser.Code, s.jp.jp.jp.Creationdate),
                        ModifiedBy = s.mUser == null ? string.Empty : string.Format("{0} {1}", s.mUser.Code, s.jp.jp.jp.Modificationdate),
                        IsPosted = s.jp.jp.jp.Isposted
                    })
                    .OrderBy(s => s.JvType)
                    .ThenBy(s => s.Reference)
                    .ThenBy(s => s.SC)
                    .ToList();

                return alljvs;
            }
        }
        public static List<ChartSearchList> listCharts(AccountingEntities ae)
        {
            using (var se = new SecurityEntities(App.SecurityConnectionString))
            {
                var charts = ae.Chartofaccounts
                      .ToList()
                      .GroupJoin(se.Users, Chart => Chart.CreatedByID ?? 0, user => user.ID, (x, y) => new { Chart = x, cUser = y })
                      .SelectMany(xy => xy.cUser.DefaultIfEmpty(), (x, y) => new { Chart = x.Chart, cUser = y })
                      .GroupJoin(se.Users, Chart => Chart.Chart.ModifiedByID ?? 0, user => user.ID, (x, y) => new { Chart = x, mUser = y })
                      .SelectMany(xy => xy.mUser.DefaultIfEmpty(), (x, y) => new { Chartofaccount = x.Chart, mUser = y })
                      .Select(s => new ChartSearchList()
                      {
                          Chart = s.Chartofaccount.Chart,
                          ID = s.Chartofaccount.Chart.ID,
                          Code = s.Chartofaccount.Chart.Code,
                          Description = s.Chartofaccount.Chart.Description,
                          isParent = s.Chartofaccount.Chart.isParent,
                          CreatedBy = s.Chartofaccount.cUser == null ? string.Empty : string.Format("{0} {1}", s.Chartofaccount.cUser.Code, s.Chartofaccount.Chart.Creationdate),
                          ModifiedBy = s.mUser == null ? string.Empty : string.Format("{0} {1}", s.mUser.Code, s.Chartofaccount.Chart.Modificationdate)
                      })
                      .OrderBy(s => s.Code)
                      .ToList();

                return charts;
            }
        }
        public static List<BankSearchList> listBanks(AccountingEntities ae)
        {
            using (var se = new SecurityEntities(App.SecurityConnectionString))
            {
                var banks = ae.Banks
                      .ToList()
                      .GroupJoin(se.Users, Bank => Bank.CreatedByID ?? 0, user => user.ID, (x, y) => new { Bank = x, cUser = y })
                      .SelectMany(xy => xy.cUser.DefaultIfEmpty(), (x, y) => new { Bank = x.Bank, cUser = y })
                      .GroupJoin(se.Users, Bank => Bank.Bank.ModifiedByID ?? 0, user => user.ID, (x, y) => new { Bank = x, mUser = y })
                      .SelectMany(xy => xy.mUser.DefaultIfEmpty(), (x, y) => new { Bank = x.Bank, mUser = y })
                      .Select(s => new BankSearchList()
                      {
                          Bank = s.Bank.Bank,
                          ID = s.Bank.Bank.ID,
                          Code = s.Bank.Bank.Code,
                          Description = s.Bank.Bank.Description,
                          CreatedBy = s.Bank.cUser == null ? string.Empty : string.Format("{0} {1}", s.Bank.cUser.Code, s.Bank.Bank.Creationdate),
                          ModifiedBy = s.mUser == null ? string.Empty : string.Format("{0} {1}", s.mUser.Code, s.Bank.Bank.Modificationdate)
                      })
                      .OrderBy(s => s.Code)
                      .ToList();

                return banks;
            }
        }
        public static List<AccountTypeSearchList> listAccountType(AccountingEntities ae)
        {
            //using (var se = new SecurityEntities(App.SecurityConnectionString))
            //{
            var AccountType = ae.AccountTypes
                  .ToList()
                  .Join(ae.AccountTypes, at1 => at1.ID, at2 => at2.ID, (x, y) => new { at = x, at3 = y })
                  .Select(s => new AccountTypeSearchList()
                  {
                      AccountType = s.at,
                      ID = s.at.ID,
                      Code = s.at.Code,
                      Description = s.at.Description,
                      CreatedBy = string.Empty,
                      ModifiedBy = string.Empty
                  })
                  .OrderBy(s => s.Code)
                  .ToList();

            return AccountType;
            //}
        }
        public static List<SectorSearchList> listSectors(AccountingEntities ae)
        {
            using (var se = new SecurityEntities(App.SecurityConnectionString))
            {
                var banks = ae.Sectors
                      .ToList()
                      .GroupJoin(se.Users, s1 => s1.CreatedByID ?? 0, user => user.ID, (x, y) => new { s1 = x, cUser = y })
                      .SelectMany(xy => xy.cUser.DefaultIfEmpty(), (x, y) => new { s1 = x.s1, cUser = y })
                      .GroupJoin(se.Users, s2 => s2.s1.ModifiedByID ?? 0, user => user.ID, (x, y) => new { s2 = x, mUser = y })
                      .SelectMany(xy => xy.mUser.DefaultIfEmpty(), (x, y) => new { s2 = x.s2, mUser = y })
                      .Select(s => new SectorSearchList()
                      {
                          Sector = s.s2.s1,
                          ID = s.s2.s1.ID,
                          Code = s.s2.s1.Code,
                          Description = s.s2.s1.Description,
                          CreatedBy = s.s2.cUser == null ? string.Empty : string.Format("{0} {1}", s.s2.s1.Code, s.s2.s1.Creationdate),
                          ModifiedBy = s.mUser == null ? string.Empty : string.Format("{0} {1}", s.mUser.Code, s.s2.s1.Modificationdate)
                      })
                      .OrderBy(s => s.Code)
                      .ToList();

                return banks;
            }
        }
        public static List<VoucherTypeSearchList> listVoucherTypes(AccountingEntities ae)
        {
            using (var se = new SecurityEntities(App.SecurityConnectionString))
            {
                var banks = ae.Vouchertypes
                      .ToList()
                      .GroupJoin(se.Users, v1 => v1.CreatedByID ?? 0, user => user.ID, (x, y) => new { v1 = x, cUser = y })
                      .SelectMany(xy => xy.cUser.DefaultIfEmpty(), (x, y) => new { v1 = x.v1, cUser = y })
                      .GroupJoin(se.Users, v2 => v2.v1.ModifiedByID ?? 0, user => user.ID, (x, y) => new { v2 = x, mUser = y })
                      .SelectMany(xy => xy.mUser.DefaultIfEmpty(), (x, y) => new { v1 = x.v2.v1, v2 = x.v2, mUser = y })
                      .Select(s => new VoucherTypeSearchList()
                      {
                          Vouchertype = s.v1,
                          ID = s.v1.ID,
                          Code = s.v1.Code,
                          Description = s.v1.Description,
                          Type = s.v1.Type,
                          OrderID = s.v1.OrderID,
                          JV = s.v1.JV,
                          PV = s.v1.PV,
                          RV = s.v1.RV,
                          CN = s.v1.CN,
                          DN = s.v1.DN,
                          CreatedBy = s.v2.cUser == null ? string.Empty : string.Format("{0} {1}", s.v2.cUser.Code, s.v1.Creationdate),
                          ModifiedBy = s.mUser == null ? string.Empty : string.Format("{0} {1}", s.mUser.Code, s.v1.Modificationdate)
                      })
                      .OrderBy(s => s.Code)
                      .ToList();

                return banks;
            }
        }
        public static List<CurrencySearchList> listCurrencies(AccountingEntities ae)
        {
            using (var se = new SecurityEntities(App.SecurityConnectionString))
            {
                var currs = ae.Currencies.ToList()
                      .GroupJoin(se.Users, v1 => v1.CreatedByID ?? 0, user => user.ID, (x, y) => new { v1 = x, cUser = y })
                      .SelectMany(xy => xy.cUser.DefaultIfEmpty(), (x, y) => new { v1 = x.v1, cUser = y })
                      .GroupJoin(se.Users, v2 => v2.v1.ModifiedByID ?? 0, user => user.ID, (x, y) => new { v2 = x, mUser = y })
                      .SelectMany(xy => xy.mUser.DefaultIfEmpty(), (x, y) => new { v1 = x.v2.v1, v2 = x.v2, mUser = y })
                      .Select(s => new CurrencySearchList()
                      {
                          Currency = s.v1,
                          ID = s.v1.ID,
                          Code = s.v1.Code,
                          Description = s.v1.Description,
                          CreatedBy = s.v2.cUser == null ? string.Empty : string.Format("{0} {1}", s.v2.cUser.Code, s.v1.Creationdate),
                          ModifiedBy = s.mUser == null ? string.Empty : string.Format("{0} {1}", s.mUser.Code, s.v1.Modificationdate)
                      })
                      .OrderBy(s => s.Code)
                      .ToList();

                return currs;
            }
        }
        public static List<CompanySearchList> listCompanies(SecurityEntities se)
        {
            var comps = se.Companies.ToList()
                  .GroupJoin(se.Users, v1 => v1.CreatedByID ?? 0, user => user.ID, (x, y) => new { v1 = x, cUser = y })
                  .SelectMany(xy => xy.cUser.DefaultIfEmpty(), (x, y) => new { v1 = x.v1, cUser = y })
                  .GroupJoin(se.Users, v2 => v2.v1.ModifiedByID ?? 0, user => user.ID, (x, y) => new { v2 = x, mUser = y })
                  .SelectMany(xy => xy.mUser.DefaultIfEmpty(), (x, y) => new { v1 = x.v2.v1, v2 = x.v2, mUser = y })
                  .Select(s => new CompanySearchList()
                  {
                      Company = s.v1,
                      ID = s.v1.ID,
                      Description = s.v1.Description,
                      CreatedBy = s.v2.cUser == null ? string.Empty : string.Format("{0} {1}", s.v2.cUser.Code, s.v1.Creationdate),
                      ModifiedBy = s.mUser == null ? string.Empty : string.Format("{0} {1}", s.mUser.Code, s.v1.Modificationdate)
                  })
                  .OrderBy(s => s.Code)
                  .ToList();

            return comps;
        }
        #endregion
    }
}
