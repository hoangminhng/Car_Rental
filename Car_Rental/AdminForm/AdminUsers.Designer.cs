namespace Car_Rental.AdminForm
{
    partial class AdminUsers
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

        #region Component Designer generated code

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
            txtId = new Label();
            txtUsername = new Label();
            txtFullname = new Label();
            txtRole = new Label();
            txtStatus = new Label();
            btnDetail = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 6);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 37);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 1;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 69);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Fullname:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 102);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 3;
            label4.Text = "Role:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 132);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 4;
            label5.Text = "Status:";
            // 
            // txtId
            // 
            txtId.AutoSize = true;
            txtId.Location = new Point(94, 6);
            txtId.Name = "txtId";
            txtId.Size = new Size(21, 15);
            txtId.TabIndex = 5;
            txtId.Text = "ID:";
            // 
            // txtUsername
            // 
            txtUsername.AutoSize = true;
            txtUsername.Location = new Point(94, 37);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(63, 15);
            txtUsername.TabIndex = 6;
            txtUsername.Text = "Username:";
            // 
            // txtFullname
            // 
            txtFullname.AutoSize = true;
            txtFullname.Location = new Point(94, 69);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(59, 15);
            txtFullname.TabIndex = 7;
            txtFullname.Text = "Fullname:";
            // 
            // txtRole
            // 
            txtRole.AutoSize = true;
            txtRole.Location = new Point(94, 102);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(59, 15);
            txtRole.TabIndex = 8;
            txtRole.Text = "Fullname:";
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(94, 132);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(59, 15);
            txtStatus.TabIndex = 9;
            txtStatus.Text = "Fullname:";
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(45, 150);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(75, 23);
            btnDetail.TabIndex = 10;
            btnDetail.Text = "View Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // AdminUsers
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(btnDetail);
            Controls.Add(txtStatus);
            Controls.Add(txtRole);
            Controls.Add(txtFullname);
            Controls.Add(txtUsername);
            Controls.Add(txtId);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdminUsers";
            Size = new Size(188, 187);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label txtId;
        private Label txtUsername;
        private Label txtFullname;
        private Label txtRole;
        private Label txtStatus;
        private Button btnDetail;
    }
}
