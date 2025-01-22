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



    protected void Button3_Click(object sender, EventArgs e)
    {
        ListBox2.Items.Add(ListBox1.SelectedItem.Text);
        ListBox1.Items.Remove(ListBox1.SelectedItem.Text);
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        ListBox1.Items.Add(ListBox2.SelectedItem.Text);
        ListBox2.Items.Remove(ListBox2.SelectedItem.Text);
    }

    protected void Button5_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ListBox1.Items.Count; i++)
        {
            ListBox2.Items.Add(ListBox1.Items[i].Text);
    
        }
        ListBox1.Items.Clear();
    }

    protected void Button4_Click(object sender, EventArgs e)
    {
        for (int i = 0; i < ListBox2.Items.Count; i++)
        {
            ListBox1.Items.Add(ListBox2.Items[i].Text);
        }
        ListBox2.Items.Clear();
    }
}