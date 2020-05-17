<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ProductList.aspx.cs" Inherits="ProductList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 705px">
            <asp:Label ID="Label1" runat="server" style="z-index: 1; left: 31px; top: 522px; position: absolute" Text="Enter Style Name"></asp:Label>
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 93px; top: 452px; position: absolute;" Text="Edit" />
            <asp:ListBox ID="lstProductList" runat="server" style="z-index: 1; left: 33px; top: 36px; position: absolute; height: 388px; width: 476px"></asp:ListBox>
            <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 34px; top: 647px; position: absolute" Text="[Error]"></asp:Label>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 157px; top: 452px; position: absolute" Text="Delete" />
            <asp:TextBox ID="txtFilter" runat="server" style="z-index: 1; left: 195px; top: 523px; position: absolute; width: 192px;"></asp:TextBox>
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="z-index: 1; left: 41px; top: 572px; position: absolute" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="z-index: 1; left: 123px; top: 571px; position: absolute" Text="Clear" />
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 31px; top: 452px; position: absolute" Text="Add" />
    </form>
</body>
</html>
