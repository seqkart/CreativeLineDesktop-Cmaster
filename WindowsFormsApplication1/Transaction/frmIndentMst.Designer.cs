﻿namespace WindowsFormsApplication1.Transaction
{
    partial class frmIndentMst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIndentMst));
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dtInvoiceDate = new DevExpress.XtraEditors.DateEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.txtSerialNo = new DevExpress.XtraEditors.TextEdit();
            this.txtserial = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDeptName = new DevExpress.XtraEditors.TextEdit();
            this.txtProductName = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductACode = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.txtDeptCode = new DevExpress.XtraEditors.TextEdit();
            this.label30 = new DevExpress.XtraEditors.LabelControl();
            this.txtProductCode = new DevExpress.XtraEditors.TextEdit();
            this.txtProductQty = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.InfoGrid = new DevExpress.XtraGrid.GridControl();
            this.InfoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnUndo = new DevExpress.XtraEditors.SimpleButton();
            this.BtnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.BtnOK = new DevExpress.XtraEditors.SimpleButton();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserial.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeptName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductACode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeptCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductQty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(153, 167);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(652, 318);
            this.HelpGrid.TabIndex = 354;
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
            // dtInvoiceDate
            // 
            this.dtInvoiceDate.EditValue = null;
            this.dtInvoiceDate.Enabled = false;
            this.dtInvoiceDate.Location = new System.Drawing.Point(83, 56);
            this.dtInvoiceDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtInvoiceDate.Name = "dtInvoiceDate";
            this.dtInvoiceDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtInvoiceDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtInvoiceDate.Properties.Mask.EditMask = "";
            this.dtInvoiceDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtInvoiceDate.Size = new System.Drawing.Size(92, 24);
            this.dtInvoiceDate.TabIndex = 345;
            this.dtInvoiceDate.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(41, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 346;
            this.label2.Text = "Date";
            // 
            // txtSerialNo
            // 
            this.txtSerialNo.Enabled = false;
            this.txtSerialNo.Location = new System.Drawing.Point(404, 58);
            this.txtSerialNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSerialNo.Name = "txtSerialNo";
            this.txtSerialNo.Size = new System.Drawing.Size(173, 24);
            this.txtSerialNo.TabIndex = 348;
            this.txtSerialNo.TabStop = false;
            // 
            // txtserial
            // 
            this.txtserial.Enabled = false;
            this.txtserial.Location = new System.Drawing.Point(357, 58);
            this.txtserial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtserial.Name = "txtserial";
            this.txtserial.Size = new System.Drawing.Size(40, 24);
            this.txtserial.TabIndex = 347;
            this.txtserial.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(282, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 344;
            this.label1.Text = "Indent No";
            // 
            // txtDeptName
            // 
            this.txtDeptName.EnterMoveNextControl = true;
            this.txtDeptName.Location = new System.Drawing.Point(199, 92);
            this.txtDeptName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeptName.Name = "txtDeptName";
            this.txtDeptName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeptName.Properties.ReadOnly = true;
            this.txtDeptName.Size = new System.Drawing.Size(583, 24);
            this.txtDeptName.TabIndex = 349;
            this.txtDeptName.TabStop = false;
            // 
            // txtProductName
            // 
            this.txtProductName.EnterMoveNextControl = true;
            this.txtProductName.Location = new System.Drawing.Point(199, 129);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductName.Properties.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(377, 24);
            this.txtProductName.TabIndex = 351;
            this.txtProductName.TabStop = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(24, 133);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 355;
            this.label7.Text = "Product";
            // 
            // txtProductACode
            // 
            this.txtProductACode.Location = new System.Drawing.Point(82, 129);
            this.txtProductACode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductACode.Name = "txtProductACode";
            this.txtProductACode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductACode.Properties.MaxLength = 8;
            this.txtProductACode.Size = new System.Drawing.Size(91, 24);
            this.txtProductACode.TabIndex = 352;
            this.txtProductACode.EditValueChanged += new System.EventHandler(this.TxtProductACode_EditValueChanged);
            this.txtProductACode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProductACode_KeyDown);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 95);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 353;
            this.label6.Text = "Dept Code";
            // 
            // txtDeptCode
            // 
            this.txtDeptCode.Location = new System.Drawing.Point(82, 93);
            this.txtDeptCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDeptCode.Name = "txtDeptCode";
            this.txtDeptCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDeptCode.Properties.MaxLength = 6;
            this.txtDeptCode.Size = new System.Drawing.Size(91, 24);
            this.txtDeptCode.TabIndex = 350;
            this.txtDeptCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDeptCode_KeyDown);
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(588, 133);
            this.label30.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(80, 17);
            this.label30.TabIndex = 375;
            this.label30.Text = "Product Code";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(684, 129);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductCode.Properties.MaxLength = 4;
            this.txtProductCode.Properties.ReadOnly = true;
            this.txtProductCode.Size = new System.Drawing.Size(99, 24);
            this.txtProductCode.TabIndex = 374;
            // 
            // txtProductQty
            // 
            this.txtProductQty.EditValue = " ";
            this.txtProductQty.EnterMoveNextControl = true;
            this.txtProductQty.Location = new System.Drawing.Point(83, 163);
            this.txtProductQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductQty.Name = "txtProductQty";
            this.txtProductQty.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductQty.Properties.MaxLength = 15;
            this.txtProductQty.Size = new System.Drawing.Size(90, 24);
            this.txtProductQty.TabIndex = 376;
            this.txtProductQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductQty_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(47, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 17);
            this.label4.TabIndex = 377;
            this.label4.Text = "Qty";
            // 
            // txtAmount
            // 
            this.txtAmount.EditValue = " ";
            this.txtAmount.EnterMoveNextControl = true;
            this.txtAmount.Location = new System.Drawing.Point(486, 163);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAmount.Properties.MaxLength = 15;
            this.txtAmount.Size = new System.Drawing.Size(90, 24);
            this.txtAmount.TabIndex = 378;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProductQty_KeyPress);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(428, 167);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 379;
            this.label3.Text = "Amount";
            // 
            // InfoGrid
            // 
            this.InfoGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoGrid.Location = new System.Drawing.Point(14, 239);
            this.InfoGrid.MainView = this.InfoGridView;
            this.InfoGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoGrid.Name = "InfoGrid";
            this.InfoGrid.Size = new System.Drawing.Size(780, 277);
            this.InfoGrid.TabIndex = 412;
            this.InfoGrid.TabStop = false;
            this.InfoGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InfoGridView,
            this.gridView4});
            this.InfoGrid.DoubleClick += new System.EventHandler(this.InfoGrid_DoubleClick);
            // 
            // InfoGridView
            // 
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
            // gridView4
            // 
            this.gridView4.DetailHeight = 458;
            this.gridView4.GridControl = this.InfoGrid;
            this.gridView4.Name = "gridView4";
            // 
            // BtnUndo
            // 
            this.BtnUndo.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.BtnUndo.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.BtnUndo.Appearance.ForeColor = System.Drawing.Color.White;
            this.BtnUndo.Appearance.Options.UseBackColor = true;
            this.BtnUndo.Appearance.Options.UseFont = true;
            this.BtnUndo.Appearance.Options.UseForeColor = true;
            this.BtnUndo.Location = new System.Drawing.Point(327, 199);
            this.BtnUndo.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.BtnUndo.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnUndo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnUndo.Name = "BtnUndo";
            this.BtnUndo.Size = new System.Drawing.Size(99, 30);
            this.BtnUndo.TabIndex = 411;
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
            this.BtnDelete.Location = new System.Drawing.Point(476, 199);
            this.BtnDelete.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.BtnDelete.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(99, 30);
            this.BtnDelete.TabIndex = 410;
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
            this.BtnOK.Location = new System.Drawing.Point(199, 199);
            this.BtnOK.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.BtnOK.LookAndFeel.UseDefaultLookAndFeel = false;
            this.BtnOK.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(99, 30);
            this.BtnOK.TabIndex = 409;
            this.BtnOK.Text = "&Ok";
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(805, 31);
            this.Menu_ToolStrip.TabIndex = 413;
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
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // frmIndentMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 527);
            this.ControlBox = false;
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.InfoGrid);
            this.Controls.Add(this.BtnUndo);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductQty);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.dtInvoiceDate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSerialNo);
            this.Controls.Add(this.txtserial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDeptName);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtProductACode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDeptCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmIndentMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmIndentMst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtInvoiceDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSerialNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtserial.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeptName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductACode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDeptCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProductQty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.DateEdit dtInvoiceDate;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit txtSerialNo;
        private DevExpress.XtraEditors.TextEdit txtserial;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtDeptName;
        private DevExpress.XtraEditors.TextEdit txtProductName;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.TextEdit txtProductACode;
        private DevExpress.XtraEditors.LabelControl label6;
        private DevExpress.XtraEditors.TextEdit txtDeptCode;
        private DevExpress.XtraEditors.LabelControl label30;
        private DevExpress.XtraEditors.TextEdit txtProductCode;
        private DevExpress.XtraEditors.TextEdit txtProductQty;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraGrid.GridControl InfoGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView InfoGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.SimpleButton BtnUndo;
        private DevExpress.XtraEditors.SimpleButton BtnDelete;
        private DevExpress.XtraEditors.SimpleButton BtnOK;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
    }
}