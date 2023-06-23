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

        private Admin _adminForm;
        private int _subForm;
        public UserDetailForm()
        {
            InitializeComponent();
        }

        public UserDetailForm(int accountId, Admin adminForm)
        {
            InitializeComponent();
            _adminForm = adminForm;
            _subForm = _adminForm.subForm;

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

        public UserDetailForm(int accountId)
        {
            InitializeComponent();

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
                Role = AdminUtils.GetUserRole(_user.Role),
                Status = AdminUtils.GetUserStatus(_user.Status)
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
            btnStatus.Enabled = false;
            btnStatus.Visible = false;
        }

        public void LoadLessee()
        {
            btnStatus.Enabled = true;
            btnStatus.Visible = true;
        }

        public void LoadRenter()
        {
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
            switch (_subForm)
            {
                case 1:
                    _adminForm.LoadUser();
                    break;
                case 2:
                    _adminForm.LoadCar();
                    break;
                case 3:
                    _adminForm.LoadRental();
                    break;
            }
        }
    }
}
