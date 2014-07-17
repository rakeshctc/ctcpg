using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Web;

namespace CTC_Latest_4._0.Helper
{
    public class sendSomething
    {
        #region Send Grid
        public static void SendGrid(string senderName, string senderEmail, string receiverEmails, string subject,
                                  string html)
        {
            {
                try
                {
                    MailMessage mailMsg = new MailMessage();

                    // To
                    mailMsg.To.Add(new MailAddress(receiverEmails, "Guest"));

                    // From
                    mailMsg.From = new MailAddress(senderEmail, senderName);

                    // Subject and multipart/alternative Body
                    mailMsg.Subject = subject;
                    //string text = "text body";
                    //mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Plain));
                    mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Html));

                    // Init mdtpClient and send
                    SmtpClient mdtpClient = new SmtpClient("mdtp.sendgrid.net", Convert.ToInt32(587));
                    System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("rakeshctc", "Rakesh@51");
                    mdtpClient.Credentials = credentials;

                    mdtpClient.Send(mailMsg);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
        #endregion Send Grid

        #region Send Ticket
        public static void sendTicket(string senderName, string senderEmail, string receiverEmails, string subject,
                                  string html)
        {
            {
                try
                {
                    MailMessage mailMsg = new MailMessage();

                    // To
                    mailMsg.To.Add(new MailAddress(receiverEmails, "Guest"));

                    // From
                    mailMsg.From = new MailAddress(senderEmail, senderName);

                    // Subject and multipart/alternative Body
                    mailMsg.Subject = subject;
                    //string text = "text body";
                    //mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Plain));
                    mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Html));

                    // Init mdtpClient and send
                    SmtpClient mdtpClient = new SmtpClient("sendgrid.net", Convert.ToInt32(587));
                    System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("rakeshctc", "Rakesh@51");
                    mdtpClient.Credentials = credentials;

                    mdtpClient.Send(mailMsg);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
        #endregion Send Ticket

        #region Send Msg
        public static void SendMsg(string phoneNumber, string msg)
        {
            try
            {
                //**Send masg to the participants who received the BIB**//
                {
                    {
                        HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("https://control.msg91.com/sendhttp.php?user=" + "softyathlete" + "&password=" + "rakesh@123" + "&mobiles=" + phoneNumber.Trim().ToString() + "&message='" + msg.Trim().ToString() + "'" + "&sender=CTCCTM&ignoreNdnc=4");

                        HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
                        System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
                        string responseString = respStreamReader.ReadToEnd();
                        respStreamReader.Close();
                        myResp.Close();
                    }
                }
            }
            catch (Exception ex)
            {

                //if ()
                {
                    //   SystemCrash(ex.Message, "Something Wrong With Send Message ", true);
                }
                // else
                {
                    //TODO: Log this error later.
                }
            }

        }
        #endregion Send Msg

        public static void SendMail(string senderName, string senderEmail, string receiverEmails, string subject,
                                 string body)
        {
            using (var mailMessage = new MailMessage())
            {
                // To
                mailMessage.To.Add(receiverEmails);

                // From
                mailMessage.From = new MailAddress(senderEmail, senderName);

                //Subject
                mailMessage.Subject = subject;

                //Body
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = true;

                //Send it
                DoWork(mailMessage);
            }
        }

        public static void DoWork(MailMessage mailMessage, bool fromException = false)
        {
            try
            {
                // Init mdtpClient and send
                using (
                    var mdtpClient = new SmtpClient("mdtp.gmail.com", 25)
                    {

                        Credentials =
                            new NetworkCredential("letsrun@chennaitrekkers.org", "Chennai@Trail"),
                        EnableSsl = true
                    })
                {
                    mdtpClient.Send(mailMessage);
                }
            }
            catch (Exception ex)
            {
                if (!fromException)
                {
                    SystemCrash(ex.Message, "Something Wrong With Send Mail @ DoWork", true);
                }
                else
                {
                    //TODO: Log this error later.
                }
            }
        }

        public static void SystemCrash(string ex, string where, bool fromException = false)
        {
            using (var mailMessage = new MailMessage())
            {
                // To
                mailMessage.To.Add("rakeshchandrasekar@gmail.com");

                // From
                mailMessage.From = new MailAddress("rakeshchandrasekar@gmail.com", "testing");

                // Subject and Body
                mailMessage.Subject = "System Crash @ " + where;
                mailMessage.Body = ex;
                DoWork(mailMessage, fromException);
            }
        }

        public static void SystemCrash(Exception ex, string where, string extraContent = null)
        {
            SystemCrash(
                ex.Message + Environment.NewLine + ex.InnerException + Environment.NewLine + ex.StackTrace +
                Environment.NewLine + extraContent, where);
        }
    }
}