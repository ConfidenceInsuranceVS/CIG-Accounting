using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;

namespace efControls
{
    [UserRepositoryItem("RegisterefMemoEdit")]
    public class RepositoryItemefMemoEdit : RepositoryItemMemoEdit
    {
        public static void RegisterefMemoEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("efMemoEdit",
                                                       typeof(efMemoEdit),
                                                       typeof(RepositoryItemefMemoEdit),
                                                       typeof(DevExpress.XtraEditors.ViewInfo.MemoEditViewInfo),
                                                       new DevExpress.XtraEditors.Drawing.MemoEditPainter(),
                                                       true, null,
                                                       typeof(DevExpress.Accessibility.MemoEditAccessible)));
        }

        public override string EditorTypeName
        {
            get
            {
                return "efMemoEdit";
            }
        }
    }
}
