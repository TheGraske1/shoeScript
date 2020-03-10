<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnOrder.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>
<script runat="server">




</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Testing inputs</title>
</head>
<body style="height: 532px; margin-bottom: 27px">
    <form id="form1" runat="server">
        <div>
            <p>OrderID 
                <asp:TextBox ID="intOrderID" runat="server" Width="80px"></asp:TextBox>
                <asp:Button ID="Find" runat="server" OnClick="Find_Click" Text="Find" />
            </p>
            <p>StaffID: 
                <asp:TextBox ID="intStaffID" runat="server"></asp:TextBox>
            </p>
            <p>Total Price: 
                <asp:TextBox ID="floatPrice" runat="server" Width="127px"></asp:TextBox>
            </p>
            <p>
                Delivery Address: 
                <asp:TextBox ID="stringAddress" runat="server"></asp:TextBox>
            </p>
            <p>
                Date Ordered: 
                <asp:TextBox ID="dateOrdered" runat="server"></asp:TextBox>
            </p>
            <p>
                OrderLineID: 
                <asp:TextBox ID="intOrderLine" runat="server"></asp:TextBox>
            </p>
            <p>
                ProductID: 
                <asp:TextBox ID="intProduct" runat="server"></asp:TextBox>
            </p>
            <p>
                SelectionDescription: 
                <asp:TextBox ID="stringSelection" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:CheckBox ID="boolPaid" runat="server" />
            </p>
            <p>Quantity:&nbsp;
                <asp:DropDownList ID="DropDownList1" runat="server" >
                    <asp:ListItem Value="1"></asp:ListItem>
                    <asp:ListItem Value="2"></asp:ListItem>
                    <asp:ListItem Value="3"></asp:ListItem>
                </asp:DropDownList>
            
>
                <asp:Button ID="Button1" runat="server" OnClick="btnOK_Click" Text="OK" />
        
         </p>
                </div>
    </form>
</body>
</html>
