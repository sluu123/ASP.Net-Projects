<%@ Page Title="" Language="C#" MasterPageFile="~/eCommercePart2.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="eCommercePart2.Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Styles/Home.css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="text-center" style="top:10px; position:relative;">
        <img src="Images/new pds pro car kit-01.jpg" />
        <br />
        <br />
        <asp:Panel ID="Panel1" CssClass="Panels" style="left: 10px; top: 100px; height:325px; right: 500px; width:550px;" runat="server">
        <h5> - How long does Plasti Dip® last?  If properly applied, Plasti Dip® will last as long as 3 years without having to be retouched.  
            It is very durable and will not lose it's bond.  
            The spray distance when applying as well as the amount of coats applied will heavily determine the longevity of the product.  
            After 3 years, or during the three years if desired, a new refresher coat can be easily applied.</h5>
        <br />
        <h5> - Will it hold up to the elements (sun, winter)?  
            Plasti Dip® is extremely resistant to the elements, including sun exposure, winter ice, cold, salt etc.  
            A lot of customers actually dip their wheels and cars specifically to protect the original surfaces from the winter season.  
            Please keep in mind however that Fluorescent and Blaze products are subject to fading after prolonged UV exposure.  
            This only happens with these two items due to the fluorescent pigments utilized.</h5>
        <br />
        <h5> - Does it really peel off?  Yes, Plasti Dip® really does peel off.  
            We always suggest a minimum of 4-5 coats, not only for durability, but to make sure it peels off in large pieces when you are ready.</h5>
        </asp:Panel> 
    </div>
</asp:Content>
