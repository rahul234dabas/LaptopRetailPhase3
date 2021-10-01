using System;
using System.Collections.Generic;

#nullable disable

namespace LaptopRetailPhase3.Models
{
    public partial class TblCustomer
    {
        public TblCustomer()
        {
            TblSellerCustomers = new HashSet<TblSellerCustomer>();
        }

        public int Sno { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public int Age { get; set; }
        public string Pno { get; set; }
        public string Cemail { get; set; }
        public int? LaptopPurchased { get; set; }

        public virtual TblLaptop LaptopPurchasedNavigation { get; set; }
        public virtual ICollection<TblSellerCustomer> TblSellerCustomers { get; set; }
    }
}
