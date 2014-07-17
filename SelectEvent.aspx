<%@ Page Title="" Language="C#" MasterPageFile="~/CTCMaster.Master" AutoEventWireup="true" CodeBehind="SelectEvent.aspx.cs" Inherits="CTC_Final.SelectEvent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">


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
        jquery16min(document).ready(function () {
            
            jquery16min("#<%= rbtn10KM.ClientID %>").click(function () {
                
                jquery16min("#<%= rbtn21kms.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbn42kms.ClientID %>").prop('checked', false);

                jquery16min("#<%= rbtnStudents21.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbtnStudents42.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbtnStudents50.ClientID %>").prop('checked', false);

            });
            
            jquery16min("#<%= rbtn21kms.ClientID %>").click(function () {
                
                jquery16min("#<%= rbtn10KM.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbn42kms.ClientID %>").prop('checked', false);

                jquery16min("#<%= rbtnStudents21.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbtnStudents42.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbtnStudents50.ClientID %>").prop('checked', false);

            });
            jquery16min("#<%= rbn42kms.ClientID %>").click(function () {

                jquery16min("#<%= rbtn21kms.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbtn10KM.ClientID %>").prop('checked', false);

                jquery16min("#<%= rbtnStudents21.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbtnStudents42.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbtnStudents50.ClientID %>").prop('checked', false);

            });

            jquery16min("#<%= rbtnStudents21.ClientID %>").click(function () {

                jquery16min("#<%= rbtn21kms.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbtn10KM.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbn42kms.ClientID %>").prop('checked', false);

                jquery16min("#<%= rbtnStudents42.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbtnStudents50.ClientID %>").prop('checked', false);

            });
            jquery16min("#<%= rbtnStudents42.ClientID %>").click(function () {

                jquery16min("#<%= rbtn21kms.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbtn10KM.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbn42kms.ClientID %>").prop('checked', false);

                jquery16min("#<%= rbtnStudents21.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbtnStudents50.ClientID %>").prop('checked', false);

            });
            jquery16min("#<%= rbtnStudents50.ClientID %>").click(function () {

                jquery16min("#<%= rbtn21kms.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbtn10KM.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbn42kms.ClientID %>").prop('checked', false);

                jquery16min("#<%= rbtnStudents21.ClientID %>").prop('checked', false);
                jquery16min("#<%= rbtnStudents42.ClientID %>").prop('checked', false);

            });



        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- /main container -->
    <div class="well col-md-12" style="height: 500px; background-color: white;">
        <div id="divmain" class="col-md-12 col-xs-11 text-center" runat="server">
            <%--<asp:Label class="btn-sm btn-success" runat="server" ID="Label1">Email Confirmation</asp:Label>--%>
            <asp:Label class="btn-sm label-primary" runat="server" ID="Label2">Select Event</asp:Label>
            <asp:Label class="btn-sm btn-danger" runat="server" ID="lblRegistration">Registration</asp:Label>
            <asp:Label class="btn-sm btn-danger" runat="server" ID="lblConfimation">Confirm Before Proceed</asp:Label>
            <asp:Label class="btn-sm btn-danger" runat="server" ID="Label3">Payment</asp:Label>
            <asp:Label class="btn-sm btn-danger" runat="server" ID="Label4">Ticket</asp:Label>
            <hr />
        </div>
        <div class="col-md-12 text-center" style="height: 350px; background-color: white; vertical-align: central">
            <div class="col-md-10 text-center" style="vertical-align: central">
                <div class="row text-center col-md-offset-2" style="height: 70px;">
                    <h4>Select the Category You Wish to Participate.</h4>
                </div>

                <div class="row col-md-offset-4">
                     <div class="col-md-6 text-center" style="vertical-align: central">
                        <div class="pull-right">Half Marathon(21.1km) (₹500.00)</div>
                    </div>
                    <div class="col-md-5 text-center" style="vertical-align: central">
                        <asp:RadioButton ID="rbtn21kms" CssClass="pull-left" runat="server" />
                    </div>
                </div>
                <div class="row col-md-offset-4">
                    <div class="col-md-6 text-center" style="vertical-align: central">
                        <div class="pull-right">Full Marathon(42.2km) (₹500.00)</div>
                    </div>
                    <div class="col-md-5 text-center" style="vertical-align: central">
                        <asp:RadioButton ID="rbn42kms" CssClass="pull-left" runat="server" />
                    </div>
                </div>
                <div class="row col-md-offset-4" style="height: 40px;">
                   <div class="col-md-6 text-center" style="vertical-align: central">
                        <div class="pull-right">Ultra Marathon(50.0km) (₹500.00)</div>
                    </div>
                    <div class="col-md-5 text-center" style="vertical-align: central">
                        <asp:RadioButton ID="rbtn10KM" CssClass="pull-left" runat="server" />
                    </div>
                </div>


                <div class="row col-md-offset-0">
                     <div class="col-md-8 text-center" style="vertical-align: central">
                        <div class="pull-right">Student - Half Marathon (21.1km)(₹350.00)</div>
                    </div>
                    <div class="col-md-4 text-center" style="vertical-align: central">
                        <asp:RadioButton ID="rbtnStudents21" CssClass="pull-left" runat="server" />
                    </div>
                </div>
                <div class="row col-md-offset-0">
                    <div class="col-md-8 text-center" style="vertical-align: central">
                        <div class="pull-right">Student - Full Marathon(42.2km) (₹350.00)</div>
                    </div>
                    <div class="col-md-4 text-center" style="vertical-align: central">
                        <asp:RadioButton ID="rbtnStudents42" CssClass="pull-left" runat="server" />
                    </div>
                </div>
                <div class="row col-md-offset-0" style="height: 70px;">
                   <div class="col-md-8 text-center" style="vertical-align: central">
                        <div class="pull-right">Student - Ultra Marathon(50.0km) (₹350.00)</div>
                    </div>
                    <div class="col-md-4 text-center" style="vertical-align: central">
                        <asp:RadioButton ID="rbtnStudents50" CssClass="pull-left" runat="server" />
                    </div>
                </div>

                <div id="Div1" class="row col-md-offset-1" runat="server" style="height: 40px;">
                    <div class="col-md-5 text-center" style="vertical-align: central">
                        <div class="pull-right">
                            <asp:CheckBox ID="chkbxTermsnConditions" runat="server" />

                        </div>
                    </div>
                    <div class="col-md-6 text-left" style="vertical-align: central">
                        <%--<asp:LinkButton ID="lnkbtnTermsnCondition" CssClass="pull-left" Text="Terms and Conditions" runat="server" />--%>
                        I Have Read And Accept The <asp:LinkButton ID="lnkbtnTermsnCondition" runat="server" OnClientClick="window.open('TermsandConditions.aspx'); " ForeColor="Red" Target="_blank">Terms and Conditions</asp:LinkButton>
                    </div>
                </div>

                <div id="divProceedRegistration" class="row col-md-offset-6" runat="server">
                    <div class="col-md-5 text-center" style="vertical-align: central">
                        <asp:Button ID="btnProceed" CssClass="pull-left btn btn-primary" Text="Continue Registration" runat="server" OnClick="btnProceed_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
