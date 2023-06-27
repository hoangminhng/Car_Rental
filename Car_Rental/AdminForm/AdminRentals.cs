namespace Car_Rental.AdminForm
{
    public partial class AdminRentals : UserControl
    {
        private readonly Admin _adminForm;
        public AdminRentals()
        {
            InitializeComponent();
        }

        public AdminRentals(Admin form)
        {
            InitializeComponent();
            _adminForm = form;
        }

        public int _RentalId;


        public int RentalId
        {
            set
            {
                this._RentalId = value;
                txtRentalId.Text = value.ToString();
            }
            get { return _RentalId; }
        }

        public int _RenterId { get; set; }

        public int RenterId
        {
            set
            {
                this._RenterId = value;
                txtRenter.Text = value.ToString();
            }
            get { return _RenterId; }
        }


        public string _RenterName { get; set; }

        public string RenterName
        {
            set
            {
                this._RenterName = value;
                txtRenter.Text = value.ToString();
            }
            get { return _RenterName; }
        }

        public string _OwnerName { get; set; }
        public string OwnerName
        {
            set
            {
                _OwnerName = value;
                txtOwner.Text = value.ToString();
            }
            get { return _OwnerName; }
        }

        public string _Model { get; set; }

        public string Model
        {
            set
            {
                this._Model = value;
                txtCarModel.Text = value.ToString();
            }
            get { return _Model; }
        }


        public decimal? _Price { get; set; }

        public decimal? Price
        {
            set
            {
                this._Price = value;
                txtTotal.Text = value.ToString();
            }
            get { return _Price; }
        }
        public string _Status { get; set; }

        public string Status
        {
            set
            {
                this._Status = value;
                txtStatus.Text = value.ToString();
            }
            get { return _Status; }
        }

        public string _Img;
        public string Img
        {
            set
            {
                this._Img = value;
                Image carImage = Image.FromFile(Img);
                imgCar.Image = carImage;
                imgCar.SizeMode = PictureBoxSizeMode.Zoom;
            }
            get { return _Img; }
        }

        public int? _ownerId { get; set; }
        public int? _renterId { get; set; }
        public int? _carId { get; set; }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            UserDetailForm userDetailForm = new UserDetailForm((int)_ownerId, _adminForm);
            userDetailForm.Show();
        }


        private void btnDetail_Click(object sender, EventArgs e)
        {
            RentalDetailForm rentalDetailForm = new RentalDetailForm(_RentalId, _adminForm);

            rentalDetailForm.Show();
        }

        private void btnRenter_Click(object sender, EventArgs e)
        {
            UserDetailForm userDetailForm = new UserDetailForm((int)_renterId, _adminForm);
            userDetailForm.Show();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            CarDetailForm carDetailForm = new CarDetailForm((int)_carId, _adminForm);
            carDetailForm.Show();
        }
    }
}
