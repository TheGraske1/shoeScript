﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AReview.aspx.cs" Inherits="AReview" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblReviewID" runat="server" style="z-index: 1; left: 10px; top: 34px; position: absolute; height: 22px; width: 67px" Text="ReviewID"></asp:Label>
        <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" style="z-index: 1; left: 328px; top: 29px; position: absolute" Text="Find" />
        <p>
            &nbsp;</p>
        <asp:Label ID="lblProductID" runat="server" style="z-index: 1; left: 9px; top: 109px; position: absolute; bottom: 734px" Text="ProductID"></asp:Label>
        <asp:Label ID="lblCustomerID" runat="server" style="z-index: 1; left: 9px; top: 71px; position: absolute; width: 41px" Text="CustomerID"></asp:Label>
        <asp:Label ID="lblReview" runat="server" style="z-index: 1; left: 10px; top: 148px; position: absolute; margin-top: 0px" Text="Review"></asp:Label>
        <asp:Label ID="lblReviewDate" runat="server" style="z-index: 1; left: 10px; top: 183px; position: absolute" Text="Review Date"></asp:Label>
        <asp:Label ID="lblProductRating" runat="server" style="z-index: 1; left: 10px; top: 219px; position: absolute" Text="Product Rating"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 10px; top: 296px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; left: 67px; top: 297px; position: absolute" Text="Cancel" OnClick="btnCancel_Click" />
        <asp:TextBox ID="txtReviewID" runat="server" style="z-index: 1; left: 148px; top: 33px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtCustomerID" runat="server" style="z-index: 1; left: 148px; top: 71px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtProductID" runat="server" style="z-index: 1; left: 148px; top: 109px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtReview" runat="server" style="z-index: 1; left: 148px; top: 148px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtReviewDate" runat="server" style="z-index: 1; left: 147px; top: 182px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtProductRating" runat="server" style="z-index: 1; left: 147px; top: 219px; position: absolute"></asp:TextBox>
        <asp:Label ID="txtVerifiedCustomer" runat="server" style="z-index: 1; left: 10px; top: 262px; position: absolute; right: 892px;" Text="Verified Customer?"></asp:Label>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 14px; top: 345px; position: absolute" Text="lbl Error"></asp:Label>
        <asp:CheckBox ID="Yes" runat="server" style="z-index: 1; left: 149px; top: 276px; position: absolute; height: 21px" />
    </form>
</body>
</html>
