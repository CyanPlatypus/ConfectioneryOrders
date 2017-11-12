using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConfectioneryOrders.Model;
using DevExpress.XtraEditors;

namespace ConfectioneryOrders
{
    public partial class frmUcDisplay : DevExpress.XtraEditors.XtraForm
    {
        private Object selectedObject;
        private IHaveObject iHaveObject;

        public frmUcDisplay()
        {
            InitializeComponent();
        }

        public object ShowDialog(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;

            if (uc is IHaveObject)
            {
                iHaveObject = uc as IHaveObject;
            }

            this.splitContainer.Panel1.Controls.Clear();
            this.splitContainer.Panel1.Controls.Add(uc);

            ShowDialog();

            return selectedObject;
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            selectedObject = iHaveObject?.GetObject();
        }
    }
}