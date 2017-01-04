using DevExpress.XtraEditors;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efLabel : LabelControl, IControl
    {
        static efLabel()
        {
            RepositoryItemefLabel.RegisterefLabel();
        }

        public efLabel()
        {
            Name = "efLabel";
            DefaultState = Enums.ControlState.Default;
            //Layout += efLabel_Layout;
        }

        [Category("xProperties")]
        public Enums.ControlState DefaultState { get; set; }

        [Category("xProperties")]
        public bool HtmlLook { get; set; }
    }
}
