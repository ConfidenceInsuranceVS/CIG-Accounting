using System;
using System.Collections.Generic;
using System.Data;
using static Accounting.vfpData;
using Accounting.vfpDataTableAdapters;
using System.Linq;
using System.Data.OleDb;
using DevExpress.XtraGrid;
using efControls;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraBars;
using System.Globalization;
using DevExpress.XtraScheduler.UI;
using System.Text;

namespace Accounting
{
    public partial class ucInstallments : XtraUserControl
    {
        protected internal efDataForm frm;
        protected internal string broker, type;
        protected internal int Voucherid, reference, ydate;
        protected internal decimal amount = 0;
        //
        AccountingEntities ae;
        OleDbConnection vfpConn;
        public ucInstallments()
        {
            InitializeComponent();

            ae = new AccountingEntities(App.MainConnectionString);
            vfpConn = VfpConnection.dbfConnection("install");

            gvReceipts.ShowingEditor += GvReceipts_ShowingEditor;
            //
            DataTable dt = new DataTable();
            dt.Columns.Add("Amount", typeof(Decimal));
            var dr = dt.NewRow();
            dr[0] = amount;
            dt.Rows.Add(dr);
            BindingSource bsAmount = new BindingSource() { DataSource = dt };
            beAmount.DataBindings.Add("EditValue", bsAmount, "Amount");
            //
            var americanCulture = new CultureInfo("en-US");
        }
        public ucInstallments(efDataForm xfrm) : this()
        {
            frm = xfrm;
            Dock = DockStyle.Fill;
            EnableParent(false);
            //
            //frm.Controls.Add(this);

            BringToFront();
        }
        protected void EnableParent(bool enabled)
        {
            frm.sccMain.Visible = enabled;
            frm.lcSearch.Enabled = frm.lcMain.Enabled = enabled;
            frm.toolBar.BeginUpdate();
            try
            {
                foreach (BarItemLink link in frm.toolBar.ItemLinks)
                {
                    if (!enabled)
                    {
                        link.Item.Tag = link.Item.Enabled;
                        link.Item.Enabled = false;
                    }
                    else
                    {
                        link.Item.Enabled = (bool)link.Item.Tag;
                        link.Item.Tag = null;
                    }
                }
            }
            finally
            {
                frm.toolBar.EndUpdate();
            }
        }
        private void _close()
        {
            EnableParent(true);
            frm.Controls.Remove(this);
            frm.Refresh();
        }
        private void GvReceipts_ShowingEditor(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var view = sender as efGridView;
            //var rec = (Installment)bsReceipts.Current;
            if (view.FocusedColumn != colPaid) { e.Cancel = true; }
        }
        private void bbiCancel_ItemClick(object sender, ItemClickEventArgs e)
        {
            _close();
        }
        private void gcReceipts_EmbeddedNavigator_ButtonClick(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType != NavigatorButtonType.Custom) { return; }
            switch (e.Button.Tag.ToString().ToUpper())
            {
                case "FILTER":
                    if (gvReceipts.ActiveFilter.Count > 0) { setFilter(false); }
                    else { setFilter(true); }
                    break;
                case "EXCEL":
                    break;
                case "PRINT":
                    break;
                case "CLEAR":
                    if (Alert.ShowDialogMessage("Clear All Amounts relative to this receipt?") == DialogResult.Yes)
                    {
                        var rows = bsReceipts.List.OfType<Installment>()
                            .Where(c => c.Ydate == ydate)
                            .Where(c => c.Type == type)
                            .Where(c => c.Reference == reference)
                            .ToList();
                        foreach (var row in rows)
                        {
                            row.Amount = 0;
                        }
                        gvReceipts.RefreshData();
                    }
                    break;
            }
        }
        private void gvReceipts_CustomUnboundColumnData(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs e)
        {
            if (e.IsGetData)
            {
                var row = (Installment)e.Row;
                OleDbCommand cmd = new OleDbCommand()
                {
                    Connection = vfpConn,
                    CommandText = string.Format("Select inst_date From install WHERE inst_branch = '{0}' and inst_policy = '{1}' and inst_end = '{2}'", row.Branch, row.Policy, row.Endorsement)
                };
                if (vfpConn.State == ConnectionState.Closed) { vfpConn.Open(); }
                e.Value = ((DateTime)cmd.ExecuteScalar()).ToShortDateString();
            }
        }
        private void riPaid2Zero_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

            var row = (Installment)bsReceipts.Current;
            row.Amount = 0;
            gvReceipts.RefreshRow(gvReceipts.FocusedRowHandle);
        }
        private void bbiAutoDistribute_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (amount == 0) { return; }

            foreach (var row in bsInstall.List.OfType<InstallRow>().Where(c => c.inst_pay != 0))
            {
                row.inst_pay = 0;
            }

            decimal remain = 0;
            foreach (var row in bsInstall.List.OfType<InstallRow>())
            {
                if (row.inst_amt < 0)
                {
                    if (amount <= Math.Abs(row.inst_amt) - Math.Abs(row.inst_pay))
                        remain = amount;
                    else
                        remain = -(Math.Abs(row.inst_amt) - Math.Abs(row.inst_pay));
                }
                else
                {
                    if (amount <= row.inst_amt - row.inst_pay)
                        remain = amount;
                    else
                        remain = row.inst_amt - row.inst_pay;
                }
                row.inst_pay = remain;
                amount -= remain;
            }
            Refresh();
        }
        private void bbiSave_ItemClick(object sender, ItemClickEventArgs e)
        {
            //NET
            if (amount < 0)
            {
                Alert.Show("Cannot Save Amount Exceeds The Voucher", Enums.AlertType.Warning);
                return;
            }

            var insts = bsInstall.List.OfType<InstallRow>().Where(c => c.inst_topay != 0).ToList();
            Installment installment = null;
            foreach (var inst in insts)
            {
                installment = bsReceipts.List.OfType<Installment>()
                    .Where(c => c.Type == type)
                    .Where(c => c.Reference == reference)
                    .Where(c => c.Branch == inst.inst_branch)
                    .Where(c => c.Policy == inst.inst_policy)
                    .Where(c => c.Endorsement == inst.inst_end)
                    .Where(c => c.Serial == inst.inst_serial)
                    .FirstOrDefault();
                if (installment != null)
                    installment.Amount += inst.inst_topay;
                else
                {
                    installment = new Installment()
                    {
                        Type = type,
                        Reference = reference,
                        Paydate = inst.inst_date,
                        Branch = inst.inst_branch,
                        Policy = inst.inst_policy,
                        Endorsement = inst.inst_end,
                        Serial = (int)inst.inst_serial,
                        Broker = inst.inst_broker,
                        Insured = inst.inst_cli,
                        Amount = inst.inst_topay
                    };
                    bsReceipts.Add(installment);
                }
            }

            //VFP
            var receipts = bsReceipts.List.OfType<Installment>().Where(c => c.Type == type & c.Reference == reference).ToList();
            foreach (var receipt in receipts)
            {
                // CLEAR
                string dbfName = string.Empty;

                #region Fill DBF Name
                switch (receipt.Branch)
                {
                    case "A":
                        dbfName = "CARS";
                        break;
                    case "C":
                        dbfName = "ALLRISK";
                        break;
                    case "H":
                        dbfName = "HOSPI";
                        break;
                    case "I":
                        dbfName = "FIRE";
                        break;
                    case "L":
                        dbfName = "LIFE";
                        break;
                    case "P":
                        dbfName = "PA";
                        break;
                    case "S":
                        dbfName = "WORKERS";
                        break;
                    case "R":
                        dbfName = "GTPL";
                        break;
                    case "W":
                        dbfName = "WMEN";
                        break;
                    case "T":
                        dbfName = "TRANSP";
                        break;
                    case "V":
                        dbfName = "BURG";
                        break;
                    case "M":
                        dbfName = "MOTOR";
                        break;
                    case "O":
                        dbfName = "OUT";
                        break;
                    case "J":
                        dbfName = "TRAVEL";
                        break;
                    case "B":
                        dbfName = "VEH";
                        break;
                    case "Q":
                        dbfName = "CARSQS";
                        break;
                    case "K":
                        dbfName = "BOATS";
                        break;
                    case "D":
                        dbfName = "PVIOL";
                        break;
                }
                #endregion

                using (var conn = VfpConnection.dbfConnection(dbfName))
                {
                    OleDbCommand cmd = new OleDbCommand() { Connection = vfpConn };
                    if (string.IsNullOrEmpty(receipt.Endorsement))
                        cmd.CommandText = string.Format("update {0} set paid = {1} where policy = '{2}'", dbfName, receipt.Amount, receipt.Policy);
                    else
                        cmd.CommandText = string.Format("update {0}e set paid = {1} where code = '{2}'", dbfName, receipt.Amount, receipt.Endorsement);

                    if (conn.State == ConnectionState.Closed) { conn.Open(); }
                    cmd.ExecuteNonQuery();
                };
            }

            bsReceipts.List.OfType<Installment>().ToList().RemoveAll(c => c.Amount == 0);
        }
        private void riImportLife_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (e.Button.Caption == "IMPORT")
            {
                if (App.WorkingYear < 2007) { return; }
                //
                var il = sender as MonthEdit;
                if (il.EditValue == null)
                {
                    Alert.Show("Please Select Month To Proceed ...", Enums.AlertType.Warning);
                    return;
                }
                //
                try
                {
                    var exDate = new DateTime(App.WorkingYear, (int)il.EditValue, DateTime.DaysInMonth(App.WorkingYear, (int)il.EditValue));
                    if (Alert.ShowDialogMessage(string.Format("Update Long Life Policies Till {0} ??", exDate.ToShortDateString())) == DialogResult.No) { return; }
                    //
                    using (OleDbDataAdapter da = new OleDbDataAdapter())
                    {
                        StringBuilder sb = new StringBuilder();
                        sb.Append("Select * from life ");
                        sb.AppendFormat("Where life=2 And Month(life.idate) <= {0} ", exDate.Month);
                        sb.AppendFormat("And ({0} - Year(life.idate) < life.period) ", exDate.Year);
                        sb.AppendFormat("And Iif(!Empty(life.deldate), life.deldate > Ctod(Transform(Day(life.idate)) + ' / ' + Transform(Month(life.idate)) + ' / ' + Transform({0})), .T.)", exDate.Year);
                        //
                        OleDbCommand cmd = new OleDbCommand()
                        {
                            Connection = vfpConn,
                            CommandText = sb.ToString()
                        };
                        if (vfpConn.State == ConnectionState.Closed) { vfpConn.Open(); }
                        DataTable dt = new DataTable();
                        da.SelectCommand = cmd;
                        da.Fill(dt);
                        //
                        foreach (DataRow row in dt.Rows)
                        {
                            sb.Clear();
                            decimal tpremium = 0;
                            var year = ((DateTime)row["idate"]).Year;
                            if (year != exDate.Year)
                                tpremium = decimal.Parse(row["premium"].ToString()) + decimal.Parse(row["fees"].ToString()) + decimal.Parse(row["tcom"].ToString()) + decimal.Parse(row["com"].ToString());
                            else
                                tpremium = decimal.Parse(row["tpremium"].ToString());

                            sb.Append("SELECT inst_branch, inst_policy, inst_end, inst_broker, inst_cli, inst_amt, inst_date, inst_serial from install");
                            sb.AppendFormat(" WHERE inst_branch = 'L' and inst_policy = '{0}' and inst_end = '{1}'", row["policy"], row["end"]);
                            sb.AppendFormat(" and EMPTY(inst_end) and YEAR(inst_date) == {0}", exDate.Year);
                            cmd.CommandText = sb.ToString();
                            if (cmd.ExecuteNonQuery() == 0)
                            {
                                sb.Clear();
                                sb.Append("INSERT INTO install (inst_branch, inst_policy, inst_end, inst_broker, inst_cli, inst_amt, inst_date, inst_serial)");
                                sb.AppendFormat(" SELECT inst_branch, inst_policy, inst_end, inst_broker, inst_cli, {0},", tpremium);
                                sb.AppendFormat(" CTOD('{0}'), MAX(inst_serial)+1", new DateTime(exDate.Year, ((DateTime)row["idate"]).Month, ((DateTime)row["idate"]).Day).ToShortDateString());
                                sb.AppendFormat(" FROM install WHERE inst_branch = 'L' and inst_policy = '{0}' and inst_end = '{1}'", row["policy"], row["end"]);
                                sb.AppendFormat(" and EMPTY(inst_end) and YEAR(inst_date) != {0}", exDate.Year);
                                sb.Append(" GROUP BY inst_branch, inst_policy, inst_end, inst_broker, inst_cli, inst_amt");
                                cmd.CommandText = sb.ToString();

                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception)
                {
                }
            }
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            getInstallData();

            bsReceipts.DataSource = ae.Installments.OrderBy(c => c.Ydate).ToList();
            setFilter(true);
        }
        private void getInstallData()
        {
            //
            var ds = new vfpData();
            var dt = new InstallDataTable();
            InstallTableAdapter install = new InstallTableAdapter() { Connection = vfpConn };
            install.Fill(dt, broker);
            bsInstall.DataSource = dt;
        }
        private void setFilter(bool set)
        {
            if (set)
            {
                gvReceipts.SetRowCellValue(GridControl.AutoFilterRowHandle, colType, type);
                gvReceipts.SetRowCellValue(GridControl.AutoFilterRowHandle, colReference, reference);
                gvReceipts.SetRowCellValue(GridControl.AutoFilterRowHandle, colYdate, ydate);
            }
            else
            {
                gvReceipts.ActiveFilter.Clear();
            }
            if(gvReceipts.RowCount > 0) { gvReceipts.MoveFirst(); }
        }
    }
}
