namespace DisasterDonationReliefManagementSystem.Forms.cards
{
    partial class User_card
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
            usercard = new Label();
            Xusername = new Label();
            Xfullname = new Label();
            Xphone = new Label();
            Xstatus = new Label();
            xRole = new Label();
            label7 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // usercard
            // 
            usercard.AutoSize = true;
            usercard.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            usercard.Location = new Point(139, 28);
            usercard.Name = "usercard";
            usercard.Size = new Size(142, 40);
            usercard.TabIndex = 0;
            usercard.Text = "User Card";
            // 
            // Xusername
            // 
            Xusername.AutoSize = true;
            Xusername.Location = new Point(272, 139);
            Xusername.Name = "Xusername";
            Xusername.Size = new Size(63, 15);
            Xusername.TabIndex = 1;
            Xusername.Text = "Username ";
            // 
            // Xfullname
            // 
            Xfullname.AutoSize = true;
            Xfullname.Location = new Point(272, 218);
            Xfullname.Name = "Xfullname";
            Xfullname.Size = new Size(61, 15);
            Xfullname.TabIndex = 2;
            Xfullname.Text = "Full Name";
            // 
            // Xphone
            // 
            Xphone.AutoSize = true;
            Xphone.Location = new Point(272, 293);
            Xphone.Name = "Xphone";
            Xphone.Size = new Size(88, 15);
            Xphone.TabIndex = 3;
            Xphone.Text = "Phone Number";
            // 
            // Xstatus
            // 
            Xstatus.AutoSize = true;
            Xstatus.Location = new Point(272, 368);
            Xstatus.Name = "Xstatus";
            Xstatus.Size = new Size(39, 15);
            Xstatus.TabIndex = 4;
            Xstatus.Text = "Status";
            // 
            // xRole
            // 
            xRole.AutoSize = true;
            xRole.Location = new Point(272, 441);
            xRole.Name = "xRole";
            xRole.Size = new Size(30, 15);
            xRole.TabIndex = 5;
            xRole.Text = "Role";
            xRole.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(272, 526);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "label7";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HotTrack;
            label1.Location = new Point(62, 139);
            label1.Name = "label1";
            label1.Size = new Size(79, 20);
            label1.TabIndex = 7;
            label1.Text = "Username ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(64, 218);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 8;
            label2.Text = "Full Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.ForeColor = SystemColors.HotTrack;
            label3.Location = new Point(61, 293);
            label3.Name = "label3";
            label3.Size = new Size(108, 20);
            label3.TabIndex = 9;
            label3.Text = "Phone Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F);
            label4.ForeColor = SystemColors.HotTrack;
            label4.Location = new Point(62, 368);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 10;
            label4.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F);
            label5.ForeColor = SystemColors.HotTrack;
            label5.Location = new Point(64, 441);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 11;
            label5.Text = "Role";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F);
            label6.ForeColor = SystemColors.HotTrack;
            label6.Location = new Point(64, 526);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 12;
            label6.Text = "label6";
            // 
            // User_card
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 628);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label7);
            Controls.Add(xRole);
            Controls.Add(Xstatus);
            Controls.Add(Xphone);
            Controls.Add(Xfullname);
            Controls.Add(Xusername);
            Controls.Add(usercard);
            Name = "User_card";
            StartPosition = FormStartPosition.CenterParent;
            Text = "User_card";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label usercard;
        private Label Xusername;
        private Label Xfullname;
        private Label Xphone;
        private Label Xstatus;
        private Label xRole;
        private Label label7;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}