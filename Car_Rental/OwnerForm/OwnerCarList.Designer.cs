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
            btnAddNewCar = new Button();
            dgvCarList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // btnAddNewCar
            // 
            btnAddNewCar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAddNewCar.AutoSize = true;
            btnAddNewCar.Location = new Point(633, 283);
            btnAddNewCar.MaximumSize = new Size(155, 67);
            btnAddNewCar.MinimumSize = new Size(155, 67);
            btnAddNewCar.Name = "btnAddNewCar";
            btnAddNewCar.Size = new Size(155, 67);
            btnAddNewCar.TabIndex = 5;
            btnAddNewCar.Text = "Add more";
            btnAddNewCar.UseVisualStyleBackColor = true;
            btnAddNewCar.Click += btnAddNewCar_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCarList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Dock = DockStyle.Top;
            dgvCarList.Location = new Point(0, 0);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.Size = new Size(800, 277);
            dgvCarList.TabIndex = 4;
            dgvCarList.CellDoubleClick += dgvCarList_CellDoubleClick;
            // 
            // OwnerCarList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddNewCar);
            Controls.Add(dgvCarList);
            Name = "OwnerCarList";
            Text = "OwnerCarList";
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddNewCar;
        private DataGridView dgvCarList;
    }
}