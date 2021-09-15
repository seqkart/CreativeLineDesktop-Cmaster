namespace WindowsFormsApplication1
{
    partial class FrmUserDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUserDetails));
            this.txtstatusTag = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new DevExpress.XtraEditors.LabelControl();
            this.txtConfirmPassword = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbLoginAs = new System.Windows.Forms.ComboBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtRoleCode = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtstatusTag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtstatusTag
            // 
            this.txtstatusTag.Location = new System.Drawing.Point(324, 58);
            this.txtstatusTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtstatusTag.Name = "txtstatusTag";
            this.txtstatusTag.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtstatusTag.Size = new System.Drawing.Size(121, 24);
            this.txtstatusTag.TabIndex = 2;
            this.txtstatusTag.Validating += new System.ComponentModel.CancelEventHandler(this.TxtstatusTag_Validating);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(282, 62);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 329;
            this.label12.Text = "Active";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(118, 161);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Properties.MaxLength = 8;
            this.txtConfirmPassword.Properties.PasswordChar = '*';
            this.txtConfirmPassword.Size = new System.Drawing.Size(327, 24);
            this.txtConfirmPassword.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(7, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 313;
            this.label4.Text = "Confirm Password";
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(464, 31);
            this.Menu_ToolStrip.TabIndex = 312;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(58, 28);
            this.btnQuit.Text = "&Cancel";
            this.btnQuit.ToolTipText = "Cancel";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(118, 93);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.MaxLength = 8;
            this.txtUserName.Size = new System.Drawing.Size(327, 24);
            this.txtUserName.TabIndex = 3;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(118, 127);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.MaxLength = 8;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(327, 24);
            this.txtPassword.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(51, 97);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 310;
            this.label3.Text = "UserName";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(57, 131);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 308;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(67, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 307;
            this.label1.Text = "LogInAs";
            // 
            // cmbLoginAs
            // 
            this.cmbLoginAs.FormattingEnabled = true;
            this.cmbLoginAs.Location = new System.Drawing.Point(118, 58);
            this.cmbLoginAs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbLoginAs.Name = "cmbLoginAs";
            this.cmbLoginAs.Size = new System.Drawing.Size(140, 25);
            this.cmbLoginAs.TabIndex = 1;
            // 
            // txtRoleCode
            // 
            this.txtRoleCode.Location = new System.Drawing.Point(118, 195);
            this.txtRoleCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRoleCode.Name = "txtRoleCode";
            this.txtRoleCode.Properties.MaxLength = 40;
            this.txtRoleCode.Size = new System.Drawing.Size(327, 24);
            this.txtRoleCode.TabIndex = 330;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(81, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 331;
            this.label5.Text = "Roles";
            // 
            // frmUserDetails
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(464, 235);
            this.ControlBox = false;
            this.Controls.Add(this.txtRoleCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbLoginAs);
            this.Controls.Add(this.txtstatusTag);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUserDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmUserDetails_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmUserDetails_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtstatusTag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtConfirmPassword.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtstatusTag;
        private DevExpress.XtraEditors.LabelControl label12;
        private DevExpress.XtraEditors.TextEdit txtConfirmPassword;
        private DevExpress.XtraEditors.LabelControl label4;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl label1;
        private System.Windows.Forms.ComboBox cmbLoginAs;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.TextEdit txtRoleCode;
        private DevExpress.XtraEditors.LabelControl label5;
    }
}