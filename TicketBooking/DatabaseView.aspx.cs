using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TicketBooking
{
    public partial class DatabaseView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            
            TextBox1.Text = GridView1.SelectedRow.Cells[0].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[1].Text;
            TextBox3.Text = GridView1.SelectedRow.Cells[2].Text;
            TextBox4.Text = GridView1.SelectedRow.Cells[3].Text;
            TextBox5.Text = GridView1.SelectedRow.Cells[4].Text;
            TextBox6.Text = GridView1.SelectedRow.Cells[5].Text;
            TextBox7.Text = GridView1.SelectedRow.Cells[6].Text;
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}