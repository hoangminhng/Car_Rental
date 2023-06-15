using LibraryRepo.Cars;
using LibraryRepo.Repo;

namespace Car_Rental.AdminForm
{
    public partial class CarDetailForm : Form
    {
        CarRepo _carRepo;
        UserRepo _userRepo;
        AccountRepo _accountRepo;
        BrandRepo _brandRepo;
        private AdminUtils _adminUtils;
        int carId;

        Car _car;
        Brand _brand;
        Account _account;

        private Form previousForm;
        private Admin adminForm;

        public CarDetailForm()
        {
            InitializeComponent();
        }

        public CarDetailForm(int carId, Form previousForm, Admin adminForm)
        {
            InitializeComponent();

            this.previousForm = previousForm;
            this.adminForm = adminForm;

            this.carId = carId;

            LoadCar();
        }

        public Car LoadCar()
        {
            _carRepo = new CarRepo();
            _car = _carRepo.getAll().Where(p => p.CarId == carId).FirstOrDefault();


            //car image
            string imgPath = _car.Images;
            Image carImage = Image.FromFile(imgPath);

            pBCar.Image = carImage;
            pBCar.SizeMode = PictureBoxSizeMode.Zoom;

            //branch image
            _brandRepo = new BrandRepo();
            _brand = _brandRepo.getAll().Where(p => p.BrandId == _car.BrandId).FirstOrDefault();

            string imgPathBrand = _brand.Logo;
            Image brandImage = Image.FromFile(imgPathBrand);

            pBBranch.Image = brandImage;
            pBBranch.SizeMode = PictureBoxSizeMode.Zoom;
            //Load text

            _adminUtils = new AdminUtils();
            txtCarId.Text = carId.ToString();
            txtModel.Text = _car.Model;
            txtType.Text = _car.Type;
            txtSeat.Text = _car.Seats.ToString();
            txtFuel.Text = _car.Fuel;
            txtStatus.Text = _adminUtils.GetCarStatus(_car.Status);
            txtComsumption.Text = _car.Consumption.ToString();
            txtTransmission.Text = _car.Transmission.ToString();
            rtbDes.Text = _car.Describe.ToString();

            _accountRepo = new AccountRepo();
            _account = _accountRepo.getAll().Where(p => p.AccountId == _car.AccountId).FirstOrDefault();

            txtOwnerId.Text = _account.AccountId.ToString();
            txtOwner.Text = _account.Fullname;

            //load button
            if (_car.Status == 1)
            {
                btnStatus.Enabled = true;
                btnStatus.Visible = true;
            }
            else
            {
                btnStatus.Enabled = false;
                btnStatus.Visible = false;
            }

            return _car;
        }

        private void CarDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            if (previousForm is ManageCarForm manageCarForm)
            {
                manageCarForm.LoadList();
            }
        }


        private void btnStatus_Click(object sender, EventArgs e)
        {
            _carRepo = new CarRepo();
            _car = _carRepo.getAll().Where(p => p.CarId == carId).FirstOrDefault();

            _car.Status = 0;

            _carRepo.Update(_car);

            LoadCar();
        }

        private void btnOwner_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserDetailForm detailsForm = new UserDetailForm(_car.AccountId, this, adminForm);
            detailsForm.ShowDialog();
        }
    }
}
