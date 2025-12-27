using DisasterDonationReliefManagementSystem.Forms;
using Microsoft.Data.SqlClient;
using System.Data;
using System;
using DisasterDonationReliefManagementSystem.Services;
using DisasterDonationReliefManagementSystem.Entities;
using System.Windows.Forms;

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
                // Authenticate against Login table (kept string+con style as requested)
                string select_query = $"SELECT * FROM Login WHERE Username = '{identifier}' AND Password = '{password}'";
                SqlDataAdapter sda = new SqlDataAdapter(select_query, con);

                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DataRow row = dt.Rows[0];

                // Retrieve login details safely
                int loginId = row.Table.Columns.Contains("LoginID") && row["LoginID"] != DBNull.Value ? Convert.ToInt32(row["LoginID"]) : 0;
                string username = row.Table.Columns.Contains("Username") ? row["Username"]?.ToString() ?? string.Empty : string.Empty;
                string passwordFromDb = row.Table.Columns.Contains("Password") ? row["Password"]?.ToString() ?? string.Empty : string.Empty;
                bool status = row.Table.Columns.Contains("Status") && row["Status"] != DBNull.Value ? Convert.ToBoolean(row["Status"]) : false;
                string role = row.Table.Columns.Contains("Role") ? row["Role"]?.ToString()?.Trim() ?? string.Empty : string.Empty;

                // Create Login object
                login = new Login(loginId, username, passwordFromDb, status, role);

                // Check account status
                if (!login.Status)
                {
                    MessageBox.Show("Account is inactive. Please contact the administrator.", "Account inactive", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Admin
                if (string.Equals(login.Role, "Admin", StringComparison.OrdinalIgnoreCase))
                {
                    string adminQuery = $"SELECT * FROM Admin WHERE LoginID = '{login.LoginID}'";
                    sda = new SqlDataAdapter(adminQuery, con);
                    DataTable adminDt = new DataTable();
                    sda.Fill(adminDt);

                    if (adminDt.Rows.Count == 0)
                    {
                        MessageBox.Show("Admin record not found. Contact administrator.", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DataRow adminRow = adminDt.Rows[0];
                    int adminID = adminRow.Table.Columns.Contains("AdminID") && adminRow["AdminID"] != DBNull.Value ? Convert.ToInt32(adminRow["AdminID"]) : 0;
                    string fullName = adminRow.Table.Columns.Contains("FullName") ? adminRow["FullName"]?.ToString() ?? username : username;
                    string email = adminRow.Table.Columns.Contains("Email") ? adminRow["Email"]?.ToString() ?? string.Empty : string.Empty;

                    Admin adminUser = new Admin(adminID, login.LoginID, username, status, fullName, email);

                    HomePage homePage = new HomePage(adminUser);
                    homePage.FormClosed += (s, args) => Application.Exit();
                    this.Hide();
                    homePage.Show();
                    return;
                }

                // Donator / Donor
                if (string.Equals(login.Role, "Donator", StringComparison.OrdinalIgnoreCase))
                {
                    string donorQuery = $"SELECT * FROM Donator WHERE LoginID = '{login.LoginID}'";
                    sda = new SqlDataAdapter(donorQuery, con);
                    DataTable donorDt = new DataTable();
                    sda.Fill(donorDt);

                    if (donorDt.Rows.Count == 0)
                    {
                        MessageBox.Show("Donator record not found. Contact administrator.", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DataRow donorRow = donorDt.Rows[0];
                    int donatorID = donorRow.Table.Columns.Contains("DonatorID") && donorRow["DonatorID"] != DBNull.Value ? Convert.ToInt32(donorRow["DonatorID"]) : 0;
                    string donorFullName = donorRow.Table.Columns.Contains("FullName") ? donorRow["FullName"]?.ToString() ?? username : username;
                    string donorPhone = donorRow.Table.Columns.Contains("Phone") ? donorRow["Phone"]?.ToString() ?? string.Empty : string.Empty;
                    string donorAddress = donorRow.Table.Columns.Contains("Address") ? donorRow["Address"]?.ToString() ?? string.Empty : string.Empty;

                    Donator donatorUser = new Donator(donatorID, login.LoginID, username, status, donorFullName, donorPhone, donorAddress);

                    HomePage homePage = new HomePage(donatorUser);
                    homePage.FormClosed += (s, args) => Application.Exit();
                    this.Hide();
                    homePage.Show();
                    return;
                }

                // Victim / Recipient
                if (string.Equals(login.Role, "Victim", StringComparison.OrdinalIgnoreCase))
                {
                    string victimQuery = $"SELECT * FROM Victim WHERE LoginID = '{login.LoginID}'";
                    sda = new SqlDataAdapter(victimQuery, con);
                    DataTable victimDt = new DataTable();
                    sda.Fill(victimDt);

                    if (victimDt.Rows.Count == 0)
                    {
                        MessageBox.Show("Recipient record not found. Contact administrator.", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DataRow victimRow = victimDt.Rows[0];
                    int victimID = victimRow.Table.Columns.Contains("VictimID") && victimRow["VictimID"] != DBNull.Value ? Convert.ToInt32(victimRow["VictimID"]) : 0;
                    string victimFullName = victimRow.Table.Columns.Contains("FullName") ? victimRow["FullName"]?.ToString() ?? username : username;
                    string victimPhone = victimRow.Table.Columns.Contains("Phone") ? victimRow["Phone"]?.ToString() ?? string.Empty : string.Empty;
                    string victimAddress = victimRow.Table.Columns.Contains("Address") ? victimRow["Address"]?.ToString() ?? string.Empty : string.Empty;
                    string verificationStatus = victimRow.Table.Columns.Contains("VerificationStatus") ? victimRow["VerificationStatus"]?.ToString() ?? string.Empty : string.Empty;

                    Victim victimUser = new Victim(victimID, login.LoginID, username, status, victimFullName, victimPhone, victimAddress, verificationStatus);

                    HomePage homePage = new HomePage(victimUser);
                    homePage.FormClosed += (s, args) => Application.Exit();
                    this.Hide();
                    homePage.Show();
                    return;
                }

                // Volunteer
                if (string.Equals(login.Role, "Volunteer", StringComparison.OrdinalIgnoreCase))
                {
                    string volQuery = $"SELECT * FROM Volunteer WHERE LoginID = '{login.LoginID}'";
                    sda = new SqlDataAdapter(volQuery, con);
                    DataTable volDt = new DataTable();
                    sda.Fill(volDt);

                    if (volDt.Rows.Count == 0)
                    {
                        MessageBox.Show("Volunteer record not found. Contact administrator.", "Data error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    DataRow volRow = volDt.Rows[0];
                    int volunteerID = volRow.Table.Columns.Contains("VolunteerID") && volRow["VolunteerID"] != DBNull.Value ? Convert.ToInt32(volRow["VolunteerID"]) : 0;
                    string volFullName = volRow.Table.Columns.Contains("FullName") ? volRow["FullName"]?.ToString() ?? username : username;
                    string volPhone = volRow.Table.Columns.Contains("Phone") ? volRow["Phone"]?.ToString() ?? string.Empty : string.Empty;
                    string vehicleType = volRow.Table.Columns.Contains("VehicleType") ? volRow["VehicleType"]?.ToString() ?? string.Empty : string.Empty;
                    string availabilityStatus = volRow.Table.Columns.Contains("AvailabilityStatus") ? volRow["AvailabilityStatus"]?.ToString() ?? string.Empty : string.Empty;

                    Volunteer volunteerUser = new Volunteer(volunteerID, login.LoginID, username, status, volFullName, volPhone, vehicleType, availabilityStatus);

                    HomePage homePage = new HomePage(volunteerUser);
                    homePage.FormClosed += (s, args) => Application.Exit();
                    this.Hide();
                    homePage.Show();
                    return;
                }

                // Unrecognized role
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
