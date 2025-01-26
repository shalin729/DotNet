using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class page2 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Cookies["login"]!=null)
        {
            Label1.Text = Request.Cookies["login"].Values["v1"].ToString();
            Label2.Text = Request.Cookies["login"].Values["v2"].ToString();

        }
    }

    
}