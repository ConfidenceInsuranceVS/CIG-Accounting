using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;

namespace efControls
{
    public static class Splash
    {
        public static void Show(this efBaseForm frm)
        {
            SplashScreenManager.ShowForm(frm, typeof(efProgressForm), false, false, false, SplashFormStartPosition.Manual, frm.getWaitFormLocation<efProgressForm>());
        }
        public static void SetCaption(string caption)
        {
            SplashScreenManager.Default.SendCommand(efProgressForm.SplashScreenCommand.SetCaption, caption);
        }
        public static void SetDescription(string description)
        {
            SplashScreenManager.Default.SendCommand(efProgressForm.SplashScreenCommand.SetDescription, description);
        }
        public static void SetMaximum(int max)
        {
            SplashScreenManager.Default.SendCommand(efProgressForm.SplashScreenCommand.SetMaximum, max);
        }
        public static void SetProgress(int count)
        {
            SplashScreenManager.Default.SendCommand(efProgressForm.SplashScreenCommand.SetProgress, count);
        }
        public static void Close()
        {
            SplashScreenManager.CloseForm(false);
        }
    }
}
