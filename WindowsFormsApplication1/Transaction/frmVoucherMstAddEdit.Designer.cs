namespace WindowsFormsApplication1.Transaction
{
    partial class frmVoucherMstAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVoucherMstAddEdit));
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.InfoGrid = new DevExpress.XtraGrid.GridControl();
            this.InfoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.dtInvoiceDate = new DevExpress.XtraEditors.DateEdit();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.txtSerialNo = new DevExpress.XtraEditors.TextEdit();
            this.txtserial = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtVuDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtAccName = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccCode = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.BtnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnOK = new DevExpress.XtraEditors.SimpleButton();
            this.txtVuType = new DevExpress.XtraEditors.TextEdit();
            this.txtDrCr = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.txtNarration = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label8 = new DevExpress.XtraEditors.LabelControl();
            this.txtChqNo = new DevExpress.XtraEditors.TextEdit();
            this.txtChqDate = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVuDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVuType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDrCr.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNarration.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChqNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChqDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChqDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(56, 198);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(819, 473);
            this.HelpGrid.TabIndex = 437;
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
            // InfoGrid
            // 
            this.InfoGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoGrid.Location = new System.Drawing.Point(14, 313);
            this.InfoGrid.MainView = this.InfoGridView;
            this.InfoGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoGrid.Name = "InfoGrid";
            this.InfoGrid.Size = new System.Drawing.Size(874, 344);
            this.InfoGrid.TabIndex = 450;
            this.InfoGrid.TabStop = false;
            this.InfoGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InfoGridView,
            this.gridView4});
            this.InfoGrid.DoubleClick += new System.EventHandler(this.InfoGrid_DoubleClick);
            // 
            // InfoGridView
            // 
            this.InfoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8});
            this.InfoGridView.CustomizationFormBounds = new System.Drawing.Rectangle(580, 341, 252, 233);
            this.InfoGridView.DetailHeight = 458;
            this.InfoGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.InfoGridView.GridControl = this.InfoGrid;
            this.InfoGridView.Name = "InfoGridView";
            this.InfoGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.InfoGridView.OptionsBehavior.Editable = false;
            this.InfoGridView.OptionsPrint.PrintFooter = false;
            this.InfoGridView.OptionsPrint.PrintGroupFooter = false;
            this.InfoGridView.OptionsView.ColumnAutoWidth = false;
            this.InfoGridView.OptionsView.ShowFooter = true;
            this.InfoGridView.OptionsView.ShowGroupPanel = false;
            this.InfoGridView.OptionsView.ShowIndicator = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "AccCode";
            this.gridColumn1.FieldName = "AccCode";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "AccName";
            this.gridColumn2.FieldName = "AccName";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Narration";
            this.gridColumn3.FieldName = "Narration";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            this.gridColumn3.Width = 87;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Debit";
            this.gridColumn4.FieldName = "Debit";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 87;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Credit";
            this.gridColumn5.FieldName = "Credit";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            this.gridColumn5.Width = 87;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "CrDr";
            this.gridColumn6.FieldName = "CrDr";
            this.gridColumn6.MinWidth = 23;
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 5;
            this.gridColumn6.Width = 87;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "VutChequeNo";
            this.gridColumn7.FieldName = "VutChequeNo";
            this.gridColumn7.MinWidth = 23;
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 6;
            this.gridColumn7.Width = 87;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "VutChequeDate";
            this.gridColumn8.FieldName = "VutChequeDate";
            this.gridColumn8.MinWidth = 23;
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 7;
            this.gridColumn8.Width = 87;
            // 
            // gridView4
            // 
            this.gridView4.DetailHeight = 458;
            this.gridView4.GridControl = this.InfoGrid;
            this.gridView4.Name = "gridView4";
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(903, 31);
            this.Menu_ToolStrip.TabIndex = 435;
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
            // dtInvoiceDate
            // 
            this.dtInvoiceDate.EditValue = null;
            this.dtInvoiceDate.Location = new System.Drawing.Point(128, 61);
            this.dtInvoiceDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtInvoiceDate.Name = "dtInvoiceDate";
            this.dtInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtInvoiceDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dtInvoiceDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtInvoiceDate.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.dtInvoiceDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtInvoiceDate.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.dtInvoiceDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtInvoiceDate.Size = new System.Drawing.Size(92, 24);
            this.dtInvoiceDate.TabIndex = 419;
            this.dtInvoiceDate.TabStop = false;
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = " ";
            this.txtAmount.EnterMoveNextControl = true;
            this.txtAmount.Location = new System.Drawing.Point(128, 169);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAmount.Properties.MaxLength = 15;
            this.txtAmount.Size = new System.Drawing.Size(90, 24);
            this.txtAmount.TabIndex = 427;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(91, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 420;
            this.label2.Text = "Date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(65, 173);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 438;
            this.label4.Text = "Amount";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Enabled = false;
            this.txtSerialNo.Location = new System.Drawing.Point(677, 63);
            this.txtSerialNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(173, 24);
            this.txtSerialNo.TabIndex = 422;
            this.txtSerialNo.TabStop = false;
            // 
            // txtserial
            // 
            this.txtserial.Enabled = false;
            this.txtserial.Location = new System.Drawing.Point(630, 63);
            this.txtserial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtserial.Name = "txtserial";
            this.txtserial.Size = new System.Drawing.Size(40, 24);
            this.txtserial.TabIndex = 421;
            this.txtserial.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(555, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 418;
            this.label1.Text = "CCI No";
            // 
            // txtVuDesc
            // 
            this.txtVuDesc.EnterMoveNextControl = true;
            this.txtVuDesc.Location = new System.Drawing.Point(245, 97);
            this.txtVuDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVuDesc.Name = "txtVuDesc";
            this.txtVuDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVuDesc.Properties.ReadOnly = true;
            this.txtVuDesc.Size = new System.Drawing.Size(605, 24);
            this.txtVuDesc.TabIndex = 424;
            this.txtVuDesc.TabStop = false;
            // 
            // txtAccName
            // 
            this.txtAccName.EnterMoveNextControl = true;
            this.txtAccName.Location = new System.Drawing.Point(245, 135);
            this.txtAccName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAccName.Properties.ReadOnly = true;
            this.txtAccName.Size = new System.Drawing.Size(607, 24);
            this.txtAccName.TabIndex = 425;
            this.txtAccName.TabStop = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(70, 139);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 17);
            this.label7.TabIndex = 439;
            this.label7.Text = "Account";
            // 
            // txtAccCode
            // 
            this.txtAccCode.Location = new System.Drawing.Point(127, 135);
            this.txtAccCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccCode.Name = "txtAccCode";
            this.txtAccCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAccCode.Properties.MaxLength = 8;
            this.txtAccCode.Size = new System.Drawing.Size(91, 24);
            this.txtAccCode.TabIndex = 426;
            this.txtAccCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAccCode_KeyDown);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(71, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 436;
            this.label6.Text = "Vu Type";
            // 
            // BtnUndo
            // 
            this.BtnUndo.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnUndo.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnUndo.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnUndo.Appearance.Options.UseBackColor = true;
            this.BtnUndo.Appearance.Options.UseFont = true;
            this.BtnUndo.Appearance.Options.UseForeColor = true;
            this.BtnUndo.Location = new System.Drawing.Point(647, 248);
            this.BtnUndo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.BtnUndo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnUndo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(99, 30);
            this.BtnUndo.TabIndex = 432;
            this.BtnUndo.Text = "&Undo";
            this.BtnUndo.Click += new System.EventHandler(this.BtnUndo_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnDelete.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnDelete.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Appearance.Options.UseBackColor = true;
            this.BtnDelete.Appearance.Options.UseFont = true;
            this.BtnDelete.Appearance.Options.UseForeColor = true;
            this.BtnDelete.Location = new System.Drawing.Point(754, 248);
            this.BtnDelete.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.BtnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(99, 30);
            this.BtnDelete.TabIndex = 436;
            this.BtnDelete.Text = "De&lete";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnOK
            // 
            this.BtnOK.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnOK.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnOK.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnOK.Appearance.Options.UseBackColor = true;
            this.BtnOK.Appearance.Options.UseFont = true;
            this.BtnOK.Appearance.Options.UseForeColor = true;
            this.BtnOK.Location = new System.Drawing.Point(533, 248);
            this.BtnOK.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.BtnOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(99, 30);
            this.BtnOK.TabIndex = 432;
            this.BtnOK.Text = "&Ok";
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // txtVuType
            // 
            this.txtVuType.Location = new System.Drawing.Point(127, 98);
            this.txtVuType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtVuType.Name = "txtVuType";
            this.txtVuType.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtVuType.Properties.MaxLength = 6;
            this.txtVuType.Size = new System.Drawing.Size(91, 24);
            this.txtVuType.TabIndex = 423;
            this.txtVuType.EditValueChanged += new System.EventHandler(this.txtVuType_EditValueChanged);
            this.txtVuType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVuType_KeyDown);
            // 
            // txtDrCr
            // 
            this.txtDrCr.EditValue = " ";
            this.txtDrCr.EnterMoveNextControl = true;
            this.txtDrCr.Location = new System.Drawing.Point(306, 169);
            this.txtDrCr.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDrCr.Name = "txtDrCr";
            this.txtDrCr.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDrCr.Properties.MaxLength = 15;
            this.txtDrCr.Size = new System.Drawing.Size(90, 24);
            this.txtDrCr.TabIndex = 428;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(243, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 17);
            this.label3.TabIndex = 453;
            this.label3.Text = "DR/CR";
            // 
            // txtNarration
            // 
            this.txtNarration.EditValue = " ";
            this.txtNarration.EnterMoveNextControl = true;
            this.txtNarration.Location = new System.Drawing.Point(131, 203);
            this.txtNarration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNarration.Name = "txtNarration";
            this.txtNarration.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNarration.Properties.MaxLength = 15;
            this.txtNarration.Size = new System.Drawing.Size(721, 24);
            this.txtNarration.TabIndex = 431;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(68, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 455;
            this.label5.Text = "Narration";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(555, 173);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 456;
            this.label8.Text = "Chq Info";
            // 
            // txtChqNo
            // 
            this.txtChqNo.EditValue = " ";
            this.txtChqNo.EnterMoveNextControl = true;
            this.txtChqNo.Location = new System.Drawing.Point(630, 169);
            this.txtChqNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChqNo.Name = "txtChqNo";
            this.txtChqNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtChqNo.Properties.MaxLength = 15;
            this.txtChqNo.Size = new System.Drawing.Size(90, 24);
            this.txtChqNo.TabIndex = 429;
            // 
            // txtChqDate
            // 
            this.txtChqDate.EditValue = null;
            this.txtChqDate.EnterMoveNextControl = true;
            this.txtChqDate.Location = new System.Drawing.Point(727, 169);
            this.txtChqDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtChqDate.Name = "txtChqDate";
            this.txtChqDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtChqDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtChqDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.txtChqDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtChqDate.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.txtChqDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtChqDate.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.txtChqDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtChqDate.Size = new System.Drawing.Size(124, 24);
            this.txtChqDate.TabIndex = 430;
            // 
            // frmVoucherMstAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(903, 675);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.txtChqDate);
            this.Controls.Add(this.txtChqNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNarration);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDrCr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InfoGrid);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.dtInvoiceDate);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.txtserial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVuDesc);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAccCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.BtnUndo);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.txtVuType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmVoucherMstAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmVoucherMstAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVuDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtVuType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDrCr.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNarration.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChqNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChqDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtChqDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl InfoGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView InfoGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.DateEdit dtInvoiceDate;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.TextEdit txtSerialNo;
        private DevExpress.XtraEditors.TextEdit txtserial;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtVuDesc;
        private DevExpress.XtraEditors.TextEdit txtAccName;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.TextEdit txtAccCode;
        private DevExpress.XtraEditors.LabelControl label6;
        private DevExpress.XtraEditors.SimpleButton BtnUndo;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnOK;
        private DevExpress.XtraEditors.TextEdit txtVuType;
        private DevExpress.XtraEditors.TextEdit txtDrCr;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.TextEdit txtNarration;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label8;
        private DevExpress.XtraEditors.TextEdit txtChqNo;
        private DevExpress.XtraEditors.DateEdit txtChqDate;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;

    }
}