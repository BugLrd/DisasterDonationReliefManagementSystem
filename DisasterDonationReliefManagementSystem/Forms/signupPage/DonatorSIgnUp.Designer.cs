namespace DisasterDonationReliefManagementSystem.Forms.signupPage
{
    partial class DonatorSIgnUp
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
            phntxtbx = new TextBox();
            AddressTxtbx = new TextBox();
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
            // phntxtbx
            // 
            phntxtbx.Font = new Font("Segoe UI", 11F);
            phntxtbx.Location = new Point(127, 343);
            phntxtbx.Name = "phntxtbx";
            phntxtbx.PlaceholderText = "Phone";
            phntxtbx.Size = new Size(292, 27);
            phntxtbx.TabIndex = 19;
            // 
            // AddressTxtbx
            // 
            AddressTxtbx.Font = new Font("Segoe UI", 11F);
            AddressTxtbx.Location = new Point(127, 390);
            AddressTxtbx.Name = "AddressTxtbx";
            AddressTxtbx.PlaceholderText = "Address";
            AddressTxtbx.Size = new Size(292, 27);
            AddressTxtbx.TabIndex = 15;
            // 
            // DonatorSIgnUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.SignUpBg;
            ClientSize = new Size(1092, 586);
            Controls.Add(phntxtbx);
            Controls.Add(AddressTxtbx);
            Name = "DonatorSIgnUp";
            Text = "DonatorSIgnUp";
            Load += DonatorSIgnUp_Load;
            Controls.SetChildIndex(AddressTxtbx, 0);
            Controls.SetChildIndex(phntxtbx, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textlbl;
        private Button backbtn;
        private Button signupbtn;
        private TextBox phntxtbx;
        private TextBox AddressTxtbx;
    }
}