using DevExpress.XtraEditors;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace efControls
{
    public class Functions
    {
        #region Class Vairables

        private static readonly byte[] bytes = ASCIIEncoding.ASCII.GetBytes("marlboro");

        #endregion Class Vairables

        #region Logging
        public static void LogException(String Exception)
        {
            try
            {
                //string tablePrefix = "";
                //switch (App.Name)
                //{
                //    case "Accounting":
                //        tablePrefix = "Acc";
                //        break;

                //    case "Stock":
                //        tablePrefix = "Stock";
                //        break;

                //    default:
                //        break;
                //}
                //string date = DateTime.Now.ToString();
                //using (var con = new SqlConnection(App.SecurityConnectionString))
                //{
                //    con.Open();
                //    using (var da = new SqlDataAdapter())
                //    {
                //        var insertcommand = new SqlCommand
                //        {
                //            Connection = con,
                //            CommandType = CommandType.Text,
                //            CommandText = String.Format("INSERT INTO {0}_Errors ( Error_Workstation,Error_User,Error_Date, Error_Message) VALUES ( '{1}' , '{2}', '{3}', '{4}')", tablePrefix, System.Net.Dns.GetHostName(), App.Name, date, Exception)
                //        };
                //        da.InsertCommand = insertcommand;
                //    }
                //}
            }
            catch (Exception exp)
            {
                Alert.ShowMessage(exp.ToString());
            }
        }

        #endregion Logging

        #region Other Functions

        public static bool setControlState(Enums.ControlState state, Enums.State formState)
        {
            // this will set the control ReadOnly State
            bool EnableState = true;
            switch (state)
            {
                case Enums.ControlState.Default:
                    switch (formState)
                    {
                        case Enums.State.New:
                            EnableState = false;
                            break;

                        case Enums.State.Edit:
                            EnableState = false;
                            break;

                        case Enums.State.None:
                            EnableState = true;
                            break;

                        default:
                            EnableState = true;
                            break;
                    }
                    break;

                case Enums.ControlState.AlwaysDisabled:
                    EnableState = true;
                    break;

                case Enums.ControlState.AlwaysEnabled:
                    EnableState = false;
                    break;

                case Enums.ControlState.EditDisabled:
                    EnableState = formState == Enums.State.New ? false : true;
                    break;
            }
            return EnableState;
        }
        #endregion Other Functions

        #region Locking

        //public static Decimal getRate(string code, DateTime date)
        //{
        //    Decimal Result = 0;
        //    SqlConnection con = new SqlConnection(App.ConnectionString);
        //    SqlCommand cmd = new SqlCommand();

        //    cmd.CommandText = "SP_GetRate";
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    cmd.Parameters.AddWithValue("@Code", code);
        //    cmd.Parameters.AddWithValue("@Date", date.ToShortDateString());

        //    cmd.Connection = con;
        //    con.Open();
        //    Result = decimal.Parse(cmd.ExecuteScalar().ToString());
        //    if (Result == 0)
        //    {
        //        cmd.Parameters.Clear();
        //        cmd.Parameters.AddWithValue("@Code", code);
        //        cmd.Parameters.AddWithValue("@Date", null);
        //    }
        //    return Result;
        //}

        #endregion Locking

        #region VFP Adapted Functions
        public static bool InList(object toExpression, params object[] toItems)
        {
            return Array.IndexOf(toItems, toExpression) > -1;
        }
        public static bool Between(int tnExpression, int tnLowValue, int tnHighValue)
        {
            return ((tnExpression >= tnLowValue) && (tnExpression <= tnHighValue));
        }
        public static bool Between(double tnExpression, double tnLowValue, double tnHighValue)
        {
            return ((tnExpression >= tnLowValue) && (tnExpression <= tnHighValue));
        }
        public static bool BetweenDecimal(decimal tnExpression, decimal tnLowValue, decimal tnHighValue)
        {
            return ((tnExpression >= tnLowValue) && (tnExpression <= tnHighValue));
        }
        // Compares between for date range
        public static bool Between(DateTime tdDateTime, DateTime tdStartDate, DateTime tdEndDate)
        {
            return ((tdDateTime >= tdStartDate) && (tdDateTime <= tdEndDate));
        }
        // Compares between for char
        public static bool Between(char tcChar, char tcLowChar, char tcHighChar)
        {
            return (((int)tcChar >= (int)tcLowChar) && ((int)tcChar <= (int)tcHighChar));
        }
        // Compares between for strings
        // The way strings are compared in VFP is interesting
        public static bool Between(string tcExpression, string tcStart, string tcEnd)
        {
            bool llRetVal = true;

            // We start with the start string, tcStart, and compare each character in this
            // with tcExpression. If we fail at anytime we return a false
            for (int i = 0; i < tcStart.Length; i++)
            {
                if (tcStart[i] < tcExpression[i])
                {
                    llRetVal = false;
                    break;
                }

                //if we have reached the end of tcExpression break
                if (i == tcExpression.Length)
                    break;
            }

            // The way strings are compared in VFP is interesting
            // We start with the start string, tcStart, and compare each character in this
            // with tcExpression. If we fail at anytime we return a false
            for (int i = 0; i < tcEnd.Length; i++)
            {
                if (tcEnd[i] > tcExpression[i])
                {
                    llRetVal = false;
                    break;
                }

                //if we have reached the end of tcExpression break
                if (i == tcExpression.Length)
                    break;
            }

            return llRetVal;
        }
        public static bool Between(DateTime? tdDateTime, DateTime? tdStartDate, DateTime? tdEndDate)
        {
            return (((DateTime)tdDateTime).Date >= ((DateTime)tdStartDate).Date && ((DateTime)tdDateTime).Date <= ((DateTime)tdEndDate).Date);
        }

        #endregion VFP Adapted Functions

        public static bool isNullOrZeroInt(int? x)
        {
            bool result = false;
            try
            {
                if (x == 0)
                {
                    throw new Exception();
                }
                if (x == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                result = true;
            }
            return result;
        }
        public static bool isNullOrZeroDecimal(decimal? x)
        {
            bool result = false;
            try
            {
                if (x == 0)
                {
                    throw new Exception();
                }
                if (x == null)
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                result = true;
            }
            return result;
        }
        public static int noOfDaysInYear(int year)
        {
            var thisYear = new DateTime(year, 1, 1);
            var nextYear = new DateTime(year + 1, 1, 1);

            return (nextYear - thisYear).Days;
        }
        public static DialogResult InputBox(string title, string promptText, ref string value)
        {
            var form = new XtraForm();
            var label = new Label();
            var textBox = new TextBox();
            var buttonOk = new Button();
            var buttonCancel = new Button();

            form.Text = title;
            label.Text = promptText;
            textBox.Text = value;
            textBox.CharacterCasing = CharacterCasing.Upper;
            textBox.SelectionStart = value.Length; // Added

            buttonOk.Text = "OK";
            buttonCancel.Text = "Cancel";
            buttonOk.DialogResult = DialogResult.OK;
            buttonCancel.DialogResult = DialogResult.Cancel;

            label.SetBounds(9, 20, 372, 13);
            textBox.SetBounds(12, 36, 372, 20);
            buttonOk.SetBounds(228, 72, 75, 23);
            buttonCancel.SetBounds(309, 72, 75, 23);

            label.AutoSize = true;
            textBox.Anchor = textBox.Anchor | AnchorStyles.Right;
            buttonOk.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;

            form.ClientSize = new Size(396, 107);
            form.Controls.AddRange(new Control[] { label, textBox, buttonOk, buttonCancel });
            form.ClientSize = new Size(Math.Max(300, label.Right + 10), form.ClientSize.Height);
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterScreen;
            form.MinimizeBox = false;
            form.MaximizeBox = false;
            form.AcceptButton = buttonOk;
            form.CancelButton = buttonCancel;

            var dialogResult = form.ShowDialog();
            value = textBox.Text;
            return dialogResult;
        }
        public static DataTable ToDataTable<T>(IEnumerable<T> collection)
        {
            DataTable newDataTable = new DataTable();
            Type impliedType = typeof(T);
            PropertyInfo[] _propInfo = impliedType.GetProperties();
            foreach (PropertyInfo pi in _propInfo)
                newDataTable.Columns.Add(pi.Name);

            foreach (T item in collection)
            {
                DataRow newDataRow = newDataTable.NewRow();
                newDataRow.BeginEdit();
                foreach (PropertyInfo pi in _propInfo)
                    newDataRow[pi.Name] = pi.GetValue(item, null);
                newDataRow.EndEdit();
                newDataTable.Rows.Add(newDataRow);
            }
            return newDataTable;
        }
        
        #region "getobject filled object with property reconized"
        public static List<T> ConvertTo<T>(DataTable datatable) where T : new()
        {
            List<T> Temp = new List<T>();
            try
            {
                List<string> columnsNames = new List<string>();
                foreach (DataColumn DataColumn in datatable.Columns)
                    columnsNames.Add(DataColumn.ColumnName);
                Temp = datatable.AsEnumerable().ToList().ConvertAll<T>(row => getObject<T>(row, columnsNames));
                return Temp;
            }
            catch
            {
                return Temp;
            }

        }
        public static T getObject<T>(DataRow row, List<string> columnsName) where T : new()
        {
            T obj = new T();
            try
            {
                string columnname = "";
                string value = "";
                PropertyInfo[] Properties;
                Properties = typeof(T).GetProperties();
                foreach (PropertyInfo objProperty in Properties)
                {
                    columnname = columnsName.Find(name => name.ToLower() == objProperty.Name.ToLower());
                    if (!string.IsNullOrEmpty(columnname))
                    {
                        value = row[columnname].ToString();
                        if (!string.IsNullOrEmpty(value))
                        {
                            if (Nullable.GetUnderlyingType(objProperty.PropertyType) != null)
                            {
                                value = row[columnname].ToString().Replace("$", "").Replace(",", "");
                                objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(Nullable.GetUnderlyingType(objProperty.PropertyType).ToString())), null);
                            }
                            else
                            {
                                value = row[columnname].ToString().Replace("%", "");
                                objProperty.SetValue(obj, Convert.ChangeType(value, Type.GetType(objProperty.PropertyType.ToString())), null);
                            }
                        }
                    }
                }
                return obj;
            }
            catch
            {
                return obj;
            }
        }
        #endregion

        public static DataTable ConvertToDataTable<T>(IList<T> list)
        {
            var dt = new DataTable();
            var properties = typeof(T).GetProperties();

            foreach (var pi in properties)
            {
                if (Type.GetType(pi.PropertyType.FullName) == null)
                    continue;
                dt.Columns.Add(pi.Name);
            }

            foreach (T element in list)
            {
                var row = dt.NewRow();
                foreach (var pi in properties)
                {
                    if (Type.GetType(pi.PropertyType.FullName) == null)
                        continue;
                    row[pi.Name] = pi.GetValue(element, null);
                }
                dt.Rows.Add(row);
            }
            return dt;
        }
        public static bool CompareDataTable(DataTable t1, DataTable t2)  // t1 table of bsMaster  &&  t2 table of bsSearch
        {
            var result = true;
            for (int i = 0; i < t2.Rows.Count; i++)
            {
                foreach (var col in t2.Columns)
                {
                    if (t1.Columns[col.ToString()] != null)
                        if (t1.Rows[i][col.ToString()].ToString().Trim() != t2.Rows[i][col.ToString()].ToString().Trim())
                        {
                            result = false;
                            break;
                        }
                }
                if (!result) break;
            }
            return result;
        }
    }
}
