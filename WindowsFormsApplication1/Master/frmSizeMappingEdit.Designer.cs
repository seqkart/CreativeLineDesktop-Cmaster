
namespace WindowsFormsApplication1.Master
{
    partial class FrmSizeMappingEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSizeMappingEdit));
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.label9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTempSizeDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtSizeDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtSizeID = new DevExpress.XtraEditors.TextEdit();
            this.txtGrpDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtGrpCode = new DevExpress.XtraEditors.TextEdit();
            this.txtSGrpDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtSGrpCode = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTempSizeDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSizeDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSizeID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrpDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrpCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGrpDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGrpCode.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Location = new System.Drawing.Point(74, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 19);
            this.label1.TabIndex = 699;
            this.label1.Text = "GROUP";
            // 
            // label9
            // 
            this.label9.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.label9.Appearance.Options.UseFont = true;
            this.label9.Location = new System.Drawing.Point(44, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 19);
            this.label9.TabIndex = 698;
            this.label9.Text = "SUB GROUP";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(74, 150);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 19);
            this.labelControl1.TabIndex = 702;
            this.labelControl1.Text = "Size ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(62, 177);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 19);
            this.labelControl2.TabIndex = 704;
            this.labelControl2.Text = "Size Desc";
            // 
            // txtTempSizeDesc
            // 
            this.txtTempSizeDesc.Location = new System.Drawing.Point(128, 179);
            this.txtTempSizeDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTempSizeDesc.Name = "txtTempSizeDesc";
            this.txtTempSizeDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTempSizeDesc.Size = new System.Drawing.Size(331, 22);
            this.txtTempSizeDesc.TabIndex = 703;
            this.txtTempSizeDesc.TabStop = false;
            // 
            // txtSizeDesc
            // 
            this.txtSizeDesc.Enabled = false;
            this.txtSizeDesc.Location = new System.Drawing.Point(212, 149);
            this.txtSizeDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSizeDesc.Name = "txtSizeDesc";
            this.txtSizeDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSizeDesc.Properties.ReadOnly = true;
            this.txtSizeDesc.Size = new System.Drawing.Size(247, 22);
            this.txtSizeDesc.TabIndex = 701;
            this.txtSizeDesc.TabStop = false;
            // 
            // txtSizeID
            // 
            this.txtSizeID.Enabled = false;
            this.txtSizeID.Location = new System.Drawing.Point(128, 149);
            this.txtSizeID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSizeID.Name = "txtSizeID";
            this.txtSizeID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSizeID.Properties.MaxLength = 4;
            this.txtSizeID.Size = new System.Drawing.Size(80, 22);
            this.txtSizeID.TabIndex = 700;
            // 
            // txtGrpDesc
            // 
            this.txtGrpDesc.Enabled = false;
            this.txtGrpDesc.Location = new System.Drawing.Point(212, 87);
            this.txtGrpDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGrpDesc.Name = "txtGrpDesc";
            this.txtGrpDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrpDesc.Properties.ReadOnly = true;
            this.txtGrpDesc.Size = new System.Drawing.Size(247, 22);
            this.txtGrpDesc.TabIndex = 696;
            this.txtGrpDesc.TabStop = false;
            // 
            // txtGrpCode
            // 
            this.txtGrpCode.Enabled = false;
            this.txtGrpCode.Location = new System.Drawing.Point(128, 87);
            this.txtGrpCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGrpCode.Name = "txtGrpCode";
            this.txtGrpCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrpCode.Properties.MaxLength = 4;
            this.txtGrpCode.Size = new System.Drawing.Size(80, 22);
            this.txtGrpCode.TabIndex = 695;
            this.txtGrpCode.TabStop = false;
            // 
            // txtSGrpDesc
            // 
            this.txtSGrpDesc.Enabled = false;
            this.txtSGrpDesc.Location = new System.Drawing.Point(212, 119);
            this.txtSGrpDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSGrpDesc.Name = "txtSGrpDesc";
            this.txtSGrpDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSGrpDesc.Properties.ReadOnly = true;
            this.txtSGrpDesc.Size = new System.Drawing.Size(247, 22);
            this.txtSGrpDesc.TabIndex = 697;
            this.txtSGrpDesc.TabStop = false;
            // 
            // txtSGrpCode
            // 
            this.txtSGrpCode.Enabled = false;
            this.txtSGrpCode.Location = new System.Drawing.Point(128, 119);
            this.txtSGrpCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSGrpCode.Name = "txtSGrpCode";
            this.txtSGrpCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSGrpCode.Properties.MaxLength = 4;
            this.txtSGrpCode.Size = new System.Drawing.Size(80, 22);
            this.txtSGrpCode.TabIndex = 694;
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(520, 31);
            this.Menu_ToolStrip.TabIndex = 705;
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
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(62, 55);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 19);
            this.labelControl3.TabIndex = 707;
            this.labelControl3.Text = "TransID";
            // 
            // txtTransID
            // 
            this.txtTransID.Location = new System.Drawing.Point(128, 57);
            this.txtTransID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTransID.Properties.ReadOnly = true;
            this.txtTransID.Size = new System.Drawing.Size(331, 22);
            this.txtTransID.TabIndex = 706;
            this.txtTransID.TabStop = false;
            // 
            // frmSizeMappingEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 236);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtTransID);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtTempSizeDesc);
            this.Controls.Add(this.txtSizeDesc);
            this.Controls.Add(this.txtSizeID);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtGrpDesc);
            this.Controls.Add(this.txtGrpCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSGrpDesc);
            this.Controls.Add(this.txtSGrpCode);
            this.Controls.Add(this.label9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmSizeMappingEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmSizeMappingEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtTempSizeDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSizeDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSizeID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrpDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrpCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGrpDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGrpCode.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtGrpDesc;
        private DevExpress.XtraEditors.TextEdit txtGrpCode;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtSGrpDesc;
        private DevExpress.XtraEditors.TextEdit txtSGrpCode;
        private DevExpress.XtraEditors.LabelControl label9;
        private DevExpress.XtraEditors.TextEdit txtSizeDesc;
        private DevExpress.XtraEditors.TextEdit txtSizeID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtTempSizeDesc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtTransID;
    }
}