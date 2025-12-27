using DisasterDonationReliefManagementSystem.Entities;
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
                    break;

                case "victim":
                    urReqBtn.Visible = true;
                    cReqBtn.Visible = true;
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

        private void mainpnl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void logoutbtn_Click(object sender, EventArgs e)
        {
            LogInPage loginPage = new LogInPage();
            loginPage.FormClosed += (s, args) => Application.Exit();
            loginPage.Show();
            this.Hide();
        }
    }
}
