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
        

        //int[] num = { 1, 2, 3, 4, 5 };
        //int[] num = new int[5];

        int[,] num = new int[3,3];

        num[0,0] = Convert.ToInt32( TextBox1.Text);
        num[0,1] = Convert.ToInt32(TextBox2.Text);
        num[0,2] = Convert.ToInt32(TextBox3.Text);
        num[1,0] = Convert.ToInt32(TextBox4.Text);
        num[1,1] = Convert.ToInt32(TextBox5.Text);
        num[1,2] = Convert.ToInt32(TextBox6.Text);
        num[2,0] = Convert.ToInt32(TextBox7.Text);
        num[2,1] = Convert.ToInt32(TextBox8.Text);
        num[2,2] = Convert.ToInt32(TextBox9.Text);

        int sum = 0;    
        
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Response.Write ( Convert.ToInt32( num[i,j]) + "&nbsp;&nbsp");
            }
            Response.Write( "<br>");
        }
        Response.Write("<br>");
        Response.Write("<br>");

    }
}