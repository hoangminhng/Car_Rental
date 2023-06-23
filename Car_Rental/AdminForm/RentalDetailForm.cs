using LibraryRepo.Cars;
using LibraryRepo.Repo;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Car_Rental.AdminForm
{
    public partial class RentalDetailForm : Form
    {
        RentalDetailRepo _rentalDetailRepo;
        RentalRepo _rentalRepo;
        private List<RentalDetail> _listRentalDetail;
        private List<Rental> _listRental;
        private RentalDetail rentalDetail;
        private Rental rental;
        private DisplayRental displayRental;
        private Form previousForm;
        int _carId;
        int _renterId;
        int _rentalId;
        Admin _adminForm;

        private int _subForm;

        public RentalDetailForm()
        {
            InitializeComponent();
        }

        public RentalDetailForm(int rentalId, Admin adminForm)
        {
            InitializeComponent();

            _adminForm = adminForm;
            _subForm = adminForm.subForm;

            _rentalId = rentalId;

            LoadDetail();
        }

        public RentalDetailForm(DisplayRental displayRental, Form previousForm, Admin adminForm)
        {
            this._adminForm = adminForm;
            this.previousForm = previousForm;
            InitializeComponent();
            this.displayRental = displayRental;
            LoadDetail();
        }

        public void LoadDetail()
        {
            _rentalDetailRepo = new RentalDetailRepo();
            _listRentalDetail = _rentalDetailRepo.getAll();

            rentalDetail = _listRentalDetail.FirstOrDefault(rd => rd.RentalDetailId == _rentalId);

            if (rentalDetail != null)
            {
                txtRentalDetailId.Text = rentalDetail.RentalDetailId.ToString();
                //txtRenterName.Text = displayRental.RenterName.ToString();
                //txtCarModel.Text = displayRental.Model.ToString();
                txtPickupDate.Text = rentalDetail.PickupDate.ToString();
                txtPickupTime.Text = rentalDetail.PickupTime.ToString();
                txtPickupLocation.Text = rentalDetail.PickupLocation;
                txtDropOffDate.Text = rentalDetail.DropOffDate.ToString();
                txtDropOffTime.Text = rentalDetail.DropOffTime.ToString();
                txtDropOffLocation.Text = rentalDetail.DropOffLocation;
            }
        }

        private void RentalDetailForm_Load(object sender, EventArgs e)
        {
            this.Hide();
            if (previousForm is ManageRentalForm manageRentalForm)
            {
                manageRentalForm.LoadList();
            }
        }


        private void RentalDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnRenter_Click(object sender, EventArgs e)
        {
            this.Hide();
            //UserDetailForm renter = new UserDetailForm(_renterId, this, adminForm);
            //renter.Show();
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            this.Hide();
            //CarDetailForm car = new CarDetailForm(_carId, this, adminForm);
            //car.Show();
        }
    }

    public class DisplayRentalDetail
    {
        public int RentalDetailId { get; set; }

        public string RenterName { get; set; }
        public string CarModel { get; set; }
        public DateTime? PickupDate { get; set; }
        public TimeSpan? PickupTime { get; set; }
        public string PickupLocation { get; set; }
        public DateTime? DropOffDate { get; set; }
        public TimeSpan? DropOffTime { get; set; }
        public string DropOffLocation { get; set; }
    }
}
