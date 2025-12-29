using System;

namespace DisasterDonationReliefManagementSystem.Entities
{
    public abstract class User
    {
        public int LoginID { get; set; }
        public string Username { get; set; }
        public string Role { get; protected set; }
        public bool Status { get; set; }
        public string FullName { get; set; }

        protected User(int loginID, string username, string role, bool status, string fullName)
        {
            LoginID = loginID;
            Username = username;
            Role = role;
            Status = status;
            FullName = fullName;
        }

        public abstract void LoadDashboard();
    }

    public class Admin : User
    {
        public int AdminID { get; set; }
        public string Email { get; set; }

        public Admin(int adminID, int loginID, string username, bool status, string fullName, string email) : base(loginID, username, "Admin", status, fullName)
        {
            AdminID = adminID;
            Email = email;
        }

        public override void LoadDashboard() { }

        public void ApproveRequest(int requestId) { }
        public void RejectRequest(int requestId) { }
        public void CreateAdmin(Admin admin) { }
    }

    public class Victim : User
    {
        public int VictimID { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string VerificationStatus { get; set; }

        public Victim(int victimID, int loginID, string username, bool status, string fullName, string phone, string address, string verificationStatus) : base(loginID, username, "Victim", status, fullName)
        {
            VictimID = victimID;
            Phone = phone;
            Address = address;
            VerificationStatus = verificationStatus;
        }

        public override void LoadDashboard() { }

        public void CreateRequest() { }
        public void EditRequest(int requestId) { }
        public void CancelRequest(int requestId) { }
    }

    public class Donator : User
    {
        public int DonatorID { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public Donator(int donatorID, int loginID, string username, bool status, string fullName, string phone, string address) : base(loginID, username, "Donator", status, fullName)
        {
            DonatorID = donatorID;
            Phone = phone;
            Address = address;
        }

        public override void LoadDashboard() { }

        public void MakeDonation(int requestId) { }
        public void ViewDonationHistory() { }
    }

    public class Volunteer : User
    {
        public int VolunteerID { get; set; }
        public string Phone { get; set; }
        public string VehicleType { get; set; }
        public string AvailabilityStatus { get; set; }

        public Volunteer(int volunteerID, int loginID, string username, bool status, string fullName, string phone, string vehicleType, string availabilityStatus) : base(loginID, username, "Volunteer", status, fullName)
        {
            VolunteerID = volunteerID;
            Phone = phone;
            VehicleType = vehicleType;
            AvailabilityStatus = availabilityStatus;
        }

        public override void LoadDashboard() { }

        public void AcceptDelivery(int deliveryId) { }
        public void UpdateDeliveryStatus(int deliveryId, string status) { }
    }
}
