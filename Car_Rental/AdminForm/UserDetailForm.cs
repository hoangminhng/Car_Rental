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
        public UserDetailForm()
        {
            InitializeComponent();
        }

        public UserDetailForm(int accountId, Form previousForm)
        {
            InitializeComponent();
            this.previousForm = previousForm;

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
            btnRental.Enabled = true;
            btnRental.Visible = true;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (previousForm is ManageUserForm)
            {
                // Perform action specific to Form1
                ManageUserForm returnForm = new ManageUserForm();
                returnForm.Show();
            }
            //else if (previousForm is Form2)
            //{
            //    // Perform action specific to Form2
            //    Form2 form2 = (Form2)previousForm;
            //    form2.DoSomethingElse();
            //}
            //else if (previousForm is Form3)
            //{
            //    // Perform action specific to Form3
            //    Form3 form3 = (Form3)previousForm;
            //    form3.DoAnotherThing();
            //}

        }

        private void UserDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
