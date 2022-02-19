﻿namespace WindowsFormsApplication1
{
    partial class frmLedgerAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLedgerAddEdit));
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtLedgerDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtLedgerType = new DevExpress.XtraEditors.TextEdit();
            this.txtLedgerCode = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLedgerDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLedgerType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLedgerCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(85, 99);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 16);
            this.label3.TabIndex = 19;
            this.label3.Text = "Desc";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(85, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 18;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(82, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "Code";
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(454, 27);
            this.Menu_ToolStrip.TabIndex = 194;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(43, 24);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtLedgerDesc
            // 
            this.txtLedgerDesc.EnterMoveNextControl = true;
            this.txtLedgerDesc.Location = new System.Drawing.Point(121, 95);
            this.txtLedgerDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLedgerDesc.Name = "txtLedgerDesc";
            this.txtLedgerDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLedgerDesc.Properties.MaxLength = 30;
            this.txtLedgerDesc.Size = new System.Drawing.Size(267, 22);
            this.txtLedgerDesc.TabIndex = 1;
            // 
            // txtLedgerType
            // 
            this.txtLedgerType.EnterMoveNextControl = true;
            this.txtLedgerType.Location = new System.Drawing.Point(121, 129);
            this.txtLedgerType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLedgerType.Name = "txtLedgerType";
            this.txtLedgerType.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLedgerType.Properties.MaxLength = 1;
            this.txtLedgerType.Size = new System.Drawing.Size(65, 22);
            this.txtLedgerType.TabIndex = 3;
            // 
            // txtLedgerCode
            // 
            this.txtLedgerCode.Location = new System.Drawing.Point(121, 61);
            this.txtLedgerCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLedgerCode.Name = "txtLedgerCode";
            this.txtLedgerCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLedgerCode.Size = new System.Drawing.Size(65, 22);
            this.txtLedgerCode.TabIndex = 1;
            this.txtLedgerCode.TabStop = false;
            // 
            // frmLedgerAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(454, 191);
            this.ControlBox = false;
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtLedgerDesc);
            this.Controls.Add(this.txtLedgerType);
            this.Controls.Add(this.txtLedgerCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLedgerAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmLedgerAddEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmLedgerAddEdit_KeyDown);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtLedgerDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLedgerType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLedgerCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtLedgerCode;
        private DevExpress.XtraEditors.TextEdit txtLedgerType;
        private DevExpress.XtraEditors.TextEdit txtLedgerDesc;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnQuit;
    }
}