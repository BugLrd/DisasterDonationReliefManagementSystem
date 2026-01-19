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
            sideBarPnl = new FlowLayoutPanel();
            homebtn = new Button();
            urReqBtn = new Button();
            mngUsrsBtn = new Button();
            mngReqBtn = new Button();
            penReqBtn = new Button();
            cReqBtn = new Button();
            donationsBtn = new Button();
            donHistBtn = new Button();
            currDelBtn = new Button();
            delHistBtn = new Button();
            adminBtn = new Button();
            mainpnl = new Panel();
            headerpnl.SuspendLayout();
            sideBarPnl.SuspendLayout();
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
            // sideBarPnl
            // 
            sideBarPnl.BackColor = Color.FromArgb(43, 47, 51);
            sideBarPnl.Controls.Add(homebtn);
            sideBarPnl.Controls.Add(urReqBtn);
            sideBarPnl.Controls.Add(mngUsrsBtn);
            sideBarPnl.Controls.Add(mngReqBtn);
            sideBarPnl.Controls.Add(penReqBtn);
            sideBarPnl.Controls.Add(cReqBtn);
            sideBarPnl.Controls.Add(donationsBtn);
            sideBarPnl.Controls.Add(donHistBtn);
            sideBarPnl.Controls.Add(currDelBtn);
            sideBarPnl.Controls.Add(delHistBtn);
            sideBarPnl.Controls.Add(adminBtn);
            sideBarPnl.Location = new Point(1, 35);
            sideBarPnl.Name = "sideBarPnl";
            sideBarPnl.Padding = new Padding(0, 10, 0, 0);
            sideBarPnl.Size = new Size(168, 601);
            sideBarPnl.TabIndex = 0;
            // 
            // homebtn
            // 
            homebtn.BackColor = Color.Transparent;
            homebtn.Cursor = Cursors.Hand;
            homebtn.FlatAppearance.BorderSize = 0;
            homebtn.FlatStyle = FlatStyle.Flat;
            homebtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            homebtn.ForeColor = SystemColors.ButtonFace;
            homebtn.Location = new Point(3, 13);
            homebtn.Name = "homebtn";
            homebtn.Size = new Size(144, 23);
            homebtn.TabIndex = 3;
            homebtn.Text = "Home";
            homebtn.TextAlign = ContentAlignment.MiddleLeft;
            homebtn.UseVisualStyleBackColor = false;
            homebtn.Click += homebtn_Click;
            // 
            // urReqBtn
            // 
            urReqBtn.BackColor = Color.Transparent;
            urReqBtn.Cursor = Cursors.Hand;
            urReqBtn.FlatAppearance.BorderSize = 0;
            urReqBtn.FlatStyle = FlatStyle.Flat;
            urReqBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            urReqBtn.ForeColor = SystemColors.ButtonFace;
            urReqBtn.Location = new Point(3, 42);
            urReqBtn.Name = "urReqBtn";
            urReqBtn.Size = new Size(144, 23);
            urReqBtn.TabIndex = 3;
            urReqBtn.Text = "Your Requests";
            urReqBtn.TextAlign = ContentAlignment.MiddleLeft;
            urReqBtn.UseVisualStyleBackColor = false;
            urReqBtn.Click += urReqBtn_Click;
            // 
            // mngUsrsBtn
            // 
            mngUsrsBtn.BackColor = Color.Transparent;
            mngUsrsBtn.Cursor = Cursors.Hand;
            mngUsrsBtn.FlatAppearance.BorderSize = 0;
            mngUsrsBtn.FlatStyle = FlatStyle.Flat;
            mngUsrsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            mngUsrsBtn.ForeColor = SystemColors.ButtonFace;
            mngUsrsBtn.Location = new Point(3, 71);
            mngUsrsBtn.Name = "mngUsrsBtn";
            mngUsrsBtn.Size = new Size(144, 23);
            mngUsrsBtn.TabIndex = 3;
            mngUsrsBtn.Text = "Manage Users";
            mngUsrsBtn.TextAlign = ContentAlignment.MiddleLeft;
            mngUsrsBtn.UseVisualStyleBackColor = false;
            mngUsrsBtn.Click += mngUsrsBtn_Click;
            // 
            // mngReqBtn
            // 
            mngReqBtn.BackColor = Color.Transparent;
            mngReqBtn.Cursor = Cursors.Hand;
            mngReqBtn.FlatAppearance.BorderSize = 0;
            mngReqBtn.FlatStyle = FlatStyle.Flat;
            mngReqBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            mngReqBtn.ForeColor = SystemColors.ButtonFace;
            mngReqBtn.Location = new Point(3, 100);
            mngReqBtn.Name = "mngReqBtn";
            mngReqBtn.Size = new Size(144, 23);
            mngReqBtn.TabIndex = 3;
            mngReqBtn.Text = "Manage Requests";
            mngReqBtn.TextAlign = ContentAlignment.MiddleLeft;
            mngReqBtn.UseVisualStyleBackColor = false;
            mngReqBtn.Click += mngReqBtn_Click;
            // 
            // penReqBtn
            // 
            penReqBtn.BackColor = Color.Transparent;
            penReqBtn.Cursor = Cursors.Hand;
            penReqBtn.FlatAppearance.BorderSize = 0;
            penReqBtn.FlatStyle = FlatStyle.Flat;
            penReqBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            penReqBtn.ForeColor = SystemColors.ButtonFace;
            penReqBtn.Location = new Point(3, 129);
            penReqBtn.Name = "penReqBtn";
            penReqBtn.Size = new Size(144, 23);
            penReqBtn.TabIndex = 3;
            penReqBtn.Text = "Pending Requests";
            penReqBtn.TextAlign = ContentAlignment.MiddleLeft;
            penReqBtn.UseVisualStyleBackColor = false;
            penReqBtn.Click += penReqBtn_Click;
            // 
            // cReqBtn
            // 
            cReqBtn.BackColor = Color.Transparent;
            cReqBtn.Cursor = Cursors.Hand;
            cReqBtn.FlatAppearance.BorderSize = 0;
            cReqBtn.FlatStyle = FlatStyle.Flat;
            cReqBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            cReqBtn.ForeColor = SystemColors.ButtonFace;
            cReqBtn.Location = new Point(3, 158);
            cReqBtn.Name = "cReqBtn";
            cReqBtn.Size = new Size(144, 23);
            cReqBtn.TabIndex = 3;
            cReqBtn.Text = "Create New Request";
            cReqBtn.TextAlign = ContentAlignment.MiddleLeft;
            cReqBtn.UseVisualStyleBackColor = false;
            cReqBtn.Click += cReqBtn_Click;
            // 
            // donationsBtn
            // 
            donationsBtn.BackColor = Color.Transparent;
            donationsBtn.Cursor = Cursors.Hand;
            donationsBtn.FlatAppearance.BorderSize = 0;
            donationsBtn.FlatStyle = FlatStyle.Flat;
            donationsBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            donationsBtn.ForeColor = SystemColors.ButtonFace;
            donationsBtn.Location = new Point(3, 187);
            donationsBtn.Name = "donationsBtn";
            donationsBtn.Size = new Size(144, 23);
            donationsBtn.TabIndex = 3;
            donationsBtn.Text = "Donations";
            donationsBtn.TextAlign = ContentAlignment.MiddleLeft;
            donationsBtn.UseVisualStyleBackColor = false;
            donationsBtn.Click += donationsBtn_Click;
            // 
            // donHistBtn
            // 
            donHistBtn.BackColor = Color.Transparent;
            donHistBtn.Cursor = Cursors.Hand;
            donHistBtn.FlatAppearance.BorderSize = 0;
            donHistBtn.FlatStyle = FlatStyle.Flat;
            donHistBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            donHistBtn.ForeColor = SystemColors.ButtonFace;
            donHistBtn.Location = new Point(3, 216);
            donHistBtn.Name = "donHistBtn";
            donHistBtn.Size = new Size(144, 23);
            donHistBtn.TabIndex = 3;
            donHistBtn.Text = "Donation History";
            donHistBtn.TextAlign = ContentAlignment.MiddleLeft;
            donHistBtn.UseVisualStyleBackColor = false;
            donHistBtn.Click += donHistBtn_Click;
            // 
            // currDelBtn
            // 
            currDelBtn.BackColor = Color.Transparent;
            currDelBtn.Cursor = Cursors.Hand;
            currDelBtn.FlatAppearance.BorderSize = 0;
            currDelBtn.FlatStyle = FlatStyle.Flat;
            currDelBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            currDelBtn.ForeColor = SystemColors.ButtonFace;
            currDelBtn.Location = new Point(3, 245);
            currDelBtn.Name = "currDelBtn";
            currDelBtn.Size = new Size(144, 23);
            currDelBtn.TabIndex = 3;
            currDelBtn.Text = "Current Deliveries";
            currDelBtn.TextAlign = ContentAlignment.MiddleLeft;
            currDelBtn.UseVisualStyleBackColor = false;
            currDelBtn.Click += currDelBtn_Click;
            // 
            // delHistBtn
            // 
            delHistBtn.BackColor = Color.Transparent;
            delHistBtn.Cursor = Cursors.Hand;
            delHistBtn.FlatAppearance.BorderSize = 0;
            delHistBtn.FlatStyle = FlatStyle.Flat;
            delHistBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            delHistBtn.ForeColor = SystemColors.ButtonFace;
            delHistBtn.Location = new Point(3, 274);
            delHistBtn.Name = "delHistBtn";
            delHistBtn.Size = new Size(144, 23);
            delHistBtn.TabIndex = 3;
            delHistBtn.Text = "Delivey History";
            delHistBtn.TextAlign = ContentAlignment.MiddleLeft;
            delHistBtn.UseVisualStyleBackColor = false;
            delHistBtn.Click += delHistBtn_Click;
            // 
            // adminBtn
            // 
            adminBtn.BackColor = Color.Transparent;
            adminBtn.Cursor = Cursors.Hand;
            adminBtn.FlatAppearance.BorderSize = 0;
            adminBtn.FlatStyle = FlatStyle.Flat;
            adminBtn.Font = new Font("Segoe UI", 9F, FontStyle.Underline);
            adminBtn.ForeColor = SystemColors.ButtonFace;
            adminBtn.Location = new Point(3, 303);
            adminBtn.Name = "adminBtn";
            adminBtn.Size = new Size(144, 23);
            adminBtn.TabIndex = 3;
            adminBtn.Text = "Create New Admin";
            adminBtn.TextAlign = ContentAlignment.MiddleLeft;
            adminBtn.UseVisualStyleBackColor = false;
            adminBtn.Click += adminBtn_Click;
            // 
            // mainpnl
            // 
            mainpnl.BorderStyle = BorderStyle.FixedSingle;
            mainpnl.Location = new Point(172, 37);
            mainpnl.Name = "mainpnl";
            mainpnl.Size = new Size(924, 599);
            mainpnl.TabIndex = 1;
            mainpnl.Paint += mainpnl_Paint;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 642);
            Controls.Add(mainpnl);
            Controls.Add(sideBarPnl);
            Controls.Add(headerpnl);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            Load += HomePage_Load;
            headerpnl.ResumeLayout(false);
            headerpnl.PerformLayout();
            sideBarPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel headerpnl;
        private Label headerlbl;
        private Label welcomelbl;
        private Label splitterlbl;
        private Button logoutbtn;
        private Button homebtn;
        private Button urReqBtn;
        private Button cReqBtn;
        private FlowLayoutPanel sideBarPnl;
        private Button mngUsrsBtn;
        private Button mngReqBtn;
        private Button adminBtn;
        private Button donationsBtn;
        private Button donHistBtn;
        private Button currDelBtn;
        private Button delHistBtn;
        private Panel mainpnl;
        private Button penReqBtn;
    }
}