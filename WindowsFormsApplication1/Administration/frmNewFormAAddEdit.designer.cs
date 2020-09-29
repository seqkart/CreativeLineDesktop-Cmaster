namespace WindowsFormsApplication1
{
    partial class frmNewFormAAddEdit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNewFormAAddEdit));
            this.label12 = new DevExpress.XtraEditors.LabelControl();
            this.txtFormName = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.txtMenuName = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.txtFormDesc = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new DevExpress.XtraEditors.LabelControl();
            this.txtFormCode = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.txtSMenuName = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new DevExpress.XtraEditors.LabelControl();
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtProcName = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtRoleCode = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new DevExpress.XtraEditors.LabelControl();
            this.txtRoleDesc = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrderBy = new DevExpress.XtraEditors.TextEdit();
            this.txtstatusTag = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtNfaTag = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMenuName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMenuName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderBy.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstatusTag.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNfaTag.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(51, 67);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 13);
            this.label12.TabIndex = 332;
            this.label12.Text = "Form Name";
            // 
            // txtFormName
            // 
            this.txtFormName.EnterMoveNextControl = true;
            this.txtFormName.Location = new System.Drawing.Point(117, 63);
            this.txtFormName.Name = "txtFormName";
            this.txtFormName.Properties.MaxLength = 50;
            this.txtFormName.Size = new System.Drawing.Size(463, 20);
            this.txtFormName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Appearance.ForeColor = System.Drawing.Color.Red;
            this.label4.Appearance.Options.UseForeColor = true;
            this.label4.Location = new System.Drawing.Point(69, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 343;
            this.label4.Text = "NFATag";
            // 
            // txtMenuName
            // 
            this.txtMenuName.Location = new System.Drawing.Point(117, 144);
            this.txtMenuName.Name = "txtMenuName";
            this.txtMenuName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMenuName.Size = new System.Drawing.Size(463, 20);
            this.txtMenuName.TabIndex = 5;
            this.txtMenuName.EditValueChanged += new System.EventHandler(this.txtMenuName_EditValueChanged);
            this.txtMenuName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMenuName_KeyDown);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(47, 148);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 347;
            this.label7.Text = "Menu Name";
            // 
            // txtFormDesc
            // 
            this.txtFormDesc.EnterMoveNextControl = true;
            this.txtFormDesc.Location = new System.Drawing.Point(117, 117);
            this.txtFormDesc.Name = "txtFormDesc";
            this.txtFormDesc.Properties.MaxLength = 150;
            this.txtFormDesc.Size = new System.Drawing.Size(463, 20);
            this.txtFormDesc.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(56, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 349;
            this.label8.Text = "Form Desc";
            // 
            // txtFormCode
            // 
            this.txtFormCode.EnterMoveNextControl = true;
            this.txtFormCode.Location = new System.Drawing.Point(117, 90);
            this.txtFormCode.Name = "txtFormCode";
            this.txtFormCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFormCode.Properties.MaxLength = 8;
            this.txtFormCode.Size = new System.Drawing.Size(136, 20);
            this.txtFormCode.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(53, 94);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 13);
            this.label9.TabIndex = 351;
            this.label9.Text = "Form Code";
            // 
            // label5
            // 
            this.label5.Appearance.ForeColor = System.Drawing.Color.Red;
            this.label5.Appearance.Options.UseForeColor = true;
            this.label5.Location = new System.Drawing.Point(501, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 353;
            this.label5.Text = "Status";
            // 
            // txtSMenuName
            // 
            this.txtSMenuName.Location = new System.Drawing.Point(117, 171);
            this.txtSMenuName.Name = "txtSMenuName";
            this.txtSMenuName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSMenuName.Size = new System.Drawing.Size(463, 20);
            this.txtSMenuName.TabIndex = 6;
            this.txtSMenuName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSMenuName_KeyDown);
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(24, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 13);
            this.label11.TabIndex = 356;
            this.label11.Text = "Sub Menu Name";
            // 
            // HelpGrid
            // 
            this.HelpGrid.Location = new System.Drawing.Point(101, 41);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(470, 269);
            this.HelpGrid.TabIndex = 358;
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
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.DodgerBlue;
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(637, 26);
            this.Menu_ToolStrip.TabIndex = 365;
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
            this.btnQuit.Size = new System.Drawing.Size(45, 23);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnSave.Size = new System.Drawing.Size(48, 23);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtProcName
            // 
            this.txtProcName.EnterMoveNextControl = true;
            this.txtProcName.Location = new System.Drawing.Point(256, 198);
            this.txtProcName.Name = "txtProcName";
            this.txtProcName.Properties.MaxLength = 150;
            this.txtProcName.Size = new System.Drawing.Size(324, 20);
            this.txtProcName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(195, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 367;
            this.label1.Text = "Proc Name";
            // 
            // txtRoleCode
            // 
            this.txtRoleCode.EnterMoveNextControl = true;
            this.txtRoleCode.Location = new System.Drawing.Point(117, 225);
            this.txtRoleCode.Name = "txtRoleCode";
            this.txtRoleCode.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.txtRoleCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRoleCode.Properties.MaxLength = 4;
            this.txtRoleCode.Size = new System.Drawing.Size(69, 20);
            this.txtRoleCode.TabIndex = 394;
            this.txtRoleCode.EditValueChanged += new System.EventHandler(this.TxtRoleCode_EditValueChanged);
            this.txtRoleCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtRoleCode_KeyDown);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(51, 229);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 13);
            this.label13.TabIndex = 396;
            this.label13.Text = "Under Role";
            // 
            // txtRoleDesc
            // 
            this.txtRoleDesc.Location = new System.Drawing.Point(192, 225);
            this.txtRoleDesc.Name = "txtRoleDesc";
            this.txtRoleDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtRoleDesc.Properties.ReadOnly = true;
            this.txtRoleDesc.Size = new System.Drawing.Size(388, 20);
            this.txtRoleDesc.TabIndex = 395;
            this.txtRoleDesc.TabStop = false;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(65, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 398;
            this.label2.Text = "Order By";
            // 
            // txtOrderBy
            // 
            this.txtOrderBy.Location = new System.Drawing.Point(117, 252);
            this.txtOrderBy.Name = "txtOrderBy";
            this.txtOrderBy.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrderBy.Properties.MaxLength = 1;
            this.txtOrderBy.Size = new System.Drawing.Size(69, 20);
            this.txtOrderBy.TabIndex = 397;
            // 
            // txtstatusTag
            // 
            this.txtstatusTag.Location = new System.Drawing.Point(539, 90);
            this.txtstatusTag.Name = "txtstatusTag";
            this.txtstatusTag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtstatusTag.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtstatusTag.Properties.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.txtstatusTag.Properties.MaxLength = 1;
            this.txtstatusTag.Size = new System.Drawing.Size(41, 20);
            this.txtstatusTag.TabIndex = 3;
            this.txtstatusTag.Enter += new System.EventHandler(this.txtstatusTag_Enter);
            this.txtstatusTag.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtstatusTag_KeyDown);
            this.txtstatusTag.Validating += new System.ComponentModel.CancelEventHandler(this.txtstatusTag_Validating);
            // 
            // txtNfaTag
            // 
            this.txtNfaTag.Location = new System.Drawing.Point(117, 198);
            this.txtNfaTag.Name = "txtNfaTag";
            this.txtNfaTag.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtNfaTag.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNfaTag.Properties.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.txtNfaTag.Properties.MaxLength = 1;
            this.txtNfaTag.Size = new System.Drawing.Size(45, 20);
            this.txtNfaTag.TabIndex = 7;
            this.txtNfaTag.Validating += new System.ComponentModel.CancelEventHandler(this.txtNfaTag_Validating);
            // 
            // frmNewFormAAddEdit
            // 
            this.Appearance.BackColor = System.Drawing.Color.Gainsboro;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 332);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOrderBy);
            this.Controls.Add(this.txtRoleCode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtRoleDesc);
            this.Controls.Add(this.txtProcName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtSMenuName);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtFormCode);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtFormDesc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMenuName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtFormName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtstatusTag);
            this.Controls.Add(this.txtNfaTag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmNewFormAAddEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmNewFormAAddEdit_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmNewFormAAddEdit_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.txtFormName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMenuName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFormCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSMenuName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProcName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRoleDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderBy.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtstatusTag.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNfaTag.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.LabelControl label12;
        private DevExpress.XtraEditors.TextEdit txtFormName;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.TextEdit txtMenuName;
        private DevExpress.XtraEditors.LabelControl label7;
        private DevExpress.XtraEditors.TextEdit txtFormDesc;
        private DevExpress.XtraEditors.LabelControl label8;
        private DevExpress.XtraEditors.TextEdit txtFormCode;
        private DevExpress.XtraEditors.LabelControl label9;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.TextEdit txtSMenuName;
        private DevExpress.XtraEditors.LabelControl label11;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtProcName;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtRoleCode;
        private DevExpress.XtraEditors.LabelControl label13;
        private DevExpress.XtraEditors.TextEdit txtRoleDesc;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit txtOrderBy;
        private DevExpress.XtraEditors.ComboBoxEdit txtstatusTag;
        private DevExpress.XtraEditors.ComboBoxEdit txtNfaTag;
    }
}