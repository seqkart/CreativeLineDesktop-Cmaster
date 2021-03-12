
namespace WindowsFormsApplication1.Transaction
{
    partial class FrmProcessWiseRateFeeding
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProcessWiseRateFeeding));
            this.lblContrator = new DevExpress.XtraEditors.LabelControl();
            this.txtContractorDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtContractorCode = new DevExpress.XtraEditors.TextEdit();
            this.chContratcor = new DevExpress.XtraEditors.CheckEdit();
            this.chWorker = new DevExpress.XtraEditors.CheckEdit();
            this.lblWorker = new DevExpress.XtraEditors.LabelControl();
            this.txtWorkerName = new DevExpress.XtraEditors.TextEdit();
            this.txtWorkerCode = new DevExpress.XtraEditors.TextEdit();
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.InforGrid = new DevExpress.XtraGrid.GridControl();
            this.InforGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractorDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractorCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chContratcor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chWorker.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InforGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InforGridView)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblContrator
            // 
            this.lblContrator.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblContrator.Appearance.Options.UseFont = true;
            this.lblContrator.Location = new System.Drawing.Point(61, 84);
            this.lblContrator.Name = "lblContrator";
            this.lblContrator.Size = new System.Drawing.Size(54, 13);
            this.lblContrator.TabIndex = 721;
            this.lblContrator.Text = "Contractor";
            this.lblContrator.Click += new System.EventHandler(this.lblContrator_Click);
            // 
            // txtContractorDesc
            // 
            this.txtContractorDesc.Enabled = false;
            this.txtContractorDesc.EnterMoveNextControl = true;
            this.txtContractorDesc.Location = new System.Drawing.Point(201, 81);
            this.txtContractorDesc.Name = "txtContractorDesc";
            this.txtContractorDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContractorDesc.Properties.MaxLength = 8;
            this.txtContractorDesc.Size = new System.Drawing.Size(330, 20);
            this.txtContractorDesc.TabIndex = 723;
            this.txtContractorDesc.TabStop = false;
            // 
            // txtContractorCode
            // 
            this.txtContractorCode.EnterMoveNextControl = true;
            this.txtContractorCode.Location = new System.Drawing.Point(121, 81);
            this.txtContractorCode.Name = "txtContractorCode";
            this.txtContractorCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContractorCode.Properties.MaxLength = 8;
            this.txtContractorCode.Size = new System.Drawing.Size(74, 20);
            this.txtContractorCode.TabIndex = 722;
            this.txtContractorCode.EditValueChanged += new System.EventHandler(this.TxtContractorCode_EditValueChanged);
            this.txtContractorCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtContractorCode_KeyDown);
            // 
            // chContratcor
            // 
            this.chContratcor.Location = new System.Drawing.Point(110, 45);
            this.chContratcor.Name = "chContratcor";
            this.chContratcor.Properties.Caption = "Contratcot Wise";
            this.chContratcor.Size = new System.Drawing.Size(114, 19);
            this.chContratcor.TabIndex = 724;
            this.chContratcor.CheckedChanged += new System.EventHandler(this.ChContratcor_CheckedChanged);
            // 
            // chWorker
            // 
            this.chWorker.Location = new System.Drawing.Point(230, 45);
            this.chWorker.Name = "chWorker";
            this.chWorker.Properties.Caption = "Worker Wise";
            this.chWorker.Size = new System.Drawing.Size(114, 19);
            this.chWorker.TabIndex = 725;
            this.chWorker.CheckedChanged += new System.EventHandler(this.ChWorker_CheckedChanged);
            // 
            // lblWorker
            // 
            this.lblWorker.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblWorker.Appearance.Options.UseFont = true;
            this.lblWorker.Location = new System.Drawing.Point(61, 110);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(38, 13);
            this.lblWorker.TabIndex = 726;
            this.lblWorker.Text = "Worker";
            // 
            // txtWorkerName
            // 
            this.txtWorkerName.Enabled = false;
            this.txtWorkerName.EnterMoveNextControl = true;
            this.txtWorkerName.Location = new System.Drawing.Point(201, 107);
            this.txtWorkerName.Name = "txtWorkerName";
            this.txtWorkerName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWorkerName.Properties.MaxLength = 8;
            this.txtWorkerName.Size = new System.Drawing.Size(330, 20);
            this.txtWorkerName.TabIndex = 728;
            this.txtWorkerName.TabStop = false;
            // 
            // txtWorkerCode
            // 
            this.txtWorkerCode.EnterMoveNextControl = true;
            this.txtWorkerCode.Location = new System.Drawing.Point(121, 107);
            this.txtWorkerCode.Name = "txtWorkerCode";
            this.txtWorkerCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtWorkerCode.Properties.MaxLength = 8;
            this.txtWorkerCode.Size = new System.Drawing.Size(74, 20);
            this.txtWorkerCode.TabIndex = 727;
            this.txtWorkerCode.EditValueChanged += new System.EventHandler(this.TxtWorkerCode_EditValueChanged);
            this.txtWorkerCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtWorkerCode_KeyDown);
            // 
            // HelpGrid
            // 
            this.HelpGrid.Location = new System.Drawing.Point(190, 38);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(506, 246);
            this.HelpGrid.TabIndex = 745;
            this.HelpGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HelpGridView});
            this.HelpGrid.Visible = false;
            this.HelpGrid.DoubleClick += new System.EventHandler(this.HelpGrid_DoubleClick);
            this.HelpGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HelpGrid_KeyDown);
            // 
            // HelpGridView
            // 
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
            // InforGrid
            // 
            this.InforGrid.Location = new System.Drawing.Point(12, 133);
            this.InforGrid.MainView = this.InforGridView;
            this.InforGrid.Name = "InforGrid";
            this.InforGrid.Size = new System.Drawing.Size(672, 248);
            this.InforGrid.TabIndex = 746;
            this.InforGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InforGridView});
            // 
            // InforGridView
            // 
            this.InforGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.InforGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.InforGridView.GridControl = this.InforGrid;
            this.InforGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.InforGridView.Name = "InforGridView";
            this.InforGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.InforGridView.OptionsView.ShowGroupPanel = false;
            this.InforGridView.OptionsView.ShowIndicator = false;
            this.InforGridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "ProcessName";
            this.gridColumn1.FieldName = "ProcessName";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "SubProcessCode";
            this.gridColumn2.FieldName = "SubProcessCode";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "SubProcessName";
            this.gridColumn3.FieldName = "SubProcessName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "ProcessRate";
            this.gridColumn4.DisplayFormat.FormatString = "n2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "ProcessRate";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.Menu_ToolStrip.CanOverflow = false;
            this.Menu_ToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuit,
            this.btnSave});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(696, 26);
            this.Menu_ToolStrip.TabIndex = 747;
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
            this.btnQuit.Size = new System.Drawing.Size(45, 23);
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
            this.btnSave.Size = new System.Drawing.Size(48, 23);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmProcessWiseRateFeeding
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 393);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.InforGrid);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.txtWorkerName);
            this.Controls.Add(this.txtWorkerCode);
            this.Controls.Add(this.chWorker);
            this.Controls.Add(this.chContratcor);
            this.Controls.Add(this.lblContrator);
            this.Controls.Add(this.txtContractorDesc);
            this.Controls.Add(this.txtContractorCode);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmProcessWiseRateFeeding";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmProcessWiseRateFeeding_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtContractorDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContractorCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chContratcor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chWorker.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtWorkerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InforGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InforGridView)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal DevExpress.XtraEditors.LabelControl lblContrator;
        private DevExpress.XtraEditors.TextEdit txtContractorDesc;
        private DevExpress.XtraEditors.TextEdit txtContractorCode;
        private DevExpress.XtraEditors.CheckEdit chContratcor;
        private DevExpress.XtraEditors.CheckEdit chWorker;
        internal DevExpress.XtraEditors.LabelControl lblWorker;
        private DevExpress.XtraEditors.TextEdit txtWorkerName;
        private DevExpress.XtraEditors.TextEdit txtWorkerCode;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraGrid.GridControl InforGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView InforGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
    }
}