
namespace WindowsFormsApplication1.Master
{
    partial class FrmContractorMst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmContractorMst));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtIDNo = new DevExpress.XtraEditors.TextEdit();
            this.txtIDType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtOtherNo = new DevExpress.XtraEditors.TextEdit();
            this.txtContCode = new DevExpress.XtraEditors.TextEdit();
            this.Label3 = new DevExpress.XtraEditors.LabelControl();
            this.txtEMailId = new DevExpress.XtraEditors.TextEdit();
            this.txtMobileNo = new DevExpress.XtraEditors.TextEdit();
            this.Label4 = new DevExpress.XtraEditors.LabelControl();
            this.txtContName = new DevExpress.XtraEditors.TextEdit();
            this.LBDEPNAME = new DevExpress.XtraEditors.LabelControl();
            this.Label7 = new DevExpress.XtraEditors.LabelControl();
            this.LBDEPCODE = new DevExpress.XtraEditors.LabelControl();
            this.Label6 = new DevExpress.XtraEditors.LabelControl();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMailId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContName.Properties)).BeginInit();
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(604, 31);
            this.Menu_ToolStrip.TabIndex = 746;
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
            // txtIDNo
            // 
            this.txtIDNo.EnterMoveNextControl = true;
            this.txtIDNo.Location = new System.Drawing.Point(399, 179);
            this.txtIDNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDNo.Name = "txtIDNo";
            this.txtIDNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtIDNo.Size = new System.Drawing.Size(183, 22);
            this.txtIDNo.TabIndex = 770;
            // 
            // txtIDType
            // 
            this.txtIDType.Location = new System.Drawing.Point(104, 179);
            this.txtIDType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtIDType.Name = "txtIDType";
            this.txtIDType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtIDType.Properties.Items.AddRange(new object[] {
            "N/A",
            "AADHAR ID",
            "VOTER ID",
            "PASSPORT",
            "OTHER ID",
            "LISCENSE"});
            this.txtIDType.Size = new System.Drawing.Size(199, 22);
            this.txtIDType.TabIndex = 769;
            // 
            // txtOtherNo
            // 
            this.txtOtherNo.EnterMoveNextControl = true;
            this.txtOtherNo.Location = new System.Drawing.Point(399, 111);
            this.txtOtherNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOtherNo.Name = "txtOtherNo";
            this.txtOtherNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOtherNo.Size = new System.Drawing.Size(183, 22);
            this.txtOtherNo.TabIndex = 767;
            // 
            // txtContCode
            // 
            this.txtContCode.Enabled = false;
            this.txtContCode.EnterMoveNextControl = true;
            this.txtContCode.Location = new System.Drawing.Point(104, 43);
            this.txtContCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContCode.Name = "txtContCode";
            this.txtContCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContCode.Properties.MaxLength = 8;
            this.txtContCode.Size = new System.Drawing.Size(86, 22);
            this.txtContCode.TabIndex = 760;
            this.txtContCode.TabStop = false;
            // 
            // Label3
            // 
            this.Label3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label3.Appearance.Options.UseFont = true;
            this.Label3.Location = new System.Drawing.Point(37, 148);
            this.Label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(65, 19);
            this.Label3.TabIndex = 757;
            this.Label3.Text = "EMAIL ID :";
            // 
            // txtEMailId
            // 
            this.txtEMailId.EnterMoveNextControl = true;
            this.txtEMailId.Location = new System.Drawing.Point(104, 145);
            this.txtEMailId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEMailId.Name = "txtEMailId";
            this.txtEMailId.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEMailId.Size = new System.Drawing.Size(478, 22);
            this.txtEMailId.TabIndex = 765;
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.EnterMoveNextControl = true;
            this.txtMobileNo.Location = new System.Drawing.Point(104, 111);
            this.txtMobileNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMobileNo.Size = new System.Drawing.Size(199, 22);
            this.txtMobileNo.TabIndex = 764;
            // 
            // Label4
            // 
            this.Label4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label4.Appearance.Options.UseFont = true;
            this.Label4.Location = new System.Drawing.Point(319, 114);
            this.Label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(78, 19);
            this.Label4.TabIndex = 758;
            this.Label4.Text = "OTHER NO :";
            // 
            // txtContName
            // 
            this.txtContName.EnterMoveNextControl = true;
            this.txtContName.Location = new System.Drawing.Point(104, 77);
            this.txtContName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtContName.Name = "txtContName";
            this.txtContName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtContName.Size = new System.Drawing.Size(478, 22);
            this.txtContName.TabIndex = 763;
            // 
            // LBDEPNAME
            // 
            this.LBDEPNAME.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.LBDEPNAME.Appearance.Options.UseFont = true;
            this.LBDEPNAME.Location = new System.Drawing.Point(55, 80);
            this.LBDEPNAME.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LBDEPNAME.Name = "LBDEPNAME";
            this.LBDEPNAME.Size = new System.Drawing.Size(47, 19);
            this.LBDEPNAME.TabIndex = 755;
            this.LBDEPNAME.Text = "NAME :";
            // 
            // Label7
            // 
            this.Label7.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label7.Appearance.Options.UseFont = true;
            this.Label7.Location = new System.Drawing.Point(3, 182);
            this.Label7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(99, 19);
            this.Label7.TabIndex = 754;
            this.Label7.Text = "ID TYPE && NO. :";
            // 
            // LBDEPCODE
            // 
            this.LBDEPCODE.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.LBDEPCODE.Appearance.Options.UseFont = true;
            this.LBDEPCODE.Location = new System.Drawing.Point(58, 46);
            this.LBDEPCODE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LBDEPCODE.Name = "LBDEPCODE";
            this.LBDEPCODE.Size = new System.Drawing.Size(44, 19);
            this.LBDEPCODE.TabIndex = 756;
            this.LBDEPCODE.Text = "CODE :";
            // 
            // Label6
            // 
            this.Label6.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold);
            this.Label6.Appearance.Options.UseFont = true;
            this.Label6.Location = new System.Drawing.Point(19, 114);
            this.Label6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(83, 19);
            this.Label6.TabIndex = 753;
            this.Label6.Text = "MOBILE NO :";
            // 
            // frmContractorMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(604, 228);
            this.ControlBox = false;
            this.Controls.Add(this.txtIDNo);
            this.Controls.Add(this.txtIDType);
            this.Controls.Add(this.txtOtherNo);
            this.Controls.Add(this.txtContCode);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txtEMailId);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txtContName);
            this.Controls.Add(this.LBDEPNAME);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.LBDEPCODE);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Menu_ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmContractorMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmContractorMst_Load);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOtherNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEMailId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMobileNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtContName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtIDNo;
        private DevExpress.XtraEditors.ComboBoxEdit txtIDType;
        private DevExpress.XtraEditors.TextEdit txtOtherNo;
        private DevExpress.XtraEditors.TextEdit txtContCode;
        internal DevExpress.XtraEditors.LabelControl Label3;
        private DevExpress.XtraEditors.TextEdit txtEMailId;
        private DevExpress.XtraEditors.TextEdit txtMobileNo;
        internal DevExpress.XtraEditors.LabelControl Label4;
        private DevExpress.XtraEditors.TextEdit txtContName;
        internal DevExpress.XtraEditors.LabelControl LBDEPNAME;
        internal DevExpress.XtraEditors.LabelControl Label7;
        internal DevExpress.XtraEditors.LabelControl LBDEPCODE;
        internal DevExpress.XtraEditors.LabelControl Label6;
    }
}