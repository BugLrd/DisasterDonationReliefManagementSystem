using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Forms.signupPage
{
    public partial class VolunteerSignUp : Form
    {
        public VolunteerSignUp()
        {
            InitializeComponent();
        }

        private void confirmPasstb_TextChanged(object sender, EventArgs e)
        {

        }

        private void passtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void signupbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fullName = flname.Text.Trim();
                string username = unametb.Text.Trim();
                string password = passtb.Text.Trim();
                string confirmPassword = confirmPasstb.Text.Trim();
                string phone = phntb.Text.Trim();
                string vehicle = vehicleType.Text.Trim();
                string availability = "Available"; 

                if (string.IsNullOrWhiteSpace(fullName) ||
                    string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(confirmPassword) ||
                    string.IsNullOrWhiteSpace(phone) ||
                    string.IsNullOrWhiteSpace(vehicle))
                {
                    MessageBox.Show(
                        "Please fill in all fields.",
                        "Missing Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                if (!password.Equals(confirmPassword))
                {
                    MessageBox.Show(
                        "Passwords do not match.",
                        "Validation Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // Check username uniqueness
                string checkQuery = $"SELECT * FROM Login WHERE Username = '{username}'";
                List<Login> existing = Query.GetLogins(checkQuery);

                if (existing != null && existing.Count > 0)
                {
                    MessageBox.Show(
                        "Username already exists.",
                        "Duplicate Username",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return;
                }

                // Create login (Volunteer, inactive until approval)
                Login login = new Login(0, username, password, false, "Volunteer", "");
                int loginResult = Query.InsertLogin(login);

                if (loginResult <= 0)
                {
                    MessageBox.Show(
                        "Failed to create login.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                // Get LoginID
                List<Login> createdLogins = Query.GetLogins(checkQuery);
                if (createdLogins == null || createdLogins.Count == 0)
                {
                    MessageBox.Show(
                        "Login created but could not be retrieved.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                int loginId = createdLogins[0].LoginID;

                // Create Volunteer profile
                Volunteer newVolunteer = new Volunteer(
                    0,
                    loginId,
                    username,
                    false,
                    fullName,
                    phone,
                    vehicle,
                    availability,
                    ""
                );

                int result = Query.InsertVolunteer(newVolunteer);

                if (result > 0)
                {
                    MessageBox.Show(
                        "Signup successful! Please wait for admin approval.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    LogInPage l = new LogInPage();
                    l.FormClosed += (s, args) => Application.Exit();
                    l.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show(
                        "Volunteer registration failed.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            LogInPage l = new LogInPage();
            l.FormClosed += (s, args) => Application.Exit();
            l.Show();
            this.Hide();
        }
    }
}

