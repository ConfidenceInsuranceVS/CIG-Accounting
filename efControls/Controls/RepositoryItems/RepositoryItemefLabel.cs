using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace efControls
{
    [UserRepositoryItem("RegisterefLabel")]
    public class RepositoryItemefLabel : RepositoryItemTextEdit
    {
        public static void RegisterefLabel()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("efLabel",
                                                       typeof(efLabel),
                                                       typeof(RepositoryItemefLabel),
                                                       typeof(DevExpress.XtraEditors.ViewInfo.LabelControlViewInfo),
                                                       new DevExpress.XtraEditors.Drawing.BaseEditPainter(),
                                                       true, null,
                                                       typeof(DevExpress.Accessibility.LabelControlAccessible)));
        }

        public override string EditorTypeName
        {
            get
            {
                return "efLabel";
            }
        }
    }
}
