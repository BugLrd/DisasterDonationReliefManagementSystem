using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views
{
    public partial class YourRequestsView : BaseReqView
    {
        SqlConnection con = Query.GetConnection();
        Victim victim;
        public YourRequestsView(Victim victim)
        {
            InitializeComponent();
            this.victim = victim;
        }

        private void YourRequestsView_Load(object sender, EventArgs e)
        {
            string select_query = $"SELECT * FROM DisasterRequest WHERE VictimID = {victim.VictimID} ORDER BY RequestDate DESC";
           

            LoadRequest(Query.GetDisasterRequests(select_query));
        }
    }
}
