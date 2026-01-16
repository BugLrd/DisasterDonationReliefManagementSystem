namespace DisasterDonationReliefManagementSystem.Forms.cards
{
    partial class Donation_details
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            donationtype_lb = new Label();
            Itemdetails_lb = new Label();
            deliveryLoc_lb = new Label();
            pirckupLoc_lb = new Label();
            Disastertile_bt = new Button();
            SuspendLayout();
            // 
            // donationtype_lb
            // 
            donationtype_lb.AutoSize = true;
            donationtype_lb.Location = new Point(85, 175);
            donationtype_lb.Name = "donationtype_lb";
            donationtype_lb.Size = new Size(87, 15);
            donationtype_lb.TabIndex = 0;
            donationtype_lb.Text = "Donation Type:";
            // 
            // Itemdetails_lb
            // 
            Itemdetails_lb.AutoSize = true;
            Itemdetails_lb.Location = new Point(85, 233);
            Itemdetails_lb.Name = "Itemdetails_lb";
            Itemdetails_lb.Size = new Size(81, 15);
            Itemdetails_lb.TabIndex = 1;
            Itemdetails_lb.Text = "Iteam Details: ";
            // 
            // deliveryLoc_lb
            // 
            deliveryLoc_lb.AutoSize = true;
            deliveryLoc_lb.Location = new Point(85, 294);
            deliveryLoc_lb.Name = "deliveryLoc_lb";
            deliveryLoc_lb.Size = new Size(101, 15);
            deliveryLoc_lb.TabIndex = 2;
            deliveryLoc_lb.Text = "Delivery Location:";
            // 
            // pirckupLoc_lb
            // 
            pirckupLoc_lb.AutoSize = true;
            pirckupLoc_lb.Location = new Point(85, 366);
            pirckupLoc_lb.Name = "pirckupLoc_lb";
            pirckupLoc_lb.Size = new Size(96, 15);
            pirckupLoc_lb.TabIndex = 3;
            pirckupLoc_lb.Text = "Pick Up location:";
            // 
            // Disastertile_bt
            // 
            Disastertile_bt.BackColor = Color.Transparent;
            Disastertile_bt.BackgroundImageLayout = ImageLayout.None;
            Disastertile_bt.FlatStyle = FlatStyle.Flat;
            Disastertile_bt.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            Disastertile_bt.Location = new Point(175, 60);
            Disastertile_bt.Name = "Disastertile_bt";
            Disastertile_bt.Size = new Size(316, 45);
            Disastertile_bt.TabIndex = 9;
            Disastertile_bt.Text = "Disaster Title ";
            Disastertile_bt.UseVisualStyleBackColor = false;
            Disastertile_bt.Click += Disastertile_bt_Click;
            // 
            // Donation_details
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(697, 485);
            Controls.Add(Disastertile_bt);
            Controls.Add(pirckupLoc_lb);
            Controls.Add(deliveryLoc_lb);
            Controls.Add(Itemdetails_lb);
            Controls.Add(donationtype_lb);
            Name = "Donation_details";
            Text = "Donation_details";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label donationtype_lb;
        private Label Itemdetails_lb;
        private Label deliveryLoc_lb;
        private Label pirckupLoc_lb;
        private Button Disastertile_bt;
    }
}