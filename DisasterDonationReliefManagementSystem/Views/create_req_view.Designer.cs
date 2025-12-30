namespace DisasterDonationReliefManagementSystem.Views
{
    partial class create_req_view
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
            tilte = new Label();
            DisasterTitle = new Label();
            DisasterType = new Label();
            DisasterTitleTB = new TextBox();
            RequestedItems = new Label();
            NumberOfMembers = new Label();
            NumberOfMembersTB = new TextBox();
            LocationTB = new TextBox();
            DisastertypeCombox = new ComboBox();
            Location = new Label();
            RequestedItemsTB = new TextBox();
            Description = new Label();
            DescriptionTB = new TextBox();
            ADDbutton = new Button();
            SuspendLayout();
            // 
            // tilte
            // 
            tilte.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tilte.Location = new Point(329, 30);
            tilte.Name = "tilte";
            tilte.Size = new Size(258, 42);
            tilte.TabIndex = 0;
            tilte.Text = "Create Help Request ";
            tilte.TextAlign = ContentAlignment.TopCenter;
            // 
            // DisasterTitle
            // 
            DisasterTitle.AutoSize = true;
            DisasterTitle.Location = new Point(61, 188);
            DisasterTitle.Name = "DisasterTitle";
            DisasterTitle.Size = new Size(74, 15);
            DisasterTitle.TabIndex = 1;
            DisasterTitle.Text = "Disaster Title";
            DisasterTitle.Click += DisasterTitle_Click;
            // 
            // DisasterType
            // 
            DisasterType.AutoSize = true;
            DisasterType.Location = new Point(453, 185);
            DisasterType.Name = "DisasterType";
            DisasterType.Size = new Size(76, 15);
            DisasterType.TabIndex = 2;
            DisasterType.Text = "Disaster Type";
            DisasterType.Click += DisasterType_Click;
            // 
            // DisasterTitleTB
            // 
            DisasterTitleTB.Location = new Point(176, 186);
            DisasterTitleTB.Name = "DisasterTitleTB";
            DisasterTitleTB.Size = new Size(244, 23);
            DisasterTitleTB.TabIndex = 3;
            DisasterTitleTB.TextChanged += textBox1_TextChanged;
            // 
            // RequestedItems
            // 
            RequestedItems.AutoSize = true;
            RequestedItems.Location = new Point(453, 337);
            RequestedItems.Name = "RequestedItems";
            RequestedItems.Size = new Size(94, 15);
            RequestedItems.TabIndex = 5;
            RequestedItems.Text = "Requested Items";
            RequestedItems.Click += RequestedItems_Click;
            // 
            // NumberOfMembers
            // 
            NumberOfMembers.AutoSize = true;
            NumberOfMembers.Location = new Point(453, 266);
            NumberOfMembers.Name = "NumberOfMembers";
            NumberOfMembers.Size = new Size(120, 15);
            NumberOfMembers.TabIndex = 6;
            NumberOfMembers.Text = "Number Of Members";
            NumberOfMembers.Click += label2_Click;
            // 
            // NumberOfMembersTB
            // 
            NumberOfMembersTB.Location = new Point(587, 263);
            NumberOfMembersTB.Name = "NumberOfMembersTB";
            NumberOfMembersTB.Size = new Size(187, 23);
            NumberOfMembersTB.TabIndex = 7;
            // 
            // LocationTB
            // 
            LocationTB.Location = new Point(176, 264);
            LocationTB.Name = "LocationTB";
            LocationTB.Size = new Size(242, 23);
            LocationTB.TabIndex = 8;
            LocationTB.TextChanged += textBox4_TextChanged;
            // 
            // DisastertypeCombox
            // 
            DisastertypeCombox.FormattingEnabled = true;
            DisastertypeCombox.Items.AddRange(new object[] { "Earthquake", "Flood", "Hurricane", "Wildfire", "Drought", "Tsunami" });
            DisastertypeCombox.Location = new Point(587, 185);
            DisastertypeCombox.Name = "DisastertypeCombox";
            DisastertypeCombox.Size = new Size(187, 23);
            DisastertypeCombox.TabIndex = 9;
            // 
            // Location
            // 
            Location.AutoSize = true;
            Location.Location = new Point(61, 266);
            Location.Name = "Location";
            Location.Size = new Size(53, 15);
            Location.TabIndex = 10;
            Location.Text = "Location";
            // 
            // RequestedItemsTB
            // 
            RequestedItemsTB.Location = new Point(587, 334);
            RequestedItemsTB.Multiline = true;
            RequestedItemsTB.Name = "RequestedItemsTB";
            RequestedItemsTB.Size = new Size(237, 132);
            RequestedItemsTB.TabIndex = 11;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(61, 340);
            Description.Name = "Description";
            Description.Size = new Size(67, 15);
            Description.TabIndex = 12;
            Description.Text = "Description";
            // 
            // DescriptionTB
            // 
            DescriptionTB.Location = new Point(176, 337);
            DescriptionTB.Multiline = true;
            DescriptionTB.Name = "DescriptionTB";
            DescriptionTB.Size = new Size(238, 132);
            DescriptionTB.TabIndex = 13;
            // 
            // ADDbutton
            // 
            ADDbutton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADDbutton.ImageAlign = ContentAlignment.TopCenter;
            ADDbutton.Location = new Point(789, 185);
            ADDbutton.Name = "ADDbutton";
            ADDbutton.Size = new Size(35, 24);
            ADDbutton.TabIndex = 14;
            ADDbutton.Text = "add";
            ADDbutton.TextAlign = ContentAlignment.TopCenter;
            ADDbutton.UseVisualStyleBackColor = true;
            ADDbutton.Click += ADDbutton_Click;
            // 
            // create_req_view
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ADDbutton);
            Controls.Add(DescriptionTB);
            Controls.Add(Description);
            Controls.Add(RequestedItemsTB);
            Controls.Add(Location);
            Controls.Add(DisastertypeCombox);
            Controls.Add(LocationTB);
            Controls.Add(NumberOfMembersTB);
            Controls.Add(NumberOfMembers);
            Controls.Add(RequestedItems);
            Controls.Add(DisasterTitleTB);
            Controls.Add(DisasterType);
            Controls.Add(DisasterTitle);
            Controls.Add(tilte);
            Name = "create_req_view";
            Size = new Size(923, 597);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label tilte;
        private Label DisasterTitle;
        private Label DisasterType;
        private TextBox DisasterTitleTB;
        private Label RequestedItems;
        private Label NumberOfMembers;
        private TextBox NumberOfMembersTB;
        private TextBox LocationTB;
        private ComboBox DisastertypeCombox;
        private Label Location;
        private TextBox RequestedItemsTB;
        private Label Description;
        private TextBox DescriptionTB;
        private Button ADDbutton;
    }
}
