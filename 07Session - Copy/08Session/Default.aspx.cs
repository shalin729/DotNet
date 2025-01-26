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
                        if (Path.GetExtension(FileUpload1.FileName) == ".png" || Path.GetExtension(FileUpload1.FileName) == ".jpg")
                        {

                            FileUpload1.SaveAs(Server.MapPath("~/upload/" + FileUpload1.FileName));
                            Image1.ImageUrl = "~/upload/" + FileUpload1.FileName;

                            Label1.Text = FileUpload1.FileName + " succcessfully attached...";

                            Label2.Text = (size) + "KB";
                            //Response.Write(Path.GetExtension(FileUpload1.FileName));
                        }
                        else
                        {
                            Response.Write("You can upload png files only");
                        }
                    }
                    else
                    {
                        Response.Write("size must be under 200kb");
                        i--;
                    }
                
                break;
            case 2:
                    if (size < 200)
                    {
                        if (File.Exists(Server.MapPath("~/upload/" + FileUpload1.FileName)))
                        {
                            Response.Write("File already Exist");
                        }
                        else {
                            if (Path.GetExtension(FileUpload1.FileName) == ".png" || Path.GetExtension(FileUpload1.FileName) == ".jpg")
                            {
                                FileUpload1.SaveAs(Server.MapPath("~/upload/" + FileUpload1.FileName));
                                Image2.ImageUrl = "~/upload/" + FileUpload1.FileName;

                                Label1.Text = FileUpload1.FileName + " succcessfully attached...";

                                Label2.Text = (size) + "KB";
                            }
                            else
                            {
                                Response.Write("You can upload png files only");
                            }
                        }
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

            if (i > 3)
            {
                Response.Write("You can not add more then 2 file");
                i = 2;
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
    

        i--;
        if (i >= 1)
        {
            i = 1;
        }
    }
}































//switch (i)
//{
//    case 1:
//        Response.Write(i);
//        File.Delete(Server.MapPath(Image1.ImageUrl));
//        break;
//    case 2:
//        Response.Write(i);
//        File.Delete(Server.MapPath(Image2.ImageUrl));
//        break;
//    case 3:
//        Response.Write(i);
//        File.Delete(Server.MapPath(Image3.ImageUrl));
//        break;
//    case 4:
//        Response.Write(i);
//        File.Delete(Server.MapPath(Image4.ImageUrl));
//        break;
//    case 5:
//        Response.Write(i);
//        File.Delete(Server.MapPath(Image5.ImageUrl));
//        break;
//    default:
//        break;
//}








//if(j>=5)
//{
//    j = 1;
//}
//Label3.Text = "i="+j;
//if (j == 1)
//{
//    File.Delete(Server.MapPath(Image1.ImageUrl));
//}else if (j == 2)
//{
//    File.Delete(Server.MapPath(Image2.ImageUrl));
//}
//else if (j == 3)
//{
//    File.Delete(Server.MapPath(Image3.ImageUrl));
//}
//else if (j == 4)
//{
//    File.Delete(Server.MapPath(Image4.ImageUrl));
//}
//else if (j == 5)
//{
//    File.Delete(Server.MapPath(Image5.ImageUrl));
//}
//j++;
