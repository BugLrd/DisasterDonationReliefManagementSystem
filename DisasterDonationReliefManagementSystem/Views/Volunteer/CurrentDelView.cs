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
    public partial class CurrentDelView : BaseDelReqView
    {
        public CurrentDelView(Entities.Volunteer volunteer) : base(volunteer)
        {
            InitializeComponent();
        }

        private void CurrentDelView_Load(object sender, EventArgs e)
        {
             ReloadRequests();
        }

        private void ReloadRequests()
        {
            GetDelReqListPnl().Controls.Clear();
            string sql = $"SELECT del.*, dn.DonationDate as RequestDate FROM Delivery as del, Donation as dn WHERE del.DonationID = dn.DonationID AND VolunteerID = {vol.VolunteerID} AND (DeliveryStatus = 'Assigned' or DeliveryStatus = 'In Transit')";
            LoadRequests(Query.GetDeliveries(sql));

            foreach (Control ctrl in GetDelReqListPnl().Controls)
            {
                if (ctrl is Panel card)
                {
                    ReDecorateCard(card, card.Tag as Delivery);
                }
            }
        }

        protected override Panel ReDecorateCard(Panel card, Delivery delivery)
        {
            // Set background based on status
            switch (delivery?.DeliveryStatus)
            {
                case "Assigned":
                    card.BackColor = Color.LightBlue;
                    break;
                case "In Transit":
                    card.BackColor = Color.LightGreen;
                    break;
                default:
                    card.BackColor = Color.LightYellow;
                    break;
            }

            var statusBox = new ComboBox
            {
                Location = new Point(card.Width - 150, 15),
                Width = 100,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Items = { "Assigned", "In Transit", "Delivered" },
                SelectedItem = delivery.DeliveryStatus
            };

            statusBox.SelectedIndexChanged += (s, e) =>
            {
                string newStatus = statusBox.SelectedItem.ToString();
                if (newStatus != delivery.DeliveryStatus)
                {
                    if (newStatus == "Delivered")
                    {
                        var confirmResult = MessageBox.Show("Are you sure you want to mark this delivery as Delivered?", "Confirm Delivery", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (confirmResult != DialogResult.Yes)
                        {
                            // Revert selection
                            statusBox.SelectedItem = delivery.DeliveryStatus;
                            return;
                        }

                    }

                    // Update status in database
                    string updateSql = $"UPDATE Delivery SET DeliveryStatus = '{newStatus}' WHERE DeliveryID = {delivery.DeliveryID}";
                    if (Query.UpdateDeliveryStatus(updateSql) > 0)
                    {
                        MessageBox.Show("Delivery status updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to update delivery status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Refresh the view
                    ReloadRequests();
                }
            };
            card.Controls.Add(statusBox);

            var cancelBtn = new Button
            {
                Text = "X",
                Location = new Point(card.Width - 50, 14),
                Size = new Size(25, 25),
                BackColor = Color.Red,
                Cursor = Cursors.Hand,
                FlatStyle = FlatStyle.Flat,

            };
            cancelBtn.Click += (s, args) =>
            {
                var confirmResult = MessageBox.Show("Are you sure you want to cancel this delivery?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (confirmResult == DialogResult.Yes)
                {
                    // Update status in database
                    string updateSql = $"UPDATE Delivery SET VolunteerID = NULL, DeliveryStatus = 'Pending' WHERE DeliveryID = {delivery.DeliveryID}";
                    if (Query.UpdateDeliveryStatus(updateSql) > 0)
                    {
                        MessageBox.Show("Delivery cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel delivery.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    // Refresh the view
                    ReloadRequests();
                }
            };
            card.Controls.Add(cancelBtn);

            return card;
        }
    }
}
