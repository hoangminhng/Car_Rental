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
    public partial class OwnerCarList : Form
    {
        private List<DisplayCar> _listDisplay;

        CarRepo _carRepo;
        BrandRepo _brandRepo;

        List<Car> _listCar;
        List<Brand> _listBrand;

        private int accountId;

        public OwnerCarList()
        {
            InitializeComponent();
        }

        public OwnerCarList(int accountId)
        {
            InitializeComponent();
            LoadList(accountId);
            this.accountId = accountId;
        }

        public List<DisplayCar> LoadList(int accountId)
        {
            _carRepo = new CarRepo();
            _brandRepo = new BrandRepo();

            _listCar = _carRepo.getAll();
            _listBrand = _brandRepo.getAll();

            _listDisplay = (from car in _listCar
                            where car.AccountId == accountId
                            join branch in _listBrand on car.BrandId equals branch.BrandId
                            select new DisplayCar
                            {
                                CarId = car.CarId,
                                Model = car.Model,
                                BranchName = branch.BrandName,
                                Type = car.Type,
                                Seats = car.Seats,
                                Transmission = car.Transmission,
                                Fuel = car.Fuel,
                                Consumption = car.Consumption,
                                Describe = car.Describe,
                                Price = car.Price,
                                Status = car.Status,

                            }).ToList();


            dgvOwnerCar.DataSource = new BindingSource { DataSource = _listDisplay };
            return _listDisplay;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form addCar = new OwnerCarManagement();
            addCar.ShowDialog();
        }
    }

    public class DisplayCar
    {
        public int CarId { get; set; }
        public string Model { get; set; }
        public string BranchName { get; set; }
        public string Type { get; set; }
        public string Images { get; set; }
        public int? Seats { get; set; }
        public string Transmission { get; set; }
        public string Fuel { get; set; }
        public int? Consumption { get; set; }
        public string Describe { get; set; }
        public decimal? Price { get; set; }
        public int? Status { get; set; } //active = 1, inactive = 0;

    }
}
