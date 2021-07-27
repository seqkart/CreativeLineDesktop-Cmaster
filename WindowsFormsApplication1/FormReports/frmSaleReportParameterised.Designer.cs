﻿
namespace WindowsFormsApplication1.FormReports
{
    partial class frmSaleReportParameterised
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
            this.MasterGrid.Size = new System.Drawing.Size(646, 417);
            this.MasterGrid.TabIndex = 2;
            this.MasterGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MasterGridView});
            // 
            // MasterGridView
            // 
            this.MasterGridView.DetailHeight = 458;
            gridFormatRule1.Name = "Format0";
            gridFormatRule1.Rule = null;
            this.MasterGridView.FormatRules.Add(gridFormatRule1);
            this.MasterGridView.GridControl = this.MasterGrid;
            this.MasterGridView.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
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
            // frmSaleReportParameterised
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 417);
            this.Controls.Add(this.MasterGrid);
            this.Name = "frmSaleReportParameterised";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.MasterGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MasterGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl MasterGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView MasterGridView;
    }
}