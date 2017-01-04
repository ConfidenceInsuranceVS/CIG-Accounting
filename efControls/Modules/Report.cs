using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using DevExpress.XtraReports.UI;
using DevExpress.XtraSplashScreen;

namespace efControls
{
    public class Report
    {
        public static void show<T>(efMainForm mf, T rep, bool toprint)
            where T : XtraReport
        {
            try
            {
                rep.CreateDocument();
                if (rep.Pages.Count == 0) { throw new Exception("No Data Collected..."); }

                var rv = new efPrintPreview(mf);
                rv.documentViewer.PrintingSystem = rep.PrintingSystem;
                rv.ppReportName.Caption = string.Format("Report Preview : {0}", typeof(T).Name);
                //
                try
                {
                    var repPreference = XML.Read(App.LocalPreferencesFile, "Reports", typeof(T).Name);
                    if (!string.IsNullOrEmpty(repPreference))
                    {
                        var pref = repPreference.Split('|');
                        Size sz = new Size(int.Parse(pref[3]), int.Parse(pref[4]));
                        bool ls = bool.Parse(pref[5]);
                        rep.PrintingSystem.PageSettings.Assign(
                            new Margins(int.Parse(pref[6]), int.Parse(pref[7]), int.Parse(pref[8]), int.Parse(pref[9])),    
                            new Margins(0, 0, 0, 0),
                            (PaperKind)Enum.Parse(typeof(PaperKind), pref[2]),
                            sz,
                            ls);

                        rep.PrintingSystem.PageSettings.PrinterName = pref[0];
                        rep.PrintingSystem.PageSettings.PaperName = pref[1];

                        if (int.Parse(pref[10]) == 0)
                            rep.PrintingSystem.Document.ScaleFactor = float.Parse(pref[11]);
                        else
                            rep.PrintingSystem.Document.AutoFitToPagesWidth = int.Parse(pref[10]);
                    }
                }
                catch (Exception)
                {
                    Alert.Show("Please Save Your Report Again ...", Enums.AlertType.Information);
                }

                SplashScreenManager.CloseForm(false);
                if (toprint)
                    rep.PrintDialog();
                else
                {
                    foreach (string printer in PrinterSettings.InstalledPrinters) { rv.cboPrinters.Items.Add(printer); }
                    if (string.IsNullOrEmpty(rv.documentViewer.PrintingSystem.PageSettings.PrinterName))
                    {
                        var printerSettings = new PrinterSettings();
                        rv.beiPrinters.EditValue = printerSettings.PrinterName;
                    }
                    else
                    {
                        rv.beiPrinters.EditValue = rv.documentViewer.PrintingSystem.PageSettings.PrinterName;
                    }

                    rv.ShowDialog(mf);
                }
            }
            catch (Exception ex)
            {
                SplashScreenManager.CloseForm(false);
                Alert.Show(ex.Message, "Cannot Print ...", Enums.AlertType.Warning);
            }
        }

        public static void mail<T>(T rep, string recipient, string subject, string body) where T : XtraReport
        {
            rep.CreateDocument();
            MemoryStream ms = new MemoryStream();
            rep.ExportToPdf(ms);

            ms.Seek(0, SeekOrigin.Begin);

            Attachment att = new Attachment(ms, "VisaReport.pdf", "application/pdf");
            MailMessage mail = new MailMessage();
            mail.Attachments.Add(att);

            mail.From = new MailAddress("info@intermedco.com");
            mail.To.Add(new MailAddress(recipient, "Intermed Visa"));
            mail.CC.Add(new MailAddress("medicalclaims@ciglb.com", "Intermed Visa Sent"));

            mail.Subject = subject;
            mail.Body = body;
            mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnSuccess;
            
            SmtpClient smtp = new SmtpClient()
            {
                Host = "smtpout.secureserver.net",
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential("info@intermedco.com", "svm@!l.info-")
            };
            
            try
            {
                smtp.Send(mail);
            }
            catch (Exception ex)
            {
                Alert.ShowMessage(ex.Message);
            }
        }

    }
}
