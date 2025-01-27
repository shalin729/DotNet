using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class dc : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Label l1 = new Label();
        l1.ID = "lbl1";
        l1.Text = "Name";
        l1.ForeColor = System.Drawing.Color.Green;
        form1.Controls.Add(l1);

        form1.Controls.Add(new LiteralControl("&nbsp;&nbsp"));

        TextBox t1 = new TextBox();
        t1.ID = "txt1";
        t1.Width = 100;
        t1.TextMode = TextBoxMode.SingleLine;
        form1.Controls.Add(t1);

        form1.Controls.Add(new LiteralControl("<br><br>"));

        Label l2 = new Label();
        l2.ID = "lbl2";
        l2.Text = "Email";
        l2.ForeColor = System.Drawing.Color.Green;
        form1.Controls.Add(l2);

        form1.Controls.Add(new LiteralControl("&nbsp;&nbsp"));

        TextBox t2 = new TextBox();
        t2.ID = "txt2";
        t2.Width = 100;
        t2.TextMode = TextBoxMode.SingleLine;
        form1.Controls.Add(t2);

        form1.Controls.Add(new LiteralControl("<br><br>"));


        Label l3 = new Label();
        l3.ID = "lbl3";
        l3.Text = "Gender";
        l3.ForeColor = System.Drawing.Color.Green;
        form1.Controls.Add(l3);

        form1.Controls.Add(new LiteralControl("&nbsp;&nbsp"));

        form1.Controls.Add(new LiteralControl("Male"));

        RadioButton r1 = new RadioButton();
        r1.ID = "rdo1";
        r1.GroupName = "gen";
        form1.Controls.Add(r1);

        form1.Controls.Add(new LiteralControl("Female"));

        RadioButton r2 = new RadioButton();
        r2.ID = "rdo2";
        r2.GroupName = "gen";
        form1.Controls.Add(r2);





        form1.Controls.Add(new LiteralControl("<br><br>"));

        form1.Controls.Add(new LiteralControl("City"));

        DropDownList ddl = new DropDownList();
        ddl.ID = "ddlist";       
        Form.Controls.Add(ddl);
        form1.Controls.Add(new LiteralControl("&nbsp;&nbsp"));
        ddl.Items.Add("Surat");
        ddl.Items.Add("Himmatnagr");
        ddl.Items.Add("Idar");





        form1.Controls.Add(new LiteralControl("<br><br>"));


        Button b1 = new Button();
        b1.ID = "btn1";
        b1.Text = "Submit";
        b1.Click += B1_Click;
        form1.Controls.Add(b1);


    }

    private void B1_Click(object sender, EventArgs e)
    {
        TextBox textbox1 = (TextBox)FindControl("txt1");
        TextBox textbox2 = (TextBox)FindControl("txt2");

        RadioButton rdo1 = (RadioButton)FindControl("rdo1");
        RadioButton rdo2 = (RadioButton)FindControl("rdo2");
        DropDownList ddlist = (DropDownList)FindControl("ddlist");
        Response.Write("Name - " + textbox1.Text +"<br>");
        Response.Write("Email - " + textbox2.Text +"<br>");


        if (rdo1.Checked == true)
        {
            Response.Write("Gender - Male <br>");
        }
        else if (rdo2.Checked == true)
        { 
            Response.Write("Gender - Female <br>");
        }
        else
        {
            Response.Write("Gender - <br>");
        }
        Response.Write("City - " + ddlist.Text +"<br>");

    }
}