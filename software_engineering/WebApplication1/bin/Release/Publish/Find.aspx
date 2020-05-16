<%@ Page Title="查询" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Find.aspx.cs" Inherits="WebApplication1.Find" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>&nbsp;Query the data in the database</h2>
    <div>
        
        <div style="margin-top:15px"><asp:Label ID="Label2" runat="server"  Text="Precise query content: "></asp:Label><asp:TextBox ID="TextBox1" runat="server" CssClass="form-control"></asp:TextBox></div>
        <div style="margin-right:15px;margin-top:15px"></div>
        <div style="margin-right:15px;margin-top:15px"><asp:Button ID="Button3" runat="server" Text="Immediately query" OnClick="Button3_Click" />
        <div style="margin-right:15px;margin-top:15px"> <asp:Button ID="Button4" runat="server" Text="Reveal all" OnClick="Button4_Click" />
            <br />
            <br />
            Result（All are displayed by default）：<br />
            <asp:GridView ID="GridView1" runat="server" CellPadding="3" ForeColor="Black" GridLines="Vertical"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="100%" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px">
                <AlternatingRowStyle BackColor="#CCCCCC" />
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" HorizontalAlign="Center" VerticalAlign="Middle" Height="50px" />
                <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle HorizontalAlign="Left" Height="50px" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EngineerConnectionString %>" SelectCommand="SELECT * FROM [Eng_info]"></asp:SqlDataSource>
        </div>
            
    </div>
    
</div>
</asp:Content>
