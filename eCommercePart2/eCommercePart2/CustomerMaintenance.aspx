<%@ Page Title="" Language="C#" MasterPageFile="~/eCommercePart2.Master" AutoEventWireup="true" CodeBehind="CustomerMaintenance.aspx.cs" Inherits="eCommercePart2.CustomerMaintenance" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Styles/CustomerMaintenance.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" CssClass="Panels" style="left: 10px; top: 100px; height: 350px; right: 10px; width:500px;" runat="server">
            <asp:Label ID="LabelCustomerNumber" CssClass="Labels" style="top: 20px; left: 10px;" runat="server" Text="Customer #"/>
            <asp:TextBox ID="TextCustomerNumber" runat="server" CssClass="TextBoxes" style="top: 20px; left:110px; width: 111px;"/>
            <asp:Label ID="LabelFirstName" CssClass="Labels" style="top: 50px; left: 10px;" runat="server" Text="First Name" />
            <asp:TextBox ID="TextFirstName" runat="server" CssClass="TextBoxes" style="top: 50px; left:110px; width: 200px;" />
            <asp:Label ID="LabelLastName" CssClass="Labels" style="top: 80px; left: 10px;" runat="server" Text="Last Name" />
            <asp:TextBox ID="TextLastName" runat="server" CssClass="TextBoxes" style="top: 80px; left:110px; width: 200px;" />
            <asp:Label ID="LabelAddress" CssClass="Labels" style="top: 110px; left: 10px;" runat="server" Text="Address" />
            <asp:TextBox ID="TextAddress" runat="server" CssClass="TextBoxes" style="top: 110px; left:110px; width: 200px;" />
            <asp:Label ID="LabelCity" CssClass="Labels" style="top: 140px; left: 10px;" runat="server" Text="City" />
            <asp:TextBox ID="TextCity" runat="server" CssClass="TextBoxes" style="top: 140px; left:110px; width: 120px;" />
            <asp:Label ID="LabelProvince" CssClass="Labels" style="top: 170px; left: 10px;" runat="server" Text="Province" />
            <asp:TextBox ID="TextProvince" runat="server" CssClass="TextBoxes" style="top: 170px; left:110px; width: 80px;" />
            <asp:Label ID="LabelPostalCode" CssClass="Labels" style="top: 200px; left: 10px;" runat="server" Text="Postal Code" />
            <asp:TextBox ID="TextPostalCode" runat="server" CssClass="TextBoxes" style="top: 200px; left:110px; width: 200px;" />       
            <asp:Label ID="LabelTelephone" CssClass="Labels" style="top: 230px; left: 10px;" runat="server" Text="Telephone" />
            <asp:TextBox ID="TextTelephone" runat="server" CssClass="TextBoxes" style="top: 230px; left:110px; width: 200px;" />     
            <asp:Label ID="LabelEmail" CssClass="Labels" style="top: 260px; left: 10px;" runat="server" Text="E-Mail" />
            <asp:TextBox ID="TextEmail" runat="server" CssClass="TextBoxes" style="top: 260px; left:110px; width: 200px;" />
            <asp:Button ID="ButtonNewCustomer" CssClass="Buttons" style="left: 10px; top: 290px;" ToolTip="Create A New Customer." runat="server" Text="New" OnClick="ButtonNewCustomer_Click"/>
            <asp:Button ID="ButtonUpdateCustomer" CssClass="Buttons" style="left: 70px; top: 290px;" ToolTip="Update Current Customer." runat="server" Text="Update" OnClick="ButtonUpdateCustomer_Click"/>
            <asp:Button ID="ButtonDeleteCustomer" CssClass="Buttons" style="left: 150px; top: 290px;" ToolTip="Delete Current Customer." runat="server" Text="Delete" OnClick="ButtonDeleteCustomer_Click"/>
            <asp:Button ID="ButtonFindCustomer" CssClass="Buttons" style="left: 270px; top: 290px;" ToolTip="Find Current Customer." runat="server" Text="Find" OnClick="ButtonFindCustomer_Click"/>
        </asp:Panel> 
</asp:Content>
