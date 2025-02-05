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
        <asp:Panel ID="Panel1" runat="server" Width="341px" DefaultButton="Button1">
            Login<br />
            <br />
            Email -
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            Password -
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LogIn" />
        </asp:Panel>
        <br /><br />
        <asp:Panel ID="Panel2" runat="server" Width="341px" DefaultButton="Button2">
            Registration<br />
            <br />
            Name-
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <br />
            <br />
            Phone no -
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <br />
            <br />
            Email -
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            <br />
            <br />
            Password -
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <br />
            <br />
            Conform Pass -
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Sign in" />
            <br />
        </asp:Panel>
        <br /><br />
        <asp:Panel ID="Panel3" runat="server" Width="341px" DefaultButton="Button3">
            Search<br />
            <br />
            <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Search" />
        </asp:Panel>
    </form>
</body>
</html>
