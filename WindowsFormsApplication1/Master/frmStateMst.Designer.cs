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
            this.txtCountry = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
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
            this.Menu_ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuit,
            this.btnSave});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(434, 31);
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
            // txtStateName
            // 
            this.txtStateName.Location = new System.Drawing.Point(114, 110);
            this.txtStateName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStateName.Name = "txtStateName";
            this.txtStateName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStateName.Properties.MaxLength = 100;
            this.txtStateName.Size = new System.Drawing.Size(246, 24);
            this.txtStateName.TabIndex = 388;
            // 
            // txtStateCode
            // 
            this.txtStateCode.Location = new System.Drawing.Point(114, 67);
            this.txtStateCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStateCode.Name = "txtStateCode";
            this.txtStateCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStateCode.Size = new System.Drawing.Size(97, 24);
            this.txtStateCode.TabIndex = 387;
            // 
            // txtCountry
            // 
            this.txtCountry.EditValue = "INDIA";
            this.txtCountry.Location = new System.Drawing.Point(114, 153);
            this.txtCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCountry.Size = new System.Drawing.Size(246, 24);
            this.txtCountry.TabIndex = 389;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(64, 72);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 17);
            this.labelControl1.TabIndex = 390;
            this.labelControl1.Text = "SYS ID :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(24, 115);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(84, 17);
            this.labelControl2.TabIndex = 390;
            this.labelControl2.Text = "STATE NAME :";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(42, 158);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(66, 17);
            this.labelControl3.TabIndex = 390;
            this.labelControl3.Text = "COUNTRY :";
            // 
            // frmStateMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(434, 241);
            this.ControlBox = false;
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.txtStateName);
            this.Controls.Add(this.txtStateCode);
            this.Controls.Add(this.Menu_ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmStateMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmStateMst_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmStateMst_KeyDown);
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
        private DevExpress.XtraEditors.ComboBoxEdit txtCountry;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}