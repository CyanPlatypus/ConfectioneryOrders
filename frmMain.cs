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
using DevExpress.XtraGrid.Views.Base;
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

            ucVendors = new ucVendors(cContext.Vendors.Local.ToBindingList(), EditProduct);
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

        private bool IsValidOrder(Order o, Action<VendorProduct, int> act )
        {
            if (o == null) return false;
            Vendor v = o.Vendor;

            if (o.Vendor == null)
            {
                MessageBox.Show("Field Vendor should be set.");
                return false;
            }

            if (o.Client== null)
            {
                MessageBox.Show("Field Client should be set.");
                return false;
            }

            foreach (var item in o.Items)
            {
                bool found = false;
                
                foreach (var vendorProduct in v.VendorsProducts)
                {
                    if (item.Product == vendorProduct.Product)
                    {
                        found = true;
                        if (vendorProduct.Quantity - item.Quantity >= 0)
                        {
                            act?.Invoke(vendorProduct, item.Quantity);
                            //vendorProduct.Quantity -= item.Quantity;
                        }
                        else
                        {
                            MessageBox.Show($"Not enough products {item.ProductName} in stock.");
                            return false;
                        }

                    }
                    if (found) break;
                }
                if (!found)
                {
                    MessageBox.Show($"Product {item.ProductName} was not found" +
                                    $" on vendor\'s {v.Name} stock.");
                    return false;
                }

            }
            return true;
        }

        private bool IsValidOrder(Order arg)
        {
            return IsValidOrder(arg, null);
        }

        private void addButt_Click(object sender, EventArgs e)
        {
            #region orders&items
            if (tabPaneMain.SelectedPage == tabOrders)
            {
                using (frmMakeOrder f = new frmMakeOrder())
                {
                    Order o = new Order();
                    if (f.ShowDialog(o,
                        EditClient, EditProduct, EditVendor, IsValidOrder) == DialogResult.OK)
                    {

                        IsValidOrder(o, (v, q) => v.Quantity -= q);
                        cContext.Orders.Add(o);
                    }
                }
                return;
            }
            #endregion

            #region vendors&vendorsproducts
            if (tabPaneMain.SelectedPage == tabVendors)
            {
                if ((ucVendors as ucVendors).IsDetailsFocused())
                {
                    VendorProduct i = new VendorProduct();
                    Vendor v = (ucVendors as ucVendors).GetFocusedRow(); //.VendorsProducts.Add(i);
                    if (v != null)
                    {
                        i.Vendor = v;
                        v.VendorsProducts.Add(i);
                    }
                //cContext.VendorsProducts.Add(i);
                }
                else
                {
                    Vendor i = new Vendor();
                    cContext.Vendors.Add(i);
                }
                return;
            }
            #endregion

            #region products
            if (tabPaneMain.SelectedPage == tabProducts)
            {
                Product i = new Product();
                cContext.Products.Add(i);
                return;
            }
            #endregion

            #region clients
            if (tabPaneMain.SelectedPage == tabClients)
            {
                Client i = new Client();
                cContext.Clients.Add(i);
                return;
            } 
            #endregion

        }



        private void deleteButt_Click(object sender, EventArgs e)
        {
            #region orders
            if (tabPaneMain.SelectedPage == tabOrders)
            {
                ((ColumnView)grdOrders.FocusedView).DeleteSelectedRows();
                cContext.SaveChanges();
                return;
            }
            #endregion

            #region vendors&vandorproducts
            if (tabPaneMain.SelectedPage == tabVendors)
            {
                Object o = ucVendors.GetSelectedObject();

                if (o is Vendor)
                {
                    if (cContext.Orders.Local.Any(a => a.Vendor == (o as Vendor)))
                    {
                        if (XtraMessageBox.Show("There are related orders. Do you want to delete them?" +
                                                "\n" +
                                                "If No this vendor will not be deleted.",
                                "Delete related orders", MessageBoxButtons.YesNo)
                            == DialogResult.Yes)
                        {
                            cContext.Vendors.Remove(o as Vendor);

                            // all entities in inconsistent state will be deleted
                            cContext.SaveChanges();
                        }
                    }
                    else
                    {
                        cContext.Vendors.Remove(o as Vendor);
                        cContext.SaveChanges();
                    }
                }
                if (o is VendorProduct)
                {
                    cContext.VendorsProducts.Remove(o as VendorProduct);
                    cContext.SaveChanges();
                }

                return;
            }
            #endregion

            #region products
            if (tabPaneMain.SelectedPage == tabProducts)
            {
                Object o = ucProducts.GetSelectedObject();

                if (cContext.VendorsProducts.Local.Any(a => a.Product == (o as Product))
                    || cContext.Items.Local.Any(i => i.Product == (o as Product)))
                {
                    if (XtraMessageBox.Show("There are related entities. Do you want to delete them?" +
                                            "\n" +
                                            "If No this product will not be deleted.",
                            "Delete related entities", MessageBoxButtons.YesNo)
                        == DialogResult.Yes)
                    {
                        cContext.Products.Remove(o as Product);

                        // all entities in inconsistent state will be deleted
                        cContext.SaveChanges();
                    }
                }
                else
                {
                    cContext.Products.Remove(o as Product);
                    cContext.SaveChanges();
                }

                return;
            }
            #endregion

            #region clients
            if (tabPaneMain.SelectedPage == tabClients)
            {
                Object o = ucClients.GetSelectedObject();

                if (o is Client)
                {
                    if (cContext.Orders.Local.Any(a => a.Client == (o as Client)))
                    {
                        if (XtraMessageBox.Show("There are related orders. Do you want to delete them?" +
                                                "\n" +
                                                "If No this client will not be deleted.",
                                "Delete related orders", MessageBoxButtons.YesNo)
                            == DialogResult.Yes)
                        {
                            cContext.Clients.Remove(o as Client);

                            // all entities in inconsistent state will be deleted
                            cContext.SaveChanges();
                        }
                    }
                    else
                    {
                        cContext.Clients.Remove(o as Client);
                        cContext.SaveChanges();
                    }
                }

                return;
            } 
            #endregion
        }


        private void clientButtEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Object o = frmDisplay.ShowDialog(ucClients);
            if (o != null && o is Client)
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
            ucClients.DisableEdit();
            Object o = frmDisplay.ShowDialog(ucClients);
            ucClients.EnableEdit();
            this.tabClients.Controls.Add(this.ucClients);
            return o as Client;
        }

        public Vendor EditVendor()
        {
            ucVendors.DisableEdit();
            Object o = frmDisplay.ShowDialog(ucVendors);
            ucVendors.EnableEdit();
            this.tabVendors.Controls.Add(this.ucVendors);
            return o as Vendor;
        }

        public Product EditProduct()
        {
            ucProducts.DisableEdit();
            Object o = frmDisplay.ShowDialog(ucProducts);
            ucProducts.EnableEdit();
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
