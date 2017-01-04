using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.XtraEditors;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efPopupContainerEdit : PopupContainerEdit
    {
        static efPopupContainerEdit()
        {
            RepositoryItemefPopupContainerEdit.RegisterefPopupContainerEdit();
        }

        public efPopupContainerEdit()
        {
            DefaultState = Enums.ControlState.Default;
            EnterMoveNextControl = true;
        }

        public override string EditorTypeName
        {
            get
            {
                return RepositoryItemefPopupContainerEdit.efPopupContainerEditName;
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemefPopupContainerEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemefPopupContainerEdit;
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            Enabled = true;

            var ef = FindForm() as efBaseForm;
            Properties.ReadOnly = Functions.setControlState(DefaultState, ef == null ? Enums.State.Edit : ef.xState);
        }

        [Category("xProperties")]
        public Enums.ControlState DefaultState { get; set; }
    }
}
