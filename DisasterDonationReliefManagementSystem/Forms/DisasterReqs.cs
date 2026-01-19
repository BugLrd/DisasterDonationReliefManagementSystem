using DisasterDonationReliefManagementSystem.Services;
using DisasterDonationReliefManagementSystem.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Forms
{
    public partial class DisasterReqs : Form
    {
        public DisasterReqs()
        {
            InitializeComponent();

        }

        private void demo_Load(object sender, EventArgs e)
        {
            string select_query = "SELECT * FROM DisasterRequest WHERE RequestStatus = 'Approved' ORDER BY RequestDate DESC";
            baseReqView.SetRequests(Query.GetDisasterRequests(select_query));
        }
    }
}
