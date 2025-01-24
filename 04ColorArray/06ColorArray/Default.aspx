<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body id="bd1" runat="server">
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Change bg Color" />
        </div>
        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem Value="blue"></asp:ListItem>
            <asp:ListItem>green</asp:ListItem>
            <asp:ListItem Value="brown"></asp:ListItem>
            <asp:ListItem Value="pink"></asp:ListItem>
            <asp:ListItem Value="red"></asp:ListItem>
        </asp:DropDownList>
    </form>
</body>
</html>
