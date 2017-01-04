using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Transactions;

namespace efControls
{
    public static class DbContextExtensions
    {
        public static void InsertRecord<P>(this DbContext db, P pRecord) where P : class
        {
            try
            {
                if (typeof(ITableSome).IsAssignableFrom(typeof(P)))
                    updateUserInfo((ITableSome)pRecord, "C");
                using (var ts = new TransactionScope())
                {

                    db.Set<P>().Add(pRecord);
                    db.SaveChanges();
                    ts.Complete();
                }
            }
            catch (Exception)
            {

                throw new InsertException();
            }
        }
        public static void InsertRecord<P>(this DbContext db, P pRecord, IEnumerable<P> pRecords) where P : class
        {
            try
            {
                if (typeof(ITableSome).IsAssignableFrom(typeof(P)))
                    updateUserInfo((ITableSome)pRecord, "C");
                using (var ts = new TransactionScope())
                {
                    db.Set<P>().Add(pRecord);
                    db.Set<P>().RemoveRange(pRecords);
                    db.SaveChanges();
                    ts.Complete();
                }
            }
            catch (Exception)
            {
                throw new InsertException();
            }
        }
        public static void UpdateRecord<P>(this DbContext db, P pRecord) where P : class
        {
            try
            {
                if (typeof(ITableSome).IsAssignableFrom(typeof(P)))
                    updateUserInfo((ITableSome)pRecord, "U");
                using (var ts = new TransactionScope())
                {
                    db.SaveChanges();
                    ts.Complete();
                }
            }
            catch (SqlException ex)
            {
                throw new UpdateException(getSQLError(ex.Number));
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}",
                                                validationError.PropertyName,
                                                validationError.ErrorMessage);
                    }
                }
            }
            catch (Exception)
            {
                throw new UpdateException();
            }
        }
        //public static void UpdateRecord<P>(this DbContext db, P pRecord, IEnumerable<P> pRecords) where P : class // added by samir 16/12/2016
        //{
        //    try
        //    {
        //        if (typeof(ITableSome).IsAssignableFrom(typeof(P)))
        //            updateUserInfo((ITableSome)pRecord, "U");
        //        using (var ts = new TransactionScope())
        //        {
        //            db.Set<P>().Add(pRecord);
        //            db.Set<P>().RemoveRange(pRecords);
        //            db.SaveChanges();
        //            ts.Complete();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        throw new InsertException();
        //    }
        //}
        public static void DeleteRecord<P>(this DbContext db, P pRecord) where P : class
        {
            try
            {
                using (var ts = new TransactionScope())
                {

                    db.Set<P>().Attach(pRecord);//added by samir BU 15/12/2016-1
                    db.Set<P>().Remove(pRecord);

                    db.SaveChanges();
                    ts.Complete();
                }
            }
            catch (SqlException ex)
            {
                db.Entry<P>(pRecord).Reload();
                throw new DeleteException(getSQLError(ex.Number));
            }
            catch (Exception ex)
            {
                db.Entry<P>(pRecord).Reload();
                throw new DeleteException();
            }


        }
        public static void DeleteRecord<P, C>(this DbContext db, P pRecord, IEnumerable<C> cRecords)
            where P : class
            where C : class
        {
            try
            {
                using (var ts = new TransactionScope())
                {
                    db.Set<C>().RemoveRange(cRecords);
                    db.Set<P>().Remove(pRecord);
                    db.SaveChanges();
                    ts.Complete();
                }
            }
            catch (SqlException ex)
            {
                db.Entry<P>(pRecord).Reload();
                throw new DeleteException(getSQLError(ex.Number));
            }
            catch (Exception)
            {
                db.Entry<P>(pRecord).Reload();
                throw new DeleteException();
            }
        }
        private static void updateUserInfo(ITableSome p, string cu)
        {
            switch (cu)
            {
                case "C":
                    p.CreatedByID = App.UserID;
                    p.Creationdate = DateTime.Now;
                    break;

                case "U":
                    p.ModifiedByID = App.UserID;
                    p.Modificationdate = DateTime.Now;
                    break;
            }
        }
        private static string getSQLError(int en)
        {
            var msg = string.Empty;
            switch (en)
            {
                case 547:
                    msg = "Record Has Childs, Cannot Delete !!!";
                    break;

                case 8152:
                    msg = "String too long to fit, Please Correct !!!";
                    break;

                default:
                    msg = string.Format("SQL - Error Number {0} ...", en);
                    break;
            }
            return msg;
        }
    }
}
