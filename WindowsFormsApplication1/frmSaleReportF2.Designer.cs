namespace WindowsFormsApplication1
{
    partial class frmSaleReportF2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaleReportF2));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.CmpGrid = new DevExpress.XtraGrid.GridControl();
            this.CmpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CmpUnitGrid = new DevExpress.XtraGrid.GridControl();
            this.CmpUnitGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.InfoGrid = new DevExpress.XtraGrid.GridControl();
            this.InfoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblAverageBillSale = new DevExpress.XtraEditors.LabelControl();
            this.lblNoOfBills = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalSaleQty = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalSale = new DevExpress.XtraEditors.LabelControl();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmpUnitGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmpUnitGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.Menu_ToolStrip.CanOverflow = false;
            this.Menu_ToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu_ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuit});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(810, 31);
            this.Menu_ToolStrip.TabIndex = 686;
            this.Menu_ToolStrip.Text = "Options";
            this.Menu_ToolStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Menu_ToolStrip_ItemClicked);
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnQuit.Size = new System.Drawing.Size(53, 28);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Bahnschrift", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Location = new System.Drawing.Point(597, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 29);
            this.label1.TabIndex = 692;
            this.label1.Text = "TOTAL SALE";
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Bahnschrift", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Appearance.Options.UseFont = true;
            this.label2.Location = new System.Drawing.Point(597, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 29);
            this.label2.TabIndex = 693;
            this.label2.Text = "TOTAL QTY SOLD";
            // 
            // label3
            // 
            this.label3.Appearance.Font = new System.Drawing.Font("Bahnschrift", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Appearance.Options.UseFont = true;
            this.label3.Location = new System.Drawing.Point(597, 271);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 29);
            this.label3.TabIndex = 694;
            this.label3.Text = "AVERAGE SALE";
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Bahnschrift", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Appearance.Options.UseFont = true;
            this.label4.Location = new System.Drawing.Point(597, 196);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 29);
            this.label4.TabIndex = 695;
            this.label4.Text = "TOTAL BILLS";
            // 
            // CmpGrid
            // 
            this.CmpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmpGrid.Location = new System.Drawing.Point(14, 50);
            this.CmpGrid.MainView = this.CmpGridView;
            this.CmpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmpGrid.Name = "CmpGrid";
            this.CmpGrid.Size = new System.Drawing.Size(293, 298);
            this.CmpGrid.TabIndex = 691;
            this.CmpGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CmpGridView});
            // 
            // CmpGridView
            // 
            this.CmpGridView.DetailHeight = 458;
            this.CmpGridView.GridControl = this.CmpGrid;
            this.CmpGridView.Name = "CmpGridView";
            this.CmpGridView.OptionsView.ShowGroupPanel = false;
            this.CmpGridView.OptionsView.ShowIndicator = false;
            // 
            // CmpUnitGrid
            // 
            this.CmpUnitGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmpUnitGrid.Location = new System.Drawing.Point(314, 50);
            this.CmpUnitGrid.MainView = this.CmpUnitGridView;
            this.CmpUnitGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CmpUnitGrid.Name = "CmpUnitGrid";
            this.CmpUnitGrid.Size = new System.Drawing.Size(273, 298);
            this.CmpUnitGrid.TabIndex = 696;
            this.CmpUnitGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CmpUnitGridView});
            // 
            // CmpUnitGridView
            // 
            this.CmpUnitGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn2});
            this.CmpUnitGridView.DetailHeight = 458;
            this.CmpUnitGridView.GridControl = this.CmpUnitGrid;
            this.CmpUnitGridView.Name = "CmpUnitGridView";
            this.CmpUnitGridView.OptionsView.ShowGroupPanel = false;
            this.CmpUnitGridView.OptionsView.ShowIndicator = false;
            this.CmpUnitGridView.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.CmpUnitGridView_ValidatingEditor);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "UNITNAME";
            this.gridColumn1.FieldName = "UNITNAME";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "UNITID";
            this.gridColumn3.FieldName = "UNITID";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Select";
            this.gridColumn2.FieldName = "Select";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 87;
            // 
            // InfoGrid
            // 
            this.InfoGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoGrid.Location = new System.Drawing.Point(14, 358);
            this.InfoGrid.MainView = this.InfoGridView;
            this.InfoGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoGrid.Name = "InfoGrid";
            this.InfoGrid.Size = new System.Drawing.Size(790, 269);
            this.InfoGrid.TabIndex = 697;
            this.InfoGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InfoGridView});
            this.InfoGrid.Click += new System.EventHandler(this.InfoGrid_Click);
            // 
            // InfoGridView
            // 
            this.InfoGridView.DetailHeight = 458;
            this.InfoGridView.GridControl = this.InfoGrid;
            this.InfoGridView.Name = "InfoGridView";
            this.InfoGridView.OptionsView.ShowFooter = true;
            this.InfoGridView.OptionsView.ShowGroupPanel = false;
            this.InfoGridView.OptionsView.ShowIndicator = false;
            // 
            // lblAverageBillSale
            // 
            this.lblAverageBillSale.Appearance.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold);
            this.lblAverageBillSale.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lblAverageBillSale.Appearance.Options.UseFont = true;
            this.lblAverageBillSale.Appearance.Options.UseForeColor = true;
            this.lblAverageBillSale.Location = new System.Drawing.Point(597, 301);
            this.lblAverageBillSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblAverageBillSale.Name = "lblAverageBillSale";
            this.lblAverageBillSale.Size = new System.Drawing.Size(18, 40);
            this.lblAverageBillSale.TabIndex = 698;
            this.lblAverageBillSale.Text = "0";
            // 
            // lblNoOfBills
            // 
            this.lblNoOfBills.Appearance.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold);
            this.lblNoOfBills.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lblNoOfBills.Appearance.Options.UseFont = true;
            this.lblNoOfBills.Appearance.Options.UseForeColor = true;
            this.lblNoOfBills.Location = new System.Drawing.Point(597, 226);
            this.lblNoOfBills.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblNoOfBills.Name = "lblNoOfBills";
            this.lblNoOfBills.Size = new System.Drawing.Size(18, 40);
            this.lblNoOfBills.TabIndex = 698;
            this.lblNoOfBills.Text = "0";
            // 
            // lblTotalSaleQty
            // 
            this.lblTotalSaleQty.Appearance.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalSaleQty.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lblTotalSaleQty.Appearance.Options.UseFont = true;
            this.lblTotalSaleQty.Appearance.Options.UseForeColor = true;
            this.lblTotalSaleQty.Location = new System.Drawing.Point(597, 153);
            this.lblTotalSaleQty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotalSaleQty.Name = "lblTotalSaleQty";
            this.lblTotalSaleQty.Size = new System.Drawing.Size(18, 40);
            this.lblTotalSaleQty.TabIndex = 698;
            this.lblTotalSaleQty.Text = "0";
            // 
            // lblTotalSale
            // 
            this.lblTotalSale.Appearance.Font = new System.Drawing.Font("Bahnschrift", 20F, System.Drawing.FontStyle.Bold);
            this.lblTotalSale.Appearance.ForeColor = System.Drawing.Color.Green;
            this.lblTotalSale.Appearance.Options.UseFont = true;
            this.lblTotalSale.Appearance.Options.UseForeColor = true;
            this.lblTotalSale.Appearance.Options.UseTextOptions = true;
            this.lblTotalSale.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblTotalSale.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTotalSale.AppearanceDisabled.Options.UseTextOptions = true;
            this.lblTotalSale.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblTotalSale.AppearanceHovered.Options.UseTextOptions = true;
            this.lblTotalSale.AppearanceHovered.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblTotalSale.AppearancePressed.Options.UseTextOptions = true;
            this.lblTotalSale.AppearancePressed.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblTotalSale.LineLocation = DevExpress.XtraEditors.LineLocation.Bottom;
            this.lblTotalSale.Location = new System.Drawing.Point(597, 80);
            this.lblTotalSale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lblTotalSale.Name = "lblTotalSale";
            this.lblTotalSale.Size = new System.Drawing.Size(18, 40);
            this.lblTotalSale.TabIndex = 698;
            this.lblTotalSale.Text = "0";
            // 
            // frmSaleReportF2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(810, 638);
            this.ControlBox = false;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTotalSale);
            this.Controls.Add(this.lblTotalSaleQty);
            this.Controls.Add(this.lblNoOfBills);
            this.Controls.Add(this.lblAverageBillSale);
            this.Controls.Add(this.InfoGrid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CmpUnitGrid);
            this.Controls.Add(this.CmpGrid);
            this.Controls.Add(this.Menu_ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSaleReportF2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FrmSaleReportF2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmSaleReportF2_KeyDown);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CmpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmpUnitGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmpUnitGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraGrid.GridControl CmpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView CmpGridView;
        private DevExpress.XtraGrid.GridControl CmpUnitGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView CmpUnitGridView;
        private DevExpress.XtraGrid.GridControl InfoGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView InfoGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.LabelControl lblAverageBillSale;
        private DevExpress.XtraEditors.LabelControl lblNoOfBills;
        private DevExpress.XtraEditors.LabelControl lblTotalSaleQty;
        private DevExpress.XtraEditors.LabelControl lblTotalSale;
    }
}