namespace WindowsFormsApplication1.Master
{
    partial class frmMeasurementMapping
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMeasurementMapping));
            this.Label3 = new DevExpress.XtraEditors.LabelControl();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.LBDEPCODE = new DevExpress.XtraEditors.LabelControl();
            this.txtMCode = new DevExpress.XtraEditors.TextEdit();
            this.txtMDesc = new DevExpress.XtraEditors.TextEdit();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMDesc.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Label3
            // 
            this.Label3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.Appearance.Options.UseFont = true;
            this.Label3.Location = new System.Drawing.Point(14, 86);
            this.Label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(138, 20);
            this.Label3.TabIndex = 769;
            this.Label3.Text = "Measurement Desc :";
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(501, 31);
            this.Menu_ToolStrip.TabIndex = 772;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // LBDEPCODE
            // 
            this.LBDEPCODE.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBDEPCODE.Appearance.Options.UseFont = true;
            this.LBDEPCODE.Location = new System.Drawing.Point(11, 52);
            this.LBDEPCODE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LBDEPCODE.Name = "LBDEPCODE";
            this.LBDEPCODE.Size = new System.Drawing.Size(141, 20);
            this.LBDEPCODE.TabIndex = 768;
            this.LBDEPCODE.Text = "Measurement Code :";
            // 
            // txtMCode
            // 
            this.txtMCode.Enabled = false;
            this.txtMCode.EnterMoveNextControl = true;
            this.txtMCode.Location = new System.Drawing.Point(165, 50);
            this.txtMCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMCode.Name = "txtMCode";
            this.txtMCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMCode.Properties.MaxLength = 8;
            this.txtMCode.Size = new System.Drawing.Size(86, 24);
            this.txtMCode.TabIndex = 770;
            this.txtMCode.TabStop = false;
            // 
            // txtMDesc
            // 
            this.txtMDesc.EnterMoveNextControl = true;
            this.txtMDesc.Location = new System.Drawing.Point(165, 82);
            this.txtMDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMDesc.Name = "txtMDesc";
            this.txtMDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMDesc.Size = new System.Drawing.Size(316, 24);
            this.txtMDesc.TabIndex = 771;
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
            // frmMeasurementMapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(501, 122);
            this.ControlBox = false;
            this.Controls.Add(this.txtMCode);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtMDesc);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.LBDEPCODE);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMeasurementMapping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmMeasurementMapping_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmMeasurementMapping_KeyDown);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtMCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMDesc.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtMCode;
        internal DevExpress.XtraEditors.LabelControl Label3;
        private DevExpress.XtraEditors.TextEdit txtMDesc;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        internal DevExpress.XtraEditors.LabelControl LBDEPCODE;
    }
}