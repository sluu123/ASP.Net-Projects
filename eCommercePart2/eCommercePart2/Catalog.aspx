<%@ Page Title="" Language="C#" MasterPageFile="~/eCommercePart2.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="eCommercePart2.Catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Catalog.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Table ID="Table1" runat="server" CssClass="CellStyle" Height="123px" Width="567px" BackColor="#669999" BorderStyle="Dotted">
        </asp:Table>
        <asp:Button ID="Button1" runat="server" Text="Button" style="visibility:hidden" OnClick="Button1_Click"/>
        <br />
        <br />
        <asp:Label ID="LabelRowSelected" runat="server" CssClass="Labels" Text="...select a button" ForeColor="#669999"></asp:Label>
</asp:Content>
