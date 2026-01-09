using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using DisasterDonationReliefManagementSystem.Views;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem
{
    public partial class VictimHomeView : BaseReqView
    {

        public VictimHomeView()
        {
            InitializeComponent();
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            string select_query = "SELECT * FROM DisasterRequest WHERE RequestStatus = 'Approved' ORDER BY RequestDate DESC";
            SetRequests(Query.GetDisasterRequests(select_query));
        }

        
    }
}
