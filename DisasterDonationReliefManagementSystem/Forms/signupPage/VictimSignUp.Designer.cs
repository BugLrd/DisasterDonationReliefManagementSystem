namespace DisasterDonationReliefManagementSystem.Forms
{
    partial class VictimSignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VictimSignUp));
            addresstb = new TextBox();
            phonetb = new TextBox();
            SuspendLayout();
            // 
            // addresstb
            // 
            addresstb.Font = new Font("Segoe UI", 11F);
            addresstb.Location = new Point(127, 343);
            addresstb.Name = "addresstb";
            addresstb.PlaceholderText = "Address";
            addresstb.Size = new Size(292, 27);
            addresstb.TabIndex = 7;
            // 
            // phonetb
            // 
            phonetb.Font = new Font("Segoe UI", 11F);
            phonetb.Location = new Point(127, 390);
            phonetb.Name = "phonetb";
            phonetb.PlaceholderText = "Phone";
            phonetb.Size = new Size(292, 27);
            phonetb.TabIndex = 8;
            // 
            // VictimSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(977, 567);
            Controls.Add(phonetb);
            Controls.Add(addresstb);
            Name = "VictimSignUp";
            Text = "VictimSignUp";
            Load += VictimSignUp_Load_1;
            Controls.SetChildIndex(addresstb, 0);
            Controls.SetChildIndex(phonetb, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox addresstb;
        private TextBox phonetb;
    }
}