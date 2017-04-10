<%@ Page Title="" Language="C#" MasterPageFile="~/eCommercePart1.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="eCommercePart1.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/Index.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="btnCatalogue" runat="server" Text="Catalogue" OnClick="btnCatalogue_Click"/>
        <asp:Button ID="btnCart" runat="server" Text="Cart" OnClick="btnCart_Click"/>
        <iframe id="CustomerFrame" name="Customers" src="Catalogue.aspx" runat="server">
        </iframe>
</asp:Content>
