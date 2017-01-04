using DevExpress.XtraEditors;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace efControls
{
    public class Alert
    {
        //private static Enums.AlertIconType iconType;
        //private static int delay = 3000;
        //private static string alertTitle { get; set; }
        //private static string alertMessage { get; set; }
        public static void Show(string message)
        {
            show(Enums.AlertType.None, App.CompanyName, message, 2000);
        }
        public static void Show(string message, Enums.AlertType type)
        {
            show(type, App.CompanyName, message, 5000);//modified by samir UE-19/12/2016-1  value was 2000
        }
        public static void Show(string message, Enums.AlertType type, int timeout)
        {
            //
            show(type, App.CompanyName, message, timeout);
        }
        public static void Show(string message, string title, Enums.AlertType type)
        {
            //
            show(type, title, message, 5000);
        }
        public static void Show(string message, string title, Enums.AlertType type, int timeout)
        {
            //
            show(type, title, message, timeout);
        }
        private static void show(Enums.AlertType type, string title, string message, int timeout)
        {
            Image img = App.xFrm.imgAlert.Images["None"];
            App.xFrm.AlertControl.LookAndFeel.UseDefaultLookAndFeel = false;
            switch (type)
            {
                case Enums.AlertType.None:
                    App.xFrm.AlertControl.LookAndFeel.SkinMaskColor = Color.Green;
                    break;

                case Enums.AlertType.Critical:
                    App.xFrm.AlertControl.LookAndFeel.SkinMaskColor = Color.Red;
                    img = App.xFrm.imgAlert.Images["Critical"];
                    break;

                case Enums.AlertType.Warning:
                    App.xFrm.AlertControl.LookAndFeel.SkinMaskColor = Color.Orange;
                    img = App.xFrm.imgAlert.Images["Warning"];
                    break;

                case Enums.AlertType.Information:
                    App.xFrm.AlertControl.LookAndFeel.SkinMaskColor = Color.Blue;
                    img = App.xFrm.imgAlert.Images["Information"];
                    break;

                case Enums.AlertType.Help:
                    App.xFrm.AlertControl.LookAndFeel.SkinMaskColor = Color.DarkGray;
                    img = App.xFrm.imgAlert.Images["Help"];
                    break;

            }
            //
            App.xFrm.AlertControl.AutoFormDelay = timeout;
            App.xFrm.AlertControl.FormLocation = DevExpress.XtraBars.Alerter.AlertFormLocation.BottomRight;
            App.xFrm.AlertControl.FormShowingEffect = DevExpress.XtraBars.Alerter.AlertFormShowingEffect.SlideHorizontal;
            App.xFrm.AlertControl.Show(App.xFrm.FindForm(), title, message, img);
        }
        //
        public static void ShowMessage(string message)
        {
            XtraMessageBox.Show(message, App.Name, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void ShowException(Exception ex)
        {
            XtraMessageBox.Show(ex.ToString(), "Exception Occured", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Stop);
            Functions.LogException(ex.ToString());
        }
        public static DialogResult ShowDialogMessage(string message)
        {
            return XtraMessageBox.Show(message, App.Name, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
        public static DialogResult ShowDialogMessage(string message, MessageBoxButtons mbb, MessageBoxIcon mbi)
        {
            return XtraMessageBox.Show(message, App.Name, mbb, mbi);
        }
    }
}
