using DevExpress.XtraEditors;
using System.Drawing;
using System.Windows.Forms;

namespace efControls
{
    public partial class efBackground : efBaseForm
    {
        private string back;

        public efBackground()
        {
            InitializeComponent();
        }

        protected override void OnShown(System.EventArgs e)
        {
            base.OnShown(e);   
            var back = XML.Read(App.PreferencesFile, "General", "Background");
            if (!string.IsNullOrEmpty(back))
            {
                peBackground.Image = new Bitmap(back);
                rgStyle.SelectedIndex = int.Parse(XML.Read(App.PreferencesFile, "General", "BackgroundStyle"));
                setStyle(rgStyle.SelectedIndex);
            }
        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }


        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (string.IsNullOrEmpty(back)) { return; }
            if (Alert.ShowDialogMessage("Save Background") == System.Windows.Forms.DialogResult.Yes)
            {
                XML.Write(App.PreferencesFile, "General", "Background", back);
                XML.Write(App.PreferencesFile, "General", "BackgroundStyle", rgStyle.SelectedIndex.ToString());
            }
            Close();
        }

        private void peBackground_DoubleClick(object sender, System.EventArgs e)
        {
            try
            {
                using (OpenFileDialog dlg = new OpenFileDialog())
                {
                    dlg.Title = "Open Image";
                    dlg.Filter = "png files (*.png)|*.png|jpg files (*.jpg)|*.jpg";

                    if (dlg.ShowDialog() == DialogResult.OK)
                    {
                        back = dlg.FileName;
                        peBackground.Image = ((efMainForm)ParentForm).BackgroundImage = new Bitmap(back);
                    }
                }
                setStyle(rgStyle.SelectedIndex);
            }
            catch (System.Exception)
            {
                Alert.Show(Enums.AlertType.ExceptionOccured);
            }
        }

        private void setStyle(int style)
        {
            switch (style)
            {
                case 0:
                    ((efMainForm)ParentForm).BackgroundImageLayout = ImageLayout.Tile;
                    break;
                case 1:
                    ((efMainForm)ParentForm).BackgroundImageLayout = ImageLayout.Center;
                    break;
                case 2:
                    ((efMainForm)ParentForm).BackgroundImageLayout = ImageLayout.Stretch;
                    break;
                case 3:
                    ((efMainForm)ParentForm).BackgroundImageLayout = ImageLayout.Zoom;
                    break;
            }
        }

        private void rgStyle_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            setStyle(rgStyle.SelectedIndex);
        }

        private void btnClear_Click(object sender, System.EventArgs e)
        {
            peBackground.Image = ((efMainForm)ParentForm).BackgroundImage = null;
            rgStyle.SelectedIndex = 0;
        }
    }
}
