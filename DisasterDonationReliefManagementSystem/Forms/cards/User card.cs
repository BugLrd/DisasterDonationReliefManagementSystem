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
    public partial class User_card : Form
    {
        
        public User_card(int LoginID)
        {
            InitializeComponent();
            
            LoadUserCard(LoginID);
        }


        private void LoadUserCard(int LoginID)
        {
            DataRow row = Query.GetUserCardInfo(LoginID);
            if (row == null) return;

            string role = row["Role"].ToString();

            Xusername.Text = row["Username"].ToString();
            
            Xstatus.Text = (bool)row["Status"] ? "Active" : "Inactive";
            xRole.Text = role;

            if (role == "Victim")
            {
                Xfullname.Text = row["VictimFullName"].ToString();
                Xphone.Text = row["VictimPhone"].ToString();
                label6.Text = "Address";
                label7.Text = row["VictimAddress"].ToString();
            }
            else if (role == "Donator")
            {
                Xfullname.Text = row["DonatorFullName"].ToString();
                Xphone.Text = row["DonatorPhone"].ToString();
                label6.Text = "Address";
                label7.Text = row["DonatorAddress"].ToString();
            }
            else if (role == "Volunteer")
            {
                Xfullname.Text = row["VolunteerFullName"].ToString();
                Xphone.Text = row["VolunteerPhone"].ToString();
                label6.Text = "Vehicle Type";
                label7.Text = row["VehicleType"].ToString();
            }

            usercard.Text = $"{role} Card";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
