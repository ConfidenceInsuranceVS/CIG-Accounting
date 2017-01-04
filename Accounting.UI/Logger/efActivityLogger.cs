using System;
using System.Collections.Generic;
using System.Linq;
using efControls;
using efControls.Data;

namespace Accounting
{
    public partial class efActivityLogger : efBaseForm
    {
        AccountingEntities lc;
        public efActivityLogger()
        {
            InitializeComponent();
            timer.Enabled = false;
        }
        protected override void OnShown(EventArgs e)
        {
            getLookupData();
            Splash.Close();
            //base.OnShown(e);
        }

        private void getLookupData()
        {
            lc = new AccountingEntities(App.MainConnectionString);
            bsLogger.DataSource = lc.ActivityLoggers.OrderByDescending(c => c.DateIn).ToList();
            using (var se = new SecurityEntities(App.SecurityConnectionString))
            {
                bsUsers.DataSource = se.Users.ToList();
            };
        }
        protected override void OnClosed(EventArgs e)
        {
            //base.OnClosed(e);
        }

        private void gcLogger_EmbeddedNavigator_ButtonClick(object sender, DevExpress.XtraEditors.NavigatorButtonClickEventArgs e)
        {
            if (e.Button.Hint == "REFRESH") 
            {
                lc = null;
                getLookupData(); 
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lc = null;
            getLookupData();
        }

        private void chkAutoRefresh_CheckedChanged(object sender, EventArgs e)
        {
            timer.Enabled = (bool)chkAutoRefresh.EditValue;
        }
    }
}
