using DisasterDonationReliefManagementSystem.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace DisasterDonationReliefManagementSystem.Services
{
    internal static class Query
    {
        private static readonly string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=DisasterDonationReliefDB;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        private static SqlConnection con = new SqlConnection(connectionString);

        //---------------------SELECT QUERIES---------------------//
        public static List<Login> GetLogins(string sql)
        {
            List<Login> list = new List<Login>();
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
                    row["Role"].ToString(),
                    row["Message"].ToString()
                ));
                //{
                //    Message = row.Table.Columns.Contains("Message") ? row["Message"].ToString() : null
                //});
            }

            return list;
        }

        public static List<Admin> GetAdmins(string sql) // Gonna need Join query to get the the username and status from Login table
        {
            List<Admin> list = new List<Admin>();
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
                    row["Email"].ToString(),
                    row["Message"].ToString()
                ));
            }

            return list;
        }

        public static List<Victim> GetVictims(string sql) // Gonna need Join query to get the the username and status from Login table
        {
            List<Victim> list = new List<Victim>();
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
                    row["VerificationStatus"].ToString(),
                    row["Message"].ToString()

                ));
            }

            return list;
        }

        public static List<Donator> GetDonators(string sql) // Gonna need Join query to get the the username and status from Login table
        {
            List<Donator> list = new List<Donator>();
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
                    row["Address"].ToString(),
                    row["Message"].ToString()
                ));
            }

            return list;
        }

        public static List<Volunteer> GetVolunteers(string sql) // Gonna need Join query to get the the username and status from Login table
        {
            List<Volunteer> list = new List<Volunteer>();
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
                    row["AvailabilityStatus"].ToString(),
                    row["Message"].ToString()
                ));
            }

            return list;
        }

        public static List<DisasterRequest> GetDisasterRequests(string sql)
        {
            List<DisasterRequest> list = new List<DisasterRequest>();
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

        public static Dictionary<string, int> GetInfos()
        {
            Dictionary<string, int> infos = new Dictionary<string, int>();

            string sql = @"
            SELECT
                (SELECT COUNT(*) FROM Login) AS TotalUsers,
                (SELECT COUNT(*) FROM Login WHERE Status = 1) AS ActiveUsers,
                (SELECT COUNT(*) FROM Login WHERE Status = 0) AS InactiveUsers,
                (SELECT COUNT(*) FROM DisasterRequest) AS TotalRequests,
                (SELECT COUNT(*) FROM DisasterRequest WHERE RequestStatus = 'Pending') AS PendingRequests;
            ";

            SqlDataAdapter sda = new SqlDataAdapter(sql, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];

                infos["TotalUsers"] = Convert.ToInt32(row["TotalUsers"]);
                infos["ActiveUsers"] = Convert.ToInt32(row["ActiveUsers"]);
                infos["InactiveUsers"] = Convert.ToInt32(row["InactiveUsers"]);
                infos["TotalRequests"] = Convert.ToInt32(row["TotalRequests"]);
                infos["PendingRequests"] = Convert.ToInt32(row["PendingRequests"]);
            }

            return infos;
        }

        //---------------------------------------------------------------//


        //-------------------------Insert Queries-------------------------//

        public static int InsertLogin(Login login)
        {
            string sql = @"INSERT INTO Login (Username, Password, Status, Role, Message)
                   VALUES (@Username, @Password, @Status, @Role, @Message)";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@Username", login.Username);
            cmd.Parameters.AddWithValue("@Password", login.Password);
            cmd.Parameters.AddWithValue("@Status", login.Status);
            cmd.Parameters.AddWithValue("@Role", login.Role);
            cmd.Parameters.AddWithValue("@Message", string.IsNullOrWhiteSpace(login.Message)
                ? "Your account isn't activated yet. Contact administrator to activate."
                : login.Message);

            if (con.State == ConnectionState.Closed)
                con.Open();

            int result = cmd.ExecuteNonQuery();
            
            con.Close();
            return result;
        }

        public static int InsertAdmin(Admin admin)
        {
            string sql = @"INSERT INTO Admin (LoginID, FullName, Email)
                   VALUES (@LoginID, @FullName, @Email)";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@LoginID", admin.LoginID);
            cmd.Parameters.AddWithValue("@FullName", admin.FullName);
            cmd.Parameters.AddWithValue("@Email", admin.Email);

            if (con.State == ConnectionState.Closed)
                con.Open();

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public static int InsertVictim(Victim victim)
        {
            string sql = @"INSERT INTO Victim 
                   (LoginID, FullName, Phone, Address, VerificationStatus)
                   VALUES 
                   (@LoginID, @FullName, @Phone, @Address, @VerificationStatus)";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@LoginID", victim.LoginID);
            cmd.Parameters.AddWithValue("@FullName", victim.FullName);
            cmd.Parameters.AddWithValue("@Phone", victim.Phone);
            cmd.Parameters.AddWithValue("@Address", victim.Address);
            cmd.Parameters.AddWithValue("@VerificationStatus", victim.VerificationStatus);

            if (con.State == ConnectionState.Closed)
                con.Open();

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public static int InsertDonator(Donator donator)
        {
            string sql = @"INSERT INTO Donator (LoginID, FullName, Phone, Address)
                   VALUES (@LoginID, @FullName, @Phone, @Address)";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@LoginID", donator.LoginID);
            cmd.Parameters.AddWithValue("@FullName", donator.FullName);
            cmd.Parameters.AddWithValue("@Phone", donator.Phone);
            cmd.Parameters.AddWithValue("@Address", donator.Address);

            if (con.State == ConnectionState.Closed)
                con.Open();




            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }

        public static int InsertVolunteer(Volunteer volunteer)
        {
            string sql = @"INSERT INTO Volunteer 
                   (LoginID, FullName, Phone, VehicleType, AvailabilityStatus)
                   VALUES 
                   (@LoginID, @FullName, @Phone, @VehicleType, @AvailabilityStatus)";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@LoginID", volunteer.LoginID);
            cmd.Parameters.AddWithValue("@FullName", volunteer.FullName);
            cmd.Parameters.AddWithValue("@Phone", volunteer.Phone);
            cmd.Parameters.AddWithValue("@VehicleType", volunteer.VehicleType);
            cmd.Parameters.AddWithValue("@AvailabilityStatus", volunteer.AvailabilityStatus);

            if (con.State == ConnectionState.Closed)
                con.Open();

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public static int InsertDisasterRequest(DisasterRequest req)
        {
            string sql = @"INSERT INTO DisasterRequest
                   (VictimID, DisasterTitle, DisasterType, Description,
                    RequestedItems, NumberOfMembers, Location)
                   VALUES
                   (@VictimID, @DisasterTitle, @DisasterType, @Description,
                    @RequestedItems, @NumberOfMembers, @Location)";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@VictimID", req.VictimID);
            cmd.Parameters.AddWithValue("@DisasterTitle", req.DisasterTitle);
            cmd.Parameters.AddWithValue("@DisasterType", req.DisasterType);
            cmd.Parameters.AddWithValue("@Description", req.Description);
            cmd.Parameters.AddWithValue("@RequestedItems", req.RequestedItems);
            cmd.Parameters.AddWithValue("@NumberOfMembers", req.NumberOfMembers);
            cmd.Parameters.AddWithValue("@Location", req.Location);

            if (con.State == ConnectionState.Closed)
                con.Open();

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public static int InsertDonation(Donation donation)
        {
            string sql = @"INSERT INTO Donation
                   (DonatorID, RequestID, DonationType, ItemDetails)
                   VALUES
                   (@DonatorID, @RequestID, @DonationType, @ItemDetails)";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@DonatorID", donation.DonatorID);
            cmd.Parameters.AddWithValue("@RequestID", donation.RequestID);
            cmd.Parameters.AddWithValue("@DonationType", donation.DonationType);
            cmd.Parameters.AddWithValue("@ItemDetails", donation.ItemDetails);

            if (con.State == ConnectionState.Closed)
                con.Open();

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

        public static int InsertDelivery(Delivery delivery)
        {
            string sql = @"INSERT INTO Delivery
                   (DonationID, PickupLocation, DeliveryLocation)
                   VALUES
                   (@DonationID, @PickupLocation, @DeliveryLocation)";

            SqlCommand cmd = new SqlCommand(sql, con);

            cmd.Parameters.AddWithValue("@DonationID", delivery.DonationID);
            cmd.Parameters.AddWithValue("@PickupLocation", delivery.PickupLocation);
            cmd.Parameters.AddWithValue("@DeliveryLocation", delivery.DeliveryLocation);

            if (con.State == ConnectionState.Closed)
                con.Open();

            int result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }


        //---------------------------------------------------------------//

            
        public static SqlConnection GetConnection()
        {
            return con;
        }
        

        internal static int DeleteDisasterRequest(int requestID)
        {
            const string sql = @"DELETE FROM DisasterRequest WHERE RequestID = @RequestID";

            var cmd = new SqlCommand(sql, con);
            
            cmd.Parameters.AddWithValue("@RequestID", requestID);

            if (con.State == ConnectionState.Closed)
                con.Open();

            int affected = cmd.ExecuteNonQuery();
            con.Close();

            return affected;
        }

        public static int UpdateDisasterRequest(DisasterRequest req)
        {
            const string sql = @"UPDATE DisasterRequest SET DisasterTitle = @DisasterTitle, DisasterType = @DisasterType, Description = @Description, RequestedItems = @RequestedItems, NumberOfMembers = @NumberOfMembers, Location = @Location, RequestStatus = @RequestStatus WHERE RequestID = @RequestID";

            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@RequestID", req.RequestID);
                cmd.Parameters.AddWithValue("@DisasterTitle", req.DisasterTitle);
                cmd.Parameters.AddWithValue("@DisasterType", req.DisasterType);
                cmd.Parameters.AddWithValue("@Description", req.Description);
                cmd.Parameters.AddWithValue("@RequestedItems", req.RequestedItems);
                cmd.Parameters.AddWithValue("@NumberOfMembers", req.NumberOfMembers);
                cmd.Parameters.AddWithValue("@Location", req.Location);
                cmd.Parameters.AddWithValue("@RequestStatus", req.RequestStatus);

                if (con.State == ConnectionState.Closed)
                    con.Open();

                var affected = cmd.ExecuteNonQuery();
                con.Close();
                return affected;
            }
        }

        public static int UpdateLoginStatusAndMessage(int loginID, bool status, string message)
        {
            const string sql = @"UPDATE Login SET Status = @Status, Message = @Message WHERE LoginID = @LoginID";

            using (var cmd = new SqlCommand(sql, con))
            {
                cmd.Parameters.AddWithValue("@LoginID", loginID);
                cmd.Parameters.AddWithValue("@Status", status);
                cmd.Parameters.AddWithValue("@Message", message ?? string.Empty);

                if (con.State == ConnectionState.Closed)
                    con.Open();

                int affected = cmd.ExecuteNonQuery();
                con.Close();
                return affected;
            }
        }


    }
}
