
namespace WindowsFormsApplication1.Administration
{
    partial class frmAPIIntegrationInfo
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAPIIntegrationInfo));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.svgImageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.imageCollection1 = new DevExpress.Utils.SvgImageCollection(this.components);
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtASPPassword = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new DevExpress.XtraEditors.LabelControl();
            this.txtTransId = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new DevExpress.XtraEditors.LabelControl();
            this.txtGSPName = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new DevExpress.XtraEditors.LabelControl();
            this.txtASPNetUser = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.txtBaseUrl = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtEWBGSTIN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtEWBUserID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEWBPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtstatusTag = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtASPPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGSPName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtASPNetUser.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseUrl.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEWBGSTIN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEWBUserID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEWBPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstatusTag.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(668, 31);
            this.Menu_ToolStrip.TabIndex = 423;
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
            // txtASPPassword
            // 
            this.txtASPPassword.Location = new System.Drawing.Point(102, 150);
            this.txtASPPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtASPPassword.Name = "txtASPPassword";
            this.txtASPPassword.Size = new System.Drawing.Size(540, 24);
            this.txtASPPassword.TabIndex = 411;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(18, 153);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 421;
            this.label11.Text = "ASPPassword";
            // 
            // txtTransId
            // 
            this.txtTransId.EnterMoveNextControl = true;
            this.txtTransId.Location = new System.Drawing.Point(102, 44);
            this.txtTransId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTransId.Name = "txtTransId";
            this.txtTransId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTransId.Properties.MaxLength = 8;
            this.txtTransId.Size = new System.Drawing.Size(159, 24);
            this.txtTransId.TabIndex = 407;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(52, 47);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 17);
            this.label9.TabIndex = 419;
            this.label9.Text = "TransID";
            // 
            // txtGSPName
            // 
            this.txtGSPName.EnterMoveNextControl = true;
            this.txtGSPName.Location = new System.Drawing.Point(102, 79);
            this.txtGSPName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGSPName.Name = "txtGSPName";
            this.txtGSPName.Properties.MaxLength = 150;
            this.txtGSPName.Size = new System.Drawing.Size(540, 24);
            this.txtGSPName.TabIndex = 409;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(38, 82);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 17);
            this.label8.TabIndex = 418;
            this.label8.Text = "GSPName";
            // 
            // txtASPNetUser
            // 
            this.txtASPNetUser.Location = new System.Drawing.Point(102, 114);
            this.txtASPNetUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtASPNetUser.Name = "txtASPNetUser";
            this.txtASPNetUser.Size = new System.Drawing.Size(540, 24);
            this.txtASPNetUser.TabIndex = 410;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(26, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 17);
            this.label7.TabIndex = 417;
            this.label7.Text = "ASPNetUser";
            // 
            // txtBaseUrl
            // 
            this.txtBaseUrl.Location = new System.Drawing.Point(102, 184);
            this.txtBaseUrl.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBaseUrl.Name = "txtBaseUrl";
            this.txtBaseUrl.Size = new System.Drawing.Size(540, 24);
            this.txtBaseUrl.TabIndex = 424;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(52, 187);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(44, 17);
            this.labelControl1.TabIndex = 425;
            this.labelControl1.Text = "BaseUrl";
            // 
            // txtEWBGSTIN
            // 
            this.txtEWBGSTIN.Location = new System.Drawing.Point(102, 218);
            this.txtEWBGSTIN.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEWBGSTIN.Name = "txtEWBGSTIN";
            this.txtEWBGSTIN.Size = new System.Drawing.Size(540, 24);
            this.txtEWBGSTIN.TabIndex = 426;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(34, 221);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(62, 17);
            this.labelControl2.TabIndex = 427;
            this.labelControl2.Text = "EWBGSTIN";
            // 
            // txtEWBUserID
            // 
            this.txtEWBUserID.Location = new System.Drawing.Point(102, 252);
            this.txtEWBUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEWBUserID.Name = "txtEWBUserID";
            this.txtEWBUserID.Size = new System.Drawing.Size(540, 24);
            this.txtEWBUserID.TabIndex = 428;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(31, 255);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(65, 17);
            this.labelControl3.TabIndex = 429;
            this.labelControl3.Text = "EWBUserID";
            // 
            // txtEWBPassword
            // 
            this.txtEWBPassword.Location = new System.Drawing.Point(102, 286);
            this.txtEWBPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEWBPassword.Name = "txtEWBPassword";
            this.txtEWBPassword.Size = new System.Drawing.Size(540, 24);
            this.txtEWBPassword.TabIndex = 430;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 289);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(82, 17);
            this.labelControl4.TabIndex = 431;
            this.labelControl4.Text = "EWBPassword";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(62, 325);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(34, 17);
            this.labelControl5.TabIndex = 433;
            this.labelControl5.Text = "Active";
            // 
            // txtstatusTag
            // 
            this.txtstatusTag.Location = new System.Drawing.Point(102, 321);
            this.txtstatusTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtstatusTag.Name = "txtstatusTag";
            this.txtstatusTag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtstatusTag.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtstatusTag.Properties.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.txtstatusTag.Properties.MaxLength = 1;
            this.txtstatusTag.Size = new System.Drawing.Size(48, 24);
            this.txtstatusTag.TabIndex = 434;
            // 
            // frmAPIIntergrationInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 364);
            this.ControlBox = false;
            this.Controls.Add(this.txtstatusTag);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtEWBPassword);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtEWBUserID);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtEWBGSTIN);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtBaseUrl);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtASPPassword);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTransId);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtGSPName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtASPNetUser);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAPIIntergrationInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmAPIIntergrationInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageCollection1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageCollection1)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtASPPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTransId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGSPName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtASPNetUser.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBaseUrl.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEWBGSTIN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEWBUserID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEWBPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstatusTag.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.Utils.SvgImageCollection svgImageCollection1;
        private DevExpress.Utils.SvgImageCollection imageCollection1;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtASPPassword;
        private DevExpress.XtraEditors.LabelControl label11;
        private DevExpress.XtraEditors.TextEdit txtTransId;
        private DevExpress.XtraEditors.LabelControl label9;
        private DevExpress.XtraEditors.TextEdit txtGSPName;
        private DevExpress.XtraEditors.LabelControl label8;
        private DevExpress.XtraEditors.TextEdit txtASPNetUser;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.TextEdit txtBaseUrl;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtEWBGSTIN;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtEWBUserID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtEWBPassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.ComboBoxEdit txtstatusTag;
    }
}