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
using ConfectioneryOrders.UC;

namespace ConfectioneryOrders
{
    public partial class frmMain : Form
    {
        private ConfectioneryContext cContext;

        private ucVendors ucVendors;
        private ucProducts ucProducts;
        private ucClients ucClients;

        private frmUcDisplay frmDisplay;

        public frmMain()
        {
            InitializeComponent();

            LoadDB("d");

            ucVendors = new ucVendors(cContext.Vendors.Local.ToBindingList());
            ucProducts = new ucProducts(cContext.Products.Local.ToBindingList());
            ucClients = new ucClients(cContext.Clients.Local.ToBindingList());

            this.tabVendors.Controls.Add(this.ucVendors);
            this.tabProducts.Controls.Add(this.ucProducts);
            this.tabClients.Controls.Add(this.ucClients);

            frmDisplay = new frmUcDisplay();

            //Order o = new Order() { ClientName = "Alice", VendorName = "Bob" };
            //Item i = new Item() { ProductName = "cupcacke", Quantity = 40 };
            //Item ii = new Item() { ProductName = "bun", Quantity = 30 };
            //o.Items.Add(i);
            //o.Items.Add(ii);
            //cContext.Orders.Add(o);

            //cContext.SaveChanges();

            //tabPaneMain.TabIndexChanged += TabPaneMain_TabIndexChanged;
            this.Load += FrmMain_Load;
            this.FormClosing += FrmMain_FormClosing;
        }

        //private void TabPaneMain_TabIndexChanged(object sender, EventArgs e)
        //{
        //    throw new NotImplementedException();
        //}

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            cContext.SaveChanges();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            grdOrders.DataSource = cContext.Orders.Local.ToBindingList();
        }

        private void LoadDB(string n)
        {
            cContext = new ConfectioneryContext(n);
            cContext.Items.Load();
            cContext.Orders.Load();
            cContext.Clients.Load();
            cContext.Products.Load();
            cContext.Vendors.Load();
            cContext.VendorsProducts.Load();
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            if (tabPaneMain.SelectedPage == tabOrders)
            {
                if (grdOrders.FocusedView == gvItems)
                {
                    Item i = new Item();
                    cContext.Items.Add(i);
                }
                else
                {
                    Order o = new Order();
                    cContext.Orders.Add(o);
                }

                return;
            }

            if (tabPaneMain.SelectedPage == tabVendors)
            {
                if (ucVendors.IsDetailsFocused())
                {
                    VendorProduct i = new VendorProduct();
                    cContext.VendorsProducts.Add(i);
                }
                else
                {
                    Vendor i = new Vendor();
                    cContext.Vendors.Add(i);
                }
                return;
            }

            if (tabPaneMain.SelectedPage == tabProducts)
            {
                Product i = new Product();
                cContext.Products.Add(i);
                return;
            }

            if (tabPaneMain.SelectedPage == tabClients)
            {
                Client i = new Client();
                cContext.Clients.Add(i);
                return;
            }
            //// order vendor product client
            //switch (tabPaneMain.TabIndex)
            //{
            //    case 0:
            //        {

            //            if (grdOrders.FocusedView == gvItems)
            //            {
            //                Item i = new Item();
            //                cContext.Items.Add(i);
            //            }
            //            else
            //            {
            //                Order o = new Order();
            //                cContext.Orders.Add(o);
            //            }

            //            break;
            //        }
            //    case 1:
            //        {
            //            if (ucVendors.IsDetailsFocused())
            //            {
            //                VendorProduct i = new VendorProduct();
            //                cContext.VendorsProducts.Add(i);
            //            }
            //            else
            //            {
            //                Vendor i = new Vendor();
            //                cContext.Vendors.Add(i);
            //            }
            //            break;
            //        }
            //    case 2:
            //        {
            //            Product i = new Product();
            //            cContext.Products.Add(i);
            //            break;
            //        }
            //    case 3:
            //    {
            //        Client i = new Client();
            //        cContext.Clients.Add(i);
            //        break;
            //    }
            //}

        }

        private void clientButtEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (frmDisplay.ShowDialog(ucClients) == DialogResult.OK)
            {
            }
            this.tabClients.Controls.Add(this.ucClients);
        }

        private void itemButtEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }

        private void vendorButtEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}
