
namespace WindowsFormsApplication1.Production
{
    partial class frmFabricStock
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
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtColorName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtColorCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtFabricLotNo = new DevExpress.XtraEditors.TextEdit();
            this.txtFabricTypeDesc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFabricTypeCode = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtFabricContent = new DevExpress.XtraEditors.TextEdit();
            this.txtFabricCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtQty = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricLotNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricTypeDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricTypeCode.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(102, 35);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(613, 221);
            this.HelpGrid.TabIndex = 424;
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
            // txtColorName
            // 
            this.txtColorName.Enabled = false;
            this.txtColorName.Location = new System.Drawing.Point(334, 169);
            this.txtColorName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColorName.Name = "txtColorName";
            this.txtColorName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColorName.Properties.MaxLength = 100;
            this.txtColorName.Size = new System.Drawing.Size(341, 24);
            this.txtColorName.TabIndex = 417;
            this.txtColorName.TabStop = false;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(49, 172);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(150, 17);
            this.labelControl3.TabIndex = 423;
            this.labelControl3.Text = "Fabric Sahde Num & Name";
            // 
            // txtColorCode
            // 
            this.txtColorCode.Enabled = false;
            this.txtColorCode.Location = new System.Drawing.Point(231, 169);
            this.txtColorCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColorCode.Name = "txtColorCode";
            this.txtColorCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColorCode.Properties.MaxLength = 100;
            this.txtColorCode.Size = new System.Drawing.Size(97, 24);
            this.txtColorCode.TabIndex = 416;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(373, 74);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 17);
            this.labelControl2.TabIndex = 422;
            this.labelControl2.Text = "Fabric Lot No";
            // 
            // txtFabricLotNo
            // 
            this.txtFabricLotNo.Enabled = false;
            this.txtFabricLotNo.Location = new System.Drawing.Point(483, 71);
            this.txtFabricLotNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFabricLotNo.Name = "txtFabricLotNo";
            this.txtFabricLotNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFabricLotNo.Properties.MaxLength = 100;
            this.txtFabricLotNo.Size = new System.Drawing.Size(193, 24);
            this.txtFabricLotNo.TabIndex = 415;
            // 
            // txtFabricTypeDesc
            // 
            this.txtFabricTypeDesc.Enabled = false;
            this.txtFabricTypeDesc.Location = new System.Drawing.Point(334, 103);
            this.txtFabricTypeDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFabricTypeDesc.Name = "txtFabricTypeDesc";
            this.txtFabricTypeDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFabricTypeDesc.Properties.MaxLength = 100;
            this.txtFabricTypeDesc.Size = new System.Drawing.Size(342, 24);
            this.txtFabricTypeDesc.TabIndex = 413;
            this.txtFabricTypeDesc.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(133, 106);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 17);
            this.labelControl1.TabIndex = 421;
            this.labelControl1.Text = "Fabric Type";
            // 
            // txtFabricTypeCode
            // 
            this.txtFabricTypeCode.Enabled = false;
            this.txtFabricTypeCode.Location = new System.Drawing.Point(231, 103);
            this.txtFabricTypeCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFabricTypeCode.Name = "txtFabricTypeCode";
            this.txtFabricTypeCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFabricTypeCode.Properties.MaxLength = 100;
            this.txtFabricTypeCode.Size = new System.Drawing.Size(97, 24);
            this.txtFabricTypeCode.TabIndex = 412;
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(759, 27);
            this.Menu_ToolStrip.TabIndex = 420;
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
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(116, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 419;
            this.label3.Text = "Fabric Content";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(130, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 418;
            this.label1.Text = "Fabric Code";
            // 
            // txtFabricContent
            // 
            this.txtFabricContent.Enabled = false;
            this.txtFabricContent.Location = new System.Drawing.Point(231, 137);
            this.txtFabricContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFabricContent.Name = "txtFabricContent";
            this.txtFabricContent.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFabricContent.Properties.MaxLength = 100;
            this.txtFabricContent.Size = new System.Drawing.Size(445, 24);
            this.txtFabricContent.TabIndex = 414;
            // 
            // txtFabricCode
            // 
            this.txtFabricCode.Location = new System.Drawing.Point(231, 71);
            this.txtFabricCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFabricCode.Name = "txtFabricCode";
            this.txtFabricCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtFabricCode.Size = new System.Drawing.Size(97, 24);
            this.txtFabricCode.TabIndex = 411;
            this.txtFabricCode.EditValueChanged += new System.EventHandler(this.TxtYarnCode_EditValueChanged);
            this.txtFabricCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtYarnCode_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(179, 204);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(20, 17);
            this.labelControl4.TabIndex = 426;
            this.labelControl4.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(231, 201);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQty.Properties.MaxLength = 100;
            this.txtQty.Size = new System.Drawing.Size(193, 24);
            this.txtQty.TabIndex = 425;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtQty_KeyPress);
            // 
            // frmFabricStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(759, 272);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtQty);
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
            this.Name = "frmFabricStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmYarnStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricLotNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricTypeDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricTypeCode.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtFabricCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraEditors.TextEdit txtColorName;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtColorCode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtFabricLotNo;
        private DevExpress.XtraEditors.TextEdit txtFabricTypeDesc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtFabricTypeCode;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtFabricContent;
        private DevExpress.XtraEditors.TextEdit txtFabricCode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtQty;
    }
}