using ConfectioneryOrders.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConfectioneryOrders
{
    public partial class frmMain : Form
    {
        private ConfectioneryContext cContext;

        public frmMain()
        {
            InitializeComponent();

            cContext = new ConfectioneryContext("f");
            cContext.Items.Load();
            cContext.Orders.Load();

            Order o = new Order() { ClientName = "Alice", VendorName = "Bob" };
            Item i = new Item() { ProductName = "cupcacke", Quantity = 40 };
            Item ii = new Item() { ProductName = "bun", Quantity = 30 };
            o.Items.Add(i);
            o.Items.Add(ii);

            cContext.Orders.Add(o);
            cContext.SaveChanges();

            this.Load += FrmMain_Load;
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            grdOrders.DataSource = cContext.Orders.Local.ToBindingList();
        }
    }
}
