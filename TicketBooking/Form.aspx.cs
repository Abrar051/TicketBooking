using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogic;

namespace TicketBooking
{
    public partial class Form : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        protected void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Passenger passenger = new Passenger();
            passenger.name = TextBox1.Text;
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
            if (RadioButton1.Checked == true)
            {
                passenger.insuranceOpt = "Yes";
            }
            else
            {
                passenger.insuranceOpt = "No";
            }
            passenger.email = TextBox7.Text;
            PassengerBusinessLayer passengerB = new PassengerBusinessLayer();
            passengerB.AddPassenger(passenger);
            Response.Redirect(Request.RawUrl);
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("./DatabaseView.aspx");
        }
    }
}