using CTC_Latest_4._0.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CTC_Final
{
    public partial class Payment : System.Web.UI.Page
    {
        CTC_Latest_4._0.DBRepository.DBRepository _dbRepository = new CTC_Latest_4._0.DBRepository.DBRepository();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        UsingFunctions _usingFunctions = new UsingFunctions();
        Gujaals _gujaals = new Gujaals();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] == null)
            {
                Response.Redirect("Default.aspx");
            }
        }


        protected void btnPayment_Click(object sender, EventArgs e)
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
                            ViewState["Cat"] = "[10kms]";
                            getData();
                            Session["Ticket"] = "goTicket";
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
                            ViewState["Cat"] = "[21kms]";
                            getData();
                            Session["Ticket"] = "goTicket";
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
                            ViewState["Cat"] = "[42kms]";
                            getData();
                            Session["Ticket"] = "goTicket";
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
                        city, tshirtsize, emerconPerson, emerconNumber, typeodID, idNumber, proceedtoConfirm, proceedtoPayment, paymentStatus,"");
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
    }
}