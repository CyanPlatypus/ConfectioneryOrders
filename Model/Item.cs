using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConfectioneryOrders.Model
{
    class Item
    {
        public int ID { get; set; }

        public string ProductName { get; set; }

        public int Quantity { get; set; }

        public Order Order { get; set; }
    }
}
