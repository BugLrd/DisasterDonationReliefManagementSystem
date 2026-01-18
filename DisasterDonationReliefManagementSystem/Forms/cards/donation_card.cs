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
            VolunterUpdate.Text = row["VolunteerStatus"].ToString();

            victim_username.Text = row["VictimUsername"].ToString();
            vphone.Text = row["VictimPhone"].ToString();

            Donator_username.Text = row["DonatorUsername"].ToString();
            Donator_nunber.Text = row["DonatorPhone"].ToString();
        }

        private void DisasterType_Click(object sender, EventArgs e)
        {

        }

        private void Donator_username_Click(object sender, EventArgs e)
        {

        }
    }
}
