<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label2" runat="server" Text="Friends Sesion 8 "></asp:Label>
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="v1.mp4"></asp:ListItem>
                <asp:ListItem Value="v2.mp4"></asp:ListItem>
                <asp:ListItem Value="v3.mp4"></asp:ListItem>
                <asp:ListItem Value="v4.mp4"></asp:ListItem>
            </asp:DropDownList>
            <br />
        </div>
        <br />
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <video controls autoplay> 
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
            
        </video>
    </form>
</body>
</html>
