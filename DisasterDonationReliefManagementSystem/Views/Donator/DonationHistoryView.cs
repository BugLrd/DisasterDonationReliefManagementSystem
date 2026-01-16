using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views.Donator
{
    public class DonationInfo
    {
        public int DonationID { get; set; }
        public string DisasterTitle { get; set; }
        public string VictimName { get; set; }
        public DateTime DonationDate { get; set; }
        public string DeliveryStatus { get; set; }
    }

    public partial class DonationHistoryView : UserControl
    {
        private Entities.Donator _donator;
        public DonationHistoryView(Entities.Donator donator)
        {
            InitializeComponent();
            _donator = donator;
        }
        private void DonationHistoryView_Load(object sender, EventArgs e)
        {
            filter.SelectedIndexChanged += (s, ev) => LoadData();
            LoadData();
        }

        private void LoadData()
        {
            List<DonationInfo> infos = Query.GetDonationInfos(_donator.DonatorID);
            ApplyFilter(infos);
        }

        private void ApplyFilter(List<DonationInfo> donations)
        {
            string status = filter.SelectedItem.ToString();
            mainPnl.Controls.Clear();
            List<DonationInfo> filteredDonations;
            if (status == "All")
            {
                filteredDonations = donations;
            }
            else
            {
                filteredDonations = donations.FindAll(d => d.DeliveryStatus == status);
            }
            DonationHistoryUI(filteredDonations);
        }
        private void DonationHistoryUI(List<DonationInfo> donations)
        {
            foreach (var donation in donations)
            {
                var card = CreateDonationCard(donation);
                mainPnl.Controls.Add(card);
            }

        }

        private Panel CreateDonationCard(DonationInfo info)
        {
            var card = new Panel
            {
                Size = new Size(900, 56),
                BackColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(0, 0, 0, 8),
                Padding = new Padding(0),
                Tag = info.DonationID
            };

            var nameLbl = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                Text = "Donation to " + info.VictimName,
                Location = new Point(12, 8),
                Cursor = Cursors.Hand
            };

            var subLbl = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9F),
                Text = $"Request Title: {info.DisasterTitle}" + $" | Donation Date: {info.DonationDate.ToString("d")}",
                Location = new Point(12, 28)
            };

            Color c = info.DeliveryStatus == "Pending" ? Color.Orange : Color.Blue;
            var statusLbl = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Text = $"Status: {info.DeliveryStatus}",
                ForeColor = info.DeliveryStatus == "Delivered" ? Color.Green : c,
                Anchor = AnchorStyles.Top | AnchorStyles.Right,
                Location = new Point(750, 18)
            };

            card.Controls.Add(nameLbl);
            card.Controls.Add(subLbl);
            card.Controls.Add(statusLbl);

            return card;
        }
    }
}
