<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
  
    <form id="form1" runat="server">
  
 
        
        
        
          
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="Dont_Let_Me_Down.mp3"></asp:ListItem>
            <asp:ListItem Value="Lean on.mp3"></asp:ListItem>
            <asp:ListItem Value="Mi Gente.mp3"></asp:ListItem>
            <asp:ListItem Value="Alone.mp3"></asp:ListItem>
            <asp:ListItem Value="Havana.mp3"></asp:ListItem>
        </asp:DropDownList> 
        

        <br />
        <br />
       

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <audio controls play id="Ad1">
            <asp:Literal ID="Literal1" runat="server"></asp:Literal>
           
        </audio>
    </form>
        
        
        
          
</body>
</html>
