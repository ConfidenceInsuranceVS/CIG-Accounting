using DevExpress.XtraEditors;
using System;
using System.ComponentModel;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efSpinner : SpinEdit, IControl
    {
        static efSpinner()
        {
            RepositoryItemefSpinner.RegisterefSpinner();
        }

        public efSpinner()
        {
            InitializeComponent();
            DefaultState = Enums.ControlState.Default;
            DisplayType = Enums.DisplayType.Default;
            EnterMoveNextControl = true;
            Properties.Leave += Properties_Leave;
            Properties.EditMask = "f0";
            StyleController = App.styleController;
        }

        public override string EditorTypeName
        {
            get
            {
                return "efSpinner";
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public new RepositoryItemefSpinner Properties
        {
            get
            {
                return base.Properties as RepositoryItemefSpinner;
            }
        }

        public override void Refresh()
        {
            base.Refresh();
            Enabled = true;

            var ef = FindForm() as efBaseForm;
            Properties.ReadOnly = Functions.setControlState(DefaultState, ef == null ? Enums.State.Edit : ef.xState);
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
