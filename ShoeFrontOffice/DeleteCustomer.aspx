<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteCustomer.aspx.cs" Inherits="DeleteCustomer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>
                Are you sure you want to delete this record?
            </p>
            <p>
                <asp:Button ID="btnYes" runat="server" Text="Yes" Width="50px" OnClick="btnYes_Click"></asp:Button>
                <asp:Button ID="btnNo" runat="server" Text="No" Width="50px"></asp:Button>
            </p>
        </div>
    </form>
</body>
</html>
