using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ConfectioneryOrders
{
    public partial class frmUcDisplay : DevExpress.XtraEditors.XtraForm
    {
        public frmUcDisplay()
        {
            InitializeComponent();
        }

        public DialogResult ShowDialog(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;

            this.splitContainer.Panel1.Controls.Clear();
            this.splitContainer.Panel1.Controls.Add(uc);

            return ShowDialog(); 
        }
    }
}