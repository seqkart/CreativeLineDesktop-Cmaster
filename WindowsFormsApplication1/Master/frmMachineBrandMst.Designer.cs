
namespace WindowsFormsApplication1.Master
{
    partial class FrmMachineBrandMst
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
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBrandName = new DevExpress.XtraEditors.TextEdit();
            this.txtBrandCode = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandCode.Properties)).BeginInit();
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(523, 31);
            this.Menu_ToolStrip.TabIndex = 205;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.Image = global::WindowsFormsApplication1.Properties.Resources.Close;
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(70, 28);
            this.btnQuit.Text = "Close";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::WindowsFormsApplication1.Properties.Resources.Add;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 28);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(52, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 17);
            this.label3.TabIndex = 204;
            this.label3.Text = "MachineBrandName";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(52, 88);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 203;
            this.label1.Text = "Machine Brand Code";
            // 
            // txtBrandName
            // 
            this.txtBrandName.Location = new System.Drawing.Point(189, 133);
            this.txtBrandName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrandName.Name = "txtBrandName";
            this.txtBrandName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBrandName.Properties.MaxLength = 100;
            this.txtBrandName.Size = new System.Drawing.Size(244, 24);
            this.txtBrandName.TabIndex = 202;
            // 
            // txtBrandCode
            // 
            this.txtBrandCode.Location = new System.Drawing.Point(189, 84);
            this.txtBrandCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBrandCode.Name = "txtBrandCode";
            this.txtBrandCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBrandCode.Size = new System.Drawing.Size(97, 24);
            this.txtBrandCode.TabIndex = 201;
            // 
            // FrmMachineBrandMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(523, 209);
            this.ControlBox = false;
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBrandName);
            this.Controls.Add(this.txtBrandCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmMachineBrandMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmMachineBrandMst_Load);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBrandCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtBrandName;
        private DevExpress.XtraEditors.TextEdit txtBrandCode;
    }
}