
namespace WindowsFormsApplication1.Master
{
    partial class FrmProcessMst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProcessMst));
            this.txtProcessRate = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtProcessName = new DevExpress.XtraEditors.TextEdit();
            this.txtProcessCode = new DevExpress.XtraEditors.TextEdit();
            this.Label17 = new DevExpress.XtraEditors.LabelControl();
            this.Label16 = new DevExpress.XtraEditors.LabelControl();
            this.Label15 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessRate.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProcessRate
            // 
            this.txtProcessRate.Location = new System.Drawing.Point(160, 166);
            this.txtProcessRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcessRate.Name = "txtProcessRate";
            this.txtProcessRate.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProcessRate.Properties.MaxLength = 100;
            this.txtProcessRate.Size = new System.Drawing.Size(301, 24);
            this.txtProcessRate.TabIndex = 2;
            this.txtProcessRate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtProcessRate_KeyPress);
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(519, 31);
            this.Menu_ToolStrip.TabIndex = 389;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(43, 28);
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
            // txtProcessName
            // 
            this.txtProcessName.Location = new System.Drawing.Point(160, 123);
            this.txtProcessName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcessName.Name = "txtProcessName";
            this.txtProcessName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProcessName.Properties.MaxLength = 100;
            this.txtProcessName.Size = new System.Drawing.Size(301, 24);
            this.txtProcessName.TabIndex = 1;
            // 
            // txtProcessCode
            // 
            this.txtProcessCode.Location = new System.Drawing.Point(160, 80);
            this.txtProcessCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProcessCode.Name = "txtProcessCode";
            this.txtProcessCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProcessCode.Size = new System.Drawing.Size(97, 24);
            this.txtProcessCode.TabIndex = 0;
            // 
            // Label17
            // 
            this.Label17.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label17.Appearance.Options.UseFont = true;
            this.Label17.Location = new System.Drawing.Point(45, 126);
            this.Label17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(108, 19);
            this.Label17.TabIndex = 385;
            this.Label17.Text = "PROCESS  NAME";
            // 
            // Label16
            // 
            this.Label16.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label16.Appearance.Options.UseFont = true;
            this.Label16.Location = new System.Drawing.Point(56, 169);
            this.Label16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(97, 19);
            this.Label16.TabIndex = 386;
            this.Label16.Text = "PROCESS RATE";
            // 
            // Label15
            // 
            this.Label15.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label15.Appearance.Options.UseFont = true;
            this.Label15.Location = new System.Drawing.Point(48, 83);
            this.Label15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(105, 19);
            this.Label15.TabIndex = 384;
            this.Label15.Text = "PROCESS CODE ";
            // 
            // frmProcessMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(519, 237);
            this.ControlBox = false;
            this.Controls.Add(this.txtProcessRate);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtProcessName);
            this.Controls.Add(this.txtProcessCode);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmProcessMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmProcessMst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessRate.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcessCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtProcessRate;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtProcessName;
        private DevExpress.XtraEditors.TextEdit txtProcessCode;
        internal DevExpress.XtraEditors.LabelControl Label17;
        internal DevExpress.XtraEditors.LabelControl Label16;
        internal DevExpress.XtraEditors.LabelControl Label15;
    }
}