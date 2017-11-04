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
        public DbSet<Vendor> Vendors { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<VendorProduct> VendorsProducts { get; set; }

        public ConfectioneryContext(): base()
        {

        }
        public ConfectioneryContext(string name) : base(name) { }

        public override int SaveChanges()
        {


            return base.SaveChanges();
        }
    }
}
