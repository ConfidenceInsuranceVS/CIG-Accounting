using DevExpress.Accessibility;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Drawing;

namespace efControls
{
    [UserRepositoryItem("RegisterefCheckBox")]
    public class RepositoryItemefCheckBox : RepositoryItemCheckEdit
    {
        public static void RegisterefCheckBox()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("efCheckBox",
                                                       typeof(efCheckBox),
                                                       typeof(RepositoryItemefCheckBox),
                                                       typeof(CheckEditViewInfo),
                                                       new CheckEditPainter(),
                                                       true, null,
                                                       typeof(CheckEditAccessible)));
        }

    }
}
