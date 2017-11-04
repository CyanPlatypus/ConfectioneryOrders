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
    public partial class ucProducts : DevExpress.XtraEditors.XtraUserControl
    {
        public ucProducts(BindingList<Product> bs)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            grdProducts.DataSource = bs;
        }
    }
}
