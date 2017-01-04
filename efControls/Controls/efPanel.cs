using DevExpress.XtraEditors;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efPanel : PanelControl, IControl
    {
        public efPanel()
        {
            InitializeComponent();
        }

        public override void Refresh()
        {
            base.Refresh();
        }

        [Category("xProperties")]
        public Enums.ControlState DefaultState { get; set; }

        [Category("xProperties")]
        public bool HighLighted { get; set; }
    }
}
