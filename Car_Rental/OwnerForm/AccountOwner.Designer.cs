namespace Car_Rental.OwnerForm
{
    partial class AccountOwner
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
            btnUpdate = new Button();
            txtAddress = new TextBox();
            label4 = new Label();
            txtPhone = new TextBox();
            label3 = new Label();
            txtFullName = new TextBox();
            label1 = new Label();
            txtEmail = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(601, 357);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(123, 55);
            btnUpdate.TabIndex = 137;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // txtAddress
            // 
            txtAddress.Anchor = AnchorStyles.None;
            txtAddress.Location = new Point(224, 299);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.MaxLength = 100;
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.ScrollBars = ScrollBars.Both;
            txtAddress.Size = new Size(268, 113);
            txtAddress.TabIndex = 136;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(94, 299);
            label4.Name = "label4";
            label4.Size = new Size(83, 25);
            label4.TabIndex = 135;
            label4.Text = "Address";
            // 
            // txtPhone
            // 
            txtPhone.Anchor = AnchorStyles.None;
            txtPhone.Location = new Point(224, 225);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.MaxLength = 11;
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(268, 27);
            txtPhone.TabIndex = 134;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(94, 224);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 133;
            label3.Text = "Phone";
            // 
            // txtFullName
            // 
            txtFullName.Anchor = AnchorStyles.None;
            txtFullName.Location = new Point(224, 153);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.MaxLength = 50;
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(268, 27);
            txtFullName.TabIndex = 132;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(94, 153);
            label1.Name = "label1";
            label1.Size = new Size(101, 25);
            label1.TabIndex = 131;
            label1.Text = "Full Name";
            // 
            // txtEmail
            // 
            txtEmail.Anchor = AnchorStyles.None;
            txtEmail.Location = new Point(224, 85);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.MaxLength = 50;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(268, 27);
            txtEmail.TabIndex = 130;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(94, 85);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 129;
            label2.Text = "Email";
            // 
            // AccountOwner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnUpdate);
            Controls.Add(txtAddress);
            Controls.Add(label4);
            Controls.Add(txtPhone);
            Controls.Add(label3);
            Controls.Add(txtFullName);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Name = "AccountOwner";
            Size = new Size(818, 497);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUpdate;
        private TextBox txtAddress;
        private Label label4;
        private TextBox txtPhone;
        private Label label3;
        private TextBox txtFullName;
        private Label label1;
        private TextBox txtEmail;
        private Label label2;
    }
}
