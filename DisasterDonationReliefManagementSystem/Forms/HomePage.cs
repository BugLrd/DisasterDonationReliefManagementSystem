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
        public HomePage()
        {
            InitializeComponent();
            // For demonstration, creating a sample user. In a real application, this would come from login.
            _currentUser = new User(1, "John", "Doe", "johndoe@proton.me", "013345435", "uganda", "admin", "active");
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            welcomelbl.Text = $"Welcome, {_currentUser.FirstName}";
            
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

    }
}
