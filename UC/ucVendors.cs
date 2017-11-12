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

        public ucVendors(BindingList<Vendor> bs )
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            grdVendors.DataSource = bs;

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
            MessageBox.Show(o is Vendor?"vendor":"not vendor");
        }
    }
}
