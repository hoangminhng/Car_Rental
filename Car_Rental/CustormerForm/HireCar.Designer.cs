namespace Car_Rental.CustormerForm
{
    partial class HireCar
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
            pickupdate = new DateTimePicker();
            dropoffdate = new DateTimePicker();
            dropofftime = new DateTimePicker();
            pickuptime = new DateTimePicker();
            pickuplocation = new TextBox();
            dropofflocation = new TextBox();
            btn_comfirm = new Button();
            btn_cancel = new Button();
            txt_idrental = new TextBox();
            txt_account = new TextBox();
            txt_price = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(251, 19);
            label1.Name = "label1";
            label1.Size = new Size(267, 38);
            label1.TabIndex = 0;
            label1.Text = "Rental Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(81, 94);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Pick up Date :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(81, 290);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 2;
            label3.Text = "Drop off Time :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(81, 238);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 3;
            label4.Text = "Drop off Date :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(81, 189);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 4;
            label5.Text = "Pick up Location :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(81, 145);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 5;
            label6.Text = "Pick up Time :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(81, 340);
            label7.Name = "label7";
            label7.Size = new Size(141, 20);
            label7.TabIndex = 6;
            label7.Text = "Drop off Location :";
            // 
            // pickupdate
            // 
            pickupdate.Format = DateTimePickerFormat.Short;
            pickupdate.Location = new Point(286, 87);
            pickupdate.Name = "pickupdate";
            pickupdate.Size = new Size(131, 27);
            pickupdate.TabIndex = 7;
            // 
            // dropoffdate
            // 
            dropoffdate.Format = DateTimePickerFormat.Short;
            dropoffdate.Location = new Point(286, 231);
            dropoffdate.Name = "dropoffdate";
            dropoffdate.Size = new Size(131, 27);
            dropoffdate.TabIndex = 8;
            // 
            // dropofftime
            // 
            dropofftime.Format = DateTimePickerFormat.Time;
            dropofftime.Location = new Point(286, 285);
            dropofftime.Name = "dropofftime";
            dropofftime.Size = new Size(131, 27);
            dropofftime.TabIndex = 9;
            // 
            // pickuptime
            // 
            pickuptime.Format = DateTimePickerFormat.Time;
            pickuptime.Location = new Point(286, 140);
            pickuptime.Name = "pickuptime";
            pickuptime.Size = new Size(131, 27);
            pickuptime.TabIndex = 10;
            // 
            // pickuplocation
            // 
            pickuplocation.Location = new Point(286, 186);
            pickuplocation.Name = "pickuplocation";
            pickuplocation.Size = new Size(437, 27);
            pickuplocation.TabIndex = 11;
            // 
            // dropofflocation
            // 
            dropofflocation.Location = new Point(286, 333);
            dropofflocation.Name = "dropofflocation";
            dropofflocation.Size = new Size(437, 27);
            dropofflocation.TabIndex = 12;
            // 
            // btn_comfirm
            // 
            btn_comfirm.BackColor = SystemColors.MenuHighlight;
            btn_comfirm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_comfirm.Location = new Point(203, 396);
            btn_comfirm.Name = "btn_comfirm";
            btn_comfirm.Size = new Size(106, 42);
            btn_comfirm.TabIndex = 13;
            btn_comfirm.Text = "Comfirm";
            btn_comfirm.UseVisualStyleBackColor = false;
            btn_comfirm.Click += btn_comfirm_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.BackColor = SystemColors.MenuHighlight;
            btn_cancel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btn_cancel.ForeColor = SystemColors.ActiveCaptionText;
            btn_cancel.Location = new Point(427, 396);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(106, 42);
            btn_cancel.TabIndex = 14;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = false;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // txt_idrental
            // 
            txt_idrental.Location = new Point(541, 89);
            txt_idrental.Name = "txt_idrental";
            txt_idrental.Size = new Size(125, 27);
            txt_idrental.TabIndex = 15;
            txt_idrental.Visible = false;
            // 
            // txt_account
            // 
            txt_account.Location = new Point(541, 122);
            txt_account.Name = "txt_account";
            txt_account.Size = new Size(125, 27);
            txt_account.TabIndex = 16;
            txt_account.Visible = false;
            // 
            // txt_price
            // 
            txt_price.Location = new Point(541, 155);
            txt_price.Name = "txt_price";
            txt_price.Size = new Size(125, 27);
            txt_price.TabIndex = 17;
            txt_price.Visible = false;
            // 
            // HireCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(758, 450);
            Controls.Add(txt_price);
            Controls.Add(txt_account);
            Controls.Add(txt_idrental);
            Controls.Add(btn_cancel);
            Controls.Add(btn_comfirm);
            Controls.Add(dropofflocation);
            Controls.Add(pickuplocation);
            Controls.Add(pickuptime);
            Controls.Add(dropofftime);
            Controls.Add(dropoffdate);
            Controls.Add(pickupdate);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "HireCar";
            Text = "HireCar";
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
        private DateTimePicker pickupdate;
        private DateTimePicker dropoffdate;
        private DateTimePicker dropofftime;
        private DateTimePicker pickuptime;
        private TextBox pickuplocation;
        private TextBox dropofflocation;
        private Button btn_comfirm;
        private Button btn_cancel;
        private TextBox txt_idrental;
        private TextBox txt_account;
        private TextBox txt_price;
    }
}