using System;
using System.Collections.Generic;
using System.Linq;

namespace efControls
{
    public partial class bfPDF : DevExpress.XtraEditors.XtraUserControl
    {
        public bfPDF()
        {
            InitializeComponent();
            //pdfViewer.LoadDocument(@"c:\imp_data\output.pdf");
        }

        private void bbiEmail_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            dynamic app = Activator.CreateInstance(Type.GetTypeFromProgID("Outlook.Application"));
            dynamic email = app.CreateItem(0);
            email.Subject = "Subject";
            email.Body = "Text";
            email.To = "email@email.com";
            email.Save();
            email.Attachments.Add(pdfViewer.DocumentFilePath);

            email.Display(true); //use this to display the Outlook-window
            //email.Send(); //use this to send the email directly        
        }
    }
}
