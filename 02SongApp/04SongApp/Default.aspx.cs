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

    //protected void Button1_Click(object sender, EventArgs e)
    //{
    //}

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        Literal1.Text = "<source src=\""+DropDownList1.Text + "\"/>";
        Label1.Text = DropDownList1.Text;

    }
}