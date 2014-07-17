<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="1ccavRequestHandler.aspx.cs" Inherits="SubmitData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $('iframe#paymentFrame').load(function () {
                window.addEventListener('message', function (e) {
                    $("#paymentFrame").css("height", e.data['newHeight'] + 'px');
                }, false);
            });
        });
    </script>
</head>
<body>
    <form id="customerData" runat="server">
        <div class="well col-md-12" style="height: 100%; background-color: white;">
            <div id="divmain" class="col-md-12 col-xs-11 text-center" runat="server">
                <asp:Label class="btn-sm btn-success" runat="server" ID="Label1">Email Confirmation</asp:Label>
                <asp:Label class="btn-sm btn-success" runat="server" ID="Label2">Select Event</asp:Label>
                <asp:Label class="btn-sm btn-success" runat="server" ID="lblRegistration">Registration</asp:Label>
                <asp:Label class="btn-sm btn-success" runat="server" ID="lblConfimation">Confirm Before Proceed</asp:Label>
                <asp:Label class="btn-sm label-primary" runat="server" ID="Label3">Payment</asp:Label>
                <asp:Label class="btn-sm btn-danger" runat="server" ID="Label4">Ticket</asp:Label>
                <hr />
            </div>
        </div>
        <center>
                 
         <iframe width="1500" height="900" scrolling="no" frameborder="0"  id="paymentFrame" src="<%=iframeSrc%>">
	        </iframe>
            </center>


    </form>
</body>
</html>
