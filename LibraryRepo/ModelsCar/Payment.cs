using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryRepo.ModelsCar
{
    public partial class Payment
    {
        public int PaymentId { get; set; }
        public int? AccountId { get; set; }
        public decimal? TotalPrice { get; set; }
        public int? Status { get; set; }

        public virtual Account Account { get; set; }
        public virtual RentalDetail PaymentNavigation { get; set; }
    }
}
