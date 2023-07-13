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
    public partial class RentalRequest : UserControl
    {
        private UserRepo _userRepo;
        private RentalRepo _rentalRepo;
        private Owner owner;
        public RentalRequest(Owner owner)
        {
            InitializeComponent();
            this.owner = owner;
        }

        private void RentalRequest_Load(object sender, EventArgs e)
        {

        }

        private void txtName_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
        public string _Img;

        private void btnApprove_Click(object sender, EventArgs e)
        {
            _rentalRepo = new RentalRepo();
            Rental rental = _rentalRepo.getAll().Where(x => x.RentalId == Convert.ToInt32(txtRentalID.Text)).FirstOrDefault();
            rental.Status = 1;
            bool isUpdate = _rentalRepo.Update(rental);
            if (isUpdate)
            {
                DialogResult result = MessageBox.Show("Approve success", "Notification", MessageBoxButtons.OK);
                if (owner != null)
                {
                    owner.LoadRequest();
                }
            }
            else
            {
                MessageBox.Show("Fail to approve", "Notification", MessageBoxButtons.OK);
            }
        }

        private void btnReject_Click(object sender, EventArgs e)
        {
            _rentalRepo = new RentalRepo();
            Rental rental = _rentalRepo.getAll().Where(x => x.RentalId == Convert.ToInt32(txtRentalID.Text)).FirstOrDefault();
            rental.Status = 3;
            bool isUpdate = _rentalRepo.Update(rental);
            if (isUpdate)
            {
                DialogResult result = MessageBox.Show("Reject success", "Notification", MessageBoxButtons.OK);
                if (owner != null)
                {
                    owner.LoadRequest();
                }
            }
            else
            {
                MessageBox.Show("Fail to reject", "Notification", MessageBoxButtons.OK);
            }
        }

        public string Img
        {
            set
            {
                this._Img = value;
                Image carImage = Image.FromFile(Img);
                imageCar.Image = carImage;
                imageCar.SizeMode = PictureBoxSizeMode.Zoom;
            }
            get { return _Img; }
        }

        public int _Rentail_ID { get; set; }
        public int Rentail_ID
        {
            set
            {
                this._Rentail_ID = value;
                txtRentalID.Text = value.ToString();
            }
            get { return _Rentail_ID; }
        }

        public int _Customer_ID { get; set; }
        public int Customer_ID
        {
            set
            {
                _userRepo = new UserRepo();
                this._Customer_ID = value;
                txtCustomer_ID.Text = value.ToString();
                var userList = _userRepo.getAll();
                User customer = userList.FirstOrDefault(x => x.AccountId == _Customer_ID);
                txtName.Text = customer.Username;
            }

            get { return _Customer_ID; }
        }

        public int _Car_ID { get; set; }
        public int Car_ID
        {
            set
            {
                this._Car_ID = value;
                txtCarID.Text = value.ToString();
            }
            get { return _Car_ID; }
        }

        public string _status { set; get; }
        public string status
        {
            set
            {
                this._status = value;
                txtStatus.Text = value.ToString();
            }
            get { return _status; }
        }

        public DateTime _PickupDate { get; set; }
        public DateTime PickupDate
        {
            set
            {
                this._PickupDate = value;
                txtPickUpDate.Text = value.ToString("yyyy-MM-dd");
            }
            get { return _PickupDate; }
        }

        public TimeSpan? _PickUpTime { get; set; }
        public TimeSpan? PickUpTime
        {
            set
            {
                this._PickUpTime = value;
                txtPickUpTime.Text = value.ToString();
            }
            get { return _PickUpTime; }
        }

        public string _PickupLocation { get; set; }
        public string PickupLocation
        {
            set
            {
                this._PickupLocation = value;
                txtPickUpLocation.Text = value.ToString();
            }
            get { return _PickupLocation; }
        }

        public DateTime _DropOffDate { get; set; }
        public DateTime DropOffDate
        {
            set
            {
                this._DropOffDate = value;
                txtDropOffDate.Text = value.ToString("yyyy-MM-dd");
            }
            get { return _DropOffDate; }
        }

        public TimeSpan? _DropOffTime { get; set; }
        public TimeSpan? DropOffTime
        {
            set
            {
                this._DropOffTime = value;
                txtDropOffTime.Text = value.ToString();
            }
            get { return _DropOffTime; }
        }

        public string _DropOffLocation { get; set; }
        public string DropOffLocation
        {
            set
            {
                this._DropOffLocation = value;
                txtDropOffLocation.Text = value.ToString();
            }
            get { return _DropOffLocation; }
        }

    }
}
