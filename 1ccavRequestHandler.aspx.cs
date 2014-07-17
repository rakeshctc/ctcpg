﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CCA.Util;

    public partial class SubmitData : System.Web.UI.Page
    {
        CCACrypto ccaCrypto = new CCACrypto();
        string workingKey = "79226183BBAE50766E8383CEA3FF089D";//put in the 32bit alpha numeric key in the quotes provided here 	
        string ccaRequest = "";
        public string iframeSrc = "";
        public string strEncRequest = "";
        public string strAccessCode = "AVSY01BF68AJ02YSJA"; // put the access code in the quotes provided here.

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                foreach (string name in Request.Form)
                {
                    if (name != null)
                    {
                        if (!name.StartsWith("_"))
                        {
                            ccaRequest = ccaRequest + name + "=" + Request.Form[name] + "&";
                            /* Response.Write(name + "=" + Request.Form[name]);
                              Response.Write("</br>");*/
                        }
                    }
                }
                strEncRequest = ccaCrypto.Encrypt(ccaRequest, workingKey);
                iframeSrc = "https://secure.ccavenue.com/transaction/transaction.do?command=initiateTransaction&encRequest=" + strEncRequest + "&access_code=" + strAccessCode;
            }

        }
    }
