
namespace WindowsFormsApplication1.Transaction
{
    partial class FrmImportSaleGSTDiffData
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImportSaleGSTDiffData));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.InfoGrid = new DevExpress.XtraGrid.GridControl();
            this.InfoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnLoad = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDebitPartyName = new DevExpress.XtraEditors.TextEdit();
            this.txtDebitPartyCode = new DevExpress.XtraEditors.TextEdit();
            this.EOSSGrid = new DevExpress.XtraGrid.GridControl();
            this.EOSSGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView6 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FreshGrid = new DevExpress.XtraGrid.GridControl();
            this.FreshGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitPartyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitPartyCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EOSSGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EOSSGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreshGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreshGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoGrid
            // 
            this.InfoGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoGrid.Location = new System.Drawing.Point(0, 0);
            this.InfoGrid.MainView = this.InfoGridView;
            this.InfoGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoGrid.Name = "InfoGrid";
            this.InfoGrid.Size = new System.Drawing.Size(1070, 608);
            this.InfoGrid.TabIndex = 448;
            this.InfoGrid.TabStop = false;
            this.InfoGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InfoGridView,
            this.gridView4});
            // 
            // InfoGridView
            // 
            this.InfoGridView.CustomizationFormBounds = new System.Drawing.Rectangle(580, 341, 252, 233);
            this.InfoGridView.DetailHeight = 458;
            this.InfoGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.InfoGridView.GridControl = this.InfoGrid;
            this.InfoGridView.Name = "InfoGridView";
            this.InfoGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.InfoGridView.OptionsPrint.PrintFooter = false;
            this.InfoGridView.OptionsPrint.PrintGroupFooter = false;
            this.InfoGridView.OptionsView.ShowFooter = true;
            this.InfoGridView.OptionsView.ShowGroupPanel = false;
            this.InfoGridView.OptionsView.ShowIndicator = false;
            // 
            // gridView4
            // 
            this.gridView4.DetailHeight = 458;
            this.gridView4.GridControl = this.InfoGrid;
            this.gridView4.Name = "gridView4";
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
            this.btnLoad,
            this.btnSave});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(1363, 31);
            this.Menu_ToolStrip.TabIndex = 447;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnQuit.Size = new System.Drawing.Size(53, 28);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.btnLoad.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnLoad.Image = ((System.Drawing.Image)(resources.GetObject("btnLoad.Image")));
            this.btnLoad.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(86, 28);
            this.btnLoad.Text = "Load Excel";
            this.btnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 28);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 31);
            this.splitContainerControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton4);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton3);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton2);
            this.splitContainerControl1.Panel1.Controls.Add(this.simpleButton1);
            this.splitContainerControl1.Panel1.Controls.Add(this.labelControl4);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtDebitPartyName);
            this.splitContainerControl1.Panel1.Controls.Add(this.txtDebitPartyCode);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.EOSSGrid);
            this.splitContainerControl1.Panel2.Controls.Add(this.HelpGrid);
            this.splitContainerControl1.Panel2.Controls.Add(this.FreshGrid);
            this.splitContainerControl1.Panel2.Controls.Add(this.InfoGrid);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1363, 738);
            this.splitContainerControl1.SplitterPosition = 111;
            this.splitContainerControl1.TabIndex = 449;
            // 
            // simpleButton4
            // 
            this.simpleButton4.Location = new System.Drawing.Point(522, 65);
            this.simpleButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(149, 30);
            this.simpleButton4.TabIndex = 538;
            this.simpleButton4.Text = "PROCESS REPORT";
            this.simpleButton4.Click += new System.EventHandler(this.SimpleButton4_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(373, 65);
            this.simpleButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(149, 30);
            this.simpleButton3.TabIndex = 538;
            this.simpleButton3.Text = "EXPORT REPORT";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(224, 65);
            this.simpleButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(149, 30);
            this.simpleButton2.TabIndex = 538;
            this.simpleButton2.Text = "PRINT REPORT";
            this.simpleButton2.Click += new System.EventHandler(this.SimpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(75, 65);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(149, 30);
            this.simpleButton1.TabIndex = 538;
            this.simpleButton1.Text = "LOAD EXCEL";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(8, 22);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(71, 16);
            this.labelControl4.TabIndex = 537;
            this.labelControl4.Text = "Party Name";
            // 
            // txtDebitPartyName
            // 
            this.txtDebitPartyName.Enabled = false;
            this.txtDebitPartyName.EnterMoveNextControl = true;
            this.txtDebitPartyName.Location = new System.Drawing.Point(169, 17);
            this.txtDebitPartyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDebitPartyName.Name = "txtDebitPartyName";
            this.txtDebitPartyName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDebitPartyName.Properties.ReadOnly = true;
            this.txtDebitPartyName.Size = new System.Drawing.Size(444, 22);
            this.txtDebitPartyName.TabIndex = 535;
            this.txtDebitPartyName.TabStop = false;
            // 
            // txtDebitPartyCode
            // 
            this.txtDebitPartyCode.Location = new System.Drawing.Point(79, 17);
            this.txtDebitPartyCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDebitPartyCode.Name = "txtDebitPartyCode";
            this.txtDebitPartyCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDebitPartyCode.Properties.MaxLength = 6;
            this.txtDebitPartyCode.Size = new System.Drawing.Size(85, 22);
            this.txtDebitPartyCode.TabIndex = 536;
            this.txtDebitPartyCode.EditValueChanged += new System.EventHandler(this.TxtDebitPartyCode_EditValueChanged);
            this.txtDebitPartyCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDebitPartyCode_KeyDown);
            // 
            // EOSSGrid
            // 
            this.EOSSGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode1.RelationName = "Level1";
            this.EOSSGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.EOSSGrid.Location = new System.Drawing.Point(1072, 314);
            this.EOSSGrid.MainView = this.EOSSGridView;
            this.EOSSGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EOSSGrid.Name = "EOSSGrid";
            this.EOSSGrid.Size = new System.Drawing.Size(282, 290);
            this.EOSSGrid.TabIndex = 540;
            this.EOSSGrid.TabStop = false;
            this.EOSSGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.EOSSGridView,
            this.gridView6});
            // 
            // EOSSGridView
            // 
            this.EOSSGridView.CustomizationFormBounds = new System.Drawing.Rectangle(580, 341, 252, 233);
            this.EOSSGridView.DetailHeight = 458;
            this.EOSSGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.EOSSGridView.GridControl = this.EOSSGrid;
            this.EOSSGridView.Name = "EOSSGridView";
            this.EOSSGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.EOSSGridView.OptionsPrint.PrintFooter = false;
            this.EOSSGridView.OptionsPrint.PrintGroupFooter = false;
            this.EOSSGridView.OptionsView.ShowFooter = true;
            this.EOSSGridView.OptionsView.ShowGroupPanel = false;
            this.EOSSGridView.OptionsView.ShowIndicator = false;
            // 
            // gridView6
            // 
            this.gridView6.DetailHeight = 458;
            this.gridView6.GridControl = this.EOSSGrid;
            this.gridView6.Name = "gridView6";
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            gridLevelNode2.RelationName = "Level1";
            this.HelpGrid.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.HelpGrid.Location = new System.Drawing.Point(257, 52);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(771, 268);
            this.HelpGrid.TabIndex = 539;
            this.HelpGrid.TabStop = false;
            this.HelpGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HelpGridView,
            this.gridView1});
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
            // gridView1
            // 
            this.gridView1.DetailHeight = 458;
            this.gridView1.GridControl = this.HelpGrid;
            this.gridView1.Name = "gridView1";
            // 
            // FreshGrid
            // 
            this.FreshGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FreshGrid.Location = new System.Drawing.Point(1072, 0);
            this.FreshGrid.MainView = this.FreshGridView;
            this.FreshGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FreshGrid.Name = "FreshGrid";
            this.FreshGrid.Size = new System.Drawing.Size(282, 306);
            this.FreshGrid.TabIndex = 448;
            this.FreshGrid.TabStop = false;
            this.FreshGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.FreshGridView,
            this.gridView3});
            // 
            // FreshGridView
            // 
            this.FreshGridView.CustomizationFormBounds = new System.Drawing.Rectangle(580, 341, 252, 233);
            this.FreshGridView.DetailHeight = 458;
            this.FreshGridView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.FreshGridView.GridControl = this.FreshGrid;
            this.FreshGridView.Name = "FreshGridView";
            this.FreshGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.FreshGridView.OptionsPrint.PrintFooter = false;
            this.FreshGridView.OptionsPrint.PrintGroupFooter = false;
            this.FreshGridView.OptionsView.ShowFooter = true;
            this.FreshGridView.OptionsView.ShowGroupPanel = false;
            this.FreshGridView.OptionsView.ShowIndicator = false;
            // 
            // gridView3
            // 
            this.gridView3.DetailHeight = 458;
            this.gridView3.GridControl = this.FreshGrid;
            this.gridView3.Name = "gridView3";
            // 
            // FrmImportSaleGSTDiffData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1363, 769);
            this.ControlBox = false;
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.Menu_ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmImportSaleGSTDiffData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmImportSaleGSTDiffData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            this.splitContainerControl1.Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitPartyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDebitPartyCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EOSSGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EOSSGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreshGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FreshGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl InfoGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView InfoGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnLoad;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDebitPartyName;
        private DevExpress.XtraEditors.TextEdit txtDebitPartyCode;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl EOSSGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView EOSSGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView6;
        private DevExpress.XtraGrid.GridControl FreshGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView FreshGridView;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
    }
}