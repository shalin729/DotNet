<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <br />
        </div>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="500" OnTick="Timer1_Tick">
                </asp:Timer>
                <br />
                <asp:Label ID="Label1" runat="server" style="font-weight: 700; font-size: x-large;" Text="0"></asp:Label>
            </ContentTemplate>
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="Button1" EventName="click" />
                <asp:AsyncPostBackTrigger ControlID="Button2" EventName="click" />
            </Triggers>
        </asp:UpdatePanel>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Start" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Stop" />
        </p>
    </form>
</body>
</html>
