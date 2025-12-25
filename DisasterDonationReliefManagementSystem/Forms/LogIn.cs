using DisasterDonationReliefManagementSystem.Forms;

namespace DisasterDonationReliefManagementSystem
{
    public partial class LogInPage : Form
    {
        public LogInPage()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            if (unametf.Text == "admin" && passtf.Text == "admin")
            {
                HomePage home = new HomePage();
                home.FormClosed += (s, args) => Application.Exit();
                this.Hide();
                home.Show();

            }
            else
            {
                MessageBox.Show("Wrong Credentials!!");
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            GreetPage g = new GreetPage();
            g.FormClosed += (s, args) => Application.Exit();
            this.Hide();
            g.Show();
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            SignUp s = new SignUp();
            s.FormClosed += (s, args) => Application.Exit();
            s.Show();
            this.Hide();

        }

        private void LogInPage_Load(object sender, EventArgs e)
        {

        }

    }
}
