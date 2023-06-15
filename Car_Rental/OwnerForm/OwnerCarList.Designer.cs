namespace Car_Rental.OwnerForm
{
    partial class OwnerCarList
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
            dgvOwnerCar = new DataGridView();
            btnAdd = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvOwnerCar).BeginInit();
            SuspendLayout();
            // 
            // dgvOwnerCar
            // 
            dgvOwnerCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOwnerCar.Location = new Point(1, 2);
            dgvOwnerCar.Name = "dgvOwnerCar";
            dgvOwnerCar.RowHeadersWidth = 51;
            dgvOwnerCar.RowTemplate.Height = 29;
            dgvOwnerCar.Size = new Size(798, 267);
            dgvOwnerCar.TabIndex = 0;
            dgvOwnerCar.CellDoubleClick += dgvOwnerCar_CellDoubleClick;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(581, 316);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(155, 67);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add more";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // OwnerCarList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAdd);
            Controls.Add(dgvOwnerCar);
            Name = "OwnerCarList";
            Text = "OwnerCarList";
            ((System.ComponentModel.ISupportInitialize)dgvOwnerCar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOwnerCar;
        private Button btnAdd;
    }
}