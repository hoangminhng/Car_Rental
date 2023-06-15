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
            cbSearchBy = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
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
            dgvCar.Size = new Size(807, 206);
            dgvCar.TabIndex = 0;
            dgvCar.CellDoubleClick += dgvCar_CellDoubleClick;
            dgvCar.ColumnHeaderMouseClick += dgvCar_ColumnHeaderMouseClick;
            dgvCar.EditingControlShowing += dgvCar_EditingControlShowing;
            // 
            // cbSearchBy
            // 
            cbSearchBy.FormattingEnabled = true;
            cbSearchBy.Location = new Point(397, 251);
            cbSearchBy.Name = "cbSearchBy";
            cbSearchBy.Size = new Size(121, 23);
            cbSearchBy.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(131, 251);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 23);
            txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(524, 252);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(705, 305);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ManageCarForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(808, 338);
            Controls.Add(cbSearchBy);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Controls.Add(dgvCar);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageCarForm";
            Text = "ManageCarForm";
            ((System.ComponentModel.ISupportInitialize)dgvCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCar;
        private ComboBox cbSearchBy;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
    }
}