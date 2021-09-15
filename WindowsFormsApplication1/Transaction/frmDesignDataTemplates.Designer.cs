namespace WindowsFormsApplication1.Transaction
{
    partial class frmDesignDataTemplates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDesignDataTemplates));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnLoadExcel = new DevExpress.XtraEditors.SimpleButton();
            this.DColumnGrid = new DevExpress.XtraGrid.GridControl();
            this.DColumnGridVIew = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cmbSourceColumns = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.SColumnGrid = new DevExpress.XtraGrid.GridControl();
            this.SColumnGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STableGrid = new DevExpress.XtraGrid.GridControl();
            this.STableGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDebitPartyName = new DevExpress.XtraEditors.TextEdit();
            this.txtDebitPartyCode = new DevExpress.XtraEditors.TextEdit();
            this.txtDocType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtTemplateName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DColumnGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DColumnGridVIew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SColumnGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SColumnGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STableGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.STableGridView)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitPartyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitPartyCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTemplateName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl2.CaptionImageOptions.SvgImage")));
            this.groupControl2.Controls.Add(this.btnLoadExcel);
            this.groupControl2.Controls.Add(this.DColumnGrid);
            this.groupControl2.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl2.Location = new System.Drawing.Point(484, 141);
            this.groupControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(448, 641);
            this.groupControl2.TabIndex = 213;
            // 
            // btnLoadExcel
            // 
            this.btnLoadExcel.Location = new System.Drawing.Point(329, 29);
            this.btnLoadExcel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLoadExcel.Name = "btnLoadExcel";
            this.btnLoadExcel.Size = new System.Drawing.Size(113, 42);
            this.btnLoadExcel.TabIndex = 209;
            this.btnLoadExcel.Text = "Load Excel";
            this.btnLoadExcel.Click += new System.EventHandler(this.btnLoadExcel_Click);
            // 
            // DColumnGrid
            // 
            this.DColumnGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DColumnGrid.Location = new System.Drawing.Point(6, 82);
            this.DColumnGrid.MainView = this.DColumnGridVIew;
            this.DColumnGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DColumnGrid.Name = "DColumnGrid";
            this.DColumnGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.DColumnGrid.Size = new System.Drawing.Size(436, 535);
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
            this.DColumnGridVIew.OptionsBehavior.AllowIncrementalSearch = true;
            this.DColumnGridVIew.OptionsView.ShowGroupPanel = false;
            this.DColumnGridVIew.OptionsView.ShowIndicator = false;
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
            // 
            // groupControl1
            // 
            this.groupControl1.CaptionImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("groupControl1.CaptionImageOptions.SvgImage")));
            this.groupControl1.Controls.Add(this.SColumnGrid);
            this.groupControl1.Controls.Add(this.STableGrid);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(28, 154);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(449, 628);
            this.groupControl1.TabIndex = 212;
            this.groupControl1.Text = "Source Db";
            // 
            // SColumnGrid
            // 
            this.SColumnGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SColumnGrid.Location = new System.Drawing.Point(14, 289);
            this.SColumnGrid.MainView = this.SColumnGridView;
            this.SColumnGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SColumnGrid.Name = "SColumnGrid";
            this.SColumnGrid.Size = new System.Drawing.Size(429, 328);
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
            this.SColumnGridView.OptionsBehavior.AllowIncrementalSearch = true;
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
            this.STableGrid.Location = new System.Drawing.Point(14, 78);
            this.STableGrid.MainView = this.STableGridView;
            this.STableGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.STableGrid.Name = "STableGrid";
            this.STableGrid.Size = new System.Drawing.Size(429, 203);
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
            this.STableGridView.OptionsBehavior.AllowIncrementalSearch = true;
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(946, 27);
            this.Menu_ToolStrip.TabIndex = 214;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(43, 24);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(33, 55);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 17);
            this.labelControl4.TabIndex = 537;
            this.labelControl4.Text = "Party Name";
            // 
            // txtDebitPartyName
            // 
            this.txtDebitPartyName.Enabled = false;
            this.txtDebitPartyName.EnterMoveNextControl = true;
            this.txtDebitPartyName.Location = new System.Drawing.Point(194, 52);
            this.txtDebitPartyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDebitPartyName.Name = "txtDebitPartyName";
            this.txtDebitPartyName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDebitPartyName.Properties.ReadOnly = true;
            this.txtDebitPartyName.Size = new System.Drawing.Size(444, 24);
            this.txtDebitPartyName.TabIndex = 535;
            this.txtDebitPartyName.TabStop = false;
            // 
            // txtDebitPartyCode
            // 
            this.txtDebitPartyCode.Location = new System.Drawing.Point(104, 52);
            this.txtDebitPartyCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDebitPartyCode.Name = "txtDebitPartyCode";
            this.txtDebitPartyCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDebitPartyCode.Properties.MaxLength = 6;
            this.txtDebitPartyCode.Size = new System.Drawing.Size(85, 24);
            this.txtDebitPartyCode.TabIndex = 536;
            this.txtDebitPartyCode.EditValueChanged += new System.EventHandler(this.txtDebitPartyCode_EditValueChanged);
            this.txtDebitPartyCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDebitPartyCode_KeyDown);
            this.txtDebitPartyCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDebitPartyCode_KeyPress);
            // 
            // txtDocType
            // 
            this.txtDocType.Location = new System.Drawing.Point(744, 52);
            this.txtDocType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDocType.Name = "txtDocType";
            this.txtDocType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDocType.Properties.Items.AddRange(new object[] {
            "Sale",
            "Purchase"});
            this.txtDocType.Size = new System.Drawing.Size(117, 24);
            this.txtDocType.TabIndex = 538;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(645, 55);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(91, 17);
            this.labelControl1.TabIndex = 539;
            this.labelControl1.Text = "Document Type";
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(269, 55);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(572, 268);
            this.HelpGrid.TabIndex = 540;
            this.HelpGrid.TabStop = false;
            this.HelpGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HelpGridView,
            this.gridView1});
            this.HelpGrid.Visible = false;
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
            // gridView1
            // 
            this.gridView1.DetailHeight = 458;
            this.gridView1.GridControl = this.HelpGrid;
            this.gridView1.Name = "gridView1";
            // 
            // txtTemplateName
            // 
            this.txtTemplateName.Location = new System.Drawing.Point(104, 86);
            this.txtTemplateName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTemplateName.Name = "txtTemplateName";
            this.txtTemplateName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTemplateName.Properties.MaxLength = 100;
            this.txtTemplateName.Size = new System.Drawing.Size(534, 24);
            this.txtTemplateName.TabIndex = 541;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 90);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(89, 17);
            this.labelControl2.TabIndex = 542;
            this.labelControl2.Text = "TemplateName";
            // 
            // frmDesignDataTemplates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(946, 867);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTemplateName);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtDocType);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtDebitPartyName);
            this.Controls.Add(this.txtDebitPartyCode);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDesignDataTemplates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmDesignDataTemplates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DColumnGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DColumnGridVIew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SColumnGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SColumnGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STableGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.STableGridView)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitPartyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitPartyCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDocType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTemplateName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnLoadExcel;
        private DevExpress.XtraGrid.GridControl DColumnGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView DColumnGridVIew;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn cmbSourceColumns;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl SColumnGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView SColumnGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.GridControl STableGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView STableGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDebitPartyName;
        private DevExpress.XtraEditors.TextEdit txtDebitPartyCode;
        private DevExpress.XtraEditors.ComboBoxEdit txtDocType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit txtTemplateName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}