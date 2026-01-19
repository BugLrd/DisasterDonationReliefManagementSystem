using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views.Admin
{
    public partial class create_new_admin : UserControl
    {
        private Entities.Admin _currentAdmin;

        public create_new_admin(Entities.Admin currentAdmin)
        {
            InitializeComponent();
            _currentAdmin = currentAdmin;
        }
        private void creatadminbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string username = usernametxbx.Text.Trim();
                string password = passwordtxtbx.Text.Trim();
                string fullName = fullnametxtbox.Text.Trim();
                string email = emailtxtbx.Text.Trim();

                
                if (string.IsNullOrWhiteSpace(username) ||
                    string.IsNullOrWhiteSpace(password) ||
                    string.IsNullOrWhiteSpace(fullName) ||
                    string.IsNullOrWhiteSpace(email))
                {
                    MessageBox.Show("Please fill in all fields.", "Missing information",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    var mailAddress = new System.Net.Mail.MailAddress(email);
                    if (mailAddress.Address != email)
                    {
                        throw new FormatException();
                    }
                }
                catch
                {
                    MessageBox.Show("Please enter a valid email address.",
                        "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    emailtxtbx.Focus();
                    return ;
                }


                string checkQuery = $"SELECT * FROM Login WHERE Username = '{username}'";
                List<Login> existing = Query.GetLogins(checkQuery);

                if (existing != null && existing.Count > 0)
                {
                    MessageBox.Show("Username already exists.",
                        "Duplicate username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                Login login = new Login(
                    0,
                    username,
                    password,
                    true,           
                    "Admin",        
                    "Admin account"
                );

                int affected = Query.InsertLogin(login);

                if (affected <= 0)
                {
                    MessageBox.Show("Admin login creation failed.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                
                List<Login> createdLogins = Query.GetLogins(checkQuery);



                if (createdLogins == null || createdLogins.Count == 0)
                {
                    MessageBox.Show("Login created but could not be retrieved.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Login createdLogin = createdLogins[0];


                Entities.Admin newAdmin = new Entities.Admin(
                    0,
                    createdLogin.LoginID,
                    username,
                    true,
                    fullName,
                    email,
                    "Admin account"
                );

                int adminResult = Query.InsertAdmin(newAdmin);

                

                if (adminResult > 0)
                {
                    MessageBox.Show("Admin created successfully.",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    usernametxbx.Clear();
                    passwordtxtbx.Clear();
                    fullnametxtbox.Clear();
                    emailtxtbx.Clear();
                }
                else
                {
                    MessageBox.Show("Admin creation failed.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
