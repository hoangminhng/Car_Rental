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
            txt_search.Location = new Point(273, 75);
            txt_search.Margin = new Padding(3, 2, 3, 2);
            txt_search.Name = "txt_search";
            txt_search.Size = new Size(331, 23);
            txt_search.TabIndex = 6;
            // 
            // combobrand
            // 
            combobrand.DisplayMember = "BrandName";
            combobrand.FormattingEnabled = true;
            combobrand.Location = new Point(640, 75);
            combobrand.Margin = new Padding(3, 2, 3, 2);
            combobrand.Name = "combobrand";
            combobrand.Size = new Size(84, 23);
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
            panel1.Size = new Size(247, 478);
            panel1.TabIndex = 4;
            // 
            // btnHome
            // 
            btnHome.BackColor = SystemColors.Highlight;
            btnHome.Location = new Point(-5, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(249, 60);
            btnHome.TabIndex = 5;
            btnHome.Text = "Home";
            btnHome.UseVisualStyleBackColor = false;
            btnHome.Click += btnHome_Click;
            // 
            // btnMngRental
            // 
            btnMngRental.BackColor = SystemColors.ActiveBorder;
            btnMngRental.Location = new Point(0, 110);
            btnMngRental.Name = "btnMngRental";
            btnMngRental.Size = new Size(244, 64);
            btnMngRental.TabIndex = 4;
            btnMngRental.Text = "History";
            btnMngRental.UseVisualStyleBackColor = false;
            btnMngRental.Click += btnMngRental_Click_1;
            // 
            // btnAccount
            // 
            btnAccount.BackColor = SystemColors.ActiveBorder;
            btnAccount.Location = new Point(0, 55);
            btnAccount.Name = "btnAccount";
            btnAccount.Size = new Size(244, 60);
            btnAccount.TabIndex = 0;
            btnAccount.Text = "Account";
            btnAccount.UseVisualStyleBackColor = false;
            btnAccount.Click += btnAccount_Click_1;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(0, 0);
            panel2.TabIndex = 0;
            // 
            // paneltittle
            // 
            paneltittle.AutoSize = true;
            paneltittle.BackColor = SystemColors.Highlight;
            paneltittle.Controls.Add(label1);
            paneltittle.Location = new Point(242, 2);
            paneltittle.Margin = new Padding(3, 2, 3, 2);
            paneltittle.Name = "paneltittle";
            paneltittle.Size = new Size(688, 57);
            paneltittle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Highlight;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(293, 22);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 0;
            label1.Text = "HOME";
            // 
            // carlayout
            // 
            carlayout.AutoScroll = true;
            carlayout.Location = new Point(249, 129);
            carlayout.Margin = new Padding(3, 2, 3, 2);
            carlayout.Name = "carlayout";
            carlayout.Padding = new Padding(18, 4, 18, 15);
            carlayout.Size = new Size(680, 350);
            carlayout.TabIndex = 8;
            // 
            // btn_search
            // 
            btn_search.BackColor = SystemColors.ActiveCaption;
            btn_search.Location = new Point(790, 70);
            btn_search.Margin = new Padding(3, 2, 3, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(85, 28);
            btn_search.TabIndex = 9;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // message
            // 
            message.AutoSize = true;
            message.Location = new Point(501, 110);
            message.Name = "message";
            message.Size = new Size(144, 15);
            message.TabIndex = 10;
            message.Text = "There are any cars to hire !";
            message.Visible = false;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(932, 480);
            Controls.Add(message);
            Controls.Add(btn_search);
            Controls.Add(carlayout);
            Controls.Add(combobrand);
            Controls.Add(paneltittle);
            Controls.Add(txt_search);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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