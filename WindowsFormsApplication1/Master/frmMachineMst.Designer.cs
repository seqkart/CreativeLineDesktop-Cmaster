
namespace WindowsFormsApplication1.Master
{
    partial class frmMachineMst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMachineMst));
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtMachineCode = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTypeDesc = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtGauge = new DevExpress.XtraEditors.TextEdit();
            this.txtTypeCode = new DevExpress.XtraEditors.TextEdit();
            this.label19 = new DevExpress.XtraEditors.LabelControl();
            this.label22 = new DevExpress.XtraEditors.LabelControl();
            this.txtBrandDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtBrandCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMachineCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeDesc.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGauge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(84, 51);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(539, 209);
            this.HelpGrid.TabIndex = 416;
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
            // txtMachineCode
            // 
            this.txtMachineCode.Enabled = false;
            this.txtMachineCode.EnterMoveNextControl = true;
            this.txtMachineCode.Location = new System.Drawing.Point(156, 101);
            this.txtMachineCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMachineCode.Name = "txtMachineCode";
            this.txtMachineCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMachineCode.Properties.MaxLength = 8;
            this.txtMachineCode.Size = new System.Drawing.Size(86, 24);
            this.txtMachineCode.TabIndex = 399;
            this.txtMachineCode.TabStop = false;
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Appearance.Options.UseFont = true;
            this.label3.Appearance.Options.UseForeColor = true;
            this.label3.Location = new System.Drawing.Point(63, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 418;
            this.label3.Text = "Machine Code";
            // 
            // txtTypeDesc
            // 
            this.txtTypeDesc.Enabled = false;
            this.txtTypeDesc.EnterMoveNextControl = true;
            this.txtTypeDesc.Location = new System.Drawing.Point(250, 135);
            this.txtTypeDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTypeDesc.Name = "txtTypeDesc";
            this.txtTypeDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTypeDesc.Properties.MaxLength = 8;
            this.txtTypeDesc.Size = new System.Drawing.Size(385, 24);
            this.txtTypeDesc.TabIndex = 401;
            this.txtTypeDesc.TabStop = false;
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(683, 31);
            this.Menu_ToolStrip.TabIndex = 417;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.ForeColor = System.Drawing.Color.White;
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
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnSave.Size = new System.Drawing.Size(55, 28);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtGauge
            // 
            this.txtGauge.EnterMoveNextControl = true;
            this.txtGauge.Location = new System.Drawing.Point(156, 203);
            this.txtGauge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGauge.Name = "txtGauge";
            this.txtGauge.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGauge.Size = new System.Drawing.Size(478, 24);
            this.txtGauge.TabIndex = 404;
            // 
            // txtTypeCode
            // 
            this.txtTypeCode.EnterMoveNextControl = true;
            this.txtTypeCode.Location = new System.Drawing.Point(156, 135);
            this.txtTypeCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTypeCode.Name = "txtTypeCode";
            this.txtTypeCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTypeCode.Properties.MaxLength = 8;
            this.txtTypeCode.Size = new System.Drawing.Size(86, 24);
            this.txtTypeCode.TabIndex = 400;
            this.txtTypeCode.EditValueChanged += new System.EventHandler(this.txtTypeCode_EditValueChanged);
            this.txtTypeCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTypeCode_KeyDown);
            // 
            // label19
            // 
            this.label19.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Appearance.Options.UseFont = true;
            this.label19.Appearance.Options.UseForeColor = true;
            this.label19.Location = new System.Drawing.Point(111, 205);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 19);
            this.label19.TabIndex = 415;
            this.label19.Text = "Gauge";
            // 
            // label22
            // 
            this.label22.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Appearance.Options.UseFont = true;
            this.label22.Appearance.Options.UseForeColor = true;
            this.label22.Location = new System.Drawing.Point(66, 137);
            this.label22.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(85, 19);
            this.label22.TabIndex = 409;
            this.label22.Text = "Machine Type";
            // 
            // txtBrandDesc
            // 
            this.txtBrandDesc.Enabled = false;
            this.txtBrandDesc.EnterMoveNextControl = true;
            this.txtBrandDesc.Location = new System.Drawing.Point(250, 169);
            this.txtBrandDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrandDesc.Name = "txtBrandDesc";
            this.txtBrandDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBrandDesc.Properties.MaxLength = 8;
            this.txtBrandDesc.Size = new System.Drawing.Size(385, 24);
            this.txtBrandDesc.TabIndex = 422;
            this.txtBrandDesc.TabStop = false;
            // 
            // txtBrandCode
            // 
            this.txtBrandCode.EnterMoveNextControl = true;
            this.txtBrandCode.Location = new System.Drawing.Point(156, 169);
            this.txtBrandCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrandCode.Name = "txtBrandCode";
            this.txtBrandCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBrandCode.Properties.MaxLength = 8;
            this.txtBrandCode.Size = new System.Drawing.Size(86, 24);
            this.txtBrandCode.TabIndex = 421;
            this.txtBrandCode.EditValueChanged += new System.EventHandler(this.txtBrandCode_EditValueChanged);
            this.txtBrandCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBrandCode_KeyDown);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(115, 171);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 19);
            this.labelControl1.TabIndex = 423;
            this.labelControl1.Text = "Brand";
            // 
            // frmMachineMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(683, 284);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.txtBrandDesc);
            this.Controls.Add(this.txtBrandCode);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtMachineCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTypeDesc);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtGauge);
            this.Controls.Add(this.txtTypeCode);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label22);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMachineMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmMachineMst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMachineCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeDesc.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGauge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraEditors.TextEdit txtMachineCode;
        internal DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.TextEdit txtTypeDesc;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtGauge;
        private DevExpress.XtraEditors.TextEdit txtTypeCode;
        internal DevExpress.XtraEditors.LabelControl label19;
        internal DevExpress.XtraEditors.LabelControl label22;
        private DevExpress.XtraEditors.TextEdit txtBrandDesc;
        private DevExpress.XtraEditors.TextEdit txtBrandCode;
        internal DevExpress.XtraEditors.LabelControl labelControl1;
    }
}