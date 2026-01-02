using System;
using System.Collections.Generic;
using System.Text;

namespace DisasterDonationReliefManagementSystem.Entities
{
    public class Login
    {
        public int LoginID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
        public bool Status { get; set; }
        public string Message { get; set; }

        public Login(int loginID, string username, string password, bool status, string role, string message)
        {
            LoginID = loginID;
            Username = username;
            Password = password;
            Status = status;
            Role = role;
            Message = message;
        }
    }
}
