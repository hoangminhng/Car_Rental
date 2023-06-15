using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryRepo.Cars
{
    public partial class RentalDetail
    {
        public int RentalDetailId { get; set; }
        public DateTime? PickupDate { get; set; }
        public TimeSpan? PickupTime { get; set; }
        public string PickupLocation { get; set; }
        public DateTime? DropOffDate { get; set; }
        public TimeSpan? DropOffTime { get; set; }
        public string DropOffLocation { get; set; }

        public virtual Rental RentalDetailNavigation { get; set; }
        public virtual Payment Payment { get; set; }
    }
}
