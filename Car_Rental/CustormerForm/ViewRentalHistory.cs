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

namespace Car_Rental.CustormerForm
{
    public partial class ViewRentalHistory : Form
    {
        RentalRepo _rentalRepo;
        RentalDetailRepo _rentalDetailRepo;
        AccountRepo _accountRepo;

        List<RentalDetail> listRentalDetails;
        List<Rental> listRental;
        List<Account> listAccount;

        int acc;

        public ViewRentalHistory(int accountId)
        {
            InitializeComponent();

            _rentalRepo = new RentalRepo();
            _rentalDetailRepo = new RentalDetailRepo();
            _accountRepo = new AccountRepo();
            dgvRentalDetail.AutoGenerateColumns = false; // Disable automatic column generation

            dgvRentalDetail.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Rental Detail ID",
                DataPropertyName = "RentalDetailId"
            });

            dgvRentalDetail.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Pickup Date",
                DataPropertyName = "PickupDate"
            });

            dgvRentalDetail.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Pickup Time",
                DataPropertyName = "PickupTime"
            });

            dgvRentalDetail.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Pickup Location",
                DataPropertyName = "PickupLocation"
            });

            dgvRentalDetail.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Drop-Off Date",
                DataPropertyName = "DropOffDate"
            });

            dgvRentalDetail.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Drop-Off Time",
                DataPropertyName = "DropOffTime"
            });

            dgvRentalDetail.Columns.Add(new DataGridViewTextBoxColumn()
            {
                HeaderText = "Drop-Off Location",
                DataPropertyName = "DropOffLocation"
            });


            LoadHistory(accountId);
        }

        public List<RentalDetail> LoadHistory(int accountId)
        {
            //List<RentalDetail> rentalDetails = new List<RentalDetail>();

            listRental = _rentalRepo.getAll();
            listAccount = _accountRepo.getAll();
            listRentalDetails = _rentalDetailRepo.getAll();
            listRentalDetails = (
                from rd in listRentalDetails
                join r in listRental on rd.RentalDetailId equals r.RentalId
                join a in listAccount on r.AccountId equals a.AccountId
                where a.AccountId == accountId
                select new RentalDetail
                {   
                    RentalDetailId = rd.RentalDetailId,
                    PickupDate = rd.PickupDate,
                    PickupTime = rd.PickupTime,
                    PickupLocation = rd.PickupLocation,
                    DropOffDate = rd.DropOffDate,
                    DropOffTime = rd.DropOffTime,
                    DropOffLocation = rd.DropOffLocation,
                }
            ).ToList();

            dgvRentalDetail.DataSource = new BindingSource { DataSource = listRentalDetails };
            return listRentalDetails;
        }
    }
}
