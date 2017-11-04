using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConfectioneryOrders.Model
{
    class ConfectioneryContext:DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Item> Items { get; set; }

        public ConfectioneryContext(): base()
        {

        }
        public ConfectioneryContext(string name) : base(name) { }
    }
}
