namespace DisasterDonationReliefManagementSystem.Forms.signupPage
{
    partial class VolunteerSignUp
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
            flname = new TextBox();
            unametb = new TextBox();
            passtb = new TextBox();
            confirmPasstb = new TextBox();
            phntb = new TextBox();
            vehicleType = new TextBox();
            signupbtn = new Button();
            backbtn = new Button();
            SuspendLayout();
            // 
            // textlbl
            // 
            textlbl.AutoSize = true;
            textlbl.BackColor = Color.Transparent;
            textlbl.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            textlbl.Location = new Point(48, 37);
            textlbl.Name = "textlbl";
            textlbl.Size = new Size(246, 31);
            textlbl.TabIndex = 17;
            textlbl.Text = "Sign Up on ReliefHub";
            // 
            // flname
            // 
            flname.CausesValidation = false;
            flname.Font = new Font("Segoe UI", 11F);
            flname.Location = new Point(48, 100);
            flname.Name = "flname";
            flname.PlaceholderText = "Full Name ";
            flname.Size = new Size(292, 27);
            flname.TabIndex = 2;
            // 
            // unametb
            // 
            unametb.Font = new Font("Segoe UI", 11F);
            unametb.Location = new Point(48, 152);
            unametb.Name = "unametb";
            unametb.PlaceholderText = "Username";
            unametb.Size = new Size(292, 27);
            unametb.TabIndex = 3;
            // 
            // passtb
            // 
            passtb.Font = new Font("Segoe UI", 11F);
            passtb.Location = new Point(48, 198);
            passtb.Name = "passtb";
            passtb.PasswordChar = '*';
            passtb.PlaceholderText = "Password";
            passtb.Size = new Size(292, 27);
            passtb.TabIndex = 4;
            passtb.TextChanged += passtb_TextChanged;
            // 
            // confirmPasstb
            // 
            confirmPasstb.Font = new Font("Segoe UI", 11F);
            confirmPasstb.Location = new Point(48, 249);
            confirmPasstb.Name = "confirmPasstb";
            confirmPasstb.PasswordChar = '*';
            confirmPasstb.PlaceholderText = "Confirm Password";
            confirmPasstb.Size = new Size(292, 27);
            confirmPasstb.TabIndex = 5;
            confirmPasstb.TextChanged += confirmPasstb_TextChanged;
            // 
            // phntb
            // 
            phntb.CausesValidation = false;
            phntb.Font = new Font("Segoe UI", 11F);
            phntb.Location = new Point(48, 344);
            phntb.Name = "phntb";
            phntb.PlaceholderText = "Phone Number ";
            phntb.Size = new Size(292, 27);
            phntb.TabIndex = 7;
            // 
            // vehicleType
            // 
            vehicleType.CausesValidation = false;
            vehicleType.Font = new Font("Segoe UI", 11F);
            vehicleType.Location = new Point(48, 295);
            vehicleType.Name = "vehicleType";
            vehicleType.PlaceholderText = "Vehicle Type";
            vehicleType.Size = new Size(292, 27);
            vehicleType.TabIndex = 6;
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.ForestGreen;
            signupbtn.Location = new Point(293, 432);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(196, 31);
            signupbtn.TabIndex = 8;
            signupbtn.Text = "SignUp";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            // 
            // backbtn
            // 
            backbtn.BackColor = SystemColors.ControlDarkDark;
            backbtn.Location = new Point(34, 432);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(194, 31);
            backbtn.TabIndex = 1;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // VolunteerSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SignUpBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 508);
            Controls.Add(backbtn);
            Controls.Add(signupbtn);
            Controls.Add(vehicleType);
            Controls.Add(phntb);
            Controls.Add(confirmPasstb);
            Controls.Add(passtb);
            Controls.Add(unametb);
            Controls.Add(flname);
            Controls.Add(textlbl);
            Name = "VolunteerSignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "VolunteerSignUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textlbl;
        private TextBox flname;
        private TextBox unametb;
        private TextBox passtb;
        private TextBox confirmPasstb;
        private TextBox phntb;
        private TextBox vehicleType;
        private Button signupbtn;
        private Button backbtn;
    }
}