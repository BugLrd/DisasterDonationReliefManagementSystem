using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DisasterDonationReliefManagementSystem.Services;
using DisasterDonationReliefManagementSystem.Entities;

namespace DisasterDonationReliefManagementSystem.Views.Admin
{
    public partial class ManageUserView : UserControl
    {
        private TextBox _searchBox;
        private ComboBox _statusFilter;
        private DataGridView _usersGrid;
        private BindingSource _bindingSource;
        private DataTable _usersTable;

        public ManageUserView()
        {
            InitializeComponent();
        }

        private void ManageUserView_Load(object sender, EventArgs e)
        {
            BuildUI();
            LoadUsers();

            _searchBox.TextChanged += (_, __) => ApplyFilters();
            _statusFilter.SelectedIndexChanged += (_, __) => ApplyFilters();

            ApplyFilters();
        }

        private void BuildUI()
        {
            Controls.Clear();

            _searchBox = new TextBox
            {
                PlaceholderText = "Search by name or username...",
                Font = new Font("Segoe UI", 10F),
                Location = new Point(12, 12),
                Size = new Size(320, 27),
                Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right
            };
            Controls.Add(_searchBox);

            _statusFilter = new ComboBox
            {
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10F),
                Location = new Point(_searchBox.Right + 12, 12),
                Size = new Size(180, 27),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            _statusFilter.Items.AddRange(new object[] { "All", "Active", "Inactive" });
            _statusFilter.SelectedIndex = 0;
            Controls.Add(_statusFilter);

            _usersGrid = new DataGridView
            {
                Location = new Point(12, 52),
                Size = new Size(Width - 24, Height - 64),
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                ReadOnly = false,
                AllowUserToAddRows = false,
                AllowUserToDeleteRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode = DataGridViewSelectionMode.FullRowSelect
            };
            Controls.Add(_usersGrid);

            var toggleCol = new DataGridViewButtonColumn
            {
                Name = "Toggle",
                HeaderText = "Toggle Status",
                Text = "Toggle",
                UseColumnTextForButtonValue = true
            };
            _usersGrid.Columns.Add(toggleCol);

            var messageCol = new DataGridViewTextBoxColumn
            {
                Name = "Message",
                HeaderText = "Message/Reason"
            };
            _usersGrid.Columns.Add(messageCol);

            _usersGrid.CellClick -= UsersGrid_CellClick;
            _usersGrid.CellClick += UsersGrid_CellClick;

            _bindingSource = new BindingSource();
            _usersGrid.DataSource = _bindingSource;
        }

        private void LoadUsers()
        {
            _usersTable = new DataTable();
            _usersTable.Columns.Add("LoginID", typeof(int));
            _usersTable.Columns.Add("Role", typeof(string));
            _usersTable.Columns.Add("Username", typeof(string));
            _usersTable.Columns.Add("FullName", typeof(string));
            _usersTable.Columns.Add("Status", typeof(string)); // "Active" / "Inactive"
            _usersTable.Columns.Add("Contact", typeof(string)); // Email/Phone depending on role
            _usersTable.Columns.Add("Extra", typeof(string));   // Role-specific extra field
            _usersTable.Columns.Add("Message", typeof(string)); // Current login message

            try
            {
                // Admins
                string adminQuery = "SELECT a.*, l.Username, l.Status, l.Message FROM Admin a INNER JOIN Login l ON a.LoginID = l.LoginID";
                foreach (var a in Query.GetAdmins(adminQuery))
                {
                    // Fetch login to get the message
                    var login = Query.GetLogins($"SELECT * FROM Login WHERE LoginID = '{a.LoginID}'").FirstOrDefault();
                    _usersTable.Rows.Add(
                        a.LoginID,
                        "Admin",
                        a.Username,
                        a.FullName,
                        a.Status ? "Active" : "Inactive",
                        a.Email,
                        "",
                        login?.Message ?? ""
                    );
                }

                // Victims
                string victimQuery = "SELECT v.*, l.Username, l.Status, l.Message FROM Victim v INNER JOIN Login l ON v.LoginID = l.LoginID";
                foreach (var v in Query.GetVictims(victimQuery))
                {
                    var login = Query.GetLogins($"SELECT * FROM Login WHERE LoginID = '{v.LoginID}'").FirstOrDefault();
                    _usersTable.Rows.Add(
                        v.LoginID,
                        "Victim",
                        v.Username,
                        v.FullName,
                        v.Status ? "Active" : "Inactive",
                        v.Phone,
                        $"Verification: {v.VerificationStatus}",
                        login?.Message ?? ""
                    );
                }

                // Donators
                string donatorQuery = "SELECT d.*, l.Username, l.Status, l.Message FROM Donator d INNER JOIN Login l ON d.LoginID = l.LoginID";
                foreach (var d in Query.GetDonators(donatorQuery))
                {
                    var login = Query.GetLogins($"SELECT * FROM Login WHERE LoginID = '{d.LoginID}'").FirstOrDefault();
                    _usersTable.Rows.Add(
                        d.LoginID,
                        "Donator",
                        d.Username,
                        d.FullName,
                        d.Status ? "Active" : "Inactive",
                        d.Phone,
                        d.Address,
                        login?.Message ?? ""
                    );
                }

                // Volunteers
                string volunteerQuery = "SELECT v.*, l.Username, l.Status, l.Message FROM Volunteer v INNER JOIN Login l ON v.LoginID = l.LoginID";
                foreach (var v in Query.GetVolunteers(volunteerQuery))
                {
                    var login = Query.GetLogins($"SELECT * FROM Login WHERE LoginID = '{v.LoginID}'").FirstOrDefault();
                    _usersTable.Rows.Add(
                        v.LoginID,
                        "Volunteer",
                        v.Username,
                        v.FullName,
                        v.Status ? "Active" : "Inactive",
                        v.Phone,
                        $"Availability: {v.AvailabilityStatus}",
                        login?.Message ?? ""
                    );
                }

                _bindingSource.DataSource = _usersTable;
                ConfigureGridColumns();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigureGridColumns()
        {
            if (_usersGrid.Columns["LoginID"] != null)
                _usersGrid.Columns["LoginID"].Visible = false;
            if (_usersGrid.Columns["Role"] != null)
                _usersGrid.Columns["Role"].HeaderText = "Role";
            if (_usersGrid.Columns["Username"] != null)
                _usersGrid.Columns["Username"].HeaderText = "Username";
            if (_usersGrid.Columns["FullName"] != null)
                _usersGrid.Columns["FullName"].HeaderText = "Full Name";
            if (_usersGrid.Columns["Status"] != null)
                _usersGrid.Columns["Status"].HeaderText = "Status";
            if (_usersGrid.Columns["Contact"] != null)
                _usersGrid.Columns["Contact"].HeaderText = "Contact";
            if (_usersGrid.Columns["Extra"] != null)
                _usersGrid.Columns["Extra"].HeaderText = "Details";
            if (_usersGrid.Columns["Message"] != null)
                _usersGrid.Columns["Message"].HeaderText = "Message/Reason";
        }

        private void ApplyFilters()
        {
            string search = (_searchBox.Text ?? string.Empty).Trim().ToLowerInvariant();
            string statusFilter = _statusFilter.SelectedItem?.ToString() ?? "All";

            IEnumerable<DataRow> rows = _usersTable.AsEnumerable();

            if (statusFilter == "Active" || statusFilter == "Inactive")
            {
                rows = rows.Where(r => string.Equals(r.Field<string>("Status"), statusFilter, StringComparison.OrdinalIgnoreCase));
            }

            if (!string.IsNullOrEmpty(search))
            {
                rows = rows.Where(r =>
                    (r.Field<string>("FullName") ?? string.Empty).ToLowerInvariant().Contains(search) ||
                    (r.Field<string>("Username") ?? string.Empty).ToLowerInvariant().Contains(search));
            }

            DataView view = rows.Any() ? rows.CopyToDataTable().DefaultView : _usersTable.Clone().DefaultView;
            _bindingSource.DataSource = view;
        }

        private void UsersGrid_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var grid = (DataGridView)sender!;
            if (grid.Columns[e.ColumnIndex].Name != "Toggle") return;

            var row = grid.Rows[e.RowIndex];
            int loginID = Convert.ToInt32(row.Cells["LoginID"].Value);
            string currentStatus = row.Cells["Status"].Value?.ToString() ?? "Inactive";
            bool makeActive = string.Equals(currentStatus, "Inactive", StringComparison.OrdinalIgnoreCase);

            string message = row.Cells["Message"].Value?.ToString() ?? string.Empty;

            if (!makeActive)
            {
                // making inactive requires a reason message
                using (var prompt = new Form
                {
                    Text = "Reason to make user inactive",
                    StartPosition = FormStartPosition.CenterParent,
                    Width = 480,
                    Height = 180,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                })
                {
                    var lbl = new Label { Text = "Reason:", Left = 10, Top = 15, Width = 60 };
                    var tb = new TextBox { Left = 80, Top = 12, Width = 370, Text = message };
                    var ok = new Button { Text = "OK", Left = 290, Top = 60, Width = 75, DialogResult = DialogResult.OK };
                    var cancel = new Button { Text = "Cancel", Left = 375, Top = 60, Width = 75, DialogResult = DialogResult.Cancel };

                    prompt.Controls.Add(lbl);
                    prompt.Controls.Add(tb);
                    prompt.Controls.Add(ok);
                    prompt.Controls.Add(cancel);
                    prompt.AcceptButton = ok;
                    prompt.CancelButton = cancel;

                    if (prompt.ShowDialog(FindForm()) != DialogResult.OK)
                        return;

                    message = tb.Text?.Trim() ?? string.Empty;
                    if (string.IsNullOrWhiteSpace(message))
                    {
                        MessageBox.Show("Please provide a reason to make the user inactive.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            else
            {
                // restoring to active resets message to empty
                message = string.Empty;
            }

            try
            {
                int affected = Query.UpdateLoginStatusAndMessage(loginID, makeActive, makeActive ? "" : message);
                if (affected > 0)
                {
                    // Update UI row
                    row.Cells["Status"].Value = makeActive ? "Active" : "Inactive";
                    row.Cells["Message"].Value = makeActive ? "" : message;
                    MessageBox.Show($"User has been {(makeActive ? "activated" : "made inactive")}.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No changes were made. Please try again.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to update status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
