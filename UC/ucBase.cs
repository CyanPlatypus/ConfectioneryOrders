﻿using System;
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
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace ConfectioneryOrders.UC
{
    public partial class ucBase : DevExpress.XtraEditors.XtraUserControl, IHaveObject
    {
        protected virtual GridControl grdMain { get; }

        public ucBase()
        {
            InitializeComponent();
        }

        public object GetSelectedObject()
        {
            return ((ColumnView)grdMain.FocusedView).GetFocusedRow();
        }

        public virtual void EnableEdit()
        {
            ((GridView) grdMain.MainView).OptionsBehavior.Editable = true;
        }
        public virtual void DisableEdit()
        {
            ((GridView)grdMain.MainView).OptionsBehavior.Editable = false;
        }
    }
}
