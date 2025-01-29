<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name -&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:TextBox ID="TextBox1" runat="server" Height="22px" ValidationGroup="g1"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Fill the name field" ValidationGroup="g1"></asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox1" ErrorMessage="name is invalid" ValidationExpression="[a-zA-Z\s]{2,20}" ValidationGroup="g1"></asp:RegularExpressionValidator>
            <br />
            <br />
            Email -&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox2" runat="server" ValidationGroup="g1"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Fill the email field" ValidationGroup="g1"></asp:RequiredFieldValidator>
            &nbsp;
            <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter valid email id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="g1"></asp:RegularExpressionValidator>
            <br />
            <br />
            Password -&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox3" runat="server" ValidationGroup="g1"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter Password" ValidationGroup="g1"></asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Length must be up to 8 dig" ValidationExpression="\S{6,20}" ValidationGroup="g1"></asp:RegularExpressionValidator>
            <br />
            <br />
            Conform Password -
            <asp:TextBox ID="TextBox6" runat="server" ValidationGroup="g1"></asp:TextBox>
&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TextBox6" ErrorMessage="Required Field" ValidationGroup="g1"></asp:RequiredFieldValidator>
&nbsp;&nbsp;&nbsp;
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox3" ControlToValidate="TextBox6" ErrorMessage="Password does not match" ValidationGroup="g1"></asp:CompareValidator>
            <br />
            <br />
            Phone No -&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp; <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Enter Phone no " ValidationGroup="g1"></asp:RequiredFieldValidator>
            <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox4" ErrorMessage="Pls enter 10 dig" ValidationExpression="(D-)?\d{10}"></asp:RegularExpressionValidator>
            <br />
            <br />
            Age -&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="TextBox5" runat="server" ValidationGroup="g1"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Enter Age" ControlToValidate="TextBox5" ValidationGroup="g1"></asp:RequiredFieldValidator>
            &nbsp;
            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="TextBox5" ErrorMessage="Age must in beetwen 25 to 35" MaximumValue="35" MinimumValue="25" ValidationGroup="g1"></asp:RangeValidator>
            <br />
            <br />
            City -&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:DropDownList ID="DropDownList1" runat="server" ValidationGroup="g1">
                <asp:ListItem>--Selact City--</asp:ListItem>
                <asp:ListItem>Idar</asp:ListItem>
                <asp:ListItem>Hmtl</asp:ListItem>
                <asp:ListItem>Amd</asp:ListItem>
            </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Selact city" ControlToValidate="DropDownList1" InitialValue="--Selact City--" ValidationGroup="g1"></asp:RequiredFieldValidator>
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Submit" ValidationGroup="g1" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" CausesValidation="False" Text="Cancle" ValidationGroup="g1" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            Name - <asp:TextBox ID="TextBox7" runat="server" ValidationGroup="g2"></asp:TextBox>
&nbsp;&nbsp;&nbsp; <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="TextBox7" ErrorMessage="Fill the name field" ValidationGroup="g2"></asp:RequiredFieldValidator>
            &nbsp;&nbsp; <asp:RegularExpressionValidator ID="RegularExpressionValidator6" runat="server" ControlToValidate="TextBox7" ErrorMessage="name is invalid" ValidationExpression="[a-zA-Z\s]{2,20}" ValidationGroup="g2"></asp:RegularExpressionValidator>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
        <p>
            Email -
            <asp:TextBox ID="TextBox8" runat="server" ValidationGroup="g2"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TextBox8" ErrorMessage="Fill the email field" ValidationGroup="g2"></asp:RequiredFieldValidator>
            &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="TextBox8" ErrorMessage="Enter valid email id" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="g2"></asp:RegularExpressionValidator>
            </p>
        <asp:Button ID="Button3" runat="server" Text="LogIn" ValidationGroup="g2" />
    </form>
</body>
</html>
