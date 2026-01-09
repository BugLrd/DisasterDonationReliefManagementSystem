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
            components = new System.ComponentModel.Container();
            mainPnl = new Panel();
            groupBoxuserdis = new GroupBox();
            lblvolunteer = new Label();
            progressBardonor = new ProgressBar();
            progressBarvictim = new ProgressBar();
            progressBarvolon = new ProgressBar();
            groupBoxalrt = new GroupBox();
            listBox1 = new ListBox();
            panel6 = new Panel();
            label8 = new Label();
            inactive = new Label();
            panel7 = new Panel();
            panel3 = new Panel();
            label6 = new Label();
            totalreq = new Label();
            panel5 = new Panel();
            panel2 = new Panel();
            label4 = new Label();
            activeuser = new Label();
            panel4 = new Panel();
            panel1 = new Panel();
            lbpendingtitle = new Label();
            valuepending = new Label();
            dashBLbl = new Label();
            volunteerBindingSource = new BindingSource(components);
            mainPnl.SuspendLayout();
            groupBoxuserdis.SuspendLayout();
            groupBoxalrt.SuspendLayout();
            panel6.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)volunteerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // mainPnl
            // 
            mainPnl.BackColor = SystemColors.Info;
            mainPnl.Controls.Add(groupBoxuserdis);
            mainPnl.Controls.Add(groupBoxalrt);
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
            // groupBoxuserdis
            // 
            groupBoxuserdis.Controls.Add(lblvolunteer);
            groupBoxuserdis.Controls.Add(progressBardonor);
            groupBoxuserdis.Controls.Add(progressBarvictim);
            groupBoxuserdis.Controls.Add(progressBarvolon);
            groupBoxuserdis.Location = new Point(527, 217);
            groupBoxuserdis.Name = "groupBoxuserdis";
            groupBoxuserdis.Size = new Size(363, 287);
            groupBoxuserdis.TabIndex = 6;
            groupBoxuserdis.TabStop = false;
            groupBoxuserdis.Text = "USER DRISTRIBUTION";
            // 
            // lblvolunteer
            // 
            lblvolunteer.BackColor = Color.Transparent;
            lblvolunteer.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblvolunteer.Location = new Point(106, 39);
            lblvolunteer.Name = "lblvolunteer";
            lblvolunteer.Size = new Size(162, 38);
            lblvolunteer.TabIndex = 3;
            lblvolunteer.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBardonor
            // 
            progressBardonor.Location = new Point(106, 123);
            progressBardonor.Name = "progressBardonor";
            progressBardonor.Size = new Size(162, 35);
            progressBardonor.Style = ProgressBarStyle.Continuous;
            progressBardonor.TabIndex = 2;
            // 
            // progressBarvictim
            // 
            progressBarvictim.Location = new Point(106, 209);
            progressBarvictim.Name = "progressBarvictim";
            progressBarvictim.Size = new Size(162, 27);
            progressBarvictim.Style = ProgressBarStyle.Continuous;
            progressBarvictim.TabIndex = 1;
            // 
            // progressBarvolon
            // 
            progressBarvolon.Location = new Point(106, 39);
            progressBarvolon.Name = "progressBarvolon";
            progressBarvolon.Size = new Size(162, 38);
            progressBarvolon.Style = ProgressBarStyle.Continuous;
            progressBarvolon.TabIndex = 0;
            progressBarvolon.Click += progressBar1_Click;
            // 
            // groupBoxalrt
            // 
            groupBoxalrt.BackColor = Color.Bisque;
            groupBoxalrt.Controls.Add(listBox1);
            groupBoxalrt.Location = new Point(19, 217);
            groupBoxalrt.Name = "groupBoxalrt";
            groupBoxalrt.Size = new Size(445, 287);
            groupBoxalrt.TabIndex = 5;
            groupBoxalrt.TabStop = false;
            groupBoxalrt.Text = "RECENT DESASTER ALERTS ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(31, 39);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(369, 199);
            listBox1.TabIndex = 0;
            // 
            // panel6
            // 
            panel6.BackColor = Color.Gray;
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label8);
            panel6.Controls.Add(inactive);
            panel6.Controls.Add(panel7);
            panel6.Location = new Point(735, 73);
            panel6.Name = "panel6";
            panel6.Size = new Size(155, 100);
            panel6.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 56);
            label8.Name = "label8";
            label8.Size = new Size(38, 15);
            label8.TabIndex = 5;
            label8.Text = "label8";
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
            panel3.Controls.Add(label6);
            panel3.Controls.Add(totalreq);
            panel3.Controls.Add(panel5);
            panel3.Location = new Point(517, 73);
            panel3.Name = "panel3";
            panel3.Size = new Size(155, 100);
            panel3.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(61, 56);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "label6";
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
            panel2.Controls.Add(label4);
            panel2.Controls.Add(activeuser);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(304, 73);
            panel2.Name = "panel2";
            panel2.Size = new Size(155, 100);
            panel2.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 56);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 4;
            label4.Text = "label4";
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
            panel1.Controls.Add(valuepending);
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
            // valuepending
            // 
            valuepending.AutoSize = true;
            valuepending.Location = new Point(64, 56);
            valuepending.Name = "valuepending";
            valuepending.Size = new Size(13, 15);
            valuepending.TabIndex = 4;
            valuepending.Text = "0";
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
            // volunteerBindingSource
            // 
            volunteerBindingSource.DataSource = typeof(Entities.Volunteer);
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
            groupBoxalrt.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)volunteerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPnl;
        private Label dashBLbl;
        private Panel panel6;
        private Label label8;
        private Label inactive;
        private Panel panel7;
        private Panel panel3;
        private Label label6;
        private Label totalreq;
        private Panel panel5;
        private Panel panel2;
        private Label label4;
        private Label activeuser;
        private Panel panel4;
        private Panel panel1;
        private Label lbpendingtitle;
        private Label valuepending;
        private GroupBox groupBoxuserdis;
        private ProgressBar progressBar3;
        private ProgressBar progressBar2;
        private ProgressBar progressBar1;
        private GroupBox groupBoxalrt;
        private ListBox listBox1;
        private BindingSource volunteerBindingSource;
        private ProgressBar progressBardonor;
        private ProgressBar progressBarvictim;
        private ProgressBar progressBarvolon;
        private Label lblvolunteer;
    }
}
