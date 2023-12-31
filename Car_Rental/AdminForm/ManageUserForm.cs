﻿using LibraryRepo.Cars;
using LibraryRepo.Repo;

namespace Car_Rental.AdminForm
{
    public partial class ManageUserForm : Form
    {
        private bool sortAscending = false;
        private List<DisplayUser> _listDisplay;
        UserRepo _userRepo;
        AccountRepo _accountRepo;
        AdminUtils _adminUtils;

        Admin adminForm;

        List<User> _listUser;
        List<Account> _listAccount;
        public ManageUserForm()
        {
            InitializeComponent();
            LoadList();
        }

        public ManageUserForm(Admin adminForm)
        {
            InitializeComponent();
            this.adminForm = adminForm;
            LoadList();
        }

        public List<DisplayUser> LoadList()
        {
            _userRepo = new UserRepo();
            _accountRepo = new AccountRepo();
            _adminUtils = new AdminUtils();

            _listUser = _userRepo.getAll();
            _listAccount = _accountRepo.getAll();

            _listDisplay = (from account in _listAccount
                            join user in _listUser on account.AccountId equals user.AccountId
                            select new DisplayUser
                            {
                                AccountId = account.AccountId,
                                Username = user.Username,
                                Fullname = account.Fullname,
                                Phone = account.Phone,
                                Email = account.Email,
                                Address = account.Address,
                                Role = AdminUtils.GetUserRole(user.Role),
                                Status = AdminUtils.GetUserStatus(user.Status)
                            }).ToList();


            dgvUser.DataSource = new BindingSource { DataSource = _listDisplay };

            cbSearchBy.Items.Clear();
            foreach (DataGridViewColumn column in dgvUser.Columns)
            {
                cbSearchBy.Items.Add(column.HeaderText);
            }
            cbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            return _listDisplay;

        }

        private void dgvUser_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_listDisplay != null && e.ColumnIndex >= 0 && e.ColumnIndex < dgvUser.Columns.Count)
            {
                string propertyName = dgvUser.Columns[e.ColumnIndex].DataPropertyName;

                if (sortAscending)
                    dgvUser.DataSource = _listDisplay.OrderBy(d => GetPropertyValue(d, propertyName)).ToList();
                else
                    dgvUser.DataSource = _listDisplay.OrderByDescending(d => GetPropertyValue(d, propertyName)).ToList();

                sortAscending = !sortAscending;
            }
        }

        private object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName)?.GetValue(obj, null);
        }

        private void dgvUser_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _adminUtils = new AdminUtils();
            DataGridView dgv = (DataGridView)sender;
            //labelMes.Text = "";
            if (e.RowIndex == dgv.Rows.Count - 1 || e.RowIndex == -1)
            {
            }
            else
            {
                DataGridViewRow clickedRow = dgvUser.Rows[e.RowIndex];
                int accountId = Convert.ToInt32(clickedRow.Cells["AccountId"].Value);

                DisplayUser selectedData = _listDisplay.FirstOrDefault(data => data.AccountId == accountId);
                if (selectedData != null)
                {
                    // Open new form and pass the selectedData to it
                    //UserDetailForm detailsForm = new UserDetailForm(accountId, this, adminForm);
                    //detailsForm.Show();
                }
            }
        }



        private void dgvUser_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            //Disable editting in all cell
            e.Control.Enabled = false;
        }

        private void ManageUserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadList();
        }

        public void SearchUser(string keyword, string searchby)
        {
            dgvUser.ClearSelection();
            dgvUser.CurrentCell = null;

            // Iterate through the DataGridView rows and filter based on the selected header and search string
            foreach (DataGridViewRow row in dgvUser.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells[searchby].Value != null &&
                        row.Cells[searchby].Value.ToString().Contains(keyword))
                    {
                        row.Visible = true;
                    }
                    else
                    {
                        row.Visible = false;
                    }
                }
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchBy = cbSearchBy.SelectedItem as string;
            string keyword = txtSearch.Text;
            SearchUser(keyword, searchBy);
        }
    }
    public class DisplayUser
    {
        public int AccountId { get; set; }
        public string? Username { get; set; }
        public string? Fullname { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public string? Address { get; set; }
        public string? Role { get; set; }
        public string? Status { get; set; }
    }

}
