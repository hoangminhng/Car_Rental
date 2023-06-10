namespace Car_Rental
{
    partial class Customer
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
            pnlShow = new Panel();
            panel1 = new Panel();
            btnMngRental = new Button();
            btnViewCar = new Button();
            btnAccount = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlShow
            // 
            pnlShow.Location = new Point(259, 0);
            pnlShow.Margin = new Padding(3, 4, 3, 4);
            pnlShow.Name = "pnlShow";
            pnlShow.Size = new Size(755, 556);
            pnlShow.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btnMngRental);
            panel1.Controls.Add(btnViewCar);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(256, 556);
            panel1.TabIndex = 4;
            // 
            // btnMngRental
            // 
            btnMngRental.Location = new Point(14, 236);
            btnMngRental.Margin = new Padding(3, 4, 3, 4);
            btnMngRental.Name = "btnMngRental";
            btnMngRental.Size = new Size(229, 85);
            btnMngRental.TabIndex = 4;
            btnMngRental.Text = "History";
            btnMngRental.UseVisualStyleBackColor = true;
            btnMngRental.Click += btnMngRental_Click_1;
            // 
            // btnViewCar
            // 
            btnViewCar.Location = new Point(14, 118);
            btnViewCar.Margin = new Padding(3, 4, 3, 4);
            btnViewCar.Name = "btnViewCar";
            btnViewCar.Size = new Size(229, 85);
            btnViewCar.TabIndex = 3;
            btnViewCar.Text = "View Car";
            btnViewCar.UseVisualStyleBackColor = true;
            btnViewCar.Click += btnViewCar_Click_1;
            // 
            // btnAccount
            // 
            btnAccount.Location = new Point(14, 16);
            btnAccount.Margin = new Padding(3, 4, 3, 4);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(229, 80);
            btnAccount.TabIndex = 0;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = true;
            btnAccount.Click += btnAccount_Click_1;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 0;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 556);
            Controls.Add(pnlShow);
            Controls.Add(panel1);
            Name = "Customer";
            Text = "Customer";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlShow;
        private Panel panel1;
        private Button btnMngRental;
        private Button btnViewCar;
        private Button btnAccount;
        private Panel panel2;
    }
}