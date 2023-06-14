namespace Car_Rental.AdminForm
{
    partial class ManageRentalForm
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
            dgvRental = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRental).BeginInit();
            SuspendLayout();
            // 
            // dgvRental
            // 
            dgvRental.AllowUserToDeleteRows = false;
            dgvRental.AllowUserToOrderColumns = true;
            dgvRental.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRental.Location = new Point(-6, 1);
            dgvRental.Name = "dgvRental";
            dgvRental.ReadOnly = true;
            dgvRental.RowHeadersWidth = 51;
            dgvRental.RowTemplate.Height = 29;
            dgvRental.Size = new Size(913, 188);
            dgvRental.TabIndex = 1;
            dgvRental.CellDoubleClick += dgvRentalDetail_CellDoubleClick;
            // 
            // ManageRentalForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 488);
            Controls.Add(dgvRental);
            Name = "ManageRentalForm";
            Text = "ManageRentalForm";
            ((System.ComponentModel.ISupportInitialize)dgvRental).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRental;
    }
}