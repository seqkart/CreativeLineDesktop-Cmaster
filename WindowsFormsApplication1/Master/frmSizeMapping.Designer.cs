﻿namespace WindowsFormsApplication1.Master
{
    partial class FrmSizeMapping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSizeMapping));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.GroupGrid = new DevExpress.XtraGrid.GridControl();
            this.GroupGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SizeGrid = new DevExpress.XtraGrid.GridControl();
            this.SizeGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Menu_ToolStrip.CanOverflow = false;
            this.Menu_ToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu_ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuit,
            this.btnSave});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(1034, 31);
            this.Menu_ToolStrip.TabIndex = 204;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(43, 28);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 28);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // GroupGrid
            // 
            this.GroupGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupGrid.Location = new System.Drawing.Point(14, 48);
            this.GroupGrid.MainView = this.GroupGridView;
            this.GroupGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GroupGrid.Name = "GroupGrid";
            this.GroupGrid.Size = new System.Drawing.Size(413, 382);
            this.GroupGrid.TabIndex = 205;
            this.GroupGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GroupGridView});
            // 
            // GroupGridView
            // 
            this.GroupGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.GroupGridView.DetailHeight = 458;
            this.GroupGridView.GridControl = this.GroupGrid;
            this.GroupGridView.Name = "GroupGridView";
            this.GroupGridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "GrpCode";
            this.gridColumn1.FieldName = "GrpCode";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "GrpDesc";
            this.gridColumn2.FieldName = "GrpDesc";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "GrpSubCode";
            this.gridColumn3.FieldName = "GrpSubCode";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 87;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "GrpSubDesc";
            this.gridColumn4.FieldName = "GrpSubDesc";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 87;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Select";
            this.gridColumn5.FieldName = "Select";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 87;
            // 
            // SizeGrid
            // 
            this.SizeGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SizeGrid.Location = new System.Drawing.Point(434, 48);
            this.SizeGrid.MainView = this.SizeGridView;
            this.SizeGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SizeGrid.Name = "SizeGrid";
            this.SizeGrid.Size = new System.Drawing.Size(589, 382);
            this.SizeGrid.TabIndex = 205;
            this.SizeGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SizeGridView});
            // 
            // SizeGridView
            // 
            this.SizeGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn10,
            this.gridColumn9});
            this.SizeGridView.DetailHeight = 458;
            this.SizeGridView.GridControl = this.SizeGrid;
            this.SizeGridView.Name = "SizeGridView";
            this.SizeGridView.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "SZSYSID";
            this.gridColumn6.FieldName = "SZSYSID";
            this.gridColumn6.MinWidth = 23;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.OptionsColumn.AllowEdit = false;
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 0;
            this.gridColumn6.Width = 87;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "SZNAME";
            this.gridColumn7.FieldName = "SZNAME";
            this.gridColumn7.MinWidth = 23;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 1;
            this.gridColumn7.Width = 87;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "SZDESC";
            this.gridColumn8.FieldName = "SZDESC";
            this.gridColumn8.MinWidth = 23;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.OptionsColumn.AllowEdit = false;
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 2;
            this.gridColumn8.Width = 87;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "SizeDesc";
            this.gridColumn10.FieldName = "SizeDesc";
            this.gridColumn10.MinWidth = 23;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            this.gridColumn10.Width = 87;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Select";
            this.gridColumn9.FieldName = "Select";
            this.gridColumn9.MinWidth = 23;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 4;
            this.gridColumn9.Width = 87;
            // 
            // frmSizeMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1034, 443);
            this.ControlBox = false;
            this.Controls.Add(this.SizeGrid);
            this.Controls.Add(this.GroupGrid);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Cursor = System.Windows.Forms.Cursors.No;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSizeMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmSizeMapping_Load);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GroupGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SizeGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraGrid.GridControl GroupGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView GroupGridView;
        private DevExpress.XtraGrid.GridControl SizeGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView SizeGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
    }
}