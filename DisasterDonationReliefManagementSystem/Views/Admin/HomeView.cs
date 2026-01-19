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
using DisasterDonationReliefManagementSystem.Services;

namespace DisasterDonationReliefManagementSystem.Views.Admin
{
    public partial class HomeView : UserControl
    {
        private readonly ToolTip _toolTip = new ToolTip();
        public Dictionary<string, int> infos;
        public HomeView()
        {
            InitializeComponent();
            _toolTip = new ToolTip();


            this.Load += HomeView_Load;
        }

        public ListBox ListBoxDisasterReq => listBoxDisasterReq;
        public Panel MainPnl => mainPnl;

        internal void HomeView_Load(object? sender, EventArgs e)
        {


            LoadUserDistribution();
            LoadDisasterRequestsCompact();
            LoadDashboardStats();
        }

        private void lbpendingtitle_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void progressBardonor_Click(object sender, EventArgs e)
        {

        }

        void LoadUserDistribution()
        {
            try
            {
                // Get all data from Query.GetInfos()
                infos = Query.GetInfos();

                // Get user type counts
                int volunteers = infos["Volunteers"];
                int donors = infos["Donors"];
                int victims = infos["Victims"];

                int total = volunteers + donors + victims;

                if (total == 0) return;

                int vPct = (volunteers * 100) / total;
                int dPct = (donors * 100) / total;
                int viPct = (victims * 100) / total;

                progressBarvolun.Value = vPct;
                progressBardonor.Value = dPct;
                progressBarvictim.Value = viPct;

                lbVolonP.Text = $"Volunteer ({vPct}%)";
                lbdonorP.Text = $"Donor ({dPct}%)";
                lbvictimP.Text = $"Victim ({viPct}%)";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading user distribution: {ex.Message}");
            }
        }




        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxDisasterReq_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void LoadDisasterRequestsCompact()
        {
            try
            {
                // Get data from Query.GetInfos()
                Dictionary<string, int> infos = Query.GetInfos();

                int pendingCount = infos["PendingRequests"];

                listBoxDisasterReq.Items.Clear();

                if (pendingCount == 0)
                {
                    listBoxDisasterReq.Items.Add("✅ NO PENDING REQUESTS");
                    listBoxDisasterReq.Items.Add("");
                    listBoxDisasterReq.Items.Add("All disaster requests are");
                    listBoxDisasterReq.Items.Add("currently processed!");
                    listBoxDisasterReq.Items.Add("");
                    listBoxDisasterReq.Items.Add("🎉 Great job!");
                    return;
                }

                listBoxDisasterReq.Items.Add($"🚨 PENDING REQUESTS: {pendingCount}");
                listBoxDisasterReq.Items.Add("");

                // Get detailed requests
                string sql = "SELECT * FROM DisasterRequest WHERE RequestStatus = 'Pending'";
                List<DisasterRequest> requests = Query.GetDisasterRequests(sql);

                foreach (DisasterRequest req in requests)
                {
                    string item = $"{req.DisasterTitle} | {req.Location} | Needs: {req.RequestedItems}";
                    listBoxDisasterReq.Items.Add(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
                listBoxDisasterReq.Items.Clear();
                listBoxDisasterReq.Items.Add("⚠️ Error loading requests");
                listBoxDisasterReq.Items.Add($"Details: {ex.Message}");
            }
        }

        private void LoadDashboardStats()
        {
            try
            {
                Dictionary<string, int> infos = Query.GetInfos();

                // Update PENDING
                if (infos.ContainsKey("PendingRequests"))
                {
                    lbvaluepending.Text = infos["PendingRequests"].ToString();
                }

                // Update ACTIVE USER
                if (infos.ContainsKey("ActiveUsers"))
                {
                    lbactiveuser.Text = infos["ActiveUsers"].ToString();
                }

                // Update TOTAL REQ
                if (infos.ContainsKey("TotalRequests"))
                {
                    rlbreqpending.Text = infos["TotalRequests"].ToString();
                }

                // Update INACTIVE
                if (infos.ContainsKey("InactiveUsers"))
                {
                    lbinactive.Text = infos["InactiveUsers"].ToString();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard stats: {ex.Message}");
                SetDefaultValues();
            }
        }

        private void SetDefaultValues()
        {
            lbvaluepending.Text = "0";
            lbactiveuser.Text = "0";
            rlbreqpending.Text = "0";
            lbinactive.Text = "0";
        }
        private void lbinactive_Click(object sender, EventArgs e)
        {

        }

        private void rlbreqpending_Click(object sender, EventArgs e)
        {

        }
    }
}
