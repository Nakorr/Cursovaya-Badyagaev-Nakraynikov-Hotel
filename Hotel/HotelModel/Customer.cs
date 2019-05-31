using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelModel
{
    public class Customer
    {
        public int Id { get; set; }
        public string CustomerFIO { get; set; }
        public string CustomerLogin { get; set; }
        public string CustomerPassword { get; set; }
        public string CustomerMail { get; set; }
        public virtual List<Order> Orders { get; set; }

    }
}
