using DisasterDonationReliefManagementSystem.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DisasterDonationReliefManagementSystem.Services
{
    internal static class Query
    {
        private static readonly string connectionString = "Data Source=shayon\\SQLEXPRESS;Initial Catalog=DisasterDonationReliefDB;Integrated Security=True;Trust Server Certificate=True";

        public static List<Login> GetLogins(string sql)
        {
            List<Login> list = new List<Login>();
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Login(
                    Convert.ToInt32(row["LoginID"]),
                    row["Username"].ToString(),
                    row["Password"].ToString(),
                    Convert.ToBoolean(row["Status"]),
                    row["Role"].ToString()
                ));
            }

            return list;
        }

        public static List<Admin> GetAdmins(string sql) // Gonna need Join query to get the the username and status from Login table
        {
            List<Admin> list = new List<Admin>();
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Admin(
                    Convert.ToInt32(row["AdminID"]),
                    Convert.ToInt32(row["LoginID"]),
                    row["Username"].ToString(),
                    Convert.ToBoolean(row["Status"]),
                    row["FullName"].ToString(),
                    row["Email"].ToString()
                ));
            }

            return list;
        }

        public static List<Victim> GetVictims(string sql) // Gonna need Join query to get the the username and status from Login table
        {
            List<Victim> list = new List<Victim>();
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Victim(
                    Convert.ToInt32(row["VictimID"]),
                    Convert.ToInt32(row["LoginID"]),
                    row["Username"].ToString(),
                    Convert.ToBoolean(row["Status"]),
                    row["FullName"].ToString(),
                    row["Phone"].ToString(),
                    row["Address"].ToString(),
                    row["VerificationStatus"].ToString()
                ));
            }

            return list;
        }

        public static List<Donator> GetDonators(string sql) // Gonna need Join query to get the the username and status from Login table
        {
            List<Donator> list = new List<Donator>();
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Donator(
                    Convert.ToInt32(row["DonatorID"]),
                    Convert.ToInt32(row["LoginID"]),
                    row["Username"].ToString(),
                    Convert.ToBoolean(row["Status"]),
                    row["FullName"].ToString(),
                    row["Phone"].ToString(),
                    row["Address"].ToString()
                ));
            }

            return list;
        }

        public static List<Volunteer> GetVolunteers(string sql) // Gonna need Join query to get the the username and status from Login table
        {
            List<Volunteer> list = new List<Volunteer>();
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Volunteer(
                    Convert.ToInt32(row["VolunteerID"]),
                    Convert.ToInt32(row["LoginID"]),
                    row["Username"].ToString(),
                    Convert.ToBoolean(row["Status"]),
                    row["FullName"].ToString(),
                    row["Phone"].ToString(),
                    row["VehicleType"].ToString(),
                    row["AvailabilityStatus"].ToString()
                ));
            }

            return list;
        }

        public static List<DisasterRequest> GetDisasterRequests(string sql)
        {
            List<DisasterRequest> list = new List<DisasterRequest>();
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new DisasterRequest(
                    Convert.ToInt32(row["RequestID"]),
                    Convert.ToInt32(row["VictimID"]),
                    row["DisasterTitle"].ToString(),
                    row["DisasterType"].ToString(),
                    row["Description"].ToString(),
                    row["RequestedItems"].ToString(),
                    Convert.ToInt32(row["NumberOfMembers"]),
                    Convert.ToDateTime(row["RequestDate"]),
                    row["Location"].ToString(),
                    row["RequestStatus"].ToString()
                ));
            }

            return list;
        }

        public static List<Donation> GetDonations(string sql)
        {
            List<Donation> list = new List<Donation>();
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Donation(
                    Convert.ToInt32(row["DonationID"]),
                    Convert.ToInt32(row["DonatorID"]),
                    Convert.ToInt32(row["RequestID"]),
                    row["DonationType"].ToString(),
                    row["ItemDetails"].ToString(),
                    Convert.ToDateTime(row["DonationDate"]),
                    row["DonationStatus"].ToString()
                ));
            }

            return list;
        }

        public static List<Delivery> GetDeliveries(string sql)
        {
            List<Delivery> list = new List<Delivery>();
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                list.Add(new Delivery(
                    Convert.ToInt32(row["DeliveryID"]),
                    Convert.ToInt32(row["DonationID"]),
                    Convert.ToInt32(row["VolunteerID"]),
                    row["PickupLocation"].ToString(),
                    row["DeliveryLocation"].ToString(),
                    row["DeliveryStatus"].ToString()
                ));
            }

            return list;
        }

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
