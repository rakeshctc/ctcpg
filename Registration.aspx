<%@ Page Title="" Language="C#" MasterPageFile="~/CTCMaster.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="CTC_Final.Registration" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

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
            jquery104min("#<%= txtDOB.ClientID %>").datepicker(
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

    <%-- GoogleAnalyticsObject --%>
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

            jquery104min("#<%= txtPhone.ClientID %>").keypress(function (e) {
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

            jquery104min("#<%= txtEmergencyContactPersonNumber.ClientID %>").keypress(function (e) {
                //if the letter is not digit then display error and don't type anything
                if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
                    //display error message
                    jquery104min("#errmsg").html("Digits Only").show().fadeOut("slow");
                    return false;
                }
            });
        });


    </script>

    <script type="text/javascript">
        jQuery(document).ready(function () {
            jQuery("#form1").validationEngine();
        });

        $(document).ready(function () {
            var textbox = '<%=txtDOB.ClientID%>';
            $('#' + textbox).datepicker();

        });


    </script>

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- /main container -->
    <div class="col-md-12" style="background-color: white">

        <div class="col-md-12 text-center" style="background-color: white;">
        </div>

        <div class="well col-md-12" style="background-color: white;">
            <%--<asp:Label class="btn-sm btn-success" runat="server" ID="lblEmailConfirmation">Email Confirmation</asp:Label>--%>
            <asp:Label class="btn-sm btn-success" runat="server" ID="lblSelectEvent">Select Event</asp:Label>
            <asp:Label class="btn-sm label-primary" runat="server" ID="lblRegistration">Registration</asp:Label>
            <asp:Label class="btn-sm btn-danger" runat="server" ID="lblConfimation">Confirm Before Proceed</asp:Label>
            <asp:Label class="btn-sm btn-danger" runat="server" ID="lblPayment">Payment</asp:Label>
            <asp:Label class="btn-sm btn-danger" runat="server" ID="lblTicket">Ticket</asp:Label>
            <hr />
            <%--<h5>Hi!</h5>--%>
            <asp:Label ID="lblDisplayEmail" runat="server" Enabled="false" Font-Bold="true" Font-Italic="true"></asp:Label>
            <asp:Label ID="lblDisplayMessage" runat="server" Enabled="false" Text=" Will be your EmailId for Further Communication."></asp:Label>
            <br />
            <hr />
            <div id="divPersonalInformation" class="col-md-12" style="background-color: white;" visible="true" runat="server">
                <div class="container">
                    <div class="row">
                        <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                            <div class="col-xs-12 col-md-6" style="text-align: right">Name*</div>
                            <div class="col-xs-12 col-md-3" style="text-align: left">
                                <asp:TextBox ID="txtNomineeName" placeholder="Name" runat="server" CssClass="validate[required] form-control login-field"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                            <div class="col-xs-12 col-md-6" style="text-align: right">Phone*</div>
                            <div class="col-xs-12 col-md-3" style="text-align: left">
                                <asp:TextBox ID="txtPhone" runat="server" placeholder="99XXXXXXXX" MinLength="10" CssClass="validate[required,custom[phoneNumberNew]  form-control login-field"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                            <div class="col-xs-12 col-md-6" style="text-align: right">BIB Name*</div>
                            <div class="col-xs-12 col-md-3" style="text-align: left">
                                <asp:TextBox ID="txtBIBName" runat="server" placeholder="Name on the BIB" CssClass="validate[required]  form-control login-field"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                            <div class="col-xs-12 col-md-6" style="text-align: right">Date Of Birth*</div>
                            <div class="col-xs-12 col-md-3" style="text-align: left; background-color: white">
                                <asp:TextBox ID="txtDOB" runat="server" placeholder="dd/mm/yyyy" ReadOnly="true" CssClass="validate[required] form-control login-field"></asp:TextBox>
                                <asp:HiddenField ID="HiddenField1" runat="server" />
                            </div>
                        </div>
                    </div>
                    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>

                    <div class="row">
                        <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                            <div class="col-xs-12 col-md-6" style="text-align: right">Gender*</div>
                            <div class="col-xs-12 col-md-3" style="text-align: left">
                                <asp:DropDownList ID="ddlGender" Width="255px" CssClass="validate[required] form-control login-field" runat="server">
                                    <asp:ListItem Text="Select Gender" Value="0"></asp:ListItem>
                                    <asp:ListItem Text="Female" Value="1"></asp:ListItem>
                                    <asp:ListItem Text="Male" Value="2"></asp:ListItem>
                                    <%--<asp:ListItem Text="Transgender" Value="3"></asp:ListItem>--%>
                                </asp:DropDownList>

                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                            <div class="col-xs-12 col-md-6" style="text-align: right">Blood Group*</div>
                            <div class="col-xs-12 col-md-3" style="text-align: left">
                                <asp:DropDownList ID="ddlBloodGroup" Width="255px" runat="server" CssClass="validate[required]  form-control login-field">
                                </asp:DropDownList>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                            <div class="col-xs-12 col-md-6" style="text-align: right">Country*</div>
                            <div class="col-xs-12 col-md-3" style="text-align: left">
                                <asp:DropDownList ID="ddlCountry" runat="server" Width="255px" CssClass="validate[required] form-control login-field "></asp:DropDownList>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                            <div class="col-xs-12 col-md-6" style="text-align: right">State*</div>
                            <div class="col-xs-12 col-md-3" style="text-align: left">
                                <asp:TextBox ID="txtState" placeholder="Reside In Which State" CssClass="validate[required]  form-control login-field" runat="server"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                            <div class="col-xs-12 col-md-6" style="text-align: right">City*</div>
                            <div class="col-xs-12 col-md-3" style="text-align: left">
                                <asp:TextBox ID="txtCity" runat="server" placeholder="Reside In Which City" CssClass="validate[required] form-control login-field"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                            <div class="col-xs-12 col-md-6" style="text-align: right">T-Shirt Size*</div>
                            <div class="col-xs-12 col-md-3" style="text-align: left">
                                <asp:DropDownList ID="ddlTShirtSize" Width="255px" runat="server" CssClass="validate[required]  form-control login-field"></asp:DropDownList>
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
                                    <br /> 
                                    *)Option "NO" corresponds to T Shirt Not Required.
                                        
                                        <hr />
                                    <a href="javascript:void(0)"
                                        onclick="document.getElementById('light').style.display='none';document.getElementById('fade').style.display='none'">Close</a>
                                </div>
                            </div>
                            <div class="col-xs-12 col-md-3" style="text-align: left">
                                <h5><strong>(T-Shirt is Optional and 220Rs extra per T-Shirt)</strong></h5>
                            </div>
                        </div>
                    </div>

                    <div class="row">
                        <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                            <div class="col-xs-12 col-md-6" style="text-align: right">Emergency Contact Person*</div>
                            <div class="col-xs-12 col-md-3" style="text-align: left">
                                <asp:TextBox ID="txtEmergencyContactPerson" placeholder="Contact Person" runat="server" CssClass="validate[required] form-control login-field"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                            <div class="col-xs-12 col-md-6" style="text-align: right">Emergency Contact Number*</div>
                            <div class="col-xs-12 col-md-3" style="text-align: left">
                                <asp:TextBox ID="txtEmergencyContactPersonNumber" placeholder="99XXXXXXXX" runat="server" CssClass="validate[required,custom[phoneNumberNew] form-control login-field"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="row">

                        <div class="col-xs-12 col-md-12" style="margin-left: -150px; margin-bottom: 10px">
                            <div class="col-xs-12 col-md-6" style="text-align: right">Type of ID*</div>
                            <div class="col-xs-12 col-md-3" style="text-align: left">
                                <asp:DropDownList ID="ddlTypeofID" Width="255px" runat="server" CssClass="validate[required]  form-control login-field">
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
                                <asp:TextBox ID="txtIDNumber" runat="server" placeholder="XXXXXXXXX" CssClass="validate[required] form-control login-field"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                    <br>

                    <div id="divNextPreviousButton" runat="server">
                        <div class="col-md-12">

                            <div class="row col-md-3 col-md-offset-4">
                                <asp:Button ID="btnContinue" class="btn btn-primary btn-large btn-block col-md-3" runat="server" Text="Continue" OnClick="btnContinue_Click" />
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
