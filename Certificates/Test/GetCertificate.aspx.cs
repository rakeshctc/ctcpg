using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
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
                //Data Source=184.168.194.70;Initial Catalog=ittitudeworks; User ID=rakesh123; Password=Rakesh@123; Trusted_Connection=False
                DataTable dt = new DataTable();
                using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
                {
                    using (SqlCommand cmd = new SqlCommand("select * from all_triathlon_timing where GUID='" + abc.ToString() + "'", con))
                    {
                        con.Open();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);

                        string bib = dt.Rows[0][1].ToString();
                        string name = dt.Rows[0][2].ToString();
                        string swim = dt.Rows[0][3].ToString();
                        string cycle = dt.Rows[0][4].ToString();
                        string run = dt.Rows[0][5].ToString();
                        string category = dt.Rows[0][6].ToString();
                        string total = dt.Rows[0][7].ToString();

                        HtmlMeta tag = new HtmlMeta();
                        tag.Attributes.Add("property", "og:title");
                        tag.Content = name;
                        Page.Header.Controls.Add(tag);

                        HtmlMeta tag1 = new HtmlMeta();
                        tag1.Attributes.Add("property", "og:description");
                        tag1.Content = "CTM 2014";
                        Page.Header.Controls.Add(tag1);

                        HtmlMeta tagurl = new HtmlMeta();
                        tagurl.Attributes.Add("property", "og:url");
                        tagurl.Content = "http://www.Chennaitrekkingclubevents.org/Certificates/Test/Images/AllImages/" + bib.Trim() + ".png";
                        Page.Header.Controls.Add(tagurl);

                        HtmlMeta tagimg = new HtmlMeta();
                        tagimg.Attributes.Add("property", "og:img");
                        tagimg.Content = "http://www.Chennaitrekkingclubevents.org/Certificates/Test/Images/AllImages/" + bib.Trim() + ".png";
                        Page.Header.Controls.Add(tagimg);

                        hfBib.Value = bib;
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
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
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