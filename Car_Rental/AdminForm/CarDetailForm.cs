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

        public CarDetailForm()
        {
            InitializeComponent();
        }

        public CarDetailForm(int carId, Form previousForm)
        {
            InitializeComponent();

            this.previousForm = previousForm;

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
            Application.Exit();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (previousForm is ManageCarForm)
            {
                // Perform action specific to Form1
                ManageCarForm returnForm = new ManageCarForm();
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

        private void btnStatus_Click(object sender, EventArgs e)
        {
            _carRepo = new CarRepo();
            _car = _carRepo.getAll().Where(p => p.CarId == carId).FirstOrDefault();

            _car.Status = 0;

            _carRepo.Update(_car);

            LoadCar();
        }
    }
}
