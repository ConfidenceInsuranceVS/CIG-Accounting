using efControls;
using System;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;

namespace Accounting
{
    public class InsuranceServices
    {
        //private enum ptype { pPolicy, pEndorsement, dPolicy, dEndorsement }

        #region Common Functions
        public static OleDbConnection CreateConnection(string table)
        {
            var path = XML.Read(App.PreferencesFile, "General", "VfpPath");
            string connectionString = string.Format(@"Provider=VFPOLEDB.1;Exclusive=NO;Data Source={0}\{1}.dbf", path, table);
            return new OleDbConnection(connectionString);
        }

        //public static void createVfpTable(string cmd)
        //{
        //    using (var oConn = VfpConnection.dbfConnection())
        //    {
        //        cigWorkers dsw = new cigWorkers();
        //        OleDbCommand oCmd = new OleDbCommand();
        //        {
        //            oCmd.Connection = oConn;
        //            oCmd.Connection.Open();
        //            oCmd.CommandText = cmd;
        //            oCmd.CommandType = CommandType.Text;
        //            oCmd.ExecuteNonQuery();
        //        }
        //        oConn.Close();
        //        oConn.Dispose();
        //        oCmd.Dispose();
        //    }
        //}
        #endregion
        public decimal getBrokerRemain()
        {
            decimal remain = 0M;
            //using (OleDbConnection oConn = CreateConnection())
            //{
            //    try
            //    {
            //        oConn.Open();
            //        OleDbDataAdapter da = new OleDbDataAdapter();
            //        DataTable dt = new DataTable();

            //        OleDbCommand vfpcmd = new OleDbCommand()
            //        {
            //            Connection = oConn,
            //            CommandType = CommandType.Text,
            //            CommandText = string.Format("select p_remain from {2} where policy+CODE LIKE PADR('{0}',20)+LEFT('{1}',5)+'%'", cl.Opolicy, cl.Code, pTableDetails)
            //        };

            //        //Policies
            //        da.SelectCommand = vfpcmd;
            //        da.Fill(dt);
            //        if (dt.Rows.Count > 0)
            //            remain = decimal.Parse(dt.Rows[0]["p_remain"].ToString());
            //        else
            //        {
            //            //Endorsements
            //            vfpcmd.CommandText = string.Format("select p_remain from {2} where policy+CODE LIKE PADR('{0}',20)+LEFT('{1}',5)+'%'", cl.Opolicy, cl.Code, eTableDetails);
            //            da.Fill(dt);
            //            if (dt.Rows.Count > 0)
            //                remain = decimal.Parse(dt.Rows[0]["p_remain"].ToString());
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        remain = 0;
            //    }
            //    oConn.Close();
            //}
            return remain;
        }
        public string CheckPolicyCode()
        {
            string code = string.Empty;
            //try
            //{
            //    string cmd = string.Empty;
            //    if (branch == "L")
            //        cmd = String.Format("Select * from WORKERS Where policy = '{0}' and Code = '{1}'", cl.Opolicy, cl.Code);
            //    else
            //        cmd = String.Format("Select * from {0} Where policy+code like '{1}{2}%'", pTableDetails, cl.Opolicy.PadRight(20), cl.Code.TrimEnd());

            //    using (var oConn = CreateConnection())
            //    {
            //        DataTable dt = new DataTable();
            //        OleDbDataAdapter da = new OleDbDataAdapter(cmd, oConn);

            //        oConn.Open();
                    
            //        da.Fill(dt);

            //        if (dt.Rows.Count <= 0)
            //            throw new Exception("Not Found In Broker");
            //        code = dt.Rows[0]["code"].ToString();
            //    }
            //}
            //catch (Exception)
            //{
            //    code = string.Empty;
            //}
            return code;
        }
        public DataTable getDataTable(string cmd)
        {
            DataTable dt = new DataTable();
            //using (var oConn = CreateConnection())
            //{
            //    //dt = new DataTable();
            //    OleDbDataAdapter da = new OleDbDataAdapter() { SelectCommand = new OleDbCommand(cmd, oConn) };
            //    da.Fill(dt);
            //    oConn.Close();
            //}
            return dt;
        }
    }
}
