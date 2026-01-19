using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Forms.cards;
using DisasterDonationReliefManagementSystem.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views
{
    public partial class BaseReqView : UserControl
    {
        // Color palette for the request panels
        private readonly Color reqNormalColor = Color.FromArgb(243, 246, 249); // #F3F6F9
        private readonly Color reqHoverColor = Color.FromArgb(232, 239, 246); // #E8EFF6
        private readonly Color titleColor = Color.FromArgb(0, 120, 215);       // #0078D7
        private readonly Color titleHoverColor = Color.FromArgb(0, 90, 158);   // #005A9E
        private readonly Color descColor = Color.FromArgb(85, 85, 85);         // #555555

        public bool isDetailsPanelOpen = false;
        private Panel selectedPanel = null;

        public Panel subReqPnl, contentPnl; 
        public Button closeBtn;

        // Data and events
        private List<DisasterRequest> _allRequests = new List<DisasterRequest>();
        private EventHandler _searchChangedHandler;
        private EventHandler _filterChangedHandler;

        public BaseReqView()
        {
            InitializeComponent();

            // Subscribe to search/filter events ONCE
            _searchChangedHandler = (s, e) => ApplyFilters();
            _filterChangedHandler = (s, e) => ApplyFilters();

            // These controls are created by the designer
            if (searchBox != null) searchBox.TextChanged += _searchChangedHandler;
            if (filter != null) filter.SelectedIndexChanged += _filterChangedHandler;
        }

        private void BaseReqView_Load(object sender, EventArgs e)
        {
        }

        // Public entry to set/refresh the data source
        public void SetRequests(List<DisasterRequest> requests)
        {
            _allRequests = requests ?? new List<DisasterRequest>();
            ApplyFilters();
        }

        // Kept for compatibility if existing callers use this name/signature
        public void LoadRequest(IEnumerable<DisasterRequest> requests)
        {
            SetRequests(requests?.ToList() ?? new List<DisasterRequest>());
        }

        // Apply current UI filters and redraw
        public void ApplyFilters()
        {
            string search = (searchBox?.Text ?? string.Empty).Trim();
            string statusFilter = filter?.SelectedItem?.ToString() ?? "All";

            IEnumerable<DisasterRequest> q = _allRequests;

            // Optional: interpret sorting values if your ComboBox uses them
            if (string.Equals(statusFilter, "Most Recent", StringComparison.OrdinalIgnoreCase))
            {
                q = q.OrderByDescending(r => r.RequestDate);
                statusFilter = "All"; // treat as no status filter after sorting
            }
            else if (string.Equals(statusFilter, "Oldest", StringComparison.OrdinalIgnoreCase))
            {
                q = q.OrderBy(r => r.RequestDate);
                statusFilter = "All";
            }

            // Status filter (only if not "All")
            if (!string.Equals(statusFilter, "All", StringComparison.OrdinalIgnoreCase))
            {
                q = q.Where(r => string.Equals(r.RequestStatus, statusFilter, StringComparison.OrdinalIgnoreCase));
            }

            // Text search across selected fields
            if (!string.IsNullOrEmpty(search))
            {
                q = q.Where(u =>
                    (!string.IsNullOrEmpty(u.DisasterTitle) && u.DisasterTitle.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0) ||
                    (!string.IsNullOrEmpty(u.Description) && u.Description.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0));
            }

            // Rebuild UI: clear previous, then add filtered ones
            CloseDetailsPanel();
            mainReqPnl.SuspendLayout();
            mainReqPnl.Controls.Clear();

            foreach (var req in q)
            {
                var panel = CreateRequestPanel(req);
                mainReqPnl.Controls.Add(panel);
            }

            mainReqPnl.ResumeLayout(false);
            mainReqPnl.PerformLayout();
        }

        private Panel CreateRequestPanel(DisasterRequest req)
        {
            // Title label (local variable to avoid closure issues on fields)
            var titleLbl = new Label
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

            // Description label
            var descLbl = new Label
            {
                Text = req.Description,
                Location = new Point(15, 45),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = descColor
            };

            // Request panel
            subReqPnl = new Panel
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

            return subReqPnl;
        }

        public void Panel_Click(object sender, EventArgs e)
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

            DisasterRequest req = reqPanel.Tag as DisasterRequest;

            if (req == null)
                return;

            // Create a scrollable panel for details content
            contentPnl = new Panel
            {
                AutoScroll = true,
                Dock = DockStyle.Fill,
                Padding = new Padding(10),
                Location = new Point(0, 0),
                Size = new Size(detailsPnl.Width, detailsPnl.Height)
            };

            int xPos_heading = 15; // Heading labels X position
            int xPos_info = 20; // Info labels X position
            int yPosition = 15;
            const int labelHeight = 20; // Standard label height
            const int sectionSpacing = 30; // Space between sections
            const int fieldSpacing = 10; // Space between fields

            // Close button
            closeBtn = new Button
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
                Location = new Point(10, yPosition),
                AutoSize = true,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = titleColor,
                MaximumSize = new Size(detailsPnl.Width - 60, 0)
            };
            contentPnl.Controls.Add(mainTitleLbl);

            yPosition += 40;
            // === Request Information Section ===
            Label requestInfoLbl = new Label
            {
                Text = "Request Information",
                Location = new Point(xPos_heading, yPosition),
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
                Font = new Font("Segoe UI", 10F),
                Location = new Point(xPos_info, yPosition),
                AutoSize = true,
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
                Font = new Font("Segoe UI", 10F, FontStyle.Underline | FontStyle.Italic),
                ForeColor = descColor,
                Cursor = Cursors.Hand
            };
            victimIdLbl.Click += (s, e) =>
            {
                new User_card(req.VictimID).ShowDialog();
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

        public virtual void CloseDetailsPanel()
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

        private void mainReqPnl_Paint(object sender, PaintEventArgs e)
        {
        }

        private void containerPnl_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
