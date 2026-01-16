namespace DisasterDonationReliefManagementSystem.Views.Donator
{
    partial class DonationHistoryView
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
            filter = new ComboBox();
            mainPnl = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // filter
            // 
            filter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filter.DropDownStyle = ComboBoxStyle.DropDownList;
            filter.Font = new Font("Segoe UI", 10F);
            filter.Items.AddRange(new object[] { "All", "Pending", "In Transit", "Delivered" });
            filter.SelectedIndex = 0;
            filter.Location = new Point(3, 10);
            filter.Name = "filter";
            filter.Size = new Size(176, 25);
            filter.TabIndex = 5;
            // 
            // mainPnl
            // 
            mainPnl.Location = new Point(3, 41);
            mainPnl.Name = "mainPnl";
            mainPnl.Size = new Size(917, 553);
            mainPnl.AutoScroll = true;
            mainPnl.TabIndex = 6;
            // 
            // DonationHistoryView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(mainPnl);
            Controls.Add(filter);
            Name = "DonationHistoryView";
            Size = new Size(923, 597);
            Load += DonationHistoryView_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox filter;
        private FlowLayoutPanel mainPnl;
    }
}
