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
            backbtn.Location = new Point(40, 488);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(194, 31);
            backbtn.TabIndex = 8;
            backbtn.Text = "Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += backbtn_Click;
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.ForestGreen;
            signupbtn.Location = new Point(354, 488);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(196, 31);
            signupbtn.TabIndex = 7;
            signupbtn.Text = "SignUp";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
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
    }
}