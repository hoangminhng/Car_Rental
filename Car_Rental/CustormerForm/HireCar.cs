using LibraryRepo.Cars;
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
        public HireCar(string CarID, string idOwner, string price)
        {
            InitializeComponent();
            txt_idrental.Text = CarID;
            txt_account.Text = idOwner;
            txt_price.Text = price;
        }

        private void btn_comfirm_Click(object sender, EventArgs e)
        {
            int Account_ID = Convert.ToInt32(txt_account.Text);
            int Car_ID = Convert.ToInt32(txt_idrental.Text);


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
            Decimal price = Convert.ToDecimal(txt_price.Text);
            _rental = new RentalRepo();
            _rentaldetail = new RentalDetailRepo();
            _payment = new PaymentRepo();

            if (locationpickup == "" && locationdropoff == "")
            {
                MessageBox.Show("Fill all fields", "Message", MessageBoxButtons.OK);
            }
            else
            {
                //create rental
                Rental rental = new Rental();
                rental.AccountId = Account_ID;
                rental.CarId = Car_ID;
                rental.Status = 2;
                bool isCreateR = _rental.Create(rental);

                int rentalDetailID = rental.RentalId;

                //create rental detail
                RentalDetail rentalDetail = new RentalDetail();
                rentalDetail.RentalDetailId = rentalDetailID;
                rentalDetail.PickupDate = datepickup;
                rentalDetail.PickupTime = datetime;
                rentalDetail.PickupLocation = locationpickup;
                rentalDetail.DropOffDate = datedropoff;
                rentalDetail.DropOffTime = timedropoff;
                rentalDetail.DropOffLocation = locationdropoff;
                bool isCreatedRD = _rentaldetail.Create(rentalDetail);

                //create payment
                Payment payment = new Payment();
                payment.PaymentId = rentalDetailID;
                payment.AccountId = idaccount;
                payment.Status = 1;
                payment.TotalPrice = price;

                bool isCreatedP = _payment.Create(payment);
                if (isCreateR == true && isCreatedP == true && isCreatedRD == true)
                {
                    this.Hide();
                    MessageBox.Show("Retal car successfully.", "Message", MessageBoxButtons.OK);
                }
            }

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
