using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryRepo.Cars
{
    public partial class Account
    {
        //public Account()
        //{
        //    Payments = new HashSet<Payment>();
        //    Rentals = new HashSet<Rental>();
        //}

        public int AccountId { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual User AccountNavigation { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
