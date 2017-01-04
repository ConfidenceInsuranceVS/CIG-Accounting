using DevExpress.Accessibility;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace efControls
{
    [UserRepositoryItem("RegisterefComboBox")]
    public class RepositoryItemefComboBox : RepositoryItemLookUpEdit
    {
        public RepositoryItemefComboBox() : base()
        {
            Name = "efComboBox";
        }

        public static void RegisterefComboBox()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("efComboBox",
                                                       typeof(efComboBox),
                                                       typeof(RepositoryItemefComboBox),
                                                       typeof(LookUpEditViewInfo),
                                                       new ButtonEditPainter(),
                                                       true, null,
                                                       typeof(ButtonEditAccessible)));
        }

        public override string EditorTypeName { get { return "efComboBox"; } }
    }
}
