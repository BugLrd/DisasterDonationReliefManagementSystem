namespace DisasterDonationReliefManagementSystem
{
    partial class GreetPage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GreetPage));
            greetlbl = new Label();
            mottolbl = new Label();
            nextbtn = new Button();
            userBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)userBindingSource).BeginInit();
            SuspendLayout();
            // 
            // greetlbl
            // 
            greetlbl.AutoSize = true;
            greetlbl.BackColor = Color.Transparent;
            greetlbl.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            greetlbl.Location = new Point(291, 46);
            greetlbl.Name = "greetlbl";
            greetlbl.Size = new Size(448, 54);
            greetlbl.TabIndex = 0;
            greetlbl.Text = "Welcome To ReliefHub";
            // 
            // mottolbl
            // 
            mottolbl.AutoSize = true;
            mottolbl.BackColor = Color.Transparent;
            mottolbl.Font = new Font("Segoe UI", 15F);
            mottolbl.Location = new Point(342, 123);
            mottolbl.Name = "mottolbl";
            mottolbl.Size = new Size(350, 28);
            mottolbl.TabIndex = 1;
            mottolbl.Text = "Connecting help when its needed most";
            // 
            // nextbtn
            // 
            nextbtn.BackColor = Color.DarkTurquoise;
            nextbtn.Location = new Point(342, 525);
            nextbtn.Name = "nextbtn";
            nextbtn.Size = new Size(387, 28);
            nextbtn.TabIndex = 2;
            nextbtn.Text = "Next ->";
            nextbtn.UseVisualStyleBackColor = false;
            nextbtn.Click += nextbtn_click;
            // 
            // userBindingSource
            // 
            userBindingSource.DataSource = typeof(Entities.User);
            // 
            // GreetPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1062, 610);
            Controls.Add(nextbtn);
            Controls.Add(mottolbl);
            Controls.Add(greetlbl);
            Name = "GreetPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GreetPage";
            ((System.ComponentModel.ISupportInitialize)userBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label greetlbl;
        private Label mottolbl;
        private Button nextbtn;
        private BindingSource userBindingSource;
    }
}