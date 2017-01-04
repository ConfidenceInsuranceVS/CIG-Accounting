using DevExpress.Accessibility;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System;

namespace efControls
{
    [UserRepositoryItem("RegisterefUnboundComboBox")]
    public class RepositoryItemefUnboundComboBox : RepositoryItemComboBox
    {
        public RepositoryItemefUnboundComboBox()
            : base()
        {
            Name = "efUnboundComboBox";
        }

        public static void RegisterefUnboundComboBox()
        {
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo("efUnboundComboBox",
                                                       typeof(efUnboundComboBox),
                                                       typeof(RepositoryItemefUnboundComboBox),
                                                       typeof(ComboBoxViewInfo),
                                                       new ButtonEditPainter(),
                                                       true, null,
                                                       typeof(ButtonEditAccessible)));
        }

        public override string EditorTypeName
        {
            get
            {
                return "efUnboundComboBox";
            }
        }
    }
}
