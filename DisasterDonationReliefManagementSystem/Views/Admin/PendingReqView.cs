using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Forms;
using DisasterDonationReliefManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views.Admin
{
    public partial class PendingReqView : BaseReqView
    {
        private DisasterRequest currReq;
        public PendingReqView()
        {
            InitializeComponent();
        }

        private void AdminHomeView_Load(object sender, EventArgs e)
        {
            string select_query = "SELECT * FROM DisasterRequest WHERE RequestStatus = 'Pending'";
            List<DisasterRequest> requests = Query.GetDisasterRequests(select_query);
            LoadRequest(requests);

            foreach (Panel ReqPanel in mainReqPnl.Controls)
            {
                ReqPanel.Click += AddButtonsToDetailsPanel;
            }
        }

        private void AddButtonsToDetailsPanel(object sender, EventArgs args)
        {
            if (contentPnl == null)
                return;
            if (sender is Panel p && p.Tag is DisasterRequest req)
                currReq = req;

            Button approveBtn = new Button
            {
                Text = "Approve",
                Size = new Size(80, 30),
                Location = new Point(200, 650),
                BackColor = Color.FromArgb(40, 167, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            approveBtn.Click += ApproveBtn_Click;

            Button rejectBtn = new Button
            {
                Text = "Reject",
                Size = new Size(80, 30),
                Location = new Point(10, 650),
                BackColor = Color.FromArgb(220, 53, 69),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Anchor = AnchorStyles.Top | AnchorStyles.Left
            };
            rejectBtn.Click += RejectBtn_Click;

            contentPnl.Controls.Add(approveBtn);
            contentPnl.Controls.Add(rejectBtn);
        }

        private void ApproveBtn_Click(object sender, EventArgs e)
        {
            currReq.RequestStatus = "Approved";
            try
            {
                if (Query.UpdateDisasterRequest(currReq) > 0)
                {
                    MessageBox.Show("Request approved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the view
                    if (FindForm() is Forms.HomePage home)
                    {
                        home.ShowView(new PendingReqView());
                    }
                }
                else
                {
                    MessageBox.Show("Failed to approve the request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RejectBtn_Click(object sender, EventArgs e)
        {
            currReq.RequestStatus = "Rejected";
            try
            {
                if (Query.UpdateDisasterRequest(currReq) > 0)
                {
                    MessageBox.Show("Request rejected successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Refresh the view
                    if (FindForm() is Forms.HomePage home)
                    {
                        home.ShowView(new PendingReqView());
                    }
                }
                else
                {
                    MessageBox.Show("Failed to reject the request.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
