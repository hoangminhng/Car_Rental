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
            cbSearchBy = new ComboBox();
            txtSearch = new TextBox();
            btnSearch = new Button();
            btnRefresh = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvRental).BeginInit();
            SuspendLayout();
            // 
            // dgvRental
            // 
            dgvRental.AllowUserToDeleteRows = false;
            dgvRental.AllowUserToOrderColumns = true;
            dgvRental.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRental.Location = new Point(-5, 1);
            dgvRental.Margin = new Padding(3, 2, 3, 2);
            dgvRental.Name = "dgvRental";
            dgvRental.ReadOnly = true;
            dgvRental.RowHeadersWidth = 51;
            dgvRental.RowTemplate.Height = 29;
            dgvRental.Size = new Size(799, 209);
            dgvRental.TabIndex = 1;
            dgvRental.CellDoubleClick += dgvRentalDetail_CellDoubleClick;
            // 
            // cbSearchBy
            // 
            cbSearchBy.FormattingEnabled = true;
            cbSearchBy.Location = new Point(362, 261);
            cbSearchBy.Name = "cbSearchBy";
            cbSearchBy.Size = new Size(121, 23);
            cbSearchBy.TabIndex = 8;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(96, 261);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(260, 23);
            txtSearch.TabIndex = 7;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(489, 262);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 23);
            btnSearch.TabIndex = 6;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(670, 315);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(75, 23);
            btnRefresh.TabIndex = 5;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // ManageRentalForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 366);
            Controls.Add(cbSearchBy);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Controls.Add(dgvRental);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ManageRentalForm";
            Text = "ManageRentalForm";
            Load += ManageRentalForm_Load;
            ((System.ComponentModel.ISupportInitialize)dgvRental).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvRental;
        private ComboBox cbSearchBy;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button btnRefresh;
    }
}