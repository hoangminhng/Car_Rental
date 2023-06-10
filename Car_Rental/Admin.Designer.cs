namespace Car_Rental
{
    partial class Admin
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
            panel1 = new Panel();
            btnMngUser = new Button();
            btnMngRental = new Button();
            panel2 = new Panel();
            pnlShow = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btnMngUser);
            panel1.Controls.Add(btnMngRental);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(256, 556);
            panel1.TabIndex = 3;
            // 
            // btnMngUser
            // 
            btnMngUser.Location = new Point(12, 13);
            btnMngUser.Margin = new Padding(3, 4, 3, 4);
            btnMngUser.Name = "btnMngUser";
            btnMngUser.Size = new Size(229, 85);
            btnMngUser.TabIndex = 2;
            btnMngUser.Text = "Manage User";
            btnMngUser.UseVisualStyleBackColor = true;
            btnMngUser.Click += btnMngUser_Click;
            // 
            // btnMngRental
            // 
            btnMngRental.Location = new Point(14, 121);
            btnMngRental.Margin = new Padding(3, 4, 3, 4);
            btnMngRental.Name = "btnMngRental";
            btnMngRental.Size = new Size(229, 85);
            btnMngRental.TabIndex = 1;
            btnMngRental.Text = "Manage Rental";
            btnMngRental.UseVisualStyleBackColor = true;
            btnMngRental.Click += btnMngRental_Click_1;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 0;
            // 
            // pnlShow
            // 
            pnlShow.Location = new Point(259, 0);
            pnlShow.Margin = new Padding(3, 4, 3, 4);
            pnlShow.Name = "pnlShow";
            pnlShow.Size = new Size(755, 556);
            pnlShow.TabIndex = 4;
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 556);
            Controls.Add(panel1);
            Controls.Add(pnlShow);
            Name = "Admin";
            Text = "Admin";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnMngUser;
        private Button btnMngRental;
        private Panel panel2;
        private Panel pnlShow;
    }
}