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
using CTC_Final.Model;

namespace CTC_Final
{
    public partial class JustToConfirm : System.Web.UI.Page
    {
        CompleteModel model = new CompleteModel();
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
                    case "50":
                        string selectQuery10 = "select * from [10kms] where Email='" + email.Trim() + "'";
                        SqlCommand cmd10 = new SqlCommand(selectQuery10, con);
                        SqlDataAdapter aDap10 = new SqlDataAdapter(cmd10);
                        DataTable dt10 = new DataTable();
                        aDap10.Fill(dt10);
                        ViewState["dt"] = dt10;
                        Session["Category"] = "50.0KM Run/Ultra Run";
                        BindData();

                        break;

                    case "S50":
                        string selectQueryS10 = "select * from [10kms] where Email='" + email.Trim() + "'";
                        SqlCommand cmdS10 = new SqlCommand(selectQueryS10, con);
                        SqlDataAdapter aDapS10 = new SqlDataAdapter(cmdS10);
                        DataTable dtS10 = new DataTable();
                        aDapS10.Fill(dtS10);
                        ViewState["dt"] = dtS10;
                        Session["Category"] = "Student 50.0KM Run/Ultra Run";
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

                    case "S21":
                        string selectQueryS21 = "select * from [21kms] where Email='" + email.Trim() + "'";
                        SqlCommand cmdS21 = new SqlCommand(selectQueryS21, con);
                        SqlDataAdapter aDapS21 = new SqlDataAdapter(cmdS21);
                        DataTable dtS21 = new DataTable();
                        aDapS21.Fill(dtS21);
                        ViewState["dt"] = dtS21;
                        Session["Category"] = "Student 21.1KMS/Half Marathon";
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

                    case "S42":
                        string selectQueryS42 = "select * from [42kms] where Email='" + email.Trim() + "' ";
                        SqlCommand cmdS42 = new SqlCommand(selectQueryS42, con);
                        SqlDataAdapter aDapS42 = new SqlDataAdapter(cmdS42);
                        DataTable dtS42 = new DataTable();
                        aDapS42.Fill(dtS42);
                        ViewState["dt"] = dtS42;
                        Session["Category"] = "Student 42.2KMS/Full Marathon";
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
            if (HiddenField1.Value.Trim().ToString() != "")
            {
                DateTime today = DateTime.Today;
                var dob = HiddenField1.Value.Trim().ToString();
                DateTime dt = DateTime.ParseExact(dob, "mm/dd/yyyy", CultureInfo.InvariantCulture);
                int age = today.Year - dt.Year;
                return age;
            }
            else
            {
                DateTime today = DateTime.Today;
                var dob = txtUDOB.Text.Trim().ToString();
                HiddenField1.Value = dob;
                DateTime dt = DateTime.ParseExact(dob, "mm/dd/yyyy", CultureInfo.InvariantCulture);
                int age = today.Year - dt.Year;
                return age;
            }
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
            //clearConfirm();
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
                    case "50.0KM Run/Ultra Run":
                        TShirtCount();
                        _dbRepository.UpdateQueryRegistration(txtUNomineeName.Text.Trim(), email, txtUPhone.Text.Trim(), guid, txtUBibName.Text.Trim(), HiddenField1.Value.Trim().ToString(), changedAge,
                            "", ddlUGender.SelectedItem.Text.Trim(), ddlUBloodGroup.SelectedItem.Text.Trim(), ddlUCountry.SelectedItem.Text.Trim(), txtUState.Text.Trim(),
                            txtUCity.Text.Trim(), ddlUTshirt.SelectedItem.Text.Trim(), txtUEmergencyContactPerson.Text.Trim(), txtUEmergencyContactNumber.Text.Trim(),
                            ddlUTypeOdId.SelectedItem.Text.Trim(), txtUTypeInId.Text.Trim(), proceedToConfirm, proceedtoPayment, "", "50");

                        clearUpdate();
                        divConfirmPersonalInformation.Visible = true;
                        divUpdatePersonalInformation.Visible = false;
                        btnEditData.Visible = true;
                        //btnContinue.Visible = true;
                        BindAfterUpdate();

                        break;

                    case "Student 50.0KM Run/Ultra Run":
                        TShirtCount();
                        _dbRepository.UpdateQueryRegistration(txtUNomineeName.Text.Trim(), email, txtUPhone.Text.Trim(), guid, txtUBibName.Text.Trim(), HiddenField1.Value.Trim().ToString(), changedAge,
                            "", ddlUGender.SelectedItem.Text.Trim(), ddlUBloodGroup.SelectedItem.Text.Trim(), ddlUCountry.SelectedItem.Text.Trim(), txtUState.Text.Trim(),
                            txtUCity.Text.Trim(), ddlUTshirt.SelectedItem.Text.Trim(), txtUEmergencyContactPerson.Text.Trim(), txtUEmergencyContactNumber.Text.Trim(),
                            ddlUTypeOdId.SelectedItem.Text.Trim(), txtUTypeInId.Text.Trim(), proceedToConfirm, proceedtoPayment, "", "S50");

                        clearUpdate();
                        divConfirmPersonalInformation.Visible = true;
                        divUpdatePersonalInformation.Visible = false;
                        btnEditData.Visible = true;
                        //btnContinue.Visible = true;
                        BindAfterUpdate();

                        break;

                    case "21.1KMS/Half Marathon":
                        ViewState["S50"] = "true";
                        TShirtCount();
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

                    case "Student 21.1KMS/Half Marathon":
                        ViewState["S21"] = "true";
                        TShirtCount();
                        _dbRepository.UpdateQueryRegistration(txtUNomineeName.Text.Trim(), email, txtUPhone.Text.Trim(), guid, txtUBibName.Text.Trim(), HiddenField1.Value.Trim().ToString(), changedAge,
                            "", ddlUGender.SelectedItem.Text.Trim(), ddlUBloodGroup.SelectedItem.Text.Trim(), ddlUCountry.SelectedItem.Text.Trim(), txtUState.Text.Trim(),
                            txtUCity.Text.Trim(), ddlUTshirt.SelectedItem.Text.Trim(), txtUEmergencyContactPerson.Text.Trim(), txtUEmergencyContactNumber.Text.Trim(),
                            ddlUTypeOdId.SelectedItem.Text.Trim(), txtUTypeInId.Text.Trim(), proceedToConfirm, proceedtoPayment, "", "S21");

                        clearUpdate();
                        divConfirmPersonalInformation.Visible = true;
                        divUpdatePersonalInformation.Visible = false;
                        btnEditData.Visible = true;
                        //btnContinue.Visible = true;
                        BindAfterUpdate();

                        break;

                    case "42.2KMS/Full Marathon":
                        TShirtCount();
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

                    case "Student 42.2KMS/Full Marathon":
                        ViewState["S42"] = "true";
                        TShirtCount();
                        _dbRepository.UpdateQueryRegistration(txtUNomineeName.Text.Trim(), email, txtUPhone.Text.Trim(), guid, txtUBibName.Text.Trim(), HiddenField1.Value.Trim().ToString(), changedAge,
                            "", ddlUGender.SelectedItem.Text.Trim(), ddlUBloodGroup.SelectedItem.Text.Trim(), ddlUCountry.SelectedItem.Text.Trim(), txtUState.Text.Trim(),
                            txtUCity.Text.Trim(), ddlUTshirt.SelectedItem.Text.Trim(), txtUEmergencyContactPerson.Text.Trim(), txtUEmergencyContactNumber.Text.Trim(),
                            ddlUTypeOdId.SelectedItem.Text.Trim(), txtUTypeInId.Text.Trim(), proceedToConfirm, proceedtoPayment, "", "S42");

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
            DataTable dt = new DataTable();

            switch (type)
            {
                case "50":
                    
                    dt = commmonSelectQueryDT("[10kms]","Email");
                    ViewState["dt"] = dt;
                    Session["Category"] = "50.0KM Run/Ultra Run";
                    BindData();

                    break;

                case "S50":
                    dt = commmonSelectQueryDT("[10kms]","Email");
                    ViewState["dt"] = dt;
                    Session["Category"] = "Student 50.0KM Run/Ultra Run";
                    BindData();

                    break;

                case "21":
                    dt = commmonSelectQueryDT("[21kms]","Email");
                    ViewState["dt"] = dt;
                    Session["Category"] = "21.1KMS/Half Marathon";
                    BindData();

                    break;

                case "S21":
                    dt = commmonSelectQueryDT("[21kms]","Email");
                    ViewState["dt"] = dt;
                    Session["Category"] = "Student 21.1KMS/Half Marathon";
                    BindData();

                    break;

                case "42":
                    dt = commmonSelectQueryDT("[42kms]","Email");
                    ViewState["dt"] = dt;
                    Session["Category"] = "42.2KMS/Full Marathon";
                    BindData();

                    break;

                case "S42":
                    dt = commmonSelectQueryDT("[42kms]","Email");
                    ViewState["dt"] = dt;
                    Session["Category"] = "Student 42.2KMS/Full Marathon";
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
            DataTable dtNew = new DataTable();
            

            // Create on more common table which will insert only in this page .

            switch (type)
            {

                case "50.0KM Run/Ultra Run":
                    //TShirtCount();
                    _dbRepository.UpdateQueryRegistrationPage2("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "",
                        "", "", proceedToConfirm, proceedtoPayment, "", "50");
                    
                    dtNew = getDataForPaymentBeforeTable("[10Kms]");
                    insertDataForPaymentBeforeTable(dtNew);

                    clearUpdate();
                    Session["JustToConfirm"] = null;
                    Session["DoSomething"] = "DoSomething";
                    Response.Redirect("DoSomething.aspx");
                    break;

                case "Student 50.0KM Run/Ultra Run":
                    //TShirtCount();
                    _dbRepository.UpdateQueryRegistrationPage2("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "",
                        "", "", proceedToConfirm, proceedtoPayment, "", "S50");

                    dtNew = getDataForPaymentBeforeTable("[10kms]");
                    insertDataForPaymentBeforeTable(dtNew);

                    clearUpdate();
                    Session["JustToConfirm"] = null;
                    Session["DoSomething"] = "DoSomething";
                    Response.Redirect("DoSomething.aspx");
                    break;

                case "21.1KMS/Half Marathon":
                    //TShirtCount();
                    _dbRepository.UpdateQueryRegistrationPage2("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "",
                        "", "", proceedToConfirm, proceedtoPayment, "", "21");
                    
                    dtNew = getDataForPaymentBeforeTable("[21kms]");
                    insertDataForPaymentBeforeTable(dtNew);

                    clearUpdate();
                    Session["JustToConfirm"] = null;
                    Session["DoSomething"] = "DoSomething";
                    Response.Redirect("DoSomething.aspx");

                    break;

                case "Student 21.1KMS/Half Marathon":
                    //TShirtCount();
                    _dbRepository.UpdateQueryRegistrationPage2("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "",
                        "", "", proceedToConfirm, proceedtoPayment, "", "S21");

                    dtNew = getDataForPaymentBeforeTable("[21kms]");
                    insertDataForPaymentBeforeTable(dtNew);

                    clearUpdate();
                    Session["JustToConfirm"] = null;
                    Session["DoSomething"] = "DoSomething";
                    Response.Redirect("DoSomething.aspx");

                    break;

                case "42.2KMS/Full Marathon":
                    //TShirtCount();
                    _dbRepository.UpdateQueryRegistrationPage2("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "",
                        "", "", proceedToConfirm, proceedtoPayment, "", "42");
                    
                    dtNew = getDataForPaymentBeforeTable("[42kms]");
                    insertDataForPaymentBeforeTable(dtNew);

                    clearUpdate();
                    Session["JustToConfirm"] = null;
                    Session["DoSomething"] = "DoSomething";
                    Response.Redirect("DoSomething.aspx");

                    break;

                case "Student 42.2KMS/Full Marathon":
                    //TShirtCount();
                    _dbRepository.UpdateQueryRegistrationPage2("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "",
                        "", "", proceedToConfirm, proceedtoPayment, "", "S42");
                    
                    dtNew = getDataForPaymentBeforeTable("[42kms]");
                    insertDataForPaymentBeforeTable(dtNew);

                    clearUpdate();
                    Session["JustToConfirm"] = null;
                    Session["DoSomething"] = "DoSomething";
                    Response.Redirect("DoSomething.aspx");

                    break;
                default:
                    break;
            }
        }

        DataTable getDataForPaymentBeforeTable(string table)
        {
            string type = Session["type"].ToString();
            string email = Session["email"].ToString();
            DataTable dt = new DataTable();

            switch (type)
            {
                case "50":
                    dt = commmonSelectQueryDT(table, "Email");
                    return dt;
                    break;

                case "S50":
                    dt = commmonSelectQueryDT(table, "Email");
                    return dt;
                    break;

                case "21":
                    dt = commmonSelectQueryDT(table, "Email");
                    return dt;
                    break;

                case "S21":
                    dt = commmonSelectQueryDT(table, "Email");
                    return dt;
                    break;

                case "42":
                    dt = commmonSelectQueryDT(table, "Email");
                    return dt;
                    break;

                case "S42":
                    dt = commmonSelectQueryDT(table, "Email");
                    return dt;
                    break;

                default:
                    break;
            }
            return dt;
        }
        /// <summary>
        /// Insert data to the new table before payment
        /// with this data you can get all the details of the registrents in the aaresponsepage.
        /// </summary>
        /// <param name="dt"></param>
        void insertDataForPaymentBeforeTable(DataTable dt)
        {

        }

        DataTable commmonSelectQueryDT(string table, string firstCondition)
        {

            string tableToLook = table.Trim();
            string condition1 = firstCondition.Trim();

            string email = Session["email"].ToString();
            string selectQuery = "select * from " + tableToLook + " where " + condition1 + "='" + email.Trim() + "'";
            SqlCommand myCommond = new SqlCommand(selectQuery, con);
            SqlDataAdapter myAdap = new SqlDataAdapter(myCommond);
            DataTable dt = new DataTable();
            myAdap.Fill(dt);
            return dt;
        }

        #region TShirtCount
        void TShirtCount()
        {
            string Amount = string.Empty;
            string tshirt = string.Empty;

            switch (ddlUTshirt.SelectedItem.Text.Trim())
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

    }
}