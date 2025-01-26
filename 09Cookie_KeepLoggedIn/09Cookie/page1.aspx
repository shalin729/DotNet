<%@ Page Language="C#" AutoEventWireup="true" CodeFile="page1.aspx.cs" Inherits="page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Email&nbsp;:-&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Width="238px" TextMode="Email"></asp:TextBox>
            <br />
            Password&nbsp; :-&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="241px"></asp:TextBox>
            <br />
            <asp:CheckBox ID="CheckBox1" runat="server" />
&nbsp;Keep me Loged in</div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LogIn" />
    </form>
</body>
</html>
