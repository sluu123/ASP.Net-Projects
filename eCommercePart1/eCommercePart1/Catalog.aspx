<%@ Page Title="" Language="C#" MasterPageFile="~/eCommercePart1.Master" AutoEventWireup="true" CodeBehind="Catalog.aspx.cs" Inherits="eCommercePart1.Catalog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/Catalog.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Table ID="tblProducts" runat="server" BorderColor="Black" BorderWidth="1px" BorderStyle="Solid" CellPadding="5" CellSpacing="0">
            <asp:TableHeaderRow CssClass="TableHeader">
                <asp:TableCell></asp:TableCell>
                <asp:TableCell>Product #</asp:TableCell>
                <asp:TableCell>Name</asp:TableCell>
                <asp:TableCell>Price</asp:TableCell>                
                <asp:TableCell></asp:TableCell>
            </asp:TableHeaderRow>
        </asp:Table>
        <asp:Button ID="btnAddToCart" runat="server" Text="Add To Cart" style="visibility: hidden;"/>
        <asp:Label ID="lblOutput" runat="server"></asp:Label>
</asp:Content>
