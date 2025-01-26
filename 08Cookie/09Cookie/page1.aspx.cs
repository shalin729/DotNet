using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page1 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie c1 = new HttpCookie("login");
        c1.Values.Add("v1", TextBox1.Text);
        c1.Values.Add("v2", TextBox2.Text);

        c1.Expires = System.DateTime.Now.AddDays(2);
        Response.Cookies.Add(c1);

        Response.Write("cookie created...");
    }
}