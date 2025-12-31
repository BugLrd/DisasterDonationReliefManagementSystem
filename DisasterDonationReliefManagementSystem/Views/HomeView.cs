using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem
{
    public partial class HomeView : UserControl
    {
        // Color palette for the request panels
        private readonly Color reqNormalColor = Color.FromArgb(243, 246, 249); // #F3F6F9
        private readonly Color reqHoverColor = Color.FromArgb(232, 239, 246); // #E8EFF6
        private readonly Color titleColor = Color.FromArgb(0, 120, 215);   // #0078D7
        private readonly Color titleHoverColor = Color.FromArgb(0, 90, 158);    // #005A9E
        private readonly Color descColor = Color.FromArgb(85, 85, 85);    // #555555

        SqlConnection con = Query.GetConnection();

        private bool isDetailsPanelOpen = false;
        private Panel selectedPanel = null;

        public HomeView()
        {
            InitializeComponent();
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            string select_query = "SELECT * FROM DisasterRequest WHERE RequestStatus = 'Approved' ORDER BY RequestDate DESC";
            SqlDataAdapter sda = new SqlDataAdapter(select_query, con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            List<DisasterRequest> requests = new List<DisasterRequest>();

            foreach (DataRow row in dt.Rows)
            {
                requests.Add(new DisasterRequest
                {
                    RequestID = Convert.ToInt32(row["RequestID"]),
                    VictimID = Convert.ToInt32(row["VictimID"]),
                    DisasterTitle = row["DisasterTitle"].ToString(),
                    DisasterType = row["DisasterType"].ToString(),
                    Description = row["Description"].ToString(),
                    RequestedItems = row["RequestedItems"].ToString(),
                    NumberOfMembers = Convert.ToInt32(row["NumberOfMembers"]),
                    RequestDate = Convert.ToDateTime(row["RequestDate"]),
                    Location = row["Location"].ToString(),
                    RequestStatus = row["RequestStatus"].ToString()
                });
            }

            mainReqPnl.SuspendLayout();

            foreach (var req in requests)
            {
                // Only create panel if status is approved
                if (!req.RequestStatus.Equals("Approved", StringComparison.OrdinalIgnoreCase))
                    continue;

                // Create title label with hover effects
                Label titleLbl = new Label
                {
                    Text = req.DisasterTitle,
                    Location = new Point(15, 15),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                    ForeColor = titleColor,
                    Cursor = Cursors.Hand,
                    Tag = req.RequestID // Store request ID
                };

                // Title hover events
                titleLbl.MouseEnter += (s, ev) =>
                {
                    titleLbl.ForeColor = titleHoverColor;
                    titleLbl.Font = new Font(titleLbl.Font, FontStyle.Bold | FontStyle.Underline);
                };

                titleLbl.MouseLeave += (s, ev) =>
                {
                    titleLbl.ForeColor = titleColor;
                    titleLbl.Font = new Font(titleLbl.Font.FontFamily, titleLbl.Font.Size, FontStyle.Bold);
                };

                titleLbl.Click += Title_Click;

                // Create description label
                Label descLbl = new Label
                {
                    Text = req.Description,
                    Location = new Point(15, 45),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10F),
                    ForeColor = descColor
                };

                // Create request panel with hover effects
                Panel subReqPnl = new Panel
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(mainReqPnl.Width - 25, 86),
                    BackColor = reqNormalColor,
                    Margin = new Padding(5, 5, 5, 3),
                    Name = $"ReqPnl_{req.RequestID}",
                    Cursor = Cursors.Hand,
                    Tag = req,
                    AutoSize = false
                };

                // Panel hover events
                subReqPnl.MouseEnter += (s, ev) =>
                {
                    if (s is Panel p) p.BackColor = reqHoverColor;
                };
                subReqPnl.MouseLeave += (s, ev) =>
                {
                    if (s is Panel p && p != selectedPanel)
                        p.BackColor = reqNormalColor;
                };
                subReqPnl.Click += Panel_Click;

                // Add labels to panel
                subReqPnl.Controls.Add(titleLbl);
                subReqPnl.Controls.Add(descLbl);

                // Add panel to main container
                mainReqPnl.Controls.Add(subReqPnl);
            }

            mainReqPnl.ResumeLayout(false);
            mainReqPnl.PerformLayout();
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            if (sender is Panel panel)
            {
                selectedPanel = panel;
                panel.BackColor = reqHoverColor;
                ShowDetailsPanel(panel);
            }
        }

        private void Title_Click(object sender, EventArgs e)
        {
            if (sender is Label label)
            {
                MessageBox.Show($"You clicked on {label.Text}");
            }
        }

        private void ShowDetailsPanel(Panel selectedReqPanel)
        {
            // Toggle details panel
            if (isDetailsPanelOpen && selectedPanel == selectedReqPanel)
            {
                CloseDetailsPanel();
                return;
            }

            isDetailsPanelOpen = true;

            // Calculate dimensions
            int totalWidth = containerPnl.Width;
            int mainPnlWidth = (int)(totalWidth * 0.66); // 2/3 of total width
            int detailsWidth = totalWidth - mainPnlWidth; // 1/3 of total width

            // Resize main request panel
            mainReqPnl.Width = mainPnlWidth;

            // Resize and show details panel
            detailsPnl.Width = detailsWidth;
            detailsPnl.Visible = true;
            detailsPnl.BringToFront();

            // Populate details panel with content
            DetailsPanelUi(selectedReqPanel);
        }

        private void DetailsPanelUi(Panel reqPanel)
        {
            detailsPnl.Controls.Clear();

            DisasterRequest? req = reqPanel.Tag as DisasterRequest;

            if (req == null)
                return;

            // Create a scrollable panel for details content
            Panel contentPnl = new Panel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill,
                Padding = new Padding(10),
                Location = new Point(0, 0),
                Size = new Size(detailsPnl.Width, detailsPnl.Height)
            };

            int xPos_heading = 15; // Heading labels X position
            int xPos_info = 20; // Info labels X position
            int yPosition = 10;
            const int labelHeight = 20; // Standard label height
            const int sectionSpacing = 30; // Space between sections
            const int fieldSpacing = 10; // Space between fields

            // Close button
            Button closeBtn = new Button
            {
                Text = "✕",
                Location = new Point(detailsPnl.Width - 30, 5),
                Size = new Size(25, 25),
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.Transparent,
                ForeColor = Color.Red,
                Cursor = Cursors.Hand,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold)
            };
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.Click += (s, e) => CloseDetailsPanel();
            detailsPnl.Controls.Add(closeBtn);

            // === Main Title ===
            Label mainTitleLbl = new Label
            {
                Text = req.DisasterTitle,
                Location = new Point(10, 15),
                AutoSize = true,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = titleColor,
                MaximumSize = new Size(detailsPnl.Width - 60, 0)
            };
            contentPnl.Controls.Add(mainTitleLbl);

            yPosition = 60;
            // === Request Information Section ===
            Label requestInfoLbl = new Label
            {
                Text = "Request Information",
                Location = new Point(xPos_heading, 60),
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = titleColor
            };
            contentPnl.Controls.Add(requestInfoLbl);
            yPosition += sectionSpacing;

            // Request ID
            Label requestIdLbl = new Label
            {
                Text = $"Request ID: {req.RequestID}",
                Location = new Point(xPos_info, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = descColor
            };
            contentPnl.Controls.Add(requestIdLbl);
            yPosition += fieldSpacing + labelHeight;

            // Request Status
            Label statusLbl = new Label
            {
                Text = $"Status: {req.RequestStatus}",
                Location = new Point(xPos_info, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = descColor
            };
            contentPnl.Controls.Add(statusLbl);
            yPosition += fieldSpacing + labelHeight;

            // Request Date
            Label dateLbl = new Label
            {
                Text = $"Request Date: {req.RequestDate:dd/MM/yyyy}",
                Location = new Point(xPos_info, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = descColor
            };
            contentPnl.Controls.Add(dateLbl);
            yPosition += fieldSpacing + labelHeight;

            // === Disaster Information Section ===
            yPosition += sectionSpacing;
            Label disasterInfoLbl = new Label
            {
                Text = "Disaster Information",
                Location = new Point(xPos_heading, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = titleColor
            };
            contentPnl.Controls.Add(disasterInfoLbl);
            yPosition += sectionSpacing;

            // Disaster Type
            Label disasterTypeLbl = new Label
            {
                Text = $"Disaster Type: {req.DisasterType}",
                Location = new Point(xPos_info, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = descColor
            };
            contentPnl.Controls.Add(disasterTypeLbl);
            yPosition += fieldSpacing + labelHeight;

            // Location
            Label locationLbl = new Label
            {
                Text = $"Location: {req.Location}",
                Location = new Point(xPos_info, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = descColor,
                MaximumSize = new Size(detailsPnl.Width - 40, 0)
            };
            contentPnl.Controls.Add(locationLbl);
            yPosition += fieldSpacing + labelHeight;

            // === Description Section ===
            yPosition += sectionSpacing;
            Label descSectionLbl = new Label
            {
                Text = "Full Description",
                Location = new Point(xPos_heading, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = titleColor
            };
            contentPnl.Controls.Add(descSectionLbl);
            yPosition += sectionSpacing;

            Label descContentLbl = new Label
            {
                Text = req.Description,
                Location = new Point(xPos_info, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = descColor,
                MaximumSize = new Size(detailsPnl.Width - 40, 150)
            };
            contentPnl.Controls.Add(descContentLbl);
            yPosition += descContentLbl.Height + sectionSpacing;

            // === Requested Items Section ===
            yPosition += sectionSpacing;
            Label itemsSectionLbl = new Label
            {
                Text = "Requested Items",
                Location = new Point(xPos_heading, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = titleColor
            };
            contentPnl.Controls.Add(itemsSectionLbl);
            yPosition += sectionSpacing;

            Label itemsContentLbl = new Label
            {
                Text = req.RequestedItems,
                Location = new Point(xPos_info, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = descColor,
                MaximumSize = new Size(detailsPnl.Width - 40, 120)
            };
            contentPnl.Controls.Add(itemsContentLbl);
            yPosition += itemsContentLbl.Height + sectionSpacing;

            // === Victim Information Section ===
            yPosition += sectionSpacing;
            Label victimInfoLbl = new Label
            {
                Text = "Victim Information",
                Location = new Point(xPos_heading, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = titleColor
            };
            contentPnl.Controls.Add(victimInfoLbl);
            yPosition += sectionSpacing;

            // Victim ID
            Label victimIdLbl = new Label
            {
                Text = $"Victim ID: {req.VictimID}",
                Location = new Point(xPos_info, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = descColor
            };
            contentPnl.Controls.Add(victimIdLbl);
            yPosition += fieldSpacing + labelHeight;

            // Number of Members
            Label membersLbl = new Label
            {
                Text = $"Number of Members Affected: {req.NumberOfMembers}",
                Location = new Point(xPos_info, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = descColor
            };
            contentPnl.Controls.Add(membersLbl);
            yPosition += fieldSpacing + labelHeight;

            // Add content panel to details panel
            detailsPnl.Controls.Add(contentPnl);
        }

        private void CloseDetailsPanel()
        {
            isDetailsPanelOpen = false;
            detailsPnl.Visible = false;
            detailsPnl.Controls.Clear();

            // Restore selected panel color
            if (selectedPanel != null)
                selectedPanel.BackColor = reqNormalColor;

            selectedPanel = null;

            // Resize main request panel back to full width
            mainReqPnl.Width = containerPnl.Width;
        }
    }
}
