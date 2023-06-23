using Car_Rental.AdminForm;
using LibraryRepo.Cars;
using LibraryRepo.Repo;

namespace Car_Rental
{
    public partial class Admin : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        private CarRepo _carRepo;
        private BrandRepo _brandRepo;
        private AccountRepo _accountRepo;
        private RentalRepo _rentalRepo;

        public int subForm; //1,2,3


        public Admin()
        {
            InitializeComponent();
            random = new Random();
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

        private void ActiveButton(object sender)
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
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }

            }
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

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(childForm);
            this.panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }

        public void OpenChildFormFromOutside(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelContainer.Controls.Add(childForm);
            this.panelContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lbTitle.Text = childForm.Text;
        }


        private void btnMngUser_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ManageUserForm(this), sender);
        }

        private void btnMngRental_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new ManageRentalForm(this), sender);
            ActiveButton((Control)sender, "MANAGE RENTAL");
            LoadRental();
        }

        private void btnMngCar_Click(object sender, EventArgs e)
        {
            ActiveButton((Control)sender, "MANAGE CAR");
            LoadCar();
        }

        public void LoadCar() //subform 2
        {
            subForm = 2;
            List<AdminCars> itemCars;
            List<AdminCars> itemCarsFilter;
            _carRepo = new CarRepo();
            _brandRepo = new BrandRepo();
            _accountRepo = new AccountRepo();
            
            List<Car> _listCar = _carRepo.getAll();
            List<Brand> _listBrand = _brandRepo.getAll();
            List<Account> _listAccount = _accountRepo.getAll();
            var _listDisplay = (from car in _listCar
                                join branch in _listBrand on car.BrandId equals branch.BrandId
                                join account in _listAccount on car.AccountId equals account.AccountId
                                select new AdminCars
                                {
                                    Car_ID = car.CarId,
                                    Model = car.Model,
                                    Img = car.Images,
                                    Brandname = branch.BrandName,
                                    Type = car.Type,
                                    Price = car.Price,
                                    Status = GetCarStatus(car.Status),
                                    OwnerName = account.Fullname,
                                    OwnerId = car.AccountId,
                                }).ToList();
            var list = new AdminCars[_listDisplay.Count];
            int i = 0;
            itemCars = new List<AdminCars>();
            itemCarsFilter = new List<AdminCars>();
            panelContainer.Controls.Clear(); // Clear any existing controls in panelContainer

            List<AdminCars> carLabels = new List<AdminCars>(); // Create a list to hold the Label controls
            foreach (var item in _listDisplay)
            {
                var adminCars = new AdminCars(this);
                adminCars.Img = item.Img;
                adminCars.Car_ID = item.Car_ID;
                adminCars.Model = item.Model;
                adminCars.Brandname = item.Brandname;
                adminCars.Type = item.Type;
                adminCars.Price = item.Price;
                adminCars.Status = item.Status;
                adminCars.OwnerName = item.OwnerName;
                adminCars.OwnerId = item.OwnerId;
                //ownerCar.LoadImageAsync();
                itemCars.Add(adminCars);
                itemCarsFilter.Add(adminCars);
                carLabels.Add(adminCars); // Add the carLabel to the list
            }
            panelContainer.Controls.AddRange(carLabels.ToArray()); // Add all the Label controls at once


        }

        public void LoadRental() //subform 3
        {
            subForm = 3;
            List<AdminRentals> itemRentals;
            List<AdminRentals> itemRentalsFilter;
            _carRepo = new CarRepo();
            _brandRepo = new BrandRepo();
            _accountRepo = new AccountRepo();
            _rentalRepo = new RentalRepo();
            List<Car> _listCar = _carRepo.getAll();
            List<Brand> _listBrand = _brandRepo.getAll();
            List<Account> _listAccount = _accountRepo.getAll();
            List<Rental> _listRental = _rentalRepo.getAll();
            var _listDisplay = (from rental in _listRental
                                join car in _listCar on rental.CarId equals car.CarId
                                join account in _listAccount on rental.AccountId equals account.AccountId
                                select new AdminRentals
                                {
                                    RentalId = rental.RentalId,
                                    RenterName = account.Fullname,
                                    OwnerName = GetOwnerName(car.AccountId),
                                    Price = car.Price,
                                    Model = car.Model,
                                    Status = GetRentalStatus(rental.Status),
                                }).ToList();
            var list = new AdminRentals[_listDisplay.Count];
            int i = 0;
            itemRentals = new List<AdminRentals>();
            itemRentalsFilter = new List<AdminRentals>();
            panelContainer.Controls.Clear(); // Clear any existing controls in panelContainer

            List<AdminRentals> rentalLabels = new List<AdminRentals>(); // Create a list to hold the Label controls
            foreach (var item in _listDisplay)
            {
                var adminRentals = new AdminRentals(this);
                adminRentals.RentalId = item.RentalId;
                adminRentals.RenterName = item.RenterName;
                adminRentals.OwnerName = item.OwnerName;
                adminRentals.Model = item.Model;
                adminRentals.Price = item.Price;
                adminRentals.Status = item.Status;

                //ownerCar.LoadImageAsync();
                itemRentals.Add(adminRentals);
                itemRentalsFilter.Add(adminRentals);
                rentalLabels.Add(adminRentals); // Add the carLabel to the list
            }
            panelContainer.Controls.AddRange(rentalLabels.ToArray()); // Add all the Label controls at once


        }

        private string GetOwnerName(int accountId)
        {
            _carRepo = new CarRepo();
            _accountRepo = new AccountRepo();
            List<Car> _listCar = _carRepo.getAll();
            List<Account> _listAccount = _accountRepo.getAll();

            var ownerName = (from car in _listCar
                             join account in _listAccount on car.AccountId equals account.AccountId
                             where account.AccountId == accountId
                             select account.Fullname).FirstOrDefault();

            return ownerName ?? "";
        }


        private string GetRentalStatus(int? status)
        {
            switch (status)
            {
                case 0:
                    return "Rented";
                case 1:
                    return "Renting";
                case 2:
                    return "Ready to rent";
                default:
                    return string.Empty;
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

        private void Admin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
