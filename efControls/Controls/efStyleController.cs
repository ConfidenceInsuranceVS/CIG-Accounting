using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace efControls
{
    [ToolboxItem(true)]
    public partial class efStyleController : StyleController
    {
        public efStyleController()
        {
            InitializeComponent();

            AppearanceFocused.ForeColor = App.controlForecolor;
            AppearanceFocused.BackColor = App.controlBackcolor;
            AppearanceFocused.BorderColor = App.controlBordercolor;
            AppearanceFocused.Options.UseBorderColor = true;
            AppearanceFocused.Options.UseBackColor = true;
            AppearanceFocused.Options.UseForeColor = true;
        }
    }
}
