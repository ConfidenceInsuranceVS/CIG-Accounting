using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace efControls
{
    [UserRepositoryItem("RegisterefDateEdit")]
    public class RepositoryItemefDateEdit : RepositoryItemDateEdit
    {
        public static void RegisterefDateEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("efDateEdit",
                                                       typeof(efDateEdit),
                                                       typeof(RepositoryItemefDateEdit),
                                                       typeof(DevExpress.XtraEditors.ViewInfo.DateEditViewInfo),
                                                       new DevExpress.XtraEditors.Drawing.BaseEditPainter(),
                                                       true, null,
                                                       typeof(DevExpress.Accessibility.DateEditAccessible)));
        }
    }
}
