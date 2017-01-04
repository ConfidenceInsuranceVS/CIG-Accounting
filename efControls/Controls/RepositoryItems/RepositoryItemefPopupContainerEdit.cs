using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using System.Drawing;

namespace efControls
{
    [UserRepositoryItem("RegisterefPopupContainerEdit")]
    public class RepositoryItemefPopupContainerEdit : RepositoryItemPopupContainerEdit
    {
        static RepositoryItemefPopupContainerEdit()
        {
            RegisterefPopupContainerEdit();
        }

        public RepositoryItemefPopupContainerEdit()
        {
        }

        public const string efPopupContainerEditName = "efPopupContainerEdit";

        public override string EditorTypeName
        {
            get
            {
                return efPopupContainerEditName;
            }
        }

        public static void RegisterefPopupContainerEdit()
        {
            var img = (Image )null;

            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(efPopupContainerEditName
                                                       , typeof(efPopupContainerEdit)
                                                       , typeof(RepositoryItemefPopupContainerEdit)
                                                       , typeof(PopupContainerEditViewInfo)
                                                       , new ButtonEditPainter()
                                                       , true
                                                       , img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                var source = item as RepositoryItemefPopupContainerEdit;
                if (source == null)
                {
                    return;
                }
            }
            finally
            {
                EndUpdate();
            }
        }

        private void InitializeComponent()
        {
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
        }
    }
}
