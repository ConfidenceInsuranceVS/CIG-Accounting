using DevExpress.Utils;
using DevExpress.Utils.Serializing;
using DevExpress.XtraGrid.Columns;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace efControls
{
    public class efGridColumn : GridColumn
    {
        [Category("xProperties"), Browsable(true)]
        public bool AlwaysDisabled { get; set; }

        [Category("xProperties"), Browsable(true)]
        public bool EditDisabled { get; set; }
        public efGridColumn()
        {
            AppearanceHeader.TextOptions.HAlignment = HorzAlignment.Center;
            AppearanceHeader.Options.UseTextOptions = true;

            OptionsColumn.AllowSort = DefaultBoolean.False;
            OptionsFilter.AutoFilterCondition = AutoFilterCondition.Contains;
        }
        string customDataValue = string.Empty;

        [XtraSerializableProperty()]
        public string CustomData
        {
            get { return customDataValue; }
            set { customDataValue = value; }
        }
        protected override void Assign(GridColumn column)
        {
            base.Assign(column);
            if (column is efGridColumn)
            {
                CustomData = ((efGridColumn)column).CustomData;
            }
        }
    }
}