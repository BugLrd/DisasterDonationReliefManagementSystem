namespace DisasterDonationReliefManagementSystem.Views.Admin
{
    partial class ManageUserView
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
            searchBox = new TextBox();
            filter = new ComboBox();
            userListPnl = new FlowLayoutPanel();
            roleFilter = new ComboBox();
            SuspendLayout();
            // 
            // searchBox
            // 
            searchBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            searchBox.Font = new Font("Segoe UI", 10F);
            searchBox.Location = new Point(12, 12);
            searchBox.Name = "searchBox";
            searchBox.PlaceholderText = "Search by name or username...";
            searchBox.Size = new Size(320, 25);
            searchBox.TabIndex = 0;
            // 
            // filter
            // 
            filter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            filter.DropDownStyle = ComboBoxStyle.DropDownList;
            filter.Font = new Font("Segoe UI", 10F);
            filter.Items.AddRange(new object[] { "All", "Active", "Inactive" });
            filter.Location = new Point(344, 12);
            filter.Name = "filter";
            filter.Size = new Size(180, 25);
            filter.TabIndex = 0;
            // 
            // userListPnl
            // 
            userListPnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            userListPnl.AutoScroll = true;
            userListPnl.BackColor = SystemColors.Control;
            userListPnl.BorderStyle = BorderStyle.FixedSingle;
            userListPnl.FlowDirection = FlowDirection.TopDown;
            userListPnl.Location = new Point(12, 52);
            userListPnl.Margin = new Padding(0);
            userListPnl.Name = "userListPnl";
            userListPnl.Size = new Size(911, 544);
            userListPnl.TabIndex = 0;
            userListPnl.WrapContents = false;
            userListPnl.Paint += userListPnl_Paint;
            // 
            // roleFilter
            // 
            roleFilter.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            roleFilter.DropDownStyle = ComboBoxStyle.DropDownList;
            roleFilter.Font = new Font("Segoe UI", 10F);
            roleFilter.Items.AddRange(new object[] { "All", "Admin", "Victim", "Donator", "Volunteer" });
            roleFilter.Location = new Point(540, 12);
            roleFilter.Name = "roleFilter";
            roleFilter.Size = new Size(180, 25);
            roleFilter.TabIndex = 0;
            // 
            // ManageUserView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(userListPnl);
            Controls.Add(roleFilter);
            Controls.Add(filter);
            Controls.Add(searchBox);
            Name = "ManageUserView";
            Size = new Size(923, 597);
            Load += ManageUserView_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox searchBox;
        private ComboBox filter;
        private FlowLayoutPanel userListPnl;
        private ComboBox roleFilter;
    }
}
