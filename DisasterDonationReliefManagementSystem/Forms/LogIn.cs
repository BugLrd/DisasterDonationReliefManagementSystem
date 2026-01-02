using DisasterDonationReliefManagementSystem.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using System;
using DisasterDonationReliefManagementSystem.Services;
using DisasterDonationReliefManagementSystem.Entities;
using System.Windows.Forms;
using Microsoft.IdentityModel.Tokens;

namespace DisasterDonationReliefManagementSystem
{
    public partial class LogInPage : Form
    {
        SqlConnection con = Query.GetConnection();
        Login login;
        public LogInPage()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string identifier = unametf.Text?.Trim() ?? string.Empty;
            string password = passtf.Text ?? string.Empty;

            if (string.IsNullOrEmpty(identifier) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username (email/phone) and password.", "Missing credentials", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string select_query = $"SELECT * FROM Login WHERE Username = '{identifier}' AND Password = '{password}'";
                List<Login> logins = Query.GetLogins(select_query);
                if (logins == null || logins.Count == 0)
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                login = logins[0];

                if (!login.Status)
                {
                    string msg = string.IsNullOrWhiteSpace(login.Message)
                        ? "Your account isn't activated yet. Contact administrator to activate."
                        : login.Message;
                    MessageBox.Show(msg, "Account inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.Equals(login.Role, "Admin", StringComparison.OrdinalIgnoreCase))
                {
                    string adminQuery = $"SELECT a.*, l.Username, l.Status FROM Admin a INNER JOIN Login l ON a.LoginID = l.LoginID and a.LoginID = '{login.LoginID}'";

                    HomePage homePage = new HomePage(Query.GetAdmins(adminQuery)[0]);
                    homePage.FormClosed += (s, args) => Application.Exit();
                    this.Hide();
                    homePage.Show();
                    return;
                }

                if (string.Equals(login.Role, "Donator", StringComparison.OrdinalIgnoreCase))
                {
                    string donorQuery = $"SELECT d.*, l.Username, l.Status FROM Donator d INNER JOIN Login l ON d.LoginID = l.LoginID and d.LoginID = '{login.LoginID}'";

                    HomePage homePage = new HomePage(Query.GetDonators(donorQuery)[0]);
                    homePage.FormClosed += (s, args) => Application.Exit();
                    this.Hide();
                    homePage.Show();
                    return;
                }

                if (string.Equals(login.Role, "Victim", StringComparison.OrdinalIgnoreCase))
                {
                    string victimQuery = $"SELECT v.*, l.Username, l.Status FROM Victim v INNER JOIN Login l ON v.LoginID = l.LoginID and v.LoginID = '{login.LoginID}'";

                    HomePage homePage = new HomePage(Query.GetVictims(victimQuery)[0]);
                    homePage.FormClosed += (s, args) => Application.Exit();
                    this.Hide();
                    homePage.Show();
                    return;
                }

                if (string.Equals(login.Role, "Volunteer", StringComparison.OrdinalIgnoreCase))
                {
                    string volQuery = $"SELECT v.*, l.Username, l.Status FROM Volunteer v INNER JOIN Login l ON v.LoginID = l.LoginID and v.LoginID = '{login.LoginID}'";

                    HomePage homePage = new HomePage(Query.GetVolunteers(volQuery)[0]);
                    homePage.FormClosed += (s, args) => Application.Exit();
                    this.Hide();
                    homePage.Show();
                    return;
                }

                MessageBox.Show("User role is not recognized. Please contact the administrator.", "Role error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"A database error occurred: {ex.Message}", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            GreetPage g = new GreetPage();
            g.FormClosed += (s, args) => Application.Exit();
            this.Hide();
            g.Show();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            s.FormClosed += (s, args) => Application.Exit();
            s.Show();
            this.Hide();

        }

        private void LogInPage_Load(object sender, EventArgs e)
        {

        }

    }
}
