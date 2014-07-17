using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net.Mime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CTC_Latest_4._0.Helper;
using System.Data.SqlClient;
using System.Configuration;

namespace CTC_Final
{
    public partial class Support : System.Web.UI.Page
    {

        Gujaals _gujaals = new Gujaals();
        CTC_Latest_4._0.DBRepository.DBRepository _dbRepository = new CTC_Latest_4._0.DBRepository.DBRepository();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmitEnquiry_Click(object sender, EventArgs e)
        {
            divEnquiry.Visible = false;
            divMessage.Visible = true;

            string htmlContent = "<p> Hi Admin,</p><p>There is a New Enquiry.</p><p>Name :" + txtEName.Text.Trim() + "</p><p>	Email :" + txtEEmail.Text.Trim() + "</p><p>Phone :" + txtEPhone.Text.Trim() + "</p><p>Message :" + txtEMain.Text.Trim() + "</p><p>&nbsp;</p><p>Regards</p><p>CTM Automated Mail Service.</p><p>&nbsp;</p>";
            SendEnquiry(txtEName.Text.Trim(), txtEEmail.Text.Trim(), "", txtESubject.Text.Trim(), htmlContent);
            _dbRepository.InsertEmailQuery(txtESubject.Text.Trim(),txtEMain.Text.Trim(), txtEName.Text.Trim(), txtEPhone.Text.Trim(), txtEEmail.Text.Trim());
        }

        #region Send Enquiry
        public static void SendEnquiry(string senderName, string senderEmail, string receiverEmails, string subject,
                                  string html)
        {
            {
                try
                {
                    MailMessage mailMsg = new MailMessage();

                    // To
                    mailMsg.To.Add(new MailAddress("CTM@chennaitrekkers.org", "Admin"));
                    mailMsg.CC.Add(new MailAddress("rakeshchandrasekar@gmail.com", "Rakesh"));
                    mailMsg.CC.Add(new MailAddress("nobal20@gmail.com", "Nobal"));


                    // From
                    mailMsg.From = new MailAddress("letsrun@chennaitrekkers.org", senderName);

                    // Subject and multipart/alternative Body

                    string addSub = "CTM2014-Enquiry" + subject;

                    mailMsg.Subject = addSub;
                    //string text = "text body";
                    //mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Plain));
                    mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Html));

                    // Init mdtpClient and send
                    SmtpClient mdtpClient = new SmtpClient("smtp.gmail.com", Convert.ToInt32(587));
                    mdtpClient.EnableSsl = true;
                    System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("letsrun@chennaitrekkers.org", "Chennai@Trail");
                    mdtpClient.Credentials = credentials;

                    mdtpClient.Send(mailMsg);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }

        }
        #endregion Send Enquiry


    }
}