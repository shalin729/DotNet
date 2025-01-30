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
        var characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwzyz1234567890";
        var stringChar = new char[5];
        var random = new Random();

        for (int i = 0; i < 5; i++)
        {
            stringChar[i] = characters[random.Next(characters.Length)];
        }
        var finalString = new string(stringChar);
        ////Response.Write(finalString);

        //Label1.Text = finalString;


        Bitmap b = new Bitmap(250, 30, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
        Graphics g = Graphics.FromImage(b);
        string message;
        g.Clear(Color.Yellow);
        message = finalString;
        g.DrawString(message, new Font("Arial", 12, FontStyle.Strikeout),
        new SolidBrush(Color.Black), new PointF(0.5F, 2.5F));
        Response.ContentType = "image/gif";
        b.Save(Response.OutputStream, ImageFormat.Gif);
        b.Dispose();
    }
}