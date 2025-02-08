using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static int i = 0;
    static int sec = 0;
    static int min = 0; 
    static int hr = 0;
    protected void Page_Load(object sender, EventArgs e)
    {

    }


    protected void Timer1_Tick(object sender, EventArgs e)
    {

        i++;
        Label4.Text = Convert.ToString(Convert.ToInt32(i));

        if (i == 60)
        {
            i = 0;
            sec++;
            Label3.Text = Convert.ToString(Convert.ToInt32(sec));
        }
        if (sec == 60)
        {
            sec = 0;
            min++;
            Label2.Text = Convert.ToString(Convert.ToInt32(min));
        }
        if (min == 60)
        {
            min = 0;
            hr++;
            Label1.Text = Convert.ToString(Convert.ToInt32(hr));
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        Timer1.Enabled = true;
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Timer1.Enabled = false;
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Timer1.Enabled=false;
        Label1.Text = "00";
        Label2.Text = "00";
        Label3.Text = "00";
        Label4.Text = "00";
    }
}