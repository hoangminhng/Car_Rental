using LibraryRepo.Cars;
using LibraryRepo.Repo;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Car_Rental.OwnerForm
{
    public partial class OwnerUpdateCar : Form
    {
        private int Car_ID;
        private int brandID;
        private string brandName;
        private CarRepo _carRepo;
        private BrandRepo _brandRepo;
        private Owner owner;
        public OwnerUpdateCar(int carID, Owner owner)
        {
            InitializeComponent();
            this.Car_ID = carID;
            this.owner = owner;
            Car car = getCar(carID);

            this.brandID = car.BrandId;

            _brandRepo = new BrandRepo();
            string brandName = _brandRepo.getAll().FirstOrDefault(x => x.BrandId == car.BrandId)?.BrandName;
            cbBrand.Text = brandName;
            txtModel.Text = car.Model;
            cbType.Text = car.Type;
            cbFuel.Text = car.Fuel;

            Image carImage = Image.FromFile(car.Images);
            ptCarImage.Image = carImage;
            ptCarImage.SizeMode = PictureBoxSizeMode.Zoom;

            numSeat.Text = car.Seats.ToString();
            cbTransmission.Text = car.Transmission;
            numConsumption.Text = car.Consumption.ToString();
            txtDescribe.Text = car.Describe;
            numPrice.Text = car.Price.ToString();
        }

        public Car getCar(int carID)
        {
            _carRepo = new CarRepo();
            var cars = _carRepo.getAll();
            var car = cars.First(x => x.CarId == carID);
            Car newCar = new Car()
            {
                CarId = car.CarId,
                Model = car.Model,
                BrandId = car.BrandId,
                AccountId = car.AccountId,
                Type = car.Type,
                Images = car.Images,
                Seats = car.Seats,
                Transmission = car.Transmission,
                Fuel = car.Fuel,
                Consumption = car.Consumption,
                Describe = car.Describe,
                Price = car.Price,
                Status = car.Status
            };
            return car;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _carRepo = new CarRepo();
            Car car = getCar(this.Car_ID);
            car.Price = numPrice.Value;
            bool isUpdated = _carRepo.Update(car);
            if (isUpdated)
            {
                MessageBox.Show("Update car successfully", "Success", MessageBoxButtons.OK);
                if (owner != null)
                {
                    owner.LoadCar();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Fail", "Error", MessageBoxButtons.OK);
            }
        }
    }
}
