namespace Car_Rental.AdminForm
{
    partial class RentalDetailForm
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
            txtDropOffLocation = new Label();
            txtDropOffTime = new Label();
            txtDropOffDate = new Label();
            txtPickupLocation = new Label();
            txtPickupTime = new Label();
            txtPickupDate = new Label();
            txtRentalDetailId = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtDropOffLocation
            // 
            txtDropOffLocation.AutoSize = true;
            txtDropOffLocation.Location = new Point(212, 373);
            txtDropOffLocation.Name = "txtDropOffLocation";
            txtDropOffLocation.Size = new Size(132, 20);
            txtDropOffLocation.TabIndex = 27;
            txtDropOffLocation.Text = "Drop Off Location:";
            // 
            // txtDropOffTime
            // 
            txtDropOffTime.AutoSize = true;
            txtDropOffTime.Location = new Point(212, 323);
            txtDropOffTime.Name = "txtDropOffTime";
            txtDropOffTime.Size = new Size(108, 20);
            txtDropOffTime.TabIndex = 26;
            txtDropOffTime.Text = "Drop Off Time:";
            // 
            // txtDropOffDate
            // 
            txtDropOffDate.AutoSize = true;
            txtDropOffDate.Location = new Point(212, 265);
            txtDropOffDate.Name = "txtDropOffDate";
            txtDropOffDate.Size = new Size(107, 20);
            txtDropOffDate.TabIndex = 25;
            txtDropOffDate.Text = "Drop Off Date:";
            // 
            // txtPickupLocation
            // 
            txtPickupLocation.AutoSize = true;
            txtPickupLocation.Location = new Point(212, 208);
            txtPickupLocation.Name = "txtPickupLocation";
            txtPickupLocation.Size = new Size(116, 20);
            txtPickupLocation.TabIndex = 24;
            txtPickupLocation.Text = "Pickup Location:";
            // 
            // txtPickupTime
            // 
            txtPickupTime.AutoSize = true;
            txtPickupTime.Location = new Point(212, 156);
            txtPickupTime.Name = "txtPickupTime";
            txtPickupTime.Size = new Size(92, 20);
            txtPickupTime.TabIndex = 23;
            txtPickupTime.Text = "Pickup Time:";
            // 
            // txtPickupDate
            // 
            txtPickupDate.AutoSize = true;
            txtPickupDate.Location = new Point(212, 100);
            txtPickupDate.Name = "txtPickupDate";
            txtPickupDate.Size = new Size(91, 20);
            txtPickupDate.TabIndex = 22;
            txtPickupDate.Text = "Pickup Date:";
            // 
            // txtRentalDetailId
            // 
            txtRentalDetailId.AutoSize = true;
            txtRentalDetailId.Location = new Point(207, 45);
            txtRentalDetailId.Name = "txtRentalDetailId";
            txtRentalDetailId.Size = new Size(121, 20);
            txtRentalDetailId.TabIndex = 21;
            txtRentalDetailId.Text = "Rentail Detail ID:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 373);
            label7.Name = "label7";
            label7.Size = new Size(132, 20);
            label7.TabIndex = 20;
            label7.Text = "Drop Off Location:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 323);
            label6.Name = "label6";
            label6.Size = new Size(108, 20);
            label6.TabIndex = 19;
            label6.Text = "Drop Off Time:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(78, 265);
            label5.Name = "label5";
            label5.Size = new Size(107, 20);
            label5.TabIndex = 18;
            label5.Text = "Drop Off Date:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(64, 208);
            label4.Name = "label4";
            label4.Size = new Size(116, 20);
            label4.TabIndex = 17;
            label4.Text = "Pickup Location:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(83, 156);
            label3.Name = "label3";
            label3.Size = new Size(92, 20);
            label3.TabIndex = 16;
            label3.Text = "Pickup Time:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(85, 100);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 15;
            label2.Text = "Pickup Date:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 45);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 14;
            label1.Text = "Rental Detail ID:";
            // 
            // RentalDetailForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 608);
            Controls.Add(txtDropOffLocation);
            Controls.Add(txtDropOffTime);
            Controls.Add(txtDropOffDate);
            Controls.Add(txtPickupLocation);
            Controls.Add(txtPickupTime);
            Controls.Add(txtPickupDate);
            Controls.Add(txtRentalDetailId);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "RentalDetailForm";
            Text = "RentalDetailForm";
            FormClosed += RentalDetailForm_FormClosed;
            Load += RentalDetailForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtDropOffLocation;
        private Label txtDropOffTime;
        private Label txtDropOffDate;
        private Label txtPickupLocation;
        private Label txtPickupTime;
        private Label txtPickupDate;
        private Label txtRentalDetailId;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}