using System;
using System.Collections.Generic;

namespace Accounting
{
    public partial class RptNotesReceivablesSummary : DevExpress.XtraReports.UI.XtraReport
    {
        public RptNotesReceivablesSummary(List<NotesSummary> bs)
        {
            InitializeComponent();
            bsReport.DataSource = bs;
        }
    }
}
