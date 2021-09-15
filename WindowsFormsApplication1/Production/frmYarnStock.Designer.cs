
namespace WindowsFormsApplication1.Production
{
    partial class frmYarnStock
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
            this.txtYarnLotNo = new DevExpress.XtraEditors.TextEdit();
            this.txtYarnTypeDesc = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtYarnTypeCode = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.txtYarnContent = new DevExpress.XtraEditors.TextEdit();
            this.txtYarnCode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtQty = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnLotNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnTypeDesc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnTypeCode.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnContent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtQty.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(50, 31);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(613, 177);
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
            this.txtColorName.Location = new System.Drawing.Point(258, 137);
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
            this.labelControl3.Location = new System.Drawing.Point(6, 140);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(141, 17);
            this.labelControl3.TabIndex = 423;
            this.labelControl3.Text = "Yarn Sahde Num & Name";
            // 
            // txtColorCode
            // 
            this.txtColorCode.Enabled = false;
            this.txtColorCode.Location = new System.Drawing.Point(155, 137);
            this.txtColorCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColorCode.Name = "txtColorCode";
            this.txtColorCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtColorCode.Properties.MaxLength = 100;
            this.txtColorCode.Size = new System.Drawing.Size(97, 24);
            this.txtColorCode.TabIndex = 416;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(297, 42);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 17);
            this.labelControl2.TabIndex = 422;
            this.labelControl2.Text = "Yarn Lot No";
            // 
            // txtYarnLotNo
            // 
            this.txtYarnLotNo.Enabled = false;
            this.txtYarnLotNo.Location = new System.Drawing.Point(407, 38);
            this.txtYarnLotNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYarnLotNo.Name = "txtYarnLotNo";
            this.txtYarnLotNo.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYarnLotNo.Properties.MaxLength = 100;
            this.txtYarnLotNo.Size = new System.Drawing.Size(193, 24);
            this.txtYarnLotNo.TabIndex = 415;
            // 
            // txtYarnTypeDesc
            // 
            this.txtYarnTypeDesc.Enabled = false;
            this.txtYarnTypeDesc.Location = new System.Drawing.Point(258, 71);
            this.txtYarnTypeDesc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYarnTypeDesc.Name = "txtYarnTypeDesc";
            this.txtYarnTypeDesc.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYarnTypeDesc.Properties.MaxLength = 100;
            this.txtYarnTypeDesc.Size = new System.Drawing.Size(342, 24);
            this.txtYarnTypeDesc.TabIndex = 413;
            this.txtYarnTypeDesc.TabStop = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(89, 74);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(58, 17);
            this.labelControl1.TabIndex = 421;
            this.labelControl1.Text = "Yarn Type";
            // 
            // txtYarnTypeCode
            // 
            this.txtYarnTypeCode.Enabled = false;
            this.txtYarnTypeCode.Location = new System.Drawing.Point(155, 71);
            this.txtYarnTypeCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYarnTypeCode.Name = "txtYarnTypeCode";
            this.txtYarnTypeCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYarnTypeCode.Properties.MaxLength = 100;
            this.txtYarnTypeCode.Size = new System.Drawing.Size(97, 24);
            this.txtYarnTypeCode.TabIndex = 412;
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(674, 27);
            this.Menu_ToolStrip.TabIndex = 420;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.Image = global::WindowsFormsApplication1.Properties.Resources.Close;
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(70, 28);
            this.btnQuit.Text = "Close";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::WindowsFormsApplication1.Properties.Resources.Add;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(65, 28);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(72, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 419;
            this.label3.Text = "Yarn Content";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(86, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 17);
            this.label1.TabIndex = 418;
            this.label1.Text = "Yarn Code";
            // 
            // txtYarnContent
            // 
            this.txtYarnContent.Enabled = false;
            this.txtYarnContent.Location = new System.Drawing.Point(155, 105);
            this.txtYarnContent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYarnContent.Name = "txtYarnContent";
            this.txtYarnContent.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYarnContent.Properties.MaxLength = 100;
            this.txtYarnContent.Size = new System.Drawing.Size(445, 24);
            this.txtYarnContent.TabIndex = 414;
            // 
            // txtYarnCode
            // 
            this.txtYarnCode.Location = new System.Drawing.Point(155, 38);
            this.txtYarnCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYarnCode.Name = "txtYarnCode";
            this.txtYarnCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtYarnCode.Size = new System.Drawing.Size(97, 24);
            this.txtYarnCode.TabIndex = 411;
            this.txtYarnCode.EditValueChanged += new System.EventHandler(this.txtYarnCode_EditValueChanged);
            this.txtYarnCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYarnCode_KeyDown);
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(127, 172);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(20, 17);
            this.labelControl4.TabIndex = 426;
            this.labelControl4.Text = "Qty";
            // 
            // txtQty
            // 
            this.txtQty.Enabled = false;
            this.txtQty.Location = new System.Drawing.Point(155, 169);
            this.txtQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQty.Name = "txtQty";
            this.txtQty.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtQty.Properties.MaxLength = 100;
            this.txtQty.Size = new System.Drawing.Size(193, 24);
            this.txtQty.TabIndex = 425;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            // 
            // frmYarnStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(674, 221);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtColorName);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtColorCode);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtYarnLotNo);
            this.Controls.Add(this.txtYarnTypeDesc);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtYarnTypeCode);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtYarnContent);
            this.Controls.Add(this.txtYarnCode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmYarnStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmYarnStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtColorCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnLotNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnTypeDesc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnTypeCode.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnContent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtYarnCode.Properties)).EndInit();
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
        private DevExpress.XtraEditors.TextEdit txtYarnLotNo;
        private DevExpress.XtraEditors.TextEdit txtYarnTypeDesc;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtYarnTypeCode;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.TextEdit txtYarnContent;
        private DevExpress.XtraEditors.TextEdit txtYarnCode;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtQty;
    }
}