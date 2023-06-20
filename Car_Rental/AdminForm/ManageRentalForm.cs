using LibraryRepo.Cars;
using LibraryRepo.Repo;

namespace Car_Rental.AdminForm
{
    public partial class ManageRentalForm : Form
    {
        private List<DisplayRental> _listDisplay;
        CarRepo _carRepo;
        AccountRepo _accountRepo;
        RentalRepo _rentalRepo;

        List<Car> _listCar;
        List<Account> _listAccount;
        List<Rental> _listRental;

        int _accountIdToLoadOld;
        Admin adminForm;


        public ManageRentalForm()
        {
            InitializeComponent();
            LoadList();
        }

        public ManageRentalForm(Admin adminForm)
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
        public List<DisplayRental> LoadListNew()
        {
            _carRepo = new CarRepo();
            _accountRepo = new AccountRepo();
            _rentalRepo = new RentalRepo();

            _listCar = _carRepo.getAll();
            _listAccount = _accountRepo.getAll();
            _listRental = _rentalRepo.getAll();

            _listDisplay = (from rental in _listRental
                            join car in _listCar on rental.CarId equals car.CarId
                            join account in _listAccount on rental.AccountId equals account.AccountId
                            select new DisplayRental
                            {
                                No = rental.RentalId,
                                CarId = car.CarId,
                                RenterId = rental.AccountId,
                                RenterName = account.Fullname,
                                Model = car.Model,
                                Status = GetRentalStatus(rental.Status),
                            }
                ).ToList();

            cbSearchBy.Items.Clear();
            foreach (DataGridViewColumn column in dgvRental.Columns)
            {
                cbSearchBy.Items.Add(column.HeaderText);
            }
            cbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;


            dgvRental.DataSource = new BindingSource { DataSource = _listDisplay };
            _accountIdToLoadOld = 0;
            return _listDisplay;

        }

        public List<DisplayRental> LoadListOld()
        {
            _carRepo = new CarRepo();
            _accountRepo = new AccountRepo();
            _rentalRepo = new RentalRepo();

            _listCar = _carRepo.getAll();
            _listAccount = _accountRepo.getAll();
            _listRental = _rentalRepo.getAll();

            _listDisplay = (from rental in _listRental
                            where rental.AccountId == _accountIdToLoadOld
                            join car in _listCar on rental.CarId equals car.CarId
                            join account in _listAccount on rental.AccountId equals account.AccountId
                            select new DisplayRental
                            {
                                No = rental.RentalId,
                                CarId = car.CarId,
                                RenterId = rental.AccountId,
                                RenterName = account.Fullname,
                                Model = car.Model,
                                Status = GetRentalStatus(rental.Status),
                            }
                ).ToList();

            cbSearchBy.Items.Clear();
            foreach (DataGridViewColumn column in dgvRental.Columns)
            {
                cbSearchBy.Items.Add(column.HeaderText);
            }
            cbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;


            dgvRental.DataSource = new BindingSource { DataSource = _listDisplay };
            return _listDisplay;

        }


        private string GetRentalStatus(int? status)
        {
            switch (status)
            {
                case 0:
                    return "Rented";
                case 1:
                    return "Renting";
                case 2:
                    return "Ready to rent";
                default:
                    return string.Empty;
            }
        }

        private void dgvRentalDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.RowIndex == dgv.Rows.Count - 1 || e.RowIndex == -1)
            {
            }
            else
            {
                DataGridViewRow clickedRow = dgvRental.Rows[e.RowIndex];
                int rentalId = Convert.ToInt32(clickedRow.Cells["No"].Value);

                DisplayRental selectedData = _listDisplay.FirstOrDefault(data => data.No == rentalId);
                if (selectedData != null)
                {
                    RentalDetailForm rentalDetailForm = new RentalDetailForm(selectedData, this, adminForm);
                    rentalDetailForm.ShowDialog();
                    this.Show();
                }
            }
        }

        private void ManageRentalForm_Load(object sender, EventArgs e)
        {
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadListNew();
        }

        public void loadRentalByAccountId(string accountId)
        {
            dgvRental.ClearSelection();
            dgvRental.CurrentCell = null;
            this._accountIdToLoadOld = int.Parse(accountId);
            foreach (DataGridViewRow row in dgvRental.Rows)
            {
                if (!row.IsNewRow)
                {
                    if (row.Cells["RenterId"].Value != null &&
                        row.Cells["RenterId"].Value.ToString().Contains(accountId))
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

        public void SearchRental(string keyword, string searchby)
        {
            dgvRental.ClearSelection();
            dgvRental.CurrentCell = null;

            // Iterate through the DataGridView rows and filter based on the selected header and search string
            foreach (DataGridViewRow row in dgvRental.Rows)
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
            SearchRental(keyword, searchBy);
        }
    }



    public class DisplayRental
    {
        public int No { get; set; }
        public int CarId { get; set; }

        public int? RenterId { get; set; }

        public string RenterName { get; set; }

        public string Model { get; set; }
        public string Status { get; set; }
    }
}
