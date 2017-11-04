namespace ConfectioneryOrders.UC
{
    partial class ucClients
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
            this.grdClients = new DevExpress.XtraGrid.GridControl();
            this.gvClient = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.clmName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.clmINN = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // grdClients
            // 
            this.grdClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdClients.Location = new System.Drawing.Point(0, 0);
            this.grdClients.MainView = this.gvClient;
            this.grdClients.Name = "grdClients";
            this.grdClients.Size = new System.Drawing.Size(389, 310);
            this.grdClients.TabIndex = 3;
            this.grdClients.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gvClient});
            // 
            // gvClient
            // 
            this.gvClient.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.clmName,
            this.clmINN});
            this.gvClient.GridControl = this.grdClients;
            this.gvClient.Name = "gvClient";
            this.gvClient.OptionsView.ShowGroupPanel = false;
            // 
            // clmName
            // 
            this.clmName.Caption = "Name";
            this.clmName.FieldName = "Name";
            this.clmName.Name = "clmName";
            this.clmName.Visible = true;
            this.clmName.VisibleIndex = 0;
            // 
            // clmINN
            // 
            this.clmINN.Caption = "INN";
            this.clmINN.FieldName = "INN";
            this.clmINN.Name = "clmINN";
            this.clmINN.Visible = true;
            this.clmINN.VisibleIndex = 1;
            // 
            // ucClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grdClients);
            this.Name = "ucClients";
            this.Size = new System.Drawing.Size(389, 310);
            ((System.ComponentModel.ISupportInitialize)(this.grdClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvClient)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl grdClients;
        private DevExpress.XtraGrid.Views.Grid.GridView gvClient;
        private DevExpress.XtraGrid.Columns.GridColumn clmName;
        private DevExpress.XtraGrid.Columns.GridColumn clmINN;
    }
}
