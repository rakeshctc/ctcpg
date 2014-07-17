using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CTC_Final
{
    public partial class TermsandConditions : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            StreamReader sr;
            string html;
            string path = Server.MapPath("~/terms.html");

            sr = File.OpenText(path);
            html = sr.ReadToEnd();
            lblDisplayTerms.Text = html;
            sr.Close();
        }
    }
}