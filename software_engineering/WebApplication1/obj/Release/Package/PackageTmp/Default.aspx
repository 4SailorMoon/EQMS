<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Engineer Query Management System&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </h1>
        <p class="lead"> 
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>&nbsp;<asp:Button ID="Button1" runat="server" class="btn btn-primary btn-lg" OnClick="Button1_Click" Text="Click Me->Login" CssClass="col-sm-9" ForeColor="#663300" Font-Size="X-Large" />
           
        </p> <asp:Button ID="Button2" runat="server"  class="btn btn-primary btn-lg" Text="Click Me->LogOut"  CssClass="col-sm-9" ForeColor="#663300" Font-Size="X-Large" OnClick="Button2_Click" />
        
    </div>

    <div class="row">
     
            <h2>More Imformation</h2>
            <p>
                Base On ASP.NET Web Forms
                </p>
        <p>
                Producer List：Secret  </p>
            <p>
                &nbsp;</p>
        </div>
       
    </div>

</asp:Content>
