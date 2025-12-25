namespace DisasterDonationReliefManagementSystem
{
    partial class LogInPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            unametf = new TextBox();
            unamelbl = new Label();
            label2 = new Label();
            passlbl = new Label();
            passtf = new TextBox();
            loginbtn = new Button();
            logInlbl = new Label();
            createbtn = new Button();
            backbtn = new Button();
            SuspendLayout();
            // 
            // unametf
            // 
            unametf.Font = new Font("Segoe UI", 12F);
            unametf.Location = new Point(738, 214);
            unametf.Name = "unametf";
            unametf.PlaceholderText = "enter your username or email";
            unametf.Size = new Size(253, 29);
            unametf.TabIndex = 2;
            // 
            // unamelbl
            // 
            unamelbl.AutoSize = true;
            unamelbl.BackColor = Color.Transparent;
            unamelbl.Font = new Font("Segoe UI", 12F);
            unamelbl.Location = new Point(636, 217);
            unamelbl.Name = "unamelbl";
            unamelbl.Size = new Size(88, 21);
            unamelbl.TabIndex = 0;
            unamelbl.Text = "Username: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(554, 249);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 0;
            // 
            // passlbl
            // 
            passlbl.AutoSize = true;
            passlbl.BackColor = Color.Transparent;
            passlbl.Font = new Font("Segoe UI", 12F);
            passlbl.Location = new Point(636, 275);
            passlbl.Name = "passlbl";
            passlbl.Size = new Size(83, 21);
            passlbl.TabIndex = 0;
            passlbl.Text = "Password: ";
            // 
            // passtf
            // 
            passtf.Font = new Font("Segoe UI", 12F);
            passtf.Location = new Point(738, 272);
            passtf.Name = "passtf";
            passtf.PasswordChar = '*';
            passtf.PlaceholderText = "enter your password";
            passtf.Size = new Size(253, 29);
            passtf.TabIndex = 3;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = SystemColors.HotTrack;
            loginbtn.Location = new Point(636, 346);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(355, 33);
            loginbtn.TabIndex = 4;
            loginbtn.Text = "LogIn";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += loginbtn_Click;
            // 
            // logInlbl
            // 
            logInlbl.AutoSize = true;
            logInlbl.BackColor = Color.Transparent;
            logInlbl.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            logInlbl.Location = new Point(669, 117);
            logInlbl.Name = "logInlbl";
            logInlbl.Size = new Size(266, 37);
            logInlbl.TabIndex = 0;
            logInlbl.Text = "Log In to ReliefHub";
            // 
            // createbtn
            // 
            createbtn.BackColor = Color.ForestGreen;
            createbtn.Location = new Point(636, 389);
            createbtn.Name = "createbtn";
            createbtn.Size = new Size(355, 33);
            createbtn.TabIndex = 5;
            createbtn.Text = "SignUp";
            createbtn.UseVisualStyleBackColor = false;
            createbtn.Click += SignUpBtn_Click;
            // 
            // backbtn
            // 
            backbtn.BackColor = SystemColors.GrayText;
            backbtn.Location = new Point(636, 428);
            backbtn.Name = "backbtn";
            backbtn.Size = new Size(355, 33);
            backbtn.TabIndex = 6;
            backbtn.Text = "<- Back";
            backbtn.UseVisualStyleBackColor = false;
            backbtn.Click += BackBtn_Click;
            // 
            // LogInPage
            // 
            AcceptButton = loginbtn;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            CausesValidation = false;
            ClientSize = new Size(1110, 601);
            Controls.Add(logInlbl);
            Controls.Add(backbtn);
            Controls.Add(createbtn);
            Controls.Add(loginbtn);
            Controls.Add(passlbl);
            Controls.Add(label2);
            Controls.Add(unamelbl);
            Controls.Add(passtf);
            Controls.Add(unametf);
            Name = "LogInPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LogInPage";
            Load += LogInPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox unametf;
        private Label unamelbl;
        private Label label2;
        private Label passlbl;
        private TextBox passtf;
        private Button loginbtn;
        private Label logInlbl;
        private Button createbtn;
        private Button backbtn;
    }
}
