using LibraryRepo.Cars;
using LibraryRepo.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental.OwnerForm
{
    public partial class OwnerCarDetail : Form
    {
        private int carId;
        CarRepo _carRepo;
        UserRepo _userRepo;
        AccountRepo _accountRepo;
        BrandRepo _brandRepo;

        Car _car;
        Brand _brand;
        Account _account;

        public OwnerCarDetail()
        {
            InitializeComponent();
        }

        public OwnerCarDetail(int carId)
        {
            InitializeComponent();
            this.carId = carId;
            LoadCar();
        }

        public string GetCarStatus(int? status)
        {
            switch (status)
            {
                case 0:
                    return "Active";
                case 1:
                    return "Inactive";
                default:
                    return string.Empty;
            }
        }

        public Car LoadCar()
        {
            _carRepo = new CarRepo();
            _car = _carRepo.getAll().Where(p => p.CarId == carId).FirstOrDefault();


            //car image
            //string imgPath = _car.Images;
            //Image carImage = Image.FromFile(imgPath);

            //pBCar.Image = carImage;
            //pBCar.SizeMode = PictureBoxSizeMode.Zoom;

            //branch image
            _brandRepo = new BrandRepo();
            _brand = _brandRepo.getAll().Where(p => p.BrandId == _car.BrandId).FirstOrDefault();

            //string imgPathBrand = _brand.Logo;
            //Image brandImage = Image.FromFile(imgPathBrand);

            //pBBranch.Image = brandImage;
            //pBBranch.SizeMode = PictureBoxSizeMode.Zoom;
            //Load text

            txtModel.Text = _car.Model;
            txtType.Text = _car.Type;
            txtSeat.Text = _car.Seats.ToString();
            txtFuel.Text = _car.Fuel;
            txtStatus.Text = GetCarStatus(_car.Status).ToString();
            txtPrice.Text = _car.Price.ToString();
            txtComsumption.Text = _car.Consumption.ToString();
            txtTransmission.Text = _car.Transmission.ToString();
            rtbDes.Text = _car.Describe.ToString();

            _accountRepo = new AccountRepo();
            _account = _accountRepo.getAll().Where(p => p.AccountId == _car.AccountId).FirstOrDefault();

            return _car;
        }
    }
}
