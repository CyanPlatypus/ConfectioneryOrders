namespace ConfectioneryOrders.UC
{
    partial class ucVendors
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.gvVP = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdVendors = new DevExpress.XtraGrid.GridControl();
            this.gvVendor = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPhone = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gvVP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVendor)).BeginInit();
            this.SuspendLayout();
            // 
            // gvVP
            // 
            this.gvVP.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmProduct,
            this.clmQuantity});
            this.gvVP.GridControl = this.grdVendors;
            this.gvVP.Name = "gvVP";
            // 
            // clmProduct
            // 
            this.clmProduct.Caption = "Product";
            this.clmProduct.FieldName = "ProductName";
            this.clmProduct.Name = "clmProduct";
            this.clmProduct.Visible = true;
            this.clmProduct.VisibleIndex = 1;
            // 
            // clmQuantity
            // 
            this.clmQuantity.Caption = "Quantity";
            this.clmQuantity.FieldName = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.Visible = true;
            this.clmQuantity.VisibleIndex = 0;
            // 
            // grdVendors
            // 
            this.grdVendors.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gvVP;
            gridLevelNode1.RelationName = "VendorsProducts";
            this.grdVendors.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdVendors.Location = new System.Drawing.Point(0, 0);
            this.grdVendors.MainView = this.gvVendor;
            this.grdVendors.Name = "grdVendors";
            this.grdVendors.Size = new System.Drawing.Size(404, 340);
            this.grdVendors.TabIndex = 1;
            this.grdVendors.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvVendor,
            this.gvVP});
            // 
            // gvVendor
            // 
            this.gvVendor.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmName,
            this.clmPhone});
            this.gvVendor.GridControl = this.grdVendors;
            this.gvVendor.Name = "gvVendor";
            this.gvVendor.OptionsView.ShowGroupPanel = false;
            // 
            // clmName
            // 
            this.clmName.Caption = "Name";
            this.clmName.FieldName = "Name";
            this.clmName.Name = "clmName";
            this.clmName.Visible = true;
            this.clmName.VisibleIndex = 0;
            // 
            // clmPhone
            // 
            this.clmPhone.Caption = "Phone";
            this.clmPhone.FieldName = "Phone";
            this.clmPhone.Name = "clmPhone";
            this.clmPhone.Visible = true;
            this.clmPhone.VisibleIndex = 1;
            // 
            // ucVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdVendors);
            this.Name = "ucVendors";
            this.Size = new System.Drawing.Size(404, 340);
            ((System.ComponentModel.ISupportInitialize)(this.gvVP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdVendors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvVendor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdVendors;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVP;
        private DevExpress.XtraGrid.Columns.GridColumn clmProduct;
        private DevExpress.XtraGrid.Columns.GridColumn clmQuantity;
        private DevExpress.XtraGrid.Views.Grid.GridView gvVendor;
        private DevExpress.XtraGrid.Columns.GridColumn clmName;
        private DevExpress.XtraGrid.Columns.GridColumn clmPhone;
    }
}
