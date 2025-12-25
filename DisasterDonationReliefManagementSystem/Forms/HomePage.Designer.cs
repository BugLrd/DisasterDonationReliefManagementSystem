namespace DisasterDonationReliefManagementSystem
{
    partial class HomePage
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
            greet = new Label();
            SuspendLayout();
            // 
            // greet
            // 
            greet.AutoSize = true;
            greet.Font = new Font("Segoe UI", 50F);
            greet.Location = new Point(586, 295);
            greet.Margin = new Padding(6, 0, 6, 0);
            greet.Name = "greet";
            greet.Size = new Size(192, 89);
            greet.TabIndex = 0;
            greet.Text = "Hello";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(16F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1341, 790);
            Controls.Add(greet);
            Font = new Font("Times New Roman", 20F, FontStyle.Bold);
            Margin = new Padding(6, 7, 6, 7);
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HomePage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label greet;
    }
}