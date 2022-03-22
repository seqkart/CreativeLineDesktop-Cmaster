
namespace WindowsFormsApplication1.Master
{
    partial class frmAreaMaster
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
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtAreaName = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtAreaCode = new DevExpress.XtraEditors.TextEdit();
            this.label33 = new DevExpress.XtraEditors.LabelControl();
            this.txtCityName = new DevExpress.XtraEditors.TextEdit();
            this.txtCitycode = new DevExpress.XtraEditors.TextEdit();
            this.txtZipCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCitycode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZipCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            this.SuspendLayout();
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(652, 27);
            this.Menu_ToolStrip.TabIndex = 200;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.Image = global::WindowsFormsApplication1.Properties.Resources.Close;
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(70, 24);
            this.btnQuit.Text = "Close";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::WindowsFormsApplication1.Properties.Resources.Add;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtAreaName
            // 
            this.txtAreaName.Location = new System.Drawing.Point(181, 139);
            this.txtAreaName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAreaName.Name = "txtAreaName";
            this.txtAreaName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAreaName.Properties.MaxLength = 100;
            this.txtAreaName.Size = new System.Drawing.Size(408, 22);
            this.txtAreaName.TabIndex = 197;
            this.txtAreaName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAreaName_KeyDown);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(94, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 199;
            this.label3.Text = "Area Name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(94, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 198;
            this.label1.Text = "Area Code";
            // 
            // txtAreaCode
            // 
            this.txtAreaCode.Location = new System.Drawing.Point(181, 79);
            this.txtAreaCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAreaCode.Name = "txtAreaCode";
            this.txtAreaCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAreaCode.Size = new System.Drawing.Size(97, 22);
            this.txtAreaCode.TabIndex = 196;
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(94, 112);
            this.label33.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(22, 16);
            this.label33.TabIndex = 456;
            this.label33.Text = "City";
            // 
            // txtCityName
            // 
            this.txtCityName.EnterMoveNextControl = true;
            this.txtCityName.Location = new System.Drawing.Point(279, 109);
            this.txtCityName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCityName.Name = "txtCityName";
            this.txtCityName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCityName.Properties.ReadOnly = true;
            this.txtCityName.Size = new System.Drawing.Size(310, 22);
            this.txtCityName.TabIndex = 455;
            this.txtCityName.TabStop = false;
            // 
            // txtCitycode
            // 
            this.txtCitycode.Location = new System.Drawing.Point(181, 109);
            this.txtCitycode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCitycode.Name = "txtCitycode";
            this.txtCitycode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCitycode.Properties.MaxLength = 8;
            this.txtCitycode.Size = new System.Drawing.Size(91, 22);
            this.txtCitycode.TabIndex = 454;
            this.txtCitycode.EditValueChanged += new System.EventHandler(this.txtCitycode_EditValueChanged);
            this.txtCitycode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCitycode_KeyDown);
            // 
            // txtZipCode
            // 
            this.txtZipCode.Location = new System.Drawing.Point(181, 169);
            this.txtZipCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtZipCode.Name = "txtZipCode";
            this.txtZipCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtZipCode.Properties.MaxLength = 100;
            this.txtZipCode.Size = new System.Drawing.Size(408, 22);
            this.txtZipCode.TabIndex = 457;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(94, 172);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 16);
            this.labelControl1.TabIndex = 458;
            this.labelControl1.Text = "ZipCode";
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(24, 34);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(616, 220);
            this.HelpGrid.TabIndex = 459;
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
            this.HelpGridView.OptionsView.ColumnAutoWidth = false;
            this.HelpGridView.OptionsView.ShowGroupPanel = false;
            this.HelpGridView.OptionsView.ShowIndicator = false;
            this.HelpGridView.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Never;
            // 
            // frmAreaMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 267);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.txtZipCode);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.txtCityName);
            this.Controls.Add(this.txtCitycode);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtAreaName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAreaCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmAreaMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmAreaMaster_Load);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAreaCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCitycode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtZipCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtAreaName;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtAreaCode;
        private DevExpress.XtraEditors.LabelControl label33;
        private DevExpress.XtraEditors.TextEdit txtCityName;
        private DevExpress.XtraEditors.TextEdit txtCitycode;
        private DevExpress.XtraEditors.TextEdit txtZipCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
    }
}