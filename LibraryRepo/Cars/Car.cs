using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryRepo.Cars
{
    public partial class Car
    {
        public Car()
        {
            Rentals = new HashSet<Rental>();
        }

        public int CarId { get; set; }
        public string Model { get; set; }
        public int BrandId { get; set; }
        public int AccountId { get; set; }
        public string Type { get; set; }
        public string Images { get; set; }
        public int? Seats { get; set; }
        public string Transmission { get; set; }
        public string Fuel { get; set; }
        public int? Consumption { get; set; }
        public string Describe { get; set; }
        public decimal? Price { get; set; }
        public int? Status { get; set; }

        public virtual User Account { get; set; }
        public virtual Brand Brand { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
