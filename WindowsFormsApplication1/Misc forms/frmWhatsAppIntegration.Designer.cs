
namespace WindowsFormsApplication1.Misc_forms
{
    partial class FrmWhatsAppIntegration
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
            this.txtSearchBar = new DevExpress.XtraEditors.TextEdit();
            this.ContactGrid = new DevExpress.XtraGrid.GridControl();
            this.ContactGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtMobileNo = new DevExpress.XtraEditors.TextEdit();
            this.txtStatus = new DevExpress.XtraEditors.TextEdit();
            this.btnSync = new DevExpress.XtraEditors.SimpleButton();
            this.txtMessageCount = new DevExpress.XtraEditors.TextEdit();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessageCount.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchBar
            // 
            this.txtSearchBar.Location = new System.Drawing.Point(12, 92);
            this.txtSearchBar.Name = "txtSearchBar";
            this.txtSearchBar.Size = new System.Drawing.Size(296, 22);
            this.txtSearchBar.TabIndex = 0;
            // 
            // ContactGrid
            // 
            this.ContactGrid.Location = new System.Drawing.Point(12, 177);
            this.ContactGrid.MainView = this.ContactGridView;
            this.ContactGrid.Name = "ContactGrid";
            this.ContactGrid.Size = new System.Drawing.Size(362, 320);
            this.ContactGrid.TabIndex = 3;
            this.ContactGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ContactGridView});
            // 
            // ContactGridView
            // 
            this.ContactGridView.GridControl = this.ContactGrid;
            this.ContactGridView.Name = "ContactGridView";
            this.ContactGridView.OptionsView.ShowGroupPanel = false;
            // 
            // textEdit2
            // 
            this.textEdit2.Location = new System.Drawing.Point(377, 475);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Size = new System.Drawing.Size(500, 22);
            this.textEdit2.TabIndex = 4;
            this.textEdit2.EditValueChanged += new System.EventHandler(this.textEdit2_EditValueChanged);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(883, 471);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 29);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Text = "Send";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Location = new System.Drawing.Point(12, 12);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(359, 22);
            this.txtMobileNo.TabIndex = 6;
            // 
            // txtStatus
            // 
            this.txtStatus.Location = new System.Drawing.Point(15, 40);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(359, 22);
            this.txtStatus.TabIndex = 7;
            // 
            // btnSync
            // 
            this.btnSync.Location = new System.Drawing.Point(67, 120);
            this.btnSync.Name = "btnSync";
            this.btnSync.Size = new System.Drawing.Size(185, 29);
            this.btnSync.TabIndex = 9;
            this.btnSync.Text = "Sync With Whats App";
            this.btnSync.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtMessageCount
            // 
            this.txtMessageCount.EditValue = "10";
            this.txtMessageCount.Location = new System.Drawing.Point(314, 92);
            this.txtMessageCount.Name = "txtMessageCount";
            this.txtMessageCount.Size = new System.Drawing.Size(60, 22);
            this.txtMessageCount.TabIndex = 10;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(282, 120);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(92, 29);
            this.simpleButton2.TabIndex = 11;
            this.simpleButton2.Text = "Load";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // FrmWhatsAppIntegration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 508);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.txtMessageCount);
            this.Controls.Add(this.btnSync);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.ContactGrid);
            this.Controls.Add(this.txtSearchBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmWhatsAppIntegration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmWhatsAppIntegration_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessageCount.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtSearchBar;
        private DevExpress.XtraGrid.Views.Grid.GridView ContactGridView;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.TextEdit txtMobileNo;
        private DevExpress.XtraEditors.TextEdit txtStatus;
        public DevExpress.XtraGrid.GridControl ContactGrid;
        private DevExpress.XtraEditors.SimpleButton btnSync;
        private DevExpress.XtraEditors.TextEdit txtMessageCount;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}