using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views.Volunteer
{
    public partial class DelHistView : BaseDelReqView
    {
        public DelHistView(Entities.Volunteer volunteer) : base(volunteer)
        {
            InitializeComponent();
        }

        private void DelHistView_Load(object sender, EventArgs e)
        {
            ReloadRequests();
        }

        private void ReloadRequests()
        {
            GetDelReqListPnl().Controls.Clear();
            string sql = $"SELECT del.*, dn.DonationDate as RequestDate FROM Delivery as del, Donation as dn WHERE del.DonationID = dn.DonationID AND VolunteerID = {vol.VolunteerID} AND (DeliveryStatus = 'Delivered')";
            LoadRequests(Query.GetDeliveries(sql));

            foreach (Control ctrl in GetDelReqListPnl().Controls)
            {
                Panel card = (Panel)ctrl;
                ReDecorateCard(card, card.Tag as Delivery);
            }
        }

        protected override Panel ReDecorateCard(Panel card, Delivery delivery)
        {
            // Set background for delivered status
            card.BackColor = Color.ForestGreen;
            return card;
        }
    }
}
