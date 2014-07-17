<%@ Page Title="" Language="C#" MasterPageFile="~/CTCMaster.Master" AutoEventWireup="true" CodeBehind="Ticket.aspx.cs" Inherits="CTC_Final.Ticket" %>

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
                <p>Dear
                    <asp:Label ID="lblDisPlayName1" runat="server"></asp:Label>,</p>

                <p>This is to confirm your participation for Chennai Trail Marathon.</p>

                <p>Details for your participation for the Event.</p>

                <p>
                    Name :<asp:Label ID="lblDisPlayName" runat="server"></asp:Label>
                </p>

                <p>Age :<asp:Label ID="lblDisPlayAge" runat="server"></asp:Label>
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

</asp:Content>
