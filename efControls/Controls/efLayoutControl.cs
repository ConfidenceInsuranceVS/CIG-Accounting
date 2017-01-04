using DevExpress.XtraLayout;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efLayoutControl : LayoutControl
    {
        public efLayoutControl()
        {
            StyleController = App.styleController;
        }
        public efLayoutControl(bool fAllowUseSplitters, bool fAllowTabbedGroups)
            : base(fAllowUseSplitters, fAllowTabbedGroups)
        {
        }

        public efLayoutControl(bool createFast)
            : base(createFast)
        {
        }

        public override BaseLayoutItem CreateLayoutItem(LayoutGroup parent)
        {
            return new lci(parent as LayoutControlGroup);
        }
    }
}
