<%@ Page Title="" Language="C#" MasterPageFile="~/eCommercePart1.Master" AutoEventWireup="true" CodeBehind="ProductMaintenance.aspx.cs" Inherits="eCommercePart1.ProductMaintenance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/ProductMaintenance.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" CssClass="Panels" style="left: 10px; top: 100px; height: 350px; right: 10px; width:350px;" runat="server">
        <asp:Label ID="LabelProdID" runat="server" Text="Product ID"></asp:Label>
        <asp:TextBox ID="TextProdID" runat="server" style="margin-left: 28px; margin-top: 0px"></asp:TextBox>  
        <asp:RequiredFieldValidator ID="rfvProdID" runat="server" ErrorMessage="Product ID is a required field." ControlToValidate="TextProdID"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID="LabelName" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="TextName" runat="server" style="margin-left: 59px; margin-top: 0px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvName" runat="server" ErrorMessage="Name is a required field." ControlToValidate="TextName"></asp:RequiredFieldValidator>
        <br />
        <asp:Label ID ="LabelPrice" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="TextPrice" runat="server" style="margin-left: 64px; margin-top: 0px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPrice" runat="server" ControlToValidate="TextPrice" ErrorMessage="Price is a required field"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revPrice" runat="server" ControlToValidate="TextPrice" ErrorMessage="The price is not valid" 
            ValidationExpression="^([0-9]{3}, ([0-9]{3},)*[0-9]{3}|[0-9]+)(.[0-9][0-9])?$"></asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="LabelPhone" runat="server" Text="Phone"></asp:Label>
        <asp:TextBox ID="TextPhone" runat="server" style="margin-left: 55px; margin-top: 0px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="rfvPhone" runat="server" ErrorMessage="Supplier Phone is a required field." ControlToValidate="TextPhone"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revPhone" runat="server" ErrorMessage="This phone is not in a valid format" ControlToValidate="TextPhone" 
            ValidationExpression="^(\([2-9]\d{2}\)|[2-9]\d{2})[- .]?\d{3}[- .]?\d{4}$">*</asp:RegularExpressionValidator>
        <br />
        <asp:Label ID="LabelImage" runat="server" Text="Image"></asp:Label>
        <asp:FileUpload ID="fulImage" runat="server" style="margin-left: 59px" />
        <br />
        <asp:Button ID="ButtonSave" runat="server" Text="Save" OnClick="ButtonSave_Click" />
        <br />
        <asp:ValidationSummary ID="vsValidationErrors" runat="server" />
        <asp:Label ID="LabelOutput" runat="server" Text=""></asp:Label>
    </asp:Panel> 
</asp:Content>
