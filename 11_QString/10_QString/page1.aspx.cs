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

   
        string gen;
    protected void Button1_Click(object sender, EventArgs e)
    {
        if(RadioButton1.Checked)
        {
            gen = "male";
            //Response.Write(gen);

        }
        if(RadioButton2.Checked)
        {
            gen = "Female";
            //Response.Write(gen);
        }
        Response.Redirect("page2.aspx?name="+TextBox1.Text+"&email="+TextBox2.Text+"&password="+ TextBox3.Text+"&gender="+gen);
     
    }
}