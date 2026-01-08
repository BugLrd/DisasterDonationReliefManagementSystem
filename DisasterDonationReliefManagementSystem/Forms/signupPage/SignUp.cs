using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DisasterDonationReliefManagementSystem.Forms
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        public TextBox FnameTb()
        {
            return fnametb;
        }
        public TextBox LnameTb()
        {
            return lnametb;
        }
        public TextBox UnameTb()
        {
            return unametb;
        }
        public TextBox PassTb()
        {
            return passtb;
        }
        public TextBox ConfirmPassTb()
        {
            return confirmPasstb;
        }
        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        protected virtual void backbtn_Click(object sender, EventArgs e)
        {
            LogInPage l = new LogInPage();
            l.FormClosed += (s, args) => Application.Exit();
            l.Show();
            this.Hide();
        }

        protected virtual void signupbtn_Click(object sender, EventArgs e)
        {

        }

        private void lnametb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
