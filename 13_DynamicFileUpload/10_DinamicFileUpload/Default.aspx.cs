using System;
using System.Collections.Generic;
using System.Linq;
//using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        

        FileUpload fileUpload = new FileUpload();
        fileUpload.ID = "FileUpload1";
        form1.Controls.Add(fileUpload);

        Button button = new Button();
        button.ID = "Button1";
        button.Text = "Upload";
        button.Click += Button_Click;
        form1.Controls.Add(button);

        form1.Controls.Add(new LiteralControl("<br><br>"));
        form1.Controls.Add(new LiteralControl("Name - "));

        Label l1 = new Label();
        l1.ID = "lbl1";
        l1.Text = "";
        l1.ForeColor = System.Drawing.Color.Green;
        form1.Controls.Add(l1);



        form1.Controls.Add(new LiteralControl("<br><br>"));
        form1.Controls.Add(new LiteralControl("Size - "));

        Label l2 = new Label();
        l2.Text = "";
        l2.ForeColor = System.Drawing.Color.Green;
        l2.ID = "lbl2";
        form1.Controls.Add(l2);

        form1.Controls.Add(new LiteralControl("<br><br>"));
        form1.Controls.Add(new LiteralControl("<br><br>"));

        Image image = new Image();
        image.ID = "Image1";
        image.Width = 300;
        image.Height = 200;
        form1.Controls.Add(image);

    }


    private void Button_Click(object sender, EventArgs e)
    {
        FileUpload FileUpload1 = (FileUpload)FindControl("FileUpload1");
        Image Image1 = (Image)FindControl("Image1");
        Label Label1 = (Label)FindControl("Lbl1");
        Label Label2 = (Label)FindControl("Lbl2");
        if (FileUpload1.HasFile)
        {
            FileUpload1.SaveAs(Server.MapPath("~/upload/" + FileUpload1.FileName));
            Image1.ImageUrl = "~/upload/" + FileUpload1.FileName;

            Label1.Text = FileUpload1.FileName + " succcessfully attached...";



            Label2.Text = Convert.ToInt32(FileUpload1.FileContent.Length) / 1024 + "KB";
        }
    }
}