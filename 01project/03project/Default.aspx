<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:ListBox ID="ListBox1" runat="server" Height="107px">
                <asp:ListItem>JavaScript</asp:ListItem>
                <asp:ListItem>java</asp:ListItem>
                <asp:ListItem>C++</asp:ListItem>
                <asp:ListItem>Python</asp:ListItem>
                <asp:ListItem>TypeScript</asp:ListItem>

            </asp:ListBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button3" runat="server" Text="&gt;" OnClick="Button3_Click" />
            &nbsp;
            <asp:Button ID="Button2" runat="server" Text="&lt;" OnClick="Button2_Click" />
&nbsp;
            &nbsp;&nbsp;
            <asp:Button ID="Button4" runat="server" Text="&lt;&lt;" OnClick="Button4_Click" />
&nbsp;&nbsp;
            <asp:Button ID="Button5" runat="server" Text="&gt;&gt;" OnClick="Button5_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:ListBox ID="ListBox2" runat="server" Height="102px"></asp:ListBox>

        </div>
    </form>
</body>
</html>
            