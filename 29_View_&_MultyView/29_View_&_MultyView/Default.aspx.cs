﻿using System;
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

    protected void Button4_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 0;
    }

    protected void Button6_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 2;
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        MultiView1.ActiveViewIndex = 1;

    }
}