using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CTC_Latest_4._0.Helper;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace CTC_Final
{
    public partial class SelectEvent : System.Web.UI.Page
    {
        CTC_Latest_4._0.DBRepository.DBRepository _dbRepository = new CTC_Latest_4._0.DBRepository.DBRepository();
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        UsingFunctions _usingFunctions = new UsingFunctions();
        Gujaals _gujaals = new Gujaals();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["SelectEvent"] == null)
            {
                Response.Redirect("default.aspx");
            }
        }

        private void MessageBox(string message, string title = "title")
        {
            ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), title, "alert('" + message + "');", true);
        }

        protected void btnProceed_Click(object sender, EventArgs e)
        {
            if (rbtn10KM.Checked == true || rbtn21kms.Checked == true || rbn42kms.Checked == true ||
                rbtnStudents21.Checked == true || rbtnStudents42.Checked == true || rbtnStudents50.Checked == true)
            {
                //Student 21Km
                if (rbtnStudents21.Checked == true)
                {
                    if (chkbxTermsnConditions.Checked == true)
                    {
                        string email = Session["email"].ToString();
                        string guid = Session["guid"].ToString();

                        string selectQueryGetemail = "select * from [21kms] where Email='" + email + "'";
                        SqlCommand cmdGetemail = new SqlCommand(selectQueryGetemail, conn);
                        SqlDataAdapter aDapGetemail = new SqlDataAdapter(cmdGetemail);
                        DataTable dtGetemail = new DataTable();
                        aDapGetemail.Fill(dtGetemail);

                        int emailCount = dtGetemail.Rows.Count;

                        string emailConfirmation = ((string)Session["Check"] == "nothing") ? "Success" : "Pending";


                        Session["type"] = "S21";

                        if (emailCount == 0)
                        {
                            //OrderIDGeneration();
                            _dbRepository.InsertQueryCategory("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", emailConfirmation, "S21", "1");
                            Session["Registration"] = "true";
                            Session["SelectEvent"] = null;
                            Response.Redirect("Registration.aspx");
                        }
                        else
                        {
                            //OrderIDGeneration();
                            _dbRepository.InsertQueryCategory("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", emailConfirmation, "S21", "0");
                            Session["Registration"] = "true";
                            Session["SelectEvent"] = null;
                            Response.Redirect("Registration.aspx");
                        }
                    }
                    else
                    {
                        MessageBox("Kindly Read and Select the Terms and Conditions.");
                    }
                }

                //Student 42
                if (rbtnStudents42.Checked == true)
                {
                    if (chkbxTermsnConditions.Checked == true)
                    {
                        string email = Session["email"].ToString();
                        string guid = Session["guid"].ToString();

                        string selectQueryGetemail = "select * from [42kms] where Email='" + email + "'";
                        SqlCommand cmdGetemail = new SqlCommand(selectQueryGetemail, conn);
                        SqlDataAdapter aDapGetemail = new SqlDataAdapter(cmdGetemail);
                        DataTable dtGetemail = new DataTable();
                        aDapGetemail.Fill(dtGetemail);

                        int emailCount = dtGetemail.Rows.Count;

                        string emailConfirmation = ((string)Session["Check"] == "nothing") ? "Success" : "Pending";


                        Session["type"] = "S42";

                        if (emailCount == 0)
                        {
                            //OrderIDGeneration();
                            _dbRepository.InsertQueryCategory("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", emailConfirmation, "S42", "1");
                            Session["Registration"] = "true";
                            Session["SelectEvent"] = null;
                            Response.Redirect("Registration.aspx");
                        }
                        else
                        {
                            //OrderIDGeneration();
                            _dbRepository.InsertQueryCategory("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", emailConfirmation, "S42", "0");
                            Session["Registration"] = "true";
                            Session["SelectEvent"] = null;
                            Response.Redirect("Registration.aspx");
                        }
                    }
                    else
                    {
                        MessageBox("Kindly Read and Select the Terms and Conditions.");
                    }
                }


                //Student 50
                if (rbtnStudents50.Checked == true)
                {
                    if (chkbxTermsnConditions.Checked == true)
                    {
                        string email = Session["email"].ToString();
                        string guid = Session["guid"].ToString();

                        string selectQueryGetemail = "select * from [10kms] where Email='" + email + "'";
                        SqlCommand cmdGetemail = new SqlCommand(selectQueryGetemail, conn);
                        SqlDataAdapter aDapGetemail = new SqlDataAdapter(cmdGetemail);
                        DataTable dtGetemail = new DataTable();
                        aDapGetemail.Fill(dtGetemail);

                        int emailCount = dtGetemail.Rows.Count;

                        string emailConfirmation = ((string)Session["Check"] == "nothing") ? "Success" : "Pending";


                        Session["type"] = "S50";

                        if (emailCount == 0)
                        {
                            //OrderIDGeneration();
                            _dbRepository.InsertQueryCategory("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", emailConfirmation, "S50", "1");
                            Session["Registration"] = "true";
                            Session["SelectEvent"] = null;
                            Response.Redirect("Registration.aspx");
                        }
                        else
                        {
                            //OrderIDGeneration();
                            _dbRepository.InsertQueryCategory("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", emailConfirmation, "S50", "0");
                            Session["Registration"] = "true";
                            Session["SelectEvent"] = null;
                            Response.Redirect("Registration.aspx");
                        }
                    }
                    else
                    {
                        MessageBox("Kindly Read and Select the Terms and Conditions.");
                    }
                }



                //Open 50
                if (rbtn10KM.Checked == true)
                {
                    if (chkbxTermsnConditions.Checked == true)
                    {
                        string email = Session["email"].ToString();
                        string guid = Session["guid"].ToString();

                        string selectQueryGetemail = "select * from [10kms] where Email='" + email + "'";
                        SqlCommand cmdGetemail = new SqlCommand(selectQueryGetemail, conn);
                        SqlDataAdapter aDapGetemail = new SqlDataAdapter(cmdGetemail);
                        DataTable dtGetemail = new DataTable();
                        aDapGetemail.Fill(dtGetemail);

                        int emailCount = dtGetemail.Rows.Count;

                        string emailConfirmation = ((string)Session["Check"] == "nothing") ? "Success" : "Pending";


                        Session["type"] = "50";

                        if (emailCount == 0)
                        {
                            //OrderIDGeneration();
                            _dbRepository.InsertQueryCategory("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", emailConfirmation, "50", "1");
                            Session["Registration"] = "true";
                            Session["SelectEvent"] = null;
                            Response.Redirect("Registration.aspx");
                        }
                        else
                        {
                            //OrderIDGeneration();
                            _dbRepository.InsertQueryCategory("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", emailConfirmation, "50", "0");
                            Session["Registration"] = "true";
                            Session["SelectEvent"] = null;
                            Response.Redirect("Registration.aspx");
                        }
                    }
                    else
                    {
                        MessageBox("Kindly Read and Select the Terms and Conditions.");
                    }
                }

                if (rbtn21kms.Checked == true)
                {
                    if (chkbxTermsnConditions.Checked == true)
                    {
                        string emailConfirmation = (Session["Check"] == "nothing") ? "Success" : "Pending";

                        string email = Session["email"].ToString();
                        string guid = Session["guid"].ToString();

                        string selectQueryGetemail = "select * from [21kms] where Email='" + email + "'";
                        SqlCommand cmdGetemail = new SqlCommand(selectQueryGetemail, conn);
                        SqlDataAdapter aDapGetemail = new SqlDataAdapter(cmdGetemail);
                        DataTable dtGetemail = new DataTable();
                        aDapGetemail.Fill(dtGetemail);

                        int emailCount = dtGetemail.Rows.Count;

                        Session["type"] = "21";
                        if (emailCount == 0)
                        {
                            //OrderIDGeneration();
                            _dbRepository.InsertQueryCategory("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", emailConfirmation, "21", "1");
                            Session["Registration"] = "true";
                            Session["SelectEvent"] = null;
                            Response.Redirect("Registration.aspx");
                        }
                        else
                        {
                            //OrderIDGeneration();
                            _dbRepository.InsertQueryCategory("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", emailConfirmation, "21", "0");
                            Session["Registration"] = "true";
                            Session["SelectEvent"] = null;
                            Response.Redirect("Registration.aspx");
                        }
                    }
                    else
                    {
                        MessageBox("Kindly Read and Select the Terms and Conditions.");
                    }
                }

                if (rbn42kms.Checked == true)
                {
                    if (chkbxTermsnConditions.Checked == true)
                    {
                        string emailConfirmation = (Session["Check"] == "nothing") ? "Success" : "Pending";

                        string email = Session["email"].ToString();
                        string guid = Session["guid"].ToString();

                        string selectQueryGetemail = "select * from [42kms] where Email='" + email + "'";
                        SqlCommand cmdGetemail = new SqlCommand(selectQueryGetemail, conn);
                        SqlDataAdapter aDapGetemail = new SqlDataAdapter(cmdGetemail);
                        DataTable dtGetemail = new DataTable();
                        aDapGetemail.Fill(dtGetemail);

                        int emailCount = dtGetemail.Rows.Count;

                        Session["type"] = "42";
                        if (emailCount == 0)
                        {
                            //OrderIDGeneration();
                            _dbRepository.InsertQueryCategory("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", emailConfirmation, "42", "1");
                            Session["Registration"] = "true";
                            Session["SelectEvent"] = null;
                            Response.Redirect("Registration.aspx");
                        }
                        else
                        {
                            //OrderIDGeneration();
                            _dbRepository.InsertQueryCategory("", email, "", guid, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", emailConfirmation, "42", "0");
                            Session["Registration"] = "true";
                            Session["SelectEvent"] = null;
                            Response.Redirect("Registration.aspx");
                        }
                    }
                    else
                    {
                        MessageBox("Kindly Read and Select the Terms and Conditions.");
                    }
                }
            }
            else
            {
                MessageBox("Select your desired category");
            }
        }


    }
}