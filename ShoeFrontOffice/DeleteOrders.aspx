<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteOrders.aspx.cs" Inherits="DeleteOrders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Are you sure you want to delete this record?<br />
            <br />
            <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            <asp:Button ID="btnNo" runat="server" Text="No" />
        </div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </form>
</body>
</html>
