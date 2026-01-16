using System;
using System.Collections.Generic;
using System.Text;

namespace DisasterDonationReliefManagementSystem.Entities
{
    using System;

    public class Donation
    {
        public int DonationID { get; set; }
        public int DonatorID { get; set; }
        public int RequestID { get; set; }
        public string DonationType { get; set; }
        public string ItemDetails { get; set; }
        public DateTime DonationDate { get; set; }

        public Donation(int donationID, int donatorID, int requestID, string donationType, string itemDetails, DateTime donationDate)
        {
            DonationID = donationID;
            DonatorID = donatorID;
            RequestID = requestID;
            DonationType = donationType;
            ItemDetails = itemDetails;
            DonationDate = donationDate;
        }
    }

    public class DonationInfo
    {
        public int DonationID { get; set; }
        public int RequestID { get; set; }
        public string DisasterTitle { get; set; }
        public string VictimName { get; set; }
        public DateTime DonationDate { get; set; }
        public string DeliveryStatus { get; set; }
    }

    public class DonationDetailsView
    {
        public string DisasterType { get; set; }
        public string DonationType { get; set; }
        public int RequestID { get; set; }
        public string ItemDetails { get; set; }
        public string DeliveryLocation { get; set; }
        public string PickupLocation { get; set; }
        public string VictimName { get; set; } 
    }

    public class VictimDisasterDetails
    {
     
        public string FullName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        
        public string DisasterTitle { get; set; }
        public string DisasterType { get; set; }
        public string RequestedItems { get; set; }
        public DateTime RequestDate { get; set; }
        public string Location { get; set; }
        public int NumberOfMembers { get; set; }
    }

}
