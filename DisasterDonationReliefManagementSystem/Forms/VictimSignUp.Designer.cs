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
            fnametb = new TextBox();
            lnametb = new TextBox();
            phonetb = new TextBox();
            addresstb = new TextBox();
            unametb = new TextBox();
            passtb = new TextBox();
            confirmPasstb = new TextBox();
            SuspendLayout();
            // 
            // fnametb
            // 
            fnametb.Font = new Font("Segoe UI", 11F);
            fnametb.Location = new Point(127, 108);
            fnametb.Name = "fnametb";
            fnametb.PlaceholderText = "First Name";
            fnametb.Size = new Size(292, 27);
            fnametb.TabIndex = 1;
            // 
            // lnametb
            // 
            lnametb.Font = new Font("Segoe UI", 11F);
            lnametb.Location = new Point(127, 155);
            lnametb.Name = "lnametb";
            lnametb.PlaceholderText = "Last Name";
            lnametb.Size = new Size(292, 27);
            lnametb.TabIndex = 2;
            // 
            // phonetb
            // 
            phonetb.Font = new Font("Segoe UI", 11F);
            phonetb.Location = new Point(127, 207);
            phonetb.Name = "phonetb";
            phonetb.PlaceholderText = "Phone";
            phonetb.Size = new Size(292, 27);
            phonetb.TabIndex = 3;
            // 
            // addresstb
            // 
            addresstb.Font = new Font("Segoe UI", 11F);
            addresstb.Location = new Point(127, 259);
            addresstb.Name = "addresstb";
            addresstb.PlaceholderText = "Address";
            addresstb.Size = new Size(292, 27);
            addresstb.TabIndex = 4;
            // 
            // unametb
            // 
            unametb.Font = new Font("Segoe UI", 11F);
            unametb.Location = new Point(127, 307);
            unametb.Name = "unametb";
            unametb.PlaceholderText = "Username";
            unametb.Size = new Size(292, 27);
            unametb.TabIndex = 5;
            // 
            // passtb
            // 
            passtb.Font = new Font("Segoe UI", 11F);
            passtb.Location = new Point(127, 360);
            passtb.Name = "passtb";
            passtb.PlaceholderText = "Password";
            passtb.Size = new Size(292, 27);
            passtb.TabIndex = 5;
            // 
            // confirmPasstb
            // 
            confirmPasstb.Font = new Font("Segoe UI", 11F);
            confirmPasstb.Location = new Point(127, 413);
            confirmPasstb.Name = "confirmPasstb";
            confirmPasstb.PlaceholderText = "Confirm Password";
            confirmPasstb.Size = new Size(292, 27);
            confirmPasstb.TabIndex = 6;
            // 
            // VictimSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 567);
            Controls.Add(confirmPasstb);
            Controls.Add(passtb);
            Controls.Add(unametb);
            Controls.Add(addresstb);
            Controls.Add(phonetb);
            Controls.Add(lnametb);
            Controls.Add(fnametb);
            Name = "VictimSignUp";
            Text = "VictimSignUp";
            Controls.SetChildIndex(fnametb, 0);
            Controls.SetChildIndex(lnametb, 0);
            Controls.SetChildIndex(phonetb, 0);
            Controls.SetChildIndex(addresstb, 0);
            Controls.SetChildIndex(unametb, 0);
            Controls.SetChildIndex(passtb, 0);
            Controls.SetChildIndex(confirmPasstb, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox fnametb;
        private TextBox lnametb;
        private TextBox phonetb;
        private TextBox addresstb;
        private TextBox unametb;
        private TextBox passtb;
        private TextBox confirmPasstb;
    }
}