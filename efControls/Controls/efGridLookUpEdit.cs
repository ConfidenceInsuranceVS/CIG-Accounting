using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Drawing;
using DevExpress.XtraEditors.Registrator;
using DevExpress.XtraEditors.Repository;
using DevExpress.XtraEditors.ViewInfo;
using DevExpress.XtraEditors.Popup;

namespace efControls
{
    [UserRepositoryItem("RegisterefGridLookUpEdit")]
    public class RepositoryItemefGridLookUpEdit : RepositoryItemGridLookUpEdit
    {
        static RepositoryItemefGridLookUpEdit()
        {
            RegisterefGridLookUpEdit();
        }

        public const string CustomEditName = "efGridLookUpEdit";

        public RepositoryItemefGridLookUpEdit()
        {
        }

        public override string EditorTypeName
        {
            get
            {
                return CustomEditName;
            }
        }

        public static void RegisterefGridLookUpEdit()
        {
            Image img = null;
            EditorRegistrationInfo.Default.Editors.Add(new EditorClassInfo(CustomEditName, typeof(efGridLookUpEdit), typeof(RepositoryItemefGridLookUpEdit), typeof(efGridLookUpEditViewInfo), new efGridLookUpEditPainter(), true, img));
        }

        public override void Assign(RepositoryItem item)
        {
            BeginUpdate();
            try
            {
                base.Assign(item);
                RepositoryItemefGridLookUpEdit source = item as RepositoryItemefGridLookUpEdit;
                if (source == null) return;
                //
            }
            finally
            {
                EndUpdate();
            }
        }
    }

    [ToolboxItem(true)]
    public class efGridLookUpEdit : GridLookUpEdit, IControl
    {
        [Category("xProperties")]
        public Enums.ControlState DefaultState { get; set; }

        [Category("xProperties"), Browsable(true)]
        public int DropdownWidth { get; set; }
        static efGridLookUpEdit()
        {
            RepositoryItemefGridLookUpEdit.RegisterefGridLookUpEdit();
        }
        public efGridLookUpEdit()
        {
            DefaultState = Enums.ControlState.Default;
            EnterMoveNextControl = true;
            Properties.Leave += efGridLookUpEdit_Leave;
            Properties.QueryPopUp += Properties_QueryPopUp;
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            Properties.View.OptionsView.ShowIndicator = false;
            Properties.View.OptionsView.EnableAppearanceOddRow = true;
            Properties.View.OptionsView.ShowAutoFilterRow = true;
            Properties.View.OptionsView.ShowColumnHeaders = true;
            Properties.View.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.False;
            Properties.View.OptionsFilter.AllowFilterEditor = false;
            Properties.View.OptionsFind.AllowFindPanel = false;
            Properties.View.OptionsFind.ShowClearButton = false;
            Properties.View.OptionsFind.ShowCloseButton = false;
            Properties.View.OptionsFind.ShowFindButton = false;
            Properties.View.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            Properties.View.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            Properties.View.OptionsCustomization.AllowColumnMoving = false;
            Properties.View.OptionsCustomization.AllowColumnResizing = false;
            Properties.View.OptionsCustomization.AllowFilter = false;
            Properties.View.OptionsCustomization.AllowRowSizing = false;
        }
        protected override void Refresh(bool resetCache)
        {
            base.Refresh(resetCache);
            Enabled = true;

            var ef = FindForm() as efBaseForm;
            Properties.ReadOnly = Functions.setControlState(DefaultState, ef == null ? Enums.State.Edit : ef.xState);
        }
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemefGridLookUpEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemefGridLookUpEdit;
            }
        }
        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemefGridLookUpEdit.CustomEditName;
            }
        }
        protected override PopupBaseForm CreatePopupForm()
        {
            return new efGridLookUpEditPopupForm(this);
        }
        private void efGridLookUpEdit_Leave(object sender, EventArgs e)
        {
            var ef = FindForm() as efBaseForm;
            if (ef != null)
            {
                if (!Properties.ReadOnly) { ef.ValidationProvider.Validate(this); }
            }
        }
        void Properties_QueryPopUp(object sender, CancelEventArgs e)
        {
            GridLookUpEdit editor = (GridLookUpEdit)sender;
            RepositoryItemGridLookUpEdit properties = editor.Properties;
            properties.PopupFormSize = new Size(DropdownWidth == 0 ? editor.Width : DropdownWidth, properties.PopupFormSize.Height);
        }
    }

    public class efGridLookUpEditViewInfo : GridLookUpEditBaseViewInfo
    {
        public efGridLookUpEditViewInfo(RepositoryItem item) : base(item)
        {
        }
    }

    public class efGridLookUpEditPainter : ButtonEditPainter
    {
        public efGridLookUpEditPainter()
        {
        }
    }

    public class efGridLookUpEditPopupForm : PopupGridLookUpEditForm
    {
        public efGridLookUpEditPopupForm(efGridLookUpEdit ownerEdit) : base(ownerEdit)
        {
        }
    }
}
