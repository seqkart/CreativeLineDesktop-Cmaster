namespace WindowsFormsApplication1
{
    partial class frmUserFinancialYearAddition
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserFinancialYearAddition));
            this.cmbSelectUser = new System.Windows.Forms.ComboBox();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.cmbSelectFY = new System.Windows.Forms.ComboBox();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.btnSaveFY = new System.Windows.Forms.Button();
            this.BTEXIT = new System.Windows.Forms.Button();
            this.Menu_ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbSelectUser
            // 
            this.cmbSelectUser.FormattingEnabled = true;
            this.cmbSelectUser.Location = new System.Drawing.Point(87, 52);
            this.cmbSelectUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSelectUser.Name = "cmbSelectUser";
            this.cmbSelectUser.Size = new System.Drawing.Size(305, 24);
            this.cmbSelectUser.TabIndex = 0;
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(419, 25);
            this.Menu_ToolStrip.TabIndex = 7;
            this.Menu_ToolStrip.TabStop = true;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.MergeIndex = 1;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(43, 24);
            this.btnQuit.Text = "&Quit";
            this.btnQuit.Visible = false;
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.MergeIndex = 0;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 24);
            this.btnSave.Text = "&Save";
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(20, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 336;
            this.label3.Text = "UserName";
            // 
            // cmbSelectFY
            // 
            this.cmbSelectFY.FormattingEnabled = true;
            this.cmbSelectFY.Location = new System.Drawing.Point(87, 86);
            this.cmbSelectFY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbSelectFY.Name = "cmbSelectFY";
            this.cmbSelectFY.Size = new System.Drawing.Size(305, 24);
            this.cmbSelectFY.TabIndex = 2;
            this.cmbSelectFY.SelectedIndexChanged += new System.EventHandler(this.CmbSelectFY_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(29, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 341;
            this.label1.Text = "Select FY";
            // 
            // btnSaveFY
            // 
            this.btnSaveFY.Location = new System.Drawing.Point(304, 139);
            this.btnSaveFY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveFY.Name = "btnSaveFY";
            this.btnSaveFY.Size = new System.Drawing.Size(87, 30);
            this.btnSaveFY.TabIndex = 342;
            this.btnSaveFY.Text = "SAVE";
            this.btnSaveFY.UseVisualStyleBackColor = true;
            this.btnSaveFY.Click += new System.EventHandler(this.BtnSaveFY_Click);
            // 
            // BTEXIT
            // 
            this.BTEXIT.Location = new System.Drawing.Point(211, 139);
            this.BTEXIT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTEXIT.Name = "BTEXIT";
            this.BTEXIT.Size = new System.Drawing.Size(87, 30);
            this.BTEXIT.TabIndex = 342;
            this.BTEXIT.Text = "EXIT";
            this.BTEXIT.UseVisualStyleBackColor = true;
            this.BTEXIT.Click += new System.EventHandler(this.BtnSaveFY_Click);
            // 
            // frmUserFinancialYearAddition
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(419, 187);
            this.ControlBox = false;
            this.Controls.Add(this.BTEXIT);
            this.Controls.Add(this.btnSaveFY);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSelectFY);
            this.Controls.Add(this.cmbSelectUser);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUserFinancialYearAddition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmUserFinancialYearAddition_Load);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSelectUser;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.LabelControl label3;
        private System.Windows.Forms.ComboBox cmbSelectFY;
        private DevExpress.XtraEditors.LabelControl label1;
        private System.Windows.Forms.Button btnSaveFY;
        private System.Windows.Forms.Button BTEXIT;
    }
}