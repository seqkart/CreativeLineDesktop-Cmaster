namespace WindowsFormsApplication1.FormReports
{
    partial class FrmPartyAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPartyAccounts));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.lbl = new System.Windows.Forms.ToolStripLabel();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.RefreshBtn = new System.Windows.Forms.ToolStripButton();
            this.LedgerGrid = new DevExpress.XtraGrid.GridControl();
            this.LedgerGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LedgerGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedgerGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.Menu_ToolStrip.CanOverflow = false;
            this.Menu_ToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu_ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuit,
            this.lbl,
            this.btnPrint,
            this.RefreshBtn});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(1115, 31);
            this.Menu_ToolStrip.TabIndex = 372;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnQuit.Size = new System.Drawing.Size(53, 28);
            this.btnQuit.Text = "&Quit";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // lbl
            // 
            this.lbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(126, 28);
            this.lbl.Text = "WSB Sale Report";
            this.lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrint
            // 
            this.btnPrint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.LightSeaGreen;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(47, 28);
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // RefreshBtn
            // 
            this.RefreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.RefreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("RefreshBtn.Image")));
            this.RefreshBtn.ImageTransparentColor = System.Drawing.Color.LightSeaGreen;
            this.RefreshBtn.Name = "RefreshBtn";
            this.RefreshBtn.Size = new System.Drawing.Size(57, 28);
            this.RefreshBtn.Text = "&Range";
            this.RefreshBtn.Click += new System.EventHandler(this.RefreshBtn_Click);
            // 
            // LedgerGrid
            // 
            this.LedgerGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LedgerGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LedgerGrid.Location = new System.Drawing.Point(0, 31);
            this.LedgerGrid.MainView = this.LedgerGridView;
            this.LedgerGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LedgerGrid.Name = "LedgerGrid";
            this.LedgerGrid.Size = new System.Drawing.Size(1115, 635);
            this.LedgerGrid.TabIndex = 373;
            this.LedgerGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.LedgerGridView,
            this.gridView4,
            this.gridView5});
            // 
            // LedgerGridView
            // 
            this.LedgerGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn10,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.LedgerGridView.DetailHeight = 458;
            this.LedgerGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.LedgerGridView.GridControl = this.LedgerGrid;
            this.LedgerGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", this.gridColumn6, "{0:0.##}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", this.gridColumn5, "{0:0.##}")});
            this.LedgerGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.LedgerGridView.Name = "LedgerGridView";
            this.LedgerGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.LedgerGridView.OptionsBehavior.Editable = false;
            this.LedgerGridView.OptionsView.ColumnAutoWidth = false;
            this.LedgerGridView.OptionsView.ShowFooter = true;
            this.LedgerGridView.OptionsView.ShowGroupPanel = false;
            this.LedgerGridView.OptionsView.ShowIndicator = false;
            this.LedgerGridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.LedgerGridView.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.LedgerGridView_CustomColumnDisplayText);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "VutType";
            this.gridColumn1.FieldName = "VutType";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "VutNo";
            this.gridColumn2.FieldName = "VutNo";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "VutDate";
            this.gridColumn3.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn3.FieldName = "VutDate";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 87;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "VutNart";
            this.gridColumn4.FieldName = "VutNart";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 87;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Debit";
            this.gridColumn5.FieldName = "Debit";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Debit", "SUM={0:0.##}")});
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 87;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Credit";
            this.gridColumn6.FieldName = "Credit";
            this.gridColumn6.MinWidth = 23;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Credit", "SUM={0:0.##}")});
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            this.gridColumn6.Width = 87;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Balance";
            this.gridColumn7.FieldName = "Balance";
            this.gridColumn7.MinWidth = 23;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 7;
            this.gridColumn7.Width = 87;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "LedgerPartyName";
            this.gridColumn8.FieldName = "LedgerPartyName";
            this.gridColumn8.MinWidth = 25;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 8;
            this.gridColumn8.Width = 87;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "CRDR";
            this.gridColumn9.FieldName = "CRDR";
            this.gridColumn9.MinWidth = 25;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 9;
            this.gridColumn9.Width = 94;
            // 
            // gridView4
            // 
            this.gridView4.DetailHeight = 458;
            this.gridView4.GridControl = this.LedgerGrid;
            this.gridView4.Name = "gridView4";
            // 
            // gridView5
            // 
            this.gridView5.DetailHeight = 458;
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.GridControl = this.LedgerGrid;
            this.gridView5.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsView.ColumnAutoWidth = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.OptionsView.ShowIndicator = false;
            this.gridView5.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "VutDesc";
            this.gridColumn10.FieldName = "VutDesc";
            this.gridColumn10.MinWidth = 25;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 94;
            // 
            // FrmPartyAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 666);
            this.ControlBox = false;
            this.Controls.Add(this.LedgerGrid);
            this.Controls.Add(this.Menu_ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPartyAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPartyAccounts_Load);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LedgerGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LedgerGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripLabel lbl;
        private System.Windows.Forms.ToolStripButton RefreshBtn;
        private DevExpress.XtraGrid.GridControl LedgerGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView LedgerGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}