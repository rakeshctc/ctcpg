<%@ Page Title="" Language="C#" MasterPageFile="~/CTCMaster.Master" AutoEventWireup="true" CodeBehind="Payment.aspx.cs" Inherits="CTC_Final.Payment" %>

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

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- /main container -->
    <div class="well col-md-12" style="height: 100%; background-color: white;">
        <div id="divmain" class="col-md-12 col-xs-11 text-center" runat="server">
            <%--<asp:Label class="btn-sm btn-success" runat="server" ID="Label1">Email Confirmation</asp:Label>--%>
            <asp:Label class="btn-sm btn-success" runat="server" ID="Label2">Select Event</asp:Label>
            <asp:Label class="btn-sm btn-success" runat="server" ID="lblRegistration">Registration</asp:Label>
            <asp:Label class="btn-sm btn-success" runat="server" ID="lblConfimation">Confirm Before Proceed</asp:Label>
            <asp:Label class="btn-sm label-primary" runat="server" ID="Label3">Payment</asp:Label>
            <asp:Label class="btn-sm btn-danger" runat="server" ID="Label4">Ticket</asp:Label>
            <hr />
        </div>

        <div class="col-md-12 well text-center" style="height: 100%; background-color: white; vertical-align: central">
            <div id="divPayment" class="col-md-12  well text-center" style="border: groove;" visible="true" runat="server">
                <asp:Button class="btn btn-success" runat="server" ID="btnPayment" Text="Payment Successfull" OnClick="btnPayment_Click"></asp:Button>
            </div>
        </div>
    </div>

</asp:Content>
