namespace WindowsFormsApplication1.Master
{
    partial class frmStateMst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStateMst));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtStateName = new DevExpress.XtraEditors.TextEdit();
            this.txtStateCode = new DevExpress.XtraEditors.TextEdit();
            this.Label17 = new System.Windows.Forms.Label();
            this.Label16 = new System.Windows.Forms.Label();
            this.Label15 = new System.Windows.Forms.Label();
            this.txtCountry = new DevExpress.XtraEditors.ComboBoxEdit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStateName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStateCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(552, 26);
            this.Menu_ToolStrip.TabIndex = 376;
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
            this.btnQuit.Size = new System.Drawing.Size(45, 23);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnSave.Size = new System.Drawing.Size(48, 23);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtStateName
            // 
            this.txtStateName.Location = new System.Drawing.Point(140, 91);
            this.txtStateName.Name = "txtStateName";
            this.txtStateName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStateName.Properties.MaxLength = 100;
            this.txtStateName.Size = new System.Drawing.Size(351, 20);
            this.txtStateName.TabIndex = 388;
            // 
            // txtStateCode
            // 
            this.txtStateCode.Location = new System.Drawing.Point(140, 57);
            this.txtStateCode.Name = "txtStateCode";
            this.txtStateCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStateCode.Size = new System.Drawing.Size(83, 20);
            this.txtStateCode.TabIndex = 387;
            // 
            // Label17
            // 
            this.Label17.AutoSize = true;
            this.Label17.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Label17.Location = new System.Drawing.Point(37, 91);
            this.Label17.Name = "Label17";
            this.Label17.Size = new System.Drawing.Size(85, 18);
            this.Label17.TabIndex = 385;
            this.Label17.Text = "STATE NAME";
            // 
            // Label16
            // 
            this.Label16.AutoSize = true;
            this.Label16.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Label16.Location = new System.Drawing.Point(37, 123);
            this.Label16.Name = "Label16";
            this.Label16.Size = new System.Drawing.Size(76, 18);
            this.Label16.TabIndex = 386;
            this.Label16.Text = "COUNTRY :";
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(81, 57);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(53, 18);
            this.Label15.TabIndex = 384;
            this.Label15.Text = "SYS ID :";
            // 
            // txtCountry
            // 
            this.txtCountry.Location = new System.Drawing.Point(140, 123);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCountry.Size = new System.Drawing.Size(351, 20);
            this.txtCountry.TabIndex = 389;
            // 
            // frmStateMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 197);
            this.ControlBox = false;
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtStateName);
            this.Controls.Add(this.txtStateCode);
            this.Controls.Add(this.Label17);
            this.Controls.Add(this.Label16);
            this.Controls.Add(this.Label15);
            this.Controls.Add(this.Menu_ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmStateMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmStateMst_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStateMst_KeyDown);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtStateName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStateCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtStateName;
        private DevExpress.XtraEditors.TextEdit txtStateCode;
        internal System.Windows.Forms.Label Label17;
        internal System.Windows.Forms.Label Label16;
        internal System.Windows.Forms.Label Label15;
        private DevExpress.XtraEditors.ComboBoxEdit txtCountry;
    }
}