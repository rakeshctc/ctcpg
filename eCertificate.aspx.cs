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
    public partial class eCertificate : System.Web.UI.Page
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            string selectQuery = "select EventName,EventDate,EventCertificate,EventDataSource,EventPoster,EventOrganizer from Certificate_Table ORDER BY ID DESC";
            SqlCommand cmd = new SqlCommand(selectQuery, conn);
            SqlDataAdapter Adap = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            Adap.Fill(dt);

          //  dlCertificate.DataSource = dt;
            //dlCertificate.DataBind();

        }

        private void MessageBox(string message, string title = "title")
        {
            ScriptManager.RegisterStartupScript(this.Page, this.Page.GetType(), title, "alert('" + message + "');", true);
        }

        protected void btnGetCertificate1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Certificates/CTMar292014/Default.aspx");
        }

        protected void btnGetCertificate2_Click(object sender, EventArgs e)
        {
           MessageBox("This event's Certificate issued in Person");
        }

        protected void btnGetCertificate3_Click(object sender, EventArgs e)
        {
            Response.Redirect("Certificates/CTM2013/Default.html");
        }

        protected void btnCTJuly12_Click(object sender, EventArgs e)
        {
            Response.Redirect("Certificates/CTJuly122014/July12.aspx");
        }

        protected void btnCTJuly13_Click(object sender, EventArgs e)
        {
            Response.Redirect("Certificates/CTJuly132014/July13.aspx");
        }
    }
}