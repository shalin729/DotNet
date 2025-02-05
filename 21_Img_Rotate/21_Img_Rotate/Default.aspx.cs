using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //string path = Server.MapPath(Image1.ImageUrl);
        ////Response.Write(path);
        //// creating image from the image url
        //System.Drawing.Image i = System.Drawing.Image.FromFile(path);

        //// rotate Image 90' Degree
        //i.RotateFlip(RotateFlipType.Rotate90FlipX);

        //// save it to its actual path
        //i.Save(path);

        //// release Image File
        //i.Dispose();
        Response.Write("<script>console.log('Data inserted successfully')</script>");
    }
}