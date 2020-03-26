<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Your basket</title>
</head>
<body style="height: 532px; margin-bottom: 27px">
    <form id="form1" runat="server">
        <div>
            <p>Order number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input type="text" size ="20px"  /></p>
            <p>Product selected:&nbsp; <input type="text" size="20px" /></p>
            <p>Quantity:&nbsp;
                <select ammount="orders" name="D1">
                    <option value ="1">1</option>
                    <option value ="2">2</option>
                    <option value ="3">3</option>
                </select><p>
>
            <asp:Button ID="OK" runat="server" Text="OK" />
        
            <p>&nbsp;&nbsp;
                </div>
    </form>
</body>
</html>
