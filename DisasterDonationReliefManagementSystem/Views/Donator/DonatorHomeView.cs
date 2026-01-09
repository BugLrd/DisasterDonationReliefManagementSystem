using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views.Donator
{
    public partial class DonatorHomeView : BaseReqView
    {
        private DisasterRequest? _currentReq;
        private Entities.Donator _donator;

        public DonatorHomeView(Entities.Donator donator)
        {
            InitializeComponent();
            _donator = donator;
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            string select_query = "SELECT * FROM DisasterRequest WHERE RequestStatus = 'Approved' ORDER BY RequestDate DESC";
            List<DisasterRequest> disasterRequests = Query.GetDisasterRequests(select_query);
            if (disasterRequests == null || disasterRequests.Count == 0)
            {
                containerPnl.Controls.Clear();
                Label noReqLbl = new Label
                {
                    Text = "There is no disaster requests yet.",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Location = new Point((containerPnl.Width) / 2 - 170, containerPnl.Height / 2 - 15)
                };
                containerPnl.Controls.Add(noReqLbl);
                return;
            }
            SetRequests(disasterRequests);

            foreach (Panel ReqPnl in mainReqPnl.Controls)
            {
                ReqPnl.Click += AddButtonsToPanel;
            }
        }

        private void AddButtonsToPanel(object? sender, EventArgs e)
        {
            // Track which request was clicked
            if (sender is Panel p && p.Tag is DisasterRequest req)
                _currentReq = req;

            if (contentPnl == null)
                return;

            // Prevent duplicate button creation
            foreach (Control c in contentPnl.Controls)
            {
                if (c is Button b && string.Equals(b.Text, "Donate", StringComparison.OrdinalIgnoreCase))
                    return;
            }

            var donateBtn = new Button
            {
                Text = "Donate",
                Size = new Size(300, 32),
                Location = new Point(0, 650),
                BackColor = Color.Green,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            donateBtn.Click += donateBtn_Click;
            contentPnl.Controls.Add(donateBtn);
        }

        private void donateBtn_Click(object? sender, EventArgs e)
        {
            if (_currentReq == null)
            {
                MessageBox.Show("No request selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Build donation form
            Form dlg = new Form
            {
                Text = "Make a Donation",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MinimizeBox = false,
                MaximizeBox = false,
                ClientSize = new Size(520, 360),
                BackColor = Color.White
            };

            int labelX = 20;
            int inputX = 190;
            int y = 20;
            int dy = 36;

            // Donation Type
            dlg.Controls.Add(new Label { Text = "Donation Type", Location = new Point(labelX, y + 4), AutoSize = true, Font = new Font("Segoe UI", 10F) });
            var cbType = new ComboBox
            {
                Location = new Point(inputX, y),
                Width = 300,
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10F)
            };
            cbType.Items.AddRange(new object[] { "Money", "Clothes", "Food", "Medicine", "Other" });
            cbType.SelectedIndex = 0;
            dlg.Controls.Add(cbType);
            y += dy;

            // Amount (for Money)
            var lblAmount = new Label { Text = "Amount", Location = new Point(labelX, y + 4), AutoSize = true, Font = new Font("Segoe UI", 10F), Visible = true };
            var tbAmount = new TextBox { Location = new Point(inputX, y), Width = 300, Font = new Font("Segoe UI", 10F), PlaceholderText = "Enter amount (e.g., 100.00)", Visible = true };
            dlg.Controls.Add(lblAmount);
            dlg.Controls.Add(tbAmount);
            y += dy;

            // Item Details (for non-money)
            var lblDetails = new Label { Text = "Item Details", Location = new Point(labelX, y + 4), AutoSize = true, Font = new Font("Segoe UI", 10F), Visible = false };
            var tbDetails = new TextBox { Location = new Point(inputX, y - 2), Width = 300, Height = 60, Multiline = true, Font = new Font("Segoe UI", 10F), Visible = false, PlaceholderText = "Describe items (e.g., winter jackets, canned food)" };
            dlg.Controls.Add(lblDetails);
            dlg.Controls.Add(tbDetails);
            y += 64;

            // Volunteer checkbox
            var cbVolunteer = new CheckBox
            {
                Text = "Need Volunteer Pickup?",
                Location = new Point(inputX, y + 4),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F)
            };
            dlg.Controls.Add(new Label { Text = "Volunteer", Location = new Point(labelX, y + 6), AutoSize = true, Font = new Font("Segoe UI", 10F) });
            dlg.Controls.Add(cbVolunteer);
            y += dy;

            // Pickup Location (visible only when volunteer is needed)
            var lblPickup = new Label { Text = "Pickup Location", Location = new Point(labelX, y + 4), AutoSize = true, Font = new Font("Segoe UI", 10F), Visible = false };
            var tbPickup = new TextBox { Location = new Point(inputX, y), Width = 300, Font = new Font("Segoe UI", 10F), Visible = false, PlaceholderText = "Enter pickup address" };
            dlg.Controls.Add(lblPickup);
            dlg.Controls.Add(tbPickup);
            y += dy + 4;

            // Buttons
            var btnOk = new Button { Text = "Submit", Location = new Point(inputX, y), Size = new Size(100, 30) };
            var btnCancel = new Button { Text = "Cancel", Location = new Point(inputX + 110, y), Size = new Size(100, 30) };
            dlg.Controls.Add(btnOk);
            dlg.Controls.Add(btnCancel);
            dlg.AcceptButton = btnOk;
            dlg.CancelButton = btnCancel;

            // Toggle controls based on donation type            
            cbType.SelectedIndexChanged += (s, ev) =>
            {
                bool isMoney = string.Equals(cbType.SelectedItem?.ToString(), "Money", StringComparison.OrdinalIgnoreCase);
                lblAmount.Visible = tbAmount.Visible = isMoney;
                lblDetails.Visible = tbDetails.Visible = !isMoney;
            };

            // Toggle pickup location visibility
            cbVolunteer.CheckedChanged += (s, ev) =>
            {
                bool showPickup = cbVolunteer.Checked;
                lblPickup.Visible = showPickup;
                tbPickup.Visible = showPickup;
            };

            btnCancel.Click += (s, ev) => dlg.DialogResult = DialogResult.Cancel;

            btnOk.Click += (s, ev) =>
            {
                string donationType = cbType.SelectedItem?.ToString() ?? "Money";
                string itemDetails;

                if (string.Equals(donationType, "Money", StringComparison.OrdinalIgnoreCase))
                {
                    if (string.IsNullOrWhiteSpace(tbAmount.Text))
                    {
                        MessageBox.Show("Please enter the amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    if (!decimal.TryParse(tbAmount.Text, out var amount) || amount <= 0)
                    {
                        MessageBox.Show("Please enter a valid amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    itemDetails = $"Amount: {amount:0.##}";
                }
                else
                {
                    if (string.IsNullOrWhiteSpace(tbDetails.Text))
                    {
                        MessageBox.Show("Please describe the items.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    itemDetails = $"Items: {tbDetails.Text.Trim()}";
                }

                string pickupLocation = string.Empty;
                if (cbVolunteer.Checked)
                {
                    if (string.IsNullOrWhiteSpace(tbPickup.Text))
                    {
                        MessageBox.Show("Please enter pickup location.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    pickupLocation = tbPickup.Text.Trim();
                }

                var donation = new Donation(0, _donator.DonatorID, _currentReq.RequestID, donationType, itemDetails, DateTime.Now, "Pending");

                try
                {
                    if (Query.InsertDonation(donation) > 0)
                    {
                        // Success
                    }
                    else
                    {
                        MessageBox.Show("Failed to submit donation.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error submitting donation: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (cbVolunteer.Checked && donation != null) {
                    List<Donation> donations = Query.GetDonations($"SELECT * FROM Donation WHERE DonatorID = {_donator.DonatorID} AND RequestID = {_currentReq.RequestID} ORDER BY DonationDate");
                    var delivery = new Delivery(0, donations[0].DonationID, 0, pickupLocation, _currentReq.Location, "Pending");
                    try                     {
                        if (Query.InsertDelivery(delivery) > 0)
                        {
                            MessageBox.Show("Delivery request created successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Failed to create delivery request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error creating delivery request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                dlg.DialogResult = DialogResult.OK;
                dlg.Close();
            };

            dlg.ShowDialog(this);
        }
    }
}
