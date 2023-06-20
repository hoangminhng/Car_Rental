namespace Car_Rental.OwnerForm
{
    partial class OwnerCarManagement
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
            panel2 = new Panel();
            btnAdd = new Button();
            label11 = new Label();
            ptCarImage = new PictureBox();
            numPrice = new NumericUpDown();
            label9 = new Label();
            txtDescribe = new RichTextBox();
            label6 = new Label();
            label8 = new Label();
            numConsumption = new NumericUpDown();
            label7 = new Label();
            cbTransmission = new ComboBox();
            numSeat = new NumericUpDown();
            label5 = new Label();
            cbFuel = new ComboBox();
            label4 = new Label();
            cbType = new ComboBox();
            label3 = new Label();
            txtModel = new TextBox();
            label2 = new Label();
            cbBrand = new ComboBox();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptCarImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numConsumption).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numSeat).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnAdd);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(ptCarImage);
            panel2.Controls.Add(numPrice);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtDescribe);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(numConsumption);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(cbTransmission);
            panel2.Controls.Add(numSeat);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(cbFuel);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(cbType);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(txtModel);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(cbBrand);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(842, 465);
            panel2.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(708, 422);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(134, 43);
            btnAdd.TabIndex = 127;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.None;
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(73, 289);
            label11.Name = "label11";
            label11.Size = new Size(72, 25);
            label11.TabIndex = 126;
            label11.Text = "Picute:";
            // 
            // ptCarImage
            // 
            ptCarImage.Anchor = AnchorStyles.None;
            ptCarImage.BorderStyle = BorderStyle.FixedSingle;
            ptCarImage.Location = new Point(151, 289);
            ptCarImage.Margin = new Padding(3, 4, 3, 4);
            ptCarImage.Name = "ptCarImage";
            ptCarImage.Size = new Size(206, 91);
            ptCarImage.SizeMode = PictureBoxSizeMode.StretchImage;
            ptCarImage.TabIndex = 125;
            ptCarImage.TabStop = false;
            ptCarImage.Click += ptCarImage_Click;
            // 
            // numPrice
            // 
            numPrice.Anchor = AnchorStyles.None;
            numPrice.Location = new Point(547, 341);
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
            label9.Location = new Point(483, 341);
            label9.Name = "label9";
            label9.Size = new Size(61, 25);
            label9.TabIndex = 123;
            label9.Text = "Price:";
            // 
            // txtDescribe
            // 
            txtDescribe.Anchor = AnchorStyles.None;
            txtDescribe.Location = new Point(550, 220);
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
            label6.Location = new Point(454, 224);
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
            label8.Location = new Point(415, 111);
            label8.Name = "label8";
            label8.Size = new Size(132, 25);
            label8.TabIndex = 120;
            label8.Text = "Transmission:";
            // 
            // numConsumption
            // 
            numConsumption.Anchor = AnchorStyles.None;
            numConsumption.Location = new Point(550, 164);
            numConsumption.Margin = new Padding(3, 4, 3, 4);
            numConsumption.Name = "numConsumption";
            numConsumption.Size = new Size(206, 27);
            numConsumption.TabIndex = 119;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.None;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(415, 168);
            label7.Name = "label7";
            label7.Size = new Size(138, 25);
            label7.TabIndex = 118;
            label7.Text = "Consumption:";
            // 
            // cbTransmission
            // 
            cbTransmission.Anchor = AnchorStyles.None;
            cbTransmission.FormattingEnabled = true;
            cbTransmission.Items.AddRange(new object[] { "Manual", "Automatic" });
            cbTransmission.Location = new Point(550, 107);
            cbTransmission.Margin = new Padding(3, 4, 3, 4);
            cbTransmission.Name = "cbTransmission";
            cbTransmission.Size = new Size(205, 28);
            cbTransmission.TabIndex = 117;
            // 
            // numSeat
            // 
            numSeat.Anchor = AnchorStyles.None;
            numSeat.Location = new Point(550, 56);
            numSeat.Margin = new Padding(3, 4, 3, 4);
            numSeat.Name = "numSeat";
            numSeat.Size = new Size(206, 27);
            numSeat.TabIndex = 116;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.None;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(480, 53);
            label5.Name = "label5";
            label5.Size = new Size(63, 25);
            label5.TabIndex = 115;
            label5.Text = "Seats:";
            // 
            // cbFuel
            // 
            cbFuel.Anchor = AnchorStyles.None;
            cbFuel.FormattingEnabled = true;
            cbFuel.Items.AddRange(new object[] { "gasoline", "diesel" });
            cbFuel.Location = new Point(151, 220);
            cbFuel.Margin = new Padding(3, 4, 3, 4);
            cbFuel.Name = "cbFuel";
            cbFuel.Size = new Size(205, 28);
            cbFuel.TabIndex = 114;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(89, 224);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 113;
            label4.Text = "Fuel:";
            // 
            // cbType
            // 
            cbType.Anchor = AnchorStyles.None;
            cbType.FormattingEnabled = true;
            cbType.Items.AddRange(new object[] { "Hatchback", "Sedan", "SUV", "MUV", "Coupe", "Convertible", "Pickup Truck" });
            cbType.Location = new Point(151, 157);
            cbType.Margin = new Padding(3, 4, 3, 4);
            cbType.Name = "cbType";
            cbType.Size = new Size(205, 28);
            cbType.TabIndex = 112;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(84, 156);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 111;
            label3.Text = "Type:";
            // 
            // txtModel
            // 
            txtModel.Anchor = AnchorStyles.None;
            txtModel.Location = new Point(151, 103);
            txtModel.Margin = new Padding(3, 4, 3, 4);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(205, 27);
            txtModel.TabIndex = 110;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(72, 103);
            label2.Name = "label2";
            label2.Size = new Size(74, 25);
            label2.TabIndex = 109;
            label2.Text = "Model:";
            // 
            // cbBrand
            // 
            cbBrand.Anchor = AnchorStyles.None;
            cbBrand.FormattingEnabled = true;
            cbBrand.Location = new Point(151, 53);
            cbBrand.Margin = new Padding(3, 4, 3, 4);
            cbBrand.Name = "cbBrand";
            cbBrand.Size = new Size(205, 28);
            cbBrand.TabIndex = 108;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(74, 53);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 107;
            label1.Text = "Brand:";
            // 
            // OwnerCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 481);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OwnerCarManagement";
            Text = "Car";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptCarImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numConsumption).EndInit();
            ((System.ComponentModel.ISupportInitialize)numSeat).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel2;
        private Label label11;
        private PictureBox ptCarImage;
        private NumericUpDown numPrice;
        private Label label9;
        private RichTextBox txtDescribe;
        private Label label6;
        private Label label8;
        private NumericUpDown numConsumption;
        private Label label7;
        private ComboBox cbTransmission;
        private NumericUpDown numSeat;
        private Label label5;
        private ComboBox cbFuel;
        private Label label4;
        private ComboBox cbType;
        private Label label3;
        private TextBox txtModel;
        private Label label2;
        private ComboBox cbBrand;
        private Label label1;
        private Button btnAdd;
    }
}