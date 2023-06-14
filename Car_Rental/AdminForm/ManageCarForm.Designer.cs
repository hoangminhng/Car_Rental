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
            dgvCar.Margin = new Padding(3, 2, 3, 2);
            dgvCar.Name = "dgvCar";
            dgvCar.ReadOnly = true;
            dgvCar.RowHeadersWidth = 51;
            dgvCar.RowTemplate.Height = 29;
            dgvCar.Size = new Size(807, 180);
            dgvCar.TabIndex = 0;
            dgvCar.CellDoubleClick += dgvCar_CellDoubleClick;
            dgvCar.ColumnHeaderMouseClick += dgvCar_ColumnHeaderMouseClick;
            dgvCar.EditingControlShowing += dgvCar_EditingControlShowing;
            // 
            // ManageCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 338);
            Controls.Add(dgvCar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageCarForm";
            Text = "ManageCarForm";
            ((System.ComponentModel.ISupportInitialize)dgvCar).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvCar;
    }
}