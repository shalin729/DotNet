using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
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
        Bitmap b = new Bitmap(300, 300, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        Graphics g = Graphics.FromImage(b);
        string Text;
        g.Clear(Color.Red);
        Text = TextBox1.Text;
        g.DrawString(Text, new Font("Arial", 12),
        new SolidBrush(Color.Blue), new PointF(0.5F, 2.5F));
        Response.ContentType = "image/gif";
        b.Save(Response.OutputStream, ImageFormat.Gif);
        b.Dispose();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Bitmap b = new Bitmap(300, 300, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        Graphics g = Graphics.FromImage(b);
        string Text;
        g.Clear(Color.Red);
        Text = TextBox1.Text;
        g.DrawString(Text, new Font("Arial", 12),
        new SolidBrush(Color.Blue), new PointF(0.5F, 2.5F));
        Response.ContentType = "image/png";
        b.Save(Response.OutputStream, ImageFormat.Gif);
        b.Dispose();
    }

    protected void Button3_Click(object sender, EventArgs e)
    {
        Bitmap b = new Bitmap(300, 300, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        Graphics g = Graphics.FromImage(b);
        string Text;
        g.Clear(Color.Red);
        Text = TextBox1.Text;
        g.DrawString(Text, new Font("Arial", 12),
        new SolidBrush(Color.Blue), new PointF(0.5F, 2.5F));
        Response.ContentType = "image/jpg";
        b.Save(Response.OutputStream, ImageFormat.Gif);
        b.Dispose();
    }
}