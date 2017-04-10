<%@ Page Title="" Language="C#" MasterPageFile="~/eCommercePart2.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="eCommercePart2.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Cart.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Table ID="Table1" runat="server" CssClass="CellStyle" Height="123px" Width="567px" BackColor="#CC9999" BorderStyle="Dotted">
        </asp:Table>
        <asp:Button ID="Button1" runat="server" Text="Button" style="visibility:hidden" OnClick="Button1_Click"/>
        <br />
        <br />
        <asp:Label ID="LabelRowSelected" runat="server" CssClass="Labels" Text="...select a button" ForeColor="#CC9999"></asp:Label>
        <br />
        <asp:Label ID="LabelTotal" runat="server" CssClass="LabelTotal" Text="0.00"></asp:Label>
        <asp:Button ID="ButtonRecalculate" runat="server" Text="Total" OnClick="ButtonRecalculate_Click"/>
</asp:Content>
