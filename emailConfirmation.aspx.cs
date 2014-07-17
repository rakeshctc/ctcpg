using System;

namespace CTC_Final
{
    public partial class emailConfirmation : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["emailConfirmation"] == null)
            {
                Response.Redirect("default.aspx");
            }
            else
            {
                Session["emailConfirmation"] = null;
                Session["SelectEvent"] = "true";
                Response.Redirect("SelectEvent.aspx");
            }
        }
    }
}