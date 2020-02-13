﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnStaff.aspx.cs" Inherits="AnStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>Staff Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtBoxStaffName" runat="server"></asp:TextBox>
            </p>
            <p>Phone Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtBoxPhoneNum" runat="server"></asp:TextBox>
            </p>
            <p>Salary:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtBoxSalary" runat="server"></asp:TextBox>
            </p>
            <p>Joined Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtBoxJoinedDate" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:CheckBox ID="chckAdmin" runat="server" Text="Admin Privilages" />
            </p>
            <p>
                <asp:Button ID="BtnOk" runat="server" Text="OK" Width="50px" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="50px" />
            </p>
        </div>
    </form>
</body>
</html>
