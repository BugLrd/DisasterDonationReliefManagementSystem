namespace DisasterDonationReliefManagementSystem.Views
{
    partial class BaseReqView
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
            containerPnl = new Panel();
            filter = new ComboBox();
            searchBox = new TextBox();
            mainReqPnl = new FlowLayoutPanel();
            detailsPnl = new Panel();
            containerPnl.SuspendLayout();
            SuspendLayout();
            // 
            // containerPnl
            // 
            containerPnl.Controls.Add(filter);
            containerPnl.Controls.Add(searchBox);
            containerPnl.Controls.Add(mainReqPnl);
            containerPnl.Controls.Add(detailsPnl);
            containerPnl.Dock = DockStyle.Fill;
            containerPnl.Location = new Point(0, 0);
            containerPnl.Name = "containerPnl";
            containerPnl.Size = new Size(923, 597);
            containerPnl.TabIndex = 0;
            containerPnl.Paint += containerPnl_Paint;
            // 
            // filter
            // 
            filter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filter.DropDownStyle = ComboBoxStyle.DropDownList;
            filter.Font = new Font("Segoe UI", 10F);
            filter.Items.AddRange(new object[] { "Most Recent", "Oldest" });
            filter.Location = new Point(501, 11);
            filter.Name = "filter";
            filter.Size = new Size(176, 25);
            filter.TabIndex = 3;
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBox.Font = new Font("Segoe UI", 10F);
            searchBox.Location = new Point(10, 11);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search by title or type";
            searchBox.Size = new Size(472, 25);
            searchBox.TabIndex = 4;
            // 
            // mainReqPnl
            // 
            mainReqPnl.AutoScroll = true;
            mainReqPnl.FlowDirection = FlowDirection.TopDown;
            mainReqPnl.Location = new Point(3, 48);
            mainReqPnl.Name = "mainReqPnl";
            mainReqPnl.Size = new Size(917, 549);
            mainReqPnl.TabIndex = 0;
            mainReqPnl.WrapContents = false;
            mainReqPnl.Paint += mainReqPnl_Paint;
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
            // BaseReqView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(containerPnl);
            Name = "BaseReqView";
            Size = new Size(923, 597);
            Load += BaseReqView_Load;
            containerPnl.ResumeLayout(false);
            containerPnl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel containerPnl;
        public FlowLayoutPanel mainReqPnl;
        public Panel detailsPnl;
        private ComboBox filter;
        private TextBox searchBox;
    }
}
