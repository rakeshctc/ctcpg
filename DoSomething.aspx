<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DoSomething.aspx.cs" Inherits="CTC_Final.DoSomething" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Chennai Trekking Club</title>
    <link rel="shortcut icon" href="Images/favicon.ico" />
  <%--  <script src="DatePicker/jquery-2.1.1.min.js"></script>
     <script type="text/javascript">
         var jquery16min = $.noConflict(true);
    </script>--%>
 

    <link href="Layout/bootstrap.min.css" rel="stylesheet" />
    <link href="Layout/custom.css" rel="stylesheet" />
    <script src="Layout/jquery.min.js"></script>
    <script src="Layout/bootstrap.min.js"></script>

     <script type="text/javascript">
         $('input:text').blur(function () {
             var textBox = $('input:text').val();
             if (textBox == "") {
                 $("#error").show('slow');
             }
         });
    </script>

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
   
    <script>
        function validateForm() {
            var x = document.forms["customerData"]["billing_name"].value;
            if (x == null || x == "") {
                alert("Billing Name must be filled out");
                return false;
            }

            var x = document.forms["customerData"]["billing_address"].value;
            if (x == null || x == "") {
                alert("Billing Address must be filled out");
                return false;
            }

            var x = document.forms["customerData"]["billing_city"].value;
            if (x == null || x == "") {
                alert("Billing City must be filled out");
                return false;
            }

            var x = document.forms["customerData"]["billing_state"].value;
            if (x == null || x == "") {
                alert("Billing State must be filled out");
                return false;
            }

            var x = document.forms["customerData"]["billing_zip"].value;
            if (x == null || x == "") {
                alert("Billing Zip must be filled out");
                return false;
            }

            var x = document.forms["customerData"]["billing_country"].value;
            if (x == null || x == "") {
                alert("Billing Country must be filled out");
                return false;
            }

            var x = document.forms["customerData"]["billing_tel"].value;
            if (x == null || x == "") {
                alert("Billing Tel must be filled out");
                return false;
            }

            var x = document.forms["customerData"]["billing_email"].value;
            if (x == null || x == "") {
                alert("Billing Email must be filled out");
                return false;
            }
        }
</script>

</head>
<body>
    <form id="form1" method="post" name="customerData" action="ccavRequestHandler.aspx" onsubmit="return validateForm()">
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
                <%--<asp:Label class="btn-sm btn-success" runat="server" ID="Label1">Email Confirmation</asp:Label>--%>
                <asp:Label class="btn-sm btn-success" runat="server" ID="Label2">Select Event</asp:Label>
                <asp:Label class="btn-sm btn-success" runat="server" ID="lblRegistration">Registration</asp:Label>
                <asp:Label class="btn-sm btn-success" runat="server" ID="lblConfimation">Confirm Before Proceed</asp:Label>
                <asp:Label class="btn-sm btn-danger" runat="server" ID="Label3">Payment</asp:Label>
                <asp:Label class="btn-sm btn-danger" runat="server" ID="Label4">Ticket</asp:Label>
                <hr />
            </div>

            <div id="divSendData" class="col-md-12 col-xs-11 text-center" runat="server">
                <input type="hidden" name="merchant_id" id="merchant_id" value="<%=merchant_id%>" />
                <input id="order_id" type="hidden" name="order_id" value="<%=order_id%>" />
                <input id="amount" type="hidden" name="amount" value="<%=amount%>" />
                <input id="currency" type="hidden" name="currency" value="INR" />
                <input id="redirect_url" type="hidden" name="redirect_url" value="<%=redirect_url%>" />
                <input id="cancel_url" type="hidden" name="cancel_url" value="<%=cancel_url%>" />
                <input id="billing_email" type="hidden" name="billing_email" value="<%=billing_email%>" />
                <p>
                    <h4><strong>
                        <ul>Billing Information</ul>
                        <h6>All Fields are Mandatory*</h6>
                        <h6><strong>Empty Box's leads to fail transactions</strong> </h6>
                    </strong></h4>
                </p>
                <div class="text-left">
                    <br />
                    <div class="row">
                        <div class="col-xs-12">
                            <br />
                            <div class="col-xs-12">
                                <div class="col-xs-4">
                                    <p class="pull-right">Billing Name*:</p>
                                </div>
                                <div class="col-xs-8 col-md-5">
                                    <div class="form-group">
                                        <input type="text" name="billing_name" value="" class="validate[required] form-control login-field" placeholder="Billing Name" required/>
                                    </div>
                                </div>
                            </div>
                            <div class="col-xs-12">
                                <div class="col-xs-4">
                                    <p class="pull-right">Billing Address*:</p>
                                </div>
                                <div class="col-xs-8 col-md-5">
                                    <div class="form-group">
                                        <input type="text" name="billing_address" value="" class="validate[required] form-control login-field" placeholder="Billing Address" required />
                                    </div>
                                </div>
                            </div>

                            <div class="col-xs-12">
                                <div class="col-xs-4">
                                    <p class="pull-right">Billing City*:</p>
                                </div>
                                <div class="col-xs-8 col-md-5">
                                    <div class="form-group">
                                        <input type="text" name="billing_city" value="" class="validate[required] form-control login-field" placeholder="Billing City" required />
                                    </div>
                                </div>
                            </div>

                            <div class="col-xs-12">
                                <div class="col-xs-4">
                                    <p class="pull-right">Billing State*:</p>
                                </div>
                                <div class="col-xs-8 col-md-5">
                                    <div class="form-group">
                                        <input type="text" name="billing_state" value="" class="validate[required] form-control login-field" placeholder="Billing State" required />
                                    </div>
                                </div>
                            </div>

                            <div class="col-xs-12">
                                <div class="col-xs-4">
                                    <p class="pull-right">Billing Zip*:</p>
                                </div>
                                <div class="col-xs-8 col-md-5">
                                    <div class="form-group">
                                        <input type="text" name="billing_zip" value="" class="validate[required] form-control login-field" placeholder="Billing Zip" required />
                                    </div>
                                </div>
                            </div>

                            <div class="col-xs-12">
                                <div class="col-xs-4">
                                    <p class="pull-right">Billing Country*:</p>
                                </div>
                                <div class="col-xs-8 col-md-5">
                                    <div class="form-group">
                                        <input type="text" name="billing_country" value="" class="validate[required] form-control login-field" placeholder="Billing Country" required />
                                    </div>
                                </div>
                            </div>

                            <div class="col-xs-12">
                                <div class="col-xs-4">
                                    <p class="pull-right">Billing Tel*:</p>
                                </div>
                                <div class="col-xs-8 col-md-5">
                                    <div class="form-group">
                                        <input type="text" name="billing_tel" value="" class="validate[required] form-control login-field" placeholder="Billing Telephone" required />
                                    </div>
                                </div>
                            </div>

                           <%-- <div class="col-xs-12">
                                <div class="col-xs-4">
                                    <p class="pull-right">Billing Email*:</p>
                                </div>
                                <div class="col-xs-8 col-md-5">
                                    <div class="form-group">
                                        <input type="text" name="billing_email" value="<%=email%>"  class="validate[required,custom[email] form-control login-field" placeholder="Billing Email" required  />
                                    </div>
                                </div>
                            </div>--%>

                        <%--    <div class="col-xs-12">
                                <div class="col-xs-4">
                                    <p class="pull-right">Only For Organizers</p>
                                </div>
                                <div class="col-xs-8 col-md-5">
                                    <select name="integration_type">
                                        <option value="iframe_normal">iframe_normal</option>
                                        For Off
                                    </select>
                                </div>
                            </div>--%>


                            <div id="error"style="display:none">Fill all the textboxes</div>
                        </div>
                    </div>

                </div>
                <input type="submit" id="ProceedToPaymentGateway" class="btn btn-sm btn-success" value="Proceed To Payment Gateway" />
            </div>

            <table id="Table1" width="40%" height="100" runat="server" visible="false" border='1' align="center">
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
                        <input type="text"  name="delivery_address" value="room no.701 near bus stand" /></td>
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
                    <td></td>
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
                <tr>
                    <td></td>
                    <td>
                        <input type="submit" value="Checkout" /></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
