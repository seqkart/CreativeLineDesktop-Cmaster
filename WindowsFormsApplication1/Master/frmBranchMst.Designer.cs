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
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(124, 89);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(408, 289);
            this.HelpGrid.TabIndex = 418;
            this.HelpGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HelpGridView});
            this.HelpGrid.Visible = false;
            this.HelpGrid.DoubleClick += new System.EventHandler(this.HelpGrid_DoubleClick);
            this.HelpGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HelpGrid_KeyDown);
            // 
            // HelpGridView
            // 
            this.HelpGridView.DetailHeight = 458;
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
            this.Menu_ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuit,
            this.btnSave});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(597, 27);
            this.Menu_ToolStrip.TabIndex = 417;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(43, 24);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
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
            // txtBranchName
            // 
            this.txtBranchName.EnterMoveNextControl = true;
            this.txtBranchName.Location = new System.Drawing.Point(104, 119);
            this.txtBranchName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBranchName.Name = "txtBranchName";
            this.txtBranchName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBranchName.Properties.MaxLength = 30;
            this.txtBranchName.Size = new System.Drawing.Size(379, 24);
            this.txtBranchName.TabIndex = 413;
            // 
            // txtBranchCode
            // 
            this.txtBranchCode.Location = new System.Drawing.Point(104, 85);
            this.txtBranchCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBranchCode.Name = "txtBranchCode";
            this.txtBranchCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBranchCode.Size = new System.Drawing.Size(65, 24);
            this.txtBranchCode.TabIndex = 414;
            this.txtBranchCode.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(19, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 416;
            this.label3.Text = "Branch Name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(21, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 17);
            this.label1.TabIndex = 415;
            this.label1.Text = "Branch Code";
            // 
            // txtCityCode
            // 
            this.txtCityCode.EnterMoveNextControl = true;
            this.txtCityCode.Location = new System.Drawing.Point(104, 255);
            this.txtCityCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCityCode.Name = "txtCityCode";
            this.txtCityCode.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.txtCityCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCityCode.Properties.MaxLength = 4;
            this.txtCityCode.Size = new System.Drawing.Size(80, 24);
            this.txtCityCode.TabIndex = 422;
            this.txtCityCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtCityCode_KeyDown);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(75, 260);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 17);
            this.label2.TabIndex = 424;
            this.label2.Text = "City";
            // 
            // txtCityName
            // 
            this.txtCityName.Enabled = false;
            this.txtCityName.Location = new System.Drawing.Point(195, 255);
            this.txtCityName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCityName.Properties.ReadOnly = true;
            this.txtCityName.Size = new System.Drawing.Size(288, 24);
            this.txtCityName.TabIndex = 423;
            this.txtCityName.TabStop = false;
            // 
            // txtAccCode
            // 
            this.txtAccCode.EnterMoveNextControl = true;
            this.txtAccCode.Location = new System.Drawing.Point(104, 323);
            this.txtAccCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccCode.Name = "txtAccCode";
            this.txtAccCode.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.txtAccCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAccCode.Properties.MaxLength = 4;
            this.txtAccCode.Size = new System.Drawing.Size(80, 24);
            this.txtAccCode.TabIndex = 425;
            this.txtAccCode.EditValueChanged += new System.EventHandler(this.txtAccCode_EditValueChanged);
            this.txtAccCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtAccCode_KeyDown);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(45, 327);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 427;
            this.label4.Text = "AccCode";
            // 
            // txtAccName
            // 
            this.txtAccName.Location = new System.Drawing.Point(195, 323);
            this.txtAccName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAccName.Name = "txtAccName";
            this.txtAccName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAccName.Properties.ReadOnly = true;
            this.txtAccName.Size = new System.Drawing.Size(288, 24);
            this.txtAccName.TabIndex = 426;
            this.txtAccName.TabStop = false;
            // 
            // txtAddress1
            // 
            this.txtAddress1.EnterMoveNextControl = true;
            this.txtAddress1.Location = new System.Drawing.Point(104, 153);
            this.txtAddress1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress1.Properties.MaxLength = 30;
            this.txtAddress1.Size = new System.Drawing.Size(379, 24);
            this.txtAddress1.TabIndex = 428;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(42, 157);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 429;
            this.label5.Text = "Address1";
            // 
            // txtAddress2
            // 
            this.txtAddress2.EnterMoveNextControl = true;
            this.txtAddress2.Location = new System.Drawing.Point(104, 187);
            this.txtAddress2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress2.Properties.MaxLength = 30;
            this.txtAddress2.Size = new System.Drawing.Size(379, 24);
            this.txtAddress2.TabIndex = 430;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(42, 191);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 431;
            this.label6.Text = "Address2";
            // 
            // txtAddress3
            // 
            this.txtAddress3.EnterMoveNextControl = true;
            this.txtAddress3.Location = new System.Drawing.Point(104, 221);
            this.txtAddress3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress3.Properties.MaxLength = 30;
            this.txtAddress3.Size = new System.Drawing.Size(379, 24);
            this.txtAddress3.TabIndex = 432;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(42, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 17);
            this.label7.TabIndex = 433;
            this.label7.Text = "Address3";
            // 
            // txtGSTNo
            // 
            this.txtGSTNo.EnterMoveNextControl = true;
            this.txtGSTNo.Location = new System.Drawing.Point(104, 357);
            this.txtGSTNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGSTNo.Name = "txtGSTNo";
            this.txtGSTNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtGSTNo.Properties.MaxLength = 30;
            this.txtGSTNo.Size = new System.Drawing.Size(379, 24);
            this.txtGSTNo.TabIndex = 434;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(52, 361);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 17);
            this.label8.TabIndex = 435;
            this.label8.Text = "GST No";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(363, 85);
            this.comboBoxEdit1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Properties.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.comboBoxEdit1.Size = new System.Drawing.Size(48, 24);
            this.comboBoxEdit1.TabIndex = 466;
            // 
            // txtStatusTag
            // 
            this.txtStatusTag.Location = new System.Drawing.Point(248, 85);
            this.txtStatusTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatusTag.Name = "txtStatusTag";
            this.txtStatusTag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtStatusTag.Properties.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.txtStatusTag.Size = new System.Drawing.Size(48, 24);
            this.txtStatusTag.TabIndex = 467;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(315, 90);
            this.labelControl10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(39, 17);
            this.labelControl10.TabIndex = 462;
            this.labelControl10.Text = "IS \'HO\'";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(182, 90);
            this.labelControl7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(59, 17);
            this.labelControl7.TabIndex = 463;
            this.labelControl7.Text = "THIS UNIT";
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(539, 85);
            this.textEdit7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Size = new System.Drawing.Size(51, 24);
            this.textEdit7.TabIndex = 465;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(430, 90);
            this.labelControl8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(100, 17);
            this.labelControl8.TabIndex = 464;
            this.labelControl8.Text = "BARCODE PREFIX";
            // 
            // txtState
            // 
            this.txtState.Enabled = false;
            this.txtState.Location = new System.Drawing.Point(104, 289);
            this.txtState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtState.Name = "txtState";
            this.txtState.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtState.Properties.MaxLength = 100;
            this.txtState.Size = new System.Drawing.Size(281, 24);
            this.txtState.TabIndex = 469;
            this.txtState.TabStop = false;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(66, 294);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 17);
            this.label9.TabIndex = 468;
            this.label9.Text = "State";
            // 
            // frmBranchMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 421);
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
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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