<%@ Page Title="管理" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage.aspx.cs" Inherits="WebApplication1.Manage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Manage</h2>
    <h3>The Management Of Database（Administrators Only）</h3>
<p></p>
<asp:Panel ID="Panel1" runat="server">
    <div style="margin-top:15px">
    <asp:Label ID="Label2" runat="server" Text="*Name：（nchar(8)）"></asp:Label>
    <asp:TextBox ID="TextBox1" runat="server" MaxLength="8"></asp:TextBox>
        <asp:Label ID="Label3" runat="server" Text="*Id：（nchar(4)）"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" MaxLength="4"></asp:TextBox>
    </div>
    <br />
    <div style="margin-top:15px">
    <asp:Label ID="Label4" runat="server" Text="Gender：（nchar(2)）"></asp:Label>
    <asp:TextBox ID="TextBox3" runat="server" MaxLength="2"></asp:TextBox>
        <asp:Label ID="Label5" runat="server" Text="Address：（nchar(30)）"></asp:Label>
        <asp:TextBox ID="TextBox4" runat="server" MaxLength="30"></asp:TextBox>
    </div>
    <br />
    <div style="margin-top:15px">
    <asp:Label ID="Label6" runat="server" Text="Telephone：（nchar(13)）"></asp:Label>
    <asp:TextBox ID="TextBox5" runat="server" MaxLength="13"></asp:TextBox>
        <asp:Label ID="Label7" runat="server" Text="Length of service：（int）"></asp:Label>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
    </div>
    <br />
    <div style="margin-top:15px">
    <asp:Label ID="Label8" runat="server" Text="Basic Salary：（nchar(20)）"></asp:Label>
    <asp:TextBox ID="TextBox7" runat="server" MaxLength="20"></asp:TextBox>
        <asp:Label ID="Label9" runat="server" Text="Birthday：（datetime）"></asp:Label>
        <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
    </div>
    <br />
    <div style="margin-top:15px">
    <asp:Label ID="Label10" runat="server" Text="Education Background：（nchar(30)）"></asp:Label>
    <asp:TextBox ID="TextBox9" runat="server" MaxLength="30"></asp:TextBox>
        </div>
    <asp:Label ID="Label_at" runat="server"></asp:Label>
    <br />
    <div style="margin-top:15px">
    <asp:Button ID="Button3" runat="server" Text="Insert" OnClick="Button3_Click" />
    <asp:Button ID="Button4" runat="server" Text="Delete" OnClick="Button4_Click" />
    <asp:Button ID="Button5" runat="server" Text="Update" OnClick="Button5_Click" />
        </div>
    <br />
</asp:Panel>
    <p style="margin:15px">All Data：<asp:Label ID="Label_st" runat="server" ForeColor="Red"></asp:Label>
    </p>
    <p>
         <asp:GridView ID="GridView1" runat="server" CellPadding="3" ForeColor="Black" GridLines="Vertical"  Width="90%" OnSelectedIndexChanging="GridView1_SelectedIndexChanging1" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
            <AlternatingRowStyle BackColor="#CCCCCC" />
            <Columns>
                <asp:CommandField ShowSelectButton="True" ButtonType="Button" SelectText="Select" />
            </Columns>
            <FooterStyle BackColor="#CCCCCC" />
            <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" Height="50px" />
            <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
            <RowStyle Height="50px" />
            <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#808080" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#383838" />
        </asp:GridView>
</asp:Content>
