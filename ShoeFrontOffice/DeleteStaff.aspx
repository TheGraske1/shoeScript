<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteStaff.aspx.cs" Inherits="DeleteStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblConfirm" runat="server" Text="Are you sure you want to delete this record?"></asp:Label>
        </div>
        <asp:Button ID="btnYes" runat="server" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" Text="No" />
    </form>
</body>
</html>
