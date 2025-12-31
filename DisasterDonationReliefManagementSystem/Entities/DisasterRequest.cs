using System;
using System.Collections.Generic;
using System.Text;

namespace DisasterDonationReliefManagementSystem.Entities
{
    using System;

    public class DisasterRequest
    {
        public int RequestID { get; set; }
        public int VictimID { get; set; }
        public string DisasterTitle { get; set; }
        public string DisasterType { get; set; }
        public string Description { get; set; }
        public string RequestedItems { get; set; }
        public int NumberOfMembers { get; set; }
        public DateTime RequestDate { get; set; }
        public string Location { get; set; }
        public string RequestStatus { get; set; }

        public DisasterRequest(int requestID, int victimID, string disasterTitle, string disasterType, string description, string requestedItems, int numberOfMembers, DateTime requestDate, string location, string requestStatus)
        {
            RequestID = requestID;
            VictimID = victimID;
            DisasterTitle = disasterTitle;
            DisasterType = disasterType;
            Description = description;
            RequestedItems = requestedItems;
            NumberOfMembers = numberOfMembers;
            RequestDate = requestDate;
            Location = location;
            RequestStatus = requestStatus;
        }
    }

}
