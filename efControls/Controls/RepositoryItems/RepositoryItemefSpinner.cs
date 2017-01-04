using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace efControls
{
    [UserRepositoryItem("RegisterefSpinner")]
    public class RepositoryItemefSpinner : RepositoryItemSpinEdit
    {
        public static void RegisterefSpinner()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("efSpinner",
                                                       typeof(efSpinner),
                                                       typeof(RepositoryItemefSpinner),
                                                       typeof(DevExpress.XtraEditors.ViewInfo.BaseSpinEditViewInfo),
                                                       new DevExpress.XtraEditors.Drawing.ButtonEditPainter(),
                                                       true, null,
                                                       typeof(DevExpress.Accessibility.BaseSpinEditAccessible)));
        }

        public override string EditorTypeName
        {
            get
            {
                return "efSpinner";
            }
        }
    }
}
