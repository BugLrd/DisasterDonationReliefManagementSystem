using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Views;
using DisasterDonationReliefManagementSystem.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Forms
{
    public partial class HomePage : Form
    {
        private List<Button> sidepnlButtons;
        private User _currentUser;
        public HomePage(User user)
        {
            InitializeComponent();
            _currentUser = user;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            welcomelbl.Text = $"Welcome, {_currentUser.FullName.Split(" ")[0]}";

            // Initialize the list of side panel buttons
            sidepnlButtons = new List<Button>
            {
                homebtn,
                urReqBtn,
                cReqBtn,
                mngUsrsBtn,
                mngReqBtn,
                adminBtn,
                donateBtn,
                donHistBtn,
                currDelBtn,
                delHistBtn
            };
            ApplyRoleBasedUI();

            // set sidebar colors and button foreground for good contrast
            sideBarPnl.BackColor = Color.FromArgb(43, 47, 51); // #2B2F33
            var sidebarText = Color.White;
            var sidebarHoverText = Color.Black;

            foreach (Control c in sideBarPnl.Controls)
            {
                if (c is Button btn)
                {
                    // base color
                    btn.ForeColor = sidebarText;

                    // ensure hand cursor
                    btn.Cursor = Cursors.Hand;

                    // remove possible existing handlers to avoid duplicates if Load is invoked again
                    btn.MouseEnter -= SideBarButton_MouseEnter;
                    btn.MouseLeave -= SideBarButton_MouseLeave;

                    // attach handlers that toggle text color on hover
                    btn.MouseEnter += SideBarButton_MouseEnter;
                    btn.MouseLeave += SideBarButton_MouseLeave;

                    // local copy for restore color inside static handlers
                    btn.Tag = new ButtonColorTag { Normal = sidebarText, Hover = sidebarHoverText };
                }
            }
        }

        // centralized hover handlers to avoid capturing outer variables in many lambdas
        private void SideBarButton_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is Button b && b.Tag is ButtonColorTag tag)
            {
                b.ForeColor = tag.Hover;
            }
        }

        private void SideBarButton_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Button b && b.Tag is ButtonColorTag tag)
            {
                b.ForeColor = tag.Normal;
            }
        }

        // small helper to store colors per-button (avoids closures)
        private class ButtonColorTag
        {
            public Color Normal { get; set; }
            public Color Hover { get; set; }
        }

        private void ApplyRoleBasedUI()
        {
            // Hide all buttons initially
            foreach (var btn in sidepnlButtons)
                btn.Visible = false;

            // Home button is visible to all users
            homebtn.Visible = true;

            // Show buttons based on user role
            switch (_currentUser.Role.ToLower())
            {
                case "admin":
                    mngUsrsBtn.Visible = true;
                    mngReqBtn.Visible = true;
                    adminBtn.Visible = true;
                    ShowView(new AdminHomeView());
                    break;

                case "victim":
                    urReqBtn.Visible = true;
                    cReqBtn.Visible = true;
                    ShowView(new VictimHomeView());
                    break;

                case "donator":
                    donateBtn.Visible = true;
                    donHistBtn.Visible = true;
                    break;

                case "volunteer":
                    currDelBtn.Visible = true;
                    delHistBtn.Visible = true;
                    break;
            }
        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LogInPage loginPage = new LogInPage();
            loginPage.FormClosed += (s, args) => Application.Exit();
            loginPage.Show();
            this.Hide();
        }

        private void homebtn_Click(object sender, EventArgs e)
        {
            if (_currentUser.Role.ToLower() == "admin")
                ShowView(new AdminHomeView());
            if (_currentUser.Role.ToLower() == "victim")
                ShowView(new VictimHomeView());
            //if (_currentUser.Role == "donator")
            //    ShowView(new DonatorHomeView());
            

        }

        public void ShowView(UserControl view)
        {
            mainpnl.Controls.Clear();       // remove current view
            view.Dock = DockStyle.Fill;     // fill the panel
            mainpnl.Controls.Add(view);     // add new view
        }

        private void cReqBtn_Click(object sender, EventArgs e)
        {
            if (_currentUser is Victim victim)
            {
                ShowView(new create_req_view(victim));
            }
            else
            {
                MessageBox.Show("Current user is not a Victim. Cannot show your requests.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void urReqBtn_Click(object sender, EventArgs e)
        {
            if (_currentUser is Victim victim)
            {
                ShowView(new YourRequestsView(victim));
            }
            else
            {
                MessageBox.Show("Current user is not a Victim. Cannot show your requests.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
