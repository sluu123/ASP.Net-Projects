<%@ Page Title="" Language="C#" MasterPageFile="~/eCommercePart2.Master" AutoEventWireup="true" CodeBehind="ProductMaintenance.aspx.cs" Inherits="eCommercePart2.ProductMaintenance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/ProductMaintenance.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="LabelTitle" runat="server" style="font-size:xx-large; font:bolder;"/>
        <br /><br />
        <asp:Label ID="LabelExplain" runat="server" style="font-size: x-large; font:bolder; color: red" Text="Please select a picture:"/><br />
        <asp:Label ID="LabelExplain2" runat="server" style="font-size: x-large; font:bolder; color: red" Text="Then enter pertinent information in the boxes below" />
        <br /><br />
        <asp:FileUpload ID="FileUpload1" style="font-size: x-large" runat="server" Width="300px" />&nbsp;&nbsp;
        <br /><br />
        <asp:Label ID="LabelProductID" CssClass="Labels" runat="server" Text="Product ID" />
        <asp:TextBox ID="TextProductID" CssClass="TextBoxes" style="left: 100px"  runat="server" Font-Strikeout="False" ReadOnly="True" Enabled="False"></asp:TextBox>
        <br /><br />
        <asp:Label ID="LabelPictureName" CssClass="Labels" runat="server" Text="Picture Name" />
        <asp:TextBox ID="TextPictureName" CssClass="TextBoxes" style="left: 100px" runat="server" Enabled="False" ReadOnly="True"></asp:TextBox>
        <br /><br />
        <asp:Label ID="LabelSupplierCode" CssClass="Labels" runat="server" Text="Supplier Code" />
        <asp:TextBox ID="TextSupplierCode" CssClass="TextBoxes" style="left:100px" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="LabelDescription" CssClass="Labels" runat="server" Text="Description" />
        <asp:TextBox ID="TextDescription" CssClass="TextBoxes" style="left: 100px" runat="server"></asp:TextBox>
        <br /><br />       
        <asp:Label ID="LabelQty" CssClass="Labels" runat="server" Text="Quantity On Hand" />
        <asp:TextBox ID="TextQty" CssClass="TextBoxes" style="left: 100px" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label ID="LabelPrice" CssClass="Labels" runat="server" Text="Price" />
        <asp:TextBox ID="TextPrice" CssClass="TextBoxes" style="left: 100px" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button ID="ButtonUploadImage" CssClass="Buttons" runat="server"
            Text="Upload Image" OnClick="ButtonUploadImage_Click"/>
        <br /><br />
        <asp:Image ID="Image1" runat="server" Visible="False" />
    </div>
</asp:Content>
