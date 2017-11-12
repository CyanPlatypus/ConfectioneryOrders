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
            foreach (var vp in VendorsProducts.Local.Where(vp=>vp.Vendor==null || vp.Product == null).ToList())
            {
                VendorsProducts.Remove(vp);
            }

            foreach (var item in Items.Local.Where(i=>i.Order == null || i.Product == null ).ToList())
            {
                Items.Remove(item);
            }

            foreach (var e in Orders.Local.Where
                (o=>(o.Client==null || o.Vendor == null || o.Items.Count == 0)).ToList())
            {
                Orders.Remove(e);
            }

            return base.SaveChanges();
        }
    }
}
