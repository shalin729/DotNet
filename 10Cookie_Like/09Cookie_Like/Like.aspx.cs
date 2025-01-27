using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Like : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        if (Request.Cookies["likes"] != null)
        {
            Label1.Text = Request.Cookies["likes"].Values["v1"];
        }else
        { 
            Response.Write("Not set"); 
        }

        //string likecount = Request.Cookies["likes"].Values["like"];
        //Label1.Text = i.ToString();
        //Label1.Text = like.Value;


    }
    static int i = 0;
    protected void Button1_Click(object sender, EventArgs e)
    {
        i = i + 1;
        //Label1.Text = i.ToString();
        HttpCookie like = new HttpCookie("likes");
        like.Values.Add("v1", i.ToString());
        like.Expires = DateTime.Now.AddDays(30);
        Response.Cookies.Add(like);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        i--;
        //Label1.Text = i.ToString();
        HttpCookie like = new HttpCookie("likes");
        like.Values.Add("v1",i.ToString());
        like.Expires = DateTime.Now.AddDays(30);
        Response.Cookies.Add(like);
  
    }


}


