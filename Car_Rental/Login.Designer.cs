namespace Car_Rental
{
    partial class Login
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
            label3 = new Label();
            textBox1 = new TextBox();
            linkRegister = new LinkLabel();
            btnCancel = new Button();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(359, 326);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 28;
            label3.Text = "New User ?";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(344, 326);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(0, 27);
            textBox1.TabIndex = 27;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Location = new Point(448, 329);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(63, 20);
            linkRegister.TabIndex = 26;
            linkRegister.TabStop = true;
            linkRegister.Text = "Register";
            linkRegister.LinkClicked += linkRegister_LinkClicked;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(485, 268);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(86, 31);
            btnCancel.TabIndex = 25;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(344, 268);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 31);
            btnLogin.TabIndex = 24;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(344, 182);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(227, 27);
            txtPassword.TabIndex = 23;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(344, 98);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(227, 27);
            txtUsername.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 192);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 20;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 102);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 21;
            label1.Text = "Username";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(linkRegister);
            Controls.Add(btnCancel);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private TextBox textBox1;
        private LinkLabel linkRegister;
        private Button btnCancel;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label2;
        private Label label1;
    }
}