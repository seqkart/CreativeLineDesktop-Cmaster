namespace WindowsFormsApplication1.Master
{
    partial class frmBranchMst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBranchMst));
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtBranchName = new DevExpress.XtraEditors.TextEdit();
            this.txtBranchCode = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtCityCode = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.txtCityName = new DevExpress.XtraEditors.TextEdit();
            this.txtAccCode = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAccName = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress1 = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress2 = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.txtAddress3 = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.txtGSTNo = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new DevExpress.XtraEditors.LabelControl();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtStatusTag = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.txtState = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGSTNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusTag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtState.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpGrid
            // 
            this.HelpGrid.Location = new System.Drawing.Point(183, 46);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(350, 221);
            this.HelpGrid.TabIndex = 418;
            this.HelpGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HelpGridView});
            this.HelpGrid.Visible = false;
            this.HelpGrid.DoubleClick += new System.EventHandler(this.HelpGrid_DoubleClick);
            this.HelpGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HelpGrid_KeyDown);
            // 
            // HelpGridView
            // 
            this.HelpGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.HelpGridView.GridControl = this.HelpGrid;
            this.HelpGridView.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            this.HelpGridView.Name = "HelpGridView";
            this.HelpGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.HelpGridView.OptionsBehavior.Editable = false;
            this.HelpGridView.OptionsView.ShowGroupPanel = false;
            this.HelpGridView.OptionsView.ShowIndicator = false;
            this.HelpGridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(236)))), ((int)(((byte)(239)))));
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(635, 25);
            this.Menu_ToolStrip.TabIndex = 417;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(35, 22);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(38, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtBranchName
            // 
            this.txtBranchName.EnterMoveNextControl = true;
            this.txtBranchName.Location = new System.Drawing.Point(89, 91);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBranchName.Properties.MaxLength = 30;
            this.txtBranchName.Size = new System.Drawing.Size(325, 20);
            this.txtBranchName.TabIndex = 413;
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.Location = new System.Drawing.Point(89, 65);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBranchCode.Size = new System.Drawing.Size(56, 20);
            this.txtBranchCode.TabIndex = 414;
            this.txtBranchCode.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(10, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 416;
            this.label3.Text = "Branch Name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 415;
            this.label1.Text = "Branch Code";
            // 
            // txtCityCode
            // 
            this.txtCityCode.EnterMoveNextControl = true;
            this.txtCityCode.Location = new System.Drawing.Point(89, 195);
            this.txtCityCode.Name = "txtCityCode";
            this.txtCityCode.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.txtCityCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtCityCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCityCode.Properties.MaxLength = 4;
            this.txtCityCode.Size = new System.Drawing.Size(69, 20);
            this.txtCityCode.TabIndex = 422;
            this.txtCityCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCityCode_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 424;
            this.label2.Text = "Under City";
            // 
            // txtCityName
            // 
            this.txtCityName.Enabled = false;
            this.txtCityName.Location = new System.Drawing.Point(167, 195);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCityName.Properties.ReadOnly = true;
            this.txtCityName.Size = new System.Drawing.Size(247, 20);
            this.txtCityName.TabIndex = 423;
            this.txtCityName.TabStop = false;
            // 
            // txtAccCode
            // 
            this.txtAccCode.EnterMoveNextControl = true;
            this.txtAccCode.Location = new System.Drawing.Point(89, 247);
            this.txtAccCode.Name = "txtAccCode";
            this.txtAccCode.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.txtAccCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtAccCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAccCode.Properties.MaxLength = 4;
            this.txtAccCode.Size = new System.Drawing.Size(69, 20);
            this.txtAccCode.TabIndex = 425;
            this.txtAccCode.EditValueChanged += new System.EventHandler(this.txtAccCode_EditValueChanged);
            this.txtAccCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAccCode_KeyDown);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(33, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 427;
            this.label4.Text = "AccCode";
            // 
            // txtAccName
            // 
            this.txtAccName.Location = new System.Drawing.Point(167, 247);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAccName.Properties.ReadOnly = true;
            this.txtAccName.Size = new System.Drawing.Size(247, 20);
            this.txtAccName.TabIndex = 426;
            this.txtAccName.TabStop = false;
            // 
            // txtAddress1
            // 
            this.txtAddress1.EnterMoveNextControl = true;
            this.txtAddress1.Location = new System.Drawing.Point(89, 117);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress1.Properties.MaxLength = 30;
            this.txtAddress1.Size = new System.Drawing.Size(325, 20);
            this.txtAddress1.TabIndex = 428;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(30, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 429;
            this.label5.Text = "Address1";
            // 
            // txtAddress2
            // 
            this.txtAddress2.EnterMoveNextControl = true;
            this.txtAddress2.Location = new System.Drawing.Point(89, 143);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress2.Properties.MaxLength = 30;
            this.txtAddress2.Size = new System.Drawing.Size(325, 20);
            this.txtAddress2.TabIndex = 430;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(30, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 431;
            this.label6.Text = "Address2";
            // 
            // txtAddress3
            // 
            this.txtAddress3.EnterMoveNextControl = true;
            this.txtAddress3.Location = new System.Drawing.Point(89, 169);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress3.Properties.MaxLength = 30;
            this.txtAddress3.Size = new System.Drawing.Size(325, 20);
            this.txtAddress3.TabIndex = 432;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(30, 172);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 433;
            this.label7.Text = "Address3";
            // 
            // txtGSTNo
            // 
            this.txtGSTNo.EnterMoveNextControl = true;
            this.txtGSTNo.Location = new System.Drawing.Point(89, 273);
            this.txtGSTNo.Name = "txtGSTNo";
            this.txtGSTNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGSTNo.Properties.MaxLength = 30;
            this.txtGSTNo.Size = new System.Drawing.Size(325, 20);
            this.txtGSTNo.TabIndex = 434;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(39, 276);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 435;
            this.label8.Text = "GST No";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(580, 87);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(41, 20);
            this.comboBoxEdit1.TabIndex = 466;
            // 
            // txtStatusTag
            // 
            this.txtStatusTag.Location = new System.Drawing.Point(482, 87);
            this.txtStatusTag.Name = "txtStatusTag";
            this.txtStatusTag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStatusTag.Properties.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.txtStatusTag.Size = new System.Drawing.Size(41, 20);
            this.txtStatusTag.TabIndex = 467;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(539, 91);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(35, 13);
            this.labelControl10.TabIndex = 462;
            this.labelControl10.Text = "IS \'HO\'";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(425, 91);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(51, 13);
            this.labelControl7.TabIndex = 463;
            this.labelControl7.Text = "THIS UNIT";
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(520, 110);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(44, 20);
            this.textEdit7.TabIndex = 465;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(427, 114);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(87, 13);
            this.labelControl8.TabIndex = 464;
            this.labelControl8.Text = "BARCODE PREFIX";
            // 
            // txtState
            // 
            this.txtState.Enabled = false;
            this.txtState.Location = new System.Drawing.Point(89, 221);
            this.txtState.Name = "txtState";
            this.txtState.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtState.Properties.MaxLength = 100;
            this.txtState.Size = new System.Drawing.Size(241, 20);
            this.txtState.TabIndex = 469;
            this.txtState.TabStop = false;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(51, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 468;
            this.label9.Text = "State";
            // 
            // frmBranchMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 322);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.txtStatusTag);
            this.Controls.Add(this.labelControl10);
            this.Controls.Add(this.labelControl7);
            this.Controls.Add(this.textEdit7);
            this.Controls.Add(this.labelControl8);
            this.Controls.Add(this.txtGSTNo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtAddress3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtAccCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAccName);
            this.Controls.Add(this.txtCityCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtBranchName);
            this.Controls.Add(this.txtBranchCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmBranchMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmBranchMst_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmBranchMst_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBranchCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAccName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGSTNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStatusTag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtState.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtBranchName;
        private DevExpress.XtraEditors.TextEdit txtBranchCode;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtCityCode;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit txtCityName;
        private DevExpress.XtraEditors.TextEdit txtAccCode;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.TextEdit txtAccName;
        private DevExpress.XtraEditors.TextEdit txtAddress1;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.TextEdit txtAddress2;
        private DevExpress.XtraEditors.LabelControl label6;
        private DevExpress.XtraEditors.TextEdit txtAddress3;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.TextEdit txtGSTNo;
        private DevExpress.XtraEditors.LabelControl label8;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
        private DevExpress.XtraEditors.ComboBoxEdit txtStatusTag;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit txtState;
        internal DevExpress.XtraEditors.LabelControl label9;
    }
}