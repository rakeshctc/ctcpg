using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CTC_Final.Certificates.Test
{
    public partial class GetCertificate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string abc = Request.QueryString["abc"];

            int bibCount = ConvertDataTabletoString(abc);

            if (bibCount != 0)
            {
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection("Data Source=184.168.194.70;Initial Catalog=ittitudeworks; User ID=rakesh123; Password=Rakesh@123; Trusted_Connection=False"))
                {
                    using (SqlCommand cmd = new SqlCommand("select * from all_triathlon_timing where GUID='" + abc.ToString() + "'", con))
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        string name = dt.Rows[0][2].ToString();
                        string swim = dt.Rows[0][3].ToString();
                        string cycle = dt.Rows[0][4].ToString();
                        string run = dt.Rows[0][5].ToString();
                        string category = dt.Rows[0][6].ToString();
                        string total = dt.Rows[0][7].ToString();

                        hfName.Value = name;
                        hfSwim.Value = swim;
                        hfCycle.Value = cycle;
                        hfRun.Value = run;
                        hfCategory.Value = category;
                        hfTotal.Value = total;
                    }
                }
            }
        }

        public int ConvertDataTabletoString(string bib)
        {
            int bibCount;
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=184.168.194.70;Initial Catalog=ittitudeworks; User ID=rakesh123; Password=Rakesh@123; Trusted_Connection=False"))
            {
                using (SqlCommand cmd = new SqlCommand("select * from all_triathlon_timing where GUID='" + bib.ToString() + "'", con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);

                    bibCount = dt.Rows.Count;

                    return bibCount;
                }
            }
        }
    }


}