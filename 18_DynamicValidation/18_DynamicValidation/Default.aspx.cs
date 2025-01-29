using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        form1.Controls.Add(new LiteralControl("Name - "));

        TextBox t1 = new TextBox();
        t1.ID = "t1";
        t1.Width = 200;
        form1.Controls.Add(t1);
        t1.ValidationGroup = "g1";
        RequiredFieldValidator rv1 = new RequiredFieldValidator();
        rv1.ID = "rv1";
        rv1.Text = "Enter field";
        rv1.ControlToValidate = "t1";
        rv1.ValidationGroup = "g1";
        form1.Controls.Add(rv1);

        RegularExpressionValidator re1 = new RegularExpressionValidator();
        re1.ID = "re1";
        re1.Text = "Name is invalid";
        re1.ControlToValidate = "t1";
        re1.ValidationGroup = "g1";
        re1.ValidationExpression = "[A-Za-z\\s]{2,50}";
        form1.Controls.Add(re1);

        form1.Controls.Add(new LiteralControl("<br><br>"));


        form1.Controls.Add(new LiteralControl("Email - "));
        TextBox t2 = new TextBox();
        t2.ID = "t2";
        t2.Width = 200;
        t2.ValidationGroup = "g1";
        form1.Controls.Add(t2);
        RequiredFieldValidator rv2 = new RequiredFieldValidator();
        rv2.ID = "rv2";
        rv2.Text = "Enter field";
        rv2.ControlToValidate = "t2";
        rv2.ValidationGroup = "g1";
        form1.Controls.Add(rv2);
        RegularExpressionValidator re2 = new RegularExpressionValidator();
        re2.ID = "re2";
        re2.Text = "Email is invalid";
        re2.ControlToValidate = "t2";
        re2.ValidationGroup = "g1";
        re2.ValidationExpression = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        form1.Controls.Add(re2);

        form1.Controls.Add(new LiteralControl("<br><br>"));
        Button b1 = new Button();
        b1.ID = "b1";
        b1.Text = "Submit";
        b1.ValidationGroup = "g1";
        form1.Controls.Add(b1);
    }
}