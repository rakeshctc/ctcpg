<%@ Page Language="C#" AutoEventWireup="true" Inherits="ResponseHandler" CodeBehind="ccavResponseHandler.aspx.cs" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Chennai Trekking Club</title>

    <link href="Layout/bootstrap.min.css" rel="stylesheet" />
    <link href="Layout/custom.css" rel="stylesheet" />
    <script src="Layout/jquery.min.js" type="text/javascript"></script>
    <script src="Layout/bootstrap.min.js" type="text/javascript"></script>

</head>
<body>
    <form id="form1" runat="server">
        <div class="well col-md-12" style="height: 100%; background-color: white;">

             <div class="navbar navbar-inverse navbar-fixed-top" role="navigation">
            <div class="container">
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".navbar-collapse">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand">
                        <img id="imgLogo" src="Images/Chennai_Trekking_Club.jpg" style="height: 35px; width: 35px; margin-top: -7px;" />
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
                            <%--<li><a href="Login.aspx" target="_blank">Log-In   </a>
                            </li>--%>
                        </ul>
                    </ul>
                </div>
                <!--/.nav-collapse -->
            </div>
        </div>

            <div id="divmain" class="col-md-12 col-xs-11 text-center" runat="server">
                <asp:HiddenField ID="cat" runat="server" />
                <asp:Label class="btn-sm btn-success" runat="server" ID="Label1">Email Confirmation</asp:Label>
                <asp:Label class="btn-sm btn-success" runat="server" ID="Label2">Select Event</asp:Label>
                <asp:Label class="btn-sm btn-success" runat="server" ID="lblRegistration">Registration</asp:Label>
                <asp:Label class="btn-sm btn-success" runat="server" ID="lblConfimation">Confirm Before Proceed</asp:Label>
                <asp:Label class="btn-sm btn-success" runat="server" ID="Label3">Payment</asp:Label>
                <asp:Label class="btn-sm label-primary" runat="server" ID="Label4">Ticket</asp:Label>
                <hr />
            </div>

            <div class="col-md-12 well text-left" style="height: 100%; background-color: white; vertical-align: central">
                <div class="row col-md-12">
                    <div class="col-md-3 ">
                        <asp:Image ID="img1" runat="server" ImageUrl="~/Images/Chennai_Trekking_Club.jpg" Width="200px" />
                    </div>
                    <div class="col-md-6 text-center">
                        <h6>Chennai Trekking Club's</h6>
                        <br />
                        <h6>Chennai Trail Marathon 2014</h6>
                    </div>
                    <div class="col-md-3 ">
                        <asp:Image ID="Img2" runat="server" ImageUrl="~/Images/Chennai_Trekking_Club.jpg" Width="200px" />
                    </div>
                </div>
                <div class="row col-md-12 ">
                    <br />
                    <br />
                    <p>
                        Dear
                    <asp:Label ID="lblDisPlayName1" runat="server"></asp:Label>,
                    </p>
                    <asp:HiddenField ID="hd" runat="server" />
                    
                    <p>This is to confirm your participation for Chennai Trail Marathon.</p>

                    <p>Details for your participation for the Event.</p>

                    <p>
                        Name :<asp:Label ID="lblDisPlayName" runat="server"></asp:Label>
                    </p>

                    <p>
                        Age :<asp:Label ID="lblDisPlayAge" runat="server"></asp:Label>
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <br />
                        <asp:Image ID="imgBarcodePic" runat="server" />
                        <asp:PlaceHolder ID="PlaceHolder1" Visible="false" runat="server" />
                    </p>

                    <p>
                        Phone:
                            <asp:Label ID="lblDisPlayPhone" runat="server"></asp:Label>
                    </p>

                    <p>
                        Email:
                            <asp:Label ID="lblDisPlayEmail" runat="server"></asp:Label>
                    </p>

                    <p>
                        Bib Number:
                            <asp:Label ID="lblDisPlayBibNumber" runat="server"></asp:Label>
                    </p>

                    <p>
                        Category :
                            <asp:Label ID="lblDisPlayCategory" runat="server"></asp:Label>
                    </p>

                    <p>
                        Ticket Number:
                            <asp:Label ID="lblDisPlayTicketNumber" runat="server"></asp:Label>
                    </p>
                    <br />
                    <p>If you don't get an E-mail/SMS from us within 1 hour then do write to us at letsrun@chennaitrekkers.org</p>
                    <br />
                    <p>Regards</p>
                    <br />
                    <p>Team CTM</p>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
