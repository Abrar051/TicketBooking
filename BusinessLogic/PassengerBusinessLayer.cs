using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations;
using BusinessLogic;

namespace BusinessLogic
{
    public class PassengerBusinessLayer
    {
        public IAsyncEnumerable<Passenger> Passengers
        {
            get
            {
                string connectionString = "Data Source=.;Initial Catalog=mydb;Integrated Security=True";
                List<Passenger> passengers = new List<Passenger>();
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = con.CreateCommand();
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        Passenger passenger = new Passenger();
                        passenger.name = dr["Full_Name"].ToString();
                        passenger.city = dr["From_City"].ToString();
                        passenger.singleConfig = dr["Single_lady"].ToString();
                        passenger.date = dr["From_Date"].ToString();
                        passenger.ticketNumbers = Convert.ToInt32(dr["Number_of_Tickets"]);
                        passenger.mobileNumber = dr["Mobile_Number"].ToString();
                        passenger.address = dr["Address"].ToString();
                        passenger.toCity = dr["Full_Name"].ToString();
                        passenger.roundTrip = dr["Round_Trip"].ToString();
                        passenger.toDate = dr["To_Date"].ToString();
                        passenger.insuranceOpt = dr["Insurance_Opt"].ToString();
                        passenger.email = dr["Email"].ToString();
                        passengers.Add(passenger);
                    }
                }
                return Passengers;
            }
        }

        public void AddPassenger(Passenger passenger)
        {
            string connectionString = "Data Source=.;Initial Catalog=mydb;Integrated Security=True";

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO dbo.ticketorder (Full_Name , From_City , Single_Lady , From_Date , Number_of_Tickets , Address , To_City , Round_Trip , To_Date , Insurance_Opt , Email) values ('" + passenger.name + "','" + passenger.city + "','" + passenger.singleConfig + "','" + passenger.date + "','" + passenger.ticketNumbers + "','" + passenger.address + "','" + passenger.city + "','" + passenger.roundTrip + "','" + passenger.toDate + "','" + passenger.insuranceOpt + "','" + passenger.email + "')";
                cmd.ExecuteNonQuery();
                con.Close();
            }
        }

        public void UpdatePassengers(Passenger passenger)
        {
            string connectionString = "Data Source=.;Initial Catalog=mydb;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "UPDATE dbo.employee SET Full_Name=@fname , From_City=@lname , Gender=@gender , Age=@age , Phone=@phone , Education=@education , Salary=@salary WHERE  Email=@email";
                cmd.Parameters.AddWithValue("@name", passenger.name);
                cmd.Parameters.AddWithValue("@city", passenger.city);
                cmd.Parameters.AddWithValue("@singleConfig", passenger.singleConfig);
                cmd.Parameters.AddWithValue("@date", passenger.date);
                cmd.Parameters.AddWithValue("@ticketNumbers", passenger.ticketNumbers);
                cmd.Parameters.AddWithValue("@mobileNumber", passenger.mobileNumber);
                cmd.Parameters.AddWithValue("@address", passenger.address);
                cmd.Parameters.AddWithValue("@toCity", passenger.city);
                cmd.Parameters.AddWithValue("@roundTrip", passenger.roundTrip);
                cmd.Parameters.AddWithValue("@toDate", passenger.toDate);
                cmd.Parameters.AddWithValue("@insuranceOpt", passenger.insuranceOpt);
                cmd.Parameters.AddWithValue("@email", passenger.email);

                cmd.CommandType = System.Data.CommandType.Text;
                cmd.ExecuteNonQuery();
            }
        }

        public void DeletePassengers(int id)
        {
            string connectionString = "Data Source=.;Initial Catalog=mydb;Integrated Security=True";
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@PassengerId", id);
                cmd.ExecuteNonQuery();
            }
        }

    }
}
