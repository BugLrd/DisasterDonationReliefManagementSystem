using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net.ServerSentEvents;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views.Volunteer
{
    public partial class BaseDelReqView : UserControl
    {
        public Entities.Volunteer vol;
        public List<Delivery> _requests;
        public BaseDelReqView(Entities.Volunteer volunteer)
        {
            InitializeComponent();
            vol = volunteer;
        }

        public Panel GetDelReqListPnl()
        {
            return DelReqListPnl;
        }

        private void BaseDelReqView_Load(object sender, EventArgs e)
        {
            searchBox.TextChanged -= OnFilterChanged;
            searchBox.TextChanged += OnFilterChanged;

            filter.SelectedIndexChanged -= OnFilterChanged;
            filter.SelectedIndexChanged += OnFilterChanged;

            // Ensure a default selection exists before filtering
            if (filter.Items.Count > 0 && filter.SelectedIndex < 0)
                filter.SelectedIndex = 0;
        }

        private void OnFilterChanged(object? sender, EventArgs e)
        {
            ApplyFilters();
        }

        public void LoadRequests(List<Delivery> deliveries)
        {
            _requests = deliveries;
            if (_requests == null || _requests.Count == 0)
            {
                Label noRequestsLabel = new Label
                {
                    AutoSize = true,
                    Font = new Font("Segoe UI", 10F, FontStyle.Italic),
                    Text = "No delivery requests available.",
                    ForeColor = Color.Gray,
                    Location = new Point(12, 12)
                };
                GetDelReqListPnl().Controls.Add(noRequestsLabel);
                searchBox.Enabled = false;
                filter.Enabled = false;
                return;
            }
            ApplyFilters();
        }

        private void ApplyFilters()
        {
            string search = (searchBox.Text ?? string.Empty).Trim().ToLower();
            // Guard against null SelectedItem during early lifecycle
            string statusFilter = filter.SelectedItem as string ?? "Most Recent";
            IEnumerable<Delivery> q = _requests ?? new List<Delivery>();

            // Optional: interpret sorting values if your ComboBox uses them
            if (string.Equals(statusFilter, "Most Recent", StringComparison.OrdinalIgnoreCase))
            {
                q = q.OrderByDescending(r => r.RequestDate);
            }
            else if (string.Equals(statusFilter, "Oldest", StringComparison.OrdinalIgnoreCase))
            {
                q = q.OrderBy(r => r.RequestDate);
            }

            if (!string.IsNullOrEmpty(search))
            {
                q = q.Where(u =>
                    (u.PickupLocation ?? string.Empty).ToLower().Contains(search) ||
                    (u.DeliveryLocation ?? string.Empty).ToLower().Contains(search));
            }

            RenderRequests(q);
        }

        private void RenderRequests(IEnumerable<Delivery> r)
        {
            DelReqListPnl.SuspendLayout();
            DelReqListPnl.Controls.Clear();

            foreach (var u in r)
            {
                DelReqListPnl.Controls.Add(CreateReqCard(u));
            }

            DelReqListPnl.ResumeLayout();
        }

        private Control CreateReqCard(Delivery r)
        {
            var card = new Panel
            {
                Size = new Size(920, 56),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 0, 0, 8),
                Padding = new Padding(0),
                Name = "card_" + r.DeliveryID,
                Tag = r
            };

            var TitleLbl = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Text = r.PickupLocation + " -> " + r.DeliveryLocation,
                Location = new Point(12, 8),
                Cursor = Cursors.Hand
            };

            var subLbl = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9F),
                Text = $"Request Date: {r.RequestDate}",
                Location = new Point(12, 28)
            };



            card.Controls.Add(TitleLbl);
            card.Controls.Add(subLbl);
            return ReDecorateCard(card, r);
        }

        protected virtual Panel ReDecorateCard(Panel card, Delivery delivery)
        {
            // Default no-op; derived views can override for specific decorations
            return card;
        }
    }
}
                