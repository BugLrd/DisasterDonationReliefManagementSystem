namespace DisasterDonationReliefManagementSystem.Forms
{
    partial class HomePage
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
            headerpnl = new Panel();
            logoutbtn = new Button();
            headerlbl = new Label();
            splitterlbl = new Label();
            welcomelbl = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            sidepnl = new Panel();
            creqbtn = new Button();
            urreqbtn = new Button();
            homebtn = new Button();
            panel2 = new Panel();
            mainpnl = new Panel();
            headerpnl.SuspendLayout();
            sidepnl.SuspendLayout();
            SuspendLayout();
            // 
            // headerpnl
            // 
            headerpnl.BorderStyle = BorderStyle.FixedSingle;
            headerpnl.Controls.Add(logoutbtn);
            headerpnl.Controls.Add(headerlbl);
            headerpnl.Controls.Add(splitterlbl);
            headerpnl.Controls.Add(welcomelbl);
            headerpnl.Location = new Point(1, 0);
            headerpnl.Name = "headerpnl";
            headerpnl.Size = new Size(1098, 34);
            headerpnl.TabIndex = 0;
            // 
            // logoutbtn
            // 
            logoutbtn.BackgroundImageLayout = ImageLayout.None;
            logoutbtn.Cursor = Cursors.Hand;
            logoutbtn.FlatAppearance.BorderSize = 0;
            logoutbtn.FlatStyle = FlatStyle.Flat;
            logoutbtn.Font = new Font("Segoe UI", 12F);
            logoutbtn.ForeColor = Color.Brown;
            logoutbtn.Location = new Point(1012, 0);
            logoutbtn.Name = "logoutbtn";
            logoutbtn.Size = new Size(75, 31);
            logoutbtn.TabIndex = 0;
            logoutbtn.Text = "LogOut";
            logoutbtn.UseVisualStyleBackColor = true;
            // 
            // headerlbl
            // 
            headerlbl.AutoSize = true;
            headerlbl.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            headerlbl.Location = new Point(10, 5);
            headerlbl.Name = "headerlbl";
            headerlbl.Size = new Size(86, 21);
            headerlbl.TabIndex = 0;
            headerlbl.Text = "ReliefHub";
            // 
            // splitterlbl
            // 
            splitterlbl.AutoSize = true;
            splitterlbl.Font = new Font("Segoe UI", 15F);
            splitterlbl.Location = new Point(989, -1);
            splitterlbl.Name = "splitterlbl";
            splitterlbl.Size = new Size(17, 28);
            splitterlbl.TabIndex = 0;
            splitterlbl.Text = "|";
            // 
            // welcomelbl
            // 
            welcomelbl.AutoSize = true;
            welcomelbl.Font = new Font("Segoe UI", 12F);
            welcomelbl.Location = new Point(873, 5);
            welcomelbl.Name = "welcomelbl";
            welcomelbl.Size = new Size(110, 21);
            welcomelbl.TabIndex = 0;
            welcomelbl.Text = "Welcome User";
            // 
            // sidepnl
            // 
            sidepnl.BackColor = SystemColors.ControlDarkDark;
            sidepnl.Controls.Add(creqbtn);
            sidepnl.Controls.Add(urreqbtn);
            sidepnl.Controls.Add(homebtn);
            sidepnl.Controls.Add(panel2);
            sidepnl.Location = new Point(1, 34);
            sidepnl.Name = "sidepnl";
            sidepnl.Size = new Size(168, 606);
            sidepnl.TabIndex = 1;
            // 
            // creqbtn
            // 
            creqbtn.BackColor = Color.Transparent;
            creqbtn.Cursor = Cursors.Hand;
            creqbtn.FlatAppearance.BorderSize = 0;
            creqbtn.FlatStyle = FlatStyle.Flat;
            creqbtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            creqbtn.Location = new Point(11, 76);
            creqbtn.Name = "creqbtn";
            creqbtn.Size = new Size(144, 23);
            creqbtn.TabIndex = 3;
            creqbtn.Text = "Create New Request";
            creqbtn.TextAlign = ContentAlignment.MiddleLeft;
            creqbtn.UseVisualStyleBackColor = false;
            // 
            // urreqbtn
            // 
            urreqbtn.BackColor = Color.Transparent;
            urreqbtn.Cursor = Cursors.Hand;
            urreqbtn.FlatAppearance.BorderSize = 0;
            urreqbtn.FlatStyle = FlatStyle.Flat;
            urreqbtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            urreqbtn.Location = new Point(11, 47);
            urreqbtn.Name = "urreqbtn";
            urreqbtn.Size = new Size(144, 23);
            urreqbtn.TabIndex = 3;
            urreqbtn.Text = "Your Requests";
            urreqbtn.TextAlign = ContentAlignment.MiddleLeft;
            urreqbtn.UseVisualStyleBackColor = false;
            // 
            // homebtn
            // 
            homebtn.BackColor = Color.Transparent;
            homebtn.Cursor = Cursors.Hand;
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            homebtn.ForeColor = SystemColors.ControlText;
            homebtn.Location = new Point(11, 18);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(144, 23);
            homebtn.TabIndex = 3;
            homebtn.Text = "Home";
            homebtn.TextAlign = ContentAlignment.MiddleLeft;
            homebtn.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Location = new Point(176, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(922, 603);
            panel2.TabIndex = 2;
            // 
            // mainpnl
            // 
            mainpnl.BorderStyle = BorderStyle.FixedSingle;
            mainpnl.Location = new Point(173, 39);
            mainpnl.Name = "mainpnl";
            mainpnl.Size = new Size(923, 597);
            mainpnl.TabIndex = 2;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 642);
            Controls.Add(mainpnl);
            Controls.Add(sidepnl);
            Controls.Add(headerpnl);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load;
            headerpnl.ResumeLayout(false);
            headerpnl.PerformLayout();
            sidepnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerpnl;
        private Label headerlbl;
        private Label welcomelbl;
        private Label splitterlbl;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button logoutbtn;
        private Panel sidepnl;
        private Panel panel2;
        private Button homebtn;
        private Panel mainpnl;
        private Button urreqbtn;
        private Button creqbtn;
    }
}