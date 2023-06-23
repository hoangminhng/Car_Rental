namespace Car_Rental
{
    partial class OwnerCars
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
            imgCar = new PictureBox();
            labelModel = new Label();
            labelBrand = new Label();
            labelPrice = new Label();
            labelStatus = new Label();
            txtModel = new Label();
            txtBrand = new Label();
            txtPrice = new Label();
            txtStatus = new Label();
            label2 = new Label();
            button1 = new Button();
            txtCarID = new TextBox();
            button2 = new Button();
            labelType = new Label();
            txtType = new Label();
            ((System.ComponentModel.ISupportInitialize)imgCar).BeginInit();
            SuspendLayout();
            // 
            // imgCar
            // 
            imgCar.Dock = DockStyle.Top;
            imgCar.Location = new Point(0, 0);
            imgCar.Name = "imgCar";
            imgCar.Size = new Size(244, 146);
            imgCar.SizeMode = PictureBoxSizeMode.Zoom;
            imgCar.TabIndex = 0;
            imgCar.TabStop = false;
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelModel.Location = new Point(3, 149);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(53, 20);
            labelModel.TabIndex = 1;
            labelModel.Text = "Model";
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBrand.Location = new Point(3, 180);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(51, 20);
            labelBrand.TabIndex = 2;
            labelBrand.Text = "Brand";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrice.Location = new Point(0, 247);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(43, 20);
            labelPrice.TabIndex = 3;
            labelPrice.Text = "Price";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatus.Location = new Point(0, 281);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(53, 20);
            labelStatus.TabIndex = 4;
            labelStatus.Text = "Status";
            // 
            // txtModel
            // 
            txtModel.AutoSize = true;
            txtModel.Location = new Point(62, 149);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(46, 20);
            txtModel.TabIndex = 5;
            txtModel.Text = "name";
            // 
            // txtBrand
            // 
            txtBrand.AutoSize = true;
            txtBrand.Location = new Point(62, 180);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(48, 20);
            txtBrand.TabIndex = 6;
            txtBrand.Text = "brand";
            // 
            // txtPrice
            // 
            txtPrice.AutoSize = true;
            txtPrice.Location = new Point(59, 247);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(42, 20);
            txtPrice.TabIndex = 7;
            txtPrice.Text = "price";
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(59, 281);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(47, 20);
            txtStatus.TabIndex = 8;
            txtStatus.Text = "status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 247);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 9;
            label2.Text = "/day";
            // 
            // button1
            // 
            button1.Location = new Point(3, 310);
            button1.Name = "button1";
            button1.Size = new Size(107, 39);
            button1.TabIndex = 10;
            button1.Text = "Delete";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(147, 146);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(97, 27);
            txtCarID.TabIndex = 11;
            txtCarID.Visible = false;
            // 
            // button2
            // 
            button2.Location = new Point(134, 310);
            button2.Name = "button2";
            button2.Size = new Size(107, 39);
            button2.TabIndex = 12;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelType.Location = new Point(3, 217);
            labelType.Name = "labelType";
            labelType.Size = new Size(42, 20);
            labelType.TabIndex = 13;
            labelType.Text = "Type";
            // 
            // txtType
            // 
            txtType.AutoSize = true;
            txtType.Location = new Point(62, 217);
            txtType.Name = "txtType";
            txtType.Size = new Size(38, 20);
            txtType.TabIndex = 14;
            txtType.Text = "type";
            // 
            // OwnerCars
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            Controls.Add(txtType);
            Controls.Add(labelType);
            Controls.Add(button2);
            Controls.Add(txtCarID);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtStatus);
            Controls.Add(txtPrice);
            Controls.Add(txtBrand);
            Controls.Add(txtModel);
            Controls.Add(labelStatus);
            Controls.Add(labelPrice);
            Controls.Add(labelBrand);
            Controls.Add(labelModel);
            Controls.Add(imgCar);
            Name = "OwnerCars";
            Size = new Size(244, 352);
            ((System.ComponentModel.ISupportInitialize)imgCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox imgCar;
        private Label labelModel;
        private Label labelBrand;
        private Label labelPrice;
        private Label labelStatus;
        private Label txtModel;
        private Label txtBrand;
        private Label txtPrice;
        private Label txtStatus;
        private Label label2;
        private Button button1;
        private TextBox txtCarID;
        private Button button2;
        private Label labelType;
        private Label txtType;
    }
}
