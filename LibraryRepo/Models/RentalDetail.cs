using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryRepo.Models
{
    public partial class RentalDetail
    {
        public RentalDetail()
        {
            Payments = new HashSet<Payment>();
        }

        public int RentalDetailId { get; set; }
        public int? RentalId { get; set; }
        public DateTime? PickupDate { get; set; }
        public TimeSpan? PickupTime { get; set; }
        public string PickupLocation { get; set; }
        public DateTime? DropOffDate { get; set; }
        public TimeSpan? DropOffTime { get; set; }
        public string DropOffLocation { get; set; }

        public virtual Rental Rental { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
