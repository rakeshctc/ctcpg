using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CTC_Final.Certificates
{
    public partial class data : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string bib = Request.QueryString["bib"];

            var output = ConvertDataTabletoString(bib);

           // lbldata.Text = output.ToString();
        }

        public string ConvertDataTabletoString(string bib)
        {
            DataTable dt = new DataTable();
            using (SqlConnection con = new SqlConnection("Data Source=184.168.194.70;Initial Catalog=ittitudeworks;User ID=rakesh123; Password=Rakesh@123; Trusted_Connection=False"))
            {
                using (SqlCommand cmd = new SqlCommand("select * from all_triathlon_timing where BIBNumber='" + bib.ToString() + "'", con))
                {
                    con.Open();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    System.Web.Script.Serialization.JavaScriptSerializer serializer = new System.Web.Script.Serialization.JavaScriptSerializer();
                    List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();
                    Dictionary<string, object> row;
                    foreach (DataRow dr in dt.Rows)
                    {
                        row = new Dictionary<string, object>();
                        foreach (DataColumn col in dt.Columns)
                        {
                            row.Add(col.ColumnName, dr[col]);
                        }
                        rows.Add(row);
                    }
                    return serializer.Serialize(rows);
                }
            }
        }
    }
}