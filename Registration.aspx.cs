using CTC_Latest_4._0.Helper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CTC_Final
{
    public partial class Registration : System.Web.UI.Page
    {
        Gujaals _gujaals = new Gujaals();
        CTC_Latest_4._0.DBRepository.DBRepository _dbRepository = new CTC_Latest_4._0.DBRepository.DBRepository();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Registration"] == null)
            {
                Response.Redirect("default.aspx");
            }

            if (Session["email"] == null)
            {
                Response.Redirect("Default.aspx");
            }

            if (Session["email"] != null || Session["guid"] != null)
            {
                lblDisplayEmail.Text = Session["email"].ToString().Trim();

                string email;
                string guid;
                int ticketCount;
                email = Session["email"].ToString();
                guid = Session["guid"].ToString();
                ticketCount = Convert.ToInt16(Session["Count"]);
                ViewState["Count"] = ticketCount;

                ViewState["email"] = email;
                ViewState["guid"] = guid;

                if (!IsPostBack)
                {
                    string selectQuery = "Select * from bloodGroup";
                    SqlCommand cmd = new SqlCommand(selectQuery, con);
                    SqlDataAdapter Adap = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    Adap.Fill(dt);

                    string selectTShirtSize = "Select * from [T-Shirt_Size]";
                    SqlCommand cmdTShirtSize = new SqlCommand(selectTShirtSize, con);
                    SqlDataAdapter AdapTShirtSize = new SqlDataAdapter(cmdTShirtSize);
                    DataTable dtTShirtSize = new DataTable();
                    AdapTShirtSize.Fill(dtTShirtSize);

                    string selectCountry = "Select * from Country";
                    SqlCommand cmdCountry = new SqlCommand(selectCountry, con);
                    SqlDataAdapter AdapCountry = new SqlDataAdapter(cmdCountry);
                    DataTable dtCountry = new DataTable();
                    AdapCountry.Fill(dtCountry);

                    ddlBloodGroup.DataSource = dt;
                    ddlBloodGroup.DataBind();
                    ddlBloodGroup.DataTextField = "BloodGroup";
                    ddlBloodGroup.DataValueField = "ID";
                    ddlBloodGroup.DataBind();
                    ddlBloodGroup.Items.Insert(0, new ListItem("Select BloodGroup", "0"));

                    ddlTShirtSize.DataSource = dtTShirtSize;
                    ddlTShirtSize.DataBind();
                    ddlTShirtSize.DataTextField = "T-S-Size";
                    ddlTShirtSize.DataValueField = "ID";
                    ddlTShirtSize.DataBind();
                    ddlTShirtSize.Items.Insert(0, new ListItem("Select T-Shirt Size", "0"));

                    ddlCountry.DataSource = dtCountry;
                    ddlCountry.DataBind();
                    ddlCountry.DataTextField = "Country";
                    ddlCountry.DataValueField = "ID";
                    ddlCountry.DataBind();
                    ddlCountry.Items.Insert(0, new ListItem("Select Country", "0"));
                }

            }
        }

        protected void datePicker_ValueSelected(object sender, EventArgs e)
        {
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            //if (HiddenField1.Value.ToString() != null)
            {

                if ((Session["email"] != null))
                {
                    string type = Session["type"].ToString();
                    string email = Session["email"].ToString();
                    string guid = Session["guid"].ToString();
                    string proceedToConfirm = "Yes";


                    int age = Age();
                    string changedAge = Convert.ToString(age);
                    if (age > 12)
                    {
                        switch (type)
                        {
                            case "50":
                                TShirtCount();
                                _dbRepository.UpdateQueryRegistration(txtNomineeName.Text.Trim(), email, txtPhone.Text.Trim(), guid, txtBIBName.Text.Trim(), HiddenField1.Value.ToString().Trim(), changedAge,
                                    "", ddlGender.SelectedItem.Text.Trim(), ddlBloodGroup.SelectedItem.Text.Trim(), ddlCountry.SelectedItem.Text.Trim(), txtState.Text.Trim(),
                                    txtCity.Text.Trim(), ddlTShirtSize.SelectedItem.Text.Trim(), txtEmergencyContactPerson.Text.Trim(), txtEmergencyContactPersonNumber.Text.Trim(),
                                    ddlTypeofID.SelectedItem.Text.Trim(), txtIDNumber.Text.Trim(), proceedToConfirm, "", "", "50");

                                Session["JustToConfirm"] = "true";
                                Session["Registration"] = null;
                                Response.Redirect("JustToConfirm.aspx");
                                break;

                            case "S50":
                                ViewState["S50"] = "true";
                                TShirtCount();
                                
                                _dbRepository.UpdateQueryRegistration(txtNomineeName.Text.Trim(), email, txtPhone.Text.Trim(), guid, txtBIBName.Text.Trim(), HiddenField1.Value.ToString().Trim(), changedAge,
                                    "", ddlGender.SelectedItem.Text.Trim(), ddlBloodGroup.SelectedItem.Text.Trim(), ddlCountry.SelectedItem.Text.Trim(), txtState.Text.Trim(),
                                    txtCity.Text.Trim(), ddlTShirtSize.SelectedItem.Text.Trim(), txtEmergencyContactPerson.Text.Trim(), txtEmergencyContactPersonNumber.Text.Trim(),
                                    ddlTypeofID.SelectedItem.Text.Trim(), txtIDNumber.Text.Trim(), proceedToConfirm, "", "", "S50");

                                Session["JustToConfirm"] = "true";
                                Session["Registration"] = null;
                                Response.Redirect("JustToConfirm.aspx");
                                break;

                            case "21":
                                TShirtCount();
                                _dbRepository.UpdateQueryRegistration(txtNomineeName.Text.Trim(), email, txtPhone.Text.Trim(), guid, txtBIBName.Text.Trim(), HiddenField1.Value.ToString().Trim(), changedAge,
                                    "", ddlGender.SelectedItem.Text.Trim(), ddlBloodGroup.SelectedItem.Text.Trim(), ddlCountry.SelectedItem.Text.Trim(), txtState.Text.Trim(),
                                    txtCity.Text.Trim(), ddlTShirtSize.SelectedItem.Text.Trim(), txtEmergencyContactPerson.Text.Trim(), txtEmergencyContactPersonNumber.Text.Trim(),
                                    ddlTypeofID.SelectedItem.Text.Trim(), txtIDNumber.Text.Trim(), proceedToConfirm, "", "", "21");
                                Session["JustToConfirm"] = "true";
                                Session["Registration"] = null;
                                Response.Redirect("JustToConfirm.aspx");

                                break;

                            case "S21":
                                ViewState["S21"] = "true";
                                TShirtCount();
                                
                                _dbRepository.UpdateQueryRegistration(txtNomineeName.Text.Trim(), email, txtPhone.Text.Trim(), guid, txtBIBName.Text.Trim(), HiddenField1.Value.ToString().Trim(), changedAge,
                                    "", ddlGender.SelectedItem.Text.Trim(), ddlBloodGroup.SelectedItem.Text.Trim(), ddlCountry.SelectedItem.Text.Trim(), txtState.Text.Trim(),
                                    txtCity.Text.Trim(), ddlTShirtSize.SelectedItem.Text.Trim(), txtEmergencyContactPerson.Text.Trim(), txtEmergencyContactPersonNumber.Text.Trim(),
                                    ddlTypeofID.SelectedItem.Text.Trim(), txtIDNumber.Text.Trim(), proceedToConfirm, "", "", "S21");
                                Session["JustToConfirm"] = "true";
                                Session["Registration"] = null;
                                Response.Redirect("JustToConfirm.aspx");

                                break;

                            case "42":
                                TShirtCount();
                                _dbRepository.UpdateQueryRegistration(txtNomineeName.Text.Trim(), email, txtPhone.Text.Trim(), guid, txtBIBName.Text.Trim(), HiddenField1.Value.ToString().Trim(), changedAge,
                                    "", ddlGender.SelectedItem.Text.Trim(), ddlBloodGroup.SelectedItem.Text.Trim(), ddlCountry.SelectedItem.Text.Trim(), txtState.Text.Trim(),
                                    txtCity.Text.Trim(), ddlTShirtSize.SelectedItem.Text.Trim(), txtEmergencyContactPerson.Text.Trim(), txtEmergencyContactPersonNumber.Text.Trim(),
                                    ddlTypeofID.SelectedItem.Text.Trim(), txtIDNumber.Text.Trim(), proceedToConfirm, "", "", "42");
                                Session["JustToConfirm"] = "true";
                                Session["Registration"] = null;
                                Response.Redirect("JustToConfirm.aspx");

                                break;

                            case "S42":
                                ViewState["S42"] = "true";
                                TShirtCount();
                                _dbRepository.UpdateQueryRegistration(txtNomineeName.Text.Trim(), email, txtPhone.Text.Trim(), guid, txtBIBName.Text.Trim(), HiddenField1.Value.ToString().Trim(), changedAge,
                                    "", ddlGender.SelectedItem.Text.Trim(), ddlBloodGroup.SelectedItem.Text.Trim(), ddlCountry.SelectedItem.Text.Trim(), txtState.Text.Trim(),
                                    txtCity.Text.Trim(), ddlTShirtSize.SelectedItem.Text.Trim(), txtEmergencyContactPerson.Text.Trim(), txtEmergencyContactPersonNumber.Text.Trim(),
                                    ddlTypeofID.SelectedItem.Text.Trim(), txtIDNumber.Text.Trim(), proceedToConfirm, "", "", "S42");
                                Session["JustToConfirm"] = "true";
                                Session["Registration"] = null;
                                Response.Redirect("JustToConfirm.aspx");

                                break;
                            default:
                                break;
                        }
                        Response.Redirect("JustToConfirm.aspx");
                    }
                    else
                    {
                        MessageBox("Minimum Age for this Category is 13Years");
                    }
                }
                else
                {

                }
            }
            //else
            //{
            //    MessageBox("Date Of Birth Field Cannot Be Empty");
            //}
        }

        #region TShirtCount
        void TShirtCount()
        {
            string Amount = string.Empty;
            string tshirt = string.Empty;

            switch (ddlTShirtSize.SelectedItem.Text.Trim())
            {
                    

                case "S":
                    if (ViewState["S50"] == "true" || ViewState["S21"] == "true" || ViewState["S42"] == "true")
                    {
                        //Amount = "570";
                        Amount = "1.25";
                        tshirt = "S";
                        Session["tShirt"] = tshirt;
                    }
                    else
                    {
                        //Amount = "720";
                        Amount = "1.50";
                        tshirt = "S";
                        Session["tShirt"] = tshirt;
                    }
                    break;

                case "M":
                    if (ViewState["S50"] == "true" || ViewState["S21"] == "true" || ViewState["S42"] == "true")
                    {
                        //Amount = "570";
                        Amount = "1.25";
                        tshirt = "M";
                        Session["tShirt"] = tshirt;
                    }
                    else
                    {
                        //Amount = "720";
                        Amount = "1.50";
                        tshirt = "M";
                        Session["tShirt"] = tshirt;
                    }
                    break;

                case "L":
                    if (ViewState["S50"] == "true" || ViewState["S21"] == "true" || ViewState["S42"] == "true")
                    {
                        //Amount = "570";
                        Amount = "1.25";
                        tshirt = "L";
                        Session["tShirt"] = tshirt;
                    }
                    else
                    {
                        //Amount = "720";
                        Amount = "1.50";
                        tshirt = "L";
                        Session["tShirt"] = tshirt;
                    }
                    break;

                case "XL":
                    if (ViewState["S50"] == "true" || ViewState["S21"] == "true" || ViewState["S42"] == "true")
                    {
                        //Amount = "570";
                        Amount = "1.25";
                        tshirt = "XL";
                        Session["tShirt"] = tshirt;
                    }
                    else
                    {
                        //Amount = "720";
                        Amount = "1.50";
                        tshirt = "XL";
                        Session["tShirt"] = tshirt;
                    }
                    break;

                case "XXL":
                    if (ViewState["S50"] == "true" || ViewState["S21"] == "true" || ViewState["S42"] == "true")
                    {
                        //Amount = "570";
                        Amount = "1.25";
                        tshirt = "XXL";
                        Session["tShirt"] = tshirt;
                    }
                    else
                    {
                        //Amount = "720";
                        Amount = "1.50";
                        tshirt = "XXL";
                        Session["tShirt"] = tshirt;
                    }
                    break;

                case "XXXL":
                    if (ViewState["S50"] == "true" || ViewState["S21"] == "true" || ViewState["S42"] == "true")
                    {
                        //Amount = "570";
                        Amount = "1.25";
                        tshirt = "XXXL";
                        Session["tShirt"] = tshirt;
                    }
                    else
                    {
                        //Amount = "720";
                        Amount = "1.50";
                        tshirt = "XXXL";
                        Session["tShirt"] = tshirt;
                    }
                    break;

                case "NO":
                    if (ViewState["S50"] == "true" || ViewState["S21"] == "true" || ViewState["S42"] == "true")
                    {
                        //Amount = "350";
                        Amount = ".75";
                        tshirt = "NO";
                        Session["tShirt"] = tshirt;
                    }
                    else
                    {
                        //Amount = "500";
                        Amount = "1";
                        tshirt = "NO";
                        Session["tShirt"] = tshirt;
                    }
                    break;

                default:
                    break;
            }

            string email = Session["email"].ToString().Trim();
            string tShirt = Session["tShirt"].ToString().Trim();

            string selectTShirtCount = "select * from TShirtCount where Email='" + email + "' and TShirt='" + Session["tShirt"].ToString().Trim() + "'";
            SqlCommand cmdTShirtCount = new SqlCommand(selectTShirtCount, con);
            SqlDataAdapter aDapTShirtCount = new SqlDataAdapter(cmdTShirtCount);
            DataTable dtTShirtCount = new DataTable();
            aDapTShirtCount.Fill(dtTShirtCount);

            int tShirtCount = dtTShirtCount.Rows.Count;

            if (tShirtCount == 0)
            {
                try
                {
                    _dbRepository.InsertTShirtCount(Session["email"].ToString().Trim(), Session["tShirt"].ToString().Trim(), Amount.ToString());
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                try
                {
                   //_dbRepository.UpdaeTShirtCount(Session["email"].ToString().Trim(), tshirt.ToString(), Amount.ToString());
                }
                catch (Exception)
                {

                    throw;
                }
            }


        }
        #endregion TShirtCount



        private void MessageBox(string message, string title = "title")
        {
            ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), title, "alert('" + message + "');", true);
        }

        int Age()
        {
            DateTime today = DateTime.Today;
            var dob = HiddenField1.Value.ToString();
            DateTime dt = DateTime.ParseExact(dob, "mm/dd/yyyy", CultureInfo.InvariantCulture);
            int age = today.Year - dt.Year;
            return age;
        }
    }
}