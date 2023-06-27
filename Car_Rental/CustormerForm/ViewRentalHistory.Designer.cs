namespace Car_Rental.CustormerForm
{
    partial class ViewRentalHistory
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
            dgvRentalDetail = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvRentalDetail).BeginInit();
            SuspendLayout();
            // 
            // dgvRentalDetail
            // 
            dgvRentalDetail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRentalDetail.Location = new Point(12, 12);
            dgvRentalDetail.Name = "dgvRentalDetail";
            dgvRentalDetail.RowHeadersWidth = 82;
            dgvRentalDetail.RowTemplate.Height = 41;
            dgvRentalDetail.Size = new Size(1029, 556);
            dgvRentalDetail.TabIndex = 0;
            // 
            // ViewRentalHistory
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 639);
            Controls.Add(dgvRentalDetail);
            Name = "ViewRentalHistory";
            Text = "ViewRentalHistory";
            ((System.ComponentModel.ISupportInitialize)dgvRentalDetail).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvRentalDetail;
    }
}