<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteProduct.aspx.cs" Inherits="DeleteProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 215px; width: 903px">
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 48px; top: 40px; position: absolute" Text="Are you sure you want to delete this record?"></asp:Label>
            <asp:Button ID="btnYes" runat="server" OnClick="Button1_Click" style="z-index: 1; left: 104px; top: 99px; position: absolute" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" style="z-index: 1; left: 186px; top: 98px; position: absolute; width: 47px" Text="No" />
        </div>
    </form>
</body>
</html>
