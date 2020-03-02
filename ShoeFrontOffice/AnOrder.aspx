<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>
<script runat="server">

    protected void OK_Click(object sender, EventArgs e)
    {

    }
</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Testing inputs</title>
</head>
<body style="height: 532px; margin-bottom: 27px">
    <form id="form1" runat="server">
        <div>
            <p>OrderID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <input type="text" size ="20px" id="txtOrderID"  />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; </p>
            <p>CustomerID:&nbsp; <input type="text" size="20px" name ="txtOrderID" id="CustomerID" /></p>
            <p>StaffID: <input type="text" size="20px" id="StaffID" /></p>
            <p>Total Price: <input type="text" size="20px" id="TotalPrice" /></p>
            <p>
                Delivery Address: <input type="text" size="20px" /></p>
            <p>
                Date Ordered: <input type="text" size="20px" /></p>
            <p>
                OrderLineID: <input type="text" size="20px" /></p>
            <p>
                ProductID: <input type="text" size="20px" /></p>
            <p>
                Price per unit: <input type="text" size="20px" /></p>
            <p>
                SelectionDescription: <input type="text" size="20px" /></p>
            <p>
                <asp:CheckBox ID="Paid" runat="server" />
            </p>
            <p>Quantity:&nbsp;
                <select ammount="orders" name="D1">
                    <option value ="1">1</option>
                    <option value ="2">2</option>
                    <option value ="3">3</option>
                </select><p>
>
            <asp:Button ID="OK" runat="server" Text="OK" style="width: 33px" OnClick="OK_Click" />
        
            <p>&nbsp;&nbsp;
                </div>
    </form>
</body>
</html>
