namespace Car_Rental.AdminForm
{
    partial class ManageUserForm
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
            dgvUser = new DataGridView();
            btnRefresh = new Button();
            btnSearch = new Button();
            txtSearch = new TextBox();
            cbSearchBy = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvUser).BeginInit();
            SuspendLayout();
            // 
            // dgvUser
            // 
            dgvUser.AllowUserToDeleteRows = false;
            dgvUser.AllowUserToOrderColumns = true;
            dgvUser.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUser.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvUser.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUser.Dock = DockStyle.Top;
            dgvUser.Location = new Point(0, 0);
            dgvUser.Margin = new Padding(3, 4, 3, 4);
            dgvUser.Name = "dgvUser";
            dgvUser.ReadOnly = true;
            dgvUser.RowHeadersWidth = 51;
            dgvUser.RowTemplate.Height = 25;
            dgvUser.Size = new Size(929, 393);
            dgvUser.TabIndex = 0;
            dgvUser.CellDoubleClick += dgvUser_CellDoubleClick;
            dgvUser.ColumnHeaderMouseClick += dgvUser_ColumnHeaderMouseClick;
            dgvUser.EditingControlShowing += dgvUser_EditingControlShowing;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.Location = new Point(831, 458);
            btnRefresh.Margin = new Padding(3, 4, 3, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(86, 31);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnSearch
            // 
            btnSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSearch.Location = new Point(831, 401);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(86, 31);
            btnSearch.TabIndex = 2;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // txtSearch
            // 
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSearch.Location = new Point(382, 399);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(297, 27);
            txtSearch.TabIndex = 3;
            // 
            // cbSearchBy
            // 
            cbSearchBy.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            cbSearchBy.FormattingEnabled = true;
            cbSearchBy.Location = new Point(686, 399);
            cbSearchBy.Margin = new Padding(3, 4, 3, 4);
            cbSearchBy.Name = "cbSearchBy";
            cbSearchBy.Size = new Size(138, 28);
            cbSearchBy.TabIndex = 4;
            // 
            // ManageUserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(929, 600);
            Controls.Add(cbSearchBy);
            Controls.Add(txtSearch);
            Controls.Add(btnSearch);
            Controls.Add(btnRefresh);
            Controls.Add(dgvUser);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ManageUserForm";
            Text = "ManageUserForm";
            FormClosed += ManageUserForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvUser;
        private Button btnRefresh;
        private Button btnSearch;
        private TextBox txtSearch;
        private ComboBox cbSearchBy;
    }
}