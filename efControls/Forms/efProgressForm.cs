using System;
using System.Collections.Generic;
using DevExpress.XtraWaitForm;
using DevExpress.XtraSplashScreen;

namespace efControls
{
    public partial class efProgressForm : WaitForm
    {
        public efProgressForm()
        {
            InitializeComponent();
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
            SplashScreenCommand command = (SplashScreenCommand)cmd;
            switch (command)
            {
                case SplashScreenCommand.SetProgress:
                    int pos = (int)arg;
                    progressBarControl.Position = pos;
                    break;
                case SplashScreenCommand.SetMaximum:
                    Height = 105;
                    progressBarControl.Properties.Maximum = (int)arg;
                    break;
                case SplashScreenCommand.SetCaption:
                    progressPanel.Caption = (string)arg;
                    break;
                case SplashScreenCommand.SetDescription:
                    progressPanel.Description = (string)arg;
                    break;
            }
        }
        public enum SplashScreenCommand
        {
            SetProgress, SetMaximum, SetCaption, SetDescription
        }

    }
}
