﻿using Car_Rental.AdminForm;
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
        private UserRepo _userRepo;
        public int subForm; //1,2,3
        private List<AdminRentals> itemRentals;
        private List<AdminCars> itemCars;
        private List<AdminUsers> itemUsers;


        public Admin()
        {
            InitializeComponent();
            random = new Random();
            cbSearchBy.DropDownStyle = ComboBoxStyle.DropDownList;
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
            cbSearchBy.Items.Clear();
            cbSearchBy.Items.Add("ID");
            cbSearchBy.Items.Add("Username");
            cbSearchBy.Items.Add("Fullname");
            cbSearchBy.Items.Add("Role");
            cbSearchBy.Items.Add("Status");
            cbSearchBy.SelectedIndex = 0;


            ActiveButton((Control)sender, "MANAGE USER");
            LoadUser();
        }

        private void btnMngRental_Click(object sender, EventArgs e)
        {
            cbSearchBy.Items.Clear();

            cbSearchBy.Items.Add("Rental ID");
            cbSearchBy.Items.Add("Renter Name");
            cbSearchBy.Items.Add("Owner Name");
            cbSearchBy.Items.Add("Model");
            cbSearchBy.Items.Add("Price");
            cbSearchBy.Items.Add("Status");
            cbSearchBy.SelectedIndex = 0;


            //OpenChildForm(new ManageRentalForm(this), sender);
            ActiveButton((Control)sender, "MANAGE RENTAL");
            LoadRental();
        }

        private void btnMngCar_Click(object sender, EventArgs e)
        {
            cbSearchBy.Items.Clear();

            // Populate the cbSearchBy combobox with search options
            cbSearchBy.Items.Add("Car ID");
            cbSearchBy.Items.Add("Model");
            cbSearchBy.Items.Add("Branch Name");
            cbSearchBy.Items.Add("Type");
            cbSearchBy.Items.Add("Price");
            cbSearchBy.Items.Add("Status");
            cbSearchBy.Items.Add("Owner Name");

            // Set the default selected item
            cbSearchBy.SelectedIndex = 0;
            ActiveButton((Control)sender, "MANAGE CAR");
            LoadCar();
        }

        public void LoadUser() //subform 3
        {
            subForm = 1;

            List<AdminUsers> itemUsersFilter;
            _accountRepo = new AccountRepo();
            _userRepo = new UserRepo();
            List<Account> _listAccount = _accountRepo.getAll();
            List<User> _listUser = _userRepo.getAll();
            var _listDisplay = (from account in _listAccount
                                join user in _listUser on account.AccountId equals user.AccountId
                                select new AdminUsers
                                {
                                    ID = account.AccountId,
                                    Fullname = account.Fullname,
                                    Username = user.Username,
                                    Role = AdminUtils.GetUserRole(user.Role),
                                    Status = AdminUtils.GetUserStatus(user.Status),
                                }).ToList();
            var list = new AdminUsers[_listDisplay.Count];
            int i = 0;
            itemUsers = new List<AdminUsers>();
            itemUsersFilter = new List<AdminUsers>();
            panelContainer.Controls.Clear(); // Clear any existing controls in panelContainer

            List<AdminUsers> rentalLabels = new List<AdminUsers>(); // Create a list to hold the Label controls
            foreach (var item in _listDisplay)
            {
                var adminUser = new AdminUsers(this);
                adminUser.ID = item.ID;
                adminUser.Fullname = item.Fullname;
                adminUser.Username = item.Username;
                adminUser.Role = item.Role;
                adminUser.Status = item.Status;

                itemUsers.Add(adminUser);
                itemUsersFilter.Add(adminUser);
                rentalLabels.Add(adminUser);
            }
            panelContainer.Controls.AddRange(rentalLabels.ToArray()); // Add all the Label controls at once


        }

        public void LoadCar() //subform 2
        {
            subForm = 2;

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
                                    OwnerName = AdminUtils.GetOwnerName(car.AccountId),
                                    Price = car.Price,
                                    Model = car.Model,
                                    Status = GetRentalStatus(rental.Status),
                                    Img = car.Images,
                                    _ownerId = car.AccountId,
                                    _renterId = rental.AccountId,
                                    _carId = car.CarId,
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
                adminRentals.Img = item.Img;
                adminRentals._renterId = item._renterId;
                adminRentals._ownerId = item._ownerId;
                adminRentals._carId = item._carId;

                itemRentals.Add(adminRentals);
                itemRentalsFilter.Add(adminRentals);
                rentalLabels.Add(adminRentals); // Add the carLabel to the list
            }
            panelContainer.Controls.AddRange(rentalLabels.ToArray()); // Add all the Label controls at once


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

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchCriteria = txtSearch.Text;
            string selectedSearchBy = cbSearchBy.SelectedItem.ToString();

            if (subForm == 1)
            {
                List<AdminUsers> filteredUsers;
                switch (selectedSearchBy)
                {
                    case "ID":
                        filteredUsers = itemUsers.Where(u => u.ID.ToString().Contains(searchCriteria)).ToList();
                        break;
                    case "Username":
                        filteredUsers = itemUsers.Where(u => u.Username.ToLower().Contains(searchCriteria.ToLower())).ToList();
                        break;
                    case "Fullname":
                        filteredUsers = itemUsers.Where(u => u.Fullname.ToLower().Contains(searchCriteria.ToLower())).ToList();
                        break;
                    case "Role":
                        filteredUsers = itemUsers.Where(u => u.Role.ToLower().Contains(searchCriteria.ToLower())).ToList();
                        break;
                    case "Status":
                        filteredUsers = itemUsers.Where(u => u.Status.ToLower().Contains(searchCriteria.ToLower())).ToList();
                        break;
                    default:
                        filteredUsers = itemUsers; // No filtering if no valid search criteria is selected
                        break;
                }
                panelContainer.Controls.Clear();
                foreach (var user in filteredUsers)
                {
                    panelContainer.Controls.Add(user);
                }
            }
            if (subForm == 2)
            {

                List<AdminCars> filteredCars;
                switch (selectedSearchBy)
                {
                    case "Car ID":
                        filteredCars = itemCars.Where(c => c.Car_ID.ToString().Contains(searchCriteria)).ToList();
                        break;
                    case "Model":
                        filteredCars = itemCars.Where(c => c.Model.ToLower().Contains(searchCriteria.ToLower())).ToList();
                        break;
                    case "Branch Name":
                        filteredCars = itemCars.Where(c => c.Brandname.ToLower().Contains(searchCriteria.ToLower())).ToList();
                        break;
                    case "Type":
                        filteredCars = itemCars.Where(c => c.Type.ToLower().Contains(searchCriteria.ToLower())).ToList();
                        break;
                    case "Price":
                        filteredCars = itemCars.Where(c => c.Price.ToString().Contains(searchCriteria)).ToList();
                        break;
                    case "Status":
                        filteredCars = itemCars.Where(c => c.Status.ToLower().Contains(searchCriteria.ToLower())).ToList();
                        break;
                    case "Owner Name":
                        filteredCars = itemCars.Where(c => c.OwnerName.ToLower().Contains(searchCriteria.ToLower())).ToList();
                        break;
                    default:
                        filteredCars = itemCars; // No filtering if no valid search criteria is selected
                        break;
                }
                panelContainer.Controls.Clear();
                foreach (var car in filteredCars)
                {
                    panelContainer.Controls.Add(car);
                }

            }

            if (subForm == 3)
            {


                // Filter the itemRentals list based on the selected search criteria
                List<AdminRentals> filteredRentals;
                switch (selectedSearchBy)
                {
                    case "Rental ID":
                        filteredRentals = itemRentals.Where(r => r.RentalId.ToString().Contains(searchCriteria)).ToList();
                        break;
                    case "Renter Name":
                        filteredRentals = itemRentals.Where(r => r.RenterName.ToLower().Contains(searchCriteria)).ToList();
                        break;
                    case "Owner Name":
                        filteredRentals = itemRentals.Where(r => r.OwnerName.ToLower().Contains(searchCriteria)).ToList();
                        break;
                    case "Model":
                        filteredRentals = itemRentals.Where(r => r.Model.ToLower().Contains(searchCriteria)).ToList();
                        break;
                    case "Price":
                        filteredRentals = itemRentals.Where(r => r.Price.ToString().Contains(searchCriteria)).ToList();
                        break;
                    case "Status":
                        filteredRentals = itemRentals.Where(r => r.Status.ToLower().Contains(searchCriteria)).ToList();
                        break;
                    default:
                        filteredRentals = new List<AdminRentals>(); // Empty list if no valid search criteria is selected
                        break;
                }

                // Update the panelContainer to display the filtered results
                panelContainer.Controls.Clear();
                foreach (var rental in filteredRentals)
                {
                    panelContainer.Controls.Add(rental);
                }
            }

        }
    }
}
