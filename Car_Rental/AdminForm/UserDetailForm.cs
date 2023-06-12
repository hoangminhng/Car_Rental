namespace Car_Rental.AdminForm
{
    public partial class UserDetailForm : Form
    {
        public UserDetailForm()
        {
            InitializeComponent();
        }

        public UserDetailForm(DisplayData displayData)
        {
            InitializeComponent();

            txtAccountId.Text = displayData.AccountId.ToString();
            txtUsername.Text = displayData.Username.ToString();
            txtFullname.Text = displayData.Fullname.ToString();
            txtPhone.Text = displayData.Phone.ToString();
            txtEmail.Text = displayData.Email.ToString();
            txtRole.Text = displayData.Role;
            txtStatus.Text = displayData.Status;

        }

    }
}
