using System;
using System.Collections.Generic;
using System.Text;

namespace DisasterDonationReliefManagementSystem.Entities
{
    public class Delivery
    {
        public int DeliveryID { get; set; }
        public int DonationID { get; set; }
        public int UserID { get; set; }
        public string PickupLocation { get; set; }
        public string DeliveryLocation { get; set; }
        public string DeliveryStatus { get; set; }
    }

}
