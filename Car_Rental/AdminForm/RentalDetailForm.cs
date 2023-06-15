using LibraryRepo.Cars;
using LibraryRepo.Repo;

namespace Car_Rental.AdminForm
{
    public partial class RentalDetailForm : Form
    {
        RentalDetailRepo _rentalDetailRepo;
        RentalRepo _rentalRepo;
        private List<RentalDetail> _listRentalDetail;
        private RentalDetail rentalDetail;
        private DisplayRental displayRental;


        public RentalDetailForm()
        {
            InitializeComponent();
        }

        public RentalDetailForm(DisplayRental displayRental)
        {
            InitializeComponent();
            this.displayRental = displayRental;
            LoadDetail(displayRental);
        }

        public void LoadDetail(DisplayRental displayRental)
        {
            _rentalDetailRepo = new RentalDetailRepo();
            _listRentalDetail = _rentalDetailRepo.getAll();

            rentalDetail = _listRentalDetail.FirstOrDefault(rd => rd.RentalDetailId == displayRental.No);

            if (rentalDetail != null)
            {
                txtRentalDetailId.Text = rentalDetail.RentalDetailId.ToString();
                txtRenterName.Text = displayRental.RenterName.ToString();
                txtCarModel.Text = displayRental.Model.ToString();
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RentalDetailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
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
