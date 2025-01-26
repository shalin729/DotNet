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
        //if (Request.Cookies["login"] != null)
        //{
            TextBox1.Text = Request.Cookies["login"].Values["v1"].ToString();
            TextBox2.Text = Request.Cookies["login"].Values["v2"].ToString();
            CheckBox1.Checked = true;
            //Response.Write(Request.Cookies["login"].Values["v1"].ToString());
        //}
        //else
        //{
        //    TextBox1.Text = "";
        //    TextBox2.Text = "";

        //    CheckBox1.Checked = false;
        //}
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        if (CheckBox1.Checked)
        {
            HttpCookie c1 = new HttpCookie("login");
            c1.Values.Add("v1", TextBox1.Text);
            c1.Values.Add("v2", TextBox2.Text);
  

            c1.Expires = System.DateTime.Now.AddDays(2);
            Response.Cookies.Add(c1);

            Response.Write("Login Succesfully...");
        }
    }
}