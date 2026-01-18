namespace DisasterDonationReliefManagementSystem.Views.Volunteer
{
    partial class BaseDelReqView
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
            DelReqListPnl = new FlowLayoutPanel();
            filter = new ComboBox();
            searchBox = new TextBox();
            SuspendLayout();
            // 
            // DelReqListPnl
            // 
            DelReqListPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DelReqListPnl.AutoScroll = true;
            DelReqListPnl.BackColor = SystemColors.Control;
            DelReqListPnl.BorderStyle = BorderStyle.FixedSingle;
            DelReqListPnl.FlowDirection = FlowDirection.TopDown;
            DelReqListPnl.Location = new Point(0, 51);
            DelReqListPnl.Margin = new Padding(0);
            DelReqListPnl.Name = "DelReqListPnl";
            DelReqListPnl.Size = new Size(924, 544);
            DelReqListPnl.TabIndex = 1;
            DelReqListPnl.WrapContents = false;
            // 
            // filter
            // 
            filter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filter.BackColor = Color.DimGray;
            filter.DropDownStyle = ComboBoxStyle.DropDownList;
            filter.Font = new Font("Segoe UI", 10F);
            filter.Items.AddRange(new object[] { "Most Recent", "Oldest" });
            filter.Location = new Point(343, 11);
            filter.Name = "filter";
            filter.Size = new Size(180, 25);
            filter.TabIndex = 3;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBox.Font = new Font("Segoe UI", 10F);
            searchBox.Location = new Point(11, 11);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search by location...";
            searchBox.Size = new Size(320, 25);
            searchBox.TabIndex = 4;
            // 
            // BaseDelReqView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DelReqListPnl);
            Controls.Add(filter);
            Controls.Add(searchBox);
            Name = "BaseDelReqView";
            Size = new Size(923, 597);
            Load += BaseDelReqView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel DelReqListPnl;
        private ComboBox filter;
        private TextBox searchBox;
    }
}
