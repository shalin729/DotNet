using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    static string[] bg = { "bg1.jpg", "bg2.jpg", "bg3.jpg", "bg4.jpg", "bg5.jpg", "bg6.jpg" };
    static int i = 0;
    protected void Page_Load(object sender, EventArgs e)
    {
        bd1.Style.Add("background-image", "url("+bg[i]+")");
        bd1.Style.Add("background-size", "cover");
        bd1.Style.Add("background-repeat", "no-repeat");

        i++;
        if (i == bg.Length) {
            
                i = 0;
            }
    }
    protected void Timer1_Tick(object sender, EventArgs e)
    {
        //Random random = new Random();
        //string ch = "ABCDEF1234567890";
        //string color = "#";
    
        //for (int i = 0; i < 6; i++)
        //{
        //    color += ch[random.Next(0, ch.Length)];
        //}
        //bd1.Style.Add("background-color", color);
    }
}