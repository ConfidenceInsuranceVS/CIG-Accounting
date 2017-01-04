using DevExpress.XtraEditors;
using System;

namespace efControls
{
    public partial class efUserControl : XtraUserControl
    {
        public efBaseForm xParent;
        protected Enums.State xParentState;
        public efUserControl()
        {
            InitializeComponent();
        }

        protected override void OnFirstLoad()
        {
            if (DesignMode) { return; }

            xParent = (efBaseForm)ParentForm;
            xParentState = xParent.xState;
            xParent.xState = Enums.State.Off;

            ClientSize = new System.Drawing.Size(ClientSize.Width + 10, ClientSize.Height + 10);
            Left = (xParent.ClientSize.Width - Width) / 2;
            Top = (xParent.ClientSize.Height - Height) / 2;

            BringToFront();
            ParentForm.ControlRemoved += efUserControl_ControlRemoved;
        }

        void efUserControl_ControlRemoved(object sender, System.Windows.Forms.ControlEventArgs e)
        {
            xParent.xState = xParentState;
        }
    }
}
