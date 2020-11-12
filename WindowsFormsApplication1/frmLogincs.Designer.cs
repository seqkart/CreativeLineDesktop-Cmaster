namespace WindowsFormsApplication1
{
    partial class FrmLogins
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogins));
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnLogin = new DevExpress.XtraEditors.SimpleButton();
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.dTP1 = new System.Windows.Forms.DateTimePicker();
            this.txtCompany = new System.Windows.Forms.ComboBox();
            this.txtUnit = new System.Windows.Forms.ComboBox();
            this.txtFNYear = new System.Windows.Forms.ComboBox();
            this.btnBackup = new DevExpress.XtraEditors.SimpleButton();
            this.stepProgressBarItem1 = new DevExpress.XtraEditors.StepProgressBarItem();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.label8 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUserName
            // 
            this.txtUserName.EnterMoveNextControl = true;
            this.txtUserName.Location = new System.Drawing.Point(165, 19);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtUserName.Properties.Appearance.Options.UseFont = true;
            this.txtUserName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUserName.Properties.MaxLength = 30;
            this.txtUserName.Size = new System.Drawing.Size(229, 22);
            this.txtUserName.TabIndex = 0;
            this.txtUserName.DoubleClick += new System.EventHandler(this.TxtUserName_DoubleClick);
            this.txtUserName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUserName_KeyDown);
            // 
            // label3
            // 
            this.label3.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Appearance.Options.UseBackColor = true;
            this.label3.Appearance.Options.UseFont = true;
            this.label3.Location = new System.Drawing.Point(128, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Login";
            // 
            // txtPassword
            // 
            this.txtPassword.EnterMoveNextControl = true;
            this.txtPassword.Location = new System.Drawing.Point(165, 46);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Properties.Appearance.Options.UseFont = true;
            this.txtPassword.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPassword.Properties.MaxLength = 30;
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(229, 22);
            this.txtPassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Appearance.Options.UseBackColor = true;
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Location = new System.Drawing.Point(108, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 23;
            this.label1.Text = "Password";
            // 
            // btnClose
            // 
            this.btnClose.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnClose.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnClose.Appearance.Options.UseBackColor = true;
            this.btnClose.Appearance.Options.UseFont = true;
            this.btnClose.Appearance.Options.UseForeColor = true;
            this.btnClose.Location = new System.Drawing.Point(256, 237);
            this.btnClose.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnClose.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(85, 23);
            this.btnClose.TabIndex = 45;
            this.btnClose.Text = "Exit";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogin.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.btnLogin.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Appearance.Options.UseBackColor = true;
            this.btnLogin.Appearance.Options.UseFont = true;
            this.btnLogin.Appearance.Options.UseForeColor = true;
            this.btnLogin.Location = new System.Drawing.Point(165, 237);
            this.btnLogin.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnLogin.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(85, 23);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2019 Colorful";
            // 
            // label2
            // 
            this.label2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Appearance.Options.UseBackColor = true;
            this.label2.Appearance.Options.UseFont = true;
            this.label2.Location = new System.Drawing.Point(107, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Company";
            // 
            // label4
            // 
            this.label4.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Appearance.Options.UseBackColor = true;
            this.label4.Appearance.Options.UseFont = true;
            this.label4.Location = new System.Drawing.Point(136, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 15);
            this.label4.TabIndex = 23;
            this.label4.Text = "Unit";
            // 
            // label5
            // 
            this.label5.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Appearance.Options.UseBackColor = true;
            this.label5.Appearance.Options.UseFont = true;
            this.label5.Location = new System.Drawing.Point(85, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Financial Year";
            // 
            // label6
            // 
            this.label6.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label6.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Appearance.Options.UseBackColor = true;
            this.label6.Appearance.Options.UseFont = true;
            this.label6.Location = new System.Drawing.Point(100, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "Login Date";
            // 
            // dTP1
            // 
            this.dTP1.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.dTP1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.dTP1.Location = new System.Drawing.Point(165, 206);
            this.dTP1.Margin = new System.Windows.Forms.Padding(0);
            this.dTP1.MinDate = new System.DateTime(2015, 1, 1, 0, 0, 0, 0);
            this.dTP1.Name = "dTP1";
            this.dTP1.Size = new System.Drawing.Size(229, 23);
            this.dTP1.TabIndex = 55;
            this.dTP1.Value = new System.DateTime(2020, 9, 9, 17, 48, 0, 0);
            // 
            // txtCompany
            // 
            this.txtCompany.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCompany.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtCompany.FormattingEnabled = true;
            this.txtCompany.Location = new System.Drawing.Point(165, 122);
            this.txtCompany.Name = "txtCompany";
            this.txtCompany.Size = new System.Drawing.Size(229, 23);
            this.txtCompany.TabIndex = 2;
            this.txtCompany.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCompany_KeyDown);
            // 
            // txtUnit
            // 
            this.txtUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtUnit.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtUnit.FormattingEnabled = true;
            this.txtUnit.Location = new System.Drawing.Point(165, 150);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(229, 23);
            this.txtUnit.TabIndex = 3;
            this.txtUnit.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtUnit_KeyDown);
            // 
            // txtFNYear
            // 
            this.txtFNYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFNYear.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.txtFNYear.FormattingEnabled = true;
            this.txtFNYear.Location = new System.Drawing.Point(165, 178);
            this.txtFNYear.Name = "txtFNYear";
            this.txtFNYear.Size = new System.Drawing.Size(229, 23);
            this.txtFNYear.TabIndex = 4;
            this.txtFNYear.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtFNYear_KeyDown);
            // 
            // btnBackup
            // 
            this.btnBackup.Appearance.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnBackup.Appearance.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.btnBackup.Appearance.ForeColor = System.Drawing.Color.White;
            this.btnBackup.Appearance.Options.UseBackColor = true;
            this.btnBackup.Appearance.Options.UseFont = true;
            this.btnBackup.Appearance.Options.UseForeColor = true;
            this.btnBackup.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnBackup.ImageOptions.SvgImage")));
            this.btnBackup.Location = new System.Drawing.Point(21, 249);
            this.btnBackup.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.btnBackup.LookAndFeel.UseDefaultLookAndFeel = false;
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(83, 39);
            this.btnBackup.TabIndex = 56;
            this.btnBackup.Text = "BackUp";
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // stepProgressBarItem1
            // 
            this.stepProgressBarItem1.ContentBlock2.Caption = "Item1";
            this.stepProgressBarItem1.Name = "stepProgressBarItem1";
            // 
            // textEdit1
            // 
            this.textEdit1.EnterMoveNextControl = true;
            this.textEdit1.Location = new System.Drawing.Point(165, 95);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.textEdit1.Properties.Appearance.Options.UseFont = true;
            this.textEdit1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textEdit1.Properties.MaxLength = 30;
            this.textEdit1.Properties.PasswordChar = '*';
            this.textEdit1.Size = new System.Drawing.Size(136, 22);
            this.textEdit1.TabIndex = 57;
            // 
            // label7
            // 
            this.label7.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label7.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Appearance.Options.UseBackColor = true;
            this.label7.Appearance.Options.UseFont = true;
            this.label7.Location = new System.Drawing.Point(135, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(23, 15);
            this.label7.TabIndex = 58;
            this.label7.Text = "OTP";
            // 
            // label8
            // 
            this.label8.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.label8.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Appearance.Options.UseBackColor = true;
            this.label8.Appearance.Options.UseFont = true;
            this.label8.Location = new System.Drawing.Point(265, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 15);
            this.label8.TabIndex = 59;
            this.label8.Text = "OR";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.ForeColor = System.Drawing.Color.Black;
            this.simpleButton1.Appearance.Options.UseBackColor = true;
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.Appearance.Options.UseForeColor = true;
            this.simpleButton1.Location = new System.Drawing.Point(309, 95);
            this.simpleButton1.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
            this.simpleButton1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(85, 23);
            this.simpleButton1.TabIndex = 60;
            this.simpleButton1.Text = "Send OTP";
            // 
            // FrmLogins
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::WindowsFormsApplication1.Properties.Resources.login;
            this.ClientSize = new System.Drawing.Size(551, 299);
            this.ControlBox = false;
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textEdit1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.txtFNYear);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtCompany);
            this.Controls.Add(this.dTP1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmLogins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmLogincs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnLogin;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label6;
        private System.Windows.Forms.DateTimePicker dTP1;
        private System.Windows.Forms.ComboBox txtCompany;
        private System.Windows.Forms.ComboBox txtUnit;
        private System.Windows.Forms.ComboBox txtFNYear;
        private DevExpress.XtraEditors.SimpleButton btnBackup;
        private DevExpress.XtraEditors.StepProgressBarItem stepProgressBarItem1;
        private DevExpress.XtraEditors.TextEdit textEdit1;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.LabelControl label8;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}