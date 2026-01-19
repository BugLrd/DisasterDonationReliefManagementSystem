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
            backbtn = new Button();
            signupbtn = new Button();
            lnametb = new TextBox();
            fnametb = new TextBox();
            unametb = new TextBox();
            confirmPasstb = new TextBox();
            passtb = new TextBox();
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
            // 
            // backbtn
            // 
            backbtn.BackColor = SystemColors.ControlDarkDark;
            backbtn.Location = new Point(45, 441);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(194, 31);
            backbtn.TabIndex = 1;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.ForestGreen;
            signupbtn.Location = new Point(357, 441);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(196, 31);
            signupbtn.TabIndex = 9;
            signupbtn.Text = "SignUp";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            // 
            // lnametb
            // 
            lnametb.Font = new Font("Segoe UI", 11F);
            lnametb.Location = new Point(127, 155);
            lnametb.Name = "lnametb";
            lnametb.PlaceholderText = "Last Name";
            lnametb.Size = new Size(292, 27);
            lnametb.TabIndex = 3;
            lnametb.TextChanged += lnametb_TextChanged;
            // 
            // fnametb
            // 
            fnametb.CausesValidation = false;
            fnametb.Font = new Font("Segoe UI", 11F);
            fnametb.Location = new Point(127, 108);
            fnametb.Name = "fnametb";
            fnametb.PlaceholderText = "First Name";
            fnametb.Size = new Size(292, 27);
            fnametb.TabIndex = 2;
            // 
            // unametb
            // 
            unametb.Font = new Font("Segoe UI", 11F);
            unametb.Location = new Point(127, 202);
            unametb.Name = "unametb";
            unametb.PlaceholderText = "Username";
            unametb.Size = new Size(292, 27);
            unametb.TabIndex = 4;
            // 
            // confirmPasstb
            // 
            confirmPasstb.Font = new Font("Segoe UI", 11F);
            confirmPasstb.Location = new Point(127, 296);
            confirmPasstb.Name = "confirmPasstb";
            confirmPasstb.PasswordChar = '*';
            confirmPasstb.PlaceholderText = "Confirm Password";
            confirmPasstb.Size = new Size(292, 27);
            confirmPasstb.TabIndex = 6;
            // 
            // passtb
            // 
            passtb.Font = new Font("Segoe UI", 11F);
            passtb.Location = new Point(127, 249);
            passtb.Name = "passtb";
            passtb.PasswordChar = '*';
            passtb.PlaceholderText = "Password";
            passtb.Size = new Size(292, 27);
            passtb.TabIndex = 5;
            // 
            // SignUp
            // 
            AcceptButton = signupbtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SignUpBg;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(767, 563);
            Controls.Add(confirmPasstb);
            Controls.Add(passtb);
            Controls.Add(unametb);
            Controls.Add(lnametb);
            Controls.Add(fnametb);
            Controls.Add(signupbtn);
            Controls.Add(backbtn);
            Controls.Add(textlbl);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label textlbl;
        private Button backbtn;
        private Button signupbtn;
        private TextBox lnametb;
        private TextBox fnametb;
        private TextBox unametb;
        private TextBox confirmPasstb;
        private TextBox passtb;
    }
}