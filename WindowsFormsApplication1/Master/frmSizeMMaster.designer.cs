﻿namespace WindowsFormsApplication1
{
    partial class frmSizeMMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSizeMMaster));
            this.Label1 = new DevExpress.XtraEditors.LabelControl();
            this.LABEL4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtSizeName = new DevExpress.XtraEditors.TextEdit();
            this.txtSysID = new DevExpress.XtraEditors.TextEdit();
            this.Label15 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.txtIndex = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSizeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSysID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIndex.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label1.Appearance.Options.UseFont = true;
            this.Label1.Location = new System.Drawing.Point(38, 99);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(71, 13);
            this.Label1.TabIndex = 32;
            this.Label1.Text = "DESCRIPTION:";
            // 
            // LABEL4
            // 
            this.LABEL4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.LABEL4.Appearance.Options.UseFont = true;
            this.LABEL4.Location = new System.Drawing.Point(51, 73);
            this.LABEL4.Name = "LABEL4";
            this.LABEL4.Size = new System.Drawing.Size(58, 13);
            this.LABEL4.TabIndex = 32;
            this.LABEL4.Text = "SIZE NAME:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(115, 95);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescription.Properties.MaxLength = 100;
            this.txtDescription.Size = new System.Drawing.Size(351, 20);
            this.txtDescription.TabIndex = 1;
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(504, 25);
            this.Menu_ToolStrip.TabIndex = 599;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(35, 22);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(38, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtSizeName
            // 
            this.txtSizeName.EnterMoveNextControl = true;
            this.txtSizeName.Location = new System.Drawing.Point(115, 69);
            this.txtSizeName.Name = "txtSizeName";
            this.txtSizeName.Properties.MaxLength = 100;
            this.txtSizeName.Size = new System.Drawing.Size(225, 20);
            this.txtSizeName.TabIndex = 0;
            // 
            // txtSysID
            // 
            this.txtSysID.Location = new System.Drawing.Point(115, 43);
            this.txtSysID.Name = "txtSysID";
            this.txtSysID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSysID.Size = new System.Drawing.Size(83, 20);
            this.txtSysID.TabIndex = 597;
            // 
            // Label15
            // 
            this.Label15.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label15.Appearance.Options.UseFont = true;
            this.Label15.Location = new System.Drawing.Point(71, 47);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(38, 13);
            this.Label15.TabIndex = 593;
            this.Label15.Text = "SYS ID :";
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label2.Appearance.Options.UseFont = true;
            this.label2.Location = new System.Drawing.Point(355, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 602;
            this.label2.Text = "INDEX";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(390, 69);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIndex.Properties.MaxLength = 100;
            this.txtIndex.Size = new System.Drawing.Size(76, 20);
            this.txtIndex.TabIndex = 2;
            // 
            // frmSizeMMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 134);
            this.ControlBox = false;
            this.Controls.Add(this.txtIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtSizeName);
            this.Controls.Add(this.txtSysID);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.LABEL4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmSizeMMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmSizeMMaster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSizeMMaster_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSizeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSysID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIndex.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal DevExpress.XtraEditors.LabelControl Label1;
        internal DevExpress.XtraEditors.LabelControl LABEL4;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtSizeName;
        private DevExpress.XtraEditors.TextEdit txtSysID;
        internal DevExpress.XtraEditors.LabelControl Label15;
        internal DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit txtIndex;
    }
}