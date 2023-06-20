using LibraryRepo.Cars;
using LibraryRepo.Repo;

namespace Car_Rental.AdminForm
{
    public partial class UserDetailForm : Form
    {
        int AccountId;
        AdminUtils _adminUtils;

        private bool _isActive;
        UserRepo _userRepo;
        AccountRepo _accountRepo;

        User _user;
        Account _account;
        DisplayUser _displayUser;

        private Form previousForm;
        private Admin adminForm;
        public UserDetailForm()
        {
            InitializeComponent();
        }

        public UserDetailForm(int accountId, Form previousForm, Admin adminForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;
            this.adminForm = adminForm;

            AccountId = accountId;
            _user = LoadDetail(accountId);

            switch (_user.Role)
            {
                case 0:
                    LoadAdmin();
                    break;
                case 1:
                    LoadRenter();
                    break;
                case 2:
                    LoadLessee();
                    break;

            }



        }

        public User LoadDetail(int accountId)
        {
            _adminUtils = new AdminUtils();
            _userRepo = new UserRepo();
            _accountRepo = new AccountRepo();
            _adminUtils = new AdminUtils();

            _user = _userRepo.getAll().Where(x => x.AccountId == accountId).FirstOrDefault();
            _account = _accountRepo.getAll().Where(y => y.AccountId == accountId).FirstOrDefault();


            _displayUser = new DisplayUser
            {
                AccountId = _account.AccountId,
                Username = _user.Username,
                Fullname = _account.Fullname,
                Phone = _account.Phone,
                Email = _account.Email,
                Address = _account.Address,
                Role = _adminUtils.GetUserRole(_user.Role),
                Status = _adminUtils.GetUserStatus(_user.Status)
            };

            txtAccountId.Text = _displayUser.AccountId.ToString();
            txtUsername.Text = _displayUser.Username.ToString();
            txtFullname.Text = _displayUser.Fullname.ToString();
            txtPhone.Text = _displayUser.Phone.ToString();
            txtEmail.Text = _displayUser.Email.ToString();
            txtRole.Text = _displayUser.Role;
            txtStatus.Text = _displayUser.Status;
            int? status = _adminUtils.GetStatusFromUserStatus(_displayUser.Status);

            if (status.HasValue)
            {
                if (status.Value == 0) _isActive = true;
                else _isActive = false;
            }

            if (_isActive)
                btnStatus.Text = "Deactivate";
            else
                btnStatus.Text = "Activate";

            return _user;
        }

        public void LoadAdmin()
        {
            btnCar.Enabled = false;
            btnCar.Visible = false;
            btnRental.Enabled = false;
            btnRental.Visible = false;
            btnStatus.Enabled = false;
            btnStatus.Visible = false;
        }

        public void LoadLessee()
        {
            btnCar.Enabled = true;
            btnCar.Visible = true;
            btnRental.Enabled = false;
            btnRental.Visible = false;
            btnStatus.Enabled = true;
            btnStatus.Visible = true;
        }

        public void LoadRenter()
        {
            btnCar.Enabled = false;
            btnCar.Visible = false;
            btnRental.Enabled = true;
            btnRental.Visible = true;
            btnStatus.Enabled = true;
            btnStatus.Visible = true;
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            _userRepo = new UserRepo();
            _user = _userRepo.getAll().Where(x => x.AccountId == AccountId).FirstOrDefault();

            if (_isActive)
            {
                _user.Status = 1;
            }
            else
            {
                _user.Status = 0;
            }

            _userRepo.Update(_user);


            LoadDetail(AccountId);
        }



        private void UserDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            if (previousForm is ManageUserForm manageUserForm)
            {
                manageUserForm.LoadList();

            }
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageRentalForm manageRentalForm = new ManageRentalForm();
            manageRentalForm.LoadList();
            adminForm.OpenChildFormFromOutside(manageRentalForm);
            manageRentalForm.loadRentalByAccountId(AccountId.ToString());
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ManageCarForm manageCarForm = new ManageCarForm();
            manageCarForm.LoadList();
            adminForm.OpenChildFormFromOutside(manageCarForm);
            manageCarForm.loadCarByAccountId(AccountId.ToString());
        }
    }
}
