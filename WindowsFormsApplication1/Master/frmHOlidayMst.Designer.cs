
namespace WindowsFormsApplication1.Master
{
    partial class frmHOlidayMst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHOlidayMst));
            this.txtHolidayName = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtHolidayDate = new DevExpress.XtraEditors.TextEdit();
            this.Label17 = new DevExpress.XtraEditors.LabelControl();
            this.Label16 = new DevExpress.XtraEditors.LabelControl();
            this.Label15 = new DevExpress.XtraEditors.LabelControl();
            this.txtSysID = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHolidayName.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHolidayDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSysID.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtHolidayName
            // 
            this.txtHolidayName.Location = new System.Drawing.Point(110, 120);
            this.txtHolidayName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHolidayName.Name = "txtHolidayName";
            this.txtHolidayName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHolidayName.Properties.MaxLength = 100;
            this.txtHolidayName.Size = new System.Drawing.Size(409, 24);
            this.txtHolidayName.TabIndex = 390;
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(535, 31);
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
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtHolidayDate
            // 
            this.txtHolidayDate.Location = new System.Drawing.Point(110, 77);
            this.txtHolidayDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHolidayDate.Name = "txtHolidayDate";
            this.txtHolidayDate.Properties.BeepOnError = false;
            this.txtHolidayDate.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtHolidayDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.txtHolidayDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtHolidayDate.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.txtHolidayDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtHolidayDate.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.DateTimeMaskManager));
            this.txtHolidayDate.Properties.MaskSettings.Set("mask", "dd-MM-yyyy");
            this.txtHolidayDate.Properties.MaxLength = 100;
            this.txtHolidayDate.Properties.UseMaskAsDisplayFormat = true;
            this.txtHolidayDate.Size = new System.Drawing.Size(409, 24);
            this.txtHolidayDate.TabIndex = 388;
            // 
            // Label17
            // 
            this.Label17.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label17.Appearance.Options.UseFont = true;
            this.Label17.Location = new System.Drawing.Point(23, 79);
            this.Label17.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(81, 19);
            this.Label17.TabIndex = 385;
            this.Label17.Text = "Holiday Date";
            // 
            // Label16
            // 
            this.Label16.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label16.Appearance.Options.UseFont = true;
            this.Label16.Location = new System.Drawing.Point(15, 123);
            this.Label16.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(89, 19);
            this.Label16.TabIndex = 386;
            this.Label16.Text = "Holiday Name";
            // 
            // Label15
            // 
            this.Label15.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label15.Appearance.Options.UseFont = true;
            this.Label15.Location = new System.Drawing.Point(55, 37);
            this.Label15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(49, 19);
            this.Label15.TabIndex = 384;
            this.Label15.Text = "SYS ID :";
            // 
            // txtSysID
            // 
            this.txtSysID.Location = new System.Drawing.Point(110, 34);
            this.txtSysID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSysID.Name = "txtSysID";
            this.txtSysID.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSysID.Size = new System.Drawing.Size(97, 24);
            this.txtSysID.TabIndex = 387;
            // 
            // frmHOlidayMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(535, 162);
            this.ControlBox = false;
            this.Controls.Add(this.txtHolidayName);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtHolidayDate);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.txtSysID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmHOlidayMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmHOlidayMst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtHolidayName.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHolidayDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSysID.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtHolidayName;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtHolidayDate;
        internal DevExpress.XtraEditors.LabelControl Label17;
        internal DevExpress.XtraEditors.LabelControl Label16;
        internal DevExpress.XtraEditors.LabelControl Label15;
        private DevExpress.XtraEditors.TextEdit txtSysID;
    }
}