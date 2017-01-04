using efControls.Data;
using System;
using System.Collections.Generic;

namespace Accounting
{
    public partial class FormUsers : efControls.FormUsers
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        public override bool onFormCanDelete()
        {
            var rec = (User)bsMaster.Current;
            return !SecurityServices.userCodeUsed(rec.ID);
        }
    }
}
