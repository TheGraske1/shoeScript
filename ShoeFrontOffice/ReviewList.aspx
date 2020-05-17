<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ReviewList.aspx.cs" Inherits="ReviewList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstReviewList" runat="server" OnSelectedIndexChanged="lstReviewList_SelectedIndexChanged" style="z-index: 1; left: 12px; top: 11px; position: absolute; height: 299px; width: 234px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" style="z-index: 1; left: 16px; top: 323px; position: absolute" Text="Add" />
        <p>
            <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" style="z-index: 1; left: 122px; top: 323px; position: absolute" Text="Delete" />
            <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" style="z-index: 1; left: 71px; top: 324px; position: absolute" Text="Edit" />
        </p>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 20px; top: 373px; position: absolute" Text="lblError"></asp:Label>
    </form>
</body>
</html>
