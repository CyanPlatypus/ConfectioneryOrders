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
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace ConfectioneryOrders
{
    public partial class frmMain : Form
    {
        private ConfectioneryContext cContext;

        private ucBase ucVendors;
        private ucBase ucProducts;
        private ucBase ucClients;

        private frmUcDisplay frmDisplay;

        //what can we delete?

        public frmMain()
        {
            InitializeComponent();

            LoadDB("k");

            ucVendors = new ucVendors(cContext.Vendors.Local.ToBindingList());
            ucProducts = new ucProducts(cContext.Products.Local.ToBindingList());
            ucClients = new ucClients(cContext.Clients.Local.ToBindingList());

            this.tabVendors.Controls.Add(this.ucVendors);
            this.tabProducts.Controls.Add(this.ucProducts);
            this.tabClients.Controls.Add(this.ucClients);

            frmDisplay = new frmUcDisplay();

            //Vendor v = cContext.Vendors.Local[0];
            //VendorProduct vp = new VendorProduct() { Quantity = 679 };
            //vp.Product = cContext.Products.Local[1];
            //v.VendorsProducts.Add(vp);

            //Vendor vq = cContext.Vendors.Local[1];
            //VendorProduct vpq = new VendorProduct() { Quantity = 534 };
            //vpq.Product = cContext.Products.Local[1];
            //vq.VendorsProducts.Add(vpq);

            //Order o = cContext.Orders.Local[1];
            //Item i = new Item() { Quantity = 7 };
            //i.Product = cContext.Products.Local[1];

            //o.Client = cContext.Clients.Local[0];
            //o.Vendor = cContext.Vendors.Local[2];
            //o.Items.Add(i);

            //cContext.Orders.Add(o);


            //Order o = new Order() { ClientName = "Alice", VendorName = "Bob" };
            //Item i = new Item() { ProductName = "cupcacke", Quantity = 40 };
            //Item ii = new Item() { ProductName = "bun", Quantity = 30 };
            //o.Items.Add(i);
            //o.Items.Add(ii);
            //cContext.Orders.Add(o);

            cContext.SaveChanges();

            //tabPaneMain.TabIndexChanged += TabPaneMain_TabIndexChanged;
            this.Load += FrmMain_Load;
            this.FormClosing += FrmMain_FormClosing;

            gvOrders.MasterRowExpanded += GvOrders_MasterRowExpanded;
        }

        private void GvOrders_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            GridView childView = gvOrders.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            childView.Focus();

            //Item i = new Item();
            //i.Order = gvOrders.GetFocusedRow() as Order;
            //cContext.Items.Add(i);

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
                using (frmMakeOrder f = new frmMakeOrder() )
                {
                    Order o = new Order();
                    if (f.ShowDialog(o,
                        EditClient, EditProduct, EditVendor) == DialogResult.OK)
                    {
                        cContext.Orders.Add(o);
                    }
                }
                //if (grdOrders.FocusedView != gvItems)
                //{
                //    Order o = new Order();
                //    cContext.Orders.Add(o);
                //}
                //else
                //{
                //    Item i = new Item();
                //    cContext.Items.Add(i);
                //}

                return;
            }

            if (tabPaneMain.SelectedPage == tabVendors)
            {
                if ((ucVendors as ucVendors).IsDetailsFocused())
                {
                    VendorProduct i = new VendorProduct();
                    (ucVendors as ucVendors).GetFocusedRow()?.VendorsProducts.Add(i);
                    //cContext.VendorsProducts.Add(i);
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

        private void deleteButt_Click(object sender, EventArgs e)
        {
            if (tabPaneMain.SelectedPage == tabOrders)
            {
                if (grdOrders.FocusedView == gvItems)
                {
                    gvItems.DeleteSelectedRows();
                }
                else
                {
                    gvOrders.DeleteSelectedRows();
                }

                return;
            }

            if (tabPaneMain.SelectedPage == tabVendors)
            {
                if ((ucVendors as ucVendors).IsDetailsFocused())
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
        }


        private void clientButtEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Object o = frmDisplay.ShowDialog(ucClients);
            if ( o != null && o is Client)
            {
                (gvOrders.GetFocusedRow() as Order).Client = (Client)o;
            }
            this.tabClients.Controls.Add(this.ucClients);
        }
        
        private void productButtEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
           
            Object o = frmDisplay.ShowDialog(ucProducts);
            if (o != null && o is Product)
            {
                Item i = (gvItems.GetFocusedRow() as Item);
                //exception here (i is null)
                (gvItems.GetFocusedRow() as Item).Product = (Product)o;
            }
            this.tabProducts.Controls.Add(this.ucProducts);
        }

        private void vendorButtEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Object o = frmDisplay.ShowDialog(ucVendors);
            if (o != null && o is Vendor)
            {
                (gvOrders.GetFocusedRow() as Order).Vendor = (Vendor)o;
            }
            this.tabVendors.Controls.Add(this.ucVendors);
        }

        public Client EditClient()
        {
            Object o = frmDisplay.ShowDialog(ucClients);
            this.tabClients.Controls.Add(this.ucClients);
            return o as Client;
        }

        public Vendor EditVendor()
        {
            Object o = frmDisplay.ShowDialog(ucVendors);
            this.tabVendors.Controls.Add(this.ucVendors);
            return o as Vendor;
        }

        public Product EditProduct()
        {
            Object o = frmDisplay.ShowDialog(ucProducts);
            this.tabProducts.Controls.Add(this.ucProducts);
            return o as Product;
        }


        private void saveButt_Click(object sender, EventArgs e)
        {
            try
            {
                cContext.SaveChanges();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
