namespace Car_Rental.CustormerForm
{
    partial class CustomerChangePassword
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
            btnConfirm = new Button();
            txtOldPwd = new TextBox();
            txtNewPwd = new TextBox();
            txtConfirmPwd = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(301, 9);
            label1.Name = "label1";
            label1.Size = new Size(200, 32);
            label1.TabIndex = 0;
            label1.Text = "Change Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 117);
            label2.Name = "label2";
            label2.Size = new Size(198, 32);
            label2.TabIndex = 1;
            label2.Text = "Current Password";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 240);
            label3.Name = "label3";
            label3.Size = new Size(166, 32);
            label3.TabIndex = 2;
            label3.Text = "New Password";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 370);
            label4.Name = "label4";
            label4.Size = new Size(204, 32);
            label4.TabIndex = 3;
            label4.Text = "Confirm Password";
            // 
            // btnConfirm
            // 
            btnConfirm.Location = new Point(430, 459);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.Size = new Size(334, 87);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirmed Change";
            btnConfirm.UseVisualStyleBackColor = true;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // txtOldPwd
            // 
            txtOldPwd.Location = new Point(310, 117);
            txtOldPwd.Name = "txtOldPwd";
            txtOldPwd.Size = new Size(418, 39);
            txtOldPwd.TabIndex = 5;
            // 
            // txtNewPwd
            // 
            txtNewPwd.Location = new Point(310, 240);
            txtNewPwd.Name = "txtNewPwd";
            txtNewPwd.Size = new Size(418, 39);
            txtNewPwd.TabIndex = 6;
            // 
            // txtConfirmPwd
            // 
            txtConfirmPwd.Location = new Point(310, 363);
            txtConfirmPwd.Name = "txtConfirmPwd";
            txtConfirmPwd.Size = new Size(418, 39);
            txtConfirmPwd.TabIndex = 7;
            // 
            // CustomerChangePassword
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 568);
            Controls.Add(txtConfirmPwd);
            Controls.Add(txtNewPwd);
            Controls.Add(txtOldPwd);
            Controls.Add(btnConfirm);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CustomerChangePassword";
            Text = "CustomerChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btnConfirm;
        private TextBox txtOldPwd;
        private TextBox txtNewPwd;
        private TextBox txtConfirmPwd;
    }
}