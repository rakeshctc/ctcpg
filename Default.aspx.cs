using CTC_Latest_4._0.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CTC_Final
{
    public partial class Default : System.Web.UI.Page
    {
        //SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        UsingFunctions _usingFunctions = new UsingFunctions();

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!IsPostBack)
            //{
            //    Session.Abandon();
            //}

            //if (Session["email"] != null)
            //{
            //    Session.Abandon();
            //}
        }

        private void MessageBox(string message, string title = "title")
        {
            ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), title, "alert('" + message + "');", true);
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            //string selectQuerySuccess = "select Payment from Register_1 where Payment='Success' and Email='" + txtGetEmail.Text.Trim() + "'";
            //SqlCommand cmdSuccess = new SqlCommand(selectQuerySuccess, conn);
            //SqlDataAdapter aDapSuccess = new SqlDataAdapter(cmdSuccess);
            //DataTable dtSuccess = new DataTable();
            //aDapSuccess.Fill(dtSuccess);
            //int main = dtSuccess.Rows.Count;

            //Session["email"] = txtGetEmail.Text.Trim();

            //if (main == 0)
            //{
            //    string selectQueryCode = "select * from Register_1 where ConfirmationCode !='' and Email='" + txtGetEmail.Text.Trim() + "'";
            //    SqlCommand cmdCode = new SqlCommand(selectQueryCode, conn);
            //    SqlDataAdapter aDapCode = new SqlDataAdapter(cmdCode);
            //    DataTable dtCode = new DataTable();
            //    aDapCode.Fill(dtCode);

            //    int codeCount = dtCode.Rows.Count;

            //    string selectQueryCheckEmail = "select Email from Register_1 where Email='" + txtGetEmail.Text.Trim() + "'";
            //    SqlCommand cmdCheckEmail = new SqlCommand(selectQueryCheckEmail, conn);
            //    SqlDataAdapter aDapCheckEmail = new SqlDataAdapter(cmdCheckEmail);
            //    DataTable dtCheckEmail = new DataTable();
            //    aDapCheckEmail.Fill(dtCheckEmail);

            //    int emailExist = dtCheckEmail.Rows.Count;

            //    if (emailExist == 0)
            //    {
            //        string GUID = Guid.NewGuid().ToString();
            //        ViewState["GUID"] = GUID;
            //    }
            //    else if (emailExist == 1)
            //    {
            //        string GUID = getGuid(txtGetEmail.Text.Trim());
            //        ViewState["GUID"] = GUID;
            //    }
            //    else if (emailExist > 1)
            //    {
            //    }

            //    if (codeCount == 0)
            //    {
            //        Guid g = Guid.NewGuid();
            //        string random = g.ToString();
            //        string code = random.Substring(0, 6);

            //        string paymentPending = "Pending";

            //        Session["guid"] = ViewState["GUID"].ToString().Trim();

            //        int isActivated = 0;

            //        _usingFunctions.GetIP(txtName.Text.Trim(), txtGetEmail.Text.Trim(), ViewState["GUID"].ToString().Trim(), code, isActivated.ToString(), paymentPending);

            //        Session["Check"] = "new";

            //        Session["emailConfirmation"] = "true";
            //        Response.Redirect("emailConfirmation.aspx");
            //    }
            //    else
            //    {
            //        try
            //        {
            //            string selectQueryActive = "select * from Register_1 where isActivated ='0' and Email='" + txtGetEmail.Text.Trim() + "'";
            //            SqlCommand cmdActive = new SqlCommand(selectQueryActive, conn);
            //            SqlDataAdapter aDapActive = new SqlDataAdapter(cmdActive);
            //            DataTable dtActive = new DataTable();
            //            aDapActive.Fill(dtActive);

            //            int activeCount = dtActive.Rows.Count;

            //            if (activeCount == 0)
            //            {
            //                Session["guid"] = ViewState["GUID"].ToString().Trim();
            //                Session["Check"] = "nothing";
            //                Response.Redirect("emailConfirmation.aspx", false);
            //                Session["emailConfirmation"] = "true";
            //            }
            //            else
            //            {
            //                Session["guid"] = ViewState["GUID"].ToString().Trim();
            //                Session["Check"] = "goAhead";
            //                Response.Redirect("emailConfirmation.aspx", false);
            //                Session["emailConfirmation"] = "true";
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            throw;
            //        }
            //    }
            //}
            //else
            //{
            //    MessageBox("Email Id Already Exist, Enter another email address");
            //}
            
        }

        //#region getGuid

        //string getGuid(string email)
        //{
        //    string selectQuery = "select GUID from Register_1 where Email='" + email.Trim() + "'";
        //    SqlCommand cmd = new SqlCommand(selectQuery, conn);
        //    SqlDataAdapter aDap = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    aDap.Fill(dt);

        //    string guid = dt.Rows[0][0].ToString();
        //    return guid;
        //}

        //#endregion getGuid

        //#region Send Grid
        //public static void SendGrid(string senderName, string senderEmail, string receiverEmails, string subject,
        //                          string html)
        //{
        //    {
        //        try
        //        {
        //            MailMessage mailMsg = new MailMessage();

        //            // To
        //            mailMsg.To.Add(new MailAddress(receiverEmails, "Guest"));

        //            // From
        //            mailMsg.From = new MailAddress(senderEmail, senderName);

        //            // Subject and multipart/alternative Body
        //            mailMsg.Subject = subject;
        //            //string text = "text body";
        //            //mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Plain));
        //            mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Html));

        //            // Init mdtpClient and send
        //            SmtpClient mdtpClient = new SmtpClient("smtp.sendgrid.net", Convert.ToInt32(587));
        //            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("rakeshctc", "Rakesh@51");
        //            mdtpClient.Credentials = credentials;

        //            mdtpClient.Send(mailMsg);
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }

        //    }

        //}
        //#endregion Send Grid

        //#region MailJet

        //public static void SendMailJet()
        //{
        //    {
        //        String APIKey = "84fffc1f2524749b250bd7b6b308025c";
        //        String SecretKey = "92b0ca0afe613bb1f71d6c859859cf6f";
        //        String From = "you@example.com";
        //        String To = "rakeshchandrasekar@yahoo.com.com";

        //        MailMessage msg = new MailMessage();

        //        msg.From = new MailAddress(From);

        //        msg.To.Add(new MailAddress(To));

        //        msg.Subject = "Your mail from Mailjet";
        //        msg.Body = "Your mail from Mailjet, sent by C#.";

        //        SmtpClient client = new SmtpClient("in.mailjet.com", 465);
        //        client.EnableSsl = true;
        //        client.Credentials = new NetworkCredential(APIKey, SecretKey);

        //        client.Send(msg);
        //    }
        //}

        //#endregion MailJet

        //#region Send Ticket
        //public static void sendTicket(string senderName, string senderEmail, string receiverEmails, string subject,
        //                          string html)
        //{
        //    {
        //        try
        //        {
        //            MailMessage mailMsg = new MailMessage();

        //            // To
        //            mailMsg.To.Add(new MailAddress(receiverEmails, "Guest"));

        //            // From
        //            mailMsg.From = new MailAddress(senderEmail, senderName);

        //            // Subject and multipart/alternative Body
        //            mailMsg.Subject = subject;
        //            //string text = "text body";
        //            //mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Plain));
        //            mailMsg.AlternateViews.Add(AlternateView.CreateAlternateViewFromString(html, null, MediaTypeNames.Text.Html));

        //            // Init mdtpClient and send
        //            SmtpClient mdtpClient = new SmtpClient("sendgrid.net", Convert.ToInt32(587));
        //            System.Net.NetworkCredential credentials = new System.Net.NetworkCredential("rakeshctc", "Rakesh@51");
        //            mdtpClient.Credentials = credentials;

        //            mdtpClient.Send(mailMsg);
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine(ex.Message);
        //        }

        //    }

        //}
        //#endregion Send Ticket

        //#region Send Msg
        //public static void SendMsg(string phoneNumber, string msg)
        //{
        //    try
        //    {
        //        //**Send masg to the participants who received the BIB**//
        //        {
        //            {
        //                //HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("https://control.msg91.com/sendhttp.php?user=" + "softyathlete" + "&password=" + "rakesh@123" + "&mobiles=" + phoneNumber.Trim().ToString() + "&message='" + msg.Trim().ToString() + "'" + "&sender=CTCCTM&ignoreNdnc=4");
        //                HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("https://control.msg91.com/sendhttp.php?user=" + "softyathlete" + "&password=" + "rakesh@123" + "&mobiles=" + phoneNumber.Trim().ToString() + "&message='" + msg.Trim().ToString() + "'" + "&sender=CTCCTM&ignoreNdnc=4");

        //                HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
        //                System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
        //                string responseString = respStreamReader.ReadToEnd();
        //                respStreamReader.Close();
        //                myResp.Close();
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        //if ()
        //        {
        //            //   SystemCrash(ex.Message, "Something Wrong With Send Message ", true);
        //        }
        //        // else
        //        {
        //            //TODO: Log this error later.
        //        }
        //    }

        //}
        //#endregion Send Msg
    }
}