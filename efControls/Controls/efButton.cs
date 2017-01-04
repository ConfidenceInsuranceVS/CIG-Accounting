using DevExpress.XtraEditors;
using System.ComponentModel;
using System.Drawing;

namespace efControls
{
    [ToolboxItem(true), ToolboxBitmap(typeof(SimpleButton))]
    public partial class efButton : SimpleButton, IControl
    {
        public efButton()
        {
            InitializeComponent();
            DefaultState = Enums.ControlState.Default;
            BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
        }

        public override void Refresh()
        {
            base.Refresh();
            var ef = FindForm() as efBaseForm;
            Enabled = !Functions.setControlState(DefaultState, ef == null ? Enums.State.Edit : ef.xState);
        }

        [Category("xProperties")]
        public Enums.ControlState DefaultState { get; set; }

        [Category("xProperties")]
        public bool HighLighted { get; set; }
    }
}
