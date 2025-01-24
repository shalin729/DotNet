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

   static string[,] colors = { {"red", "blue", "green" }, {"black", "#efddd4","#FF6633" }, { "red", "blue", "green" }, { "black", "#efddd4", "#FF6633" }, { "red", "blue", "green" }, { "black", "#efddd4", "#FF6633" }, { "red", "blue", "green" }, { "black", "#efddd4", "#FF6633" } };

    static int i = 0;
    static int j = 0;
 
    protected void Button1_Click(object sender, EventArgs e)
    {

        //i++;
        bd1.Style.Add("background-color", colors[i,j]);
        j++;
        if (j == 3) { i++; j = 0; }
        Response.Write(i);

    }

    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        bd1.Style.Add("background-color", DropDownList1.SelectedValue);

    }

}