using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efGroupControl : DevExpress.XtraEditors.GroupControl
    {
        public efGroupControl()
        {
        }

        public override void Refresh()
        {
            Appearance.Font = App.font;
            AppearanceCaption.Font = App.font;
            AppearanceCaption.Options.UseFont = true;
            base.Refresh();
        }
    }
}
