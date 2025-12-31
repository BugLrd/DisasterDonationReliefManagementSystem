using DisasterDonationReliefManagementSystem.Entities;
using DisasterDonationReliefManagementSystem.Services;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Views
{
    public partial class YourRequestsView : BaseReqView
    {
        Victim victim;

        Button editBtn, deleteBtn;
        public YourRequestsView(Victim victim)
        {
            InitializeComponent();
            this.victim = victim;
        }

        private void YourRequestsView_Load(object sender, EventArgs e)
        {
            string select_query = $"SELECT * FROM DisasterRequest WHERE VictimID = {victim.VictimID} ORDER BY RequestDate DESC";
            List<DisasterRequest> disasterRequests = Query.GetDisasterRequests(select_query);
            if (disasterRequests.Count == 0 || disasterRequests == null)
            {
                containerPnl.Controls.Clear();
                Label noReqLbl = new Label
                {
                    Text = "You have not made any disaster requests yet.",
                    AutoSize = true,
                    Font = new Font("Arial", 12, FontStyle.Italic),
                    ForeColor = Color.Gray,
                    Location = new Point((containerPnl.Width) / 2 - 170, containerPnl.Height / 2 - 15)
                };
                containerPnl.Controls.Add(noReqLbl);
                return;
            }
            LoadRequest(disasterRequests);

            editBtn = new Button
            {
                Text = "Edit",
                Size = new Size(80, 30),
                Location = new Point(800, 10),
                BackColor = Color.FromArgb(0, 120, 215),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            deleteBtn = new Button
            {
                Text = "Delete",
                Size = new Size(80, 30),
                Location = new Point(800,  45),
                BackColor = Color.Firebrick,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            if (subReqPnl != null )
            {
                subReqPnl.Controls.Add(editBtn);
                subReqPnl.Controls.Add(deleteBtn);
                subReqPnl.Click += (s, args) =>
                {
                    if (isDetailsPanelOpen)
                    {
                        editBtn.Location = new Point(subReqPnl.Width - 400, 10);
                        deleteBtn.Location = new Point(subReqPnl.Width - 400, 45);

                    }
                    else {
                        editBtn.Location = new Point(800, 10);
                        deleteBtn.Location = new Point(800, 45);
                    }

                };
            }

        }
        public override void CloseDetailsPanel()
        {
            base.CloseDetailsPanel();
            editBtn.Location = new Point(800, 10);
            deleteBtn.Location = new Point(800, 45);
        }
    }
}
