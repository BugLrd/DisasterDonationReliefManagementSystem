using DisasterDonationReliefManagementSystem.Views.Admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views.Manager
{
    public partial class ManagerHomeView : HomeView
    {
        public ManagerHomeView()
        {
            InitializeComponent();
        }

        private void ManagerHomeView_Load(object sender, EventArgs e)
        {
            ListBoxDisasterReq.Visible = false;

            var lblTotalAdminTitle = new Label
            {
                Text = "TOTAL ADMIN\n" + infos["TotalAdmins"],
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.DarkCyan,
                AutoSize = false,
                Location = new Point(83, 225),
                Size = new Size(377, 100),
                TextAlign = ContentAlignment.MiddleCenter
            };
            MainPnl.Controls.Add(lblTotalAdminTitle);

            var lblActiveAdmins = new Label
            {
                Text = "ACTIVE ADMIN\n" + infos["ActiveAdmins"],
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.SeaGreen,
                AutoSize = false,
                Location = new Point(83, 350),
                Size = new Size(165, 100),
                TextAlign = ContentAlignment.MiddleCenter
            };
            MainPnl.Controls.Add(lblActiveAdmins);

            var lblInactiveAdmins = new Label
            {
                Text = "INACTIVE ADMIN\n" + infos["InactiveAdmins"],
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.Black,
                BackColor = Color.IndianRed,
                AutoSize = false,
                Location = new Point(295, 350),
                Size = new Size(165, 100),
                TextAlign = ContentAlignment.MiddleCenter,
                
            };
            MainPnl.Controls.Add(lblInactiveAdmins);
        }
    }
}
