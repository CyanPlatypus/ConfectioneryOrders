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

namespace ConfectioneryOrders.UC
{
    public partial class ucVendors : DevExpress.XtraEditors.XtraUserControl//, IAddDelete
    {
        public ucVendors(BindingList<Vendor> bs )
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            grdVendors.DataSource = bs;

        }

        public bool IsDetailsFocused()
        {
            return grdVendors.FocusedView == gvVP;
        }
        //public object Add()
        //{
        //    throw new NotImplementedException();
        //}

        //public void Delete(object o)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
