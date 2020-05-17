<%@ Page Language="C#" AutoEventWireup="true" CodeFile="DeleteReview.aspx.cs" Inherits="DeleteReview" %>

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
            <br />
        </div>
        <asp:Button ID="btnYes" runat="server" OnClick="btnyes_Click" style="z-index: 1; left: 14px; top: 47px; position: absolute" Text="Yes" />
        <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" style="z-index: 1; left: 80px; top: 48px; position: absolute" Text="No" />
    </form>
</body>
</html>
