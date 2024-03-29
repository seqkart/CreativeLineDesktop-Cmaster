﻿namespace WindowsFormsApplication1.Transaction
{
    partial class frmLoanMstAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoanMstAddEdit));
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtEmpCode = new DevExpress.XtraEditors.TextEdit();
            this.txtEmpName = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoanAmount = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoanInstlmnt = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtLoanNo = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new DevExpress.XtraEditors.LabelControl();
            this.txtLoanDate = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanInstlmnt.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanDate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(39, 35);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(477, 150);
            this.HelpGrid.TabIndex = 256;
            this.HelpGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HelpGridView});
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
            // txtEmpCode
            // 
            this.txtEmpCode.EnterMoveNextControl = true;
            this.txtEmpCode.Location = new System.Drawing.Point(90, 74);
            this.txtEmpCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpCode.Name = "txtEmpCode";
            this.txtEmpCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpCode.Properties.MaxLength = 6;
            this.txtEmpCode.Size = new System.Drawing.Size(75, 22);
            this.txtEmpCode.TabIndex = 1;
            this.txtEmpCode.EditValueChanged += new System.EventHandler(this.TxtEmpCode_EditValueChanged);
            this.txtEmpCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtEmpCode_KeyDown);
            // 
            // txtEmpName
            // 
            this.txtEmpName.Enabled = false;
            this.txtEmpName.Location = new System.Drawing.Point(171, 74);
            this.txtEmpName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmpName.Name = "txtEmpName";
            this.txtEmpName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmpName.Properties.ReadOnly = true;
            this.txtEmpName.Size = new System.Drawing.Size(342, 22);
            this.txtEmpName.TabIndex = 2;
            this.txtEmpName.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 253;
            this.label2.Text = "EmpName";
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.EnterMoveNextControl = true;
            this.txtLoanAmount.Location = new System.Drawing.Point(90, 113);
            this.txtLoanAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLoanAmount.Properties.MaxLength = 30;
            this.txtLoanAmount.Size = new System.Drawing.Size(75, 22);
            this.txtLoanAmount.TabIndex = 5;
            this.txtLoanAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLoanAmount_KeyPress);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(23, 115);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 259;
            this.label4.Text = "LoanAmt";
            // 
            // txtLoanInstlmnt
            // 
            this.txtLoanInstlmnt.EnterMoveNextControl = true;
            this.txtLoanInstlmnt.Location = new System.Drawing.Point(434, 111);
            this.txtLoanInstlmnt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoanInstlmnt.Name = "txtLoanInstlmnt";
            this.txtLoanInstlmnt.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLoanInstlmnt.Properties.MaxLength = 30;
            this.txtLoanInstlmnt.Size = new System.Drawing.Size(79, 22);
            this.txtLoanInstlmnt.TabIndex = 7;
            this.txtLoanInstlmnt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtLoanInstlmnt_KeyPress);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(343, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 263;
            this.label1.Text = "Loan Instlmnt";
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(528, 31);
            this.Menu_ToolStrip.TabIndex = 269;
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
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnSave.Size = new System.Drawing.Size(55, 28);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtLoanNo
            // 
            this.txtLoanNo.Enabled = false;
            this.txtLoanNo.Location = new System.Drawing.Point(434, 40);
            this.txtLoanNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoanNo.Name = "txtLoanNo";
            this.txtLoanNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLoanNo.Properties.MaxLength = 30;
            this.txtLoanNo.Size = new System.Drawing.Size(79, 22);
            this.txtLoanNo.TabIndex = 272;
            this.txtLoanNo.TabStop = false;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(373, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 16);
            this.label10.TabIndex = 273;
            this.label10.Text = "Loan No";
            // 
            // txtLoanDate
            // 
            this.txtLoanDate.Enabled = false;
            this.txtLoanDate.EnterMoveNextControl = true;
            this.txtLoanDate.Location = new System.Drawing.Point(90, 40);
            this.txtLoanDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLoanDate.Name = "txtLoanDate";
            this.txtLoanDate.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLoanDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.txtLoanDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtLoanDate.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.txtLoanDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtLoanDate.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.txtLoanDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTime;
            this.txtLoanDate.Properties.MaxLength = 30;
            this.txtLoanDate.Size = new System.Drawing.Size(75, 22);
            this.txtLoanDate.TabIndex = 274;
            this.txtLoanDate.TabStop = false;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(15, 43);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 16);
            this.label11.TabIndex = 275;
            this.label11.Text = "Loan Date";
            // 
            // frmLoanMstAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(528, 197);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.txtLoanDate);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtLoanNo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtLoanInstlmnt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmpCode);
            this.Controls.Add(this.txtEmpName);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLoanMstAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmLoanMstAddEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmpName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanInstlmnt.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoanDate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraEditors.TextEdit txtEmpCode;
        private DevExpress.XtraEditors.TextEdit txtEmpName;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit txtLoanAmount;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.TextEdit txtLoanInstlmnt;
        private DevExpress.XtraEditors.LabelControl label1;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtLoanNo;
        private DevExpress.XtraEditors.LabelControl label10;
        private DevExpress.XtraEditors.TextEdit txtLoanDate;
        private DevExpress.XtraEditors.LabelControl label11;
    }
}