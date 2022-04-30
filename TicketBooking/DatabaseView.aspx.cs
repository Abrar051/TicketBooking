using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

namespace TicketBooking
{
    public partial class DatabaseView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void passengerSetValue (Passenger passenger)
        {
            passenger.name = TextBox8.Text;
            passenger.city = DropDownList1.SelectedValue;
            if (CheckBox1.Checked == true)
            {
                passenger.singleConfig = "Yes";
            }
            else
            {
                passenger.singleConfig = "No";
            }
            passenger.date = TextBox2.Text;
            passenger.ticketNumbers = Convert.ToInt32(TextBox3.Text);
            passenger.mobileNumber = TextBox4.Text;
            passenger.address = TextBox5.Text;
            passenger.toDate = TextBox6.Text;
            if (CheckBox2.Checked == true)
            {
                passenger.insuranceOpt = "Yes";
            }
            else
            {
                passenger.insuranceOpt = "No";
            }
            passenger.email = TextBox7.Text;
        }

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            
            TextBox8.Text = GridView1.SelectedRow.Cells[1].Text;
            DropDownList1.Text = GridView1.SelectedRow.Cells[2].Text;
            TextBox2.Text = GridView1.SelectedRow.Cells[4].Text;
            TextBox3.Text = GridView1.SelectedRow.Cells[5].Text;
            TextBox4.Text = GridView1.SelectedRow.Cells[5].Text;
            TextBox5.Text = GridView1.SelectedRow.Cells[6].Text;
            TextBox6.Text = GridView1.SelectedRow.Cells[6].Text;
            TextBox7.Text = GridView1.SelectedRow.Cells[8].Text;
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger();
            passengerSetValue(passenger);
            PassengerBusinessLayer passengerB = new PassengerBusinessLayer();
            passengerB.UpdatePassengers(passenger);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //Delete
            Passenger passenger = new Passenger();
            passengerSetValue(passenger);
            PassengerBusinessLayer passengerB = new PassengerBusinessLayer();
            passengerB.DeletePassengers(passenger);
            Response.Redirect(Request.RawUrl);
        }
    }
}