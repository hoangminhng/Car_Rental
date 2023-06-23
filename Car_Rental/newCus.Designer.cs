namespace Car_Rental
{
    partial class newCus
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
            panelBar = new Panel();
            btnHistory = new Button();
            btnAccount = new Button();
            btnHome = new Button();
            panel2 = new Panel();
            panelTitle = new Panel();
            panel3 = new Panel();
            message = new Label();
            btn_search = new Button();
            combobrand = new ComboBox();
            txt_search = new TextBox();
            carList = new Panel();
            panelBar.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panelBar
            // 
            panelBar.BackColor = SystemColors.ActiveCaption;
            panelBar.Controls.Add(btnHistory);
            panelBar.Controls.Add(btnAccount);
            panelBar.Controls.Add(btnHome);
            panelBar.Controls.Add(panel2);
            panelBar.Dock = DockStyle.Left;
            panelBar.Location = new Point(0, 0);
            panelBar.Margin = new Padding(3, 2, 3, 2);
            panelBar.Name = "panelBar";
            panelBar.Size = new Size(219, 478);
            panelBar.TabIndex = 0;
            // 
            // btnHistory
            // 
            btnHistory.BackColor = SystemColors.ActiveCaption;
            btnHistory.Dock = DockStyle.Top;
            btnHistory.FlatAppearance.BorderSize = 0;
            btnHistory.FlatStyle = FlatStyle.Flat;
            btnHistory.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHistory.Location = new Point(0, 216);
            btnHistory.Margin = new Padding(3, 4, 3, 4);
            btnHistory.Name = "btnHistory";
            btnHistory.Padding = new Padding(14, 0, 0, 0);
            btnHistory.Size = new Size(219, 75);
            btnHistory.TabIndex = 3;
            btnHistory.Text = "   History";
            btnHistory.TextAlign = ContentAlignment.MiddleLeft;
            btnHistory.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHistory.UseVisualStyleBackColor = false;
            btnHistory.Click += btnHistory_Click_1;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = SystemColors.ActiveCaption;
            btnAccount.Dock = DockStyle.Top;
            btnAccount.FlatAppearance.BorderSize = 0;
            btnAccount.FlatStyle = FlatStyle.Flat;
            btnAccount.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAccount.Location = new Point(0, 141);
            btnAccount.Margin = new Padding(3, 4, 3, 4);
            btnAccount.Name = "btnAccount";
            btnAccount.Padding = new Padding(14, 0, 0, 0);
            btnAccount.Size = new Size(219, 75);
            btnAccount.TabIndex = 2;
            btnAccount.Text = "   Account";
            btnAccount.TextAlign = ContentAlignment.MiddleLeft;
            btnAccount.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click_1;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.ActiveCaption;
            btnHome.Dock = DockStyle.Top;
            btnHome.FlatAppearance.BorderSize = 0;
            btnHome.FlatStyle = FlatStyle.Flat;
            btnHome.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHome.Location = new Point(0, 66);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Padding = new Padding(14, 0, 0, 0);
            btnHome.Size = new Size(219, 75);
            btnHome.TabIndex = 1;
            btnHome.Text = "   Home";
            btnHome.TextAlign = ContentAlignment.MiddleLeft;
            btnHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(219, 66);
            panel2.TabIndex = 0;
            // 
            // panelTitle
            // 
            panelTitle.BackColor = SystemColors.Highlight;
            panelTitle.Dock = DockStyle.Top;
            panelTitle.Location = new Point(219, 0);
            panelTitle.Margin = new Padding(3, 2, 3, 2);
            panelTitle.Name = "panelTitle";
            panelTitle.Size = new Size(669, 66);
            panelTitle.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(message);
            panel3.Controls.Add(btn_search);
            panel3.Controls.Add(combobrand);
            panel3.Controls.Add(txt_search);
            panel3.Location = new Point(219, 66);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(669, 75);
            panel3.TabIndex = 2;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new Point(261, 50);
            message.Name = "message";
            message.Size = new Size(144, 15);
            message.TabIndex = 34;
            message.Text = "There are any cars to hire !";
            message.Visible = false;
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.ActiveCaption;
            btn_search.Location = new Point(550, 10);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(85, 28);
            btn_search.TabIndex = 33;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // combobrand
            // 
            combobrand.DisplayMember = "BrandName";
            combobrand.FormattingEnabled = true;
            combobrand.Location = new Point(400, 15);
            combobrand.Margin = new Padding(3, 2, 3, 2);
            combobrand.Name = "combobrand";
            combobrand.Size = new Size(84, 23);
            combobrand.TabIndex = 32;
            combobrand.ValueMember = "BrandId";
            // 
            // txt_search
            // 
            txt_search.Location = new Point(33, 15);
            txt_search.Margin = new Padding(3, 2, 3, 2);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(331, 23);
            txt_search.TabIndex = 31;
            // 
            // carList
            // 
            carList.Location = new Point(219, 141);
            carList.Margin = new Padding(3, 2, 3, 2);
            carList.Name = "carList";
            carList.Size = new Size(669, 340);
            carList.TabIndex = 3;
            // 
            // newCus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 478);
            Controls.Add(carList);
            Controls.Add(panel3);
            Controls.Add(panelTitle);
            Controls.Add(panelBar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "newCus";
            Text = "newCus";
            Load += newCus_Load;
            panelBar.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBar;
        private Panel panelTitle;
        private Panel panel3;
        private Panel carList;
        private Button btnHome;
        private Panel panel2;
        private Button btnHistory;
        private Button btnAccount;
        private Label message;
        private Button btn_search;
        private ComboBox combobrand;
        private TextBox txt_search;
    }
}