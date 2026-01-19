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
    public partial class donation_card : Form
    {

        public static int victimLoginID;
        public static int donatorLoginID;
        public static int RequestID;

        public donation_card(int deliveryID)
        {
            InitializeComponent();
            LoadDonationCard(deliveryID);
        }

        private void LoadDonationCard(int deliveryID)
        {
            DataRow row = Query.GetDonationCardRow(deliveryID);
            if (row == null) return;

            Disaster_name.Text = row["DisasterName"].ToString();
            DonationType.Text = row["DonationType"].ToString();
            Iteam_details.Text = row["ItemDetails"].ToString();
            donation_date.Text = Convert.ToDateTime(row["DonationDate"]).ToShortDateString();
            DelStsUpdate.Text = row["DeliveryStatus"].ToString();

            victim_username.Text = row["VictimUsername"].ToString();
            vphone.Text = row["VictimPhone"].ToString();

            Donator_username.Text = row["DonatorUsername"].ToString();
            Donator_nunber.Text = row["DonatorPhone"].ToString();

            victimLoginID = Convert.ToInt32(row["VictimLoginID"]);
            donatorLoginID = Convert.ToInt32(row["DonatorLoginID"]);
            RequestID = Convert.ToInt32(row["DisasterRequestID"]);
        }

        private void DisasterType_Click(object sender, EventArgs e)
        {

        }



        private void DonationType_Click(object sender, EventArgs e)
        {

        }

        private void Disaster_name_Click(object sender, EventArgs e)
        {
            new disaster_request_card(RequestID).Show();
        }

        private void Donator_username_Click_1(object sender, EventArgs e)
        {
            new User_card(donatorLoginID).Show();
        }

        private void victim_username_Click_1(object sender, EventArgs e)
        {
            new User_card(victimLoginID).Show();
        }

        private void donation_card_Load(object sender, EventArgs e)
        {

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
