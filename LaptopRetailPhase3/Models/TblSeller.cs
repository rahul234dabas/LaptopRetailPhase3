using System;
using System.Collections.Generic;

#nullable disable

namespace LaptopRetailPhase3.Models
{
    public partial class TblSeller
    {
        public TblSeller()
        {
            TblSellerCustomers = new HashSet<TblSellerCustomer>();
        }

        public int Sno { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Password { get; set; }
        public int? Age { get; set; }
        public string Address { get; set; }

        public virtual ICollection<TblSellerCustomer> TblSellerCustomers { get; set; }
    }
}
