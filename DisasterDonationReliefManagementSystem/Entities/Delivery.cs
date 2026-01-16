using System;
using System.Collections.Generic;
using System.Text;

namespace DisasterDonationReliefManagementSystem.Entities
{
    public class Delivery
    {
        public int DeliveryID { get; set; }
        public int DonationID { get; set; }
        public int? VolunteerID { get; set; }
        public string PickupLocation { get; set; }
        public string DeliveryLocation { get; set; }
        public string DeliveryStatus { get; set; }

        public Delivery(int deliveryID, int donationID, int volID, string pickupLocation, string deliveryLocation, string deliveryStatus)
        {
            DeliveryID = deliveryID;
            DonationID = donationID;
            VolunteerID = volID;
            PickupLocation = pickupLocation;
            DeliveryLocation = deliveryLocation;
            DeliveryStatus = deliveryStatus;

        }
    }
}
