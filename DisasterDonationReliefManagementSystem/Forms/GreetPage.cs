using DisasterDonationReliefManagementSystem.Forms;
using DisasterDonationReliefManagementSystem.Forms.signupPage;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem
{
    public partial class GreetPage : Form
    {
        public GreetPage()
        {
            InitializeComponent();


            SetupPanelClickEvents();
        }

        private void SetupPanelClickEvents()
        {

            victim_panel.Click += panel_Click;
            Donator_panel.Click += panel_Click;
            volun_panel.Click += panel_Click;
            nearhub.Click += panel_Click;
            donation_details.Click += panel_Click;
            new_panel.Click += panel_Click;


            MakePanelAndChildrenClickable(victim_panel);
            MakePanelAndChildrenClickable(Donator_panel);
            MakePanelAndChildrenClickable(volun_panel);
            MakePanelAndChildrenClickable(nearhub);
            MakePanelAndChildrenClickable(donation_details);
            MakePanelAndChildrenClickable(new_panel);
        }

        private void MakePanelAndChildrenClickable(Panel panel)
        {
            panel.Cursor = Cursors.Hand;

            foreach (Control control in panel.Controls)
            {
                control.Cursor = Cursors.Hand;
                control.Click += (s, e) =>
                {

                    panel_Click(panel, e);
                };
            }
        }


        private void panel_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;

            if (panel == victim_panel)
            {
                new VictimSignUp().Show();
            }
            else if (panel == Donator_panel)
            {
                new DonatorSIgnUp().Show();
            }
            else if (panel == volun_panel)
            {
                new VolunteerSignUp().Show();
            }
            else if (panel == nearhub)
            {

                MessageBox.Show("Near Delivery Hub - Coming Soon!");

            }
            else if (panel == donation_details)
            {

                MessageBox.Show("Donation Needs - Coming Soon!");

            }
            else if (panel == new_panel)
            {

                OpenWebLink("https://reliefweb.int/disasters?advanced-search=%28C31%29&search=");

            }
        }
        private void OpenWebLink(string url)
        {
            try
            {
                
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Cannot open web link: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loginbt_Click(object sender, EventArgs e)
        {
            new LogInPage().Show();
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void label8_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }

        
    }
}