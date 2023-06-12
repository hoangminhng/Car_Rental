using System;
using System.Collections.Generic;

#nullable disable

namespace LibraryRepo.ModelsCar
{
    public partial class Brand
    {
        public Brand()
        {
            Cars = new HashSet<Car>();
        }

        public int BrandId { get; set; }
        public string BrandName { get; set; }
        public string Logo { get; set; }

        public virtual ICollection<Car> Cars { get; set; }
    }
}
