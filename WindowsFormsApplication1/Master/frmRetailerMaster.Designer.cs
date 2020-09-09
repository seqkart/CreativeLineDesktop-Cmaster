﻿namespace WindowsFormsApplication1.Master
{
    partial class frmRetailerMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRetailerMaster));
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtDealerName = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDealerCode = new DevExpress.XtraEditors.TextEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAddress2 = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress3 = new DevExpress.XtraEditors.TextEdit();
            this.txtAddress1 = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSName = new DevExpress.XtraEditors.TextEdit();
            this.txtSCode = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSCode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpGrid
            // 
            this.HelpGrid.Location = new System.Drawing.Point(234, 28);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(447, 224);
            this.HelpGrid.TabIndex = 450;
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(681, 25);
            this.Menu_ToolStrip.TabIndex = 449;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(35, 22);
            this.btnQuit.Text = "&Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(38, 22);
            this.btnSave.Text = "&Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtDealerName
            // 
            this.txtDealerName.EnterMoveNextControl = true;
            this.txtDealerName.Location = new System.Drawing.Point(207, 240);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDealerName.Properties.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(456, 20);
            this.txtDealerName.TabIndex = 447;
            this.txtDealerName.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(50, 243);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 13);
            this.label15.TabIndex = 448;
            this.label15.Text = "Retailer";
            // 
            // txtDealerCode
            // 
            this.txtDealerCode.Location = new System.Drawing.Point(109, 240);
            this.txtDealerCode.Name = "txtDealerCode";
            this.txtDealerCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDealerCode.Properties.MaxLength = 6;
            this.txtDealerCode.Size = new System.Drawing.Size(79, 20);
            this.txtDealerCode.TabIndex = 446;
            this.txtDealerCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDealerCode_KeyDown);
            // 
            // txtEmail
            // 
            this.txtEmail.EnterMoveNextControl = true;
            this.txtEmail.Location = new System.Drawing.Point(111, 214);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEmail.Properties.MaxLength = 50;
            this.txtEmail.Size = new System.Drawing.Size(552, 20);
            this.txtEmail.TabIndex = 442;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(62, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 445;
            this.label11.Text = "Email";
            // 
            // txtTel
            // 
            this.txtTel.EnterMoveNextControl = true;
            this.txtTel.Location = new System.Drawing.Point(111, 189);
            this.txtTel.Name = "txtTel";
            this.txtTel.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTel.Properties.MaxLength = 40;
            this.txtTel.Size = new System.Drawing.Size(552, 20);
            this.txtTel.TabIndex = 441;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(55, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 13);
            this.label10.TabIndex = 444;
            this.label10.Text = "Tel/Fax";
            // 
            // txtAddress2
            // 
            this.txtAddress2.EnterMoveNextControl = true;
            this.txtAddress2.Location = new System.Drawing.Point(111, 137);
            this.txtAddress2.Name = "txtAddress2";
            this.txtAddress2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress2.Properties.MaxLength = 45;
            this.txtAddress2.Size = new System.Drawing.Size(552, 20);
            this.txtAddress2.TabIndex = 439;
            // 
            // txtAddress3
            // 
            this.txtAddress3.EnterMoveNextControl = true;
            this.txtAddress3.Location = new System.Drawing.Point(111, 163);
            this.txtAddress3.Name = "txtAddress3";
            this.txtAddress3.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress3.Properties.MaxLength = 45;
            this.txtAddress3.Size = new System.Drawing.Size(552, 20);
            this.txtAddress3.TabIndex = 440;
            // 
            // txtAddress1
            // 
            this.txtAddress1.EnterMoveNextControl = true;
            this.txtAddress1.Location = new System.Drawing.Point(111, 111);
            this.txtAddress1.Name = "txtAddress1";
            this.txtAddress1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAddress1.Properties.MaxLength = 45;
            this.txtAddress1.Size = new System.Drawing.Size(552, 20);
            this.txtAddress1.TabIndex = 438;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(48, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 443;
            this.label9.Text = "Address";
            // 
            // txtSName
            // 
            this.txtSName.EnterMoveNextControl = true;
            this.txtSName.Location = new System.Drawing.Point(111, 78);
            this.txtSName.Name = "txtSName";
            this.txtSName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSName.Properties.MaxLength = 60;
            this.txtSName.Size = new System.Drawing.Size(552, 20);
            this.txtSName.TabIndex = 435;
            // 
            // txtSCode
            // 
            this.txtSCode.Location = new System.Drawing.Point(111, 49);
            this.txtSCode.Name = "txtSCode";
            this.txtSCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSCode.Properties.MaxLength = 5;
            this.txtSCode.Size = new System.Drawing.Size(73, 20);
            this.txtSCode.TabIndex = 434;
            this.txtSCode.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 437;
            this.label3.Text = "Retailer Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 436;
            this.label1.Text = "Retailer Code";
            // 
            // frmRetailerMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 277);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtDealerName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDealerCode);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtAddress2);
            this.Controls.Add(this.txtAddress3);
            this.Controls.Add(this.txtAddress1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.txtSCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmRetailerMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmRetailerMaster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmRetailerMaster_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAddress1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSCode.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtDealerName;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.TextEdit txtDealerCode;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private System.Windows.Forms.Label label10;
        private DevExpress.XtraEditors.TextEdit txtAddress2;
        private DevExpress.XtraEditors.TextEdit txtAddress3;
        private DevExpress.XtraEditors.TextEdit txtAddress1;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.TextEdit txtSName;
        private DevExpress.XtraEditors.TextEdit txtSCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}