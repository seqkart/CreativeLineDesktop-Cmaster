
namespace WindowsFormsApplication1.Master
{
    partial class FrmSubProcessMst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSubProcessMst));
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSubProcessCode = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.txtProcessName = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtProcessCode = new DevExpress.XtraEditors.TextEdit();
            this.txtSubProcessName = new DevExpress.XtraEditors.TextEdit();
            this.label19 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubProcessCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessName.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubProcessName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(33, 35);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(539, 213);
            this.HelpGrid.TabIndex = 397;
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
            // txtSubProcessCode
            // 
            this.txtSubProcessCode.Enabled = false;
            this.txtSubProcessCode.EnterMoveNextControl = true;
            this.txtSubProcessCode.Location = new System.Drawing.Point(187, 81);
            this.txtSubProcessCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubProcessCode.Name = "txtSubProcessCode";
            this.txtSubProcessCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubProcessCode.Properties.MaxLength = 8;
            this.txtSubProcessCode.Size = new System.Drawing.Size(86, 24);
            this.txtSubProcessCode.TabIndex = 394;
            this.txtSubProcessCode.TabStop = false;
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Appearance.Options.UseFont = true;
            this.label3.Appearance.Options.UseForeColor = true;
            this.label3.Location = new System.Drawing.Point(73, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 19);
            this.label3.TabIndex = 399;
            this.label3.Text = "Sub Process Code";
            // 
            // txtProcessName
            // 
            this.txtProcessName.Enabled = false;
            this.txtProcessName.EnterMoveNextControl = true;
            this.txtProcessName.Location = new System.Drawing.Point(280, 149);
            this.txtProcessName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProcessName.Properties.MaxLength = 8;
            this.txtProcessName.Size = new System.Drawing.Size(259, 24);
            this.txtProcessName.TabIndex = 396;
            this.txtProcessName.TabStop = false;
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(610, 31);
            this.Menu_ToolStrip.TabIndex = 398;
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
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
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
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtProcessCode
            // 
            this.txtProcessCode.EnterMoveNextControl = true;
            this.txtProcessCode.Location = new System.Drawing.Point(187, 149);
            this.txtProcessCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcessCode.Name = "txtProcessCode";
            this.txtProcessCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProcessCode.Properties.MaxLength = 8;
            this.txtProcessCode.Size = new System.Drawing.Size(86, 24);
            this.txtProcessCode.TabIndex = 395;
            this.txtProcessCode.EditValueChanged += new System.EventHandler(this.TxtProcessCode_EditValueChanged);
            this.txtProcessCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtProcessCode_KeyDown);
            // 
            // txtSubProcessName
            // 
            this.txtSubProcessName.EnterMoveNextControl = true;
            this.txtSubProcessName.Location = new System.Drawing.Point(187, 115);
            this.txtSubProcessName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSubProcessName.Name = "txtSubProcessName";
            this.txtSubProcessName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSubProcessName.Size = new System.Drawing.Size(352, 24);
            this.txtSubProcessName.TabIndex = 400;
            // 
            // label19
            // 
            this.label19.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Appearance.Options.UseFont = true;
            this.label19.Appearance.Options.UseForeColor = true;
            this.label19.Location = new System.Drawing.Point(71, 119);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(113, 19);
            this.label19.TabIndex = 401;
            this.label19.Text = "Sub Process Name";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(94, 153);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 19);
            this.labelControl1.TabIndex = 402;
            this.labelControl1.Text = "Under Process";
            // 
            // frmSubProcessMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(610, 258);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtSubProcessName);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.txtSubProcessCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtProcessCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSubProcessMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmSubProcessMst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubProcessCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessName.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSubProcessName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraEditors.TextEdit txtSubProcessCode;
        internal DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.TextEdit txtProcessName;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtProcessCode;
        private DevExpress.XtraEditors.TextEdit txtSubProcessName;
        internal DevExpress.XtraEditors.LabelControl label19;
        internal DevExpress.XtraEditors.LabelControl labelControl1;
    }
}