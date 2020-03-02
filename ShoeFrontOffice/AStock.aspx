﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AStock.aspx.cs" Inherits="AStock" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 741px">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="txtProductId" runat="server" style="z-index: 1; left: 205px; top: 90px; position: absolute" TextMode="Number"></asp:TextBox>
        <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 27px; top: 91px; position: absolute" Text="Product ID"></asp:Label>
        <asp:TextBox ID="txtStyleName" runat="server" style="z-index: 1; left: 205px; top: 134px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblStyleName" runat="server" style="z-index: 1; left: 27px; top: 132px; position: absolute" Text="Style Name"></asp:Label>
        <asp:Label ID="lblBackInStockDate" runat="server" style="z-index: 1; left: 29px; position: absolute; top: 224px" Text="Back In Stock Date"></asp:Label>
        <asp:Label ID="lblQuantityAvailable" runat="server" style="z-index: 1; left: 27px; top: 174px; position: absolute" Text="Quantity Available"></asp:Label>
        <asp:Label ID="lblPrice" runat="server" style="z-index: 1; left: 32px; top: 267px; position: absolute" Text="Price"></asp:Label>
        <asp:TextBox ID="txtQuantityAvailable" runat="server" style="z-index: 1; left: 203px; top: 177px; position: absolute" TextMode="Number"></asp:TextBox>
        <asp:TextBox ID="txtBackInStockDate" runat="server" style="z-index: 1; left: 201px; top: 224px; position: absolute" TextMode="Date"></asp:TextBox>
        <asp:TextBox ID="txtPrice" runat="server" style="z-index: 1; left: 201px; top: 270px; position: absolute" TextMode="Number"></asp:TextBox>
        <asp:Label ID="lblLimitedEdition" runat="server" style="z-index: 1; left: 30px; top: 310px; position: absolute" Text="Limited Edition"></asp:Label>
        <asp:RadioButton ID="Yes" runat="server" style="z-index: 1; left: 190px; top: 311px; position: absolute" />
        <asp:RadioButton ID="No" runat="server" style="z-index: 1; left: 269px; top: 311px; position: absolute" />
        <asp:Button ID="Submit" runat="server" OnClick="Submit_Click" style="z-index: 1; left: 27px; top: 364px; position: absolute" Text="Submit" />
        <asp:Button ID="Cancle" runat="server" style="z-index: 1; left: 143px; top: 364px; position: absolute" Text="Cancle" />
    </form>
</body>
</html>
