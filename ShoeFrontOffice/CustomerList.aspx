<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <asp:ListBox ID="lstCustomerList" runat="server" Height="461px" Width="931px" AutoPostBack="True"></asp:ListBox>
        </div>
         <p>
                <asp:Button ID="btnAdd" runat="server" Text="OK" Width="50px" OnClick="btnAdd_Click" />
               
            </p>
    </form>
</body>
</html>
