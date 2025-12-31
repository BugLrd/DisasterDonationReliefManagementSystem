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
    }

}
