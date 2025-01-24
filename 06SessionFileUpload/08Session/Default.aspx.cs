using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    
        static int i = 1;
    
    protected void Button1_Click(object sender, EventArgs e)
    {

        

        if (FileUpload1.HasFile)
        {
            

                int size = Convert.ToInt32(FileUpload1.FileContent.Length) / 1024;
        switch (i)
        {
            case 1:
                if(size < 200)
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/upload/" + FileUpload1.FileName));
                        Image1.ImageUrl = "~/upload/" + FileUpload1.FileName;

                        Label1.Text = FileUpload1.FileName + " succcessfully attached...";

                        Label2.Text = (size) + "KB";
                    }
                    else
                    {
                        Response.Write("size must be under 200kb");
                        i--;
                    }
                
                break;
            case 2:
                    //int size = Convert.ToInt32(FileUpload1.FileContent.Length) / 1024;
                    if (size < 200)
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/upload/" + FileUpload1.FileName));
                        Image2.ImageUrl = "~/upload/" + FileUpload1.FileName;

                        Label1.Text = FileUpload1.FileName + " succcessfully attached...";

                        Label2.Text = (size) + "KB";
                    }
                    else
                    {
                        Response.Write("size must be under 200kb");
                        i--;
                    }
                    break;
                
            case 3:
                    if (size < 200)
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/upload/" + FileUpload1.FileName));
                        Image3.ImageUrl = "~/upload/" + FileUpload1.FileName;

                        Label1.Text = FileUpload1.FileName + " succcessfully attached...";

                        Label2.Text = (size) + "KB";
                    }
                    else
                    {
                        Response.Write("size must be under 200kb");
                        i--;
                    }
                    break;
            case 4:
                    if (size < 200)
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/upload/" + FileUpload1.FileName));
                        Image4.ImageUrl = "~/upload/" + FileUpload1.FileName;

                        Label1.Text = FileUpload1.FileName + " succcessfully attached...";

                        Label2.Text = (size) + "KB";
                    }
                    else
                    {
                        Response.Write("size must be under 200kb");
                        i--;
                    }
                    break;
            case 5:
                    if (size < 200)
                    {
                        FileUpload1.SaveAs(Server.MapPath("~/upload/" + FileUpload1.FileName));
                        Image5.ImageUrl = "~/upload/" + FileUpload1.FileName;

                        Label1.Text = FileUpload1.FileName + " succcessfully attached...";

                        Label2.Text = (size) + "KB";
                    }
                    else
                    {
                        Response.Write("size must be under 200kb");
                        i--;
                    }
                    break;
            default:
            break;

        }
            i++;

            if (i > 5)
            {
                Response.Write("You can not add more then 5 file");
                i = 5;
            }

        }
        else
        {
            Response.Write("pls select file");
        }
    }


   
    protected void Button2_Click(object sender, EventArgs e)
    {
        if (Image1.ImageUrl != "")
        {
            File.Delete(Server.MapPath(Image1.ImageUrl));
            Image1.ImageUrl = "";
        }
        else if (Image2.ImageUrl != "")
        {
            File.Delete(Server.MapPath(Image2.ImageUrl));
            Image2.ImageUrl = "";
        }
        else if (Image3.ImageUrl != "")
        {
            File.Delete(Server.MapPath(Image3.ImageUrl));
            Image3.ImageUrl = "";
        }
        else if (Image4.ImageUrl != "")
        {
            File.Delete(Server.MapPath(Image4.ImageUrl));
            Image4.ImageUrl = "";
        }
        else if (Image5.ImageUrl != "")
        {
            File.Delete(Server.MapPath(Image5.ImageUrl));
            Image5.ImageUrl = "";
        }

        i--;
        if (i >= 1)
        {
            i = 1;
        }
    }
}






























