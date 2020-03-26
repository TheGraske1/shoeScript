<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ACustomer.aspx.cs" Inherits="Customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>CustomerID:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCustomerID" runat="server"></asp:TextBox>
                </p>
            <p>Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                </p>
            <p>Address:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>
                </p>
            <p>DateCreated:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtDatecreated" runat="server"></asp:TextBox>
                </p>
            <p>
                <asp:CheckBox ID="chkRegistered" runat="server" Text="Registered" />
                </p>
            <p>Registered:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtRegistered" runat="server"></asp:TextBox>
                </p>
            <p>Balance:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtBalance" runat="server"></asp:TextBox>
                </p>
            <p>
                <asp:Button ID="btnOk" runat="server" Text="OK" Width="50px" />
                <asp:Button ID="btnFind" runat="server" Text="Find" Width="50px" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="50px" />
            </p>
            <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
            </p>





        </div>
    </form>
</body>
</html>
