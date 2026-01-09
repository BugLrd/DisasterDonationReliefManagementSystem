namespace DisasterDonationReliefManagementSystem.Views.Admin
{
    partial class HomeView
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
            mainPnl = new Panel();
            listBoxDisasterReq = new ListBox();
            groupBoxuserdis = new GroupBox();
            lbdonorP = new Label();
            lbVolonP = new Label();
            lbvictimP = new Label();
            progressBardonor = new ProgressBar();
            progressBarvictim = new ProgressBar();
            progressBarvolun = new ProgressBar();
            panel6 = new Panel();
            lbinactive = new Label();
            inactive = new Label();
            panel7 = new Panel();
            panel3 = new Panel();
            rlbreqpending = new Label();
            totalreq = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            lbactiveuser = new Label();
            activeuser = new Label();
            panel4 = new Panel();
            panel1 = new Panel();
            lbpendingtitle = new Label();
            lbvaluepending = new Label();
            dashBLbl = new Label();
            mainPnl.SuspendLayout();
            groupBoxuserdis.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainPnl
            // 
            mainPnl.BackColor = SystemColors.Info;
            mainPnl.Controls.Add(listBoxDisasterReq);
            mainPnl.Controls.Add(groupBoxuserdis);
            mainPnl.Controls.Add(panel6);
            mainPnl.Controls.Add(panel3);
            mainPnl.Controls.Add(panel2);
            mainPnl.Controls.Add(panel1);
            mainPnl.Controls.Add(dashBLbl);
            mainPnl.Dock = DockStyle.Fill;
            mainPnl.Location = new Point(0, 0);
            mainPnl.Name = "mainPnl";
            mainPnl.Size = new Size(923, 597);
            mainPnl.TabIndex = 0;
            // 
            // listBoxDisasterReq
            // 
            listBoxDisasterReq.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBoxDisasterReq.FormattingEnabled = true;
            listBoxDisasterReq.Location = new Point(51, 220);
            listBoxDisasterReq.Name = "listBoxDisasterReq";
            listBoxDisasterReq.Size = new Size(442, 276);
            listBoxDisasterReq.TabIndex = 7;
            listBoxDisasterReq.SelectedIndexChanged += listBoxDisasterReq_SelectedIndexChanged;
            // 
            // groupBoxuserdis
            // 
            groupBoxuserdis.Controls.Add(lbdonorP);
            groupBoxuserdis.Controls.Add(lbVolonP);
            groupBoxuserdis.Controls.Add(lbvictimP);
            groupBoxuserdis.Controls.Add(progressBardonor);
            groupBoxuserdis.Controls.Add(progressBarvictim);
            groupBoxuserdis.Controls.Add(progressBarvolun);
            groupBoxuserdis.Location = new Point(527, 217);
            groupBoxuserdis.Name = "groupBoxuserdis";
            groupBoxuserdis.Size = new Size(363, 287);
            groupBoxuserdis.TabIndex = 6;
            groupBoxuserdis.TabStop = false;
            groupBoxuserdis.Text = "USER DRISTRIBUTION";
            // 
            // lbdonorP
            // 
            lbdonorP.Location = new Point(6, 39);
            lbdonorP.Name = "lbdonorP";
            lbdonorP.Size = new Size(56, 33);
            lbdonorP.TabIndex = 6;
            lbdonorP.Text = "DONOR 0%";
            // 
            // lbVolonP
            // 
            lbVolonP.Location = new Point(6, 203);
            lbVolonP.Name = "lbVolonP";
            lbVolonP.Size = new Size(84, 33);
            lbVolonP.TabIndex = 5;
            lbVolonP.Text = "VOLUNTEER 0%";
            lbVolonP.Click += label2_Click;
            // 
            // lbvictimP
            // 
            lbvictimP.Location = new Point(6, 123);
            lbvictimP.Name = "lbvictimP";
            lbvictimP.Size = new Size(57, 35);
            lbvictimP.TabIndex = 4;
            lbvictimP.Text = "VICTIM 0%";
            // 
            // progressBardonor
            // 
            progressBardonor.Location = new Point(106, 37);
            progressBardonor.Name = "progressBardonor";
            progressBardonor.Size = new Size(162, 35);
            progressBardonor.TabIndex = 2;
            progressBardonor.Click += progressBardonor_Click;
            // 
            // progressBarvictim
            // 
            progressBarvictim.Location = new Point(106, 122);
            progressBarvictim.Name = "progressBarvictim";
            progressBarvictim.Size = new Size(162, 33);
            progressBarvictim.TabIndex = 1;
            // 
            // progressBarvolun
            // 
            progressBarvolun.Location = new Point(106, 203);
            progressBarvolun.Name = "progressBarvolun";
            progressBarvolun.Size = new Size(162, 33);
            progressBarvolun.TabIndex = 0;
            progressBarvolun.Click += progressBar1_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gray;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(lbinactive);
            panel6.Controls.Add(inactive);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(735, 73);
            panel6.Name = "panel6";
            panel6.Size = new Size(155, 100);
            panel6.TabIndex = 3;
            // 
            // lbinactive
            // 
            lbinactive.AutoSize = true;
            lbinactive.Location = new Point(70, 56);
            lbinactive.Name = "lbinactive";
            lbinactive.Size = new Size(13, 15);
            lbinactive.TabIndex = 5;
            lbinactive.Text = "0";
            lbinactive.Click += lbinactive_Click;
            // 
            // inactive
            // 
            inactive.AutoSize = true;
            inactive.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            inactive.Location = new Point(41, 19);
            inactive.Name = "inactive";
            inactive.Size = new Size(83, 21);
            inactive.TabIndex = 4;
            inactive.Text = "INACTIVE";
            // 
            // panel7
            // 
            panel7.Location = new Point(165, 143);
            panel7.Name = "panel7";
            panel7.Size = new Size(281, 158);
            panel7.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = SystemColors.HotTrack;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(rlbreqpending);
            panel3.Controls.Add(totalreq);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(517, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 100);
            panel3.TabIndex = 3;
            // 
            // rlbreqpending
            // 
            rlbreqpending.AutoSize = true;
            rlbreqpending.Location = new Point(69, 56);
            rlbreqpending.Name = "rlbreqpending";
            rlbreqpending.Size = new Size(13, 15);
            rlbreqpending.TabIndex = 5;
            rlbreqpending.Text = "0";
            rlbreqpending.Click += rlbreqpending_Click;
            // 
            // totalreq
            // 
            totalreq.AutoSize = true;
            totalreq.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            totalreq.Location = new Point(34, 19);
            totalreq.Name = "totalreq";
            totalreq.Size = new Size(95, 21);
            totalreq.TabIndex = 4;
            totalreq.Text = "TOTAL REQ:";
            // 
            // panel5
            // 
            panel5.Location = new Point(165, 143);
            panel5.Name = "panel5";
            panel5.Size = new Size(281, 158);
            panel5.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LimeGreen;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(lbactiveuser);
            panel2.Controls.Add(activeuser);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(304, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 100);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // lbactiveuser
            // 
            lbactiveuser.AutoSize = true;
            lbactiveuser.Location = new Point(66, 56);
            lbactiveuser.Name = "lbactiveuser";
            lbactiveuser.Size = new Size(16, 15);
            lbactiveuser.TabIndex = 4;
            lbactiveuser.Text = " 0";
            // 
            // activeuser
            // 
            activeuser.AutoSize = true;
            activeuser.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            activeuser.Location = new Point(21, 19);
            activeuser.Name = "activeuser";
            activeuser.Size = new Size(109, 21);
            activeuser.TabIndex = 4;
            activeuser.Text = "ACTIVE USER";
            // 
            // panel4
            // 
            panel4.Location = new Point(165, 143);
            panel4.Name = "panel4";
            panel4.Size = new Size(281, 158);
            panel4.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(lbpendingtitle);
            panel1.Controls.Add(lbvaluepending);
            panel1.Location = new Point(83, 73);
            panel1.Name = "panel1";
            panel1.Size = new Size(167, 100);
            panel1.TabIndex = 1;
            // 
            // lbpendingtitle
            // 
            lbpendingtitle.AutoSize = true;
            lbpendingtitle.BackColor = Color.Transparent;
            lbpendingtitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbpendingtitle.Location = new Point(37, 19);
            lbpendingtitle.Name = "lbpendingtitle";
            lbpendingtitle.Size = new Size(83, 21);
            lbpendingtitle.TabIndex = 3;
            lbpendingtitle.Text = "PENDING";
            lbpendingtitle.Click += lbpendingtitle_Click;
            // 
            // lbvaluepending
            // 
            lbvaluepending.AutoSize = true;
            lbvaluepending.Location = new Point(71, 56);
            lbvaluepending.Name = "lbvaluepending";
            lbvaluepending.Size = new Size(13, 15);
            lbvaluepending.TabIndex = 4;
            lbvaluepending.Text = "0";
            // 
            // dashBLbl
            // 
            dashBLbl.BackColor = Color.Transparent;
            dashBLbl.Font = new Font("Segoe UI", 11F, FontStyle.Bold | FontStyle.Italic);
            dashBLbl.Location = new Point(37, 11);
            dashBLbl.Name = "dashBLbl";
            dashBLbl.Size = new Size(839, 33);
            dashBLbl.TabIndex = 0;
            dashBLbl.Text = "Dash Board";
            dashBLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainPnl);
            Name = "HomeView";
            Size = new Size(923, 597);
            mainPnl.ResumeLayout(false);
            groupBoxuserdis.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPnl;
        private Label dashBLbl;
        private Panel panel6;
        private Label lbinactive;
        private Label inactive;
        private Panel panel7;
        private Panel panel3;
        private Label rlbreqpending;
        private Label totalreq;
        private Panel panel5;
        private Panel panel2;
        private Label lbactiveuser;
        private Label activeuser;
        private Panel panel4;
        private Panel panel1;
        private Label lbpendingtitle;
        private Label lbvaluepending;
        private GroupBox groupBoxuserdis;
        private ProgressBar progressBar3;
        private ProgressBar progressBar2;
        private ProgressBar progressBar1;
        private ProgressBar progressBardonor;
        private ProgressBar progressBarvictim;
        private ProgressBar progressBarvolun;
        private Label lbVolonP;
        private Label lbvictimP;
        private Label lbdonorP;
        private ListBox listBoxDisasterReq;
    }
}
