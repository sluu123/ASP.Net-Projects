<%@ Page Title="" Language="C#" MasterPageFile="~/eCommercePart2.Master" AutoEventWireup="true" CodeBehind="AdminMenu.aspx.cs" Inherits="eCommercePart2.AdminMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/Admin.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <iframe id="CustomerFrame" class="MainFrame" name="CustomerMaintenance" src="CustomerMaintenance.aspx" runat="server" style="left:10px; top:100px;"></iframe>
    <iframe id="ProductFrame" class="MainFrame" name="ProductMaintenance" src="ProductMaintenance.aspx" runat="server" style="left:10px; top:525px;"></iframe>
</asp:Content>
