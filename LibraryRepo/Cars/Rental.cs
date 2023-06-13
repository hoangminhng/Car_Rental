using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryRepo.Cars
{
    public partial class Rental
    {
        public int RentalId { get; set; }
        public int? AccountId { get; set; }
        public int? CarId { get; set; }
        public int? Status { get; set; }

        public virtual Account Account { get; set; }
        public virtual Car Car { get; set; }
        public virtual RentalDetail RentalDetail { get; set; }
    }
}
