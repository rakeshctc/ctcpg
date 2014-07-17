<%@ Page Title="" Language="C#" MasterPageFile="~/CTCMaster.Master" AutoEventWireup="true" CodeBehind="eCertificate.aspx.cs" Inherits="CTC_Final.eCertificate" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <div class="col-xs-12 well col-md-12">
            <div class="col-xs-12 col-md-12 text-center">
                <div class="col-md-12 text-center">
                    <h3><strong>All Events E-Certificate Page</strong></h3>
                </div>
                <%-- <asp:DataList ID="dlCertificate" runat="server" RepeatColumns="4" RepeatDirection="Horizontal">
                    <FooterStyle BackColor="#0080FF" ForeColor="IndianRed" />
                    <HeaderStyle BackColor="Black" CssClass="Header" Font-Bold="True" Font-Size="12px"
                        ForeColor="Black" />
                    <ItemStyle BorderStyle="None" BorderWidth="10px" Width="33%" />
                    <ItemTemplate>
                        <div class="text-center">
                            <br />
                            <br />
                            <asp:Label ID="lblTitle" runat="server" Font-Bold="true" Text='<%#Eval("EventName") %>'></asp:Label>
                            <br />
                            <asp:Image ID="imgCertificate" runat="server" ImageUrl='<%#Eval("EventPoster") %>' Width="250px" Height="150px" />
                            <br />
                            <asp:Label ID="lblDate" runat="server" Font-Bold="true" Text='<%#Eval("EventDate") %>'></asp:Label>
                            <br />
                            <asp:Button ID="btnGetCertificate" ToolTip='<%#Eval("EventName") %>' runat="server" Text="Get Your eCertificate" CssClass="btn btn-info" OnClick='<%#Eval("EventCertificate") %>' />
                            <br />
                            <br />
                        </div>
                    </ItemTemplate>
                </asp:DataList>--%>

                <div class="col-xs-12 col-md-12 text-center">
                    <%----%>
                    <div class="well col-md-4 text-center">
                        <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/CTJuly13.jpg" Width="250px" Height="150px" />
                        <br />
                        <asp:Label ID="Label2" runat="server" Text="Chennai Triathlon July 13th 2014 "></asp:Label>
                        <br />
                        <asp:Button ID="btnCTJuly13" runat="server" Text="Get Your eCertificate" CssClass="btn btn-info" OnClick="btnCTJuly13_Click" />
                    </div>
                     <div class="well col-md-4 text-center">
                        <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/CTJuly12.jpg" Width="250px" Height="150px" />
                        <br />
                        <asp:Label ID="Label1" runat="server" Text="Chennai Triathlon 12th July 2014 "></asp:Label>
                        <br />
                        <asp:Button ID="btnCTJuly12" runat="server" Text="Get Your eCertificate" CssClass="btn btn-info" OnClick="btnCTJuly12_Click" />
                    </div>
                    <div class="well col-md-4 text-center">
                        <asp:Image ID="imgCer1" runat="server" ImageUrl="~/Images/CTMarch29.jpg" Width="250px" Height="150px" />
                        <br />
                        <asp:Label ID="lblDate1" runat="server" Text="March 29th 2014"></asp:Label>
                        <br />
                        <asp:Button ID="btnGetCertificate1" runat="server" Text="Get Your eCertificate" CssClass="btn btn-info" OnClick="btnGetCertificate1_Click" />
                    </div>
                 
                </div>

                <div class="col-xs-12 col-md-12 text-center">
                       <div class="well col-md-4 text-center">
                        <asp:Image ID="imgCer2" runat="server" ImageUrl="~/Images/CTDec15.jpg" Width="250px" Height="150px" />
                        <br />
                        <asp:Label ID="lblDate2" runat="server" Text="Dec 15th 2013"></asp:Label>
                        <br />
                        <asp:Button ID="btnGetCertificate2" runat="server" Text="Get Your eCertificate" CssClass="btn btn-info" OnClick="btnGetCertificate2_Click" />
                    </div>



                    <div class="well col-md-4 text-center">
                        <asp:Image ID="imgCer3" runat="server" ImageUrl="~/Images/CTM.jpg" Width="250px" Height="150px" />
                        <br />
                        <asp:Label ID="lblDate3" runat="server" Text="October 20th 2013"></asp:Label>
                        <br />
                        <asp:Button ID="btnGetCertificate3" runat="server" Text="Get Your eCertificate" CssClass="btn btn-info" OnClick="btnGetCertificate3_Click" />
                    </div>
                </div>

            </div>



        </div>
    </div>
</asp:Content>
