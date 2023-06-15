using LibraryRepo.Models;
using LibraryRepo.Repo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Rental.CustormerForm
{
    public partial class HireCar : Form
    {
        RentalDetailRepo _rentaldetail;
        PaymentRepo _payment;
        RentalRepo _rental;
        public HireCar(string id, string acc, string price)
        {
            InitializeComponent();
            txt_idrental.Text = id;
            txt_account.Text = acc;
            txt_price.Text = price;
        }

        private void btn_comfirm_Click(object sender, EventArgs e)
        {
            DateTime datepickup = DateTime.Parse(pickupdate.Text);
            DateTime datetimepickup = DateTime.Parse(pickuptime.Text);
            DateTime datetimedropoff = DateTime.Parse(dropofftime.Text);
            TimeSpan datetime = datetimepickup.TimeOfDay;
            string locationpickup = pickuplocation.Text;
            DateTime datedropoff = DateTime.Parse(dropoffdate.Text);
            TimeSpan timedropoff = datetimedropoff.TimeOfDay;
            string locationdropoff = dropofflocation.Text;
            int id = Convert.ToInt32(txt_idrental.Text);
            int idaccount = Convert.ToInt32(txt_account.Text);
            int price = Convert.ToInt32(txt_price.Text);
            _rental = new RentalRepo();
            _rentaldetail = new RentalDetailRepo();
            _payment = new PaymentRepo();
            Payment payment = new Payment();
            if (locationpickup == "" && locationdropoff == "")
            {
                MessageBox.Show("Fill all fields", "Message", MessageBoxButtons.OK);
            }
            else
            {
                RentalDetail rentalDetail = new RentalDetail();
                rentalDetail.PickupDate = datepickup;
                rentalDetail.PickupTime = datetime;
                rentalDetail.PickupLocation = locationpickup;
                rentalDetail.DropOffDate = datedropoff;
                rentalDetail.DropOffTime = timedropoff;
                rentalDetail.DropOffLocation = locationdropoff;
                rentalDetail.RentalId = id;
                _rentaldetail.Create(rentalDetail);
                payment.RentalDetailId = _rentaldetail.getAll().First(r => r.RentalId == id).RentalDetailId;
                payment.AccountId = idaccount;
                payment.Status = 1;
                payment.TotalPrice = price;
                _payment.Create(payment);
                this.Hide();
                MessageBox.Show("Retal car successfully.", "Message", MessageBoxButtons.OK);
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
