<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RunNow.aspx.cs" Inherits="CTC_Final.RunNow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <%-- Datepicker --%>
    <link rel="stylesheet" href="//code.jquery.com/ui/1.10.4/themes/smoothness/jquery-ui.css" />
    <script src="//code.jquery.com/jquery-1.10.2.js"></script>
    <script src="//code.jquery.com/ui/1.10.4/jquery-ui.js"></script>
    <link rel="stylesheet" href="/resources/demos/style.css" />
    <script type="text/javascript">
        var jquery104min = $.noConflict(true);
    </script>

    <script>
        jquery104min(function () {
            jquery104min("#<%= txtUDOB.ClientID %>").datepicker(
                {
                    changeMonth: true,
                    changeYear: true,
                    yearRange: '-90:+0',
                    altField: '[id$=HiddenField1]'
                });
            if ($("[id$=HiddenField1]").attr("Value").length > 0) {
                $("[id$=txtDate]").datepicker("setDate", new Date($("[id$=HiddenField1]").attr("Value")));
            }
        });
    </script>

    <script>
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
            m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

        ga('create', 'UA-51278344-1', 'chennaitrekkingclubevents.org');
        ga('send', 'pageview');

    </script>

    <script type="text/javascript">
        jquery104min(document).ready(function () {
            //called when key is pressed in textbox

            jquery104min("#<%= txtUEmergencyContactNumber.ClientID %>").keypress(function (e) {
                //if the letter is not digit then display error and don't type anything
                if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
                    //display error message
                    jquery104min("#errmsg").html("Digits Only").show().fadeOut("slow");
                    return false;
                }
            });
        });


        jquery104min(document).ready(function () {
            //called when key is pressed in textbox

            jquery104min("#<%= txtUPhone.ClientID %>").keypress(function (e) {
                //if the letter is not digit then display error and don't type anything
                if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
                    //display error message
                    jquery104min("#errmsg").html("Digits Only").show().fadeOut("slow");
                    return false;
                }
            });
        });

    </script>

    <style type="text/css">
        .black_overlay {
            display: none;
            position: absolute;
            top: 0%;
            left: 0%;
            width: 100%;
            height: 100%;
            background-color: black;
            z-index: 1001;
            -moz-opacity: 0.8;
            opacity: .80;
            filter: alpha(opacity=80);
        }

        .white_content {
            display: none;
            position: absolute;
            top: 25%;
            left: 25%;
            width: 50%;
            height: 50%;
            padding: 16px;
            border: 16px solid orange;
            background-color: white;
            z-index: 1002;
            overflow: auto;
        }
    </style>

    <link href="Layout/bootstrap.min.css" rel="stylesheet" />
    <link href="Layout/custom.css" rel="stylesheet" />
    <script src="Layout/jquery.min.js"></script>
    <script src="Layout/bootstrap.min.js"></script>

    <style type="text/css">
        .navbar-inverse {
            background-color: #34495e;
            border-color: #080808;
        }

            .navbar-inverse .navbar-brand {
                color: #fff;
            }

            .navbar-inverse .navbar-nav > li > a {
                color: #fff;
            }
    </style>

    <script>
        (function (i, s, o, g, r, a, m) {
            i['GoogleAnalyticsObject'] = r; i[r] = i[r] || function () {
                (i[r].q = i[r].q || []).push(arguments)
            }, i[r].l = 1 * new Date(); a = s.createElement(o),
            m = s.getElementsByTagName(o)[0]; a.async = 1; a.src = g; m.parentNode.insertBefore(a, m)
        })(window, document, 'script', '//www.google-analytics.com/analytics.js', 'ga');

        ga('create', 'UA-51278344-1', 'chennaitrekkingclubevents.org');
        ga('send', 'pageview');

    </script>

</head>
<body>
    <form method="post" runat="server" name="customerData">

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

        <div class="well col-md-12" style="height: 100%; background-color: white;">
            <div id="divmain" class="col-md-12 col-xs-11 text-center" runat="server">
                <asp:Label class="btn-sm btn-success" runat="server" ID="Label1">Email Confirmation</asp:Label>
                <asp:Label class="btn-sm btn-success" runat="server" ID="Label2">Select Event</asp:Label>
                <asp:Label class="btn-sm btn-success" runat="server" ID="lblRegistration">Registration</asp:Label>
                <asp:Label class="btn-sm label-primary" runat="server" ID="lblConfimation">Confirm Before Proceed</asp:Label>
                <asp:Label class="btn-sm btn-danger" runat="server" ID="Label3">Payment</asp:Label>
                <asp:Label class="btn-sm btn-danger" runat="server" ID="Label4">Ticket</asp:Label>
                <hr />
            </div>
            <div class="col-md-12 text-center" style="height: 100%; background-color: white; vertical-align: central">
                <div id="divConfirmPersonalInformation" class="col-md-12 " runat="server">
                    <div class="container">
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Name:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txtNomineeName" placeholder="Name" runat="server"></asp:Label>
                                    <input type="text" runat="server" visible="false" name="merchant_id" id="merchant_id" value="35707" />
                                    <input id="Text1" type="text" runat="server" visible="false" name="order_id" value="123454789" readonly="true" />
                                    <input id="Text2" type="text" runat="server" visible="false" name="amount" value="1.00" />
                                    <input id="Text3" type="text" runat="server" visible="false" name="currency" value="INR" />
                                    <input id="Text4" type="text" runat="server" visible="false" name="redirect_url" value="http://www.chennaitrekkingclubevents.org/ccavResponseHandler.aspx" />
                                    <input id="Text5" type="text" runat="server" visible="false" name="cancel_url" value="http://www.chennaitrekkingclubevents.org/support.aspx" />
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Email:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="lblEmail" placeholder="Name" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Phone:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txtPhone" runat="server" placeholder="99XXXXXXXX" MaxLength="10"></asp:Label>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6 " style="text-align: right">BIB Name:</div>
                                <div class="col-xs-12 col-md-6 " style="text-align: left">
                                    <asp:Label ID="txtBIBName" runat="server" placeholder="Name on the BIB"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Date Of Birth:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txtDOB" runat="server" placeholder="dd/mm/yyyy"></asp:Label>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Age:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txtAge" runat="server" placeholder="20"></asp:Label>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Category:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txtCategory" runat="server" placeholder="20"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <%--<asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>--%>

                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Gender:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txtGender" runat="server" placeholder="20"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Blood Group:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txtBloodGroup" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Country:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txtCountry" placeholder="Reside In Which State" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">State:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txtState" placeholder="Reside In Which State" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">City:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txtCity" runat="server" placeholder="Reside In Which City"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">T-Shirt Size:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txtTShirtSize" placeholder="Reside In Which State" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Emergency Contact Person:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txtEmergencyContactPerson" placeholder="Contact Person" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Emergency Contact Number:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txtEmergencyContactPersonNumber" placeholder="99XXXXXXXX" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>

                        <div class="row">

                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Type of ID:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txt1TypeofID" placeholder="Reside In Which State" runat="server"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -120px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Type-In Id Number:</div>
                                <div class="col-xs-12 col-md-6" style="text-align: left">
                                    <asp:Label ID="txtIDNumber" runat="server" placeholder="XXXXXXXXX"></asp:Label>
                                </div>
                            </div>
                        </div>
                        <br>

                        <div id="divNextPreviousButton" runat="server">
                            <div class="row col-md-12">
                                <div class=" col-md-3 col-md-offset-2">

                                    <asp:Button ID="btnEditData" runat="server" class="btn btn-primary btn-large btn-block col-md-3" Text="Edit Given Data" OnClick="btnEditData_Click" />
                                </div>
                                <div class="col-md-3 col-md-offset-2">
                                    <%--<asp:Button ID="btnContinue" class="btn btn-primary btn-large btn-block col-md-3" runat="server" Text="Proceed To Payment" OnClick="btnContinue_Click" />--%>
                                    <input type="submit" class="btn btn-primary btn-large btn-block col-md-3" value="Checkout" />
                                    <table id="Table1" runat="server" visible="false">
                                        <tr>
                                            <td colspan="2">Billing information(optional):</td>
                                        </tr>
                                        <tr>
                                            <td>Billing Name</td>
                                            <td>
                                                <input type="text" name="billing_name" value="Charli" /></td>
                                        </tr>
                                        <tr>
                                            <td>Billing Address:</td>
                                            <td>
                                                <input type="text" name="billing_address" value="Room no 1101, near Railway station Ambad" /></td>
                                        </tr>
                                        <tr>
                                            <td>Billing City:</td>
                                            <td>
                                                <input type="text" name="billing_city" value="Indore" /></td>
                                        </tr>
                                        <tr>
                                            <td>Billing State:</td>
                                            <td>
                                                <input type="text" name="billing_state" value="MP" /></td>
                                        </tr>
                                        <tr>
                                            <td>Billing Zip:</td>
                                            <td>
                                                <input type="text" name="billing_zip" value="425001" /></td>
                                        </tr>
                                        <tr>
                                            <td>Billing Country:</td>
                                            <td>
                                                <input type="text" name="billing_country" value="India" /></td>
                                        </tr>
                                        <tr>
                                            <td>Billing Tel:</td>
                                            <td>
                                                <input type="text" name="billing_tel" value="9595226054" /></td>
                                        </tr>
                                        <tr>
                                            <td>Billing Email:</td>
                                            <td>
                                                <input type="text" name="billing_email" value="atul.kadam@avenues.info" /></td>
                                        </tr>
                                        <tr>
                                            <td colspan="2">Shipping information(optional):</td>
                                        </tr>
                                        <tr>
                                            <td>Shipping Name</td>
                                            <td>
                                                <input type="text" name="delivery_name" value="Chaplin" /></td>
                                        </tr>
                                        <tr>
                                            <td>Shipping Address:</td>
                                            <td>
                                                <input type="text" name="delivery_address" value="room no.701 near bus stand" /></td>
                                        </tr>
                                        <tr>
                                            <td>shipping City:</td>
                                            <td>
                                                <input type="text" name="delivery_city" value="Hyderabad" /></td>
                                        </tr>
                                        <tr>
                                            <td>shipping State:</td>
                                            <td>
                                                <input type="text" name="delivery_state" value="Andhra" /></td>
                                        </tr>
                                        <tr>
                                            <td>shipping Zip:</td>
                                            <td>
                                                <input type="text" name="delivery_zip" value="425001" /></td>
                                        </tr>
                                        <tr>
                                            <td>shipping Country:</td>
                                            <td>
                                                <input type="text" name="delivery_country" value="India" /></td>
                                        </tr>
                                        <tr>
                                            <td>Shipping Tel:</td>
                                            <td>
                                                <input type="text" name="delivery_tel" value="9595226054" /></td>
                                        </tr>
                                        <tr>
                                            <td>Merchant Param1</td>
                                            <td>
                                                <input type="text" name="merchant_param1" value="additional Info." /></td>
                                        </tr>
                                        <tr>
                                            <td>Merchant Param2</td>
                                            <td>
                                                <input type="text" name="merchant_param2" value="additional Info." /></td>
                                        </tr>
                                        <tr>
                                            <td>Merchant Param3</td>
                                            <td>
                                                <input type="text" name="merchant_param3" value="additional Info." /></td>
                                        </tr>
                                        <tr>
                                            <td>Merchant Param4</td>
                                            <td>
                                                <input type="text" name="merchant_param4" value="additional Info." /></td>
                                        </tr>
                                        <tr>
                                            <td>Merchant Param5</td>
                                            <td>
                                                <input type="text" name="merchant_param5" value="additional Info." /></td>
                                        </tr>
                                        <tr>
                                            <td>Integration Type:</td>
                                            <td>
                                                <select name="integration_type">
                                                    <option value="iframe_normal">iframe_normal</option>
                                                </select>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>Promo Code</td>
                                            <td>
                                                <input type="text" name="promo_code" /></td>
                                        </tr>
                                        <tr>
                                            <td>Customer Id:</td>
                                            <td>
                                                <input type="text" name="customer_identifier" /></td>
                                        </tr>
                                    </table>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div id="divUpdatePersonalInformation" class="col-md-12 " visible="false" runat="server">
                    <div class="container">
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Name*</div>
                                <div class="col-xs-12 col-md-3" style="text-align: left">
                                    <asp:TextBox ID="txtUNomineeName" placeholder="Name" runat="server" CssClass="validate[required] form-control login-field"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Phone*</div>
                                <div class="col-xs-12 col-md-3" style="text-align: left">
                                    <asp:TextBox ID="txtUPhone" runat="server" placeholder="99XXXXXXXX" MaxLength="10" CssClass="validate[required,custom[phoneNumberNew] form-control login-field"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6 " style="text-align: right">BIB Name*</div>
                                <div class="col-xs-12 col-md-3 " style="text-align: left">
                                    <asp:TextBox ID="txtUBibName" runat="server" placeholder="Name on the BIB" CssClass="validate[required] form-control login-field"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Date Of Birth*</div>
                                <div class="col-xs-12 col-md-3" style="text-align: left">
                                    <asp:TextBox ID="txtUDOB" runat="server" ReadOnly="true" placeholder="dd/mm/yyyy" CssClass="validate[required] form-control login-field"></asp:TextBox>
                                    <asp:HiddenField ID="HiddenField1" runat="server" />
                                </div>
                            </div>
                        </div>



                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Gender*</div>
                                <div class="col-xs-12 col-md-3" style="text-align: left">

                                    <asp:DropDownList ID="ddlUGender" Width="255px" CssClass="validate[required] form-control login-field" runat="server">
                                        <asp:ListItem Text="Select Gender" Value="0"></asp:ListItem>
                                        <asp:ListItem Text="Female" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Male" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="Transgender" Value="3"></asp:ListItem>
                                    </asp:DropDownList>

                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Blood Group*</div>
                                <div class="col-xs-12 col-md-3" style="text-align: left">
                                    <asp:DropDownList ID="ddlUBloodGroup" Width="255px" runat="server" CssClass="validate[required]  form-control login-field">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Country*</div>
                                <div class="col-xs-12 col-md-3" style="text-align: left">
                                    <asp:DropDownList ID="ddlUCountry" runat="server" Width="255px" CssClass="validate[required]  form-control login-field"></asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">State*</div>
                                <div class="col-xs-12 col-md-3" style="text-align: left">
                                    <asp:TextBox ID="txtUState" placeholder="Reside In Which State" CssClass="validate[required] form-control login-field" runat="server"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">City*</div>
                                <div class="col-xs-12 col-md-3" style="text-align: left">
                                    <asp:TextBox ID="txtUCity" runat="server" placeholder="Reside In Which City" CssClass="validate[required] form-control login-field"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">T-Shirt Size*</div>
                                <div class="col-xs-12 col-md-3" style="text-align: left">
                                    <asp:DropDownList ID="ddlUTshirt" Width="255px" runat="server" CssClass="validate[required] form-control login-field">
                                        <asp:ListItem Text="S" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="M" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="L" Value="3"></asp:ListItem>
                                        <asp:ListItem Text="XL" Value="4"></asp:ListItem>
                                        <asp:ListItem Text="XXL" Value="5"></asp:ListItem>
                                        <asp:ListItem Text="XXXL" Value="6"></asp:ListItem>
                                    </asp:DropDownList>
                                    <asp:Label ID="lnkbtnInfoSize" runat="server">Size measurements : </asp:Label>
                                    <a href="javascript:void(0)" onclick="document.getElementById('light').style.display='block';document.getElementById('fade').style.display='block'">Click Here</a>
                                    <div id="light" class="white_content" style="width: 450px; height: 320px">
                                        *)Size S corresponds to a 38" shirt size.
                                        <br />
                                        *)Size M corresponds to a 40" shirt size.
                                        <br />
                                        *)Size L corresponds to a 42" shirt size.
                                        <br />
                                        *)Size XL corresponds to a 44" shirt size. 
                                        <br />
                                        *)Size XXL corresponds to a 46" shirt size.
                                        <br />
                                        *)Size XXXL corresponds to a 48 " shirt size.
                                        <hr />
                                        <a href="javascript:void(0)"
                                            onclick="document.getElementById('light').style.display='none';document.getElementById('fade').style.display='none'">Close</a>
                                    </div>
                                </div>
                            </div>
                        </div>

                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Emergency Contact Person*</div>
                                <div class="col-xs-12 col-md-3" style="text-align: left">
                                    <asp:TextBox ID="txtUEmergencyContactPerson" placeholder="Contact Person" runat="server" CssClass="validate[required] form-control login-field"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Emergency Contact Number*</div>
                                <div class="col-xs-12 col-md-3" style="text-align: left">
                                    <asp:TextBox ID="txtUEmergencyContactNumber" placeholder="99XXXXXXXX" runat="server" CssClass="validate[required,custom[phoneNumberNew] form-control login-field"></asp:TextBox>
                                </div>
                            </div>
                        </div>

                        <div class="row">

                            <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Type of ID*</div>
                                <div class="col-xs-12 col-md-3" style="text-align: left">
                                    <asp:DropDownList ID="ddlUTypeOdId" Width="255px" runat="server" CssClass="validate[required] form-control login-field">
                                        <asp:ListItem Text="Select You ID" Value="0"></asp:ListItem>
                                        <asp:ListItem Text="PAN Card" Value="1"></asp:ListItem>
                                        <asp:ListItem Text="Voter ID" Value="2"></asp:ListItem>
                                        <asp:ListItem Text="Passport" Value="3"></asp:ListItem>
                                        <asp:ListItem Text="Driving License" Value="4"></asp:ListItem>
                                        <asp:ListItem Text="School ID" Value="5"></asp:ListItem>
                                        <asp:ListItem Text="College ID" Value="6"></asp:ListItem>
                                        <asp:ListItem Text="Ration Card" Value="7"></asp:ListItem>
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <div class="row">
                            <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                                <div class="col-xs-12 col-md-6" style="text-align: right">Type-In Id Number*</div>
                                <div class="col-xs-12 col-md-3" style="text-align: left">
                                    <asp:TextBox ID="txtUTypeInId" runat="server" placeholder="XXXXXXXXX" CssClass="validate[required] form-control login-field"></asp:TextBox>
                                </div>
                            </div>
                        </div>
                        <br>

                        <div id="div2" runat="server">
                            <div class="col-md-12">

                                <div class="row col-md-3 col-md-offset-4">
                                    <asp:Button ID="btnUpdateConfirm" class="btn btn-primary btn-large btn-block col-md-3" runat="server" Text="Confirm Your Entry" OnClick="btnUpdateConfirm_Click" />
                                    <asp:ScriptManager ID="scrManager" runat="server"></asp:ScriptManager>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
