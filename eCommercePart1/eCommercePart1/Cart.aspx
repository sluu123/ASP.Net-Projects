<%@ Page Title="" Language="C#" MasterPageFile="~/eCommercePart1.Master" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="eCommercePart1.Cart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/Cart.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Table ID="tblCart" runat="server" CellPadding="10"
            CellSpacing="0" BorderColor="Black" BorderWidth="1px"
            BorderStyle="Solid">            
        </asp:Table>
        <asp:Button ID="btnHiddenRemove" runat="server" style="visibility: hidden;" OnClick="btnHiddenRemove_Click"/>
        Your total bill will be: <asp:Label ID="lblGrandTotal" 
             runat="server" Text="0.00"></asp:Label>
        <br />
        <asp:Button ID="btnRecalculate" runat="server" Text="Recalculate Total" OnClick="btnRecalculate_Click"/>
</asp:Content>
