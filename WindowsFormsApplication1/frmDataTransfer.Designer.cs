﻿namespace WindowsFormsApplication1
{
    partial class frmDataTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDataTransfer));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnLoadQuery = new System.Windows.Forms.ToolStripButton();
            this.btnLoadTables = new System.Windows.Forms.ToolStripButton();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnSource = new DevExpress.XtraEditors.SimpleButton();
            this.SColumnGrid = new DevExpress.XtraGrid.GridControl();
            this.SColumnGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STableGrid = new DevExpress.XtraGrid.GridControl();
            this.STableGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtSourceDataBase = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSourcePassword = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSourceUserName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSourceServer = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnDestination = new DevExpress.XtraEditors.SimpleButton();
            this.DColumnGrid = new DevExpress.XtraGrid.GridControl();
            this.DColumnGridVIew = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbSourceColumns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.DTableGrid = new DevExpress.XtraGrid.GridControl();
            this.DTableGridVIew = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtDestinationUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtDestinationDataBase = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.label8 = new DevExpress.XtraEditors.LabelControl();
            this.txtDestinationServer = new DevExpress.XtraEditors.TextEdit();
            this.txtDestinationPassword = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.marqueeProgressBarControl1 = new DevExpress.XtraEditors.MarqueeProgressBarControl();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.label9 = new DevExpress.XtraEditors.LabelControl();
            this.txtSourceConnection = new System.Windows.Forms.RichTextBox();
            this.txtDestinationConnection = new System.Windows.Forms.RichTextBox();
            this.label10 = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalRecordsToTransfer = new DevExpress.XtraEditors.LabelControl();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SColumnGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SColumnGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STableGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STableGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSourceDataBase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSourcePassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSourceUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSourceServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DColumnGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DColumnGridVIew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTableGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTableGridVIew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinationUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinationDataBase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinationServer.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinationPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).BeginInit();
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
            this.btnLoadQuery,
            this.btnLoadTables,
            this.btnQuit,
            this.btnSave});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(1469, 27);
            this.Menu_ToolStrip.TabIndex = 208;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnLoadQuery
            // 
            this.btnLoadQuery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoadQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadQuery.Image")));
            this.btnLoadQuery.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadQuery.Name = "btnLoadQuery";
            this.btnLoadQuery.Size = new System.Drawing.Size(94, 24);
            this.btnLoadQuery.Text = "ShowQuery";
            // 
            // btnLoadTables
            // 
            this.btnLoadTables.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoadTables.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadTables.Image")));
            this.btnLoadTables.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoadTables.Name = "btnLoadTables";
            this.btnLoadTables.Size = new System.Drawing.Size(95, 24);
            this.btnLoadTables.Text = "Load Tables";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(43, 24);
            this.btnQuit.Text = "Quit";
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 24);
            this.btnSave.Text = "Save";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(958, 119);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(434, 330);
            this.richTextBox1.TabIndex = 209;
            this.richTextBox1.Text = "";
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.btnSource);
            this.groupControl1.Controls.Add(this.SColumnGrid);
            this.groupControl1.Controls.Add(this.STableGrid);
            this.groupControl1.Controls.Add(this.txtSourceDataBase);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.txtSourcePassword);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.txtSourceUserName);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.txtSourceServer);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(26, 54);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(449, 911);
            this.groupControl1.TabIndex = 210;
            this.groupControl1.Text = "Source Db";
            // 
            // btnSource
            // 
            this.btnSource.Location = new System.Drawing.Point(353, 71);
            this.btnSource.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSource.Name = "btnSource";
            this.btnSource.Size = new System.Drawing.Size(87, 73);
            this.btnSource.TabIndex = 4;
            this.btnSource.Text = "Load \r\nConnection";
            this.btnSource.Click += new System.EventHandler(this.BtnSource_Click);
            // 
            // SColumnGrid
            // 
            this.SColumnGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SColumnGrid.Location = new System.Drawing.Point(14, 475);
            this.SColumnGrid.MainView = this.SColumnGridView;
            this.SColumnGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SColumnGrid.Name = "SColumnGrid";
            this.SColumnGrid.Size = new System.Drawing.Size(418, 417);
            this.SColumnGrid.TabIndex = 208;
            this.SColumnGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.SColumnGridView});
            // 
            // SColumnGridView
            // 
            this.SColumnGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn7});
            this.SColumnGridView.DetailHeight = 458;
            this.SColumnGridView.GridControl = this.SColumnGrid;
            this.SColumnGridView.Name = "SColumnGridView";
            this.SColumnGridView.OptionsView.ShowFooter = true;
            this.SColumnGridView.OptionsView.ShowGroupPanel = false;
            this.SColumnGridView.OptionsView.ShowIndicator = false;
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
            // STableGrid
            // 
            this.STableGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.STableGrid.Location = new System.Drawing.Point(14, 186);
            this.STableGrid.MainView = this.STableGridView;
            this.STableGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.STableGrid.Name = "STableGrid";
            this.STableGrid.Size = new System.Drawing.Size(418, 262);
            this.STableGrid.TabIndex = 207;
            this.STableGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.STableGridView});
            this.STableGrid.DoubleClick += new System.EventHandler(this.STableGrid_DoubleClick);
            // 
            // STableGridView
            // 
            this.STableGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1});
            this.STableGridView.DetailHeight = 458;
            this.STableGridView.GridControl = this.STableGrid;
            this.STableGridView.Name = "STableGridView";
            this.STableGridView.OptionsView.ShowFooter = true;
            this.STableGridView.OptionsView.ShowGroupPanel = false;
            this.STableGridView.OptionsView.ShowIndicator = false;
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
            // txtSourceDataBase
            // 
            this.txtSourceDataBase.EnterMoveNextControl = true;
            this.txtSourceDataBase.Location = new System.Drawing.Point(129, 152);
            this.txtSourceDataBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSourceDataBase.Name = "txtSourceDataBase";
            this.txtSourceDataBase.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSourceDataBase.Properties.MaxLength = 100;
            this.txtSourceDataBase.Size = new System.Drawing.Size(195, 24);
            this.txtSourceDataBase.TabIndex = 3;
            this.txtSourceDataBase.EditValueChanged += new System.EventHandler(this.TxtSourceServer_EditValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(59, 156);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 203;
            this.label5.Text = "Database";
            // 
            // txtSourcePassword
            // 
            this.txtSourcePassword.EnterMoveNextControl = true;
            this.txtSourcePassword.Location = new System.Drawing.Point(129, 118);
            this.txtSourcePassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSourcePassword.Name = "txtSourcePassword";
            this.txtSourcePassword.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSourcePassword.Properties.MaxLength = 100;
            this.txtSourcePassword.Properties.PasswordChar = '*';
            this.txtSourcePassword.Size = new System.Drawing.Size(195, 24);
            this.txtSourcePassword.TabIndex = 2;
            this.txtSourcePassword.EditValueChanged += new System.EventHandler(this.TxtSourceServer_EditValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(58, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 203;
            this.label4.Text = "Password";
            // 
            // txtSourceUserName
            // 
            this.txtSourceUserName.EnterMoveNextControl = true;
            this.txtSourceUserName.Location = new System.Drawing.Point(129, 84);
            this.txtSourceUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSourceUserName.Name = "txtSourceUserName";
            this.txtSourceUserName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSourceUserName.Properties.MaxLength = 100;
            this.txtSourceUserName.Size = new System.Drawing.Size(195, 24);
            this.txtSourceUserName.TabIndex = 1;
            this.txtSourceUserName.EditValueChanged += new System.EventHandler(this.TxtSourceServer_EditValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(51, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 203;
            this.label2.Text = "User Name";
            // 
            // txtSourceServer
            // 
            this.txtSourceServer.EnterMoveNextControl = true;
            this.txtSourceServer.Location = new System.Drawing.Point(129, 50);
            this.txtSourceServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSourceServer.Name = "txtSourceServer";
            this.txtSourceServer.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtSourceServer.Properties.MaxLength = 100;
            this.txtSourceServer.Size = new System.Drawing.Size(195, 24);
            this.txtSourceServer.TabIndex = 0;
            this.txtSourceServer.EditValueChanged += new System.EventHandler(this.TxtSourceServer_EditValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(79, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 17);
            this.label3.TabIndex = 203;
            this.label3.Text = "Server";
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl2.CaptionImageOptions.SvgImage")));
            this.groupControl2.Controls.Add(this.btnDestination);
            this.groupControl2.Controls.Add(this.DColumnGrid);
            this.groupControl2.Controls.Add(this.DTableGrid);
            this.groupControl2.Controls.Add(this.txtDestinationUserName);
            this.groupControl2.Controls.Add(this.txtDestinationDataBase);
            this.groupControl2.Controls.Add(this.label1);
            this.groupControl2.Controls.Add(this.label8);
            this.groupControl2.Controls.Add(this.txtDestinationServer);
            this.groupControl2.Controls.Add(this.txtDestinationPassword);
            this.groupControl2.Controls.Add(this.label6);
            this.groupControl2.Controls.Add(this.label7);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(482, 54);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(448, 911);
            this.groupControl2.TabIndex = 211;
            this.groupControl2.Text = "Destination Db";
            // 
            // btnDestination
            // 
            this.btnDestination.Location = new System.Drawing.Point(330, 65);
            this.btnDestination.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDestination.Name = "btnDestination";
            this.btnDestination.Size = new System.Drawing.Size(87, 73);
            this.btnDestination.TabIndex = 209;
            this.btnDestination.Text = "Load \r\nConnection";
            this.btnDestination.Click += new System.EventHandler(this.BtnDestination_Click);
            // 
            // DColumnGrid
            // 
            this.DColumnGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DColumnGrid.Location = new System.Drawing.Point(14, 475);
            this.DColumnGrid.MainView = this.DColumnGridVIew;
            this.DColumnGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DColumnGrid.Name = "DColumnGrid";
            this.DColumnGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.DColumnGrid.Size = new System.Drawing.Size(418, 417);
            this.DColumnGrid.TabIndex = 209;
            this.DColumnGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DColumnGridVIew});
            // 
            // DColumnGridVIew
            // 
            this.DColumnGridVIew.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn10,
            this.cmbSourceColumns});
            this.DColumnGridVIew.DetailHeight = 458;
            this.DColumnGridVIew.GridControl = this.DColumnGrid;
            this.DColumnGridVIew.Name = "DColumnGridVIew";
            this.DColumnGridVIew.OptionsView.ShowGroupPanel = false;
            this.DColumnGridVIew.OptionsView.ShowIndicator = false;
            this.DColumnGridVIew.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.DColumnGridVIew_ValidatingEditor);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "ColumnName";
            this.gridColumn5.FieldName = "ColumnName";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "ColumnName", "{0}")});
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            this.gridColumn5.Width = 87;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Value";
            this.gridColumn10.FieldName = "Value";
            this.gridColumn10.MinWidth = 23;
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 1;
            this.gridColumn10.Width = 87;
            // 
            // cmbSourceColumns
            // 
            this.cmbSourceColumns.Caption = "Source";
            this.cmbSourceColumns.ColumnEdit = this.repositoryItemComboBox1;
            this.cmbSourceColumns.FieldName = "Source";
            this.cmbSourceColumns.MinWidth = 23;
            this.cmbSourceColumns.Name = "cmbSourceColumns";
            this.cmbSourceColumns.Visible = true;
            this.cmbSourceColumns.VisibleIndex = 2;
            this.cmbSourceColumns.Width = 87;
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            this.repositoryItemComboBox1.EditValueChanged += new System.EventHandler(this.RepositoryItemComboBox1_EditValueChanged);
            // 
            // DTableGrid
            // 
            this.DTableGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DTableGrid.Location = new System.Drawing.Point(14, 186);
            this.DTableGrid.MainView = this.DTableGridVIew;
            this.DTableGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DTableGrid.Name = "DTableGrid";
            this.DTableGrid.Size = new System.Drawing.Size(418, 262);
            this.DTableGrid.TabIndex = 208;
            this.DTableGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.DTableGridVIew});
            this.DTableGrid.DoubleClick += new System.EventHandler(this.DTableGrid_DoubleClick);
            // 
            // DTableGridVIew
            // 
            this.DTableGridVIew.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3});
            this.DTableGridVIew.DetailHeight = 458;
            this.DTableGridVIew.GridControl = this.DTableGrid;
            this.DTableGridVIew.Name = "DTableGridVIew";
            this.DTableGridVIew.OptionsView.ShowFooter = true;
            this.DTableGridVIew.OptionsView.ShowGroupPanel = false;
            this.DTableGridVIew.OptionsView.ShowIndicator = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "TableName";
            this.gridColumn3.FieldName = "TableName";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "TableName", "{0}")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 87;
            // 
            // txtDestinationUserName
            // 
            this.txtDestinationUserName.EnterMoveNextControl = true;
            this.txtDestinationUserName.Location = new System.Drawing.Point(106, 78);
            this.txtDestinationUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDestinationUserName.Name = "txtDestinationUserName";
            this.txtDestinationUserName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtDestinationUserName.Properties.MaxLength = 100;
            this.txtDestinationUserName.Size = new System.Drawing.Size(195, 24);
            this.txtDestinationUserName.TabIndex = 6;
            this.txtDestinationUserName.EditValueChanged += new System.EventHandler(this.TxtSourceServer_EditValueChanged);
            // 
            // txtDestinationDataBase
            // 
            this.txtDestinationDataBase.EnterMoveNextControl = true;
            this.txtDestinationDataBase.Location = new System.Drawing.Point(106, 146);
            this.txtDestinationDataBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDestinationDataBase.Name = "txtDestinationDataBase";
            this.txtDestinationDataBase.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtDestinationDataBase.Properties.MaxLength = 100;
            this.txtDestinationDataBase.Size = new System.Drawing.Size(195, 24);
            this.txtDestinationDataBase.TabIndex = 8;
            this.txtDestinationDataBase.EditValueChanged += new System.EventHandler(this.TxtSourceServer_EditValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(56, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 203;
            this.label1.Text = "Server";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(36, 152);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 203;
            this.label8.Text = "Database";
            // 
            // txtDestinationServer
            // 
            this.txtDestinationServer.EnterMoveNextControl = true;
            this.txtDestinationServer.Location = new System.Drawing.Point(106, 44);
            this.txtDestinationServer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDestinationServer.Name = "txtDestinationServer";
            this.txtDestinationServer.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtDestinationServer.Properties.MaxLength = 100;
            this.txtDestinationServer.Size = new System.Drawing.Size(195, 24);
            this.txtDestinationServer.TabIndex = 5;
            this.txtDestinationServer.EditValueChanged += new System.EventHandler(this.TxtSourceServer_EditValueChanged);
            // 
            // txtDestinationPassword
            // 
            this.txtDestinationPassword.EnterMoveNextControl = true;
            this.txtDestinationPassword.Location = new System.Drawing.Point(106, 112);
            this.txtDestinationPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDestinationPassword.Name = "txtDestinationPassword";
            this.txtDestinationPassword.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtDestinationPassword.Properties.MaxLength = 100;
            this.txtDestinationPassword.Properties.PasswordChar = '*';
            this.txtDestinationPassword.Size = new System.Drawing.Size(195, 24);
            this.txtDestinationPassword.TabIndex = 7;
            this.txtDestinationPassword.EditValueChanged += new System.EventHandler(this.TxtSourceServer_EditValueChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(28, 84);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 17);
            this.label6.TabIndex = 203;
            this.label6.Text = "User Name";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(35, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 203;
            this.label7.Text = "Password";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(1132, 54);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(115, 54);
            this.labelControl1.TabIndex = 212;
            this.labelControl1.Text = "Query";
            // 
            // marqueeProgressBarControl1
            // 
            this.marqueeProgressBarControl1.EditValue = 0;
            this.marqueeProgressBarControl1.Location = new System.Drawing.Point(958, 942);
            this.marqueeProgressBarControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.marqueeProgressBarControl1.Name = "marqueeProgressBarControl1";
            this.marqueeProgressBarControl1.Size = new System.Drawing.Size(435, 24);
            this.marqueeProgressBarControl1.TabIndex = 213;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Appearance.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.simpleButton3.Appearance.Options.UseFont = true;
            this.simpleButton3.Location = new System.Drawing.Point(1085, 783);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(205, 133);
            this.simpleButton3.TabIndex = 209;
            this.simpleButton3.Text = "Execute Query";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(1153, 506);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 17);
            this.label9.TabIndex = 210;
            this.label9.Text = "Source";
            // 
            // txtSourceConnection
            // 
            this.txtSourceConnection.Enabled = false;
            this.txtSourceConnection.Location = new System.Drawing.Point(958, 543);
            this.txtSourceConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSourceConnection.Name = "txtSourceConnection";
            this.txtSourceConnection.Size = new System.Drawing.Size(434, 42);
            this.txtSourceConnection.TabIndex = 214;
            this.txtSourceConnection.Text = "";
            // 
            // txtDestinationConnection
            // 
            this.txtDestinationConnection.Enabled = false;
            this.txtDestinationConnection.Location = new System.Drawing.Point(958, 639);
            this.txtDestinationConnection.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDestinationConnection.Name = "txtDestinationConnection";
            this.txtDestinationConnection.Size = new System.Drawing.Size(434, 42);
            this.txtDestinationConnection.TabIndex = 215;
            this.txtDestinationConnection.Text = "";
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(1140, 604);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 17);
            this.label10.TabIndex = 216;
            this.label10.Text = "Destination";
            // 
            // lblTotalRecordsToTransfer
            // 
            this.lblTotalRecordsToTransfer.Location = new System.Drawing.Point(969, 471);
            this.lblTotalRecordsToTransfer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotalRecordsToTransfer.Name = "lblTotalRecordsToTransfer";
            this.lblTotalRecordsToTransfer.Size = new System.Drawing.Size(81, 17);
            this.lblTotalRecordsToTransfer.TabIndex = 210;
            this.lblTotalRecordsToTransfer.Text = "Total Records";
            // 
            // frmDataTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 977);
            this.Controls.Add(this.lblTotalRecordsToTransfer);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDestinationConnection);
            this.Controls.Add(this.txtSourceConnection);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.marqueeProgressBarControl1);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Menu_ToolStrip);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDataTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmDataTransfer_Load);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SColumnGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SColumnGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STableGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STableGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSourceDataBase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSourcePassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSourceUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSourceServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DColumnGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DColumnGridVIew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTableGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DTableGridVIew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinationUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinationDataBase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinationServer.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDestinationPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.marqueeProgressBarControl1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnLoadQuery;
        private System.Windows.Forms.ToolStripButton btnLoadTables;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnSource;
        private DevExpress.XtraGrid.GridControl SColumnGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView SColumnGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.GridControl STableGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView STableGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.TextEdit txtSourceDataBase;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.TextEdit txtSourcePassword;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.TextEdit txtSourceUserName;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit txtSourceServer;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnDestination;
        private DevExpress.XtraGrid.GridControl DColumnGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView DColumnGridVIew;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn cmbSourceColumns;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraGrid.GridControl DTableGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView DTableGridVIew;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.TextEdit txtDestinationUserName;
        private DevExpress.XtraEditors.TextEdit txtDestinationDataBase;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl label8;
        private DevExpress.XtraEditors.TextEdit txtDestinationServer;
        private DevExpress.XtraEditors.TextEdit txtDestinationPassword;
        private DevExpress.XtraEditors.LabelControl label6;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.MarqueeProgressBarControl marqueeProgressBarControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.LabelControl label9;
        private System.Windows.Forms.RichTextBox txtSourceConnection;
        private System.Windows.Forms.RichTextBox txtDestinationConnection;
        private DevExpress.XtraEditors.LabelControl label10;
        private DevExpress.XtraEditors.LabelControl lblTotalRecordsToTransfer;
    }
}