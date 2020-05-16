<%@ Page Title="L O G I N" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div _designerregion="0" >
        <asp:Login ID="Login1" runat="server" BackColor="White" style="margin:auto" BorderPadding="0" DisplayRememberMe="False" Height="445px" OnAuthenticate="Login1_Authenticate1" PasswordLabelText="Password:      " TitleText="L O G I N" UserNameLabelText="Account:      " >
            <CheckBoxStyle Font-Bold="False" Font-Names="微软雅黑" />
            <LoginButtonStyle CssClass="btn btn-primary btn-lg" />
            <TextBoxStyle BorderStyle="Double" BorderWidth="1px" CssClass="form-control" />
            <TitleTextStyle Font-Size="30px"  />
        </asp:Login>
    </div>
</asp:Content>
