
namespace WindowsFormsApplication1.Master
{
    partial class frmAttendenceStatusMst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAttendenceStatusMst));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.Label17 = new DevExpress.XtraEditors.LabelControl();
            this.Label16 = new DevExpress.XtraEditors.LabelControl();
            this.Label15 = new DevExpress.XtraEditors.LabelControl();
            this.txtStatusDesc = new DevExpress.XtraEditors.TextEdit();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtStatusCode = new DevExpress.XtraEditors.TextEdit();
            this.txtStatusID = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusID.Properties)).BeginInit();
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(659, 27);
            this.Menu_ToolStrip.TabIndex = 389;
            this.Menu_ToolStrip.Text = "Options";
            this.Menu_ToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ToolStrip_ItemClicked);
            // 
            // Label17
            // 
            this.Label17.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label17.Appearance.Options.UseFont = true;
            this.Label17.Location = new System.Drawing.Point(46, 109);
            this.Label17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(114, 19);
            this.Label17.TabIndex = 385;
            this.Label17.Text = "Leave Status Code";
            // 
            // Label16
            // 
            this.Label16.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label16.Appearance.Options.UseFont = true;
            this.Label16.Location = new System.Drawing.Point(48, 150);
            this.Label16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(112, 19);
            this.Label16.TabIndex = 386;
            this.Label16.Text = "Leave Status Desc";
            // 
            // Label15
            // 
            this.Label15.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label15.Appearance.Options.UseFont = true;
            this.Label15.Location = new System.Drawing.Point(64, 63);
            this.Label15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(96, 19);
            this.Label15.TabIndex = 384;
            this.Label15.Text = "Leave Status ID";
            // 
            // txtStatusDesc
            // 
            this.txtStatusDesc.Location = new System.Drawing.Point(166, 147);
            this.txtStatusDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatusDesc.Name = "txtStatusDesc";
            this.txtStatusDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStatusDesc.Properties.MaxLength = 100;
            this.txtStatusDesc.Size = new System.Drawing.Size(409, 24);
            this.txtStatusDesc.TabIndex = 390;
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(43, 24);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 24);
            this.btnSave.Text = "Save";
            // 
            // txtStatusCode
            // 
            this.txtStatusCode.Location = new System.Drawing.Point(166, 104);
            this.txtStatusCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatusCode.Name = "txtStatusCode";
            this.txtStatusCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStatusCode.Properties.MaxLength = 100;
            this.txtStatusCode.Size = new System.Drawing.Size(409, 24);
            this.txtStatusCode.TabIndex = 388;
            // 
            // txtStatusID
            // 
            this.txtStatusID.Location = new System.Drawing.Point(166, 61);
            this.txtStatusID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatusID.Name = "txtStatusID";
            this.txtStatusID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStatusID.Size = new System.Drawing.Size(97, 24);
            this.txtStatusID.TabIndex = 387;
            // 
            // frmAttendenceStatusMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 246);
            this.ControlBox = false;
            this.Controls.Add(this.txtStatusDesc);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtStatusCode);
            this.Controls.Add(this.txtStatusID);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label15);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAttendenceStatusMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmAttendenceStatusMst_Load);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtStatusDesc;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtStatusCode;
        private DevExpress.XtraEditors.TextEdit txtStatusID;
        internal DevExpress.XtraEditors.LabelControl Label17;
        internal DevExpress.XtraEditors.LabelControl Label16;
        internal DevExpress.XtraEditors.LabelControl Label15;
    }
}