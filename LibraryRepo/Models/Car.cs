using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryRepo.Models
{
    public partial class Car
    {
        public Car()
        {
            Rentals = new HashSet<Rental>();
        }

        public int CarId { get; set; }
        public string Model { get; set; }
        public int? BrandId { get; set; }
        public string Type { get; set; }
        public string Images { get; set; }
        public int? Seats { get; set; }
        public string Transmission { get; set; }
        public string Fuel { get; set; }
        public int? Consumption { get; set; }
        public string Describe { get; set; }
        public int? Price { get; set; }

        public virtual Brand Brand { get; set; }
        public virtual ICollection<Rental> Rentals { get; set; }
    }
}
