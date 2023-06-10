using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryRepo.Models
{
    public partial class Account
    {
        public Account()
        {
            Payments = new HashSet<Payment>();
            Rentals = new HashSet<Rental>();
        }

        public int AccountId { get; set; }
        public int? UserId { get; set; }
        public string Fullname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public virtual User User { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
