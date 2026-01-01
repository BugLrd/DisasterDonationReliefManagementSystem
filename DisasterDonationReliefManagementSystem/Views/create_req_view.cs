using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views
{
    public partial class create_req_view : UserControl
    {
        Victim currVictim;
        public create_req_view(Victim victim)
        {
            InitializeComponent();
            this.currVictim = victim;
        }

        private void DisasterType_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RequestedItems_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void ADDbutton_Click(object sender, EventArgs e)
        {
            DisastertypeCombox.Items.Add(DisastertypeCombox.Text);

        }

        private void DisasterTitle_Click(object sender, EventArgs e)
        {

        }

        private void create_req_view_Load(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input fields before creating the request
                if (string.IsNullOrWhiteSpace(DisasterTitleTB.Text))
                {
                    MessageBox.Show("Please enter a disaster title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (DisastertypeCombox.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select a disaster type.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(DescriptionTB.Text))
                {
                    MessageBox.Show("Please enter a description.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(RequestedItemsTB.Text))
                {
                    MessageBox.Show("Please enter requested items.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(NumberOfMembersTB.Text, out int numberOfMembers) || numberOfMembers <= 0)
                {
                    MessageBox.Show("Please enter a valid number of members.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(LocationTB.Text))
                {
                    MessageBox.Show("Please enter a location.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DisasterRequest req = new DisasterRequest(
                    0,
                    currVictim.VictimID,
                    DisasterTitleTB.Text,
                    DisastertypeCombox.Text,
                    DescriptionTB.Text,
                    RequestedItemsTB.Text,
                    numberOfMembers,
                    DateTime.Now,
                    LocationTB.Text,
                    "Pending"
                );

                int result = Query.InsertDisasterRequest(req);

                if (result > 0)
                {
                    MessageBox.Show("Disaster Request Created Successfully!");

                    // Clear all textboxes
                    DisasterTitleTB.Clear();
                    DisastertypeCombox.SelectedIndex = -1;
                    DescriptionTB.Clear();
                    RequestedItemsTB.Clear();
                    NumberOfMembersTB.Clear();
                    LocationTB.Clear();

                    // Navigate to YourRequestsView
                    Form parentForm = this.FindForm();
                    if (parentForm is Forms.HomePage homePage)
                    {
                        homePage.ShowView(new YourRequestsView(currVictim));
                    }
                }
                else
                {
                    MessageBox.Show("Failed to create disaster request. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
