
namespace WindowsFormsApplication1.Master
{
    partial class frmServer
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtServerName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtLoginType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDataBaseName = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtUserName = new DevExpress.XtraEditors.TextEdit();
            this.txtPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.btnTestConnection = new DevExpress.XtraEditors.SimpleButton();
            this.btnConnect = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBaseName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(117, 78);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(76, 17);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Server Name";
            // 
            // txtServerName
            // 
            this.txtServerName.Location = new System.Drawing.Point(211, 75);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtServerName.Size = new System.Drawing.Size(328, 24);
            this.txtServerName.TabIndex = 1;
            // 
            // txtLoginType
            // 
            this.txtLoginType.Location = new System.Drawing.Point(211, 105);
            this.txtLoginType.Name = "txtLoginType";
            this.txtLoginType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtLoginType.Properties.Items.AddRange(new object[] {
            "WINDOW",
            "SQLSERVER"});
            this.txtLoginType.Size = new System.Drawing.Size(328, 24);
            this.txtLoginType.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(117, 108);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(64, 17);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Login Type";
            // 
            // txtDataBaseName
            // 
            this.txtDataBaseName.Location = new System.Drawing.Point(211, 135);
            this.txtDataBaseName.Name = "txtDataBaseName";
            this.txtDataBaseName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtDataBaseName.Properties.Items.AddRange(new object[] {
            "WINDOW",
            "SQLSERVER"});
            this.txtDataBaseName.Size = new System.Drawing.Size(328, 24);
            this.txtDataBaseName.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(117, 138);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(55, 17);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Database";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(211, 165);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(328, 24);
            this.txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(211, 199);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Properties.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(328, 24);
            this.txtPassword.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(117, 168);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(59, 17);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Username";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(117, 202);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(56, 17);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Password";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Location = new System.Drawing.Point(268, 264);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(123, 29);
            this.btnTestConnection.TabIndex = 10;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(445, 264);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 29);
            this.btnConnect.TabIndex = 11;
            this.btnConnect.Text = "Connect";
            // 
            // frmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(668, 350);
            this.ControlBox = false;
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.btnTestConnection);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.txtDataBaseName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtLoginType);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            ((System.ComponentModel.ISupportInitialize)(this.txtServerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtLoginType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDataBaseName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtUserName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit txtServerName;
        private DevExpress.XtraEditors.ComboBoxEdit txtLoginType;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.ComboBoxEdit txtDataBaseName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtUserName;
        private DevExpress.XtraEditors.TextEdit txtPassword;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton btnTestConnection;
        private DevExpress.XtraEditors.SimpleButton btnConnect;
    }
}