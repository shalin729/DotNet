<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Like.aspx.cs" Inherits="Like" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Like" />
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Dislike" />
            
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
&nbsp; Likes</form>
</body>
</html>
