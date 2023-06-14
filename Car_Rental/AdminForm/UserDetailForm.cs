namespace Car_Rental.AdminForm
{
    public partial class UserDetailForm : Form
    {
        public UserDetailForm()
        {
            InitializeComponent();
        }

        public UserDetailForm(DisplayUser displayUser, int? role)
        {
            InitializeComponent();
            switch (role)
            {
                case 0:
                    LoadAdminDetail(displayUser);
                    break;
                case 1:
                    LoadRenterDetail(displayUser);
                    break;
                case 2:
                    LoadLesseeDetail(displayUser);
                    break;

            }

        }

        public void LoadDetail(DisplayUser displayUser)
        {
            txtAccountId.Text = displayUser.AccountId.ToString();
            txtUsername.Text = displayUser.Username.ToString();
            txtFullname.Text = displayUser.Fullname.ToString();
            txtPhone.Text = displayUser.Phone.ToString();
            txtEmail.Text = displayUser.Email.ToString();
            txtRole.Text = displayUser.Role;
            txtStatus.Text = displayUser.Status;
        }

        public void LoadAdminDetail(DisplayUser displayUser)
        {
            LoadDetail(displayUser);
            btnCar.Enabled = false;
            btnCar.Visible = false;
            btnRental.Enabled = false;
            btnRental.Visible = false;
            btnStatus.Enabled = false;
            btnStatus.Visible = false;
        }

        public void LoadLesseeDetail(DisplayUser displayUser)
        {
            LoadDetail(displayUser);
            btnCar.Enabled = true;
            btnCar.Visible = true;
            btnRental.Enabled = true;
            btnRental.Visible = true;
            btnStatus.Enabled = true;
            btnStatus.Visible = true;
        }

        public void LoadRenterDetail(DisplayUser displayUser)
        {
            LoadDetail(displayUser);
            btnCar.Enabled = false;
            btnCar.Visible = false;
            btnRental.Enabled = true;
            btnRental.Visible = true;
            btnStatus.Enabled = true;
            btnStatus.Visible = true;
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            Form rentalForm = new ManageRentalForm(int.Parse(txtAccountId.Text.ToString()));
            rentalForm.ShowDialog();
        }
    }
}
