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
        <asp:FileUpload ID="FileUpload1" runat="server" />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Upload" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Delete" />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        Img 1 <br />
        Title =
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label><br />
        Size =
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        <br />
       
       
        <br />
        <br />
        <asp:Image ID="Image1" runat="server" Height="140px" Width="240px" />
        <asp:Image ID="Image2" runat="server" Height="140px" Width="240px" />
        <br />
        <br />
    </form>
</body>
</html>
