namespace ConfectioneryOrders
{
    partial class frmMakeOrder
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.okButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButt = new DevExpress.XtraEditors.SimpleButton();
            this.buttEdClient = new DevExpress.XtraEditors.ButtonEdit();
            this.buttEdVendor = new DevExpress.XtraEditors.ButtonEdit();
            this.grdItems = new DevExpress.XtraGrid.GridControl();
            this.gvItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmProduct = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEditProduct = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.clmQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.buttAdd = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttDelete = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.buttEdClient.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttEdVendor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.okButton.Appearance.BackColor = System.Drawing.Color.YellowGreen;
            this.okButton.Appearance.Options.UseBackColor = true;
            this.okButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(261, 345);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 3;
            this.okButton.Text = "Ok";
            // 
            // cancelButt
            // 
            this.cancelButt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cancelButt.Appearance.BackColor = System.Drawing.Color.PaleVioletRed;
            this.cancelButt.Appearance.Options.UseBackColor = true;
            this.cancelButt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.cancelButt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButt.Location = new System.Drawing.Point(12, 345);
            this.cancelButt.Name = "cancelButt";
            this.cancelButt.Size = new System.Drawing.Size(75, 23);
            this.cancelButt.TabIndex = 2;
            this.cancelButt.Text = "Cancel";
            // 
            // buttEdClient
            // 
            this.buttEdClient.EditValue = "";
            this.buttEdClient.Location = new System.Drawing.Point(171, 12);
            this.buttEdClient.Name = "buttEdClient";
            this.buttEdClient.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttEdClient.Properties.ReadOnly = true;
            this.buttEdClient.Properties.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttEdClient_Properties_ButtonClick);
            this.buttEdClient.Size = new System.Drawing.Size(164, 20);
            this.buttEdClient.TabIndex = 4;
            this.buttEdClient.ToolTip = "Client";
            // 
            // buttEdVendor
            // 
            this.buttEdVendor.Location = new System.Drawing.Point(171, 38);
            this.buttEdVendor.Name = "buttEdVendor";
            this.buttEdVendor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.buttEdVendor.Properties.ReadOnly = true;
            this.buttEdVendor.Size = new System.Drawing.Size(164, 20);
            this.buttEdVendor.TabIndex = 5;
            this.buttEdVendor.ToolTip = "Vendor";
            this.buttEdVendor.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttEdVendor_ButtonClick);
            // 
            // grdItems
            // 
            this.grdItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdItems.Location = new System.Drawing.Point(12, 112);
            this.grdItems.MainView = this.gvItems;
            this.grdItems.Name = "grdItems";
            this.grdItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEditProduct});
            this.grdItems.Size = new System.Drawing.Size(324, 220);
            this.grdItems.TabIndex = 6;
            this.grdItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvItems});
            // 
            // gvItems
            // 
            this.gvItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmProduct,
            this.clmQuantity});
            this.gvItems.GridControl = this.grdItems;
            this.gvItems.Name = "gvItems";
            this.gvItems.OptionsView.ShowGroupPanel = false;
            // 
            // clmProduct
            // 
            this.clmProduct.Caption = "Product";
            this.clmProduct.ColumnEdit = this.repositoryItemButtonEditProduct;
            this.clmProduct.FieldName = "ProductName";
            this.clmProduct.Name = "clmProduct";
            this.clmProduct.Visible = true;
            this.clmProduct.VisibleIndex = 0;
            // 
            // repositoryItemButtonEditProduct
            // 
            this.repositoryItemButtonEditProduct.AutoHeight = false;
            this.repositoryItemButtonEditProduct.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEditProduct.Name = "repositoryItemButtonEditProduct";
            this.repositoryItemButtonEditProduct.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.repositoryItemButtonEditProduct_ButtonClick);
            // 
            // clmQuantity
            // 
            this.clmQuantity.Caption = "Quantity";
            this.clmQuantity.FieldName = "Quantity";
            this.clmQuantity.Name = "clmQuantity";
            this.clmQuantity.Visible = true;
            this.clmQuantity.VisibleIndex = 1;
            // 
            // buttAdd
            // 
            this.buttAdd.Appearance.BackColor = System.Drawing.Color.YellowGreen;
            this.buttAdd.Appearance.Options.UseBackColor = true;
            this.buttAdd.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.buttAdd.Location = new System.Drawing.Point(12, 78);
            this.buttAdd.Name = "buttAdd";
            this.buttAdd.Size = new System.Drawing.Size(75, 23);
            this.buttAdd.TabIndex = 7;
            this.buttAdd.Text = "Add";
            this.buttAdd.Click += new System.EventHandler(this.buttAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Total cost";
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(296, 83);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(35, 13);
            this.lblCost.TabIndex = 9;
            this.lblCost.Text = "label2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vendor";
            // 
            // buttDelete
            // 
            this.buttDelete.Appearance.BackColor = System.Drawing.Color.PaleVioletRed;
            this.buttDelete.Appearance.Options.UseBackColor = true;
            this.buttDelete.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.buttDelete.Location = new System.Drawing.Point(93, 78);
            this.buttDelete.Name = "buttDelete";
            this.buttDelete.Size = new System.Drawing.Size(75, 23);
            this.buttDelete.TabIndex = 12;
            this.buttDelete.Text = "Delete";
            this.buttDelete.Click += new System.EventHandler(this.buttDelete_Click);
            // 
            // frmMakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 380);
            this.Controls.Add(this.buttDelete);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttAdd);
            this.Controls.Add(this.grdItems);
            this.Controls.Add(this.buttEdVendor);
            this.Controls.Add(this.buttEdClient);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButt);
            this.Name = "frmMakeOrder";
            this.Text = "frmMakeOrder";
            ((System.ComponentModel.ISupportInitialize)(this.buttEdClient.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buttEdVendor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEditProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton okButton;
        private DevExpress.XtraEditors.SimpleButton cancelButt;
        private DevExpress.XtraEditors.ButtonEdit buttEdClient;
        private DevExpress.XtraEditors.ButtonEdit buttEdVendor;
        private DevExpress.XtraGrid.GridControl grdItems;
        private DevExpress.XtraGrid.Views.Grid.GridView gvItems;
        private DevExpress.XtraGrid.Columns.GridColumn clmProduct;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEditProduct;
        private DevExpress.XtraGrid.Columns.GridColumn clmQuantity;
        private DevExpress.XtraEditors.SimpleButton buttAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton buttDelete;
    }
}