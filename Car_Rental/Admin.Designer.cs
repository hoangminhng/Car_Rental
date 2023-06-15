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
            panelContainer = new Panel();
            pnlTitle = new Panel();
            lbTitle = new Label();
            panel1 = new Panel();
            btnMngRental = new Button();
            btnMngCar = new Button();
            btnMngUser = new Button();
            panelLogo = new Panel();
            panel2 = new Panel();
            pnlTitle.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panelContainer
            // 
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(212, 66);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(805, 498);
            panelContainer.TabIndex = 11;
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(0, 150, 136);
            pnlTitle.Controls.Add(lbTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(212, 0);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(805, 66);
            pnlTitle.TabIndex = 10;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(312, 20);
            lbTitle.Name = "lbTitle";
            lbTitle.Size = new Size(69, 28);
            lbTitle.TabIndex = 0;
            lbTitle.Text = "HOME";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(51, 51, 76);
            panel1.Controls.Add(btnMngRental);
            panel1.Controls.Add(btnMngCar);
            panel1.Controls.Add(btnMngUser);
            panel1.Controls.Add(panelLogo);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(212, 564);
            panel1.TabIndex = 9;
            // 
            // btnMngRental
            // 
            btnMngRental.BackColor = Color.FromArgb(51, 51, 76);
            btnMngRental.Dock = DockStyle.Top;
            btnMngRental.FlatAppearance.BorderSize = 0;
            btnMngRental.FlatStyle = FlatStyle.Flat;
            btnMngRental.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnMngRental.ForeColor = Color.Gainsboro;
            btnMngRental.ImageAlign = ContentAlignment.MiddleLeft;
            btnMngRental.Location = new Point(0, 186);
            btnMngRental.Name = "btnMngRental";
            btnMngRental.Padding = new Padding(12, 0, 0, 0);
            btnMngRental.Size = new Size(212, 60);
            btnMngRental.TabIndex = 5;
            btnMngRental.Text = "Manage Rental";
            btnMngRental.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMngRental.UseVisualStyleBackColor = false;
            btnMngRental.Click += btnMngRental_Click;
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
            btnMngCar.Location = new Point(0, 126);
            btnMngCar.Name = "btnMngCar";
            btnMngCar.Padding = new Padding(12, 0, 0, 0);
            btnMngCar.Size = new Size(212, 60);
            btnMngCar.TabIndex = 4;
            btnMngCar.Text = "Manage Car";
            btnMngCar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMngCar.UseVisualStyleBackColor = false;
            btnMngCar.Click += btnMngCar_Click;
            // 
            // btnMngUser
            // 
            btnMngUser.AutoSize = true;
            btnMngUser.BackColor = Color.FromArgb(51, 51, 76);
            btnMngUser.Dock = DockStyle.Top;
            btnMngUser.FlatAppearance.BorderSize = 0;
            btnMngUser.FlatStyle = FlatStyle.Flat;
            btnMngUser.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnMngUser.ForeColor = Color.Gainsboro;
            btnMngUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnMngUser.Location = new Point(0, 66);
            btnMngUser.Name = "btnMngUser";
            btnMngUser.Padding = new Padding(12, 0, 0, 0);
            btnMngUser.Size = new Size(212, 60);
            btnMngUser.TabIndex = 3;
            btnMngUser.Text = "Manage User";
            btnMngUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMngUser.UseVisualStyleBackColor = false;
            btnMngUser.Click += btnMngUser_Click;
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
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 564);
            Controls.Add(panelContainer);
            Controls.Add(pnlTitle);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            FormClosed += Admin_FormClosed;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContainer;
        private Panel pnlTitle;
        private Label lbTitle;
        private Panel panel1;
        private Button btnMngRental;
        private Button btnMngCar;
        private Button btnMngUser;
        private Panel panelLogo;
        private Panel panel2;
    }
}