using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        //Label1.Text = Request.QueryString["name"];
        //Label2.Text = Request.QueryString["email"];


    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        string uname = Request.QueryString["name"];
        string uemail = Request.QueryString["email"];
        string upass = Request.QueryString["password"];
        string gender = Request.QueryString["gender"];

        Response.Write(uname+uemail+upass+gender);
        if (uemail == TextBox1.Text && upass == TextBox2.Text)
        {
            Response.Redirect("page3.aspx?name=" + uname + "&email=" + uemail + "&password=" + upass + "&gender=" + gender);

        }
        else
        {
            Response.Write("Uname or Password is wrong");
        }
    }
}