using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConfectioneryOrders.Model
{
    class Order
    {
        public int ID { get; set; }

        public string ClientName { get; set; }
        public string VendorName { get; set; }

        public List<Item> Items { get; set; }

        public Order()
        {
            Items = new List<Item>();
        }
    }
}
