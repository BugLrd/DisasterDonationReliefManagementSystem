using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DisasterDonationReliefManagementSystem.Views.Admin
{
    public partial class ManageUserView : UserControl
    {
        private readonly List<UserItem> _users = new List<UserItem>();

        private class UserItem
        {
            public int LoginID { get; set; }
            public string FullName { get; set; } = string.Empty;
            public string Username { get; set; } = string.Empty;
            public string Role { get; set; } = string.Empty; // Admin, Victim, Donator, Volunteer
            public bool Status { get; set; } // true = Active
            public string Contact { get; set; } = string.Empty;
            public string Extra { get; set; } = string.Empty;
            public string Message { get; set; } = string.Empty;

            public object this[int index]
            {
                get
                {
                    return index switch
                    {
                        0 => LoginID,
                        1 => FullName,
                        2 => Username,
                        3 => Role,
                        4 => Contact,
                        5 => Extra,
                        6 => Message,
                        7 => Status,
                        _ => throw new IndexOutOfRangeException()
                    };
                }

                set {                     switch (index)
                    {
                        case 0:
                            LoginID = (int)value;
                            break;
                        case 1:
                            FullName = (string)value;
                            break;
                        case 2:
                            Username = (string)value;
                            break;
                        case 3:
                            Role = (string)value;
                            break;
                        case 4:
                            Contact = (string)value;
                            break;
                        case 5:
                            Extra = (string)value;
                            break;
                        case 6:
                            Message = (string)value;
                            break;
                        case 7:
                            Status = (bool)value;
                            break;
                        default:
                            throw new IndexOutOfRangeException();
                    }
                }
            }
        }

        public ManageUserView()
        {
            InitializeComponent();
        }

        private void ManageUserView_Load(object sender, EventArgs e)
        {
            searchBox.TextChanged -= OnFilterChanged;
            searchBox.TextChanged += OnFilterChanged;

            filter.SelectedIndexChanged -= OnFilterChanged;
            filter.SelectedIndexChanged += OnFilterChanged;

            roleFilter.SelectedIndexChanged -= OnFilterChanged;
            roleFilter.SelectedIndexChanged += OnFilterChanged;

            if (filter.Items.Count == 0)
                filter.Items.AddRange(new object[] { "All", "Active", "Inactive" });
            if (filter.SelectedIndex < 0) filter.SelectedIndex = 0;

            if (roleFilter.Items.Count == 0)
                roleFilter.Items.AddRange(new object[] { "All", "Admin", "Victim", "Donator", "Volunteer" });
            if (roleFilter.SelectedIndex < 0) roleFilter.SelectedIndex = 0;

            LoadUsers();
            ApplyFilters();
        }

        private void OnFilterChanged(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void LoadUsers()
        {
            _users.Clear();

            try
            {
                // Admins
                string adminQuery = "SELECT a.*, l.Username, l.Status, l.Message FROM Admin a INNER JOIN Login l ON a.LoginID = l.LoginID";
                foreach (var a in Query.GetAdmins(adminQuery))
                {
                    _users.Add(new UserItem
                    {
                        LoginID = a.LoginID,
                        Role = "Admin",
                        Username = a.Username,
                        FullName = a.FullName,
                        Status = a.Status,
                        Contact = a.Email,
                        Extra = string.Empty,
                        Message = a.Message ?? string.Empty
                    });
                }

                // Victims
                string victimQuery = "SELECT v.*, l.Username, l.Status, l.Message FROM Victim v INNER JOIN Login l ON v.LoginID = l.LoginID";
                foreach (var v in Query.GetVictims(victimQuery))
                {
                    _users.Add(new UserItem
                    {
                        LoginID = v.LoginID,
                        Role = "Victim",
                        Username = v.Username,
                        FullName = v.FullName,
                        Status = v.Status,
                        Contact = v.Phone,
                        Extra = v.Address,
                        Message = v.Message ?? string.Empty
                    });
                }

                // Donators
                string donatorQuery = "SELECT d.*, l.Username, l.Status, l.Message FROM Donator d INNER JOIN Login l ON d.LoginID = l.LoginID";
                foreach (var d in Query.GetDonators(donatorQuery))
                {
                    _users.Add(new UserItem
                    {
                        LoginID = d.LoginID,
                        Role = "Donator",
                        Username = d.Username,
                        FullName = d.FullName,
                        Status = d.Status,
                        Contact = d.Phone,
                        Extra = d.Address,
                        Message = d.Message ?? string.Empty
                    });
                }

                // Volunteers
                string volunteerQuery = "SELECT v.*, l.Username, l.Status, l.Message FROM Volunteer v INNER JOIN Login l ON v.LoginID = l.LoginID";
                foreach (var v in Query.GetVolunteers(volunteerQuery))
                {
                    _users.Add(new UserItem
                    {
                        LoginID = v.LoginID,
                        Role = "Volunteer",
                        Username = v.Username,
                        FullName = v.FullName,
                        Status = v.Status,
                        Contact = v.Phone,
                        Extra = $"Availability: {v.AvailabilityStatus}",
                        Message = v.Message ?? string.Empty
                    });
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyFilters()
        {
            string search = (searchBox.Text ?? string.Empty).Trim().ToLower();
            string statusFilter = filter.SelectedItem?.ToString() ?? "All";
            string roleFilter = this.roleFilter.SelectedItem?.ToString() ?? "All";

            IEnumerable<UserItem> q = _users;

            if (statusFilter == "Active")
                q = q.Where(u => u.Status);
            else if (statusFilter == "Inactive")
                q = q.Where(u => !u.Status);

            if (!string.Equals(roleFilter, "All", StringComparison.OrdinalIgnoreCase))
                q = q.Where(u => string.Equals(u.Role, roleFilter, StringComparison.OrdinalIgnoreCase));

            if (!string.IsNullOrEmpty(search))
            {
                q = q.Where(u =>
                    (u.FullName ?? string.Empty).ToLower().Contains(search) ||
                    (u.Username ?? string.Empty).ToLower().Contains(search));
            }

            RenderUsers(q);
        }

        private void RenderUsers(IEnumerable<UserItem> users)
        {
            userListPnl.SuspendLayout();
            userListPnl.Controls.Clear();

            foreach (var u in users)
            {
                userListPnl.Controls.Add(CreateUserCard(u));
            }

            userListPnl.ResumeLayout();
        }

        private Control CreateUserCard(UserItem u)
        {
            var card = new Panel
            {
                Size = new Size(900, 56),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 0, 0, 8),
                Padding = new Padding(0),
                Tag = u.LoginID
            };

            var header = new Panel
            {
                Height = 56,
                Dock = DockStyle.Top,
                Padding = new Padding(12, 8, 12, 8),
                BackColor = Color.WhiteSmoke,
                BorderStyle = BorderStyle.FixedSingle,
                Name = "HeaderPanel"
            };

            var nameLbl = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Text = u.FullName,
                Location = new Point(12, 8),
                Cursor = Cursors.Hand
            };

            var subLbl = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9F),
                Text = $"{u.Username} • {u.Role}",
                Location = new Point(12, 28)
            };

            var statusLbl = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Text = u.Status ? "Active" : "Inactive",
                ForeColor = u.Status ? Color.ForestGreen : Color.Firebrick,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(50, 16)
            };

            var toggleBtn = new Button
            {
                AutoSize = true,
                AutoSizeMode = AutoSizeMode.GrowAndShrink,
                Text = u.Status ? "Deactivate" : "Activate",
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(100, 12),
                Size = new Size(80, 28)
            };
            toggleBtn.Click += (s, args) => { toggleBtn_Click(u); };

            header.Controls.Add(nameLbl);
            header.Controls.Add(subLbl);
            header.Controls.Add(statusLbl);
            header.Controls.Add(toggleBtn);

            var details = UserDetails(u);
            details.Name = "DetailsPanel";
            // IMPORTANT: Do not set Location; rely on DockStyle.Top stacking

            // Add DETAILS first, then HEADER so header stays above and details below.
            card.Controls.Add(details);
            card.Controls.Add(header);

            // Wire expand toggle clicks
            nameLbl.Click += (s, args) => { ToggleExpand(header, details, card); };

            return card;
        }

        private Panel UserDetails(UserItem u)
        {
            List<string> labelNames = ["Full Name", "Username", "Role", "Contact", "Details", "Message/Reason"];
            var details = new Panel
            {
                Dock = DockStyle.Top,
                Padding = new Padding(12),
                Visible = false,
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(900, 0),
            };

            int ypos = 10;

            for (int i = 0; i < labelNames.Count; i++)
            {
                var key = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Text = labelNames[i] + ":",
                    Location = new Point(12, ypos)
                };
                var valueObj = u[i + 1];
                var val = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 9F),
                    Text = valueObj == null || string.IsNullOrWhiteSpace(valueObj.ToString()) ? "-" : valueObj.ToString(),
                    Location = new Point(120, ypos),
                    MaximumSize = new Size(userListPnl.ClientSize.Width - 200, 0)
                };
                details.Controls.Add(key);
                details.Controls.Add(val);
                ypos += 22;
            }
            return details;
        }

        private void ToggleExpand(Panel header, Panel details, Panel card)
        {
            bool expanding = !details.Visible;

            details.Visible = expanding;
            header.BackColor = expanding ? Color.Gainsboro : Color.WhiteSmoke;
            // Adjust card height to contain header + details when expanded
            card.Height = expanding ? 210 : header.Height;
            details.Height = expanding ? 154 : 0;
        }


        private void toggleBtn_Click(UserItem u)
        {
            bool makeActive = !u.Status;
            string newMessage = u.Message;

            if (!makeActive)
            {
                var prompt = new Form
                {
                    Text = "Reason to make user inactive",
                    StartPosition = FormStartPosition.CenterParent,
                    Width = 480,
                    Height = 180,
                    FormBorderStyle = FormBorderStyle.FixedDialog,
                    MaximizeBox = false,
                    MinimizeBox = false
                };
                {
                    var lbl = new Label { Text = "Reason:", Left = 10, Top = 15, Width = 60 };
                    var tb = new TextBox { Left = 80, Top = 12, Width = 370, Text = newMessage ?? string.Empty };
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

                    newMessage = tb.Text?.Trim() ?? string.Empty;
                    if (string.IsNullOrWhiteSpace(newMessage))
                    {
                        MessageBox.Show("Please provide a reason to make the user inactive.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }
            else
            {
                newMessage = string.Empty;
            }

            try
            {
                int affected = Query.UpdateLoginStatusAndMessage(u.LoginID, makeActive, makeActive ? "" : newMessage);
                if (affected > 0)
                {
                    u.Status = makeActive;
                    u.Message = makeActive ? string.Empty : newMessage;

                    ApplyFilters();
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
