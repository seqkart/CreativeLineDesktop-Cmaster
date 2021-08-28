
namespace WindowsFormsApplication1.Transaction
{
    partial class FrmVouchers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVouchers));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSearchBox = new DevExpress.XtraEditors.TextEdit();
            this.VoucherGrid = new DevExpress.XtraGrid.GridControl();
            this.VoucherGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn27 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.txtAccountCode = new DevExpress.XtraEditors.TextEdit();
            this.txtVoucherDate = new DevExpress.XtraEditors.DateEdit();
            this.txtNarration = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.txtVoucherTypeDesc = new DevExpress.XtraEditors.TextEdit();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtVoucherTypeCode = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccountName = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.textEdit2 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNarration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherTypeDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.HelpGrid);
            this.panelControl2.Controls.Add(this.txtSearchBox);
            this.panelControl2.Location = new System.Drawing.Point(51, 214);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(452, 231);
            this.panelControl2.TabIndex = 729;
            this.panelControl2.Visible = false;
            // 
            // HelpGrid
            // 
            this.HelpGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(2, 26);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(448, 203);
            this.HelpGrid.TabIndex = 245;
            this.HelpGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HelpGridView});
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
            // txtSearchBox
            // 
            this.txtSearchBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearchBox.EnterMoveNextControl = true;
            this.txtSearchBox.Location = new System.Drawing.Point(2, 2);
            this.txtSearchBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchBox.Name = "txtSearchBox";
            this.txtSearchBox.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSearchBox.Properties.MaxLength = 400;
            this.txtSearchBox.Size = new System.Drawing.Size(448, 24);
            this.txtSearchBox.TabIndex = 246;
            this.txtSearchBox.EditValueChanged += new System.EventHandler(this.TxtSearchBox_EditValueChanged);
            this.txtSearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtSearchBox_KeyDown);
            // 
            // VoucherGrid
            // 
            this.VoucherGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VoucherGrid.Location = new System.Drawing.Point(-2, 106);
            this.VoucherGrid.MainView = this.VoucherGridView;
            this.VoucherGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.VoucherGrid.Name = "VoucherGrid";
            this.VoucherGrid.Size = new System.Drawing.Size(1043, 558);
            this.VoucherGrid.TabIndex = 730;
            this.VoucherGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.VoucherGridView});
            this.VoucherGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarCodeGrid_KeyDown);
            // 
            // VoucherGridView
            // 
            this.VoucherGridView.Appearance.FixedLine.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.VoucherGridView.Appearance.FixedLine.Options.UseFont = true;
            this.VoucherGridView.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.VoucherGridView.Appearance.FocusedCell.Options.UseBackColor = true;
            this.VoucherGridView.Appearance.FocusedRow.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.VoucherGridView.Appearance.FocusedRow.Options.UseBorderColor = true;
            this.VoucherGridView.Appearance.HeaderPanel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.VoucherGridView.Appearance.HeaderPanel.Options.UseFont = true;
            this.VoucherGridView.Appearance.HorzLine.BackColor = System.Drawing.Color.DimGray;
            this.VoucherGridView.Appearance.HorzLine.Options.UseBackColor = true;
            this.VoucherGridView.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.VoucherGridView.Appearance.SelectedRow.Options.UseBackColor = true;
            this.VoucherGridView.Appearance.TopNewRow.Options.UseBorderColor = true;
            this.VoucherGridView.Appearance.VertLine.BackColor = System.Drawing.Color.Gray;
            this.VoucherGridView.Appearance.VertLine.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.VoucherGridView.Appearance.VertLine.Options.UseBackColor = true;
            this.VoucherGridView.Appearance.VertLine.Options.UseBorderColor = true;
            this.VoucherGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn27});
            this.VoucherGridView.DetailHeight = 458;
            this.VoucherGridView.GridControl = this.VoucherGrid;
            this.VoucherGridView.Name = "VoucherGridView";
            this.VoucherGridView.OptionsBehavior.UnboundColumnExpressionEditorMode = DevExpress.XtraEditors.ExpressionEditorMode.Standard;
            this.VoucherGridView.OptionsEditForm.ShowOnF2Key = DevExpress.Utils.DefaultBoolean.False;
            this.VoucherGridView.OptionsImageLoad.AnimationType = DevExpress.Utils.ImageContentAnimationType.Slide;
            this.VoucherGridView.OptionsNavigation.AutoFocusNewRow = true;
            this.VoucherGridView.OptionsSelection.MultiSelect = true;
            this.VoucherGridView.OptionsView.EnableAppearanceEvenRow = true;
            this.VoucherGridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.VoucherGridView.OptionsView.ShowFooter = true;
            this.VoucherGridView.OptionsView.ShowGroupPanel = false;
            this.VoucherGridView.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            this.VoucherGridView.OptionsView.ShowIndicator = false;
            this.VoucherGridView.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;
            this.VoucherGridView.PaintStyleName = "Skin";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Cr/Dr";
            this.gridColumn1.MinWidth = 25;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 55;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "AccCode";
            this.gridColumn2.FieldName = "AccCode";
            this.gridColumn2.MinWidth = 25;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 94;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Particulars";
            this.gridColumn3.FieldName = "AccName";
            this.gridColumn3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn3.ImageOptions.Image")));
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 312;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Amount";
            this.gridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn6.FieldName = "Amount";
            this.gridColumn6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn6.ImageOptions.Image")));
            this.gridColumn6.MinWidth = 23;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:0.##}")});
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 3;
            this.gridColumn6.Width = 117;
            // 
            // gridColumn27
            // 
            this.gridColumn27.Caption = "Short Narration";
            this.gridColumn27.FieldName = "Narration";
            this.gridColumn27.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("gridColumn27.ImageOptions.Image")));
            this.gridColumn27.MinWidth = 25;
            this.gridColumn27.Name = "gridColumn27";
            this.gridColumn27.Visible = true;
            this.gridColumn27.VisibleIndex = 4;
            this.gridColumn27.Width = 346;
            // 
            // panelControl1
            // 
            this.panelControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.panelControl1.Controls.Add(this.txtAccountCode);
            this.panelControl1.Controls.Add(this.txtVoucherDate);
            this.panelControl1.Controls.Add(this.txtNarration);
            this.panelControl1.Controls.Add(this.label5);
            this.panelControl1.Controls.Add(this.label2);
            this.panelControl1.Controls.Add(this.txtVoucherTypeDesc);
            this.panelControl1.Controls.Add(this.textEdit1);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.txtVoucherTypeCode);
            this.panelControl1.Controls.Add(this.label1);
            this.panelControl1.Controls.Add(this.txtAccountName);
            this.panelControl1.Controls.Add(this.label6);
            this.panelControl1.Location = new System.Drawing.Point(-2, 30);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1043, 79);
            this.panelControl1.TabIndex = 731;
            // 
            // txtAccountCode
            // 
            this.txtAccountCode.Location = new System.Drawing.Point(74, 44);
            this.txtAccountCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccountCode.Name = "txtAccountCode";
            this.txtAccountCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountCode.Properties.Appearance.Options.UseFont = true;
            this.txtAccountCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAccountCode.Properties.MaxLength = 6;
            this.txtAccountCode.Size = new System.Drawing.Size(61, 26);
            this.txtAccountCode.TabIndex = 471;
            this.txtAccountCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAccountCode_KeyDown);
            // 
            // txtVoucherDate
            // 
            this.txtVoucherDate.EditValue = null;
            this.txtVoucherDate.EnterMoveNextControl = true;
            this.txtVoucherDate.Location = new System.Drawing.Point(384, 10);
            this.txtVoucherDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVoucherDate.Name = "txtVoucherDate";
            this.txtVoucherDate.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherDate.Properties.Appearance.Options.UseFont = true;
            this.txtVoucherDate.Properties.BeepOnError = false;
            this.txtVoucherDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtVoucherDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtVoucherDate.Properties.CalendarView = DevExpress.XtraEditors.Repository.CalendarView.ClassicNew;
            this.txtVoucherDate.Properties.MaskSettings.Set("useAdvancingCaret", true);
            this.txtVoucherDate.Properties.MaskSettings.Set("spinWithCarry", true);
            this.txtVoucherDate.Properties.VistaDisplayMode = DevExpress.Utils.DefaultBoolean.False;
            this.txtVoucherDate.Size = new System.Drawing.Size(132, 26);
            this.txtVoucherDate.TabIndex = 476;
            // 
            // txtNarration
            // 
            this.txtNarration.EditValue = " ";
            this.txtNarration.EnterMoveNextControl = true;
            this.txtNarration.Location = new System.Drawing.Point(622, 44);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNarration.Properties.Appearance.Options.UseFont = true;
            this.txtNarration.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNarration.Properties.MaxLength = 15;
            this.txtNarration.Size = new System.Drawing.Size(411, 26);
            this.txtNarration.TabIndex = 473;
            // 
            // label5
            // 
            this.label5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Appearance.Options.UseFont = true;
            this.label5.Location = new System.Drawing.Point(543, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 475;
            this.label5.Text = "Narration";
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Appearance.Options.UseFont = true;
            this.label2.Location = new System.Drawing.Point(347, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 20);
            this.label2.TabIndex = 468;
            this.label2.Text = "Date";
            // 
            // txtVoucherTypeDesc
            // 
            this.txtVoucherTypeDesc.Enabled = false;
            this.txtVoucherTypeDesc.Location = new System.Drawing.Point(159, 10);
            this.txtVoucherTypeDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVoucherTypeDesc.Name = "txtVoucherTypeDesc";
            this.txtVoucherTypeDesc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherTypeDesc.Properties.Appearance.Options.UseFont = true;
            this.txtVoucherTypeDesc.Size = new System.Drawing.Size(164, 26);
            this.txtVoucherTypeDesc.TabIndex = 470;
            this.txtVoucherTypeDesc.TabStop = false;
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(622, 10);
            this.textEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Size = new System.Drawing.Size(119, 26);
            this.textEdit1.TabIndex = 469;
            this.textEdit1.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(523, 13);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(87, 20);
            this.labelControl1.TabIndex = 466;
            this.labelControl1.Text = "Voucher No.";
            // 
            // txtVoucherTypeCode
            // 
            this.txtVoucherTypeCode.Location = new System.Drawing.Point(107, 10);
            this.txtVoucherTypeCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVoucherTypeCode.Name = "txtVoucherTypeCode";
            this.txtVoucherTypeCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVoucherTypeCode.Properties.Appearance.Options.UseFont = true;
            this.txtVoucherTypeCode.Size = new System.Drawing.Size(51, 26);
            this.txtVoucherTypeCode.TabIndex = 469;
            this.txtVoucherTypeCode.TabStop = false;
            this.txtVoucherTypeCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtVoucherTypeCode_KeyDown);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 466;
            this.label1.Text = "Voucher Type";
            // 
            // txtAccountName
            // 
            this.txtAccountName.EnterMoveNextControl = true;
            this.txtAccountName.Location = new System.Drawing.Point(135, 44);
            this.txtAccountName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAccountName.Properties.Appearance.Options.UseFont = true;
            this.txtAccountName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAccountName.Properties.ReadOnly = true;
            this.txtAccountName.Size = new System.Drawing.Size(381, 26);
            this.txtAccountName.TabIndex = 472;
            this.txtAccountName.TabStop = false;
            // 
            // label6
            // 
            this.label6.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Appearance.Options.UseFont = true;
            this.label6.Location = new System.Drawing.Point(13, 46);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 474;
            this.label6.Text = "Account";
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.LightBlue;
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(1040, 31);
            this.Menu_ToolStrip.TabIndex = 732;
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // textEdit2
            // 
            this.textEdit2.EditValue = " ";
            this.textEdit2.EnterMoveNextControl = true;
            this.textEdit2.Location = new System.Drawing.Point(118, 672);
            this.textEdit2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit2.Name = "textEdit2";
            this.textEdit2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textEdit2.Properties.MaxLength = 15;
            this.textEdit2.Size = new System.Drawing.Size(895, 24);
            this.textEdit2.TabIndex = 733;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(7, 674);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(105, 20);
            this.labelControl2.TabIndex = 734;
            this.labelControl2.Text = "Long Narration";
            // 
            // FrmVouchers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 708);
            this.ControlBox = false;
            this.Controls.Add(this.textEdit2);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.VoucherGrid);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "FrmVouchers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmVouchers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearchBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VoucherGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNarration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherTypeDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVoucherTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccountName.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit2.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraEditors.TextEdit txtSearchBox;
        private DevExpress.XtraGrid.GridControl VoucherGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView VoucherGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn27;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit txtNarration;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit txtVoucherTypeDesc;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtVoucherTypeCode;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtAccountName;
        private DevExpress.XtraEditors.LabelControl label6;
        private DevExpress.XtraEditors.TextEdit txtAccountCode;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit textEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        public DevExpress.XtraEditors.DateEdit txtVoucherDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
    }
}