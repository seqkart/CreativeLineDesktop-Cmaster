﻿namespace WindowsFormsApplication1.Forms_Transaction
{
    partial class frmAdvanceAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvanceAddEdit));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtPassword = new System.Windows.Forms.ToolStripTextBox();
            this.txtAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtType = new DevExpress.XtraEditors.TextEdit();
            this.txtEmpCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl35 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl33 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl34 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSalary = new DevExpress.XtraEditors.TextEdit();
            this.txtEmpCodeDesc = new DevExpress.XtraEditors.TextEdit();
            this.DtDate = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.DtDateforMonth = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView5 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtAdvanceNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalary.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCodeDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtDateforMonth.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtDateforMonth.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdvanceNo.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.Menu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu_ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuit,
            this.btnSave,
            this.txtPassword});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.Size = new System.Drawing.Size(549, 27);
            this.Menu_ToolStrip.TabIndex = 16;
            this.Menu_ToolStrip.Text = "toolStrip1";
            // 
            // btnQuit
            // 
            this.btnQuit.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(50, 24);
            this.btnQuit.Text = "Close";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 24);
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPassword.Size = new System.Drawing.Size(116, 27);
            this.txtPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPassword_KeyDown);
            this.txtPassword.Click += new System.EventHandler(this.txtPassword_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(96, 203);
            this.txtAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Properties.MaxLength = 6;
            this.txtAmount.Size = new System.Drawing.Size(117, 24);
            this.txtAmount.TabIndex = 11;
            this.txtAmount.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAmount_KeyDown);
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            this.txtAmount.Leave += new System.EventHandler(this.txtAmount_Leave);
            // 
            // txtType
            // 
            this.txtType.EditValue = "A";
            this.txtType.EnterMoveNextControl = true;
            this.txtType.Location = new System.Drawing.Point(96, 166);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.Name = "txtType";
            this.txtType.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtType.Properties.MaxLength = 6;
            this.txtType.Size = new System.Drawing.Size(117, 24);
            this.txtType.TabIndex = 10;
            this.txtType.Leave += new System.EventHandler(this.txtType_Leave);
            this.txtType.Validating += new System.ComponentModel.CancelEventHandler(this.txtType_Validating);
            // 
            // txtEmpCode
            // 
            this.txtEmpCode.EnterMoveNextControl = true;
            this.txtEmpCode.Location = new System.Drawing.Point(96, 129);
            this.txtEmpCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.Properties.MaxLength = 6;
            this.txtEmpCode.Size = new System.Drawing.Size(117, 24);
            this.txtEmpCode.TabIndex = 8;
            this.txtEmpCode.EditValueChanged += new System.EventHandler(this.txtEmpCode_EditValueChanged);
            this.txtEmpCode.Enter += new System.EventHandler(this.txtEmpCode_Enter);
            this.txtEmpCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEmpCode_KeyDown);
            this.txtEmpCode.Leave += new System.EventHandler(this.txtEmpCode_Leave);
            // 
            // labelControl35
            // 
            this.labelControl35.Location = new System.Drawing.Point(58, 171);
            this.labelControl35.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl35.Name = "labelControl35";
            this.labelControl35.Size = new System.Drawing.Size(28, 17);
            this.labelControl35.TabIndex = 29;
            this.labelControl35.Text = "Type";
            // 
            // labelControl33
            // 
            this.labelControl33.Location = new System.Drawing.Point(58, 98);
            this.labelControl33.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl33.Name = "labelControl33";
            this.labelControl33.Size = new System.Drawing.Size(27, 17);
            this.labelControl33.TabIndex = 30;
            this.labelControl33.Text = "Date";
            // 
            // labelControl34
            // 
            this.labelControl34.Location = new System.Drawing.Point(26, 135);
            this.labelControl34.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl34.Name = "labelControl34";
            this.labelControl34.Size = new System.Drawing.Size(61, 17);
            this.labelControl34.TabIndex = 27;
            this.labelControl34.Text = "Emp Code";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(38, 208);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(45, 17);
            this.labelControl3.TabIndex = 31;
            this.labelControl3.Text = "Amount";
            // 
            // labelControl5
            // 
            this.labelControl5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl5.Location = new System.Drawing.Point(51, 251);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(35, 17);
            this.labelControl5.TabIndex = 30;
            this.labelControl5.Text = "Salary";
            this.labelControl5.Visible = false;
            // 
            // txtSalary
            // 
            this.txtSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSalary.Enabled = false;
            this.txtSalary.EnterMoveNextControl = true;
            this.txtSalary.Location = new System.Drawing.Point(96, 243);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.Properties.MaxLength = 6;
            this.txtSalary.Size = new System.Drawing.Size(0, 24);
            this.txtSalary.TabIndex = 12;
            this.txtSalary.TabStop = false;
            this.txtSalary.Visible = false;
            this.txtSalary.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSalary_KeyPress);
            // 
            // txtEmpCodeDesc
            // 
            this.txtEmpCodeDesc.Enabled = false;
            this.txtEmpCodeDesc.Location = new System.Drawing.Point(219, 129);
            this.txtEmpCodeDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpCodeDesc.Name = "txtEmpCodeDesc";
            this.txtEmpCodeDesc.Properties.MaxLength = 6;
            this.txtEmpCodeDesc.Size = new System.Drawing.Size(300, 24);
            this.txtEmpCodeDesc.TabIndex = 9;
            this.txtEmpCodeDesc.TabStop = false;
            // 
            // DtDate
            // 
            this.DtDate.EditValue = null;
            this.DtDate.EnterMoveNextControl = true;
            this.DtDate.Location = new System.Drawing.Point(93, 93);
            this.DtDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtDate.Name = "DtDate";
            this.DtDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.DtDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DtDate.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.DtDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DtDate.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.DtDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.DtDate.Size = new System.Drawing.Size(119, 24);
            this.DtDate.TabIndex = 32;
            this.DtDate.EditValueChanged += new System.EventHandler(this.DtDate_EditValueChanged);
            this.DtDate.Validating += new System.ComponentModel.CancelEventHandler(this.DtDate_Validating);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(300, 98);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(90, 17);
            this.labelControl8.TabIndex = 30;
            this.labelControl8.Text = "Date for Month";
            // 
            // DtDateforMonth
            // 
            this.DtDateforMonth.EditValue = null;
            this.DtDateforMonth.EnterMoveNextControl = true;
            this.DtDateforMonth.Location = new System.Drawing.Point(400, 93);
            this.DtDateforMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtDateforMonth.Name = "DtDateforMonth";
            this.DtDateforMonth.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtDateforMonth.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtDateforMonth.Properties.DisplayFormat.FormatString = "MM-yyyy";
            this.DtDateforMonth.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.DtDateforMonth.Properties.EditFormat.FormatString = "MM-yyyy";
            this.DtDateforMonth.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.DtDateforMonth.Properties.Mask.EditMask = "MM-yyyy";
            this.DtDateforMonth.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.DtDateforMonth.Size = new System.Drawing.Size(119, 24);
            this.DtDateforMonth.TabIndex = 1;
            this.DtDateforMonth.Enter += new System.EventHandler(this.DtDateforMonth_Enter);
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(222, 171);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(43, 17);
            this.labelControl7.TabIndex = 30;
            this.labelControl7.Text = "A= Adv";
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(51, 53);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(456, 258);
            this.HelpGrid.TabIndex = 368;
            this.HelpGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HelpGridView,
            this.gridView4,
            this.gridView5});
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
            // gridView4
            // 
            this.gridView4.DetailHeight = 458;
            this.gridView4.GridControl = this.HelpGrid;
            this.gridView4.Name = "gridView4";
            // 
            // gridView5
            // 
            this.gridView5.DetailHeight = 458;
            this.gridView5.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridView5.GridControl = this.HelpGrid;
            this.gridView5.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.gridView5.Name = "gridView5";
            this.gridView5.OptionsBehavior.AllowIncrementalSearch = true;
            this.gridView5.OptionsBehavior.Editable = false;
            this.gridView5.OptionsView.ColumnAutoWidth = false;
            this.gridView5.OptionsView.ShowGroupPanel = false;
            this.gridView5.OptionsView.ShowIndicator = false;
            this.gridView5.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // txtAdvanceNo
            // 
            this.txtAdvanceNo.Enabled = false;
            this.txtAdvanceNo.EnterMoveNextControl = true;
            this.txtAdvanceNo.Location = new System.Drawing.Point(93, 56);
            this.txtAdvanceNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAdvanceNo.Name = "txtAdvanceNo";
            this.txtAdvanceNo.Properties.MaxLength = 6;
            this.txtAdvanceNo.Size = new System.Drawing.Size(119, 24);
            this.txtAdvanceNo.TabIndex = 369;
            this.txtAdvanceNo.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 61);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(71, 17);
            this.labelControl1.TabIndex = 370;
            this.labelControl1.Text = "Advance No";
            // 
            // frmAdvanceAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 324);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.txtAdvanceNo);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.DtDateforMonth);
            this.Controls.Add(this.DtDate);
            this.Controls.Add(this.txtSalary);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.txtEmpCode);
            this.Controls.Add(this.txtEmpCodeDesc);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl35);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.labelControl33);
            this.Controls.Add(this.labelControl34);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.Menu_ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdvanceAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmAdvanceAddEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAdvanceAddEdit_KeyDown);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSalary.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCodeDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtDateforMonth.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtDateforMonth.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdvanceNo.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripTextBox txtPassword;
        private DevExpress.XtraEditors.TextEdit txtAmount;
        private DevExpress.XtraEditors.TextEdit txtType;
        private DevExpress.XtraEditors.TextEdit txtEmpCode;
        private DevExpress.XtraEditors.LabelControl labelControl35;
        private DevExpress.XtraEditors.LabelControl labelControl33;
        private DevExpress.XtraEditors.LabelControl labelControl34;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtSalary;
        private DevExpress.XtraEditors.TextEdit txtEmpCodeDesc;
        private DevExpress.XtraEditors.DateEdit DtDate;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.DateEdit DtDateforMonth;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView5;
        private DevExpress.XtraEditors.TextEdit txtAdvanceNo;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}