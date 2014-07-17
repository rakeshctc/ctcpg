<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GetBIB.aspx.cs" Inherits="CTC_Final.Certificates.Test.GetBIB" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <title>Chennai Triathlon e-Certificate</title>

    <script src="jquery.min.js"></script>
    <link href="flat-ui.css" rel="stylesheet" />
    <link href="demo.css" rel="stylesheet" />
</head>
<body>
    <form id="formJuly12" runat="server">
        <div class="navbar navbar-inverse navbar-fixed-top" role="navigation">
            <div class="container">
                <div class="navbar-header">
                    <a class="navbar-brand">
                        <img id="imgLogo" src="../../Images/123.png" style="height: 50px; width: 100px;" />
                        Chennai Trekking Club</a>
                </div>
                <div class="collapse navbar-collapse">
                    <ul class="nav navbar-nav">
                        <ul class="nav navbar-nav  text-right">
                            <li><a href="#"></a>
                            </li>
                            <li><a href="#"></a>
                            </li>
                            <li><a href="#"></a>
                            </li>
                            <li><a href="#"></a>
                            </li>

                            <li><a href="Default.aspx">Home</a>
                            </li>

                            <li><a href="eCertificate.aspx" target="_blank">Certificate</a>
                            </li>

                            <li><a href="FAQ.aspx" target="_blank">FAQ</a>
                            </li>
                            <li><a href="TermsandConditions.aspx" target="_blank">Terms & Condition</a>
                            </li>
                            <li><a href="Support.aspx" target="_blank">Support</a>
                            </li>
                        </ul>
                    </ul>
                </div>
                <!--/.nav-collapse -->
            </div>
        </div>

        <div>
            <center>
                 <h1 class="demo-section-title">Chennai Trekking Club Chennai Triathlon July 12, 2014</h1>
                 <p>Supported only in Chrome and Mozilla Firefox browsers</p>
                 <p>
                     <%--<input type="text" value="" placeholder="Your BIB" id="bib" class="form-control" />--%>
                     <asp:TextBox ID="txt123Bib" runat="server" placeholder="Bib Number" Width="100px" CssClass="form-control login-field" ></asp:TextBox>
                     <%--<asp:TextBox ID="txtBib" runat="server" placeholder="Bib Number" Width="100px" CssClass="form-control login-field"></asp:TextBox>--%>
                     <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="submit-btn btn btn-block btn-lg btn-primary" place OnClick="btnSubmit_Click" />
                     <%--<input type="button" onclick="formSubmit()" value="Submit" class="submit-btn btn btn-block btn-lg btn-primary" /></p>--%>
                 
            </center>
        </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <!-- /footer container -->
        <footer id="footer">
            <div class="container text-center" style="text-align: center; width: 100%">
                <asp:LinkButton ID="LinkButton2" runat="server" OnClientClick="window.open('TermsandConditions.aspx'); " ForeColor="Black" Target="_blank">Terms</asp:LinkButton>
                |
                <asp:LinkButton ID="LinkButton3" runat="server" OnClientClick="window.open('aboutUs.aspx'); " ForeColor="Black" Target="_blank">About Us</asp:LinkButton>
                <br />
                <br />
                <p class="text-muted">Developed by Ittitudeworks.com</p>
            </div>
        </footer>
    </form>
</body>
</html>
