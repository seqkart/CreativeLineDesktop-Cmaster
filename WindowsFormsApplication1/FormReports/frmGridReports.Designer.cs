namespace WindowsFormsApplication1.FormReports
{
    partial class FrmGridReports
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            this.MasterGrid = new DevExpress.XtraGrid.GridControl();
            this.MasterGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MasterGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MasterGrid
            // 
            this.MasterGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MasterGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MasterGrid.Location = new System.Drawing.Point(0, 0);
            this.MasterGrid.MainView = this.MasterGridView;
            this.MasterGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MasterGrid.Name = "MasterGrid";
            this.MasterGrid.Size = new System.Drawing.Size(1297, 702);
            this.MasterGrid.TabIndex = 1;
            this.MasterGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MasterGridView});
            this.MasterGrid.DoubleClick += new System.EventHandler(this.MasterGrid_DoubleClick);
            // 
            // MasterGridView
            // 
            this.MasterGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.MasterGridView.DetailHeight = 458;
            gridFormatRule1.Name = "Format0";
            gridFormatRule1.Rule = null;
            this.MasterGridView.FormatRules.Add(gridFormatRule1);
            this.MasterGridView.GridControl = this.MasterGrid;
            this.MasterGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Custom, "NET AMOUNT*0.35", this.gridColumn1, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, ""),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.None, "", null, "")});
            this.MasterGridView.Name = "MasterGridView";
            this.MasterGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.MasterGridView.OptionsBehavior.Editable = false;
            this.MasterGridView.OptionsView.ColumnAutoWidth = false;
            this.MasterGridView.OptionsView.ShowFooter = true;
            this.MasterGridView.OptionsView.ShowGroupPanel = false;
            this.MasterGridView.OptionsView.ShowIndicator = false;
            this.MasterGridView.PopupMenuShowing += new DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(this.MasterGridView_PopupMenuShowing);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "NET AMOUNT";
            this.gridColumn1.FieldName = "NET AMOUNT";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Custom)});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 87;
            // 
            // frmGridReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 702);
            this.Controls.Add(this.MasterGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGridReports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGridReports_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MasterGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl MasterGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView MasterGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}