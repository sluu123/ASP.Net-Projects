<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ImageUpload.aspx.cs" Inherits="ImageUploader.ImageUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Maintenance</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>Product Maintenance</h1>
        <h2>Please slect a picture: <br />Then enter pertient information in the boxes below</h2>
        <br />
        <asp:FileUpload ID="fileUpload" runat="server"/>
        <br /><br />
        <asp:Label ID="LabelProdID" runat="server" Text="Product ID"></asp:Label>
        <asp:TextBox ID="TextProdID" runat="server" style="margin-left: 65px; margin-top: 0px"></asp:TextBox> 
        <br /><br />
        <asp:Label ID="LabelPictureName" runat="server" Text="Picture Name"></asp:Label>
        <asp:TextBox ID="TextPictureName" runat="server" style="margin-left: 50px; margin-top: 0px"></asp:TextBox> 
        <br /><br />
        <asp:Label ID="LabelSupplierCode" runat="server" Text="Supplier Code"></asp:Label>
        <asp:TextBox ID="TextSupplierCode" runat="server" style="margin-left: 45px; margin-top: 0px"></asp:TextBox> 
        <br /><br />
        <asp:Label ID="LabelDescription" runat="server" Text="Description"></asp:Label>
        <asp:TextBox ID="TextDescription" runat="server" style="margin-left: 63px; margin-top: 0px"></asp:TextBox> 
        <br /><br />
        <asp:Label ID="LabelQOH" runat="server" Text="Quantity On Hand"></asp:Label>
        <asp:TextBox ID="TextQOH" runat="server" style="margin-left: 21px; margin-top: 0px"></asp:TextBox> 
        <br /><br />
        <asp:Label ID="LabelPrice" runat="server" Text="Price"></asp:Label>
        <asp:TextBox ID="TextPrice" runat="server" style="margin-left: 102px; margin-top: 0px"></asp:TextBox> 
        <br /><br />
        <asp:Button ID="ButtonUploadImage" runat="server" Text="Upload Image" OnClick="ButtonUploadImage_Click"/>
        <br /><br />
        <asp:Image ID="Image1" runat="server"/>
    
    </div>
    </form>
</body>
</html>
