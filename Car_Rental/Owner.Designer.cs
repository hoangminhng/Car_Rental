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
            pnlTitle = new Panel();
            lbTitle = new Label();
            panel1 = new Panel();
            btnMngCar = new Button();
            btnRequest = new Button();
            btnMngAccount = new Button();
            panelLogo = new Panel();
            panel2 = new Panel();
            panelContainer = new Panel();
            pnlTitle.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(0, 150, 136);
            pnlTitle.Controls.Add(lbTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(212, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(676, 66);
            pnlTitle.TabIndex = 7;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(323, 20);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(69, 28);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "HOME";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(btnMngCar);
            panel1.Controls.Add(btnRequest);
            panel1.Controls.Add(btnMngAccount);
            panel1.Controls.Add(panelLogo);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(212, 478);
            panel1.TabIndex = 6;
            // 
            // btnMngCar
            // 
            btnMngCar.BackColor = Color.FromArgb(51, 51, 76);
            btnMngCar.Dock = DockStyle.Top;
            btnMngCar.FlatAppearance.BorderSize = 0;
            btnMngCar.FlatStyle = FlatStyle.Flat;
            btnMngCar.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnMngCar.ForeColor = Color.Gainsboro;
            btnMngCar.ImageAlign = ContentAlignment.MiddleLeft;
            btnMngCar.Location = new Point(0, 186);
            btnMngCar.Name = "btnMngCar";
            btnMngCar.Padding = new Padding(12, 0, 0, 0);
            btnMngCar.Size = new Size(212, 60);
            btnMngCar.TabIndex = 5;
            btnMngCar.Text = "   Car";
            btnMngCar.TextAlign = ContentAlignment.MiddleLeft;
            btnMngCar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMngCar.UseVisualStyleBackColor = false;
            btnMngCar.Click += btnMngCar_Click;
            // 
            // btnRequest
            // 
            btnRequest.BackColor = Color.FromArgb(51, 51, 76);
            btnRequest.Dock = DockStyle.Top;
            btnRequest.FlatAppearance.BorderSize = 0;
            btnRequest.FlatStyle = FlatStyle.Flat;
            btnRequest.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnRequest.ForeColor = Color.Gainsboro;
            btnRequest.ImageAlign = ContentAlignment.MiddleLeft;
            btnRequest.Location = new Point(0, 126);
            btnRequest.Name = "btnRequest";
            btnRequest.Padding = new Padding(12, 0, 0, 0);
            btnRequest.Size = new Size(212, 60);
            btnRequest.TabIndex = 4;
            btnRequest.Text = "   Request";
            btnRequest.TextAlign = ContentAlignment.MiddleLeft;
            btnRequest.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRequest.UseVisualStyleBackColor = false;
            btnRequest.Click += btnRequest_Click;
            // 
            // btnMngAccount
            // 
            btnMngAccount.AutoSize = true;
            btnMngAccount.BackColor = Color.FromArgb(51, 51, 76);
            btnMngAccount.Dock = DockStyle.Top;
            btnMngAccount.FlatAppearance.BorderSize = 0;
            btnMngAccount.FlatStyle = FlatStyle.Flat;
            btnMngAccount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnMngAccount.ForeColor = Color.Gainsboro;
            btnMngAccount.ImageAlign = ContentAlignment.MiddleLeft;
            btnMngAccount.Location = new Point(0, 66);
            btnMngAccount.Name = "btnMngAccount";
            btnMngAccount.Padding = new Padding(12, 0, 0, 0);
            btnMngAccount.Size = new Size(212, 60);
            btnMngAccount.TabIndex = 3;
            btnMngAccount.Text = "   Account";
            btnMngAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnMngAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMngAccount.UseVisualStyleBackColor = false;
            btnMngAccount.Click += btnMngAccount_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(212, 66);
            panelLogo.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 0;
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(212, 66);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(676, 412);
            panelContainer.TabIndex = 8;
            // 
            // Owner
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 478);
            Controls.Add(panelContainer);
            Controls.Add(pnlTitle);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Owner";
            Text = "Owner";
            Load += Owner_Load;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitle;
        private Panel panel1;
        private Panel panel2;
        private Label lbTitle;
        private Panel panelContainer;
        private Panel panelLogo;
        private Button btnMngCar;
        private Button btnRequest;
        private Button btnMngAccount;
    }
}