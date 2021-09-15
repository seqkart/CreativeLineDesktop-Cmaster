
namespace WindowsFormsApplication1.Production
{
    partial class frmFabricMaster
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
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFabricContent = new DevExpress.XtraEditors.TextEdit();
            this.txtFabricCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFabricTypeCode = new DevExpress.XtraEditors.TextEdit();
            this.txtFabricTypeDesc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFabricLotNo = new DevExpress.XtraEditors.TextEdit();
            this.txtColorName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtColorCode = new DevExpress.XtraEditors.TextEdit();
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricTypeCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricTypeDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricLotNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorCode.Properties)).BeginInit();
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(722, 27);
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
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::WindowsFormsApplication1.Properties.Resources.Add;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click_1);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(102, 150);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 199;
            this.label3.Text = "Fabric Content";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(116, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 198;
            this.label1.Text = "Fabric Code";
            // 
            // txtFabricContent
            // 
            this.txtFabricContent.Location = new System.Drawing.Point(217, 147);
            this.txtFabricContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFabricContent.Name = "txtFabricContent";
            this.txtFabricContent.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFabricContent.Properties.MaxLength = 100;
            this.txtFabricContent.Size = new System.Drawing.Size(445, 24);
            this.txtFabricContent.TabIndex = 3;
            // 
            // txtFabricCode
            // 
            this.txtFabricCode.Location = new System.Drawing.Point(217, 81);
            this.txtFabricCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFabricCode.Name = "txtFabricCode";
            this.txtFabricCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFabricCode.Size = new System.Drawing.Size(97, 24);
            this.txtFabricCode.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(119, 116);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 17);
            this.labelControl1.TabIndex = 202;
            this.labelControl1.Text = "Fabric Type";
            // 
            // txtFabricTypeCode
            // 
            this.txtFabricTypeCode.Location = new System.Drawing.Point(217, 113);
            this.txtFabricTypeCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFabricTypeCode.Name = "txtFabricTypeCode";
            this.txtFabricTypeCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFabricTypeCode.Properties.MaxLength = 100;
            this.txtFabricTypeCode.Size = new System.Drawing.Size(97, 24);
            this.txtFabricTypeCode.TabIndex = 1;
            this.txtFabricTypeCode.EditValueChanged += new System.EventHandler(this.txtYarnTypeCode_EditValueChanged);
            this.txtFabricTypeCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYarnTypeCode_KeyDown);
            // 
            // txtFabricTypeDesc
            // 
            this.txtFabricTypeDesc.Enabled = false;
            this.txtFabricTypeDesc.Location = new System.Drawing.Point(320, 113);
            this.txtFabricTypeDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFabricTypeDesc.Name = "txtFabricTypeDesc";
            this.txtFabricTypeDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFabricTypeDesc.Properties.MaxLength = 100;
            this.txtFabricTypeDesc.Size = new System.Drawing.Size(342, 24);
            this.txtFabricTypeDesc.TabIndex = 2;
            this.txtFabricTypeDesc.TabStop = false;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(107, 182);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 17);
            this.labelControl2.TabIndex = 205;
            this.labelControl2.Text = "Fabric Lot No";
            // 
            // txtFabricLotNo
            // 
            this.txtFabricLotNo.Location = new System.Drawing.Point(217, 179);
            this.txtFabricLotNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFabricLotNo.Name = "txtFabricLotNo";
            this.txtFabricLotNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFabricLotNo.Properties.MaxLength = 100;
            this.txtFabricLotNo.Size = new System.Drawing.Size(445, 24);
            this.txtFabricLotNo.TabIndex = 4;
            // 
            // txtColorName
            // 
            this.txtColorName.Enabled = false;
            this.txtColorName.Location = new System.Drawing.Point(321, 211);
            this.txtColorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColorName.Properties.MaxLength = 100;
            this.txtColorName.Size = new System.Drawing.Size(342, 24);
            this.txtColorName.TabIndex = 6;
            this.txtColorName.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(36, 214);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(150, 17);
            this.labelControl3.TabIndex = 207;
            this.labelControl3.Text = "Fabric Sahde Num & Name";
            // 
            // txtColorCode
            // 
            this.txtColorCode.Location = new System.Drawing.Point(218, 211);
            this.txtColorCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColorCode.Name = "txtColorCode";
            this.txtColorCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColorCode.Properties.MaxLength = 100;
            this.txtColorCode.Size = new System.Drawing.Size(97, 24);
            this.txtColorCode.TabIndex = 5;
            this.txtColorCode.EditValueChanged += new System.EventHandler(this.txtColorCode_EditValueChanged);
            this.txtColorCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtColorCode_KeyDown);
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(102, 31);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(613, 230);
            this.HelpGrid.TabIndex = 410;
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
            // frmFabricMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(722, 263);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtColorCode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtFabricLotNo);
            this.Controls.Add(this.txtFabricTypeDesc);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtFabricTypeCode);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFabricContent);
            this.Controls.Add(this.txtFabricCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmFabricMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmYarnMaster_Load);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricTypeCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricTypeDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricLotNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtFabricContent;
        private DevExpress.XtraEditors.TextEdit txtFabricCode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtFabricTypeCode;
        private DevExpress.XtraEditors.TextEdit txtFabricTypeDesc;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFabricLotNo;
        private DevExpress.XtraEditors.TextEdit txtColorName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtColorCode;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
    }
}