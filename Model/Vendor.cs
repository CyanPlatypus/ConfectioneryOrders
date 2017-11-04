using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfectioneryOrders.Model
{
    public class Vendor
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Phone { get; set; }

        public List<VendorProduct> VendorsProducts { get; set; }

        public Vendor()
        {
            VendorsProducts = new List<VendorProduct>();
        }
    }
}
