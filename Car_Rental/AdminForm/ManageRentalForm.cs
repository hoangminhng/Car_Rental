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

namespace Car_Rental.AdminForm
{
    public partial class ManageRentalForm : Form
    {
        private List<DisplayRental> _listDisplay;
        CarRepo _carRepo;
        AccountRepo _accountRepo;
        RentalRepo _rentalRepo;

        List<Car> _listCar;
        List<Account> _listAccount;
        List<Rental> _listRental;

        private int accountId;

        public ManageRentalForm()
        {
            InitializeComponent();
        }

        public ManageRentalForm(int accountId)
        {
            this.accountId = accountId;
            InitializeComponent();
            LoadList(accountId);
        }

        public List<DisplayRental> LoadList(int accountId)
        {
            _carRepo = new CarRepo();
            _accountRepo = new AccountRepo();
            _rentalRepo = new RentalRepo();

            _listCar = _carRepo.getAll();
            _listAccount = _accountRepo.getAll();
            _listRental = _rentalRepo.getAll();

            _listDisplay = (from rental in _listRental
                            where rental.AccountId == accountId
                            join car in _listCar on rental.CarId equals car.CarId
                            join account in _listAccount on rental.AccountId equals account.AccountId
                            select new DisplayRental
                            {
                                No = rental.RentalId,
                                RenterId = accountId,
                                RenterName = account.Fullname,
                                Model = car.Model,
                                Status = GetRentalStatus(rental.Status),
                            }
                ).ToList();


            dgvRental.DataSource = new BindingSource { DataSource = _listDisplay };
            return _listDisplay;

        }

        private string GetRentalStatus(int? status)
        {
            switch (status)
            {
                case 0:
                    return "Rented";
                case 1:
                    return "Reting";
                case 2:
                    return "Ready to rent";
                default:
                    return string.Empty;
            }
        }

        private void dgvRentalDetail_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            if (e.RowIndex == dgv.Rows.Count - 1 || e.RowIndex == -1)
            {
            }
            else
            {
                DataGridViewRow clickedRow = dgvRental.Rows[e.RowIndex];
                int rentalId = Convert.ToInt32(clickedRow.Cells["No"].Value);

                DisplayRental selectedData = _listDisplay.FirstOrDefault(data => data.No == rentalId);
                if (selectedData != null)
                {
                    RentalDetailForm rentalDetailForm = new RentalDetailForm(selectedData);
                    this.Hide();
                    rentalDetailForm.ShowDialog();
                    this.Show();
                }
            }
        }
    }



    public class DisplayRental
    {
        public int No { get; set; }
        public int? RenterId { get; set; }

        public string RenterName { get; set; }

        public string Model { get; set; }
        public string Status { get; set; }
    }
}
