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

        Car _car;
        Brand _brand;
        Account _account;
        public CarDetailForm()
        {
            InitializeComponent();
        }

        public CarDetailForm(int carId)
        {
            InitializeComponent();
            LoadCar(carId);
        }

        public Car LoadCar(int carId)
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

            return _car;
        }
    }
}
