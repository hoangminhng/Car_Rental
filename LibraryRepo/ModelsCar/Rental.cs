using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryRepo.ModelsCar
{
    public partial class Rental
    {
        public Rental()
        {
            RentalDetails = new HashSet<RentalDetail>();
        }

        public int RentalId { get; set; }
        public int? AccountId { get; set; }
        public int? CarId { get; set; }
        public int? Status { get; set; }

        public virtual Account Account { get; set; }
        public virtual Car Car { get; set; }
        public virtual ICollection<RentalDetail> RentalDetails { get; set; }
    }
}
