﻿
namespace WindowsFormsApplication1.Transaction
{
    partial class frmMessageBuilder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMessageBuilder));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnMakeQuery = new DevExpress.XtraEditors.SimpleButton();
            this.btnSource = new DevExpress.XtraEditors.SimpleButton();
            this.ColumnGrid = new DevExpress.XtraGrid.GridControl();
            this.ColumnGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TableGrid = new DevExpress.XtraGrid.GridControl();
            this.TableGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ParameterGrid = new DevExpress.XtraGrid.GridControl();
            this.ParameterGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtMessage = new DevExpress.XtraEditors.MemoEdit();
            this.txtQuery = new DevExpress.XtraEditors.MemoEdit();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtQueryNo = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParameterGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParameterGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.btnMakeQuery);
            this.groupControl1.Controls.Add(this.btnSource);
            this.groupControl1.Controls.Add(this.ColumnGrid);
            this.groupControl1.Controls.Add(this.TableGrid);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(64, 77);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(450, 912);
            this.groupControl1.TabIndex = 211;
            this.groupControl1.Text = "Source Db";
            // 
            // btnMakeQuery
            // 
            this.btnMakeQuery.Location = new System.Drawing.Point(353, 185);
            this.btnMakeQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMakeQuery.Name = "btnMakeQuery";
            this.btnMakeQuery.Size = new System.Drawing.Size(87, 73);
            this.btnMakeQuery.TabIndex = 209;
            this.btnMakeQuery.Text = "Make Query";
            this.btnMakeQuery.Click += new System.EventHandler(this.btnMakeQuery_Click);
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(353, 54);
            this.btnSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(87, 73);
            this.btnSource.TabIndex = 4;
            this.btnSource.Text = "Load \r\nTables";
            this.btnSource.Click += new System.EventHandler(this.btnSource_Click);
            // 
            // ColumnGrid
            // 
            this.ColumnGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColumnGrid.Location = new System.Drawing.Point(16, 324);
            this.ColumnGrid.MainView = this.ColumnGridView;
            this.ColumnGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ColumnGrid.Name = "ColumnGrid";
            this.ColumnGrid.Size = new System.Drawing.Size(411, 168);
            this.ColumnGrid.TabIndex = 208;
            this.ColumnGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ColumnGridView});
            this.ColumnGrid.DoubleClick += new System.EventHandler(this.ColumnGrid_DoubleClick);
            // 
            // ColumnGridView
            // 
            this.ColumnGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7});
            this.ColumnGridView.DetailHeight = 457;
            this.ColumnGridView.GridControl = this.ColumnGrid;
            this.ColumnGridView.Name = "ColumnGridView";
            this.ColumnGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.ColumnGridView.OptionsView.ShowFooter = true;
            this.ColumnGridView.OptionsView.ShowGroupPanel = false;
            this.ColumnGridView.OptionsView.ShowIndicator = false;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "ColumnName";
            this.gridColumn7.FieldName = "ColumnName";
            this.gridColumn7.MinWidth = 23;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ColumnName", "{0}")});
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 0;
            this.gridColumn7.Width = 87;
            // 
            // TableGrid
            // 
            this.TableGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableGrid.Location = new System.Drawing.Point(16, 54);
            this.TableGrid.MainView = this.TableGridView;
            this.TableGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableGrid.Name = "TableGrid";
            this.TableGrid.Size = new System.Drawing.Size(331, 261);
            this.TableGrid.TabIndex = 207;
            this.TableGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.TableGridView});
            this.TableGrid.DockChanged += new System.EventHandler(this.TableGrid_DockChanged);
            this.TableGrid.DoubleClick += new System.EventHandler(this.TableGrid_DoubleClick);
            // 
            // TableGridView
            // 
            this.TableGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.TableGridView.DetailHeight = 457;
            this.TableGridView.GridControl = this.TableGrid;
            this.TableGridView.Name = "TableGridView";
            this.TableGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.TableGridView.OptionsView.ShowFooter = true;
            this.TableGridView.OptionsView.ShowGroupPanel = false;
            this.TableGridView.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "TableName";
            this.gridColumn1.FieldName = "TableName";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TableName", "{0}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 87;
            // 
            // ParameterGrid
            // 
            this.ParameterGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParameterGrid.Location = new System.Drawing.Point(520, 296);
            this.ParameterGrid.MainView = this.ParameterGridView;
            this.ParameterGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ParameterGrid.Name = "ParameterGrid";
            this.ParameterGrid.Size = new System.Drawing.Size(421, 215);
            this.ParameterGrid.TabIndex = 209;
            this.ParameterGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.ParameterGridView});
            // 
            // ParameterGridView
            // 
            this.ParameterGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn5});
            this.ParameterGridView.DetailHeight = 457;
            this.ParameterGridView.GridControl = this.ParameterGrid;
            this.ParameterGridView.Name = "ParameterGridView";
            this.ParameterGridView.OptionsView.ShowFooter = true;
            this.ParameterGridView.OptionsView.ShowGroupPanel = false;
            this.ParameterGridView.OptionsView.ShowIndicator = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "ColumnName";
            this.gridColumn2.FieldName = "ColumnName";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ColumnName", "{0}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Select";
            this.gridColumn5.FieldName = "Select";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 87;
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(520, 18);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(421, 239);
            this.txtMessage.TabIndex = 555;
            // 
            // txtQuery
            // 
            this.txtQuery.Location = new System.Drawing.Point(520, 541);
            this.txtQuery.Name = "txtQuery";
            this.txtQuery.Size = new System.Drawing.Size(443, 239);
            this.txtQuery.TabIndex = 556;
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(1317, 31);
            this.Menu_ToolStrip.TabIndex = 559;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnQuit.Size = new System.Drawing.Size(53, 28);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 28);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtQueryNo
            // 
            this.txtQueryNo.Enabled = false;
            this.txtQueryNo.Location = new System.Drawing.Point(64, 45);
            this.txtQueryNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQueryNo.Name = "txtQueryNo";
            this.txtQueryNo.Size = new System.Drawing.Size(173, 24);
            this.txtQueryNo.TabIndex = 558;
            this.txtQueryNo.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(282, 406);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 557;
            this.label1.Text = "Indent No";
            // 
            // frmMessageBuilder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 772);
            this.ControlBox = false;
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtQueryNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuery);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.ParameterGrid);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmMessageBuilder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmMessageBuilder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ColumnGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ColumnGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParameterGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ParameterGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMessage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQuery.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtQueryNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSource;
        private DevExpress.XtraGrid.GridControl ColumnGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView ColumnGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.GridControl TableGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView TableGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.GridControl ParameterGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView ParameterGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.SimpleButton btnMakeQuery;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.MemoEdit txtMessage;
        private DevExpress.XtraEditors.MemoEdit txtQuery;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtQueryNo;
        private DevExpress.XtraEditors.LabelControl label1;
    }
}