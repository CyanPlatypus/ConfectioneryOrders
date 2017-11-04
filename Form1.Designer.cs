namespace ConfectioneryOrders
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.grdOrders = new DevExpress.XtraGrid.GridControl();
            this.gvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gvItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmVendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmItemID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).BeginInit();
            this.SuspendLayout();
            // 
            // grdOrders
            // 
            gridLevelNode1.LevelTemplate = this.gvItems;
            gridLevelNode1.RelationName = "Items";
            this.grdOrders.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdOrders.Location = new System.Drawing.Point(30, 58);
            this.grdOrders.MainView = this.gvOrders;
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.Size = new System.Drawing.Size(234, 200);
            this.grdOrders.TabIndex = 0;
            this.grdOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrders,
            this.gvItems});
            // 
            // gvOrders
            // 
            this.gvOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmID,
            this.clmClient,
            this.clmVendor});
            this.gvOrders.GridControl = this.grdOrders;
            this.gvOrders.Name = "gvOrders";
            // 
            // gvItems
            // 
            this.gvItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmItemID,
            this.clmProduct});
            this.gvItems.GridControl = this.grdOrders;
            this.gvItems.Name = "gvItems";
            // 
            // clmID
            // 
            this.clmID.Caption = "ID";
            this.clmID.FieldName = "ID";
            this.clmID.Name = "clmID";
            this.clmID.Visible = true;
            this.clmID.VisibleIndex = 0;
            // 
            // clmClient
            // 
            this.clmClient.Caption = "Client";
            this.clmClient.FieldName = "ClientName";
            this.clmClient.Name = "clmClient";
            this.clmClient.Visible = true;
            this.clmClient.VisibleIndex = 1;
            // 
            // clmVendor
            // 
            this.clmVendor.Caption = "Vendor";
            this.clmVendor.FieldName = "VendorName";
            this.clmVendor.Name = "clmVendor";
            this.clmVendor.Visible = true;
            this.clmVendor.VisibleIndex = 2;
            // 
            // clmItemID
            // 
            this.clmItemID.Caption = "ID";
            this.clmItemID.FieldName = "ID";
            this.clmItemID.Name = "clmItemID";
            this.clmItemID.Visible = true;
            this.clmItemID.VisibleIndex = 0;
            // 
            // clmProduct
            // 
            this.clmProduct.Caption = "Product";
            this.clmProduct.FieldName = "ProductID";
            this.clmProduct.Name = "clmProduct";
            this.clmProduct.Visible = true;
            this.clmProduct.VisibleIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 270);
            this.Controls.Add(this.grdOrders);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gvItems;
        private DevExpress.XtraGrid.Columns.GridColumn clmItemID;
        private DevExpress.XtraGrid.Columns.GridColumn clmProduct;
        private DevExpress.XtraGrid.Columns.GridColumn clmID;
        private DevExpress.XtraGrid.Columns.GridColumn clmClient;
        private DevExpress.XtraGrid.Columns.GridColumn clmVendor;
    }
}

