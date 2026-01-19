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
                VictimSignUp v = new VictimSignUp();
                v.FormClosed += (s, args) => this.Show();
                v.Show();
                this.Hide();
            }
            else if (panel == Donator_panel)
            {
                DonatorSIgnUp v = new DonatorSIgnUp();
                v.FormClosed += (s, args) => this.Show();
                v.Show();
                this.Hide();
            }
            else if (panel == volun_panel)
            {
                VolunteerSignUp v = new VolunteerSignUp();
                v.FormClosed += (s, args) => this.Show();
                v.Show();
                this.Hide();
            }
            else if (panel == nearhub)
            {

                MessageBox.Show("Near Delivery Hub - Coming Soon!");

            }
            else if (panel == donation_details)
            {

                new DisasterReqs().Show();

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
    }
}