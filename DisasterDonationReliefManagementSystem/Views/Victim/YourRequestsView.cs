using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views
{
    public partial class YourRequestsView : BaseReqView
    {
        Victim victim;
        private DisasterRequest currReq;

        Button editBtn, deleteBtn;
        public YourRequestsView(Victim victim)
        {
            InitializeComponent();
            this.victim = victim;
        }

        private void YourRequestsView_Load(object sender, EventArgs e)
        {
            string select_query = $"SELECT * FROM DisasterRequest WHERE VictimID = {victim.VictimID} ORDER BY RequestDate DESC";
            List<DisasterRequest> disasterRequests = Query.GetDisasterRequests(select_query);
            if (disasterRequests == null || disasterRequests.Count == 0)
            {
                containerPnl.Controls.Clear();
                Label noReqLbl = new Label
                {
                    Text = "You have not made any disaster requests yet.",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Location = new Point((containerPnl.Width) / 2 - 170, containerPnl.Height / 2 - 15)
                };
                containerPnl.Controls.Add(noReqLbl);
                return;
            }
            LoadRequest(disasterRequests);

            foreach (Panel ReqPnl in mainReqPnl.Controls)
            {
                // Get the request from the panel's Tag
                var req = ReqPnl.Tag as DisasterRequest;
                if (req == null) continue;

                // Normalize status and choose color
                string status = req.RequestStatus.Trim();
                Color statusColor;
                switch (status.ToLowerInvariant())
                {
                    case "pending":
                        statusColor = Color.DarkOrange;
                        break;
                    case "approved":
                        statusColor = Color.SeaGreen;
                        break;
                    case "completed":
                        statusColor = Color.SteelBlue;
                        break;
                    case "rejected":
                        statusColor = Color.Firebrick;
                        break;
                    default:
                        statusColor = Color.DarkBlue;
                        break;
                }

                // Add status label to the request panel
                var statusLbl = new Label
                {
                    Text = status,
                    AutoSize = true,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    ForeColor = statusColor,
                    Location = new Point(780, 35)
                };
                ReqPnl.Controls.Add(statusLbl);

                // Keep currReq in sync when the panel is clicked and add action buttons
                ReqPnl.Click += AddButtonsToDetailsPanel;
            }
        }

        private void AddButtonsToDetailsPanel(object sender, EventArgs args)
        {
            if (contentPnl == null)
                return;

            // Track the currently selected request from the clicked panel
            if (sender is Panel p && p.Tag is DisasterRequest req)
                currReq = req;

            editBtn = new Button
            {
                Text = "Edit",
                Size = new Size(80, 30),
                Location = new Point(10, 650),
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            editBtn.Click += EditBtn_Click;

            deleteBtn = new Button
            {
                Text = "Delete",
                Size = new Size(80, 30),
                Location = new Point(220, 650),
                BackColor = Color.Firebrick,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            deleteBtn.Click += DeleteBtn_Click;

            contentPnl.Controls.Add(editBtn);
            contentPnl.Controls.Add(deleteBtn);
        }


        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (currReq == null)
            {
                MessageBox.Show("No request selected.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ------------------ Create dialog ------------------
            Form dlg = new Form
            {
                Text = "Edit Disaster Request",
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MinimizeBox = false,
                MaximizeBox = false,
                ClientSize = new Size(500, 420)
            };

            int labelX = 20;
            int inputX = 160;
            int y = 20;
            int dy = 35;

            // Title
            dlg.Controls.Add(new Label { Text = "Title", Location = new Point(labelX, y), AutoSize = true });
            TextBox tbTitle = new TextBox
            {
                Location = new Point(inputX, y - 3),
                Width = 300,
                Text = currReq.DisasterTitle
            };
            dlg.Controls.Add(tbTitle);
            y += dy;

            // Type
            dlg.Controls.Add(new Label { Text = "Type", Location = new Point(labelX, y), AutoSize = true });
            TextBox tbType = new TextBox
            {
                Location = new Point(inputX, y - 3),
                Width = 300,
                Text = currReq.DisasterType
            };
            dlg.Controls.Add(tbType);
            y += dy;

            // Description
            dlg.Controls.Add(new Label { Text = "Description", Location = new Point(labelX, y), AutoSize = true });
            TextBox tbDesc = new TextBox
            {
                Location = new Point(inputX, y - 3),
                Width = 300,
                Height = 60,
                Multiline = true,
                Text = currReq.Description
            };
            dlg.Controls.Add(tbDesc);
            y += 70;

            // Requested Items
            dlg.Controls.Add(new Label { Text = "Requested Items", Location = new Point(labelX, y), AutoSize = true });
            TextBox tbItems = new TextBox
            {
                Location = new Point(inputX, y - 3),
                Width = 300,
                Height = 60,
                Multiline = true,
                Text = currReq.RequestedItems
            };
            dlg.Controls.Add(tbItems);
            y += 70;

            // Members
            dlg.Controls.Add(new Label { Text = "Members", Location = new Point(labelX, y), AutoSize = true });
            TextBox tbMembers = new TextBox
            {
                Location = new Point(inputX, y - 3),
                Width = 100,
                Text = currReq.NumberOfMembers.ToString()
            };
            dlg.Controls.Add(tbMembers);
            y += dy;

            // Location
            dlg.Controls.Add(new Label { Text = "Location", Location = new Point(labelX, y), AutoSize = true });
            TextBox tbLocation = new TextBox
            {
                Location = new Point(inputX, y - 3),
                Width = 300,
                Text = currReq.Location
            };
            dlg.Controls.Add(tbLocation);
            y += dy;

            // Status
            dlg.Controls.Add(new Label { Text = "Status", Location = new Point(labelX, y), AutoSize = true });
            ComboBox cbStatus = new ComboBox
            {
                Location = new Point(inputX, y - 3),
                Width = 150,
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            if (currReq.RequestStatus.Equals("Approved", StringComparison.OrdinalIgnoreCase))
            {
                cbStatus.Items.AddRange(new[] { "Approved", "Completed" });
                cbStatus.SelectedItem = "Approved";
            }
            else
            {
                cbStatus.Items.Add("Pending");
                cbStatus.SelectedItem = "Pending";
            }

            dlg.Controls.Add(cbStatus);
            y += dy + 10;

            // Buttons
            Button btnSave = new Button
            {
                Text = "Save",
                DialogResult = DialogResult.OK,
                Location = new Point(inputX, y),
                Size = new Size(100, 30)
            };

            Button btnCancel = new Button
            {
                Text = "Cancel",
                DialogResult = DialogResult.Cancel,
                Location = new Point(inputX + 110, y),
                Size = new Size(100, 30)
            };

            dlg.Controls.Add(btnSave);
            dlg.Controls.Add(btnCancel);

            // save for Enter, cancel for Esc
            dlg.AcceptButton = btnSave;
            dlg.CancelButton = btnCancel;


            // cancel clicked
            if (dlg.ShowDialog(this) != DialogResult.OK)
            {
                dlg.Dispose();
                return;
            }

            // save clicked
            // check if number of members input is valid
            if (!int.TryParse(tbMembers.Text,out int members) || members <= 0)
            {
                MessageBox.Show("Please enter a valid number of members.",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dlg.Dispose();
                return;
            }

            // gather updated data
            currReq.DisasterTitle = tbTitle.Text.Trim();
            currReq.DisasterType = tbType.Text.Trim();
            currReq.Description = tbDesc.Text.Trim();
            currReq.RequestedItems = tbItems.Text.Trim();
            currReq.NumberOfMembers = members;
            currReq.Location = tbLocation.Text.Trim();

            string chosenStatus = cbStatus.SelectedItem?.ToString();

            if (currReq.RequestStatus.Equals("Approved", StringComparison.OrdinalIgnoreCase))
                currReq.RequestStatus = chosenStatus == "Completed" ? "Completed" : "Approved";
            else
                currReq.RequestStatus = "Pending";

            // run update query
            try
            {
                if (Query.UpdateDisasterRequest(currReq) > 0)
                {
                    MessageBox.Show("Request updated successfully.",
                        "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (FindForm() is Forms.HomePage home)
                        home.ShowView(new YourRequestsView(victim));
                }
                else
                {
                    MessageBox.Show("Update failed. Please try again.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating request:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                dlg.Dispose();
            }
        }


        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (currReq == null)
            {
                MessageBox.Show("No request selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var confirm = MessageBox.Show(
                $"Are you sure you want to delete request ID {currReq.RequestID}?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm != DialogResult.Yes)
                return;

            try
            {
                // Delete from database via Query service (expects an int return: rows affected)
                int affected = Query.DeleteDisasterRequest(currReq.RequestID);

                if (affected > 0)
                {
                    MessageBox.Show("Request deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Reload the entire YourRequestsView to refresh UI
                    Form parentForm = FindForm();
                    if (parentForm is Forms.HomePage homePage)
                    {
                        homePage.ShowView(new YourRequestsView(victim));
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("Delete failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while deleting the request: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
