﻿
namespace WindowsFormsApplication1.Forms_Master
{
    partial class frmAttendanceLoading
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendanceLoading));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.btnAdd2 = new System.Windows.Forms.ToolStripButton();
            this.SFeedingGrid = new DevExpress.XtraGrid.GridControl();
            this.SFeedingGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gridView_AttendanceData = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControl_AttendanceData = new DevExpress.XtraGrid.GridControl();
            this.btnLoad_Data = new DevExpress.XtraEditors.SimpleButton();
            this.DtStartDate = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new DevExpress.XtraEditors.LabelControl();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.txtEmpCode = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEmpName = new DevExpress.XtraEditors.TextEdit();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnPrintPreview = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnExportXsls = new DevExpress.XtraEditors.SimpleButton();
            this.lblemp = new DevExpress.XtraEditors.LabelControl();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SFeedingGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SFeedingGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_AttendanceData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_AttendanceData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtStartDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
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
            this.btnSave,
            this.toolStripButton1,
            this.btnRefresh,
            this.btnLoad,
            this.btnAdd,
            this.btnAdd2});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(1252, 31);
            this.Menu_ToolStrip.TabIndex = 200;
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
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnSave.Size = new System.Drawing.Size(55, 28);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.toolStripButton1.Size = new System.Drawing.Size(79, 28);
            this.toolStripButton1.Text = "Validate";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnRefresh.Size = new System.Drawing.Size(77, 28);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnLoad.Size = new System.Drawing.Size(57, 28);
            this.btnLoad.Text = "Load";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::WindowsFormsApplication1.Properties.Resources.Add;
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnAdd.Size = new System.Drawing.Size(72, 28);
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnAdd2
            // 
            this.btnAdd2.Image = global::WindowsFormsApplication1.Properties.Resources.Add;
            this.btnAdd2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd2.Name = "btnAdd2";
            this.btnAdd2.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnAdd2.Size = new System.Drawing.Size(81, 28);
            this.btnAdd2.Text = "Add2";
            this.btnAdd2.Click += new System.EventHandler(this.btnAdd2_Click);
            // 
            // SFeedingGrid
            // 
            this.SFeedingGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SFeedingGrid.Location = new System.Drawing.Point(407, 225);
            this.SFeedingGrid.MainView = this.SFeedingGridView;
            this.SFeedingGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SFeedingGrid.Name = "SFeedingGrid";
            this.SFeedingGrid.Size = new System.Drawing.Size(499, 383);
            this.SFeedingGrid.TabIndex = 11;
            this.SFeedingGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SFeedingGridView,
            this.gridView3});
            this.SFeedingGrid.Visible = false;
            // 
            // SFeedingGridView
            // 
            this.SFeedingGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9});
            this.SFeedingGridView.DetailHeight = 458;
            this.SFeedingGridView.GridControl = this.SFeedingGrid;
            this.SFeedingGridView.Name = "SFeedingGridView";
            this.SFeedingGridView.OptionsBehavior.Editable = false;
            this.SFeedingGridView.OptionsView.ColumnAutoWidth = false;
            this.SFeedingGridView.OptionsView.ShowFooter = true;
            this.SFeedingGridView.OptionsView.ShowGroupPanel = false;
            this.SFeedingGridView.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "MonthYear";
            this.gridColumn1.FieldName = "MonthYear";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "EmpCode";
            this.gridColumn2.FieldName = "EmpCode";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "EmpName";
            this.gridColumn3.FieldName = "EmpName";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 87;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "EmpDW";
            this.gridColumn4.FieldName = "EmpDW";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 87;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "EmpPH";
            this.gridColumn5.FieldName = "EmpPH";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 87;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "EmpEL";
            this.gridColumn6.FieldName = "EmpEL";
            this.gridColumn6.MinWidth = 23;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 87;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "EmpCL";
            this.gridColumn7.FieldName = "EmpCL";
            this.gridColumn7.MinWidth = 23;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 87;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "EmpSL";
            this.gridColumn8.FieldName = "EmpSL";
            this.gridColumn8.MinWidth = 23;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 87;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "EmpPymtMode";
            this.gridColumn9.FieldName = "EmpPymtMode";
            this.gridColumn9.MinWidth = 23;
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 8;
            this.gridColumn9.Width = 87;
            // 
            // gridView3
            // 
            this.gridView3.DetailHeight = 458;
            this.gridView3.GridControl = this.SFeedingGrid;
            this.gridView3.Name = "gridView3";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // gridView_AttendanceData
            // 
            this.gridView_AttendanceData.DetailHeight = 458;
            this.gridView_AttendanceData.GridControl = this.gridControl_AttendanceData;
            this.gridView_AttendanceData.Name = "gridView_AttendanceData";
            this.gridView_AttendanceData.OptionsView.ShowFooter = true;
            this.gridView_AttendanceData.OptionsView.ShowGroupPanel = false;
            this.gridView_AttendanceData.CustomDrawFooterCell += new DevExpress.XtraGrid.Views.Grid.FooterCellCustomDrawEventHandler(this.gridView_AttendanceData_CustomDrawFooterCell);
            this.gridView_AttendanceData.RowStyle += new DevExpress.XtraGrid.Views.Grid.RowStyleEventHandler(this.gridView_AttendanceData_RowStyle);
            this.gridView_AttendanceData.CustomSummaryCalculate += new DevExpress.Data.CustomSummaryEventHandler(this.gridView_AttendanceData_CustomSummaryCalculate);
            // 
            // gridControl_AttendanceData
            // 
            this.gridControl_AttendanceData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl_AttendanceData.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl_AttendanceData.Location = new System.Drawing.Point(0, 129);
            this.gridControl_AttendanceData.MainView = this.gridView_AttendanceData;
            this.gridControl_AttendanceData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridControl_AttendanceData.Name = "gridControl_AttendanceData";
            this.gridControl_AttendanceData.Size = new System.Drawing.Size(1252, 495);
            this.gridControl_AttendanceData.TabIndex = 352;
            this.gridControl_AttendanceData.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView_AttendanceData});
            this.gridControl_AttendanceData.DoubleClick += new System.EventHandler(this.gridControl_AttendanceData_DoubleClick);
            // 
            // btnLoad_Data
            // 
            this.btnLoad_Data.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad_Data.ImageOptions.Image")));
            this.btnLoad_Data.Location = new System.Drawing.Point(707, 64);
            this.btnLoad_Data.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoad_Data.Name = "btnLoad_Data";
            this.btnLoad_Data.Size = new System.Drawing.Size(128, 39);
            this.btnLoad_Data.TabIndex = 3;
            this.btnLoad_Data.Text = "Load";
            this.btnLoad_Data.Click += new System.EventHandler(this.btnLoad_Data_Click);
            // 
            // DtStartDate
            // 
            this.DtStartDate.EnterMoveNextControl = true;
            this.DtStartDate.Location = new System.Drawing.Point(147, 50);
            this.DtStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtStartDate.Name = "DtStartDate";
            this.DtStartDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtStartDate.Properties.Appearance.Options.UseFont = true;
            this.DtStartDate.Properties.EditFormat.FormatString = "MM-yyyy";
            this.DtStartDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DtStartDate.Properties.Mask.EditMask = "MM-yyyy";
            this.DtStartDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.DtStartDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.DtStartDate.Properties.MaxLength = 6;
            this.DtStartDate.Size = new System.Drawing.Size(105, 28);
            this.DtStartDate.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.Appearance.BackColor = System.Drawing.Color.White;
            this.label13.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Appearance.Options.UseBackColor = true;
            this.label13.Appearance.Options.UseFont = true;
            this.label13.Location = new System.Drawing.Point(5, 55);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(137, 21);
            this.label13.TabIndex = 357;
            this.label13.Text = "Select Month/Year";
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.White;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 31);
            this.splitter1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(1252, 98);
            this.splitter1.TabIndex = 196;
            this.splitter1.TabStop = false;
            this.splitter1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitter1_SplitterMoved);
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.EnterMoveNextControl = true;
            this.txtEmpCode.Location = new System.Drawing.Point(147, 84);
            this.txtEmpCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmpCode.Properties.Appearance.Options.UseFont = true;
            this.txtEmpCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpCode.Properties.MaxLength = 6;
            this.txtEmpCode.Size = new System.Drawing.Size(105, 28);
            this.txtEmpCode.TabIndex = 2;
            this.txtEmpCode.EditValueChanged += new System.EventHandler(this.txtEmpCode_EditValueChanged);
            this.txtEmpCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpCode_KeyDown);
            // 
            // label1
            // 
            this.label1.Appearance.BackColor = System.Drawing.Color.White;
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Appearance.Options.UseBackColor = true;
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Location = new System.Drawing.Point(66, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 21);
            this.label1.TabIndex = 359;
            this.label1.Text = "EmpCode";
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(283, 279);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(419, 209);
            this.HelpGrid.TabIndex = 360;
            this.HelpGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HelpGridView});
            this.HelpGrid.Visible = false;
            this.HelpGrid.Click += new System.EventHandler(this.HelpGrid_Click);
            this.HelpGrid.DoubleClick += new System.EventHandler(this.HelpGrid_DoubleClick);
            this.HelpGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HelpGrid_KeyDown);
            // 
            // HelpGridView
            // 
            this.HelpGridView.DetailHeight = 458;
            this.HelpGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.HelpGridView.GridControl = this.HelpGrid;
            this.HelpGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.HelpGridView.Name = "HelpGridView";
            this.HelpGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.HelpGridView.OptionsBehavior.Editable = false;
            this.HelpGridView.OptionsView.ShowGroupPanel = false;
            this.HelpGridView.OptionsView.ShowIndicator = false;
            this.HelpGridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(69, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 362;
            this.label2.Text = "Emp Name";
            this.label2.Visible = false;
            // 
            // txtEmpName
            // 
            this.txtEmpName.EnterMoveNextControl = true;
            this.txtEmpName.Location = new System.Drawing.Point(147, 88);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpName.Properties.MaxLength = 6;
            this.txtEmpName.Properties.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(105, 24);
            this.txtEmpName.TabIndex = 361;
            this.txtEmpName.Visible = false;
            // 
            // btnPrintPreview
            // 
            this.btnPrintPreview.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrintPreview.ImageOptions.Image")));
            this.btnPrintPreview.Location = new System.Drawing.Point(839, 64);
            this.btnPrintPreview.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrintPreview.Name = "btnPrintPreview";
            this.btnPrintPreview.Size = new System.Drawing.Size(128, 39);
            this.btnPrintPreview.TabIndex = 363;
            this.btnPrintPreview.Text = "Print Preview";
            this.btnPrintPreview.Click += new System.EventHandler(this.btnPrintPreview_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(971, 64);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(128, 39);
            this.btnPrint.TabIndex = 364;
            this.btnPrint.Text = "Print";
            this.btnPrint.Click += new System.EventHandler(this.BtnPrint_Click);
            // 
            // btnExportXsls
            // 
            this.btnExportXsls.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExportXsls.ImageOptions.Image")));
            this.btnExportXsls.Location = new System.Drawing.Point(1102, 64);
            this.btnExportXsls.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnExportXsls.Name = "btnExportXsls";
            this.btnExportXsls.Size = new System.Drawing.Size(128, 39);
            this.btnExportXsls.TabIndex = 365;
            this.btnExportXsls.Text = "Export To XLS";
            this.btnExportXsls.Click += new System.EventHandler(this.btnExportXsls_Click);
            // 
            // lblemp
            // 
            this.lblemp.Appearance.BackColor = System.Drawing.Color.White;
            this.lblemp.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblemp.Appearance.Options.UseBackColor = true;
            this.lblemp.Appearance.Options.UseFont = true;
            this.lblemp.Location = new System.Drawing.Point(259, 89);
            this.lblemp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblemp.Name = "lblemp";
            this.lblemp.Size = new System.Drawing.Size(12, 21);
            this.lblemp.TabIndex = 366;
            this.lblemp.Text = "...";
            this.lblemp.ToolTip = "EMPLOYEE NAME";
            this.lblemp.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // frmAttendanceLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 624);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.lblemp);
            this.Controls.Add(this.btnExportXsls);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnPrintPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEmpCode);
            this.Controls.Add(this.gridControl_AttendanceData);
            this.Controls.Add(this.btnLoad_Data);
            this.Controls.Add(this.DtStartDate);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.SFeedingGrid);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEmpName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAttendanceLoading";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmExcelDataLoading_Load);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SFeedingGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SFeedingGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView_AttendanceData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl_AttendanceData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtStartDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private DevExpress.XtraGrid.GridControl SFeedingGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView SFeedingGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripButton btnAdd2;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView_AttendanceData;
        private DevExpress.XtraGrid.GridControl gridControl_AttendanceData;
        private DevExpress.XtraEditors.SimpleButton btnLoad_Data;
        private DevExpress.XtraEditors.TextEdit DtStartDate;
        private DevExpress.XtraEditors.LabelControl label13;
        private System.Windows.Forms.Splitter splitter1;
        private DevExpress.XtraEditors.TextEdit txtEmpCode;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit txtEmpName;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private DevExpress.XtraEditors.SimpleButton btnPrintPreview;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnExportXsls;
        private DevExpress.XtraEditors.LabelControl lblemp;
    }
}