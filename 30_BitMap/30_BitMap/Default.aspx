<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:TextBox ID="TextBox1" runat="server" Height="148px" Width="487px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="gif" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="png" />
        <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="jpg" />
    </form>
</body>
</html>
