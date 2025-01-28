using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            Label2.Text = "0";
        }
}
    protected void Button1_Click(object sender, EventArgs e)
    {
        if (FileUpload1.HasFile)
        {
            int size = Convert.ToInt32(FileUpload1.FileContent.Length) / 1024;

            FileUpload1.SaveAs(Server.MapPath("~/upload/" + FileUpload1.FileName));

            Session["s" + Label2.Text] = "~/upload/" + FileUpload1.FileName;

            Label2.Text = Convert.ToString(Convert.ToInt32(Label2.Text)+1);
            Label1.Text += "("+Label2.Text+")"+ FileUpload1.FileName.ToString() + " is Uploaded Succsessfully...  ("+size+" Kb.)<br>";
        }
    }   
    protected void Button2_Click(object sender, EventArgs e)
    {

            form1.Controls.Add(new LiteralControl("<br>"));
        for(int i = 0; i < Convert.ToInt32(Label2.Text); i++)
        {
            Image img = new Image();
            img.ID = "img"+i;
            img.Width = 150;
            img.Height = 100;
            if (Session["s" + i] != null)
            {
                img.ImageUrl = Session["s" + i].ToString();
                form1.Controls.Add(img);
            }
            //form1.Controls.Add(img);
            form1.Controls.Add(new LiteralControl("&nbsp;&nbsp"));
        }
    }
}