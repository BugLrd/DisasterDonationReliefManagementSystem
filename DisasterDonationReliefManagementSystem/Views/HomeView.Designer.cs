namespace DisasterDonationReliefManagementSystem
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
        /// <param name="disposing">true if disposed; otherwise, false.</param>
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
            containerPnl = new Panel();
            mainReqPnl = new FlowLayoutPanel();
            detailsPnl = new Panel();
            containerPnl.SuspendLayout();
            SuspendLayout();
            // 
            // containerPnl
            // 
            containerPnl.Controls.Add(mainReqPnl);
            containerPnl.Controls.Add(detailsPnl);
            containerPnl.Dock = DockStyle.Fill;
            containerPnl.Location = new Point(0, 0);
            containerPnl.Name = "containerPnl";
            containerPnl.Size = new Size(923, 597);
            containerPnl.TabIndex = 0;
            // 
            // mainReqPnl
            // 
            mainReqPnl.AutoScroll = true;
            mainReqPnl.Dock = DockStyle.Left;
            mainReqPnl.FlowDirection = FlowDirection.TopDown;
            mainReqPnl.Location = new Point(0, 0);
            mainReqPnl.Name = "mainReqPnl";
            mainReqPnl.Size = new Size(923, 597);
            mainReqPnl.TabIndex = 0;
            mainReqPnl.WrapContents = false;
            // 
            // detailsPnl
            // 
            detailsPnl.BackColor = Color.White;
            detailsPnl.BorderStyle = BorderStyle.FixedSingle;
            detailsPnl.Dock = DockStyle.Right;
            detailsPnl.Location = new Point(923, 0);
            detailsPnl.Name = "detailsPnl";
            detailsPnl.Size = new Size(0, 597);
            detailsPnl.TabIndex = 1;
            detailsPnl.Visible = false;
            // 
            // HomeView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(containerPnl);
            Name = "HomeView";
            Size = new Size(923, 597);
            Load += HomeView_Load;
            containerPnl.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel containerPnl;
        private FlowLayoutPanel mainReqPnl;
        private Panel detailsPnl;
    }
}