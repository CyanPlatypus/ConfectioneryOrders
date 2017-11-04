namespace ConfectioneryOrders.UC
{
    partial class ucProducts
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
            this.grdProducts = new DevExpress.XtraGrid.GridControl();
            this.gvProduct = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // grdProducts
            // 
            this.grdProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdProducts.Location = new System.Drawing.Point(0, 0);
            this.grdProducts.MainView = this.gvProduct;
            this.grdProducts.Name = "grdProducts";
            this.grdProducts.Size = new System.Drawing.Size(410, 322);
            this.grdProducts.TabIndex = 2;
            this.grdProducts.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvProduct});
            // 
            // gvProduct
            // 
            this.gvProduct.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmName,
            this.clmPrice});
            this.gvProduct.GridControl = this.grdProducts;
            this.gvProduct.Name = "gvProduct";
            this.gvProduct.OptionsView.ShowGroupPanel = false;
            // 
            // clmName
            // 
            this.clmName.Caption = "Name";
            this.clmName.FieldName = "Name";
            this.clmName.Name = "clmName";
            this.clmName.Visible = true;
            this.clmName.VisibleIndex = 0;
            // 
            // clmPrice
            // 
            this.clmPrice.Caption = "Price";
            this.clmPrice.FieldName = "Price";
            this.clmPrice.Name = "clmPrice";
            this.clmPrice.Visible = true;
            this.clmPrice.VisibleIndex = 1;
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
            // ucProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdProducts);
            this.Name = "ucProducts";
            this.Size = new System.Drawing.Size(410, 322);
            ((System.ComponentModel.ISupportInitialize)(this.grdProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdProducts;
        private DevExpress.XtraGrid.Columns.GridColumn clmProduct;
        private DevExpress.XtraGrid.Columns.GridColumn clmQuantity;
        private DevExpress.XtraGrid.Views.Grid.GridView gvProduct;
        private DevExpress.XtraGrid.Columns.GridColumn clmName;
        private DevExpress.XtraGrid.Columns.GridColumn clmPrice;
    }
}
