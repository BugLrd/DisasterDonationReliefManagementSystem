using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DisasterDonationReliefManagementSystem.Services;
using DisasterDonationReliefManagementSystem.Entities;

namespace DisasterDonationReliefManagementSystem.Forms
{
    public partial class VictimSignUp : SignUp
    {
        public VictimSignUp()
        {
            InitializeComponent();
        }

        private void VictimSignUp_Load(object sender, EventArgs e)
        {

        }
        
        protected override void signupbtn_Click(object sender, EventArgs e)
        {
            string firstName = fnametb.Text?.Trim() ?? string.Empty;
            string lastName = lnametb.Text?.Trim() ?? string.Empty;
            string phone = phonetb.Text?.Trim() ?? string.Empty;
            string address = addresstb.Text?.Trim() ?? string.Empty;
            string username = unametb.Text?.Trim() ?? string.Empty;
            string password = passtb.Text ?? string.Empty;
            string confirmPassword = confirmPasstb.Text ?? string.Empty;

            // Basic validation
            if (string.IsNullOrEmpty(firstName) ||
                string.IsNullOrEmpty(lastName) ||
                string.IsNullOrEmpty(phone) ||
                string.IsNullOrEmpty(address) ||
                string.IsNullOrEmpty(username) ||
                string.IsNullOrEmpty(password) ||
                string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Please fill in all fields.", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!string.Equals(password, confirmPassword, StringComparison.Ordinal))
            {
                MessageBox.Show("Passwords do not match.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Ensure username uniqueness
                string checkQuery = $"SELECT * FROM Login WHERE Username = '{username}'";
                List<Login> existing = Query.GetLogins(checkQuery);
                if (existing != null && existing.Count > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create Login (Status=false until verification, Role=Victim)
                var login = new Login(loginID: 0, username: username, password: password, status: false, role: "Victim", "");
                int loginInserted = Query.InsertLogin(login);
                if (loginInserted <= 0)
                {
                    MessageBox.Show("Failed to create login record.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Fetch created Login to get LoginID
                List<Login> createdLogins = Query.GetLogins(checkQuery);
                if (createdLogins == null || createdLogins.Count == 0)
                {
                    MessageBox.Show("Login record created but could not be retrieved.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Login createdLogin = createdLogins[0];

                // Create Victim profile
                string fullName = $"{firstName} {lastName}";
                var victim = new Victim(
                    victimID: 0,
                    loginID: createdLogin.LoginID,
                    username: createdLogin.Username,
                    status: createdLogin.Status,
                    fullName: fullName,
                    phone: phone,
                    address: address,
                    verificationStatus: "Pending"
                );

                int victimInserted = Query.InsertVictim(victim);
                if (victimInserted <= 0)
                {
                    MessageBox.Show("Failed to create victim profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                MessageBox.Show("Sign up successful! Your account is pending verification.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Navigate back to login
                LogInPage l = new LogInPage();
                l.FormClosed += (s, args) => Application.Exit();
                l.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while signing up: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
