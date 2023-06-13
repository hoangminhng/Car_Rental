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
            panelContainer = new Panel();
            pnlTitle = new Panel();
            lbTitle = new Label();
            panel1 = new Panel();
            btnHistory = new Button();
            btnViewCar = new Button();
            btnAccount = new Button();
            panelLogo = new Panel();
            panel2 = new Panel();
            pnlShow.SuspendLayout();
            pnlTitle.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlShow
            // 
            pnlShow.Controls.Add(panelContainer);
            pnlShow.Controls.Add(pnlTitle);
            pnlShow.Dock = DockStyle.Right;
            pnlShow.Location = new Point(220, 0);
            pnlShow.Name = "pnlShow";
            pnlShow.Size = new Size(668, 478);
            pnlShow.TabIndex = 5;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(0, 66);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(668, 412);
            panelContainer.TabIndex = 9;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(0, 150, 136);
            pnlTitle.Controls.Add(lbTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(0, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(668, 66);
            pnlTitle.TabIndex = 8;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(314, 18);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(69, 28);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "HOME";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(btnHistory);
            panel1.Controls.Add(btnViewCar);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(panelLogo);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(222, 478);
            panel1.TabIndex = 4;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = Color.FromArgb(51, 51, 76);
            btnHistory.Dock = DockStyle.Top;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistory.ForeColor = Color.Gainsboro;
            btnHistory.ImageAlign = ContentAlignment.MiddleLeft;
            btnHistory.Location = new Point(0, 186);
            btnHistory.Margin = new Padding(3, 2, 3, 2);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(12, 0, 0, 0);
            btnHistory.Size = new Size(222, 60);
            btnHistory.TabIndex = 6;
            btnHistory.Text = "   History";
            btnHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click;
            // 
            // btnViewCar
            // 
            btnViewCar.BackColor = Color.FromArgb(51, 51, 76);
            btnViewCar.Dock = DockStyle.Top;
            btnViewCar.FlatAppearance.BorderSize = 0;
            btnViewCar.FlatStyle = FlatStyle.Flat;
            btnViewCar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnViewCar.ForeColor = Color.Gainsboro;
            btnViewCar.ImageAlign = ContentAlignment.MiddleLeft;
            btnViewCar.Location = new Point(0, 126);
            btnViewCar.Margin = new Padding(3, 2, 3, 2);
            btnViewCar.Name = "btnViewCar";
            btnViewCar.Padding = new Padding(12, 0, 0, 0);
            btnViewCar.Size = new Size(222, 60);
            btnViewCar.TabIndex = 4;
            btnViewCar.Text = "   View Car";
            btnViewCar.TextAlign = ContentAlignment.MiddleLeft;
            btnViewCar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnViewCar.UseVisualStyleBackColor = false;
            btnViewCar.Click += btnViewCar_Click;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = Color.FromArgb(51, 51, 76);
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccount.ForeColor = Color.Gainsboro;
            btnAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnAccount.Location = new Point(0, 66);
            btnAccount.Margin = new Padding(3, 2, 3, 2);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(12, 0, 0, 0);
            btnAccount.Size = new Size(222, 60);
            btnAccount.TabIndex = 3;
            btnAccount.Text = "   Account";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(222, 66);
            panelLogo.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 0;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 478);
            Controls.Add(pnlShow);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Customer";
            Text = "Customer";
            pnlShow.ResumeLayout(false);
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlShow;
        private Panel panel1;
        private Button btnMngRental;
        private Button btnViewCar;
        private Panel panel2;
        private Panel panelLogo;
        private Button button3;
        private Button btnAccount;
        private Button btnHistory;
        private Panel pnlTitle;
        private Label lbTitle;
        private Panel panelContainer;
    }
}