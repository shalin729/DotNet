using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {


            if (Request.Cookies["txt"] != null)
            {
                TextBox1.Text = Request.Cookies["txt"].Values["v1"].ToString();


                Label1.Text = "Something went wrong";
            }
            else
            {
                Label1.Text = "Write something";
            }
        }
    }
    

    protected void Button1_Click(object sender, EventArgs e)
    {
        HttpCookie t1 = new HttpCookie("txt");
        t1.Values.Add("v1", TextBox1.Text);
        t1.Expires = System.DateTime.Now.AddDays(2);
        Response.Cookies.Add(t1);
        Response.Write("Saved");
    }

    protected void Timer1_Tick1(object sender, EventArgs e)
    {
        if (!string.IsNullOrEmpty(TextBox1.Text))
        {
            HttpCookie t1 = new HttpCookie("txt");
            t1.Values.Add("v1", TextBox1.Text);
            t1.Expires = System.DateTime.Now.AddDays(2);
            Response.Cookies.Add(t1);
            Response.Write("Auto Saved");
        }
    }
}