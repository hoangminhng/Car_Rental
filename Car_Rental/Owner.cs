using Car_Rental.OwnerForm;
using LibraryRepo.Cars;
using LibraryRepo.Repo;

namespace Car_Rental
{
    public partial class Owner : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private UserControl activeForm;
        private int accoundId;
        private CarRepo _carRepo;
        private BrandRepo _brandRepo;
        private RentalRepo _rentalRepo;
        private RentalDetailRepo _rentalDetailRepo;
        private AccountRepo _accountRepo;


        public Owner(int accountId)
        {
            InitializeComponent();
            random = new Random();
            this.accoundId = accountId;
        }

        private Color SelectThemColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[tempIndex];
            return ColorTranslator.FromHtml(color);
        }

        private void ActiveButton(object sender, string titleHeader)
        {
            DisableButton();
            if (sender != null)
            {
                if (currentButton != (Button)sender)
                {
                    Color color = SelectThemColor();
                    currentButton = (Button)sender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
                    pnlTitle.BackColor = color;
                    panelLogo.BackColor = color;
                    lbTitle.Text = titleHeader;
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }

            }
        }
        private void OpenChildForm(UserControl childForm, object btnSender, string titleHeader)
        {
            panelContainer.Controls.Clear();
            ActiveButton(btnSender, titleHeader);
            activeForm = childForm;
            //childForm.TopLevel = false;
            //childForm.Dock = DockStyle.Top;
            //childForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            //childForm.MaximizeBox = false;
            //childForm.MinimizeBox = false;
            //panelContainer.Controls.Clear();
            panelContainer.Controls.Add(childForm);
            panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = titleHeader;
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }
        private void Owner_Load(object sender, EventArgs e)
        {

        }
        //CRUD thông tin cá nhân
        private void btnMngAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new OwnerForm.AccountOwner(accoundId), sender, "ACCOUNT");
        }
        //xem các yêu cầu thuê xe của khách hàng đối với mình
        private void btnRequest_Click(object sender, EventArgs e)
        {
            ActiveButton(sender, "REQUEST");
            LoadRequest();
        }
        //CRUD car cho thuê của mình
        private void btnMngCar_Click(object sender, EventArgs e)
        {
            ActiveButton((Control)sender, "CAR");
            LoadCar();
        }

        public void LoadCar()
        {
            List<OwnerCars> itemCars;
            List<OwnerCars> itemCarsFilter;
            _carRepo = new CarRepo();
            _brandRepo = new BrandRepo();
            List<Car> _listCar = _carRepo.getAll();
            List<Brand> _listBrand = _brandRepo.getAll();
            var _listDisplay = (from car in _listCar
                                where car.AccountId == accoundId
                                join branch in _listBrand on car.BrandId equals branch.BrandId
                                select new OwnerCars
                                {
                                    Car_ID = car.CarId,
                                    Model = car.Model,
                                    Img = car.Images,
                                    Brandname = branch.BrandName,
                                    Type = car.Type,
                                    Price = car.Price,
                                    Status = GetCarStatus(car.Status),
                                }).ToList();
            var list = new OwnerCars[_listDisplay.Count];
            int i = 0;
            itemCars = new List<OwnerCars>();
            itemCarsFilter = new List<OwnerCars>();
            panelContainer.Controls.Clear(); // Clear any existing controls in panelContainer

            List<OwnerCars> carLabels = new List<OwnerCars>(); // Create a list to hold the Label controls
            foreach (var item in _listDisplay)
            {
                var ownerCar = new OwnerCars();
                ownerCar.Img = item.Img;
                ownerCar.Car_ID = item.Car_ID;
                ownerCar.Model = item.Model;
                ownerCar.Brandname = item.Brandname;
                ownerCar.Type = item.Type;
                ownerCar.Price = item.Price;
                ownerCar.Status = item.Status;
                //ownerCar.LoadImageAsync();
                itemCars.Add(ownerCar);
                itemCarsFilter.Add(ownerCar);
                carLabels.Add(ownerCar); // Add the carLabel to the list
            }
            panelContainer.Controls.AddRange(carLabels.ToArray()); // Add all the Label controls at once
            var addNewCar = new AddNewCar(accoundId, this);
            panelContainer.Controls.Add(addNewCar);
        }

        private void LoadRequest()
        {
            List<RentalRequest> itemCars;
            List<RentalRequest> itemCarsFilter;
            _carRepo = new CarRepo();
            _accountRepo = new AccountRepo();
            _rentalRepo = new RentalRepo();
            _rentalDetailRepo = new RentalDetailRepo();
            DateTime pickupDate = DateTime.Today;
            List<Car> cars = _carRepo.getAll();
            List<Account> accounts = _accountRepo.getAll();
            List<Rental> rentals = _rentalRepo.getAll();
            List<RentalDetail> rentalDetails = _rentalDetailRepo.getAll();
            var _listDisplay = (from car in cars
                                where car.AccountId == accoundId
                                join rental in rentals on car.CarId equals rental.CarId
                                join rentalDetail in rentalDetails on rental.RentalId equals rentalDetail.RentalDetailId
                                select new RentalRequest
                                {
                                    Img = car.Images,
                                    Rentail_ID = rental.RentalId,
                                    Customer_ID = Convert.ToInt32(rental.AccountId),
                                    Car_ID = Convert.ToInt32(rental.CarId),
                                    status = GetCarStatus(rental.Status),
                                    PickupDate = Convert.ToDateTime(rentalDetail.PickupDate),
                                    PickUpTime = rentalDetail.PickupTime,
                                    PickupLocation = rentalDetail.PickupLocation,
                                    DropOffDate = Convert.ToDateTime(rentalDetail.DropOffDate),
                                    DropOffTime = rentalDetail.DropOffTime,
                                    DropOffLocation = rentalDetail.DropOffLocation
                                }).ToList();
            var list = new RentalRequest[_listDisplay.Count];
            int i = 0;
            itemCars = new List<RentalRequest>();
            itemCarsFilter = new List<RentalRequest>();
            panelContainer.Controls.Clear(); // Clear any existing controls in panelContainer

            List<RentalRequest> requestLabels = new List<RentalRequest>(); // Create a list to hold the Label controls
            foreach (var items in _listDisplay)
            {
                var request = new RentalRequest();
                request.Img = items.Img;
                request.Rentail_ID = items.Rentail_ID;
                request.Customer_ID = items.Customer_ID;
                request.Car_ID = items.Car_ID;
                request.status = items.status;
                request.PickupDate = items.PickupDate;
                request.PickUpTime = items.PickUpTime;
                request.PickupLocation = items.PickupLocation;
                request.DropOffDate = items.DropOffDate;
                request.DropOffTime = items.DropOffTime;
                request.DropOffLocation = items.DropOffLocation;
                itemCars.Add(request);
                itemCarsFilter.Add(request);
                requestLabels.Add(request); // Add the carLabel to the list
            }
            panelContainer.Controls.AddRange(requestLabels.ToArray());
        }
        private void btnSignOut_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to sign out?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                Form login = new Login();
                login.ShowDialog();
            }
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

        //public class DisplayCar
        //{
        //    public int CarId { get; set; }
        //    public string Model { get; set; }
        //    public string Images { get; set; }
        //    public string BranchName { get; set; }
        //    public string Type { get; set; }
        //    public decimal? Price { get; set; }
        //    public string Status { get; set; } //active = 1, inactive = 0;
        //}
    }
}
