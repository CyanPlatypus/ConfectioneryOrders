namespace ConfectioneryOrders
{
    partial class frmUcDisplay
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
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.okButton = new DevExpress.XtraEditors.SimpleButton();
            this.cancelButt = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.Location = new System.Drawing.Point(0, 0);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.okButton);
            this.splitContainer.Panel2.Controls.Add(this.cancelButt);
            this.splitContainer.Size = new System.Drawing.Size(284, 261);
            this.splitContainer.SplitterDistance = 228;
            this.splitContainer.TabIndex = 0;
            // 
            // okButton
            // 
            this.okButton.Appearance.BackColor = System.Drawing.Color.YellowGreen;
            this.okButton.Appearance.Options.UseBackColor = true;
            this.okButton.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(197, 1);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "Ok";
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // cancelButt
            // 
            this.cancelButt.Appearance.BackColor = System.Drawing.Color.PaleVioletRed;
            this.cancelButt.Appearance.Options.UseBackColor = true;
            this.cancelButt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.cancelButt.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButt.Location = new System.Drawing.Point(12, 1);
            this.cancelButt.Name = "cancelButt";
            this.cancelButt.Size = new System.Drawing.Size(75, 23);
            this.cancelButt.TabIndex = 0;
            this.cancelButt.Text = "Cancel";
            // 
            // frmUcDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.splitContainer);
            this.Name = "frmUcDisplay";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private DevExpress.XtraEditors.SimpleButton cancelButt;
        private DevExpress.XtraEditors.SimpleButton okButton;
    }
}