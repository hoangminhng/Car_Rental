namespace Car_Rental.OwnerForm
{
    partial class OwnerUpdateCar
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
            btnUpdate = new Button();
            label11 = new Label();
            ptCarImage = new PictureBox();
            numPrice = new NumericUpDown();
            label9 = new Label();
            txtDescribe = new RichTextBox();
            label6 = new Label();
            label8 = new Label();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            cbType = new Label();
            cbFuel = new Label();
            numSeat = new Label();
            cbTransmission = new Label();
            numConsumption = new Label();
            txtModel = new Label();
            cbBrand = new Label();
            txtCarID = new Label();
            ((System.ComponentModel.ISupportInitialize)ptCarImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(696, 426);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(134, 43);
            btnUpdate.TabIndex = 127;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(52, 285);
            label11.Name = "label11";
            label11.Size = new Size(72, 25);
            label11.TabIndex = 126;
            label11.Text = "Picute:";
            // 
            // ptCarImage
            // 
            ptCarImage.Anchor = AnchorStyles.None;
            ptCarImage.BorderStyle = BorderStyle.FixedSingle;
            ptCarImage.Location = new Point(130, 285);
            ptCarImage.Margin = new Padding(3, 4, 3, 4);
            ptCarImage.Name = "ptCarImage";
            ptCarImage.Size = new Size(206, 91);
            ptCarImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ptCarImage.TabIndex = 125;
            ptCarImage.TabStop = false;
            // 
            // numPrice
            // 
            numPrice.Anchor = AnchorStyles.None;
            numPrice.Location = new Point(526, 337);
            numPrice.Margin = new Padding(3, 4, 3, 4);
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(206, 27);
            numPrice.TabIndex = 124;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.None;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(462, 337);
            label9.Name = "label9";
            label9.Size = new Size(61, 25);
            label9.TabIndex = 123;
            label9.Text = "Price:";
            // 
            // txtDescribe
            // 
            txtDescribe.Anchor = AnchorStyles.None;
            txtDescribe.Location = new Point(529, 216);
            txtDescribe.Margin = new Padding(3, 4, 3, 4);
            txtDescribe.Name = "txtDescribe";
            txtDescribe.Size = new Size(205, 76);
            txtDescribe.TabIndex = 122;
            txtDescribe.Text = "";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.None;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(433, 220);
            label6.Name = "label6";
            label6.Size = new Size(93, 25);
            label6.TabIndex = 121;
            label6.Text = "Describe:";
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.None;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(394, 107);
            label8.Name = "label8";
            label8.Size = new Size(132, 25);
            label8.TabIndex = 120;
            label8.Text = "Transmission:";
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(394, 164);
            label7.Name = "label7";
            label7.Size = new Size(138, 25);
            label7.TabIndex = 118;
            label7.Text = "Consumption:";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(459, 49);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 115;
            label5.Text = "Seats:";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(68, 220);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 113;
            label4.Text = "Fuel:";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(63, 152);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 111;
            label3.Text = "Type:";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(51, 99);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 109;
            label2.Text = "Model:";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(53, 49);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 107;
            label1.Text = "Brand:";
            // 
            // panel2
            // 
            panel2.Controls.Add(cbType);
            panel2.Controls.Add(cbFuel);
            panel2.Controls.Add(numSeat);
            panel2.Controls.Add(cbTransmission);
            panel2.Controls.Add(numConsumption);
            panel2.Controls.Add(txtModel);
            panel2.Controls.Add(cbBrand);
            panel2.Controls.Add(txtCarID);
            panel2.Controls.Add(btnUpdate);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(ptCarImage);
            panel2.Controls.Add(numPrice);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtDescribe);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 478);
            panel2.TabIndex = 2;
            // 
            // cbType
            // 
            cbType.AutoSize = true;
            cbType.Location = new Point(131, 152);
            cbType.Name = "cbType";
            cbType.Size = new Size(58, 20);
            cbType.TabIndex = 135;
            cbType.Text = "label10";
            // 
            // cbFuel
            // 
            cbFuel.AutoSize = true;
            cbFuel.Location = new Point(131, 220);
            cbFuel.Name = "cbFuel";
            cbFuel.Size = new Size(58, 20);
            cbFuel.TabIndex = 134;
            cbFuel.Text = "label10";
            // 
            // numSeat
            // 
            numSeat.AutoSize = true;
            numSeat.Location = new Point(529, 49);
            numSeat.Name = "numSeat";
            numSeat.Size = new Size(58, 20);
            numSeat.TabIndex = 133;
            numSeat.Text = "label10";
            // 
            // cbTransmission
            // 
            cbTransmission.AutoSize = true;
            cbTransmission.Location = new Point(529, 107);
            cbTransmission.Name = "cbTransmission";
            cbTransmission.Size = new Size(58, 20);
            cbTransmission.TabIndex = 132;
            cbTransmission.Text = "label10";
            // 
            // numConsumption
            // 
            numConsumption.AutoSize = true;
            numConsumption.Location = new Point(529, 169);
            numConsumption.Name = "numConsumption";
            numConsumption.Size = new Size(58, 20);
            numConsumption.TabIndex = 131;
            numConsumption.Text = "label10";
            // 
            // txtModel
            // 
            txtModel.AutoSize = true;
            txtModel.Location = new Point(131, 99);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(58, 20);
            txtModel.TabIndex = 130;
            txtModel.Text = "label10";
            // 
            // cbBrand
            // 
            cbBrand.AutoSize = true;
            cbBrand.Location = new Point(130, 49);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(58, 20);
            cbBrand.TabIndex = 129;
            cbBrand.Text = "label10";
            // 
            // txtCarID
            // 
            txtCarID.AutoSize = true;
            txtCarID.Location = new Point(12, 9);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(58, 20);
            txtCarID.TabIndex = 128;
            txtCarID.Text = "label10";
            // 
            // OwnerUpdateCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 481);
            Controls.Add(panel2);
            Name = "OwnerUpdateCar";
            Text = "OwnerUpdateCar";
            ((System.ComponentModel.ISupportInitialize)ptCarImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnUpdate;
        private Label label11;
        private PictureBox ptCarImage;
        private NumericUpDown numPrice;
        private Label label9;
        private RichTextBox txtDescribe;
        private Label label6;
        private Label label8;
        private Label label7;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private Label txtCarID;
        private Label txtModel;
        private Label cbBrand;
        private Label cbType;
        private Label cbFuel;
        private Label numSeat;
        private Label cbTransmission;
        private Label numConsumption;
    }
}