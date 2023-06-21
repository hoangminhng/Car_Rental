namespace Car_Rental
{
    partial class ViewAccountDetails
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtFullname = new TextBox();
            txtUsername = new TextBox();
            txtAccountId = new TextBox();
            btnUpdate = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 143);
            label1.Name = "label1";
            label1.Size = new Size(128, 32);
            label1.TabIndex = 0;
            label1.Text = "Account Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(98, 370);
            label2.Name = "label2";
            label2.Size = new Size(112, 32);
            label2.TabIndex = 1;
            label2.Text = "Fullname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 255);
            label3.Name = "label3";
            label3.Size = new Size(121, 32);
            label3.TabIndex = 1;
            label3.Text = "Username";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 479);
            label4.Name = "label4";
            label4.Size = new Size(82, 32);
            label4.TabIndex = 2;
            label4.Text = "Phone";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 594);
            label5.Name = "label5";
            label5.Size = new Size(71, 32);
            label5.TabIndex = 3;
            label5.Text = "Email";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(98, 713);
            label6.Name = "label6";
            label6.Size = new Size(98, 32);
            label6.TabIndex = 4;
            label6.Text = "Address";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(334, 45);
            label7.Name = "label7";
            label7.Size = new Size(234, 32);
            label7.TabIndex = 5;
            label7.Text = "User Account Details";
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(375, 706);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(429, 39);
            txtAddress.TabIndex = 11;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(375, 591);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(429, 39);
            txtEmail.TabIndex = 10;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(375, 479);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(429, 39);
            txtPhone.TabIndex = 9;
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(375, 370);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(429, 39);
            txtFullname.TabIndex = 8;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(375, 248);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(429, 39);
            txtUsername.TabIndex = 7;
            // 
            // txtAccountId
            // 
            txtAccountId.Location = new Point(375, 140);
            txtAccountId.Name = "txtAccountId";
            txtAccountId.Size = new Size(429, 39);
            txtAccountId.TabIndex = 6;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(375, 819);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(164, 46);
            btnUpdate.TabIndex = 12;
            btnUpdate.Text = "Update Info";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(640, 819);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(164, 46);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Deactivate";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ViewAccountDetails
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 911);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(txtAddress);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtFullname);
            Controls.Add(txtUsername);
            Controls.Add(txtAccountId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewAccountDetails";
            Text = "ViewAccount";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtFullname;
        private TextBox txtUsername;
        private TextBox txtAccountId;
        private Button btnUpdate;
        private Button btnDelete;
    }
}