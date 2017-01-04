using DevExpress.XtraLayout;
using System.ComponentModel;
using System.Windows.Forms;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class lci : LayoutControlItem
    {
        public lci()
        {
            //AppearanceItemCaption.Font = App.font;
        }

        public lci(LayoutControlGroup parent)
            : base(parent)
        {
        }

        public lci(LayoutControl layoutControl, Control control)
            : base(layoutControl, control)
        {
        }

        public bool? IsRequired { get; set; }
    }
}
