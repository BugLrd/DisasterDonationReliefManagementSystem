using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views.Volunteer
{
    public partial class VolunteerHomeView : BaseDelReqView
    {
        public VolunteerHomeView(Entities.Volunteer volunteer) : base(volunteer)
        {
            InitializeComponent();
        }

        private void VolunteerHomeView_Load(object sender, EventArgs e)
        {
            ReloadRequests();            
        }

        private void ReloadRequests()
        {
            GetDelReqListPnl().Controls.Clear();
            string sql = "Select del.*, dn.DonationDate as RequestDate From Delivery as del, Donation as dn where DeliveryStatus = 'Pending' and del.DonationID = dn.DonationID";
            LoadRequests(Query.GetDeliveries(sql));

            foreach (Control c in GetDelReqListPnl().Controls)
            {
                if (c is Panel card)
                {
                    ReDecorateCard(card, (Delivery)card.Tag);
                }
            }

            GetDelReqListPnl().PerformLayout();
        }

        protected override Panel ReDecorateCard(Panel card, Delivery delivery)
        {
            var acceptBtn = new Button
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Text = "Accept Delivery",
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(card.Width - 120, 12), // position near right edge
                Size = new Size(100, 28),
                FlatStyle = FlatStyle.Standard,
                BackColor = Color.Transparent
            };
            card.Controls.Add(acceptBtn);
            card.BackColor = Color.LightYellow;
            acceptBtn.Click += (s, args) => acceptBtn_Click(delivery.DeliveryID);

            return card;
        }

        private void acceptBtn_Click(int DeliveryID)
        {
            try
            {
                string sql = $"UPDATE Delivery SET DeliveryStatus = 'Assigned', VolunteerID = {vol.VolunteerID} WHERE DeliveryID = {DeliveryID}";
                int rowsAffected = Query.UpdateDeliveryStatus(sql);
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Delivery accepted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to accept delivery. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Refresh the delivery requests list
                ReloadRequests();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to accept delivery: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
