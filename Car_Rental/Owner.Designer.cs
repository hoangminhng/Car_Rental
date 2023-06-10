namespace Car_Rental
{
    partial class Owner
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
            btnMngCar = new Button();
            btnRequest = new Button();
            btnMngAccount = new Button();
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
            pnlShow.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(btnMngCar);
            panel1.Controls.Add(btnRequest);
            panel1.Controls.Add(btnMngAccount);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(256, 556);
            panel1.TabIndex = 6;
            // 
            // btnMngCar
            // 
            btnMngCar.Location = new Point(14, 238);
            btnMngCar.Margin = new Padding(3, 4, 3, 4);
            btnMngCar.Name = "btnMngCar";
            btnMngCar.Size = new Size(229, 80);
            btnMngCar.TabIndex = 2;
            btnMngCar.Text = "Manage Car";
            btnMngCar.UseVisualStyleBackColor = true;
            btnMngCar.Click += btnMngCar_Click;
            // 
            // btnRequest
            // 
            btnRequest.Location = new Point(14, 121);
            btnRequest.Margin = new Padding(3, 4, 3, 4);
            btnRequest.Name = "btnRequest";
            btnRequest.Size = new Size(229, 85);
            btnRequest.TabIndex = 1;
            btnRequest.Text = "Rent Request";
            btnRequest.UseVisualStyleBackColor = true;
            btnRequest.Click += btnRequest_Click;
            // 
            // btnMngAccount
            // 
            btnMngAccount.Location = new Point(14, 16);
            btnMngAccount.Margin = new Padding(3, 4, 3, 4);
            btnMngAccount.Name = "btnMngAccount";
            btnMngAccount.Size = new Size(229, 80);
            btnMngAccount.TabIndex = 0;
            btnMngAccount.Text = "Account";
            btnMngAccount.UseVisualStyleBackColor = true;
            btnMngAccount.Click += btnMngAccount_Click;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 0;
            // 
            // Owner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1015, 556);
            Controls.Add(pnlShow);
            Controls.Add(panel1);
            Name = "Owner";
            Text = "Owner";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlShow;
        private Panel panel1;
        private Button btnMngCar;
        private Button btnRequest;
        private Button btnMngAccount;
        private Panel panel2;
    }
}