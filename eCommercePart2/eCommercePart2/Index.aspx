<%@ Page Title="" Language="C#" MasterPageFile="~/eCommercePart2.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="eCommercePart2.Index" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/Index.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Button ID="BtnCatCart" CssClass="Buttons" style="width:80px; top:170px;" runat="server" Text="Cart" OnClick="BtnCatCart_Click"/>
        <asp:Button ID="BtnCatalog" CssClass="Buttons" style="width:80px; top:170px;" runat="server" Text="Catalog" OnClick="BtnCatalog_Click"/>
        <iframe id="CatCartFrame" class="MainFrame" name="CatCart" src="" runat="server" style="left:10px; top:120px;"></iframe>
    </div>
</asp:Content>
