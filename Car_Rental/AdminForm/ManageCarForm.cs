using LibraryRepo.Cars;
using LibraryRepo.Repo;

namespace Car_Rental.AdminForm
{
    public partial class ManageCarForm : Form
    {

        private List<DisplayCar> _listDisplay;

        CarRepo _carRepo;
        UserRepo _userRepo;
        AccountRepo _accountRepo;
        BrandRepo _brandRepo;

        List<Car> _listCar;
        List<User> _listUser;
        List<Account> _listAccount;
        List<Brand> _listBrand;



        public ManageCarForm()
        {
            InitializeComponent();
            LoadList();
        }

        public List<DisplayCar> LoadList()
        {
            _userRepo = new UserRepo();
            _accountRepo = new AccountRepo();
            _carRepo = new CarRepo();
            _brandRepo = new BrandRepo();

            _listUser = _userRepo.getAll();
            _listAccount = _accountRepo.getAll();
            _listCar = _carRepo.getAll();
            _listBrand = _brandRepo.getAll();

            _listDisplay = (from account in _listAccount
                            join user in _listUser on account.AccountId equals user.AccountId
                            join car in _listCar on account.AccountId equals car.AccountId
                            join branch in _listBrand on car.BrandId equals branch.BrandId
                            select new DisplayCar
                            {
                                AccountId = account.AccountId,
                                Fullname = account.Fullname,
                                CarId = car.CarId,
                                Model = car.Model,
                                BranchName = branch.BrandName,
                                Price = car.Price,
                                Status = GetCarStatus(car.Status),
                            }).ToList();


            dgvCar.DataSource = new BindingSource { DataSource = _listDisplay };
            return _listDisplay;
        }

        private string GetCarStatus(int? status)
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

        private int? GetStatusFromCarStatus(string carStatus)
        {
            switch (carStatus)
            {
                case "Active":
                    return 0;
                case "Inactive":
                    return 1;
                default:
                    return null;
            }
        }
    }


    public class DisplayCar
    {
        public int AccountId { get; set; }
        public string Fullname { get; set; }
        public int CarId { get; set; }
        public string Model { get; set; }
        public string BranchName { get; set; }
        public decimal? Price { get; set; }
        public string Status { get; set; } //active = 1, inactive = 0;

    }
}
