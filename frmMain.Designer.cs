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
            this.gvItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.productButtEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.clmQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdOrders = new DevExpress.XtraGrid.GridControl();
            this.gvOrders = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmClient = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clientButtEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.clmVendor = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vendorButtEdit = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.clmCost = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPaneMain = new DevExpress.XtraBars.Navigation.TabPane();
            this.tabOrders = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabVendors = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabProducts = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.tabClients = new DevExpress.XtraBars.Navigation.TabNavigationPage();
            this.addButt = new DevExpress.XtraEditors.SimpleButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.deleteButt = new DevExpress.XtraEditors.SimpleButton();
            this.saveButt = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productButtEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientButtEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorButtEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneMain)).BeginInit();
            this.tabPaneMain.SuspendLayout();
            this.tabOrders.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gvItems
            // 
            this.gvItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmProduct,
            this.clmQuantity});
            this.gvItems.GridControl = this.grdOrders;
            this.gvItems.Name = "gvItems";
            this.gvItems.OptionsBehavior.Editable = false;
            this.gvItems.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gvItems.OptionsView.ShowGroupPanel = false;
            // 
            // clmProduct
            // 
            this.clmProduct.Caption = "Product";
            this.clmProduct.ColumnEdit = this.productButtEdit;
            this.clmProduct.FieldName = "ProductName";
            this.clmProduct.Name = "clmProduct";
            this.clmProduct.Visible = true;
            this.clmProduct.VisibleIndex = 1;
            // 
            // productButtEdit
            // 
            this.productButtEdit.AutoHeight = false;
            this.productButtEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.productButtEdit.Name = "productButtEdit";
            this.productButtEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.productButtEdit_ButtonClick);
            // 
            // clmQuantity
            // 
            this.clmQuantity.Caption = "Quantity";
            this.clmQuantity.FieldName = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.Visible = true;
            this.clmQuantity.VisibleIndex = 0;
            // 
            // grdOrders
            // 
            this.grdOrders.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gvItems;
            gridLevelNode1.RelationName = "Items";
            this.grdOrders.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.grdOrders.Location = new System.Drawing.Point(0, 0);
            this.grdOrders.MainView = this.gvOrders;
            this.grdOrders.Name = "grdOrders";
            this.grdOrders.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.clientButtEdit,
            this.productButtEdit,
            this.vendorButtEdit});
            this.grdOrders.Size = new System.Drawing.Size(693, 556);
            this.grdOrders.TabIndex = 1;
            this.grdOrders.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvOrders,
            this.gvItems});
            // 
            // gvOrders
            // 
            this.gvOrders.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmClient,
            this.clmVendor,
            this.clmCost});
            this.gvOrders.GridControl = this.grdOrders;
            this.gvOrders.Name = "gvOrders";
            this.gvOrders.OptionsBehavior.Editable = false;
            this.gvOrders.OptionsDetail.AllowExpandEmptyDetails = true;
            this.gvOrders.OptionsView.ShowGroupPanel = false;
            // 
            // clmClient
            // 
            this.clmClient.Caption = "Client";
            this.clmClient.ColumnEdit = this.clientButtEdit;
            this.clmClient.FieldName = "ClientName";
            this.clmClient.Name = "clmClient";
            this.clmClient.Visible = true;
            this.clmClient.VisibleIndex = 0;
            // 
            // clientButtEdit
            // 
            this.clientButtEdit.AutoHeight = false;
            this.clientButtEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.clientButtEdit.Name = "clientButtEdit";
            this.clientButtEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.clientButtEdit_ButtonClick);
            // 
            // clmVendor
            // 
            this.clmVendor.Caption = "Vendor";
            this.clmVendor.ColumnEdit = this.vendorButtEdit;
            this.clmVendor.FieldName = "VendorName";
            this.clmVendor.Name = "clmVendor";
            this.clmVendor.Visible = true;
            this.clmVendor.VisibleIndex = 1;
            // 
            // vendorButtEdit
            // 
            this.vendorButtEdit.AutoHeight = false;
            this.vendorButtEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.vendorButtEdit.Name = "vendorButtEdit";
            this.vendorButtEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.vendorButtEdit_ButtonClick);
            // 
            // clmCost
            // 
            this.clmCost.Caption = "Cost";
            this.clmCost.FieldName = "Cost";
            this.clmCost.Name = "clmCost";
            this.clmCost.Visible = true;
            this.clmCost.VisibleIndex = 2;
            // 
            // tabPaneMain
            // 
            this.tabPaneMain.Controls.Add(this.tabOrders);
            this.tabPaneMain.Controls.Add(this.tabVendors);
            this.tabPaneMain.Controls.Add(this.tabProducts);
            this.tabPaneMain.Controls.Add(this.tabClients);
            this.tabPaneMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabPaneMain.Location = new System.Drawing.Point(0, 32);
            this.tabPaneMain.Name = "tabPaneMain";
            this.tabPaneMain.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.tabOrders,
            this.tabVendors,
            this.tabProducts,
            this.tabClients});
            this.tabPaneMain.RegularSize = new System.Drawing.Size(711, 601);
            this.tabPaneMain.SelectedPage = this.tabOrders;
            this.tabPaneMain.Size = new System.Drawing.Size(711, 601);
            this.tabPaneMain.TabIndex = 1;
            // 
            // tabOrders
            // 
            this.tabOrders.Caption = "Orders";
            this.tabOrders.Controls.Add(this.grdOrders);
            this.tabOrders.Name = "tabOrders";
            this.tabOrders.Size = new System.Drawing.Size(693, 556);
            // 
            // tabVendors
            // 
            this.tabVendors.Caption = "Vendors";
            this.tabVendors.Name = "tabVendors";
            this.tabVendors.Size = new System.Drawing.Size(693, 556);
            // 
            // tabProducts
            // 
            this.tabProducts.Caption = "Products";
            this.tabProducts.Name = "tabProducts";
            this.tabProducts.Size = new System.Drawing.Size(693, 556);
            // 
            // tabClients
            // 
            this.tabClients.Caption = "Clients";
            this.tabClients.Name = "tabClients";
            this.tabClients.Size = new System.Drawing.Size(693, 556);
            // 
            // addButt
            // 
            this.addButt.Appearance.BackColor = System.Drawing.Color.YellowGreen;
            this.addButt.Appearance.Options.UseBackColor = true;
            this.addButt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.addButt.Location = new System.Drawing.Point(3, 3);
            this.addButt.Name = "addButt";
            this.addButt.Size = new System.Drawing.Size(75, 23);
            this.addButt.TabIndex = 3;
            this.addButt.Text = "Add";
            this.addButt.Click += new System.EventHandler(this.addButt_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.addButt);
            this.flowLayoutPanel1.Controls.Add(this.deleteButt);
            this.flowLayoutPanel1.Controls.Add(this.saveButt);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(711, 28);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // deleteButt
            // 
            this.deleteButt.Appearance.BackColor = System.Drawing.Color.PaleVioletRed;
            this.deleteButt.Appearance.Options.UseBackColor = true;
            this.deleteButt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.deleteButt.Location = new System.Drawing.Point(84, 3);
            this.deleteButt.Name = "deleteButt";
            this.deleteButt.Size = new System.Drawing.Size(75, 23);
            this.deleteButt.TabIndex = 4;
            this.deleteButt.Text = "Delete";
            this.deleteButt.Click += new System.EventHandler(this.deleteButt_Click);
            // 
            // saveButt
            // 
            this.saveButt.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.saveButt.Appearance.Options.UseBackColor = true;
            this.saveButt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.saveButt.Location = new System.Drawing.Point(165, 3);
            this.saveButt.Name = "saveButt";
            this.saveButt.Size = new System.Drawing.Size(75, 23);
            this.saveButt.TabIndex = 5;
            this.saveButt.Text = "Save";
            this.saveButt.Click += new System.EventHandler(this.saveButt_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 633);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tabPaneMain);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productButtEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientButtEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendorButtEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabPaneMain)).EndInit();
            this.tabPaneMain.ResumeLayout(false);
            this.tabOrders.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.TabPane tabPaneMain;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabOrders;
        private DevExpress.XtraGrid.GridControl grdOrders;
        private DevExpress.XtraGrid.Views.Grid.GridView gvItems;
        private DevExpress.XtraGrid.Columns.GridColumn clmProduct;
        private DevExpress.XtraGrid.Columns.GridColumn clmQuantity;
        private DevExpress.XtraGrid.Views.Grid.GridView gvOrders;
        private DevExpress.XtraGrid.Columns.GridColumn clmClient;
        private DevExpress.XtraGrid.Columns.GridColumn clmVendor;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabVendors;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabProducts;
        private DevExpress.XtraBars.Navigation.TabNavigationPage tabClients;
        private DevExpress.XtraEditors.SimpleButton addButt;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private DevExpress.XtraEditors.SimpleButton deleteButt;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit clientButtEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit productButtEdit;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit vendorButtEdit;
        private DevExpress.XtraEditors.SimpleButton saveButt;
        private DevExpress.XtraGrid.Columns.GridColumn clmCost;
    }
}

