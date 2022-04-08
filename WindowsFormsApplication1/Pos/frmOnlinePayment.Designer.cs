
namespace WindowsFormsApplication1.Pos
{
    partial class FrmOnlinePayment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOnlinePayment));
            this.btnSaveOnly = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.separatorControl1 = new DevExpress.XtraEditors.SeparatorControl();
            this.btnRevert = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl50 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl49 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl48 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl47 = new DevExpress.XtraEditors.LabelControl();
            this.txtBalanceAmount = new DevExpress.XtraEditors.TextEdit();
            this.txtSLipNo = new DevExpress.XtraEditors.TextEdit();
            this.txtAmountPaid = new DevExpress.XtraEditors.TextEdit();
            this.txtMemoAmount = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl25 = new DevExpress.XtraEditors.LabelControl();
            this.lblMemoDate = new DevExpress.XtraEditors.LabelControl();
            this.lblMemoNo = new DevExpress.XtraEditors.LabelControl();
            this.labelControl24 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtUPID = new DevExpress.XtraEditors.TextEdit();
            this.txtNameOnUPID = new DevExpress.XtraEditors.TextEdit();
            this.txtUPIDMobileNo = new DevExpress.XtraEditors.TextEdit();
            this.txtUPIDType = new DevExpress.XtraEditors.TextEdit();
            this.btnPhonePe = new DevExpress.XtraEditors.SimpleButton();
            this.btnPayTM = new DevExpress.XtraEditors.SimpleButton();
            this.btnGooglePay = new DevExpress.XtraEditors.SimpleButton();
            this.BtnWhatsapp = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalanceAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLipNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountPaid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemoAmount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUPID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameOnUPID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUPIDMobileNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUPIDType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSaveOnly
            // 
            this.btnSaveOnly.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveOnly.ImageOptions.SvgImage")));
            this.btnSaveOnly.Location = new System.Drawing.Point(322, 322);
            this.btnSaveOnly.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveOnly.Name = "btnSaveOnly";
            this.btnSaveOnly.Size = new System.Drawing.Size(84, 47);
            this.btnSaveOnly.TabIndex = 38;
            this.btnSaveOnly.Text = "Save ";
            this.btnSaveOnly.Click += new System.EventHandler(this.BtnSaveOnly_Click);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(106, 196);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(42, 25);
            this.labelControl4.TabIndex = 35;
            this.labelControl4.Text = "UPID";
            this.labelControl4.Visible = false;
            // 
            // separatorControl1
            // 
            this.separatorControl1.BackColor = System.Drawing.Color.Black;
            this.separatorControl1.Location = new System.Drawing.Point(8, 34);
            this.separatorControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.separatorControl1.Name = "separatorControl1";
            this.separatorControl1.Padding = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.separatorControl1.Size = new System.Drawing.Size(689, 5);
            this.separatorControl1.TabIndex = 34;
            // 
            // btnRevert
            // 
            this.btnRevert.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnRevert.ImageOptions.SvgImage")));
            this.btnRevert.Location = new System.Drawing.Point(172, 322);
            this.btnRevert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRevert.Name = "btnRevert";
            this.btnRevert.Size = new System.Drawing.Size(148, 47);
            this.btnRevert.TabIndex = 32;
            this.btnRevert.Text = "Revert";
            this.btnRevert.Click += new System.EventHandler(this.BtnRevert_Click);
            // 
            // btnSave
            // 
            this.btnSave.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSave.ImageOptions.SvgImage")));
            this.btnSave.Location = new System.Drawing.Point(22, 322);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(148, 47);
            this.btnSave.TabIndex = 33;
            this.btnSave.Text = "Save && Print";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl50);
            this.groupControl1.Controls.Add(this.labelControl49);
            this.groupControl1.Controls.Add(this.labelControl48);
            this.groupControl1.Controls.Add(this.labelControl47);
            this.groupControl1.Controls.Add(this.txtBalanceAmount);
            this.groupControl1.Controls.Add(this.txtSLipNo);
            this.groupControl1.Controls.Add(this.txtAmountPaid);
            this.groupControl1.Controls.Add(this.txtMemoAmount);
            this.groupControl1.GroupStyle = DevExpress.Utils.GroupStyle.Light;
            this.groupControl1.Location = new System.Drawing.Point(386, 139);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(300, 173);
            this.groupControl1.TabIndex = 27;
            this.groupControl1.Text = "Memo Info";
            // 
            // labelControl50
            // 
            this.labelControl50.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl50.Appearance.Options.UseFont = true;
            this.labelControl50.Location = new System.Drawing.Point(23, 131);
            this.labelControl50.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl50.Name = "labelControl50";
            this.labelControl50.Size = new System.Drawing.Size(136, 25);
            this.labelControl50.TabIndex = 4;
            this.labelControl50.Text = "Balance Amount";
            // 
            // labelControl49
            // 
            this.labelControl49.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl49.Appearance.Options.UseFont = true;
            this.labelControl49.Location = new System.Drawing.Point(29, 98);
            this.labelControl49.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl49.Name = "labelControl49";
            this.labelControl49.Size = new System.Drawing.Size(130, 25);
            this.labelControl49.TabIndex = 5;
            this.labelControl49.Text = "Transaction No.";
            // 
            // labelControl48
            // 
            this.labelControl48.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl48.Appearance.Options.UseFont = true;
            this.labelControl48.Location = new System.Drawing.Point(50, 63);
            this.labelControl48.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl48.Name = "labelControl48";
            this.labelControl48.Size = new System.Drawing.Size(109, 25);
            this.labelControl48.TabIndex = 6;
            this.labelControl48.Text = "Amount Paid";
            // 
            // labelControl47
            // 
            this.labelControl47.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl47.Appearance.Options.UseFont = true;
            this.labelControl47.Location = new System.Drawing.Point(32, 29);
            this.labelControl47.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl47.Name = "labelControl47";
            this.labelControl47.Size = new System.Drawing.Size(127, 25);
            this.labelControl47.TabIndex = 9;
            this.labelControl47.Text = "Memo Amount";
            // 
            // txtBalanceAmount
            // 
            this.txtBalanceAmount.EditValue = "0";
            this.txtBalanceAmount.Enabled = false;
            this.txtBalanceAmount.Location = new System.Drawing.Point(161, 128);
            this.txtBalanceAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBalanceAmount.Name = "txtBalanceAmount";
            this.txtBalanceAmount.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBalanceAmount.Properties.Appearance.Options.UseFont = true;
            this.txtBalanceAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtBalanceAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtBalanceAmount.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtBalanceAmount.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtBalanceAmount.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtBalanceAmount.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtBalanceAmount.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtBalanceAmount.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtBalanceAmount.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtBalanceAmount.Properties.DisplayFormat.FormatString = "n2";
            this.txtBalanceAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBalanceAmount.Properties.EditFormat.FormatString = "n2";
            this.txtBalanceAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtBalanceAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtBalanceAmount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtBalanceAmount.Properties.MaskSettings.Set("mask", "n2");
            this.txtBalanceAmount.Size = new System.Drawing.Size(133, 28);
            this.txtBalanceAmount.TabIndex = 10;
            // 
            // txtSLipNo
            // 
            this.txtSLipNo.Location = new System.Drawing.Point(161, 94);
            this.txtSLipNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSLipNo.Name = "txtSLipNo";
            this.txtSLipNo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLipNo.Properties.Appearance.Options.UseFont = true;
            this.txtSLipNo.Properties.Appearance.Options.UseTextOptions = true;
            this.txtSLipNo.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSLipNo.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtSLipNo.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSLipNo.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtSLipNo.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSLipNo.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtSLipNo.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtSLipNo.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtSLipNo.Size = new System.Drawing.Size(133, 28);
            this.txtSLipNo.TabIndex = 11;
            // 
            // txtAmountPaid
            // 
            this.txtAmountPaid.EditValue = "0";
            this.txtAmountPaid.Location = new System.Drawing.Point(161, 60);
            this.txtAmountPaid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAmountPaid.Name = "txtAmountPaid";
            this.txtAmountPaid.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPaid.Properties.Appearance.Options.UseFont = true;
            this.txtAmountPaid.Properties.Appearance.Options.UseTextOptions = true;
            this.txtAmountPaid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAmountPaid.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtAmountPaid.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAmountPaid.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtAmountPaid.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAmountPaid.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtAmountPaid.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtAmountPaid.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtAmountPaid.Properties.DisplayFormat.FormatString = "n2";
            this.txtAmountPaid.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAmountPaid.Properties.EditFormat.FormatString = "n2";
            this.txtAmountPaid.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtAmountPaid.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtAmountPaid.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtAmountPaid.Properties.MaskSettings.Set("mask", "n2");
            this.txtAmountPaid.Size = new System.Drawing.Size(133, 28);
            this.txtAmountPaid.TabIndex = 12;
            // 
            // txtMemoAmount
            // 
            this.txtMemoAmount.EditValue = "0";
            this.txtMemoAmount.Location = new System.Drawing.Point(161, 26);
            this.txtMemoAmount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMemoAmount.Name = "txtMemoAmount";
            this.txtMemoAmount.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMemoAmount.Properties.Appearance.Options.UseFont = true;
            this.txtMemoAmount.Properties.Appearance.Options.UseTextOptions = true;
            this.txtMemoAmount.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMemoAmount.Properties.AppearanceDisabled.Options.UseTextOptions = true;
            this.txtMemoAmount.Properties.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMemoAmount.Properties.AppearanceFocused.Options.UseTextOptions = true;
            this.txtMemoAmount.Properties.AppearanceFocused.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMemoAmount.Properties.AppearanceReadOnly.Options.UseTextOptions = true;
            this.txtMemoAmount.Properties.AppearanceReadOnly.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.txtMemoAmount.Properties.ContextImageOptions.Alignment = DevExpress.XtraEditors.ContextImageAlignment.Far;
            this.txtMemoAmount.Properties.DisplayFormat.FormatString = "n2";
            this.txtMemoAmount.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMemoAmount.Properties.EditFormat.FormatString = "n2";
            this.txtMemoAmount.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.txtMemoAmount.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.txtMemoAmount.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtMemoAmount.Properties.MaskSettings.Set("mask", "n2");
            this.txtMemoAmount.Size = new System.Drawing.Size(133, 28);
            this.txtMemoAmount.TabIndex = 13;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(25, 268);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(123, 25);
            this.labelControl3.TabIndex = 23;
            this.labelControl3.Text = "Name on UPID";
            this.labelControl3.Visible = false;
            // 
            // labelControl25
            // 
            this.labelControl25.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl25.Appearance.Options.UseFont = true;
            this.labelControl25.Location = new System.Drawing.Point(181, 9);
            this.labelControl25.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl25.Name = "labelControl25";
            this.labelControl25.Size = new System.Drawing.Size(115, 25);
            this.labelControl25.TabIndex = 28;
            this.labelControl25.Text = "Memo Dated";
            // 
            // lblMemoDate
            // 
            this.lblMemoDate.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoDate.Appearance.Options.UseFont = true;
            this.lblMemoDate.Location = new System.Drawing.Point(306, 9);
            this.lblMemoDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblMemoDate.Name = "lblMemoDate";
            this.lblMemoDate.Size = new System.Drawing.Size(104, 25);
            this.lblMemoDate.TabIndex = 30;
            this.lblMemoDate.Text = "00/00/0000";
            // 
            // lblMemoNo
            // 
            this.lblMemoNo.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMemoNo.Appearance.Options.UseFont = true;
            this.lblMemoNo.Location = new System.Drawing.Point(112, 9);
            this.lblMemoNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblMemoNo.Name = "lblMemoNo";
            this.lblMemoNo.Size = new System.Drawing.Size(22, 25);
            this.lblMemoNo.TabIndex = 31;
            this.lblMemoNo.Text = "00";
            // 
            // labelControl24
            // 
            this.labelControl24.Appearance.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl24.Appearance.Options.UseFont = true;
            this.labelControl24.Location = new System.Drawing.Point(19, 9);
            this.labelControl24.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl24.Name = "labelControl24";
            this.labelControl24.Size = new System.Drawing.Size(94, 25);
            this.labelControl24.TabIndex = 29;
            this.labelControl24.Text = "Memo No.";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(12, 231);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(136, 25);
            this.labelControl2.TabIndex = 22;
            this.labelControl2.Text = "UPID Mobile No";
            this.labelControl2.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(79, 162);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(69, 25);
            this.labelControl1.TabIndex = 21;
            this.labelControl1.Text = "PG Type";
            // 
            // txtUPID
            // 
            this.txtUPID.Location = new System.Drawing.Point(154, 195);
            this.txtUPID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUPID.Name = "txtUPID";
            this.txtUPID.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUPID.Properties.Appearance.Options.UseFont = true;
            this.txtUPID.Size = new System.Drawing.Size(224, 28);
            this.txtUPID.TabIndex = 36;
            this.txtUPID.Visible = false;
            // 
            // txtNameOnUPID
            // 
            this.txtNameOnUPID.Location = new System.Drawing.Point(154, 265);
            this.txtNameOnUPID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameOnUPID.Name = "txtNameOnUPID";
            this.txtNameOnUPID.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameOnUPID.Properties.Appearance.Options.UseFont = true;
            this.txtNameOnUPID.Size = new System.Drawing.Size(224, 28);
            this.txtNameOnUPID.TabIndex = 25;
            this.txtNameOnUPID.Visible = false;
            // 
            // txtUPIDMobileNo
            // 
            this.txtUPIDMobileNo.Location = new System.Drawing.Point(154, 230);
            this.txtUPIDMobileNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUPIDMobileNo.Name = "txtUPIDMobileNo";
            this.txtUPIDMobileNo.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUPIDMobileNo.Properties.Appearance.Options.UseFont = true;
            this.txtUPIDMobileNo.Size = new System.Drawing.Size(224, 28);
            this.txtUPIDMobileNo.TabIndex = 26;
            this.txtUPIDMobileNo.Visible = false;
            // 
            // txtUPIDType
            // 
            this.txtUPIDType.Location = new System.Drawing.Point(154, 161);
            this.txtUPIDType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUPIDType.Name = "txtUPIDType";
            this.txtUPIDType.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUPIDType.Properties.Appearance.Options.UseFont = true;
            this.txtUPIDType.Size = new System.Drawing.Size(224, 28);
            this.txtUPIDType.TabIndex = 24;
            this.txtUPIDType.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUPIDType_KeyDown);
            // 
            // btnPhonePe
            // 
            this.btnPhonePe.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.phone;
            this.btnPhonePe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPhonePe.Location = new System.Drawing.Point(294, 43);
            this.btnPhonePe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPhonePe.Name = "btnPhonePe";
            this.btnPhonePe.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPhonePe.Size = new System.Drawing.Size(129, 84);
            this.btnPhonePe.TabIndex = 17;
            this.btnPhonePe.Click += new System.EventHandler(this.BtnPhonePe_Click);
            // 
            // btnPayTM
            // 
            this.btnPayTM.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.paytm1;
            this.btnPayTM.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPayTM.Location = new System.Drawing.Point(19, 44);
            this.btnPayTM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPayTM.Name = "btnPayTM";
            this.btnPayTM.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnPayTM.Size = new System.Drawing.Size(129, 82);
            this.btnPayTM.TabIndex = 20;
            this.btnPayTM.Click += new System.EventHandler(this.BtnPayTM_Click);
            // 
            // btnGooglePay
            // 
            this.btnGooglePay.BackgroundImage = global::WindowsFormsApplication1.Properties.Resources.google1;
            this.btnGooglePay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGooglePay.Location = new System.Drawing.Point(157, 43);
            this.btnGooglePay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnGooglePay.Name = "btnGooglePay";
            this.btnGooglePay.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGooglePay.Size = new System.Drawing.Size(129, 84);
            this.btnGooglePay.TabIndex = 16;
            this.btnGooglePay.Click += new System.EventHandler(this.BtnGooglePay_Click);
            // 
            // BtnWhatsapp
            // 
            this.BtnWhatsapp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnWhatsapp.ImageOptions.Image")));
            this.BtnWhatsapp.Location = new System.Drawing.Point(408, 322);
            this.BtnWhatsapp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnWhatsapp.Name = "BtnWhatsapp";
            this.BtnWhatsapp.Size = new System.Drawing.Size(123, 47);
            this.BtnWhatsapp.TabIndex = 39;
            this.BtnWhatsapp.Text = "Whatsapp";
            this.BtnWhatsapp.Click += new System.EventHandler(this.BtnWhatsapp_Click);
            // 
            // FrmOnlinePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(712, 384);
            this.ControlBox = false;
            this.Controls.Add(this.BtnWhatsapp);
            this.Controls.Add(this.btnSaveOnly);
            this.Controls.Add(this.txtUPID);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.separatorControl1);
            this.Controls.Add(this.btnRevert);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtNameOnUPID);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl25);
            this.Controls.Add(this.lblMemoDate);
            this.Controls.Add(this.txtUPIDMobileNo);
            this.Controls.Add(this.lblMemoNo);
            this.Controls.Add(this.labelControl24);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtUPIDType);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.btnPhonePe);
            this.Controls.Add(this.btnPayTM);
            this.Controls.Add(this.btnGooglePay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmOnlinePayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmOnlinePayment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.separatorControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBalanceAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSLipNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmountPaid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMemoAmount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUPID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNameOnUPID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUPIDMobileNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUPIDType.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnSaveOnly;
        private DevExpress.XtraEditors.TextEdit txtUPID;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SeparatorControl separatorControl1;
        private DevExpress.XtraEditors.SimpleButton btnRevert;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl50;
        private DevExpress.XtraEditors.LabelControl labelControl49;
        private DevExpress.XtraEditors.LabelControl labelControl48;
        private DevExpress.XtraEditors.LabelControl labelControl47;
        private DevExpress.XtraEditors.TextEdit txtBalanceAmount;
        private DevExpress.XtraEditors.TextEdit txtSLipNo;
        private DevExpress.XtraEditors.TextEdit txtAmountPaid;
        private DevExpress.XtraEditors.TextEdit txtMemoAmount;
        private DevExpress.XtraEditors.TextEdit txtNameOnUPID;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl25;
        private DevExpress.XtraEditors.LabelControl lblMemoDate;
        private DevExpress.XtraEditors.TextEdit txtUPIDMobileNo;
        private DevExpress.XtraEditors.LabelControl lblMemoNo;
        private DevExpress.XtraEditors.LabelControl labelControl24;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtUPIDType;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnPhonePe;
        private DevExpress.XtraEditors.SimpleButton btnPayTM;
        private DevExpress.XtraEditors.SimpleButton btnGooglePay;
        private DevExpress.XtraEditors.SimpleButton BtnWhatsapp;
    }
}