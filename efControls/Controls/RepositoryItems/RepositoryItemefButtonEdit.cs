using DevExpress.Accessibility;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;

namespace efControls
{
    [UserRepositoryItem("RegisterefButtonEdit")]
    public class RepositoryItemefButtonEdit : RepositoryItemButtonEdit
    {
        public RepositoryItemefButtonEdit()
            : base()
        {
            Name = "efButtonEdit";
        }

        public static void RegisterefButtonEdit()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("efButtonEdit",
                                                       typeof(efButtonEdit),
                                                       typeof(RepositoryItemefButtonEdit),
                                                       typeof(ButtonEditViewInfo),
                                                       new ButtonEditPainter(),
                                                       true, null,
                                                       typeof(ButtonEditAccessible)));
        }

        public override string EditorTypeName
        {
            get { return "efButtonEdit"; }
        }
        //public override void CreateDefaultButton()
        //{
        //       base.CreateDefaultButton();
        //}
    }
}