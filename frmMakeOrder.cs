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

        public frmMakeOrder()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(Order o, 
            Func<Client> changeClient, Func<Product> changeProduct, Func<Vendor> changeVendor)
        {
            this.changeClient = changeClient;
            this.changeProduct = changeProduct;
            this.changeVendor = changeVendor;

            order = o;
            grdItems.DataSource = o.Items;
            
            //buttEdClient.DataBindings.Add("Text", order, "ClientName", false, DataSourceUpdateMode.OnPropertyChanged );
            //buttEdVendor.DataBindings.Add("Text", order, "VendorName", true, DataSourceUpdateMode.OnPropertyChanged);

            return ShowDialog();
        }

        private void repositoryItemButtonEditProduct_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            Item i = gvItems.GetFocusedRow() as Item;
            if (i != null)
            {
                i.Product = changeProduct();
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
            order.Items.Add(new Item());
            grdItems.RefreshDataSource();
        }

        private void buttDelete_Click(object sender, EventArgs e)
        {
            gvItems.DeleteSelectedRows();
        }
    }
}
