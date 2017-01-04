using DevExpress.XtraBars.Helpers;
using DevExpress.XtraEditors;
using System.Drawing;
using System.Windows.Forms;

namespace efControls
{
    public partial class efPreferences : efBaseForm
    {
        private string sVar;

        public efPreferences()
        {
            InitializeComponent();
            SkinHelper.InitSkinGallery(gcSkins, true);
            gcSkins.Gallery.ItemImageLayout = DevExpress.Utils.Drawing.ImageLayoutMode.ZoomInside;
            gcSkins.Gallery.ImageSize = new Size(32, 32);

            sVar = XML.Read(App.PreferencesFile, "Users", App.UserCode, "Font");
            if (!string.IsNullOrEmpty(sVar))
            {
                cmbFonts.EditValue = sVar;
            }
            else
            {
                cmbFonts.EditValue = "Tahoma";
            }
            sVar = XML.Read(App.PreferencesFile, "Users", App.UserCode, "FontSize");
            if (!string.IsNullOrEmpty(sVar))
            {
                spnSize.EditValue = int.Parse(sVar);
            }
            else
            {
                spnSize.EditValue = 8;
            }
            sVar = XML.Read(App.PreferencesFile, "Users", App.UserCode, "FontStyle");
            if (!string.IsNullOrEmpty(sVar))
            {
                chkBold.Checked = bool.Parse(sVar);
            }
            else
            {
                chkBold.Checked = false;
            }
            sVar = XML.Read(App.PreferencesFile, "Users", App.UserCode, "BackColorRed");
            if (!string.IsNullOrEmpty(sVar))
            {
                cpBackcolor.EditValue = int.Parse(sVar);
            }
            sVar = XML.Read(App.PreferencesFile, "Users", App.UserCode, "ForeColorRed");
            if (!string.IsNullOrEmpty(sVar))
            {
                cpForecolor.EditValue = int.Parse(sVar);
            }
            sVar = XML.Read(App.PreferencesFile, "Users", App.UserCode, "BorderColorRed");
            if (!string.IsNullOrEmpty(sVar))
            {
                cpBordercolor.EditValue = int.Parse(sVar);
            }
        }
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            var bc = cpBackcolor.Color.ToArgb();
            var fc = cpForecolor.Color.ToArgb();
            var bd = cpBordercolor.Color.ToArgb();

            if (Alert.ShowDialogMessage("Save Preferences") == DialogResult.Yes)
            {
                XML.Write(App.PreferencesFile, "Users", App.UserCode, "Style", DevExpress.LookAndFeel.UserLookAndFeel.Default.ActiveSkinName);
                XML.Write(App.PreferencesFile, "Users", App.UserCode, "Font", cmbFonts.EditValue.ToString());
                XML.Write(App.PreferencesFile, "Users", App.UserCode, "FontSize", spnSize.EditValue.ToString());
                XML.Write(App.PreferencesFile, "Users", App.UserCode, "FontStyle", chkBold.Checked ? "true" : "false");

                XML.Write(App.PreferencesFile, "Users", App.UserCode, "BackColorRed", bc.ToString());
                XML.Write(App.PreferencesFile, "Users", App.UserCode, "ForeColorRed", fc.ToString());
                XML.Write(App.PreferencesFile, "Users", App.UserCode, "BorderColorRed", bd.ToString());

                DevExpress.Utils.AppearanceObjectEx.DefaultFont = App.getFonts();
            }
            Close();
        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
