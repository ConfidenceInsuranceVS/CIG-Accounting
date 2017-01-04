using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using System.ComponentModel;

namespace efControls
{
    [UserRepositoryItem("RegisterefTextBox")]
    public class RepositoryItemefTextBox : RepositoryItemTextEdit
    {
        public static void RegisterefTextBox()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("efTextBox",
                                                       typeof(efTextBox),
                                                       typeof(RepositoryItemefTextBox),
                                                       typeof(DevExpress.XtraEditors.ViewInfo.TextEditViewInfo),
                                                       new DevExpress.XtraEditors.Drawing.BaseEditPainter(),
                                                       true, null,
                                                       typeof(DevExpress.Accessibility.TextEditAccessible)));
        }
    }
}
