namespace Car_Rental.AdminForm
{
    partial class AdminRentals
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
            btnDetail = new Button();
            btnOwner = new Button();
            txtCarModel = new Label();
            label15 = new Label();
            txtOwner = new Label();
            txtRenter = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            imageCar = new PictureBox();
            btnRenter = new Button();
            btnCar = new Button();
            txtRentalId = new Label();
            label5 = new Label();
            txtTotal = new Label();
            label4 = new Label();
            txtStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)imageCar).BeginInit();
            SuspendLayout();
            // 
            // btnDetail
            // 
            btnDetail.Location = new Point(475, 11);
            btnDetail.Name = "btnDetail";
            btnDetail.Size = new Size(109, 37);
            btnDetail.TabIndex = 41;
            btnDetail.Text = "View Detail";
            btnDetail.UseVisualStyleBackColor = true;
            btnDetail.Click += btnDetail_Click;
            // 
            // btnOwner
            // 
            btnOwner.Location = new Point(475, 53);
            btnOwner.Name = "btnOwner";
            btnOwner.Size = new Size(109, 37);
            btnOwner.TabIndex = 40;
            btnOwner.Text = "View Owner";
            btnOwner.UseVisualStyleBackColor = true;
            // 
            // txtCarModel
            // 
            txtCarModel.AutoSize = true;
            txtCarModel.Location = new Point(335, 113);
            txtCarModel.Name = "txtCarModel";
            txtCarModel.Size = new Size(41, 20);
            txtCarModel.TabIndex = 39;
            txtCarModel.Text = "Price";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(255, 113);
            label15.Name = "label15";
            label15.Size = new Size(78, 20);
            label15.TabIndex = 38;
            label15.Text = "Car Model";
            // 
            // txtOwner
            // 
            txtOwner.AutoSize = true;
            txtOwner.Location = new Point(335, 80);
            txtOwner.Name = "txtOwner";
            txtOwner.Size = new Size(41, 20);
            txtOwner.TabIndex = 33;
            txtOwner.Text = "Date";
            // 
            // txtRenter
            // 
            txtRenter.AutoSize = true;
            txtRenter.Location = new Point(335, 43);
            txtRenter.Name = "txtRenter";
            txtRenter.Size = new Size(41, 20);
            txtRenter.TabIndex = 32;
            txtRenter.Text = "Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(255, 80);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 27;
            label3.Text = "Owner";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(255, 43);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 26;
            label2.Text = "Renter";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(255, 11);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 25;
            label1.Text = "Rental ID";
            // 
            // imageCar
            // 
            imageCar.Dock = DockStyle.Left;
            imageCar.Location = new Point(0, 0);
            imageCar.Name = "imageCar";
            imageCar.Size = new Size(245, 208);
            imageCar.SizeMode = PictureBoxSizeMode.StretchImage;
            imageCar.TabIndex = 24;
            imageCar.TabStop = false;
            // 
            // btnRenter
            // 
            btnRenter.Location = new Point(475, 96);
            btnRenter.Name = "btnRenter";
            btnRenter.Size = new Size(109, 37);
            btnRenter.TabIndex = 42;
            btnRenter.Text = "View Renter";
            btnRenter.UseVisualStyleBackColor = true;
            // 
            // btnCar
            // 
            btnCar.Location = new Point(475, 139);
            btnCar.Name = "btnCar";
            btnCar.Size = new Size(109, 37);
            btnCar.TabIndex = 43;
            btnCar.Text = "View Car";
            btnCar.UseVisualStyleBackColor = true;
            // 
            // txtRentalId
            // 
            txtRentalId.AutoSize = true;
            txtRentalId.Location = new Point(335, 11);
            txtRentalId.Name = "txtRentalId";
            txtRentalId.Size = new Size(41, 20);
            txtRentalId.TabIndex = 44;
            txtRentalId.Text = "Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(255, 148);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 45;
            label5.Text = "Total Price";
            // 
            // txtTotal
            // 
            txtTotal.AutoSize = true;
            txtTotal.Location = new Point(335, 148);
            txtTotal.Name = "txtTotal";
            txtTotal.Size = new Size(41, 20);
            txtTotal.TabIndex = 46;
            txtTotal.Text = "Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(255, 180);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 47;
            label4.Text = "Status";
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(335, 180);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(41, 20);
            txtStatus.TabIndex = 48;
            txtStatus.Text = "Price";
            // 
            // AdminRentals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(txtStatus);
            Controls.Add(label4);
            Controls.Add(txtTotal);
            Controls.Add(label5);
            Controls.Add(txtRentalId);
            Controls.Add(btnCar);
            Controls.Add(btnRenter);
            Controls.Add(btnDetail);
            Controls.Add(btnOwner);
            Controls.Add(txtCarModel);
            Controls.Add(label15);
            Controls.Add(txtOwner);
            Controls.Add(txtRenter);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(imageCar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AdminRentals";
            Size = new Size(627, 208);
            ((System.ComponentModel.ISupportInitialize)imageCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDetail;
        private Button btnOwner;
        private Label txtCarModel;
        private Label label15;
        private Label txtOwner;
        private Label txtRenter;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox imageCar;
        private Button btnRenter;
        private Button btnCar;
        private Label txtRentalId;
        private Label label5;
        private Label txtTotal;
        private Label label4;
        private Label txtStatus;
    }
}
