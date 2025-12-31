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
        public string DonationStatus { get; set; }

        public Donation(int donationID, int donatorID, int requestID, string donationType, string itemDetails, DateTime donationDate, string donationStatus)
        {
            DonationID = donationID;
            DonatorID = donatorID;
            RequestID = requestID;
            DonationType = donationType;
            ItemDetails = itemDetails;
            DonationDate = donationDate;
            DonationStatus = donationStatus;
        }
    }

}
