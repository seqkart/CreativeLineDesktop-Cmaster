﻿
namespace WindowsFormsApplication1.Production
{
    partial class frmYarnMaster
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
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtYarnContent = new DevExpress.XtraEditors.TextEdit();
            this.txtYarnCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtYarnTypeCode = new DevExpress.XtraEditors.TextEdit();
            this.txtYarnTypeDesc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtYarnLotNo = new DevExpress.XtraEditors.TextEdit();
            this.txtColorName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtColorCode = new DevExpress.XtraEditors.TextEdit();
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnTypeDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnLotNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            this.SuspendLayout();
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(882, 27);
            this.Menu_ToolStrip.TabIndex = 200;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.Image = global::WindowsFormsApplication1.Properties.Resources.Close;
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(70, 24);
            this.btnQuit.Text = "Close";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::WindowsFormsApplication1.Properties.Resources.Add;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(102, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 199;
            this.label3.Text = "Yarn Content";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(116, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 198;
            this.label1.Text = "Yarn Code";
            // 
            // txtYarnContent
            // 
            this.txtYarnContent.Location = new System.Drawing.Point(217, 147);
            this.txtYarnContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYarnContent.Name = "txtYarnContent";
            this.txtYarnContent.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYarnContent.Properties.MaxLength = 100;
            this.txtYarnContent.Size = new System.Drawing.Size(445, 24);
            this.txtYarnContent.TabIndex = 3;
            // 
            // txtYarnCode
            // 
            this.txtYarnCode.Location = new System.Drawing.Point(217, 81);
            this.txtYarnCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYarnCode.Name = "txtYarnCode";
            this.txtYarnCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYarnCode.Size = new System.Drawing.Size(97, 24);
            this.txtYarnCode.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(119, 116);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 17);
            this.labelControl1.TabIndex = 202;
            this.labelControl1.Text = "Yarn Type";
            // 
            // txtYarnTypeCode
            // 
            this.txtYarnTypeCode.Location = new System.Drawing.Point(217, 113);
            this.txtYarnTypeCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYarnTypeCode.Name = "txtYarnTypeCode";
            this.txtYarnTypeCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYarnTypeCode.Properties.MaxLength = 100;
            this.txtYarnTypeCode.Size = new System.Drawing.Size(97, 24);
            this.txtYarnTypeCode.TabIndex = 1;
            this.txtYarnTypeCode.EditValueChanged += new System.EventHandler(this.txtYarnTypeCode_EditValueChanged);
            this.txtYarnTypeCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYarnTypeCode_KeyDown);
            // 
            // txtYarnTypeDesc
            // 
            this.txtYarnTypeDesc.Enabled = false;
            this.txtYarnTypeDesc.Location = new System.Drawing.Point(320, 113);
            this.txtYarnTypeDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYarnTypeDesc.Name = "txtYarnTypeDesc";
            this.txtYarnTypeDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYarnTypeDesc.Properties.MaxLength = 100;
            this.txtYarnTypeDesc.Size = new System.Drawing.Size(342, 24);
            this.txtYarnTypeDesc.TabIndex = 2;
            this.txtYarnTypeDesc.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(107, 182);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 17);
            this.labelControl2.TabIndex = 205;
            this.labelControl2.Text = "Yarn Lot No";
            // 
            // txtYarnLotNo
            // 
            this.txtYarnLotNo.Location = new System.Drawing.Point(217, 179);
            this.txtYarnLotNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYarnLotNo.Name = "txtYarnLotNo";
            this.txtYarnLotNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYarnLotNo.Properties.MaxLength = 100;
            this.txtYarnLotNo.Size = new System.Drawing.Size(445, 24);
            this.txtYarnLotNo.TabIndex = 4;
            // 
            // txtColorName
            // 
            this.txtColorName.Enabled = false;
            this.txtColorName.Location = new System.Drawing.Point(321, 211);
            this.txtColorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColorName.Properties.MaxLength = 100;
            this.txtColorName.Size = new System.Drawing.Size(342, 24);
            this.txtColorName.TabIndex = 6;
            this.txtColorName.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 214);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(141, 17);
            this.labelControl3.TabIndex = 207;
            this.labelControl3.Text = "Yarn Sahde Num & Name";
            // 
            // txtColorCode
            // 
            this.txtColorCode.Location = new System.Drawing.Point(218, 211);
            this.txtColorCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColorCode.Name = "txtColorCode";
            this.txtColorCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColorCode.Properties.MaxLength = 100;
            this.txtColorCode.Size = new System.Drawing.Size(97, 24);
            this.txtColorCode.TabIndex = 5;
            this.txtColorCode.EditValueChanged += new System.EventHandler(this.txtColorCode_EditValueChanged);
            this.txtColorCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtColorCode_KeyDown);
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(426, 275);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(613, 340);
            this.HelpGrid.TabIndex = 410;
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
            // frmYarnMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 506);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtColorCode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtYarnLotNo);
            this.Controls.Add(this.txtYarnTypeDesc);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtYarnTypeCode);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYarnContent);
            this.Controls.Add(this.txtYarnCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmYarnMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmYarnMaster_Load);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnTypeDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnLotNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtYarnContent;
        private DevExpress.XtraEditors.TextEdit txtYarnCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtYarnTypeCode;
        private DevExpress.XtraEditors.TextEdit txtYarnTypeDesc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtYarnLotNo;
        private DevExpress.XtraEditors.TextEdit txtColorName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtColorCode;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
    }
}