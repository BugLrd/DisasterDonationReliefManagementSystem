using DisasterDonationReliefManagementSystem.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views
{
    public partial class Donation_view : BaseReqView
    {
        public Donation_view()
        {
            InitializeComponent();


        }

        private void Donationview_Load(object sender, EventArgs e)
        {
            string select_query = "SELECT * FROM DisasterRequest WHERE RequestStatus = 'Approved' ORDER BY RequestDate DESC";
            SetRequests(Query.GetDisasterRequests(select_query));
        }
    }
}
