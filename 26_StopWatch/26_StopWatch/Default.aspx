<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
        </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                Hr
                <asp:Label ID="Label1" runat="server" style="font-weight: 700; font-size: xx-large" Text="00"></asp:Label>
                &nbsp;&nbsp; Min
                <asp:Label ID="Label2" runat="server" style="font-weight: 700; font-size: xx-large" Text="00"></asp:Label>
                &nbsp;&nbsp; Sec
                <asp:Label ID="Label3" runat="server" style="font-weight: 700; font-size: xx-large" Text="00"></asp:Label>
                &nbsp;&nbsp; Ms
                <asp:Label ID="Label4" runat="server" style="font-weight: 700; font-size: xx-large" Text="00"></asp:Label>
                <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="10" OnTick="Timer1_Tick">
                </asp:Timer>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button1" EventName="click" />
                <asp:AsyncPostBackTrigger ControlID="Button2" EventName="Click" />
                <asp:AsyncPostBackTrigger ControlID="Button3" EventName="Click" />
            </Triggers>
        </asp:UpdatePanel>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Start" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Stop" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Reset" />
        </p>
    </form>
</body>
</html>
