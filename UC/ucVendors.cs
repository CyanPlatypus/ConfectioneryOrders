using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfectioneryOrders.Model;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;

namespace ConfectioneryOrders.UC
{
    public partial class ucVendors : ucBase
    {
        protected override GridControl grdMain {
            get { return grdVendors; }
        }

        private GridView childView;

        private Func<Product> getProduct;

        public ucVendors(BindingList<Vendor> bs, Func<Product> v )
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            grdVendors.DataSource = bs;

            getProduct = v;

            gvVendor.MasterRowExpanded += GvVendor_MasterRowExpanded;
        }

        private void GvVendor_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            /*GridView*/ childView = gvVendor.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            childView.Focus();
        }

        public bool IsDetailsFocused()
        {
            return grdVendors.FocusedView != gvVendor;
            //return grdVendors.FocusedView == childView;
        }
        //public object Add()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(object o)
        //{
        //    throw new NotImplementedException();
        //}

        public Vendor GetFocusedRow()
        {
            return gvVendor.GetFocusedRow() as Vendor;
        }

        private void repositoryItemButtonEditProduct_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            object o = (grdVendors.FocusedView as GridView).GetFocusedRow();
            //MessageBox.Show(o is Vendor?"vendor":"not vendor");

            if (o is VendorProduct)
            {
                if (getProduct != null)
                {
                    Product p = getProduct();
                    if (p != null)
                    {
                        //vendor of current vendorProduct already has vendorProduct with such Product
                        if ((o as VendorProduct).Vendor.VendorsProducts.Any(vp => vp.Product == p))
                        {
                            MessageBox.Show("Entity with this product already exists.");
                            return;
                        }

                        (o as VendorProduct).Product = p;
                    }
                }
            }
                
        }

        public override void EnableEdit()
        {
            this.gvVP.OptionsBehavior.Editable = true;
            base.EnableEdit();
        }

        public override void DisableEdit()
        {
            base.DisableEdit();
            this.gvVP.OptionsBehavior.Editable = false;
        }
    }

        

}

