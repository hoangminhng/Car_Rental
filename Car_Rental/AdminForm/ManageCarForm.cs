using LibraryRepo.Cars;
using LibraryRepo.Repo;


namespace Car_Rental.AdminForm
{
    public partial class ManageCarForm : Form
    {
        private bool sortAscending = false;
        private List<DisplayCar> _listDisplay;
        private AdminUtils _adminUtils;

        CarRepo _carRepo;
        UserRepo _userRepo;
        AccountRepo _accountRepo;
        BrandRepo _brandRepo;

        List<Car> _listCar;
        List<User> _listUser;
        List<Account> _listAccount;
        List<Brand> _listBrand;

        int _accountIdToLoadOld;
        Admin adminForm;

        public ManageCarForm()
        {
            InitializeComponent();
            LoadList();
        }

        public ManageCarForm(Admin adminForm)
        {
            this.adminForm = adminForm;
            InitializeComponent();
            LoadList();
        }

        public void LoadList()
        {
            if (_accountIdToLoadOld != 0)
            {
                LoadListOld();
            }
            else
                LoadListNew();
        }

        public List<DisplayCar> LoadListNew()
        {
            _userRepo = new UserRepo();
            _accountRepo = new AccountRepo();
            _carRepo = new CarRepo();
            _brandRepo = new BrandRepo();
            _adminUtils = new AdminUtils();

            _listUser = _userRepo.getAll();
            _listAccount = _accountRepo.getAll();
            _listCar = _carRepo.getAll();
            _listBrand = _brandRepo.getAll();

            _listDisplay = (from account in _listAccount
                            join user in _listUser on account.AccountId equals user.AccountId
                            join car in _listCar on account.AccountId equals car.AccountId
                            join branch in _listBrand on car.BrandId equals branch.BrandId
                            select new DisplayCar
                            {
                                AccountId = account.AccountId,
                                Fullname = account.Fullname,
                                CarId = car.CarId,
                                Model = car.Model,
                                BranchName = branch.BrandName,
                                Price = car.Price,
                                Status = _adminUtils.GetCarStatus(car.Status),
                            }).ToList();


            cbSearchBy.Items.Clear();
            foreach (DataGridViewColumn column in dgvCar.Columns)
            {
                cbSearchBy.Items.Add(column.HeaderText);
            }
            cbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvCar.DataSource = new BindingSource { DataSource = _listDisplay };
            _accountIdToLoadOld = 0;
            return _listDisplay;
        }

        public List<DisplayCar> LoadListOld()
        {
            _userRepo = new UserRepo();
            _accountRepo = new AccountRepo();
            _carRepo = new CarRepo();
            _brandRepo = new BrandRepo();
            _adminUtils = new AdminUtils();

            _listUser = _userRepo.getAll();
            _listAccount = _accountRepo.getAll();
            _listCar = _carRepo.getAll();
            _listBrand = _brandRepo.getAll();

            _listDisplay = (from account in _listAccount
                            where account.AccountId == _accountIdToLoadOld
                            join user in _listUser on account.AccountId equals user.AccountId
                            join car in _listCar on account.AccountId equals car.AccountId
                            join branch in _listBrand on car.BrandId equals branch.BrandId
                            select new DisplayCar
                            {
                                AccountId = account.AccountId,
                                Fullname = account.Fullname,
                                CarId = car.CarId,
                                Model = car.Model,
                                BranchName = branch.BrandName,
                                Price = car.Price,
                                Status = _adminUtils.GetCarStatus(car.Status),
                            }).ToList();


            cbSearchBy.Items.Clear();
            foreach (DataGridViewColumn column in dgvCar.Columns)
            {
                cbSearchBy.Items.Add(column.HeaderText);
            }
            cbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;

            dgvCar.DataSource = new BindingSource { DataSource = _listDisplay };
            return _listDisplay;
        }





        private void dgvCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //labelMes.Text = "";
            if (e.RowIndex == dgv.Rows.Count - 1 || e.RowIndex == -1)
            {
            }
            else
            {
                DataGridViewRow clickedRow = dgvCar.Rows[e.RowIndex];
                int carId = Convert.ToInt32(clickedRow.Cells["CarId"].Value);
                if (carId > 0)
                {
                    CarDetailForm carDetailForm = new CarDetailForm(carId, this, adminForm);

                    carDetailForm.Show();
                }
            }
        }

        private void dgvCar_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (_listDisplay != null && e.ColumnIndex >= 0 && e.ColumnIndex < dgvCar.Columns.Count)
            {
                string propertyName = dgvCar.Columns[e.ColumnIndex].DataPropertyName;

                if (sortAscending)
                    dgvCar.DataSource = _listDisplay.OrderBy(d => GetPropertyValue(d, propertyName)).ToList();
                else
                    dgvCar.DataSource = _listDisplay.OrderByDescending(d => GetPropertyValue(d, propertyName)).ToList();

                sortAscending = !sortAscending;
            }
        }

        private object GetPropertyValue(object obj, string propertyName)
        {
            return obj.GetType().GetProperty(propertyName)?.GetValue(obj, null);
        }

        private void dgvCar_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            //Disable editting in all cell
            e.Control.Enabled = false;
        }

        public void loadCarByAccountId(string accountId)
        {
            dgvCar.ClearSelection();
            dgvCar.CurrentCell = null;
            this._accountIdToLoadOld = int.Parse(accountId);
            foreach (DataGridViewRow row in dgvCar.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells["AccountId"].Value != null &&
                        row.Cells["AccountId"].Value.ToString().Contains(accountId))
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

        public void SearchCar(string keyword, string searchby)
        {
            dgvCar.ClearSelection();
            dgvCar.CurrentCell = null;

            // Iterate through the DataGridView rows and filter based on the selected header and search string
            foreach (DataGridViewRow row in dgvCar.Rows)
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
            SearchCar(keyword, searchBy);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListNew();
        }
    }


    public class DisplayCar
    {
        public int CarId { get; set; }
        public int AccountId { get; set; }
        public string? Fullname { get; set; }
        public string? Model { get; set; }
        public string? BranchName { get; set; }
        public decimal? Price { get; set; }
        public string? Status { get; set; } //active = 1, inactive = 0;

    }
}
