using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Views;
using DisasterDonationReliefManagementSystem.Views.Admin;
using DisasterDonationReliefManagementSystem.Views.Donator;
using DisasterDonationReliefManagementSystem.Views.Victim;
using DisasterDonationReliefManagementSystem.Views.Volunteer;
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

        // Track active (pressed) button
        private Button? activeBtn;

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
                penReqBtn,
                adminBtn,
                donationsBtn,
                donHistBtn,
                currDelBtn,
                delHistBtn
            };
            ApplyRoleBasedUI();

            foreach (Control c in sideBarPnl.Controls)
            {
                if (c is Button btn)
                {
                    // remove existing handlers (if any) to avoid duplicates
                    btn.MouseEnter -= SideBarButton_MouseEnter;
                    btn.MouseLeave -= SideBarButton_MouseLeave;
                    btn.Click -= SideBarButton_ClickHighlight;

                    // attach handlers
                    btn.MouseEnter += SideBarButton_MouseEnter;
                    btn.MouseLeave += SideBarButton_MouseLeave;
                    btn.Click += SideBarButton_ClickHighlight;
                }
            }

            // Default active button highlight
            if (homebtn.Visible)
            {
                HighlightActiveButton(homebtn);
            }
        }

        // centralized hover handlers (no Tag usage; hard-coded colors)
        private void SideBarButton_MouseEnter(object? sender, EventArgs e)
        {
            if (sender is Button b)
            {
                // On hover, text should be black regardless of active state
                b.ForeColor = Color.Black;
            }
        }

        private void SideBarButton_MouseLeave(object? sender, EventArgs e)
        {
            if (sender is Button b)
            {
                // Active stays black; others revert to white
                b.ForeColor = activeBtn == b ? Color.Black : Color.White;
            }
        }

        // generic click handler to highlight the clicked button
        private void SideBarButton_ClickHighlight(object? sender, EventArgs e)
        {
            if (sender is Button btn)
            {
                HighlightActiveButton(btn);
            }
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
                    penReqBtn.Visible = true;
                    ShowView(new HomeView());
                    break;

                case "victim":
                    urReqBtn.Visible = true;
                    cReqBtn.Visible = true;
                    donationsBtn.Visible = true;
                    ShowView(new VictimHomeView());
                    break;

                case "donator":
                    donHistBtn.Visible = true;
                    ShowView(new DonatorHomeView(_currentUser as Donator));
                    break;

                case "volunteer":
                    currDelBtn.Visible = true;
                    delHistBtn.Visible = true;
                    ShowView(new VolunteerHomeView(_currentUser as Volunteer));
                    break;
            }
        }

        private void HighlightActiveButton(Button btn)
        {
            // reset all buttons to sidebar scheme
            foreach (var b in sidepnlButtons)
            {
                b.BackColor = Color.Transparent;
                b.ForeColor = Color.White;
            }

            // make pressed button BG white and FG black
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            activeBtn = btn;
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
                ShowView(new HomeView());
            if (_currentUser.Role.ToLower() == "victim")
                ShowView(new VictimHomeView());
            if (_currentUser.Role.ToLower() == "donator")
                ShowView(new DonatorHomeView(_currentUser as Donator));
            if (_currentUser is Volunteer v)
                ShowView(new VolunteerHomeView(v));
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

        private void mngUsrsBtn_Click(object sender, EventArgs e)
        {
            ShowView(new ManageUserView());
        }

        private void mainpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void mngReqBtn_Click(object sender, EventArgs e)
        {
            ShowView(new ManageReqView());
        }

        private void penReqBtn_Click(object sender, EventArgs e)
        {
            ShowView(new PendingReqView());
        }

        private void donHistBtn_Click(object sender, EventArgs e)
        {
            ShowView(new DonationHistoryView(_currentUser as Donator));
        }

        private void currDelBtn_Click(object sender, EventArgs e)
        {
            ShowView(new CurrentDelView(_currentUser as Volunteer));
        }

        private void delHistBtn_Click(object sender, EventArgs e)
        {
            ShowView(new DelHistView(_currentUser as Volunteer));
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            ShowView(new create_new_admin(_currentUser as Admin));
        private void donationsBtn_Click(object sender, EventArgs e)
        {
            ShowView(new DonationsView(_currentUser as Victim));
        }
    }
}
