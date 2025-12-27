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
            welcomelbl = new Label();
            logoutbtn = new Button();
            headerlbl = new Label();
            splitterlbl = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            flpnl = new FlowLayoutPanel();
            homebtn = new Button();
            urReqBtn = new Button();
            cReqBtn = new Button();
            mngUsrsBtn = new Button();
            mngReqBtn = new Button();
            adminBtn = new Button();
            donateBtn = new Button();
            donHistBtn = new Button();
            currDelBtn = new Button();
            delHistBtn = new Button();
            mainpnl = new Panel();
            headerpnl.SuspendLayout();
            flpnl.SuspendLayout();
            SuspendLayout();
            // 
            // headerpnl
            // 
            headerpnl.BorderStyle = BorderStyle.FixedSingle;
            headerpnl.Controls.Add(welcomelbl);
            headerpnl.Controls.Add(logoutbtn);
            headerpnl.Controls.Add(headerlbl);
            headerpnl.Controls.Add(splitterlbl);
            headerpnl.Location = new Point(1, 0);
            headerpnl.Name = "headerpnl";
            headerpnl.Size = new Size(1098, 34);
            headerpnl.TabIndex = 0;
            // 
            // welcomelbl
            // 
            welcomelbl.Font = new Font("Segoe UI", 12F);
            welcomelbl.Location = new Point(594, 6);
            welcomelbl.Name = "welcomelbl";
            welcomelbl.Size = new Size(389, 21);
            welcomelbl.TabIndex = 0;
            welcomelbl.Text = "Welcome User";
            welcomelbl.TextAlign = ContentAlignment.MiddleRight;
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
            logoutbtn.Click += logoutbtn_Click;
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
            // flpnl
            // 
            flpnl.BackColor = SystemColors.ControlDarkDark;
            flpnl.Controls.Add(homebtn);
            flpnl.Controls.Add(urReqBtn);
            flpnl.Controls.Add(cReqBtn);
            flpnl.Controls.Add(mngUsrsBtn);
            flpnl.Controls.Add(mngReqBtn);
            flpnl.Controls.Add(adminBtn);
            flpnl.Controls.Add(donateBtn);
            flpnl.Controls.Add(donHistBtn);
            flpnl.Controls.Add(currDelBtn);
            flpnl.Controls.Add(delHistBtn);
            flpnl.Location = new Point(1, 35);
            flpnl.Name = "flpnl";
            flpnl.Padding = new Padding(0, 10, 0, 0);
            flpnl.Size = new Size(168, 601);
            flpnl.TabIndex = 0;
            // 
            // homebtn
            // 
            homebtn.BackColor = Color.Transparent;
            homebtn.Cursor = Cursors.Hand;
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            homebtn.ForeColor = SystemColors.ControlText;
            homebtn.Location = new Point(3, 13);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(144, 23);
            homebtn.TabIndex = 3;
            homebtn.Text = "Home";
            homebtn.TextAlign = ContentAlignment.MiddleLeft;
            homebtn.UseVisualStyleBackColor = false;
            // 
            // urReqBtn
            // 
            urReqBtn.BackColor = Color.Transparent;
            urReqBtn.Cursor = Cursors.Hand;
            urReqBtn.FlatAppearance.BorderSize = 0;
            urReqBtn.FlatStyle = FlatStyle.Flat;
            urReqBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            urReqBtn.Location = new Point(3, 42);
            urReqBtn.Name = "urReqBtn";
            urReqBtn.Size = new Size(144, 23);
            urReqBtn.TabIndex = 3;
            urReqBtn.Text = "Your Requests";
            urReqBtn.TextAlign = ContentAlignment.MiddleLeft;
            urReqBtn.UseVisualStyleBackColor = false;
            // 
            // cReqBtn
            // 
            cReqBtn.BackColor = Color.Transparent;
            cReqBtn.Cursor = Cursors.Hand;
            cReqBtn.FlatAppearance.BorderSize = 0;
            cReqBtn.FlatStyle = FlatStyle.Flat;
            cReqBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            cReqBtn.Location = new Point(3, 71);
            cReqBtn.Name = "cReqBtn";
            cReqBtn.Size = new Size(144, 23);
            cReqBtn.TabIndex = 3;
            cReqBtn.Text = "Create New Request";
            cReqBtn.TextAlign = ContentAlignment.MiddleLeft;
            cReqBtn.UseVisualStyleBackColor = false;
            // 
            // mngUsrsBtn
            // 
            mngUsrsBtn.BackColor = Color.Transparent;
            mngUsrsBtn.Cursor = Cursors.Hand;
            mngUsrsBtn.FlatAppearance.BorderSize = 0;
            mngUsrsBtn.FlatStyle = FlatStyle.Flat;
            mngUsrsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            mngUsrsBtn.Location = new Point(3, 100);
            mngUsrsBtn.Name = "mngUsrsBtn";
            mngUsrsBtn.Size = new Size(144, 23);
            mngUsrsBtn.TabIndex = 3;
            mngUsrsBtn.Text = "Manage Users";
            mngUsrsBtn.TextAlign = ContentAlignment.MiddleLeft;
            mngUsrsBtn.UseVisualStyleBackColor = false;
            // 
            // mngReqBtn
            // 
            mngReqBtn.BackColor = Color.Transparent;
            mngReqBtn.Cursor = Cursors.Hand;
            mngReqBtn.FlatAppearance.BorderSize = 0;
            mngReqBtn.FlatStyle = FlatStyle.Flat;
            mngReqBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            mngReqBtn.Location = new Point(3, 129);
            mngReqBtn.Name = "mngReqBtn";
            mngReqBtn.Size = new Size(144, 23);
            mngReqBtn.TabIndex = 3;
            mngReqBtn.Text = "Manage Requests";
            mngReqBtn.TextAlign = ContentAlignment.MiddleLeft;
            mngReqBtn.UseVisualStyleBackColor = false;
            // 
            // adminBtn
            // 
            adminBtn.BackColor = Color.Transparent;
            adminBtn.Cursor = Cursors.Hand;
            adminBtn.FlatAppearance.BorderSize = 0;
            adminBtn.FlatStyle = FlatStyle.Flat;
            adminBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            adminBtn.Location = new Point(3, 158);
            adminBtn.Name = "adminBtn";
            adminBtn.Size = new Size(144, 23);
            adminBtn.TabIndex = 3;
            adminBtn.Text = "Create New Admin";
            adminBtn.TextAlign = ContentAlignment.MiddleLeft;
            adminBtn.UseVisualStyleBackColor = false;
            // 
            // donateBtn
            // 
            donateBtn.BackColor = Color.Transparent;
            donateBtn.Cursor = Cursors.Hand;
            donateBtn.FlatAppearance.BorderSize = 0;
            donateBtn.FlatStyle = FlatStyle.Flat;
            donateBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            donateBtn.Location = new Point(3, 187);
            donateBtn.Name = "donateBtn";
            donateBtn.Size = new Size(144, 23);
            donateBtn.TabIndex = 3;
            donateBtn.Text = "Donate";
            donateBtn.TextAlign = ContentAlignment.MiddleLeft;
            donateBtn.UseVisualStyleBackColor = false;
            // 
            // donHistBtn
            // 
            donHistBtn.BackColor = Color.Transparent;
            donHistBtn.Cursor = Cursors.Hand;
            donHistBtn.FlatAppearance.BorderSize = 0;
            donHistBtn.FlatStyle = FlatStyle.Flat;
            donHistBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            donHistBtn.Location = new Point(3, 216);
            donHistBtn.Name = "donHistBtn";
            donHistBtn.Size = new Size(144, 23);
            donHistBtn.TabIndex = 3;
            donHistBtn.Text = "Donation History";
            donHistBtn.TextAlign = ContentAlignment.MiddleLeft;
            donHistBtn.UseVisualStyleBackColor = false;
            // 
            // currDelBtn
            // 
            currDelBtn.BackColor = Color.Transparent;
            currDelBtn.Cursor = Cursors.Hand;
            currDelBtn.FlatAppearance.BorderSize = 0;
            currDelBtn.FlatStyle = FlatStyle.Flat;
            currDelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            currDelBtn.Location = new Point(3, 245);
            currDelBtn.Name = "currDelBtn";
            currDelBtn.Size = new Size(144, 23);
            currDelBtn.TabIndex = 3;
            currDelBtn.Text = "Current Deliveries";
            currDelBtn.TextAlign = ContentAlignment.MiddleLeft;
            currDelBtn.UseVisualStyleBackColor = false;
            // 
            // delHistBtn
            // 
            delHistBtn.BackColor = Color.Transparent;
            delHistBtn.Cursor = Cursors.Hand;
            delHistBtn.FlatAppearance.BorderSize = 0;
            delHistBtn.FlatStyle = FlatStyle.Flat;
            delHistBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            delHistBtn.Location = new Point(3, 274);
            delHistBtn.Name = "delHistBtn";
            delHistBtn.Size = new Size(144, 23);
            delHistBtn.TabIndex = 3;
            delHistBtn.Text = "Delivey History";
            delHistBtn.TextAlign = ContentAlignment.MiddleLeft;
            delHistBtn.UseVisualStyleBackColor = false;
            // 
            // mainpnl
            // 
            mainpnl.BorderStyle = BorderStyle.FixedSingle;
            mainpnl.Location = new Point(173, 39);
            mainpnl.Name = "mainpnl";
            mainpnl.Size = new Size(923, 597);
            mainpnl.TabIndex = 2;
            mainpnl.Paint += mainpnl_Paint;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 642);
            Controls.Add(flpnl);
            Controls.Add(mainpnl);
            Controls.Add(headerpnl);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load;
            headerpnl.ResumeLayout(false);
            headerpnl.PerformLayout();
            flpnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerpnl;
        private Label headerlbl;
        private Label welcomelbl;
        private Label splitterlbl;
        private FolderBrowserDialog folderBrowserDialog1;
        private Button logoutbtn;
        private Button homebtn;
        private Panel mainpnl;
        private Button urReqBtn;
        private Button cReqBtn;
        private FlowLayoutPanel flpnl;
        private Button mngUsrsBtn;
        private Button mngReqBtn;
        private Button adminBtn;
        private Button donateBtn;
        private Button donHistBtn;
        private Button currDelBtn;
        private Button delHistBtn;
    }
}