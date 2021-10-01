using System;
using System.Collections.Generic;

#nullable disable

namespace LaptopRetailPhase3.Models
{
    public partial class TblSellerCustomer
    {
        public int SellerSno { get; set; }
        public int CustomerSno { get; set; }

        public virtual TblCustomer CustomerSnoNavigation { get; set; }
        public virtual TblSeller SellerSnoNavigation { get; set; }
    }
}
