﻿
namespace WindowsFormsApplication1.Transaction
{
    partial class frmImportSaleFromExcel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportSaleFromExcel));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.InfoGrid = new DevExpress.XtraGrid.GridControl();
            this.InfoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Menu_ToolStrip.CanOverflow = false;
            this.Menu_ToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuit,
            this.btnLoad,
            this.btnSave});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(860, 26);
            this.Menu_ToolStrip.TabIndex = 438;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnQuit.Size = new System.Drawing.Size(45, 23);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(69, 23);
            this.btnLoad.Text = "Load Excel";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(38, 23);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // InfoGrid
            // 
            this.InfoGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoGrid.Location = new System.Drawing.Point(0, 26);
            this.InfoGrid.MainView = this.InfoGridView;
            this.InfoGrid.Name = "InfoGrid";
            this.InfoGrid.Size = new System.Drawing.Size(860, 434);
            this.InfoGrid.TabIndex = 446;
            this.InfoGrid.TabStop = false;
            this.InfoGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InfoGridView,
            this.gridView4});
            // 
            // InfoGridView
            // 
            this.InfoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6});
            this.InfoGridView.CustomizationFormBounds = new System.Drawing.Rectangle(580, 341, 216, 178);
            this.InfoGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.InfoGridView.GridControl = this.InfoGrid;
            this.InfoGridView.Name = "InfoGridView";
            this.InfoGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.InfoGridView.OptionsPrint.PrintFooter = false;
            this.InfoGridView.OptionsPrint.PrintGroupFooter = false;
            this.InfoGridView.OptionsView.ShowFooter = true;
            this.InfoGridView.OptionsView.ShowGroupPanel = false;
            this.InfoGridView.OptionsView.ShowIndicator = false;
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.InfoGrid;
            this.gridView4.Name = "gridView4";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "AccCode";
            this.gridColumn1.FieldName = "AccCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "BILL DATE";
            this.gridColumn2.FieldName = "BILL DATE";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "USER ITEM CODE";
            this.gridColumn3.FieldName = "USER ITEM CODE";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "NET SALE VALUE";
            this.gridColumn4.FieldName = "NET SALE VALUE";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "gridColumn5";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "gridColumn6";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            // 
            // frmImportSaleFromExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 460);
            this.ControlBox = false;
            this.Controls.Add(this.InfoGrid);
            this.Controls.Add(this.Menu_ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmImportSaleFromExcel";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraGrid.GridControl InfoGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView InfoGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}