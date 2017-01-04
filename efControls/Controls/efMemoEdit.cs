using System;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efMemoEdit : DevExpress.XtraEditors.MemoEdit
    {
        static efMemoEdit()
        {
            RepositoryItemefMemoEdit.RegisterefMemoEdit();
        }

        public efMemoEdit()
            : base()
        {
            InitializeComponent();
            DefaultState = Enums.ControlState.Default;
            DisplayType = Enums.DisplayType.Default;
            EnterMoveNextControl = false; // Added
            Properties.Leave += Properties_Leave;
            StyleController = App.styleController;
        }

        public bool toValidate()
        {
            bool result = true;
            try
            {
                if (Properties.ReadOnly | !((efBaseForm)FindForm()).isActiveForm()) { result = false; }
            }
            catch (Exception)
            {
                result = true;
            }
            return result;
        }

        public override string EditorTypeName
        {
            get
            {
                return "efMemoEdit";
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemefMemoEdit Properties
        {
            get
            {
                return base.Properties as RepositoryItemefMemoEdit;
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

        [Category("xProperties"),
        Browsable(true)]
        public Enums.DisplayType DisplayType { get; set; }

        [Category("xProperties"),
        Browsable(true)]
        public bool AllowLeadingSpace { get; set; }

        [Category("xProperties"),
        Browsable(true)]
        public string Information { get; set; }

        private void Properties_Leave(object sender, EventArgs e)
        {
            var ef = FindForm() as efBaseForm;
            if (ef != null)
            {
                if (!Properties.ReadOnly) { ef.ValidationProvider.Validate(this); }
            }
        }
    }
}
