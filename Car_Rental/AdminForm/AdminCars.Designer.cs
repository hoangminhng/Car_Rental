namespace Car_Rental
{
    partial class AdminCars
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
            txtType = new Label();
            labelModel = new Label();
            labelBrand = new Label();
            labelPrice = new Label();
            labelStatus = new Label();
            txtModel = new Label();
            txtBrand = new Label();
            txtPrice = new Label();
            txtStatus = new Label();
            label2 = new Label();
            txtCarID = new TextBox();
            btnViewOwner = new Button();
            labelType = new Label();
            imgCar = new PictureBox();
            label1 = new Label();
            txtOwnerName = new Label();
            btnCarDetail = new Button();
            ((System.ComponentModel.ISupportInitialize)imgCar).BeginInit();
            SuspendLayout();
            // 
            // txtType
            // 
            txtType.AutoSize = true;
            txtType.Location = new Point(53, 175);
            txtType.Name = "txtType";
            txtType.Size = new Size(30, 15);
            txtType.TabIndex = 29;
            txtType.Text = "type";
            // 
            // labelModel
            // 
            labelModel.AutoSize = true;
            labelModel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelModel.Location = new Point(2, 124);
            labelModel.Name = "labelModel";
            labelModel.Size = new Size(42, 15);
            labelModel.TabIndex = 16;
            labelModel.Text = "Model";
            // 
            // labelBrand
            // 
            labelBrand.AutoSize = true;
            labelBrand.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBrand.Location = new Point(2, 147);
            labelBrand.Name = "labelBrand";
            labelBrand.Size = new Size(40, 15);
            labelBrand.TabIndex = 17;
            labelBrand.Text = "Brand";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelPrice.Location = new Point(8, 197);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(35, 15);
            labelPrice.TabIndex = 18;
            labelPrice.Text = "Price";
            // 
            // labelStatus
            // 
            labelStatus.AutoSize = true;
            labelStatus.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelStatus.Location = new Point(-1, 223);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(42, 15);
            labelStatus.TabIndex = 19;
            labelStatus.Text = "Status";
            // 
            // txtModel
            // 
            txtModel.AutoSize = true;
            txtModel.Location = new Point(53, 124);
            txtModel.Name = "txtModel";
            txtModel.Size = new Size(37, 15);
            txtModel.TabIndex = 20;
            txtModel.Text = "name";
            // 
            // txtBrand
            // 
            txtBrand.AutoSize = true;
            txtBrand.Location = new Point(53, 147);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(38, 15);
            txtBrand.TabIndex = 21;
            txtBrand.Text = "brand";
            // 
            // txtPrice
            // 
            txtPrice.AutoSize = true;
            txtPrice.Location = new Point(51, 197);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(33, 15);
            txtPrice.TabIndex = 22;
            txtPrice.Text = "price";
            // 
            // txtStatus
            // 
            txtStatus.AutoSize = true;
            txtStatus.Location = new Point(51, 223);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(38, 15);
            txtStatus.TabIndex = 23;
            txtStatus.Text = "status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(93, 197);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 24;
            label2.Text = "/day";
            // 
            // txtCarID
            // 
            txtCarID.Location = new Point(128, 122);
            txtCarID.Margin = new Padding(3, 2, 3, 2);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(85, 23);
            txtCarID.TabIndex = 26;
            txtCarID.Visible = false;
            // 
            // btnViewOwner
            // 
            btnViewOwner.Location = new Point(0, 271);
            btnViewOwner.Margin = new Padding(3, 2, 3, 2);
            btnViewOwner.Name = "btnViewOwner";
            btnViewOwner.Size = new Size(94, 29);
            btnViewOwner.TabIndex = 27;
            btnViewOwner.Text = "View Owner";
            btnViewOwner.UseVisualStyleBackColor = true;
            btnViewOwner.Click += btnViewOwner_Click;
            // 
            // labelType
            // 
            labelType.AutoSize = true;
            labelType.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelType.Location = new Point(9, 175);
            labelType.Name = "labelType";
            labelType.Size = new Size(33, 15);
            labelType.TabIndex = 28;
            labelType.Text = "Type";
            // 
            // imgCar
            // 
            imgCar.Dock = DockStyle.Top;
            imgCar.Location = new Point(0, 0);
            imgCar.Margin = new Padding(3, 2, 3, 2);
            imgCar.Name = "imgCar";
            imgCar.Size = new Size(227, 110);
            imgCar.SizeMode = PictureBoxSizeMode.Zoom;
            imgCar.TabIndex = 15;
            imgCar.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(-1, 244);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 30;
            label1.Text = "Car Owner";
            // 
            // txtOwnerName
            // 
            txtOwnerName.AutoSize = true;
            txtOwnerName.Location = new Point(71, 244);
            txtOwnerName.Name = "txtOwnerName";
            txtOwnerName.Size = new Size(38, 15);
            txtOwnerName.TabIndex = 31;
            txtOwnerName.Text = "status";
            // 
            // btnCarDetail
            // 
            btnCarDetail.Location = new Point(133, 271);
            btnCarDetail.Margin = new Padding(3, 2, 3, 2);
            btnCarDetail.Name = "btnCarDetail";
            btnCarDetail.Size = new Size(94, 29);
            btnCarDetail.TabIndex = 32;
            btnCarDetail.Text = "View Car Detail";
            btnCarDetail.UseVisualStyleBackColor = true;
            btnCarDetail.Click += btnCarDetail_Click;
            // 
            // AdminCars
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            Controls.Add(btnCarDetail);
            Controls.Add(txtOwnerName);
            Controls.Add(label1);
            Controls.Add(txtType);
            Controls.Add(labelType);
            Controls.Add(btnViewOwner);
            Controls.Add(txtCarID);
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
            Margin = new Padding(3, 2, 3, 2);
            Name = "AdminCars";
            Size = new Size(227, 311);
            ((System.ComponentModel.ISupportInitialize)imgCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtType;
        private Label labelModel;
        private Label labelBrand;
        private Label labelPrice;
        private Label labelStatus;
        private Label txtModel;
        private Label txtBrand;
        private Label txtPrice;
        private Label txtStatus;
        private Label label2;
        private TextBox txtCarID;
        private Button btnViewOwner;
        private Label labelType;
        private PictureBox imgCar;
        private Label label1;
        private Label txtOwnerName;
        private Button btnCarDetail;
    }
}
