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
        <asp:MultiView ID="MultiView1" runat="server">
            <asp:View ID="View1" runat="server">
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <br />
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </asp:View>
            <asp:View ID="View2" runat="server">
                <asp:Button ID="Button1" runat="server" Text="Button" />
                <br />
                <asp:Button ID="Button2" runat="server" Text="Button" />
                <br />
                <asp:Button ID="Button3" runat="server" Text="Button" />
            </asp:View>
            <asp:View ID="View3" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                <br />
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
            </asp:View>
        </asp:MultiView>

        <br />
        <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" style="width: 21px" Text="1" />
        <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="2" />
        <asp:Button ID="Button6" runat="server" OnClick="Button6_Click" Text="3" />
        <br />
    </form>
</body>
</html>
