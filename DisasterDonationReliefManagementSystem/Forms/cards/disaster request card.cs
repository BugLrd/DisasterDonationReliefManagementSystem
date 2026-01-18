using Azure.Core;
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
    public partial class disaster_request_card : Form
    {
        public disaster_request_card(int RequestID)
        {
            InitializeComponent();
            LoadDisasterRequest(RequestID);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new User_card(1);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void LoadDisasterRequest(int requestID)
        {
            DataRow row = Query.GetDisasterRequestInfo(requestID);
            if (row == null)
            {
                MessageBox.Show("Disaster request not found.");
                return;
            }

            disastertile.Text = row["DisasterTitle"].ToString();
            disastertype.Text = row["DisasterType"].ToString();
            victimname.Text = row["VictimFullName"].ToString();
            reqiteam.Text = row["RequestedItems"].ToString();
            numberofmem.Text = row["NumberOfMembers"].ToString();
            requestedDate.Text = Convert.ToDateTime(row["RequestDate"]).ToShortDateString();
            Location.Text = row["Location"].ToString();
            reqsatus.Text = row["RequestStatus"].ToString();
            description.Text = row["Description"].ToString();
        }
    }
}
