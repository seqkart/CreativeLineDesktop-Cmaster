namespace WindowsFormsApplication1.Master
{
    partial class FrmGroupMstAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGroupMstAddEdit));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.label9 = new DevExpress.XtraEditors.LabelControl();
            this.label8 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHSNCode = new DevExpress.XtraEditors.TextEdit();
            this.txtGrpDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtSGrpCode = new DevExpress.XtraEditors.TextEdit();
            this.txtSGrpDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtGrpCode = new DevExpress.XtraEditors.TextEdit();
            this.btnSave2 = new DevExpress.XtraEditors.SimpleButton();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHSNCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrpDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGrpCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGrpDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrpCode.Properties)).BeginInit();
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(641, 27);
            this.Menu_ToolStrip.TabIndex = 241;
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
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label9
            // 
            this.label9.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Appearance.Options.UseFont = true;
            this.label9.Location = new System.Drawing.Point(17, 70);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 23);
            this.label9.TabIndex = 240;
            this.label9.Text = "Group Desc";
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 239;
            this.label8.Text = "Sub Group Desc";
            this.label8.Visible = false;
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Appearance.Options.UseFont = true;
            this.label3.Location = new System.Drawing.Point(336, 37);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 23);
            this.label3.TabIndex = 237;
            this.label3.Text = "Sub Group Code";
            this.label3.Visible = false;
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 236;
            this.label1.Text = "Group Code";
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Appearance.Options.UseFont = true;
            this.label2.Location = new System.Drawing.Point(31, 102);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 23);
            this.label2.TabIndex = 243;
            this.label2.Text = "HSNCode";
            // 
            // txtHSNCode
            // 
            this.txtHSNCode.Location = new System.Drawing.Point(113, 98);
            this.txtHSNCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHSNCode.Name = "txtHSNCode";
            this.txtHSNCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHSNCode.Properties.Appearance.Options.UseFont = true;
            this.txtHSNCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHSNCode.Properties.MaxLength = 12;
            this.txtHSNCode.Size = new System.Drawing.Size(425, 30);
            this.txtHSNCode.TabIndex = 2;
            // 
            // txtGrpDesc
            // 
            this.txtGrpDesc.Location = new System.Drawing.Point(113, 66);
            this.txtGrpDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGrpDesc.Name = "txtGrpDesc";
            this.txtGrpDesc.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrpDesc.Properties.Appearance.Options.UseFont = true;
            this.txtGrpDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrpDesc.Properties.MaxLength = 50;
            this.txtGrpDesc.Size = new System.Drawing.Size(425, 30);
            this.txtGrpDesc.TabIndex = 1;
            this.txtGrpDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtGrpDesc_KeyPress);
            this.txtGrpDesc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtGrpDesc_KeyUp);
            // 
            // txtSGrpCode
            // 
            this.txtSGrpCode.Location = new System.Drawing.Point(455, 34);
            this.txtSGrpCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSGrpCode.Name = "txtSGrpCode";
            this.txtSGrpCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGrpCode.Properties.Appearance.Options.UseFont = true;
            this.txtSGrpCode.Properties.MaxLength = 4;
            this.txtSGrpCode.Size = new System.Drawing.Size(83, 30);
            this.txtSGrpCode.TabIndex = 2;
            this.txtSGrpCode.Visible = false;
            // 
            // txtSGrpDesc
            // 
            this.txtSGrpDesc.Location = new System.Drawing.Point(113, 145);
            this.txtSGrpDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSGrpDesc.Name = "txtSGrpDesc";
            this.txtSGrpDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSGrpDesc.Properties.MaxLength = 50;
            this.txtSGrpDesc.Size = new System.Drawing.Size(425, 22);
            this.txtSGrpDesc.TabIndex = 4;
            this.txtSGrpDesc.Visible = false;
            this.txtSGrpDesc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtSGrpDesc_KeyPress);
            // 
            // txtGrpCode
            // 
            this.txtGrpCode.Location = new System.Drawing.Point(113, 34);
            this.txtGrpCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGrpCode.Name = "txtGrpCode";
            this.txtGrpCode.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrpCode.Properties.Appearance.Options.UseFont = true;
            this.txtGrpCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGrpCode.Properties.MaxLength = 4;
            this.txtGrpCode.Size = new System.Drawing.Size(83, 30);
            this.txtGrpCode.TabIndex = 0;
            this.txtGrpCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtGrpCode_KeyDown);
            this.txtGrpCode.Validating += new System.ComponentModel.CancelEventHandler(this.TxtGrpCode_Validating);
            // 
            // btnSave2
            // 
            this.btnSave2.Location = new System.Drawing.Point(249, 136);
            this.btnSave2.Name = "btnSave2";
            this.btnSave2.Size = new System.Drawing.Size(94, 29);
            this.btnSave2.TabIndex = 385;
            this.btnSave2.Text = "Save";
            this.btnSave2.Click += new System.EventHandler(this.btnSave2_Click);
            // 
            // FrmGroupMstAddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(641, 177);
            this.ControlBox = false;
            this.Controls.Add(this.btnSave2);
            this.Controls.Add(this.txtHSNCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtGrpDesc);
            this.Controls.Add(this.txtSGrpCode);
            this.Controls.Add(this.txtSGrpDesc);
            this.Controls.Add(this.txtGrpCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmGroupMstAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmGroupMstAddEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmGroupMstAddEdit_KeyDown);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHSNCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrpDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGrpCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSGrpDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGrpCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtGrpDesc;
        private DevExpress.XtraEditors.TextEdit txtSGrpCode;
        private DevExpress.XtraEditors.TextEdit txtSGrpDesc;
        private DevExpress.XtraEditors.TextEdit txtGrpCode;
        private DevExpress.XtraEditors.LabelControl label9;
        private DevExpress.XtraEditors.LabelControl label8;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtHSNCode;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.SimpleButton btnSave2;
    }
}