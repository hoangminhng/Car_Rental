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
            pnlTitle = new Panel();
            lbTitle = new Label();
            panel1 = new Panel();
            btnMngRental = new Button();
            btnMngCar = new Button();
            btnMngUser = new Button();
            panelLogo = new Panel();
            panel2 = new Panel();
            panelContainer = new FlowLayoutPanel();
            panelControl = new Panel();
            btnSearch = new Button();
            cbSearchBy = new ComboBox();
            txtSearch = new TextBox();
            label1 = new Label();
            pnlTitle.SuspendLayout();
            panel1.SuspendLayout();
            panelControl.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitle
            // 
            pnlTitle.BackColor = Color.FromArgb(0, 150, 136);
            pnlTitle.Controls.Add(lbTitle);
            pnlTitle.Dock = DockStyle.Top;
            pnlTitle.Location = new Point(212, 0);
            pnlTitle.MaximumSize = new Size(0, 60);
            pnlTitle.MinimumSize = new Size(0, 60);
            pnlTitle.Name = "pnlTitle";
            pnlTitle.Size = new Size(822, 60);
            pnlTitle.TabIndex = 10;
            // 
            // lbTitle
            // 
            lbTitle.Anchor = AnchorStyles.None;
            lbTitle.AutoSize = true;
            lbTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lbTitle.ForeColor = Color.White;
            lbTitle.Location = new Point(321, 17);
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
            panel1.Size = new Size(212, 561);
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
            btnMngRental.Location = new Point(0, 180);
            btnMngRental.Name = "btnMngRental";
            btnMngRental.Padding = new Padding(12, 0, 0, 0);
            btnMngRental.Size = new Size(212, 60);
            btnMngRental.TabIndex = 5;
            btnMngRental.Text = "Manage Rental";
            btnMngRental.TextAlign = ContentAlignment.MiddleLeft;
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
            btnMngCar.Location = new Point(0, 120);
            btnMngCar.Name = "btnMngCar";
            btnMngCar.Padding = new Padding(12, 0, 0, 0);
            btnMngCar.Size = new Size(212, 60);
            btnMngCar.TabIndex = 4;
            btnMngCar.Text = "Manage Car";
            btnMngCar.TextAlign = ContentAlignment.MiddleLeft;
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
            btnMngUser.Location = new Point(0, 60);
            btnMngUser.Name = "btnMngUser";
            btnMngUser.Padding = new Padding(12, 0, 0, 0);
            btnMngUser.Size = new Size(212, 60);
            btnMngUser.TabIndex = 3;
            btnMngUser.Text = "Manage User";
            btnMngUser.TextAlign = ContentAlignment.MiddleLeft;
            btnMngUser.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMngUser.UseVisualStyleBackColor = false;
            btnMngUser.Click += btnMngUser_Click;
            // 
            // panelLogo
            // 
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(3, 2, 3, 2);
            panelLogo.MaximumSize = new Size(0, 60);
            panelLogo.MinimumSize = new Size(0, 60);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(212, 60);
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
            panelContainer.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelContainer.AutoScroll = true;
            panelContainer.Location = new Point(212, 155);
            panelContainer.Margin = new Padding(3, 2, 3, 2);
            panelContainer.MinimumSize = new Size(0, 290);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(822, 406);
            panelContainer.TabIndex = 11;
            // 
            // panelControl
            // 
            panelControl.Controls.Add(btnSearch);
            panelControl.Controls.Add(cbSearchBy);
            panelControl.Controls.Add(txtSearch);
            panelControl.Controls.Add(label1);
            panelControl.Dock = DockStyle.Top;
            panelControl.Location = new Point(212, 60);
            panelControl.MaximumSize = new Size(0, 90);
            panelControl.MinimumSize = new Size(0, 70);
            panelControl.Name = "panelControl";
            panelControl.Size = new Size(822, 90);
            panelControl.TabIndex = 12;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(540, 37);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // cbSearchBy
            // 
            cbSearchBy.AllowDrop = true;
            cbSearchBy.FormattingEnabled = true;
            cbSearchBy.Location = new Point(413, 37);
            cbSearchBy.Name = "cbSearchBy";
            cbSearchBy.Size = new Size(121, 23);
            cbSearchBy.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(96, 37);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(311, 23);
            txtSearch.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 14);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // Admin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1034, 561);
            Controls.Add(panelControl);
            Controls.Add(panelContainer);
            Controls.Add(pnlTitle);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1050, 600);
            Name = "Admin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin";
            FormClosed += Admin_FormClosed;
            pnlTitle.ResumeLayout(false);
            pnlTitle.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panelControl.ResumeLayout(false);
            panelControl.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnlTitle;
        private Label lbTitle;
        private Panel panel1;
        private Button btnMngRental;
        private Button btnMngCar;
        private Button btnMngUser;
        private Panel panelLogo;
        private Panel panel2;
        private FlowLayoutPanel panelContainer;
        private Panel panelControl;
        private ComboBox cbSearchBy;
        private TextBox txtSearch;
        private Label label1;
        private Button btnSearch;
    }
}