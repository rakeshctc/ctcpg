using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CTC_Final.Certificates.Test
{
    public partial class GetBIB : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataTable dtNew = new DataTable();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("select * from all_triathlon_timing", con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    con.Close();

                    int count = dt.Rows.Count;
                    if (count != 0)
                    {

                        using (SqlCommand cmdNew = new SqlCommand("select GUID from all_triathlon_timing where BIBNumber='" + txt123Bib.Text.Trim() + "'", con))
                        {
                            con.Open();
                            SqlDataAdapter daNew = new SqlDataAdapter(cmdNew);
                            daNew.Fill(dtNew);

                            string abc = dtNew.Rows[0][0].ToString();
                            Response.Redirect("GetCertificate.aspx?abc=" + abc);
                        }
                    }
                }
            }

        }
    }
}