using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryRepo.Cars
{
    public partial class User
    {
        public User()
        {
            Cars = new HashSet<Car>();
        }

        public int AccountId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int? Role { get; set; }
        public int? Status { get; set; }

        public virtual Account Account { get; set; }
        public virtual ICollection<Car> Cars { get; set; }
    }
}
