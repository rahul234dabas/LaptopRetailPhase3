using System;
using System.Collections.Generic;

#nullable disable

namespace LaptopRetailPhase3.Models
{
    public partial class TblLaptop
    {
        public TblLaptop()
        {
            TblCustomers = new HashSet<TblCustomer>();
        }

        public int Sno { get; set; }
        public string LaptopName { get; set; }
        public string ModelNo { get; set; }
        public int? Price { get; set; }
        public string Processor { get; set; }
        public string Ram { get; set; }
        public string Rom { get; set; }

        public virtual ICollection<TblCustomer> TblCustomers { get; set; }
    }
}
