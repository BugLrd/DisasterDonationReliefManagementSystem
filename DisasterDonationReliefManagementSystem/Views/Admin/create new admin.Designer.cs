namespace DisasterDonationReliefManagementSystem.Views.Admin
{
    partial class create_new_admin
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Admin_signup = new Label();
            usernamelb = new Label();
            passwordlb = new Label();
            email = new Label();
            fullnamelb = new Label();
            usernametxbx = new TextBox();
            passwordtxtbx = new TextBox();
            fullnametxtbox = new TextBox();
            emailtxtbx = new TextBox();
            creatadminbtn = new Button();
            SuspendLayout();
            // 
            // Admin_signup
            // 
            Admin_signup.AutoSize = true;
            Admin_signup.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Admin_signup.Location = new Point(355, 45);
            Admin_signup.Name = "Admin_signup";
            Admin_signup.Size = new Size(210, 37);
            Admin_signup.TabIndex = 0;
            Admin_signup.Text = "Admin Creation ";
            // 
            // usernamelb
            // 
            usernamelb.AutoSize = true;
            usernamelb.Font = new Font("Segoe UI", 11.25F);
            usernamelb.ForeColor = SystemColors.HotTrack;
            usernamelb.Location = new Point(94, 152);
            usernamelb.Name = "usernamelb";
            usernamelb.Size = new Size(75, 20);
            usernamelb.TabIndex = 1;
            usernamelb.Text = "Username";
            // 
            // passwordlb
            // 
            passwordlb.AutoSize = true;
            passwordlb.Font = new Font("Segoe UI", 11.25F);
            passwordlb.ForeColor = SystemColors.HotTrack;
            passwordlb.Location = new Point(94, 216);
            passwordlb.Name = "passwordlb";
            passwordlb.Size = new Size(72, 20);
            passwordlb.TabIndex = 2;
            passwordlb.Text = "password";
            // 
            // email
            // 
            email.AutoSize = true;
            email.Font = new Font("Segoe UI", 11.25F);
            email.ForeColor = SystemColors.HotTrack;
            email.Location = new Point(94, 362);
            email.Name = "email";
            email.Size = new Size(46, 20);
            email.TabIndex = 3;
            email.Text = "Email";
            // 
            // fullnamelb
            // 
            fullnamelb.AutoSize = true;
            fullnamelb.Font = new Font("Segoe UI", 11.25F);
            fullnamelb.ForeColor = SystemColors.HotTrack;
            fullnamelb.Location = new Point(94, 288);
            fullnamelb.Name = "fullnamelb";
            fullnamelb.Size = new Size(73, 20);
            fullnamelb.TabIndex = 4;
            fullnamelb.Text = "Full name";
            // 
            // usernametxbx
            // 
            usernametxbx.Location = new Point(261, 152);
            usernametxbx.Name = "usernametxbx";
            usernametxbx.Size = new Size(224, 23);
            usernametxbx.TabIndex = 5;
            // 
            // passwordtxtbx
            // 
            passwordtxtbx.Location = new Point(261, 213);
            passwordtxtbx.Name = "passwordtxtbx";
            passwordtxtbx.Size = new Size(224, 23);
            passwordtxtbx.TabIndex = 6;
            // 
            // fullnametxtbox
            // 
            fullnametxtbox.Location = new Point(261, 280);
            fullnametxtbox.Name = "fullnametxtbox";
            fullnametxtbox.Size = new Size(224, 23);
            fullnametxtbox.TabIndex = 7;
            // 
            // emailtxtbx
            // 
            emailtxtbx.Location = new Point(261, 359);
            emailtxtbx.Name = "emailtxtbx";
            emailtxtbx.Size = new Size(224, 23);
            emailtxtbx.TabIndex = 8;
            // 
            // creatadminbtn
            // 
            creatadminbtn.Location = new Point(687, 477);
            creatadminbtn.Name = "creatadminbtn";
            creatadminbtn.Size = new Size(154, 36);
            creatadminbtn.TabIndex = 9;
            creatadminbtn.Text = "Create ";
            creatadminbtn.UseVisualStyleBackColor = true;
            creatadminbtn.Click += creatadminbtn_Click;
            // 
            // create_new_admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(creatadminbtn);
            Controls.Add(emailtxtbx);
            Controls.Add(fullnametxtbox);
            Controls.Add(passwordtxtbx);
            Controls.Add(usernametxbx);
            Controls.Add(fullnamelb);
            Controls.Add(email);
            Controls.Add(passwordlb);
            Controls.Add(usernamelb);
            Controls.Add(Admin_signup);
            Name = "create_new_admin";
            Size = new Size(923, 597);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Admin_signup;
        private Label usernamelb;
        private Label passwordlb;
        private Label email;
        private Label fullnamelb;
        private TextBox usernametxbx;
        private TextBox passwordtxtbx;
        private TextBox fullnametxtbox;
        private TextBox emailtxtbx;
        private Button creatadminbtn;
    }
}
