using CTC_Latest_4._0.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CTC_Final
{
    public partial class Ticket : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        CTC_Latest_4._0.DBRepository.DBRepository _dbRepository = new CTC_Latest_4._0.DBRepository.DBRepository();
        Gujaals _gujaals = new Gujaals();

        private void MessageBox(string message, string title = "title")
        {
            ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), title, "alert('" + message + "');", true);
        }

        protected void Page_Load(object sender, EventArgs e)
        {

           

            if ((Session["incDe"] == null))
            {
                MessageBox("Your Particiaption has confirmed and Check you email for your Particiaption ticket");
                Response.Redirect("Default.aspx");
            }
            else
            {

               // string goTicket = Session["Ticket"].ToString();
               // string category = Session["Category"].ToString();

                string email = Session["email"].ToString();
                //string guid = Session["guid"].ToString();
                //if (goTicket == "goTicket")
                {
                    string selectQuery = "select name,age,Phone,email,bibnumber,category,PaymentFinish_id from allCategory where email='" + email + "' ";
                    SqlCommand cmd = new SqlCommand(selectQuery, conn);
                    SqlDataAdapter dAdap = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    dAdap.Fill(dt);

                    string emailTicket = dt.Rows[0][3].ToString();

                    string name = dt.Rows[0][0].ToString();
                    string age = dt.Rows[0][1].ToString();
                    string phoneTicket = dt.Rows[0][2].ToString();
                    string bibNumberTicket = dt.Rows[0][4].ToString();
                    string categoryTicket = dt.Rows[0][5].ToString();
                    string ticketNumberTicket = dt.Rows[0][6].ToString();

                    lblDisPlayName1.Text = name;
                    lblDisPlayName.Text = name;
                    lblDisPlayEmail.Text = emailTicket;
                    lblDisPlayAge.Text = age;
                    lblDisPlayPhone.Text = phoneTicket;
                    lblDisPlayBibNumber.Text = bibNumberTicket;
                    lblDisPlayCategory.Text = categoryTicket;
                    lblDisPlayTicketNumber.Text = ticketNumberTicket;
                    GenerateBarCode(ticketNumberTicket);

                    string barCode = ticketNumberTicket;
                    System.Web.UI.WebControls.Image imgBarCode = new System.Web.UI.WebControls.Image();
                    using (Bitmap bitMap = new Bitmap(barCode.Length * 40, 80))
                    {
                        using (Graphics graphics = Graphics.FromImage(bitMap))
                        {
                            Font oFont = new Font("IDAutomationHC39M", 16);
                            PointF point = new PointF(2f, 2f);
                            SolidBrush blackBrush = new SolidBrush(Color.Black);
                            SolidBrush whiteBrush = new SolidBrush(Color.White);
                            graphics.FillRectangle(whiteBrush, 0, 0, bitMap.Width, bitMap.Height);
                            graphics.DrawString("*" + barCode + "*", oFont, blackBrush, point);
                        }
                        using (MemoryStream ms = new MemoryStream())
                        {
                            bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                            byte[] byteImage = ms.ToArray();

                            Convert.ToBase64String(byteImage);
                            imgBarCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
                            imgBarcodePic.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
                        }
                        //PlaceHolder1.Controls.Add(imgBarCode);
                    }

                    string sendTicket = @"<div style=" + "\"background-color:#EEE;width:100%;margin:0px; padding:0px\"" + ">" + "<div style=" + "\"padding:20px;\"" + ">" + "<br />" + "<div style=" + "\"padding:8px;background-color:#FFF;-moz-border-radius:7px;-webkit-border-radius:7px;\"" + ">" + "<img alt=" + "\"Chennai Trekking Club\"" + "src=" + "\"http://upload.wikimedia.org/wikipedia/en/0/04/Chennai_Trekking_Club.jpg\"" + "style=" + "\"width: 100px; height: 100px; float: left;\"" + "/><h1><span style=" + "\"color:#ff0000;" + ">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; Ticket Confirmation &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</span>&nbsp; &nbsp;&nbsp;<img alt=" + "\"CTC\"" + "src=" + "\"https://m.ak.fbcdn.net/scontent-a.xx/hphotos-ash3/t1.0-9/944214_178036385699303_1755946111_n.jpg\"" + "style=" + "\"width: 75px; height: 29px;\"" + "/>&nbsp;&nbsp;</h1><h1>&nbsp; &nbsp; &nbsp; &nbsp;Chennai Trail Marathon 2014</h1><hr /><p>&nbsp; &nbsp;<span style=" + "\"color: rgb(255, 255, 224); font-family: georgia, serif; font-size: 18px;" + "\">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;</span><span style=" + "\"color: rgb(255, 255, 224); font-family: georgia, serif; font-size: 14px;\"" + ">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;</span></p><div style=" + "\" color:#848484\"" + "><p>Dear Participant,</p><p>This is to confirm your participation for Chennai Trail Marathon.</p><p><u><strong>Details for your participation for the Event.</strong></u></p><p>Name : <strong>" + name + "</strong></p><p>Age: <strong>" + age + "</strong></p><p>Phone: <strong>" + phoneTicket + "</strong></p><p>Email: <strong>" + emailTicket + "</strong></p><p>Bib Number: <strong>" + bibNumberTicket + "</strong></p><p>Category : <strong>" + categoryTicket + "</strong></p><p>Ticket Number: <strong>" + ticketNumberTicket + "</strong></p><p>&nbsp;</p><hr /><p>	<u><strong>Terms and Conditions:</strong></u></p><p>&nbsp;</p><div>Please choose the event carefully, confirmed registrations are non-refundable, non-transferable and cannot be modified. Provide us with a secure email address that you can access regularly, as this willbe our primary means of contacting you during the run up to the event.</div><div>&nbsp;</div><div>Users of email services that offer filtering / blocking of messages from unknown email address shouldadd letsrun@chennaitrekkers.org to their address list.</div><div>&nbsp;</div><div>Any notice sent to the email address registered with the Organizers shall be deemed as received by</div><div>the runners.</div><div>&nbsp;</div><div>Please fill out only those fields that are necessary for mailing purposes. Do not provide redundant data in multiple fields (i.e., do not list the same data for city, province and country), as this will only complicate our ability to contact you, if necessary.</div><div>&nbsp;</div><div>You are aware that running long distance running is an extreme sport and can be injurious to body and health. You take full responsibility for participating in the Chennai Trekking Club Trial Marathon 2013 and do not hold the organizing committee of Chennai Trekking Club Trial Marathon Organizing Committee ,Chennai Trekking Club other organizing persons or entities responsible for any injury or accident.</div><div>&nbsp;</div><div>You shall consult your physician and undergo complete medical examination to assess your suitability to participate in the event.</div><div>&nbsp;</div><div>You also assume all risks associated with participating in this event including, but not limited to, falls, contact with other participants, the effects of the weather, including high heat or humidity, traffic and the condition of the road, arson or terrorist threats and all other risks associated with a public event.</div><div>&nbsp;</div><div>You agree that Chennai Trekking Club Trial Marathon Organizing Committee, Chennai Trekking Club and associated companies or entities that organize the run shall not be liable for any loss, damage, illness or injury that might occur as a result of your participation in the Event.</div><div>&nbsp;</div><div>You agree to abide by the instructions provided by the organizers from time to time in the best interest of your health and event safety.</div><div>&nbsp;</div><div>You also agree to stop running if instructed by the Race director or the medical staff or by the aid station volunteers.</div><div>&nbsp;</div><div>You confirm that your name and media recordings taken during your participation may be used to publicize the Event.</div><div>&nbsp;</div><div>You may acknowledge and agree that your personal information can be stored and used by Chennai Trekking Club Trial Marathon Organizing Committee or Chennai Trekking Club or any other company in connection with the organization, promotion and administration of the Event and for the compilation of statistical information.</div><div>&nbsp;</div><div>You confirm that, in the event of adverse weather conditions, major incidents or threats on the day, the organizers reserve the right to stop/cancel/postpone the Event. You understand that confirmed registrations and merchandise orders are non-refundable, non-transferable and cannot be modified.</div><div>&nbsp;</div><div>The organizers reserve the right to reject any application without providing reasons. Any amount collected from rejected applications alone will be refunded in full (excluding bank charges wherever applicable)</div><div>&nbsp;</div><div>The organizers will contact the runners only by email. Any notice sent to the email address registered with the Organizers shall be deemed as received by the runners. All the events will conclude by 12:00 PM on October 20st 2013.</div><div>&nbsp;</div><div>Runners will not be allowed to stay on the course beyond the cut-off time considering the safety and health issues.</div><div>&nbsp;</div><div>We request total co-operation from runners in this regards. All runners less than 12 years of age shall be represented by their Parent or Guardian and only on obtaining written consent of their respective Parent or Guardian, before the Bib collection date, they shall be permitted to participate in the event.</div><p>&nbsp;</p><p>Regards</p><p>Team CTM</p><p>letsrun@chennaitrekkers.org</p><p>&nbsp;</p></div></div></div></div>";
                    string sendMsg = "This is to confirm your participation for CTM2014. Name:" + name.Trim() + ". Ticket No: " + ticketNumberTicket.Trim() + ". Category:" + categoryTicket.Trim() + ". BIB No:" + bibNumberTicket.Trim() + ". Regards. Team CTM";

                    string inputDate = DateTime.UtcNow.ToString();


                    int emailCountNew = emailCount(emailTicket, ticketNumberTicket);

                    if (emailCountNew == 0)
                    {
                        SendGrid("Team CTM", "letsrun@chennaitrekkers.org", emailTicket, "CTM 2014 Ticket Confirmation", sendTicket);
                        _dbRepository.InsertEmailTransaction(name, email, ticketNumberTicket, categoryTicket, inputDate, sendTicket);
                    }

                    int msgCountNew = msgCount(phoneTicket, ticketNumberTicket);
                    if (msgCountNew == 0)
                    {
                        SendMsg(phoneTicket, sendMsg);
                        _dbRepository.InsertMsgTransaction(name, phoneTicket, ticketNumberTicket, categoryTicket, inputDate, sendMsg);
                    }

                }
            }

        }

        private string Decryptdata(string encryptpwd)
        {
            string decryptpwd = string.Empty;
            UTF8Encoding encodepwd = new UTF8Encoding();
            Decoder Decode = encodepwd.GetDecoder();
            byte[] todecode_byte = Convert.FromBase64String(encryptpwd);
            int charCount = Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
            char[] decoded_char = new char[charCount];
            Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
            decryptpwd = new String(decoded_char);
            return decryptpwd;
        }

        int emailCount(string email, string TicketId)
        {

            string selctemailCount = "select * from emailtransaction where Email='" + email + "' and TicketId='" + TicketId + "'";
            SqlCommand cmd = new SqlCommand(selctemailCount, conn);
            SqlDataAdapter Adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            Adap.Fill(dt);

            int emailCount = dt.Rows.Count;
            return emailCount;
        }

        int msgCount(string phone, string TicketId)
        {

            string selctmsgCount = "select * from msgtransaction where Phone='" + phone + "' and TicketId='" + TicketId + "'";
            SqlCommand cmd = new SqlCommand(selctmsgCount, conn);
            SqlDataAdapter Adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            Adap.Fill(dt);

            int msgCount = dt.Rows.Count;
            return msgCount;
        }

        #region BarCode

        void GenerateBarCode(string barcode)
        {
            string barCode = barcode;
            System.Web.UI.WebControls.Image imgBarCode = new System.Web.UI.WebControls.Image();
            using (Bitmap bitMap = new Bitmap(barCode.Length * 40, 80))
            {
                using (Graphics graphics = Graphics.FromImage(bitMap))
                {
                    Font oFont = new Font("IDAutomationHC39M", 16);
                    PointF point = new PointF(2f, 2f);
                    SolidBrush blackBrush = new SolidBrush(Color.Black);
                    SolidBrush whiteBrush = new SolidBrush(Color.White);
                    graphics.FillRectangle(whiteBrush, 0, 0, bitMap.Width, bitMap.Height);
                    graphics.DrawString("*" + barCode + "*", oFont, blackBrush, point);
                }
                using (MemoryStream ms = new MemoryStream())
                {
                    bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                    byte[] byteImage = ms.ToArray();

                    Convert.ToBase64String(byteImage);
                    imgBarCode.ImageUrl = "data:image/png;base64," + Convert.ToBase64String(byteImage);
                }
                PlaceHolder1.Controls.Add(imgBarCode);
            }
        }

        #endregion BarCode

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
                    SmtpClient mdtpClient = new SmtpClient("smtp.sendgrid.net", Convert.ToInt32(587));
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
                        //HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("https://control.msg91.com/sendhttp.php?user=" + "softyathlete" + "&password=" + "rakesh@123" + "&mobiles=" + phoneNumber.Trim().ToString() + "&message='" + msg.Trim().ToString() + "'" + "&sender=CTCCTM&ignoreNdnc=4");
                        HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("https://control.msg91.com/api/sendhttp.php?authkey=33506ApcYwDf7065369c7d4&mobiles=" + phoneNumber.Trim() + "&message=" + msg.Trim() + "&sender=CTCCTM&route=4");

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
    }
}