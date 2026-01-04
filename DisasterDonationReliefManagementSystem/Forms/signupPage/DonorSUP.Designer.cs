namespace DisasterDonationReliefManagementSystem.Forms.signupPage
{
    partial class DonorSUP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textlbl = new Label();
            backbtn = new Button();
            signupbtn = new Button();
            Username = new Label();
            Address = new Label();
            name = new Label();
            AddressTxtbx = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            phone = new Label();
            textBox3 = new TextBox();
            SuspendLayout();
            // 
            // textlbl
            // 
            textlbl.AutoSize = true;
            textlbl.BackColor = Color.Transparent;
            textlbl.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            textlbl.Location = new Point(116, 73);
            textlbl.Name = "textlbl";
            textlbl.Size = new Size(226, 31);
            textlbl.TabIndex = 1;
            textlbl.Text = "Sign Up As Donator";
            // 
            // backbtn
            // 
            backbtn.BackColor = SystemColors.ControlDarkDark;
            backbtn.Location = new Point(72, 583);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(194, 31);
            backbtn.TabIndex = 9;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.ForestGreen;
            signupbtn.Location = new Point(402, 583);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(196, 31);
            signupbtn.TabIndex = 10;
            signupbtn.Text = "SignUp";
            signupbtn.UseVisualStyleBackColor = false;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Location = new Point(95, 253);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 11;
            Username.Text = "Username";
            // 
            // Address
            // 
            Address.AutoSize = true;
            Address.BackColor = Color.Transparent;
            Address.Location = new Point(95, 424);
            Address.Name = "Address";
            Address.Size = new Size(49, 15);
            Address.TabIndex = 12;
            Address.Text = "Address";
            Address.Click += Address_Click;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.Transparent;
            name.Location = new Point(95, 180);
            name.Name = "name";
            name.Size = new Size(64, 15);
            name.TabIndex = 13;
            name.Text = "Full Name ";
            name.Click += label3_Click;
            // 
            // AddressTxtbx
            // 
            AddressTxtbx.Location = new Point(210, 421);
            AddressTxtbx.Multiline = true;
            AddressTxtbx.Name = "AddressTxtbx";
            AddressTxtbx.Size = new Size(230, 95);
            AddressTxtbx.TabIndex = 15;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(210, 250);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(230, 23);
            textBox2.TabIndex = 16;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 177);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 23);
            textBox1.TabIndex = 17;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.BackColor = Color.Transparent;
            phone.Location = new Point(95, 333);
            phone.Name = "phone";
            phone.Size = new Size(41, 15);
            phone.TabIndex = 18;
            phone.Text = "Phone";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(210, 330);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(230, 23);
            textBox3.TabIndex = 19;
            // 
            // DonorSUP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SignUpBg;
            ClientSize = new Size(1140, 720);
            Controls.Add(textBox3);
            Controls.Add(phone);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(AddressTxtbx);
            Controls.Add(name);
            Controls.Add(Address);
            Controls.Add(Username);
            Controls.Add(signupbtn);
            Controls.Add(backbtn);
            Controls.Add(textlbl);
            Name = "DonorSUP";
            Text = "DonorSUP";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textlbl;
        private Button backbtn;
        private Button signupbtn;
        private Label Username;
        private Label Address;
        private Label name;
        private TextBox AddressTxtbx;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label phone;
        private TextBox textBox3;
    }
}