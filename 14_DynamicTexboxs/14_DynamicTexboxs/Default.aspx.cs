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

    //static int i = 0;
    protected void Button1_Click(object sender, EventArgs e)
    {
        int val = Convert.ToInt32(TextBox1.Text);
        //int val = TextBox1.Text;


        for (int i = 1; i <= val; i++) 
        {
            //Response.Write("hello <br>");
            string Textboxid = "Textbox" + i;
            TextBox tb = new TextBox();
            tb.ID = Textboxid;
            form1.Controls.Add(tb);
            form1.Controls.Add(new LiteralControl("<br><br>"));
        }
    }
}