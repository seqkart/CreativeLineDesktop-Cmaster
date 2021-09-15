
namespace WindowsFormsApplication1.Production
{
    partial class frmYarnTypeMst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmYarnTypeMst));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.Label17 = new DevExpress.XtraEditors.LabelControl();
            this.Label15 = new DevExpress.XtraEditors.LabelControl();
            this.txtYarnTypeDesc = new DevExpress.XtraEditors.TextEdit();
            this.txtYarnTypeCode = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnTypeDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnTypeCode.Properties)).BeginInit();
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(464, 27);
            this.Menu_ToolStrip.TabIndex = 394;
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
            this.btnSave.Size = new System.Drawing.Size(45, 28);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // Label17
            // 
            this.Label17.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label17.Appearance.Options.UseFont = true;
            this.Label17.Location = new System.Drawing.Point(19, 88);
            this.Label17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(110, 19);
            this.Label17.TabIndex = 393;
            this.Label17.Text = "YARN TYPE DESC";
            // 
            // Label15
            // 
            this.Label15.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label15.Appearance.Options.UseFont = true;
            this.Label15.Location = new System.Drawing.Point(16, 45);
            this.Label15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(113, 19);
            this.Label15.TabIndex = 392;
            this.Label15.Text = "YARN TYPE CODE";
            // 
            // txtYarnTypeDesc
            // 
            this.txtYarnTypeDesc.Location = new System.Drawing.Point(135, 85);
            this.txtYarnTypeDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYarnTypeDesc.Name = "txtYarnTypeDesc";
            this.txtYarnTypeDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYarnTypeDesc.Properties.MaxLength = 100;
            this.txtYarnTypeDesc.Size = new System.Drawing.Size(301, 24);
            this.txtYarnTypeDesc.TabIndex = 391;
            // 
            // txtYarnTypeCode
            // 
            this.txtYarnTypeCode.Location = new System.Drawing.Point(135, 42);
            this.txtYarnTypeCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYarnTypeCode.Name = "txtYarnTypeCode";
            this.txtYarnTypeCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYarnTypeCode.Size = new System.Drawing.Size(97, 24);
            this.txtYarnTypeCode.TabIndex = 390;
            // 
            // frmYarnTypeMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(464, 131);
            this.ControlBox = false;
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtYarnTypeDesc);
            this.Controls.Add(this.txtYarnTypeCode);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmYarnTypeMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmLotTypeMst_Load);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnTypeDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnTypeCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtYarnTypeDesc;
        private DevExpress.XtraEditors.TextEdit txtYarnTypeCode;
        internal DevExpress.XtraEditors.LabelControl Label17;
        internal DevExpress.XtraEditors.LabelControl Label15;
    }
}