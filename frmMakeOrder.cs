using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfectioneryOrders.Model;

namespace ConfectioneryOrders
{
    public partial class frmMakeOrder : Form
    {
        private Order order;

        private Func<Client> changeClient;
        private Func<Product> changeProduct;
        private Func<Vendor> changeVendor;
        private Func<Order, bool> check;
        public frmMakeOrder()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(Order o, 
            Func<Client> changeClient, Func<Product> changeProduct, Func<Vendor> changeVendor, Func<Order, bool> check)
        {
            this.changeClient = changeClient;
            this.changeProduct = changeProduct;
            this.changeVendor = changeVendor;
            this.check = check;
            order = o;
            grdItems.DataSource = o.Items;

            lblCost.DataBindings.Add("Text", order, "Cost", true, DataSourceUpdateMode.OnPropertyChanged );
            //buttEdVendor.DataBindings.Add("Text", order, "VendorName", true, DataSourceUpdateMode.OnPropertyChanged);

            return ShowDialog();
        }

        private void repositoryItemButtonEditProduct_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Item i = gvItems.GetFocusedRow() as Item;
            if (i != null)
            {
                if (changeProduct != null)
                {
                    var p = changeProduct();

                    if (p != null)
                    {
                        if (i.Order.Items.Any(item => item.Product == p))
                        {
                            MessageBox.Show("Item with this product already exists.");
                            return;
                        }
                        i.Product = p;
                    }
                }
            }
        }

        private void buttEdClient_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            order.Client = changeClient();
            buttEdClient.Text = order.ClientName;
        }

        private void buttEdVendor_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            order.Vendor = changeVendor();
            buttEdVendor.Text = order.VendorName;
        }

        private void buttAdd_Click(object sender, EventArgs e)
        {
            Item i = new Item();
            i.Order = order;
            order.Items.Add(i);
            grdItems.RefreshDataSource();
        }

        private void buttDelete_Click(object sender, EventArgs e)
        {
            gvItems.DeleteSelectedRows();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (check != null)
            {
                if (!check.Invoke(order))
                    return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
