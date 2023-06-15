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
                                Model = car.Model,
                                BranchName = branch.BrandName,
                                Type = car.Type,
                                Price = car.Price,
                                Status = GetCarStatus(car.Status),
                            }).ToList();


            dgvOwnerCar.DataSource = new BindingSource { DataSource = _listDisplay };
            return _listDisplay;
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form addCar = new OwnerCarManagement();
            addCar.ShowDialog();
        }

        private void dgvOwnerCar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //labelMes.Text = "";
            if (e.RowIndex == dgv.Rows.Count - 1 || e.RowIndex == -1)
            {
            }
            else
            {
                DataGridViewRow clickedRow = dgvOwnerCar.Rows[e.RowIndex];
                int carId = Convert.ToInt32(clickedRow.Cells["CarId"].Value);
                if (carId > 0)
                {
                    this.Hide();
                    OwnerCarDetail carDetailForm = new OwnerCarDetail(carId);

                    carDetailForm.Show();
                }
            }
        }
    }

    public class DisplayCar
    {
        public string Model { get; set; }
        public string BranchName { get; set; }
        public string Type { get; set; }
        public decimal? Price { get; set; }
        public string Status { get; set; } //active = 1, inactive = 0;

    }
}
