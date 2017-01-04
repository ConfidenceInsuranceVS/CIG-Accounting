using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace efControls
{
    public class Resolution
    {
        public static void Change(int a, int b)
        {
            var iWidth = a;
            var iHeight = b;

            var dm = new DevMode();
            dm.dmDeviceName = new String (new char[32]);
            dm.dmFormName = new String (new char[32]);
            dm.dmSize = (short)Marshal.SizeOf (dm);

            if (0 != User32.EnumDisplaySettings (null, User32.ENUM_CURRENT_SETTINGS, ref dm))
            {
                dm.dmPelsWidth = iWidth;
                dm.dmPelsHeight = iHeight;

                var iRet = User32.ChangeDisplaySettings (ref dm, User32.CDS_TEST);

                if (iRet == User32.DISP_CHANGE_FAILED)
                {
                    Alert.ShowMessage("Unable to process your request");
                    Alert.ShowDialogMessage("Description: Unable To Process Your Request. Sorry For This Inconvenience.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    iRet = User32.ChangeDisplaySettings (ref dm, User32.CDS_UPDATEREGISTRY);

                    switch (iRet)
                    {
                        case User32.DISP_CHANGE_SUCCESSFUL:
                            break;
                        case User32.DISP_CHANGE_RESTART:
                            Alert.ShowDialogMessage("Description: You Need To Reboot For The Change To Happen.\n If You Feel Any Problem After Rebooting Your Machine\nThen Try To Change Resolution In Safe Mode.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                        default:
                            Alert.ShowDialogMessage("Description: Failed To Change The Resolution.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
            }
        }
    }
}
