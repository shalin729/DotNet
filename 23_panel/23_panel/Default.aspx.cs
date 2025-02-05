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

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Write("<script>alert('LogIn BTN clicked')</script>");
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Response.Write("<script>alert('Registration BTN clicked')</script>");

    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Write("<script>alert('Search BTN clicked')</script>");
    }
}