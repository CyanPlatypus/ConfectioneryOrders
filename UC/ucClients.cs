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
    public partial class ucClients : DevExpress.XtraEditors.XtraUserControl
    {
        public ucClients(BindingList<Client> bs)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;

            grdClients.DataSource = bs;
        }
    }
}
