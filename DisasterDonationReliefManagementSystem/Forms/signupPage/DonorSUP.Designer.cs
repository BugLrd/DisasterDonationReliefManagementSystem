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
            usertxtbx = new TextBox();
            nametxtbx = new TextBox();
            phone = new Label();
            phntxtbx = new TextBox();
            passlb = new Label();
            passtxtbx = new TextBox();
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
            signupbtn.Click += signupbtn_Click;
            // 
            // Username
            // 
            Username.AutoSize = true;
            Username.BackColor = Color.Transparent;
            Username.Location = new Point(95, 250);
            Username.Name = "Username";
            Username.Size = new Size(60, 15);
            Username.TabIndex = 11;
            Username.Text = "Username";
            Username.Click += Username_Click;
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
            // usertxtbx
            // 
            usertxtbx.Location = new Point(210, 247);
            usertxtbx.Name = "usertxtbx";
            usertxtbx.Size = new Size(230, 23);
            usertxtbx.TabIndex = 16;
            usertxtbx.TextChanged += usertxtbx_TextChanged;
            // 
            // nametxtbx
            // 
            nametxtbx.Location = new Point(210, 177);
            nametxtbx.Name = "nametxtbx";
            nametxtbx.Size = new Size(230, 23);
            nametxtbx.TabIndex = 17;
            nametxtbx.TextChanged += nametxtbx_TextChanged;
            // 
            // phone
            // 
            phone.AutoSize = true;
            phone.BackColor = Color.Transparent;
            phone.Location = new Point(95, 361);
            phone.Name = "phone";
            phone.Size = new Size(41, 15);
            phone.TabIndex = 18;
            phone.Text = "Phone";
            // 
            // phntxtbx
            // 
            phntxtbx.Location = new Point(210, 358);
            phntxtbx.Name = "phntxtbx";
            phntxtbx.Size = new Size(230, 23);
            phntxtbx.TabIndex = 19;
            // 
            // passlb
            // 
            passlb.AutoSize = true;
            passlb.BackColor = Color.Transparent;
            passlb.Location = new Point(95, 307);
            passlb.Name = "passlb";
            passlb.Size = new Size(57, 15);
            passlb.TabIndex = 20;
            passlb.Text = "Password";
            // 
            // passtxtbx
            // 
            passtxtbx.Location = new Point(210, 304);
            passtxtbx.Name = "passtxtbx";
            passtxtbx.Size = new Size(230, 23);
            passtxtbx.TabIndex = 21;
            // 
            // DonorSUP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SignUpBg;
            ClientSize = new Size(1140, 720);
            Controls.Add(passtxtbx);
            Controls.Add(passlb);
            Controls.Add(phntxtbx);
            Controls.Add(phone);
            Controls.Add(nametxtbx);
            Controls.Add(usertxtbx);
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
        private TextBox usertxtbx;
        private TextBox nametxtbx;
        private Label phone;
        private TextBox phntxtbx;
        private Label passlb;
        private TextBox passtxtbx;
    }
}