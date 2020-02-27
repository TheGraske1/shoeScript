<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnStaff.aspx.cs" Inherits="AnStaff" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 327px">
    <form id="form1" runat="server">
        <div id="lblSalary">
            <p id="lblStaffId">Staff Id:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtStaffId" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            </p>
            <p id="lblStaffName">Staff Name:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtStaffName" runat="server"></asp:TextBox>
            </p>
            <p id="lblPhoneNum">Phone Number:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtPhoneNum" runat="server"></asp:TextBox>
            </p>
            <p>Salary:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtSalary" runat="server"></asp:TextBox>
            </p>
            <p id="lblJoinedDate">Joined Date:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="txtJoinedDate" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:CheckBox ID="chckAdmin" runat="server" Text="Admin Privilages" />
            </p>
            <p>
                <asp:Button ID="btnOk" runat="server" Text="OK" Width="50px" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="50px" />
            </p>
        </div>
    </form>
</body>
</html>
