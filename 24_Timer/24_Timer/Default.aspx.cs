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

    protected void Timer1_Tick(object sender, EventArgs e)
    {
        Label1.Text =Convert.ToString( Convert.ToInt32( Label1.Text) + 1);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Timer1.Enabled = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Timer1.Enabled = false;
    }
}