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
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                    <asp:Timer ID="Timer1" runat="server" Enabled="False" Interval="500" OnTick="Timer1_Tick">
                    </asp:Timer>
                    <asp:Label ID="Label1" runat="server" style="font-weight: 700; font-size: xx-large" Text="0"></asp:Label>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Button1" EventName="Click" />
                    <asp:AsyncPostBackTrigger ControlID="Button2" EventName="Click" />
                </Triggers>
            </asp:UpdatePanel>
            <br />
&nbsp;<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Start" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Stop" />
            <br />
            <br />         
        </div>
    </form>
</body>
</html>
