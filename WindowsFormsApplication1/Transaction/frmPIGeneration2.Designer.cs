﻿namespace WindowsFormsApplication1.Transaction
{
    partial class frmPIGeneration2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPIGeneration2));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.InfoGrid = new DevExpress.XtraGrid.GridControl();
            this.InfoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label15 = new DevExpress.XtraEditors.LabelControl();
            this.txtPINo = new DevExpress.XtraEditors.TextEdit();
            this.txtStoreCode = new DevExpress.XtraEditors.TextEdit();
            this.txtPIDate = new DevExpress.XtraEditors.DateEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtAddress = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPINo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPIDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPIDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
            this.Menu_ToolStrip.CanOverflow = false;
            this.Menu_ToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuit,
            this.btnLoad,
            this.btnSave});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(738, 26);
            this.Menu_ToolStrip.TabIndex = 437;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnQuit.Size = new System.Drawing.Size(45, 23);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(69, 23);
            this.btnLoad.Text = "Load Excel";
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(38, 23);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 13);
            this.label4.TabIndex = 448;
            this.label4.Text = "PI Date";
            // 
            // InfoGrid
            // 
            this.InfoGrid.Location = new System.Drawing.Point(12, 114);
            this.InfoGrid.MainView = this.InfoGridView;
            this.InfoGrid.Name = "InfoGrid";
            this.InfoGrid.Size = new System.Drawing.Size(714, 352);
            this.InfoGrid.TabIndex = 445;
            this.InfoGrid.TabStop = false;
            this.InfoGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InfoGridView,
            this.gridView4});
            // 
            // InfoGridView
            // 
            this.InfoGridView.CustomizationFormBounds = new System.Drawing.Rectangle(580, 341, 216, 178);
            this.InfoGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.InfoGridView.GridControl = this.InfoGrid;
            this.InfoGridView.Name = "InfoGridView";
            this.InfoGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.InfoGridView.OptionsPrint.PrintFooter = false;
            this.InfoGridView.OptionsPrint.PrintGroupFooter = false;
            this.InfoGridView.OptionsView.ShowFooter = true;
            this.InfoGridView.OptionsView.ShowGroupPanel = false;
            this.InfoGridView.OptionsView.ShowIndicator = false;
            this.InfoGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.InfoGridView_ValidateRow);
            this.InfoGridView.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.InfoGridView_ValidatingEditor);
            // 
            // gridView4
            // 
            this.gridView4.GridControl = this.InfoGrid;
            this.gridView4.Name = "gridView4";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(148, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 446;
            this.label5.Text = "PI No";
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(29, 75);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(27, 13);
            this.label15.TabIndex = 451;
            this.label15.Text = "Store";
            // 
            // txtPINo
            // 
            this.txtPINo.Enabled = false;
            this.txtPINo.Location = new System.Drawing.Point(178, 45);
            this.txtPINo.Name = "txtPINo";
            this.txtPINo.Size = new System.Drawing.Size(148, 20);
            this.txtPINo.TabIndex = 449;
            this.txtPINo.TabStop = false;
            // 
            // txtStoreCode
            // 
            this.txtStoreCode.Location = new System.Drawing.Point(62, 71);
            this.txtStoreCode.Name = "txtStoreCode";
            this.txtStoreCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStoreCode.Properties.MaxLength = 6;
            this.txtStoreCode.Size = new System.Drawing.Size(79, 20);
            this.txtStoreCode.TabIndex = 444;
            // 
            // txtPIDate
            // 
            this.txtPIDate.EditValue = null;
            this.txtPIDate.Enabled = false;
            this.txtPIDate.Location = new System.Drawing.Point(62, 45);
            this.txtPIDate.Name = "txtPIDate";
            this.txtPIDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPIDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtPIDate.Properties.MaskSettings.Set("mask", "");
            this.txtPIDate.Size = new System.Drawing.Size(79, 20);
            this.txtPIDate.TabIndex = 447;
            this.txtPIDate.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // txtAddress
            // 
            this.txtAddress.Enabled = false;
            this.txtAddress.Location = new System.Drawing.Point(141, 71);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(551, 20);
            this.txtAddress.TabIndex = 452;
            this.txtAddress.TabStop = false;
            // 
            // frmPIGeneration2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(738, 478);
            this.ControlBox = false;
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.InfoGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtPINo);
            this.Controls.Add(this.txtStoreCode);
            this.Controls.Add(this.txtPIDate);
            this.Controls.Add(this.Menu_ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmPIGeneration2";
            this.Load += new System.EventHandler(this.frmPIGeneration2_Load);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPINo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStoreCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPIDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPIDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraGrid.GridControl InfoGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView InfoGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label15;
        private DevExpress.XtraEditors.TextEdit txtPINo;
        private DevExpress.XtraEditors.TextEdit txtStoreCode;
        private DevExpress.XtraEditors.DateEdit txtPIDate;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.TextEdit txtAddress;
    }
}