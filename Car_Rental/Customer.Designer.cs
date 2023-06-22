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
            txt_search = new TextBox();
            combobrand = new ComboBox();
            panel1 = new Panel();
            btnHome = new Button();
            btnMngRental = new Button();
            btnAccount = new Button();
            panel2 = new Panel();
            paneltittle = new Panel();
            label1 = new Label();
            carlayout = new FlowLayoutPanel();
            btn_search = new Button();
            message = new Label();
            btnChangePwd = new Button();
            panel1.SuspendLayout();
            paneltittle.SuspendLayout();
            SuspendLayout();
            // 
            // txt_search
            // 
            txt_search.Location = new Point(507, 160);
            txt_search.Margin = new Padding(5, 5, 5, 5);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(612, 39);
            txt_search.TabIndex = 6;
            // 
            // combobrand
            // 
            combobrand.DisplayMember = "BrandName";
            combobrand.FormattingEnabled = true;
            combobrand.Location = new Point(1188, 160);
            combobrand.Margin = new Padding(5, 5, 5, 5);
            combobrand.Name = "combobrand";
            combobrand.Size = new Size(154, 40);
            combobrand.TabIndex = 7;
            combobrand.ValueMember = "BrandId";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnChangePwd);
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnMngRental);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(458, 1021);
            panel1.TabIndex = 4;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.Highlight;
            btnHome.Location = new Point(-10, 0);
            btnHome.Margin = new Padding(5, 6, 5, 6);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(463, 128);
            btnHome.TabIndex = 5;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnMngRental
            // 
            btnMngRental.BackColor = SystemColors.ActiveBorder;
            btnMngRental.Location = new Point(0, 235);
            btnMngRental.Margin = new Padding(5, 6, 5, 6);
            btnMngRental.Name = "btnMngRental";
            btnMngRental.Size = new Size(453, 136);
            btnMngRental.TabIndex = 4;
            btnMngRental.Text = "History";
            btnMngRental.UseVisualStyleBackColor = false;
            btnMngRental.Click += btnMngRental_Click_1;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = SystemColors.ActiveBorder;
            btnAccount.Location = new Point(0, 117);
            btnAccount.Margin = new Padding(5, 6, 5, 6);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(453, 128);
            btnAccount.TabIndex = 0;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click_1;
            // 
            // panel2
            // 
            panel2.Location = new Point(5, 6);
            panel2.Margin = new Padding(5, 6, 5, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 0;
            // 
            // paneltittle
            // 
            paneltittle.AutoSize = true;
            paneltittle.BackColor = SystemColors.Highlight;
            paneltittle.Controls.Add(label1);
            paneltittle.Location = new Point(448, 5);
            paneltittle.Margin = new Padding(5, 5, 5, 5);
            paneltittle.Name = "paneltittle";
            paneltittle.Size = new Size(1277, 122);
            paneltittle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(544, 48);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(157, 60);
            label1.TabIndex = 0;
            label1.Text = "HOME";
            // 
            // carlayout
            // 
            carlayout.AutoScroll = true;
            carlayout.Location = new Point(463, 275);
            carlayout.Margin = new Padding(5, 5, 5, 5);
            carlayout.Name = "carlayout";
            carlayout.Padding = new Padding(32, 8, 32, 32);
            carlayout.Size = new Size(1263, 746);
            carlayout.TabIndex = 8;
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.ActiveCaption;
            btn_search.Location = new Point(1467, 150);
            btn_search.Margin = new Padding(5, 5, 5, 5);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(158, 61);
            btn_search.TabIndex = 9;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new Point(931, 235);
            message.Margin = new Padding(5, 0, 5, 0);
            message.Name = "message";
            message.Size = new Size(299, 32);
            message.TabIndex = 10;
            message.Text = "There are any cars to hire !";
            message.Visible = false;
            // 
            // btnChangePwd
            // 
            btnChangePwd.BackColor = SystemColors.ActiveBorder;
            btnChangePwd.Location = new Point(0, 367);
            btnChangePwd.Margin = new Padding(5, 6, 5, 6);
            btnChangePwd.Name = "btnChangePwd";
            btnChangePwd.Size = new Size(453, 136);
            btnChangePwd.TabIndex = 6;
            btnChangePwd.Text = "Change Password";
            btnChangePwd.UseVisualStyleBackColor = false;
            btnChangePwd.Click += btnChangePwd_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1734, 1019);
            Controls.Add(message);
            Controls.Add(btn_search);
            Controls.Add(carlayout);
            Controls.Add(combobrand);
            Controls.Add(paneltittle);
            Controls.Add(txt_search);
            Controls.Add(panel1);
            Margin = new Padding(5, 5, 5, 5);
            Name = "Customer";
            Text = "Customer";
            panel1.ResumeLayout(false);
            paneltittle.ResumeLayout(false);
            paneltittle.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlShow;
        private Panel panel1;
        private Button btnMngRental;
        private Button btnAccount;
        private Panel panel2;
        private Button btnHome;
        private Panel paneltittle;
        private Label label1;
        private TextBox txt_search;
        private ComboBox combobrand;
        private FlowLayoutPanel carlayout;
        private Button btn_search;
        private Label message;
        private Button btnChangePwd;
    }
}