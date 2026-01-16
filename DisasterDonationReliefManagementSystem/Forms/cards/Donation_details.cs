using Azure.Core;
using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DisasterDonationReliefManagementSystem.Forms.cards
{
    public partial class Donation_details : Form
    {
        private int _donationID;
        public Donation_details(int donationID)

        {

            InitializeComponent();
            _donationID = donationID;
            LoadDonationDetails();
        }




        private void LoadDonationDetails()
        {
            DonationDetailsView details = Query.GetDonationDetailsByDonationID(_donationID);


            if (details == null)
                return;


            Disastertile_bt.Text =  details.DisasterType;
            donationtype_lb.Text = "Doation Type:   " + details.DonationType;
            Itemdetails_lb.Text = "Item Details:    " + details.ItemDetails;
            deliveryLoc_lb.Text = "Delivery Locaton:    " + details.DeliveryLocation;
            pirckupLoc_lb.Text = "Pick up location:     " + details.PickupLocation;



        }
        

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Disastertile_bt_Click(object sender, EventArgs e)
        {
            DonationDetailsView details = Query.GetDonationDetailsByDonationID(_donationID);
            if (details == null) return;
            Disaster_req_card form = new Disaster_req_card(details.RequestID);
            form.ShowDialog();
        }
    }
}
