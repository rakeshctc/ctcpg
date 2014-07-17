<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="errorPage.aspx.cs" Inherits="CTC_Final.errorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error!</title>

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
        <h1>Dang It <span>:(</span></h1>
        <p>Sorry, but the page you were trying to view has crashed.</p>
        <p>It looks like this was the result of either:</p>
        <ul>
            <li>the systems behaving erractically (happens more often than one thinks)</li>
            <li>a developer wrote some crazy code</li>
            <li>honey badgers being curious</li>
        </ul>

        <p style="text-align: center"><a href="Default.aspx" style="font-weight: bold;">Click Here To Continue</a></p>

        <p style="text-align: center">
            <%--<img src="../../Content/images/Audingo_Small.png" />--%>
        </p>
    </div>
    </form>
</body>
</html>
