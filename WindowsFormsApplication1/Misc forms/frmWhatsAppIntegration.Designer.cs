
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
            this.ChatItemGrid = new DevExpress.XtraGrid.GridControl();
            this.ChatItemGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.txtMessageCount = new DevExpress.XtraEditors.TextEdit();
            this.radChat1 = new Telerik.WinControls.UI.RadChat();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContactGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatItemGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatItemGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessageCount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChat1)).BeginInit();
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
            // ChatItemGrid
            // 
            this.ChatItemGrid.Location = new System.Drawing.Point(389, 15);
            this.ChatItemGrid.MainView = this.ChatItemGridView;
            this.ChatItemGrid.Name = "ChatItemGrid";
            this.ChatItemGrid.Size = new System.Drawing.Size(210, 310);
            this.ChatItemGrid.TabIndex = 8;
            this.ChatItemGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ChatItemGridView});
            // 
            // ChatItemGridView
            // 
            this.ChatItemGridView.GridControl = this.ChatItemGrid;
            this.ChatItemGridView.Name = "ChatItemGridView";
            this.ChatItemGridView.OptionsView.ShowGroupPanel = false;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(289, 129);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(85, 29);
            this.btnLoad.TabIndex = 9;
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtMessageCount
            // 
            this.txtMessageCount.EditValue = "10";
            this.txtMessageCount.Location = new System.Drawing.Point(314, 92);
            this.txtMessageCount.Name = "txtMessageCount";
            this.txtMessageCount.Size = new System.Drawing.Size(60, 22);
            this.txtMessageCount.TabIndex = 10;
            // 
            // radChat1
            // 
            this.radChat1.Location = new System.Drawing.Point(620, 15);
            this.radChat1.Name = "radChat1";
            this.radChat1.Size = new System.Drawing.Size(295, 440);
            this.radChat1.TabIndex = 11;
            this.radChat1.Text = "radChat1";
            this.radChat1.TimeSeparatorInterval = System.TimeSpan.Parse("1.00:00:00");
            // 
            // FrmWhatsAppIntegration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 508);
            this.ControlBox = false;
            this.Controls.Add(this.radChat1);
            this.Controls.Add(this.txtMessageCount);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.ChatItemGrid);
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
            ((System.ComponentModel.ISupportInitialize)(this.ChatItemGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChatItemGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessageCount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChat1)).EndInit();
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
        public DevExpress.XtraGrid.GridControl ChatItemGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView ChatItemGridView;
        private DevExpress.XtraEditors.SimpleButton btnLoad;
        private DevExpress.XtraEditors.TextEdit txtMessageCount;
        private Telerik.WinControls.UI.RadChat radChat1;
    }
}