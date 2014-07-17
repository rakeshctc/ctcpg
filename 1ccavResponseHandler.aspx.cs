using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CCA.Util;
using System.Collections.Specialized;
using CTC_Latest_4._0.Helper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;

public partial class ResponseHandler : System.Web.UI.Page
{

    CTC_Latest_4._0.DBRepository.DBRepository _dbRepository = new CTC_Latest_4._0.DBRepository.DBRepository();
    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
    UsingFunctions _usingFunctions = new UsingFunctions();
    Gujaals _gujaals = new Gujaals();

    protected void Page_Load(object sender, EventArgs e)
    {
        string workingKey = "79226183BBAE50766E8383CEA3FF089D";//put in the 32bit alpha numeric key in the quotes provided here
        CCACrypto ccaCrypto = new CCACrypto();
        string encResponse = ccaCrypto.Decrypt(Request.Form["encResp"], workingKey);
        NameValueCollection Params = new NameValueCollection();
        string[] segments = encResponse.Split('&');
        foreach (string seg in segments)
        {
            string[] parts = seg.Split('=');
            if (parts.Length > 0)
            {
                string Key = parts[0].Trim();
                string Value = parts[1].Trim();
                Params.Add(Key, Value);
            }
        }

        for (int i = 0; i < Params.Count; i++)
        {
            //Response.Write(Params.Keys[i] + " = " + Params[i] + "<br>");

            //Bank Transaction
            ViewState["order_id "] = Params[0].ToString();
            ViewState["tracking_id"] = Params[1].ToString();
            ViewState["bank_ref_no"] = Params[2].ToString();
            ViewState["order_status"] = Params[3].ToString();
            ViewState["failure_status"] = Params[4].ToString();
            ViewState["payment_mode"] = Params[5].ToString();
            ViewState["card_name"] = Params[6].ToString();
            ViewState["status_code"] = Params[7].ToString();
            ViewState["status_message"] = Params[8].ToString();
            ViewState["currency"] = Params[9].ToString();
            ViewState["amount"] = Params[10].ToString();

            ////Billing Information
            ViewState["billing_name"] = Params[11].ToString();
            ViewState["billing_address"] = Params[12].ToString();
            ViewState["billing_city"] = Params[13].ToString();
            ViewState["billing_state"] = Params[14].ToString();
            ViewState["billing_zip"] = Params[15].ToString();
            ViewState["billing_country"] = Params[16].ToString();
            ViewState["billing_tel"] = Params[17].ToString();
            ViewState["billing_email"] = Params[18].ToString();

            //MessageBox(ViewState["card_name"].ToString().Trim());

            PaymentSuccess();
            Session["Ticket"] = "goTicket";
            BindBankTransaction();
            //Response.Redirect("Ticket.aspx");


            Redirect();
            
        }
    }
    private void MessageBox(string message, string title = "title")
    {
        ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), title, "alert('" + message + "');", true);
    }


    void Redirect()
    {
        string selectQuery = "select GUID from register_1 where Email='" + Session["email"].ToString().Trim() + "'";
        SqlCommand cmd = new SqlCommand(selectQuery, conn);
        SqlDataAdapter dAdap = new SqlDataAdapter(cmd);
        DataTable dt = new DataTable();
        dAdap.Fill(dt);

        string GUID = dt.Rows[0][0].ToString();

        string encEMail = Encryptdata(Session["email"].ToString().Trim());
        string encGUID = Encryptdata(GUID);

        Response.Redirect("Ticket.aspx?inc=" + encEMail + "&enc=" + encGUID);
    }

    void PaymentSuccess()
    {
        if (Session["email"] != null)
        {
            string category = Session["Category"].ToString();
            string email = Session["email"].ToString();
            string guid = Session["guid"].ToString();
            string paymentStatus = "Yes";

            switch (category)
            {
                case "10KMS/10KM Run":
                    try
                    {
                        _dbRepository.UpdateQueryRegistrationPage3("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", paymentStatus, "10");
                        BindBankTransaction();
                        ViewState["Cat"] = "[10kms]";
                        getData();
                        Session["Ticket"] = "goTicket";
                        Session["email"] = email;
                        Response.Redirect("Ticket.aspx");
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }

                    break;

                case "21.1KMS/Half Marathon":
                    try
                    {
                        _dbRepository.UpdateQueryRegistrationPage3("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", paymentStatus, "21");
                        BindBankTransaction();
                        ViewState["Cat"] = "[21kms]";
                        getData();
                        Session["Ticket"] = "goTicket";
                        Session["email"] = email;
                        Response.Redirect("Ticket.aspx");
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                    break;

                case "42.2KMS/Full Marathon":
                    try
                    {
                        _dbRepository.UpdateQueryRegistrationPage3("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", paymentStatus, "42");
                        BindBankTransaction();
                        ViewState["Cat"] = "[42kms]";
                        getData();
                        Session["Ticket"] = "goTicket";
                        Session["email"] = email;
                        Response.Redirect("Ticket.aspx");
                    }
                    catch (Exception ex)
                    {

                        throw ex;
                    }
                    break;

                default:
                    break;
            }

        }
    }

    void getData()
    {
        string email = Session["email"].ToString();
        string guid = Session["guid"].ToString();
        string category1 = Session["Category"].ToString();
        string cat = ViewState["Cat"].ToString().Trim();

        try
        {
            string selectQuery = "select * from " + cat + " where email='" + email + "'";
            SqlCommand cmd = new SqlCommand(selectQuery, conn);
            SqlDataAdapter Adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            Adap.Fill(dt);

            string Name = dt.Rows[0][0].ToString();
            string emailChange = dt.Rows[0][1].ToString();
            string Phone = dt.Rows[0][2].ToString();
            string guidChange = dt.Rows[0][3].ToString();
            string bibname = dt.Rows[0][4].ToString();
            string dob = dt.Rows[0][5].ToString();
            string age = dt.Rows[0][6].ToString();
            string bibnumber = dt.Rows[0][7].ToString();
            string category = category1;
            string gender = dt.Rows[0][8].ToString();
            string bloodgroup = dt.Rows[0][9].ToString();
            string country = dt.Rows[0][10].ToString();
            string state = dt.Rows[0][11].ToString();
            string city = dt.Rows[0][12].ToString();
            string tshirtsize = dt.Rows[0][13].ToString();
            string emerconPerson = dt.Rows[0][14].ToString();
            string emerconNumber = dt.Rows[0][15].ToString();
            string typeodID = dt.Rows[0][16].ToString();
            string idNumber = dt.Rows[0][17].ToString();
            string proceedtoConfirm = dt.Rows[0][18].ToString();
            string proceedtoPayment = dt.Rows[0][19].ToString();
            string paymentStatus = dt.Rows[0][20].ToString();
            string emailConfirmation = dt.Rows[0][21].ToString();

            //string type =dt.Rows[0][0].ToString();

            //string em = _gujaals.Hitman(emailChange);

            try
            {
                _dbRepository.InsertQueryAllCategories(Name, emailChange, Phone, guidChange, bibname, bibnumber, category, dob, age, gender, bloodgroup, country, state,
                    city, tshirtsize, emerconPerson, emerconNumber, typeodID, idNumber, proceedtoConfirm, proceedtoPayment, paymentStatus);
                _dbRepository.UpdateQueryRegister_1_Payment(emailChange, "Success");
            }
            catch (Exception)
            {

                throw;
            }
        }
        catch (Exception ex)
        {

            throw ex;
        }
    }

    void BindBankTransaction()
    {
        _dbRepository.InsertBankTransaction(ViewState["order_id "].ToString().Trim(), ViewState["tracking_id"].ToString().Trim(), ViewState["bank_ref_no"].ToString().Trim(),
            ViewState["order_status"].ToString().Trim(), ViewState["failure_status"].ToString().Trim(), ViewState["payment_mode"].ToString().Trim(),
            ViewState["card_name"].ToString().Trim(), ViewState["status_code"].ToString().Trim(), ViewState["status_message"].ToString().Trim(),
            ViewState["currency"].ToString().Trim(), ViewState["amount"].ToString().Trim(), ViewState["billing_name"].ToString().Trim(),
            ViewState["billing_address"].ToString().Trim(), ViewState["billing_city"].ToString().Trim(), ViewState["billing_state"].ToString().Trim(),
            ViewState["billing_zip"].ToString().Trim(), ViewState["billing_country"].ToString().Trim(), ViewState["billing_tel"].ToString().Trim(),
            ViewState["billing_email"].ToString().Trim());
    }

    private string Encryptdata(string password)
    {
        string strmsg = string.Empty;
        byte[] encode = new byte[password.Length];
        encode = Encoding.UTF8.GetBytes(password);
        strmsg = Convert.ToBase64String(encode);
        return strmsg;
    }
    /// <summary>
    /// Function is used to Decrypt the password
    /// </summary>
    /// <param name="password"></param>
    /// <returns></returns>
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
}
