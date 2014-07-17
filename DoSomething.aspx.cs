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
    public partial class DoSomething : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString);
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["DoSomething"] == null)
            {
                Response.Redirect("default.aspx");
            }
        }
        public string merchant_id
        {
            get
            {
                //string strCheckSum = objLib.getchecksum("YourMerchantID", Session["ClientID"].ToString(), strAmount, "UrReturnUrl", "your working key");
                string merchant_id = "35707";
                return merchant_id;
            }
        }


        public string billing_email
        {
            get
            {
                string billing_email = string.Empty;
                string emailNew = Session["email"].ToString();
                //string strCheckSum = objLib.getchecksum("YourMerchantID", Session["ClientID"].ToString(), strAmount, "UrReturnUrl", "your working key");
                billing_email = emailNew;
                return billing_email;
            }
        }

        public string amount
        {
            get
            {
                string email = Session["email"].ToString().Trim();
                string tShirt = Session["tShirt"].ToString().Trim();
                string selectTShirtCount = "select Amount from TShirtCount where Email='" + email + "' and TShirt='" + tShirt + "'";
                SqlCommand cmdTShirtCount = new SqlCommand(selectTShirtCount, con);
                SqlDataAdapter aDapTShirtCount = new SqlDataAdapter(cmdTShirtCount);
                DataTable dtTShirtCount = new DataTable();
                aDapTShirtCount.Fill(dtTShirtCount);

                string amountNew = dtTShirtCount.Rows[0][0].ToString();

                string amount = amountNew;
                return amount;
            }
        }

        public int order_id
        {
            get
            {
                string email = Session["email"].ToString().Trim();
                string tShirt = Session["tShirt"].ToString().Trim();
                string selectorder_id = "select ID from TShirtCount where Email='" + email + "' and TShirt='" + tShirt + "'";
                SqlCommand cmdorder_id = new SqlCommand(selectorder_id, con);
                SqlDataAdapter aDaporder_id = new SqlDataAdapter(cmdorder_id);
                DataTable dtorder_id = new DataTable();
                aDaporder_id.Fill(dtorder_id);

                int orderID =Convert.ToInt32(dtorder_id.Rows[0][0]);

                int order_id = orderID;
                return order_id;
            }
        }

        public string currency
        {
            get
            {
                //string strCheckSum = objLib.getchecksum("YourMerchantID", Session["ClientID"].ToString(), strAmount, "UrReturnUrl", "your working key");
                string currency = "INR";
                return currency;
            }
        }

        public string redirect_url
        {
            get
            {
                //string strCheckSum = objLib.getchecksum("YourMerchantID", Session["ClientID"].ToString(), strAmount, "UrReturnUrl", "your working key");
                string redirect_url = "http://www.chennaitrekkingclubevents.org/ccavResponseHandler.aspx";
                return redirect_url;
            }
        }

        public string cancel_url
        {
            get
            {
                //string strCheckSum = objLib.getchecksum("YourMerchantID", Session["ClientID"].ToString(), strAmount, "UrReturnUrl", "your working key");
                string cancel_url = "http://www.chennaitrekkingclubevents.org/CancelledPage.aspx";
                return cancel_url;
            }
        }
    }
}