<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="bg" runat="server">
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="img1.png"></asp:ListItem>
            <asp:ListItem Value="img2.png"></asp:ListItem>
            <asp:ListItem Value="img3.png"></asp:ListItem>
            <asp:ListItem Value="img4.png"></asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
