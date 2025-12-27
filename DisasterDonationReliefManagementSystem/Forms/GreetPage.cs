using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
           

            MakePanelActLikeButton(panel1);
            MakePanelActLikeButton(panel2);
            MakePanelActLikeButton(panel3);
            MakePanelActLikeButton(panel4);
            MakePanelActLikeButton(panel5);
            MakePanelActLikeButton(panel6);
            MakePanelActLikeButton(panel7);
        }

        

        private void nextbtn_click(object sender, EventArgs e)
        {
            LogInPage l = new LogInPage();
            l.FormClosed += (s, args) => Application.Exit();
            l.Show();
            this.Hide();
        }

        private void CardPanel_Click(object sender, EventArgs e)
        {
            Panel panel = sender as Panel;

            if (panel == panel1)
            {
                MessageBox.Show("NEED HELP clicked");
            }
            else if (panel == panel2)
            {
                MessageBox.Show("Give Hope clicked");
            }
            else if (panel == panel3)
            {
                MessageBox.Show("Volunteer clicked");
            }
            else if (panel == panel4)
            {
                MessageBox.Show("Near delivery hub clicked");
            }
            else if (panel == panel5)
            {
                MessageBox.Show("View Donation Need clicked");
            }
            else if (panel == panel6)
            {
                MessageBox.Show("Total Donation clicked");
            }
            else if (panel == panel7)
            {
                MessageBox.Show("Latest News clicked");
            }
        }

        private void MakePanelActLikeButton(Panel panel)
        {
            panel.Cursor = Cursors.Hand;
            panel.Click += CardPanel_Click;

            foreach (Control ctrl in panel.Controls)
            {
                ctrl.Click += (s, e) => CardPanel_Click(panel, EventArgs.Empty);

            }
        }

    }
}
