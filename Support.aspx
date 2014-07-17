<%@ Page Title="" Language="C#" MasterPageFile="~/CTCMaster.Master" AutoEventWireup="true" CodeBehind="Support.aspx.cs" Inherits="CTC_Final.Support" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script type="text/javascript">
        $(document).ready(function () {
            //called when key is pressed in textbox
            $("#<%=txtEPhone.ClientID%>").keypress(function (e) {
                //if the letter is not digit then display error and don't type anything
                if (e.which != 8 && e.which != 0 && (e.which < 48 || e.which > 57)) {
                    //display error message
                    $("#errmsg").html("Digits Only").show().fadeOut("slow");
                    return false;
                }
            });
        });
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!-- /main container -->
    <div class="well" style="height: 500px; background-color: white;">
        <div class="col-xs-12">
            <div class="row">
                <div id="divEnquiry" runat="server" class="col-xs-12">
                    <h4 style="text-align: center">Enquiry Form</h4>

                    <div class="col-xs-10">
                        <div class="col-xs-4">
                            <p class="pull-right">Name</p>
                        </div>
                        <div class="col-xs-8">
                            <div class="form-group">
                                <asp:TextBox ID="txtEName" runat="server" placeholder="Your Name" CssClass="validate[required] form-control login-field"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-xs-10">
                        <div class="col-xs-4">
                            <p class="pull-right">Email Id</p>
                        </div>
                        <div class="col-xs-8">
                            <div class="form-group">
                                <asp:TextBox ID="txtEEmail" runat="server" placeholder="Email Address for Further Communication" CssClass="validate[required,custom[email] form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-xs-10">
                        <div class="col-xs-4">
                            <p class="pull-right">Phone</p>
                        </div>
                        <div class="col-xs-8">
                            <div class="form-group">
                                <asp:TextBox ID="txtEPhone" runat="server" placeholder="10 Digit Mobile Number" MinLength="10" CssClass="validate[required,custom[phoneNumberNew] form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-xs-10">
                        <div class="col-xs-4">
                            <p class="pull-right">Subject</p>
                        </div>
                        <div class="col-xs-8">
                            <div class="form-group">
                                <asp:TextBox ID="txtESubject" runat="server" placeholder="Just to Know Your Query in Brief" CssClass="validate[required] form-control login-field"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-xs-10">
                        <div class="col-xs-4">
                            <p class="pull-right">Enquiry</p>
                        </div>
                        <div class="col-xs-8">
                            <div class="form-group">
                                <asp:TextBox ID="txtEMain" runat="server" TextMode="MultiLine" Height="100px" placeholder="" CssClass="validate[required] form-control login-field"></asp:TextBox>
                            </div>
                        </div>
                    </div>

                    <div class="col-xs-10">
                        <div class="col-xs-4 col-xs-offset-5">
                            <asp:Button ID="btnSubmitEnquiry" runat="server" Text="Submit Enquiry" CssClass="btn-success btn-sm" OnClick="btnSubmitEnquiry_Click" />
                        </div>

                    </div>

                </div>
                <div id="divMessage" runat="server" visible="false" class="col-xs-12">
                    <div class="col-xs-12">
                        <h4>Thanks For submiting your Query.</h4>
                        <h4>Your Query will be answered  ASAP. Check your emailID for the reply.</h4>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <script type="text/javascript" src="https://mylivechat.com/chatinline.aspx?hccid=83988346"></script>
</asp:Content>
