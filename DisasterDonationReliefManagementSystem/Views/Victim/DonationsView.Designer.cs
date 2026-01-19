namespace DisasterDonationReliefManagementSystem.Views.Victim
{
    partial class DonationsView
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
            detailsTable = new DataGridView();
            titleLbl = new Label();
            ((System.ComponentModel.ISupportInitialize)detailsTable).BeginInit();
            SuspendLayout();
            // 
            // detailsTable
            // 
            detailsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            detailsTable.Location = new Point(0, 53);
            detailsTable.Name = "detailsTable";
            detailsTable.Size = new Size(923, 541);
            detailsTable.TabIndex = 0;
            // 
            // titleLbl
            // 
            titleLbl.AutoSize = true;
            titleLbl.Font = new Font("Segoe UI", 12F);
            titleLbl.Location = new Point(345, 16);
            titleLbl.Name = "titleLbl";
            titleLbl.Size = new Size(191, 21);
            titleLbl.TabIndex = 1;
            titleLbl.Text = "Recieved Donation Details";
            // 
            // DonationsView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(titleLbl);
            Controls.Add(detailsTable);
            Name = "DonationsView";
            Size = new Size(923, 597);
            Load += DonationsView_Load;
            ((System.ComponentModel.ISupportInitialize)detailsTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView detailsTable;
        private Label titleLbl;
    }
}
