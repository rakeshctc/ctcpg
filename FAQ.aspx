<%@ Page Title="" Language="C#" MasterPageFile="~/CTCMaster.Master" AutoEventWireup="true" CodeBehind="FAQ.aspx.cs" Inherits="CTC_Final.FAQ" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- /main container -->
    <div class="well col-md-12" style="height: 100%; background-color: white;">

        <div class="col-md-12 well text-center" style="background-color: white; text-align: left; vertical-align: central">
            <asp:Label ID="lblDisplayFaq" runat="server"></asp:Label>
        </div>
    </div>
</asp:Content>
