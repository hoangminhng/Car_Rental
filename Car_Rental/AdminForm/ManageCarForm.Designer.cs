namespace Car_Rental.AdminForm
{
    partial class ManageCarForm
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
            dgvCar = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCar).BeginInit();
            SuspendLayout();
            // 
            // dgvCar
            // 
            dgvCar.AllowUserToDeleteRows = false;
            dgvCar.AllowUserToOrderColumns = true;
            dgvCar.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCar.Location = new Point(0, 0);
            dgvCar.Name = "dgvCar";
            dgvCar.ReadOnly = true;
            dgvCar.RowHeadersWidth = 51;
            dgvCar.RowTemplate.Height = 29;
            dgvCar.Size = new Size(922, 188);
            dgvCar.TabIndex = 0;
            // 
            // ManageCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 450);
            Controls.Add(dgvCar);
            Name = "ManageCarForm";
            Text = "ManageCarForm";
            ((System.ComponentModel.ISupportInitialize)dgvCar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCar;
    }
}