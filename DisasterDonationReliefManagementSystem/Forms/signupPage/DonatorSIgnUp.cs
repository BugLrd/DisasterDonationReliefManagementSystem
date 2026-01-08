using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Forms.signupPage
{
    public partial class DonatorSIgnUp : SignUp
    {
        private Donator? donator;

        public DonatorSIgnUp()
        {
            InitializeComponent();
        }

        protected override void signupbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string fname = FnameTb().Text.Trim();
                string lname = LnameTb().Text.Trim();
                string username = UnameTb().Text.Trim();
                string password = PassTb().Text.Trim();
                string confirmPassword = ConfirmPassTb().Text.Trim();
                string phone = phntxtbx.Text.Trim();
                string address = AddressTxtbx.Text.Trim();
                string name = fname + " " + lname;

                if (string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(name) ||
                    string.IsNullOrWhiteSpace(phone) ||
                    string.IsNullOrWhiteSpace(address))
                {
                    MessageBox.Show("Please fill in all fields.", "Missing information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate password confirmation
                if (!string.Equals(password, confirmPassword, StringComparison.Ordinal))
                {
                    MessageBox.Show("Passwords do not match.", "Validation error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Ensure username is unique
                string checkQuery = $"SELECT * FROM Login WHERE Username = '{username}'";
                List<Login> existing = Query.GetLogins(checkQuery);
                if (existing != null && existing.Count > 0)
                {
                    MessageBox.Show("Username already exists. Please choose a different username.", "Duplicate username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create login (Status=false until approval, Role=Donator)
                Login login = new Login(0, username, password, false, "Donator", "");

                int affected = Query.InsertLogin(login);
                if (affected <= 0)
                {
                    MessageBox.Show("Signup failed while creating login. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                // Create Donator profile
                Donator newDonator = new Donator(0, createdLogin.LoginID, username, false, name, phone, address, createdLogin.Message);
                int donorResult = Query.InsertDonator(newDonator);

                if (donorResult > 0)
                {
                    MessageBox.Show("Signup successful! Please wait for admin approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LogInPage l = new LogInPage();
                    l.FormClosed += (s, args) => Application.Exit();
                    l.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Donator registration failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DonatorSIgnUp_Load(object sender, EventArgs e)
        {

        }
    }
}
