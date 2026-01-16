using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Forms.cards
{
    public partial class Disaster_req_card : Form
    {
        private int _requestID;

        public Disaster_req_card(int requestID)
        {
            InitializeComponent();
            _requestID = requestID;
            LoadVictimDisasterDetails();
        }

        private void LoadVictimDisasterDetails()
        {
            
            VictimDisasterDetails details = Query.GetVictimDisasterDetailsByRequestID(_requestID);

            if (details == null)
            {
                MessageBox.Show("No details found for this request.", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            
            Victimname_lb.Text ="Name:  "+ details.FullName;
            Phone_lb.Text = "Phone:    " +details.Phone;
            Address_lb.Text = "Adress:  " +details.Address;

            
            DisasterTile_lb.Text = details.DisasterTitle;
            disastertype_lb.Text = "Disaster Type:  " +details.DisasterType;
            Requestinfo_lb.Text = "Requested Items:    "+details.RequestedItems;
            date_lb.Text = "Item Requested:   "+details.RequestDate.ToShortDateString();
            Location_lb.Text = "Location:   " +details.Location;
            numbermem_lb.Text ="Number of Members:  "+ details.NumberOfMembers.ToString();
        }
    }

}
    
    
    

