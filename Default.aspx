<%@ Page Title="" Language="C#" MasterPageFile="~/CTCMaster.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CTC_Final.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <%--<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.7.2/jquery.min.js">
    </script>--%>

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
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- /main container -->
   <%-- <div class="container well col-xs-12" style="height: 500px; background-color: white;">
        <br />
        <h2>Chennai Trail Marathon October 19, 2014</h2>
        <br />
        <!-- /tiles -->
        <div class="row">
            <div class="col-xs-12">
                <h3 style="text-align: center">Registration Form</h3>
                <br />
                <div class="col-xs-12">
                    <div class="col-xs-4">
                        <p class="pull-right">Name</p>
                    </div>
                    <div class="col-xs-8 col-md-5">
                        <div class="form-group">
                            <asp:TextBox ID="txtName" runat="server" placeholder="Name" CssClass="validate[required] form-control login-field"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="col-xs-12">
                    <div class="col-xs-4">
                        <p class="pull-right">Email ID</p>
                    </div>
                    <div class="col-xs-8 col-md-5">
                        <div class="form-group">
                            <asp:TextBox ID="txtGetEmail" runat="server" placeholder="Email" CssClass="validate[required,custom[email] form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
                <div class="row row col-xs-5 col-md-3 col-xs-offset-4 col-md-offset-5">
                    <div class="form-group">
                        <asp:Button ID="btnRegister" runat="server" class="btn btn-primary btn-large btn-block" Text="Register" OnClick="btnRegister_Click" />
                    </div>
                </div>
            </div>
        </div>
    </div>--%>
</asp:Content>
