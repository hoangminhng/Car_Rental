namespace Car_Rental.AdminForm
{
    public class AdminUtils
    {
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

        public int? GetStatusFromCarStatus(string carStatus)
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

        public string GetUserRole(int? role)
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

        public string GetUserStatus(int? status)
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
    }


}
