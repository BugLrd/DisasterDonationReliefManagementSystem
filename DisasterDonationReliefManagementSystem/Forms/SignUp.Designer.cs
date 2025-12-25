namespace DisasterDonationReliefManagementSystem.Forms
{
    partial class SignUp
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
            fname = new TextBox();
            lname = new TextBox();
            email = new TextBox();
            phone = new TextBox();
            address = new TextBox();
            GenderGBox = new GroupBox();
            othersbtn = new RadioButton();
            femalebtn = new RadioButton();
            malebtn = new RadioButton();
            roleGBox = new GroupBox();
            adminbtn = new RadioButton();
            volunteerbtn = new RadioButton();
            donorbtn = new RadioButton();
            victimbtn = new RadioButton();
            backbtn = new Button();
            signupbtn = new Button();
            pass = new TextBox();
            confirmpass = new TextBox();
            GenderGBox.SuspendLayout();
            roleGBox.SuspendLayout();
            SuspendLayout();
            // 
            // textlbl
            // 
            textlbl.AutoSize = true;
            textlbl.BackColor = Color.Transparent;
            textlbl.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            textlbl.Location = new Point(69, 39);
            textlbl.Name = "textlbl";
            textlbl.Size = new Size(246, 31);
            textlbl.TabIndex = 0;
            textlbl.Text = "Sign Up on ReliefHub";
            textlbl.Click += label1_Click;
            // 
            // fname
            // 
            fname.Location = new Point(86, 111);
            fname.Name = "fname";
            fname.PlaceholderText = "First Name";
            fname.Size = new Size(217, 23);
            fname.TabIndex = 1;
            fname.TextChanged += textBox1_TextChanged;
            // 
            // lname
            // 
            lname.Location = new Point(86, 159);
            lname.Name = "lname";
            lname.PlaceholderText = "Last Name";
            lname.Size = new Size(217, 23);
            lname.TabIndex = 1;
            lname.TextChanged += textBox1_TextChanged;
            // 
            // email
            // 
            email.Location = new Point(86, 213);
            email.Name = "email";
            email.PlaceholderText = "Email";
            email.Size = new Size(217, 23);
            email.TabIndex = 1;
            email.TextChanged += textBox1_TextChanged;
            // 
            // phone
            // 
            phone.Location = new Point(86, 263);
            phone.MaxLength = 11;
            phone.Name = "phone";
            phone.PlaceholderText = "Phone";
            phone.Size = new Size(217, 23);
            phone.TabIndex = 1;
            phone.TextChanged += textBox1_TextChanged;
            // 
            // address
            // 
            address.Location = new Point(86, 314);
            address.Name = "address";
            address.PlaceholderText = "Address";
            address.Size = new Size(217, 23);
            address.TabIndex = 1;
            address.TextChanged += textBox1_TextChanged;
            // 
            // GenderGBox
            // 
            GenderGBox.BackColor = Color.Transparent;
            GenderGBox.Controls.Add(othersbtn);
            GenderGBox.Controls.Add(femalebtn);
            GenderGBox.Controls.Add(malebtn);
            GenderGBox.Location = new Point(336, 111);
            GenderGBox.Name = "GenderGBox";
            GenderGBox.Size = new Size(200, 100);
            GenderGBox.TabIndex = 2;
            GenderGBox.TabStop = false;
            GenderGBox.Text = "Select Gender";
            GenderGBox.Enter += groupBox1_Enter;
            // 
            // othersbtn
            // 
            othersbtn.AutoSize = true;
            othersbtn.Location = new Point(21, 71);
            othersbtn.Name = "othersbtn";
            othersbtn.Size = new Size(60, 19);
            othersbtn.TabIndex = 2;
            othersbtn.TabStop = true;
            othersbtn.Text = "Others";
            othersbtn.UseVisualStyleBackColor = true;
            othersbtn.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // femalebtn
            // 
            femalebtn.AutoSize = true;
            femalebtn.Location = new Point(20, 46);
            femalebtn.Name = "femalebtn";
            femalebtn.Size = new Size(63, 19);
            femalebtn.TabIndex = 1;
            femalebtn.TabStop = true;
            femalebtn.Text = "Female";
            femalebtn.UseVisualStyleBackColor = true;
            // 
            // malebtn
            // 
            malebtn.AutoSize = true;
            malebtn.Location = new Point(21, 22);
            malebtn.Name = "malebtn";
            malebtn.Size = new Size(51, 19);
            malebtn.TabIndex = 0;
            malebtn.TabStop = true;
            malebtn.Text = "Male";
            malebtn.UseVisualStyleBackColor = true;
            // 
            // roleGBox
            // 
            roleGBox.BackColor = Color.Transparent;
            roleGBox.Controls.Add(adminbtn);
            roleGBox.Controls.Add(volunteerbtn);
            roleGBox.Controls.Add(donorbtn);
            roleGBox.Controls.Add(victimbtn);
            roleGBox.Location = new Point(336, 217);
            roleGBox.Name = "roleGBox";
            roleGBox.Size = new Size(200, 120);
            roleGBox.TabIndex = 3;
            roleGBox.TabStop = false;
            roleGBox.Text = "Select Role";
            roleGBox.Enter += groupBox1_Enter_1;
            // 
            // adminbtn
            // 
            adminbtn.AutoSize = true;
            adminbtn.Location = new Point(21, 95);
            adminbtn.Name = "adminbtn";
            adminbtn.Size = new Size(61, 19);
            adminbtn.TabIndex = 3;
            adminbtn.TabStop = true;
            adminbtn.Text = "Admin";
            adminbtn.UseVisualStyleBackColor = true;
            // 
            // volunteerbtn
            // 
            volunteerbtn.AutoSize = true;
            volunteerbtn.Location = new Point(21, 71);
            volunteerbtn.Name = "volunteerbtn";
            volunteerbtn.Size = new Size(75, 19);
            volunteerbtn.TabIndex = 2;
            volunteerbtn.TabStop = true;
            volunteerbtn.Text = "Volunteer";
            volunteerbtn.UseVisualStyleBackColor = true;
            // 
            // donorbtn
            // 
            donorbtn.AutoSize = true;
            donorbtn.Location = new Point(20, 46);
            donorbtn.Name = "donorbtn";
            donorbtn.Size = new Size(58, 19);
            donorbtn.TabIndex = 1;
            donorbtn.TabStop = true;
            donorbtn.Text = "Donor";
            donorbtn.UseVisualStyleBackColor = true;
            donorbtn.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // victimbtn
            // 
            victimbtn.AutoSize = true;
            victimbtn.Location = new Point(21, 22);
            victimbtn.Name = "victimbtn";
            victimbtn.Size = new Size(59, 19);
            victimbtn.TabIndex = 0;
            victimbtn.TabStop = true;
            victimbtn.Text = "Victim";
            victimbtn.UseVisualStyleBackColor = true;
            // 
            // backbtn
            // 
            backbtn.BackColor = SystemColors.ControlDarkDark;
            backbtn.Location = new Point(86, 446);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(194, 31);
            backbtn.TabIndex = 4;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.ForestGreen;
            signupbtn.Location = new Point(357, 446);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(196, 31);
            signupbtn.TabIndex = 4;
            signupbtn.Text = "SignUp";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            // 
            // pass
            // 
            pass.Location = new Point(86, 363);
            pass.Name = "pass";
            pass.PasswordChar = '*';
            pass.PlaceholderText = "Password";
            pass.Size = new Size(217, 23);
            pass.TabIndex = 1;
            pass.TextChanged += textBox1_TextChanged;
            // 
            // confirmpass
            // 
            confirmpass.Location = new Point(336, 363);
            confirmpass.Name = "confirmpass";
            confirmpass.PasswordChar = '*';
            confirmpass.PlaceholderText = "Confirm Password";
            confirmpass.Size = new Size(217, 23);
            confirmpass.TabIndex = 1;
            confirmpass.TextChanged += textBox1_TextChanged;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SignUpBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1044, 582);
            Controls.Add(signupbtn);
            Controls.Add(backbtn);
            Controls.Add(roleGBox);
            Controls.Add(GenderGBox);
            Controls.Add(confirmpass);
            Controls.Add(pass);
            Controls.Add(address);
            Controls.Add(phone);
            Controls.Add(email);
            Controls.Add(lname);
            Controls.Add(fname);
            Controls.Add(textlbl);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            GenderGBox.ResumeLayout(false);
            GenderGBox.PerformLayout();
            roleGBox.ResumeLayout(false);
            roleGBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label textlbl;
        private TextBox fname;
        private TextBox lname;
        private TextBox email;
        private TextBox phone;
        private TextBox address;
        private GroupBox GenderGBox;
        private RadioButton othersbtn;
        private RadioButton femalebtn;
        private RadioButton malebtn;
        private GroupBox roleGBox;
        private RadioButton volunteerbtn;
        private RadioButton donorbtn;
        private RadioButton victimbtn;
        private RadioButton adminbtn;
        private Button backbtn;
        private Button signupbtn;
        private TextBox pass;
        private TextBox confirmpass;
    }
}