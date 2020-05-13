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
                <asp:Button ID="btnAdd" runat="server" Text="Add" Width="50px" OnClick="btnAdd_Click" />
             <asp:Button ID="btnEdit" runat="server" Text="Edit" Width="50px" OnClick="btnEdit_Click" />
             <asp:Button ID="btnDelete" runat="server" Text="Delete" Width="50px" OnClick="btnDelete_Click" />  
         </p>
        <p>
            Enter a Name
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </p>
        <p>
              <asp:Button ID="btnApply" runat="server" Text="Apply" Width="50px" OnClick="btnApply_Click"/>
             <asp:Button ID="btnClear" runat="server" Text="Clear" Width="50px" OnClick="btnClear_Click"/>
              
         </p>
         <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
            </p>
    </form>
</body>
</html>
