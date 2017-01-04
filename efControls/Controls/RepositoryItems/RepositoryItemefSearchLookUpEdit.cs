using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraGrid.Editors;
using System.Drawing;

namespace efControls
{
    [UserRepositoryItem("RegisterefSearchLookUpEdit")]
    public class RepositoryItemefSearchLookUpEdit : RepositoryItemSearchLookUpEdit
    {
        static RepositoryItemefSearchLookUpEdit()
        {
            RegisterefSearchLookUpEdit();
        }

        public RepositoryItemefSearchLookUpEdit() 
        {
        }

        public const string efSearchLookUpEditName = "efSearchLookUpEdit";

        public override string EditorTypeName
        {
            get { return efSearchLookUpEditName; }
        }
        public SearchEditLookUpPopup LookUpPopupForm
        {
            get { return LookUpPopup; }
        }
        public static void RegisterefSearchLookUpEdit()
        {
            var img = (Image )null;

            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(efSearchLookUpEditName
                                                       , typeof(efSearchLookUpEdit)
                                                       , typeof(RepositoryItemefSearchLookUpEdit)
                                                       , typeof(SearchLookUpEditBaseViewInfo)
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
                var source = item as RepositoryItemefSearchLookUpEdit;
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
