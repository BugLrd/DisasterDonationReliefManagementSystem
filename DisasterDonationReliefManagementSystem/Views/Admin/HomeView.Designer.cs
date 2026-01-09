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
            dashBLbl = new Label();
            mainPnl.SuspendLayout();
            SuspendLayout();
            // 
            // mainPnl
            // 
            mainPnl.BackColor = SystemColors.Info;
            mainPnl.Controls.Add(dashBLbl);
            mainPnl.Dock = DockStyle.Fill;
            mainPnl.Location = new Point(0, 0);
            mainPnl.Name = "mainPnl";
            mainPnl.Size = new Size(923, 597);
            mainPnl.TabIndex = 0;
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
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPnl;
        private Label dashBLbl;
    }
}
