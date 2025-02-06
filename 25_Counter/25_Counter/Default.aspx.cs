using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (i == 15)
        {
            Timer1.Enabled = false;
        }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        i++;
        Label1.Text += "," + Convert.ToString( Convert.ToInt32(i));
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Timer1.Enabled = true;
    }


    protected void Button2_Click(object sender, EventArgs e)
    {
        Timer1.Enabled=false;
    }
    
}