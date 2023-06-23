using LibraryRepo.Cars;
using LibraryRepo.Repo;

namespace Car_Rental.AdminForm
{
    public class AdminUtils
    {
        private static CarRepo _carRepo;
        private static AccountRepo _accountRepo;

        public static string GetCarStatus(int? status)
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

        public static int? GetStatusFromCarStatus(string carStatus)
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

        public static string GetUserRole(int? role)
        {
            switch (role)
            {
                case 0:
                    return "Admin";
                case 1:
                    return "Renter";
                case 2:
                    return "Lessee";
                default:
                    return string.Empty;
            }
        }

        public static string GetUserStatus(int? status)
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

        public int? GetRoleFromUserRole(string userRole)
        {
            switch (userRole)
            {
                case "Admin":
                    return 0;
                case "Renter":
                    return 1;
                case "Lessee":
                    return 2;
                default:
                    return null;
            }
        }

        public int? GetStatusFromUserStatus(string userStatus)
        {
            switch (userStatus)
            {
                case "Active":
                    return 0;
                case "Inactive":
                    return 1;
                default:
                    return null;
            }
        }

        public static string GetOwnerName(int accountId)
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

    }


}
