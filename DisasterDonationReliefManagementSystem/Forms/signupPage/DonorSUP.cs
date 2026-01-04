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


namespace DisasterDonationReliefManagementSystem.Forms.signupPage
{
    public partial class DonorSUP : Form
    {

        SqlConnection con = Query.GetConnection();
        Donator donator;

        public DonorSUP()
        {
            InitializeComponent();
        }



        private void signupbtn_Click(object sender, EventArgs e)
        {
            try
            {

                Login login = new Login(0,usertxtbx.Text.Trim(),passtxtbx.Text.Trim(),false,"Donator","Waiting for admin approval");




                int loginID = Query.InsertLogin(login);

                if (loginID <= 0)
                {
                    MessageBox.Show("Signup failed. Please try again.");
                    return;
                }

                
                


                Donator donator = new Donator(0,loginID,usertxtbx.Text.Trim(),false,nametxtbx.Text.Trim(),phntxtbx.Text.Trim(),AddressTxtbx.Text.Trim());



                int donorResult = Query.InsertDonator(donator);

                if (donorResult > 0)
                {
                    MessageBox.Show(
                        "Signup successful! Please wait for admin approval.",
                        "Success",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }
                else
                {
                    MessageBox.Show("Donator registration failed.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }


















        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Address_Click(object sender, EventArgs e)
        {

        }

        private void Username_Click(object sender, EventArgs e)
        {

        }

        private void nametxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        private void usertxtbx_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
