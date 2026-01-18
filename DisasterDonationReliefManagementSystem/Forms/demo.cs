using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Forms
{
    public partial class demo : Form
    {
        public demo()
        {
            InitializeComponent();

        }

        private void demo_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            var view = new DisasterDonationReliefManagementSystem.Views.Donation_view();
            view.Dock = DockStyle.Fill;     
            this.Controls.Add(view);
        }
    }
}
