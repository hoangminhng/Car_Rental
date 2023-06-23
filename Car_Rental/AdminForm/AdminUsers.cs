namespace Car_Rental.AdminForm
{
    public partial class AdminUsers : UserControl
    {
        private Admin _adminForm;

        public AdminUsers()
        {
            InitializeComponent();
        }

        public AdminUsers(Admin form)
        {
            InitializeComponent();
            _adminForm = form;
        }

        public int _id { get; set; }
        public int ID
        {
            set
            {
                _id = value;
                txtId.Text = value.ToString();
            }
            get { return _id; }
        }

        public string _username { get; set; }
        public string Username
        {
            set
            {
                _username = value;
                txtUsername.Text = value;
            }
            get { return _username; }
        }

        public string _fullname { get; set; }
        public string Fullname
        {
            set
            {
                _fullname = value;
                txtFullname.Text = value;
            }
            get { return _fullname; }
        }

        public string _role { get; set; }
        public string Role
        {
            set
            {
                _role = value;
                txtRole.Text = value;
            }
            get { return _role; }
        }

        public string _status { get; set; }
        public string Status
        {
            set
            {
                _status = value;
                txtStatus.Text = value;
            }
            get { return _status; }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            UserDetailForm userDetailForm = new UserDetailForm(ID, _adminForm);
            userDetailForm.Show();
        }
    }
}
