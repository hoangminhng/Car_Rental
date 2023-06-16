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
            panel1.SuspendLayout();
            paneltittle.SuspendLayout();
            SuspendLayout();
            // 
            // txt_search
            // 
            txt_search.Location = new Point(312, 100);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(378, 27);
            txt_search.TabIndex = 6;
            // 
            // combobrand
            // 
            combobrand.DisplayMember = "BrandName";
            combobrand.FormattingEnabled = true;
            combobrand.Location = new Point(731, 100);
            combobrand.Name = "combobrand";
            combobrand.Size = new Size(96, 28);
            combobrand.TabIndex = 7;
            combobrand.ValueMember = "BrandId";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(btnHome);
            panel1.Controls.Add(btnMngRental);
            panel1.Controls.Add(btnAccount);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(282, 638);
            panel1.TabIndex = 4;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.Highlight;
            btnHome.Location = new Point(-6, 0);
            btnHome.Margin = new Padding(3, 4, 3, 4);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(285, 80);
            btnHome.TabIndex = 5;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnMngRental
            // 
            btnMngRental.BackColor = SystemColors.ActiveBorder;
            btnMngRental.Location = new Point(0, 147);
            btnMngRental.Margin = new Padding(3, 4, 3, 4);
            btnMngRental.Name = "btnMngRental";
            btnMngRental.Size = new Size(279, 85);
            btnMngRental.TabIndex = 4;
            btnMngRental.Text = "History";
            btnMngRental.UseVisualStyleBackColor = false;
            btnMngRental.Click += btnMngRental_Click_1;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = SystemColors.ActiveBorder;
            btnAccount.Location = new Point(0, 73);
            btnAccount.Margin = new Padding(3, 4, 3, 4);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(279, 80);
            btnAccount.TabIndex = 0;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = false;
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
            // paneltittle
            // 
            paneltittle.AutoSize = true;
            paneltittle.BackColor = SystemColors.Highlight;
            paneltittle.Controls.Add(label1);
            paneltittle.Location = new Point(276, 3);
            paneltittle.Name = "paneltittle";
            paneltittle.Size = new Size(786, 76);
            paneltittle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(335, 30);
            label1.Name = "label1";
            label1.Size = new Size(101, 38);
            label1.TabIndex = 0;
            label1.Text = "HOME";
            // 
            // carlayout
            // 
            carlayout.AutoScroll = true;
            carlayout.Location = new Point(285, 172);
            carlayout.Name = "carlayout";
            carlayout.Padding = new Padding(20, 5, 20, 20);
            carlayout.Size = new Size(777, 466);
            carlayout.TabIndex = 8;
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.ActiveCaption;
            btn_search.Location = new Point(903, 94);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(97, 38);
            btn_search.TabIndex = 9;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new Point(573, 147);
            message.Name = "message";
            message.Size = new Size(183, 20);
            message.TabIndex = 10;
            message.Text = "There are any cars to hire !";
            message.Visible = false;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 637);
            Controls.Add(message);
            Controls.Add(btn_search);
            Controls.Add(carlayout);
            Controls.Add(combobrand);
            Controls.Add(paneltittle);
            Controls.Add(txt_search);
            Controls.Add(panel1);
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
    }
}