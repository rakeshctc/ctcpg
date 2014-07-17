<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CancelledPage.aspx.cs" Inherits="CTC_Final.CancelledPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Transaction Failed</title>

       <link href="css/demo.css" rel="stylesheet" />
        <link href="css/docs.css" rel="stylesheet" />
        <link href="css/flat-ui.css" rel="stylesheet" />
        <link href="css/stylish-portfolio.css" rel="stylesheet" />

        <link href="Layout/bootstrap.min.css" rel="stylesheet" />
    <link href="Layout/custom.css" rel="stylesheet" />
    <script src="Layout/jquery.min.js" type="text/javascript"></script>
    <script src="Layout/bootstrap.min.js" type="text/javascript"></script>


</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <h1>Transaction Cancelled or Transaction failed.<span>:(</span></h1>
        <p>If your amount debited before you registration firm, do not worry contact support now..</p>
        <p>Try Registering again.</p>

        <p style="text-align: center"><a href="Default.aspx" style="font-weight: bold;">Click Here To Continue</a></p>

        <p style="text-align: center">
            <%--<img src="../../Content/images/Audingo_Small.png" />--%>
        </p>
    </div>
    </form>
</body>
</html>
