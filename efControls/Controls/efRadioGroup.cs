using DevExpress.XtraEditors;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efRadioGroup : RadioGroup
    {
        public efRadioGroup()
        {
            InitializeComponent();
        }

        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            BackColor = System.Drawing.Color.Transparent;
        }
    }
}
