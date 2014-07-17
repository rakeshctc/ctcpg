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
    public partial class RunNow : System.Web.UI.Page
    {
        Gujaals _gujaals = new Gujaals();
        CTC_Latest_4._0.DBRepository.DBRepository _dbRepository = new CTC_Latest_4._0.DBRepository.DBRepository();
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["JustToConfirm"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            if (Session["email"] == null)
            {
                Response.Redirect("Default.aspx");
            }

            string email = Session["email"].ToString();
            //string guid = Session["guid"].ToString();
            //string changedEmail = _gujaals.Hitman(email);
            string changedEmail = email;

            //if ((email == null || email == "") && (guid == "" || guid == null))
            if ((email == null || email == ""))
            {
                Session.Abandon();
                Session.Clear();
                Response.Redirect("default.aspx");
            }
            else
            {
                string type = Session["type"].ToString();
                switch (type)
                {
                    case "10":
                        string selectQuery10 = "select * from [10kms] where Email='" + email.Trim() + "'";
                        SqlCommand cmd10 = new SqlCommand(selectQuery10, con);
                        SqlDataAdapter aDap10 = new SqlDataAdapter(cmd10);
                        DataTable dt10 = new DataTable();
                        aDap10.Fill(dt10);
                        ViewState["dt"] = dt10;
                        Session["Category"] = "10KMS/10KM Run";
                        BindData();

                        break;

                    case "21":
                        string selectQuery21 = "select * from [21kms] where Email='" + email.Trim() + "'";
                        SqlCommand cmd21 = new SqlCommand(selectQuery21, con);
                        SqlDataAdapter aDap21 = new SqlDataAdapter(cmd21);
                        DataTable dt21 = new DataTable();
                        aDap21.Fill(dt21);
                        ViewState["dt"] = dt21;
                        Session["Category"] = "21.1KMS/Half Marathon";
                        BindData();

                        break;

                    case "42":
                        string selectQuery42 = "select * from [42kms] where Email='" + email.Trim() + "' ";
                        SqlCommand cmd42 = new SqlCommand(selectQuery42, con);
                        SqlDataAdapter aDap42 = new SqlDataAdapter(cmd42);
                        DataTable dt42 = new DataTable();
                        aDap42.Fill(dt42);
                        ViewState["dt"] = dt42;
                        Session["Category"] = "42.2KMS/Full Marathon";
                        BindData();

                        break;

                    default:
                        break;
                }
            }
        }

        void BindData()
        {

            // if (ViewState["Confirm"].ToString().Trim() != "PleaseConfirm")
            {
                DataTable dt = (DataTable)ViewState["dt"];
                string category = Session["Category"].ToString();

                string Name = dt.Rows[0][0].ToString();
                string inEmail = dt.Rows[0][1].ToString();
                string Phone = dt.Rows[0][2].ToString();
                string inGuid = dt.Rows[0][3].ToString();
                string bibname = dt.Rows[0][4].ToString();
                string dob = dt.Rows[0][5].ToString();
                string age = dt.Rows[0][6].ToString();
                string kmbibnumber = dt.Rows[0][7].ToString();
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

                txtNomineeName.Text = Name;
                lblEmail.Text = inEmail;
                txtPhone.Text = Phone;
                txtBIBName.Text = bibname;
                txtDOB.Text = dob;
                txtAge.Text = age;
                txtCategory.Text = category;

                txtGender.Text = gender;
                txtBloodGroup.Text = bloodgroup;
                txtCountry.Text = country;
                txtState.Text = state;
                txtCity.Text = city;
                txtTShirtSize.Text = tshirtsize;
                txtEmergencyContactPerson.Text = emerconPerson;
                txtEmergencyContactPersonNumber.Text = emerconNumber;
                txt1TypeofID.Text = typeodID;
                txtIDNumber.Text = idNumber;
            }
        }

        int Age()
        {
            DateTime today = DateTime.Today;
            var dob = HiddenField1.Value.Trim().ToString();
            DateTime dt = DateTime.ParseExact(dob, "dd/mm/yyyy", CultureInfo.InvariantCulture);
            int age = today.Year - dt.Year;
            return age;
        }

        void BindEditData()
        {
            DataTable dt = (DataTable)ViewState["dt"];
            string category = Session["Category"].ToString();

            string Name = dt.Rows[0][0].ToString();
            string inEmail = dt.Rows[0][1].ToString();
            string Phone = dt.Rows[0][2].ToString();
            string inGuid = dt.Rows[0][3].ToString();
            string bibname = dt.Rows[0][4].ToString();
            string dob = dt.Rows[0][5].ToString();
            string age = dt.Rows[0][6].ToString();
            string kmbibnumber = dt.Rows[0][7].ToString();
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

            //  string changedem = _gujaals.Hitman(inEmail);

            //Binding the Dropdowns in Edit Mode.
            BindUpdateData(bloodgroup, tshirtsize, country, gender, typeodID);

            txtUNomineeName.Text = Name;
            lblEmail.Text = inEmail;
            txtUPhone.Text = Phone;
            txtUBibName.Text = bibname;
            txtUDOB.Text = dob;

            txtUState.Text = state;
            txtUCity.Text = city;
            txtUEmergencyContactPerson.Text = emerconPerson;
            txtUEmergencyContactNumber.Text = emerconNumber;
            txtUTypeInId.Text = idNumber;

        }

        void BindUpdateData(string bloodGroup, string tShirt, string Country, string gender, string typeodID)
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

            ddlUBloodGroup.DataSource = dt;
            ddlUBloodGroup.DataBind();
            ddlUBloodGroup.DataTextField = "BloodGroup";
            ddlUBloodGroup.DataValueField = "ID";
            ddlUBloodGroup.DataBind();
            ddlUBloodGroup.SelectedIndex = ddlUBloodGroup.Items.IndexOf(ddlUBloodGroup.Items.FindByText(bloodGroup));

            //ddlUTshirt.DataSource = dtTShirtSize;
            //ddlUTshirt.DataBind();
            //ddlUTshirt.DataTextField = "T-S-Size";
            //ddlUTshirt.DataValueField = "ID";
            //ddlUTshirt.DataBind();
            ddlUTshirt.SelectedIndex = ddlUTshirt.Items.IndexOf(ddlUTshirt.Items.FindByText(tShirt));

            ddlUCountry.DataSource = dtCountry;
            ddlUCountry.DataBind();
            ddlUCountry.DataTextField = "Country";
            ddlUCountry.DataValueField = "ID";
            ddlUCountry.DataBind();
            ddlUCountry.SelectedIndex = ddlUCountry.Items.IndexOf(ddlUCountry.Items.FindByText(Country));

            ddlUGender.SelectedIndex = ddlUGender.Items.IndexOf(ddlUGender.Items.FindByText(gender));

            ddlUTypeOdId.SelectedIndex = ddlUTypeOdId.Items.IndexOf(ddlUTypeOdId.Items.FindByText(typeodID));


        }

        void clearConfirm()
        {
            txtNomineeName.Text = string.Empty;
            lblEmail.Text = string.Empty;
            txtPhone.Text = string.Empty;
            txtBIBName.Text = string.Empty;
            txtDOB.Text = string.Empty;
            txtAge.Text = string.Empty;
            //txtBIBNumber.Text = kmbibnumber;
            txtCategory.Text = string.Empty;

            txtGender.Text = string.Empty;
            txtBloodGroup.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtState.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtTShirtSize.Text = string.Empty;
            txtEmergencyContactPerson.Text = string.Empty;
            txtEmergencyContactPersonNumber.Text = string.Empty;
            txt1TypeofID.Text = string.Empty;
            txtIDNumber.Text = string.Empty;
        }

        void clearUpdate()
        {
            BindUpdateData(string.Empty, string.Empty, string.Empty, string.Empty, string.Empty);

            txtUNomineeName.Text = string.Empty;
            lblEmail.Text = string.Empty;
            txtUPhone.Text = string.Empty;
            txtUBibName.Text = string.Empty;
            HiddenField1.Value = string.Empty;

            txtUState.Text = string.Empty;
            txtUCity.Text = string.Empty;
            txtUEmergencyContactPerson.Text = string.Empty;
            txtUEmergencyContactNumber.Text = string.Empty;
            txtUTypeInId.Text = string.Empty;
        }

        protected void btnEditData_Click(object sender, EventArgs e)
        {
            clearConfirm();
            divConfirmPersonalInformation.Visible = false;

            btnUpdateConfirm.Visible = true;

            btnEditData.Visible = false;
            //btnContinue.Visible = false;

            BindEditData();
            divUpdatePersonalInformation.Visible = true;
        }

        protected void btnUpdateConfirm_Click(object sender, EventArgs e)
        {

            ViewState["Confirm"] = "PleaseConfirm";

            string guid = Session["guid"].ToString();
            string email = Session["email"].ToString();
            string type = Session["Category"].ToString();

            string proceedToConfirm = "Success";
            string proceedtoPayment = "Success";


            int age = Age();
            string changedAge = Convert.ToString(age);

            if (age > 12)
            {
                switch (type)
                {
                    case "10KMS/10KM Run":

                        _dbRepository.UpdateQueryRegistration(txtUNomineeName.Text.Trim(), email, txtUPhone.Text.Trim(), guid, txtUBibName.Text.Trim(), HiddenField1.Value.Trim().ToString(), changedAge,
                            "", ddlUGender.SelectedItem.Text.Trim(), ddlUBloodGroup.SelectedItem.Text.Trim(), ddlUCountry.SelectedItem.Text.Trim(), txtUState.Text.Trim(),
                            txtUCity.Text.Trim(), ddlUTshirt.SelectedItem.Text.Trim(), txtUEmergencyContactPerson.Text.Trim(), txtUEmergencyContactNumber.Text.Trim(),
                            ddlUTypeOdId.SelectedItem.Text.Trim(), txtUTypeInId.Text.Trim(), proceedToConfirm, proceedtoPayment, "", "10");

                        clearUpdate();
                        divConfirmPersonalInformation.Visible = true;
                        divUpdatePersonalInformation.Visible = false;
                        btnEditData.Visible = true;
                        //btnContinue.Visible = true;
                        BindAfterUpdate();

                        break;

                    case "21.1KMS/Half Marathon":

                        _dbRepository.UpdateQueryRegistration(txtUNomineeName.Text.Trim(), email, txtUPhone.Text.Trim(), guid, txtUBibName.Text.Trim(), HiddenField1.Value.Trim().ToString(), changedAge,
                            "", ddlUGender.SelectedItem.Text.Trim(), ddlUBloodGroup.SelectedItem.Text.Trim(), ddlUCountry.SelectedItem.Text.Trim(), txtUState.Text.Trim(),
                            txtUCity.Text.Trim(), ddlUTshirt.SelectedItem.Text.Trim(), txtUEmergencyContactPerson.Text.Trim(), txtUEmergencyContactNumber.Text.Trim(),
                            ddlUTypeOdId.SelectedItem.Text.Trim(), txtUTypeInId.Text.Trim(), proceedToConfirm, proceedtoPayment, "", "21");

                        clearUpdate();
                        divConfirmPersonalInformation.Visible = true;
                        divUpdatePersonalInformation.Visible = false;
                        btnEditData.Visible = true;
                        //btnContinue.Visible = true;
                        BindAfterUpdate();

                        break;

                    case "42.2KMS/Full Marathon":

                        _dbRepository.UpdateQueryRegistration(txtUNomineeName.Text.Trim(), email, txtUPhone.Text.Trim(), guid, txtUBibName.Text.Trim(), HiddenField1.Value.Trim().ToString(), changedAge,
                            "", ddlUGender.SelectedItem.Text.Trim(), ddlUBloodGroup.SelectedItem.Text.Trim(), ddlUCountry.SelectedItem.Text.Trim(), txtUState.Text.Trim(),
                            txtUCity.Text.Trim(), ddlUTshirt.SelectedItem.Text.Trim(), txtUEmergencyContactPerson.Text.Trim(), txtUEmergencyContactNumber.Text.Trim(),
                            ddlUTypeOdId.SelectedItem.Text.Trim(), txtUTypeInId.Text.Trim(), proceedToConfirm, proceedtoPayment, "", "42");

                        clearUpdate();
                        divConfirmPersonalInformation.Visible = true;
                        divUpdatePersonalInformation.Visible = false;
                        btnEditData.Visible = true;
                        //btnContinue.Visible = true;
                        BindAfterUpdate();

                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox("Minimum Age for this Category is 13Years");
            }
        }

        private void MessageBox(string message, string title = "title")
        {
            ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), title, "alert('" + message + "');", true);
        }
        void BindAfterUpdate()
        {
            string type = Session["type"].ToString();
            string guid = Session["guid"].ToString();
            string email = Session["email"].ToString();

            switch (type)
            {
                case "10":
                    string selectQuery10 = "select * from [10kms] where Email='" + email.Trim() + "'";
                    SqlCommand cmd10 = new SqlCommand(selectQuery10, con);
                    SqlDataAdapter aDap10 = new SqlDataAdapter(cmd10);
                    DataTable dt10 = new DataTable();
                    aDap10.Fill(dt10);
                    ViewState["dt"] = dt10;
                    Session["Category"] = "10KMS/10KM Run";
                    BindData();

                    break;

                case "21":
                    string selectQuery21 = "select * from [21kms] where Email='" + email.Trim() + "'";
                    SqlCommand cmd21 = new SqlCommand(selectQuery21, con);
                    SqlDataAdapter aDap21 = new SqlDataAdapter(cmd21);
                    DataTable dt21 = new DataTable();
                    aDap21.Fill(dt21);
                    ViewState["dt"] = dt21;
                    Session["Category"] = "21.1KMS/Half Marathon";
                    BindData();

                    break;

                case "42":
                    string selectQuery42 = "select * from [42kms] where Email='" + email.Trim() + "' ";
                    SqlCommand cmd42 = new SqlCommand(selectQuery42, con);
                    SqlDataAdapter aDap42 = new SqlDataAdapter(cmd42);
                    DataTable dt42 = new DataTable();
                    aDap42.Fill(dt42);
                    ViewState["dt"] = dt42;
                    Session["Category"] = "42.2KMS/Full Marathon";
                    BindData();

                    break;

                default:
                    break;
            }
        }

        protected void btnContinue_Click(object sender, EventArgs e)
        {
            string guid = Session["guid"].ToString();
            string email = Session["email"].ToString();
            string type = Session["Category"].ToString();

            string proceedToConfirm = "Success";
            string proceedtoPayment = "Success";

            switch (type)
            {
                case "10KMS/10KM Run":

                    _dbRepository.UpdateQueryRegistrationPage2("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "",
                        "", "", proceedToConfirm, proceedtoPayment, "", "10");


                    clearUpdate();
                    Session["JustToConfirm"] = null;
                    Response.Redirect("Payment.aspx");
                    break;

                case "21.1KMS/Half Marathon":

                    _dbRepository.UpdateQueryRegistrationPage2("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "",
                        "", "", proceedToConfirm, proceedtoPayment, "", "21");

                    clearUpdate();
                    Session["JustToConfirm"] = null;
                    Response.Redirect("Payment.aspx");

                    break;

                case "42.2KMS/Full Marathon":

                    _dbRepository.UpdateQueryRegistrationPage2("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "",
                        "", "", proceedToConfirm, proceedtoPayment, "", "42");

                    clearUpdate();
                    Session["JustToConfirm"] = null;
                    Response.Redirect("DoSomething.aspx");

                    break;
                default:
                    break;
            }
        }
    }
}