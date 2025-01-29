using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    public string Encryption(string EncryptPass)
    {
        byte[] b = ASCIIEncoding.ASCII.GetBytes(EncryptPass);
        return Convert.ToBase64String(b);
    }
    public string Decryption(string DecryptPass)
    {
        byte[] b = Convert.FromBase64String(DecryptPass);
        return ASCIIEncoding.ASCII.GetString(b);
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Label1.Text = Encryption(TextBox1.Text);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        Label2.Text = Decryption(Label1.Text);
    }
}