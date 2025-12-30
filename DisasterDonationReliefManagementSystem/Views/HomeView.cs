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
        private const string ReqNormalColorHex = "F3F6F9";    // Light blue-gray
        private const string ReqHoverColorHex = "E8EFF6";     // Slightly darker blue-gray
        private const string TitleColorHex = "0078D7";        // Microsoft blue
        private const string TitleHoverColorHex = "005A9E";   // Darker blue on hover
        private const string DescColorHex = "555555";         // Dark gray

        private Color reqNormalColor;
        private Color reqHoverColor;
        private Color titleColor;
        private Color titleHoverColor;
        private Color descColor;

        private bool isDetailsPanelOpen = false;
        private Panel selectedPanel = null;

        public HomeView()
        {
            InitializeComponent();
            InitializeColors();
        }

        private void InitializeColors()
        {
            reqNormalColor = ColorTranslator.FromHtml("#" + ReqNormalColorHex);
            reqHoverColor = ColorTranslator.FromHtml("#" + ReqHoverColorHex);
            titleColor = ColorTranslator.FromHtml("#" + TitleColorHex);
            titleHoverColor = ColorTranslator.FromHtml("#" + TitleHoverColorHex);
            descColor = ColorTranslator.FromHtml("#" + DescColorHex);
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            mainReqPnl.SuspendLayout();

            for (int i = 0; i < 20; i++)
            {
                // Create title label with hover effects
                Label titleLbl = new Label
                {
                    Text = $"Request Title {i + 1}",
                    Location = new Point(15, 15),
                    AutoSize = true,
                    Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                    ForeColor = titleColor,
                    Cursor = Cursors.Hand,
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
                    Text = $"This is the description for request {i + 1}.",
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
                    Name = $"ReqPnl_{i + 1}",
                    Cursor = Cursors.Hand,
                    Tag = i + 1, // Store request ID
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
            PopulateDetailsPanel(selectedReqPanel);
        }

        private void PopulateDetailsPanel(Panel reqPanel)
        {
            detailsPnl.Controls.Clear();

            // Extract data from selected panel
            string requestId = reqPanel.Tag?.ToString() ?? "Unknown";
            string title = "Unknown";
            string description = "Unknown";

            foreach (Control ctrl in reqPanel.Controls)
            {
                if (ctrl is Label lbl && ctrl.Location.Y == 15)
                    title = lbl.Text;
                else if (ctrl is Label lbl2 && ctrl.Location.Y == 45)
                    description = lbl2.Text;
            }

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

            // Title label
            Label detailsTitleLbl = new Label
            {
                Text = title,
                Location = new Point(15, 15),
                AutoSize = true,
                Font = new Font("Segoe UI", 16F, FontStyle.Bold),
                ForeColor = titleColor,
                MaximumSize = new Size(detailsPnl.Width - 40, 0)
            };

            // Request ID label
            Label idLbl = new Label
            {
                Text = $"Request ID: {requestId}",
                Location = new Point(15, 60),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = descColor
            };

            // Description label
            Label detailsDescLbl = new Label
            {
                Text = "Full Description:",
                Location = new Point(15, 90),
                AutoSize = true,
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = descColor
            };

            // Description content
            Label descContentLbl = new Label
            {
                Text = description + "\n\nThis is a detailed view of the selected request.",
                Location = new Point(15, 120),
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = descColor,
                MaximumSize = new Size(detailsPnl.Width - 40, 300)
            };

            // Add controls to details panel
            detailsPnl.Controls.Add(closeBtn);
            detailsPnl.Controls.Add(detailsTitleLbl);
            detailsPnl.Controls.Add(idLbl);
            detailsPnl.Controls.Add(detailsDescLbl);
            detailsPnl.Controls.Add(descContentLbl);
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

        private void mainReqPnl_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
