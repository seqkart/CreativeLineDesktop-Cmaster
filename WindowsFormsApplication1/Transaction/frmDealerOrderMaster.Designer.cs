namespace WindowsFormsApplication1.Transaction
{
    partial class frmDealerOrderMaster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDealerOrderMaster));
            this.InfoGrid = new DevExpress.XtraGrid.GridControl();
            this.InfoGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtSUSType = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.dtOrderDate = new DevExpress.XtraEditors.DateEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.txtOrderNo = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.txtDealerName = new DevExpress.XtraEditors.TextEdit();
            this.label15 = new DevExpress.XtraEditors.LabelControl();
            this.txtDealerCode = new DevExpress.XtraEditors.TextEdit();
            this.dtOrderForDate = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSUSType.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrderDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrderDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrderForDate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrderForDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // InfoGrid
            // 
            this.InfoGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoGrid.Location = new System.Drawing.Point(14, 145);
            this.InfoGrid.MainView = this.InfoGridView;
            this.InfoGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InfoGrid.Name = "InfoGrid";
            this.InfoGrid.Size = new System.Drawing.Size(992, 441);
            this.InfoGrid.TabIndex = 419;
            this.InfoGrid.TabStop = false;
            this.InfoGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InfoGridView,
            this.gridView4});
            // 
            // InfoGridView
            // 
            this.InfoGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
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
            this.InfoGridView.ValidateRow += new DevExpress.XtraGrid.Views.Base.ValidateRowEventHandler(this.InfoGridView_ValidateRow);
            this.InfoGridView.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.InfoGridView_ValidatingEditor);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "GrpSubDesc";
            this.gridColumn5.FieldName = "GrpSubDesc";
            this.gridColumn5.MinWidth = 23;
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 2;
            this.gridColumn5.Width = 87;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "PrdCode";
            this.gridColumn1.FieldName = "OrdDPrdCode";
            this.gridColumn1.MinWidth = 23;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "OrdDPrdCode", "{0}")});
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            this.gridColumn1.Width = 87;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "PrdAsgnCode";
            this.gridColumn2.FieldName = "PrdAsgnCode";
            this.gridColumn2.MinWidth = 23;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 87;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "PrdName";
            this.gridColumn3.FieldName = "PrdName";
            this.gridColumn3.MinWidth = 23;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            this.gridColumn3.Width = 87;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Quantity";
            this.gridColumn4.DisplayFormat.FormatString = "n2";
            this.gridColumn4.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.gridColumn4.FieldName = "OrdDPrdQuantity";
            this.gridColumn4.MinWidth = 23;
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "OrdDPrdQuantity", "SUM={0:0.##}")});
            this.gridColumn4.UnboundExpression = "n2";
            this.gridColumn4.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 4;
            this.gridColumn4.Width = 87;
            // 
            // gridView4
            // 
            this.gridView4.DetailHeight = 458;
            this.gridView4.GridControl = this.InfoGrid;
            this.gridView4.Name = "gridView4";
            // 
            // txtSUSType
            // 
            this.txtSUSType.EnterMoveNextControl = true;
            this.txtSUSType.Location = new System.Drawing.Point(196, -33);
            this.txtSUSType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSUSType.Name = "txtSUSType";
            this.txtSUSType.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSUSType.Size = new System.Drawing.Size(30, 24);
            this.txtSUSType.TabIndex = 411;
            this.txtSUSType.TabStop = false;
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(1025, 31);
            this.Menu_ToolStrip.TabIndex = 416;
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
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-22, -29);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 17);
            this.label2.TabIndex = 410;
            this.label2.Text = "Date";
            // 
            // dtOrderDate
            // 
            this.dtOrderDate.EditValue = null;
            this.dtOrderDate.Enabled = false;
            this.dtOrderDate.Location = new System.Drawing.Point(103, 50);
            this.dtOrderDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtOrderDate.Name = "dtOrderDate";
            this.dtOrderDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtOrderDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtOrderDate.Properties.Mask.EditMask = "";
            this.dtOrderDate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.dtOrderDate.Size = new System.Drawing.Size(92, 24);
            this.dtOrderDate.TabIndex = 421;
            this.dtOrderDate.TabStop = false;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(20, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 423;
            this.label4.Text = "OrderDate";
            // 
            // txtOrderNo
            // 
            this.txtOrderNo.Enabled = false;
            this.txtOrderNo.Location = new System.Drawing.Point(288, 51);
            this.txtOrderNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtOrderNo.Name = "txtOrderNo";
            this.txtOrderNo.Size = new System.Drawing.Size(173, 24);
            this.txtOrderNo.TabIndex = 425;
            this.txtOrderNo.TabStop = false;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(220, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 17);
            this.label5.TabIndex = 420;
            this.label5.Text = "OrderNo";
            // 
            // txtDealerName
            // 
            this.txtDealerName.EnterMoveNextControl = true;
            this.txtDealerName.Location = new System.Drawing.Point(218, 85);
            this.txtDealerName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDealerName.Properties.ReadOnly = true;
            this.txtDealerName.Size = new System.Drawing.Size(759, 24);
            this.txtDealerName.TabIndex = 427;
            this.txtDealerName.TabStop = false;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(44, 89);
            this.label15.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 17);
            this.label15.TabIndex = 428;
            this.label15.Text = "Dealer";
            // 
            // txtDealerCode
            // 
            this.txtDealerCode.Location = new System.Drawing.Point(104, 85);
            this.txtDealerCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDealerCode.Name = "txtDealerCode";
            this.txtDealerCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDealerCode.Properties.MaxLength = 6;
            this.txtDealerCode.Size = new System.Drawing.Size(92, 24);
            this.txtDealerCode.TabIndex = 1;
            this.txtDealerCode.EditValueChanged += new System.EventHandler(this.TxtDealerCode_EditValueChanged);
            this.txtDealerCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtDealerCode_KeyDown);
            // 
            // dtOrderForDate
            // 
            this.dtOrderForDate.EditValue = null;
            this.dtOrderForDate.EnterMoveNextControl = true;
            this.dtOrderForDate.Location = new System.Drawing.Point(885, 51);
            this.dtOrderForDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtOrderForDate.Name = "dtOrderForDate";
            this.dtOrderForDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtOrderForDate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dtOrderForDate.Properties.DisplayFormat.FormatString = "dd-MM-yyyy";
            this.dtOrderForDate.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtOrderForDate.Properties.EditFormat.FormatString = "dd-MM-yyyy";
            this.dtOrderForDate.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dtOrderForDate.Properties.Mask.EditMask = "dd-MM-yyyy";
            this.dtOrderForDate.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.dtOrderForDate.Size = new System.Drawing.Size(92, 24);
            this.dtOrderForDate.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(770, 55);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 430;
            this.label3.Text = "Order For Date";
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(222, 38);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(782, 530);
            this.HelpGrid.TabIndex = 431;
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
            // frmDealerOrderMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1025, 607);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.InfoGrid);
            this.Controls.Add(this.dtOrderForDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDealerName);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtDealerCode);
            this.Controls.Add(this.dtOrderDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrderNo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSUSType);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmDealerOrderMaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmDealerOrderMaster_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmDealerOrderMaster_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.InfoGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InfoGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSUSType.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrderDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrderDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtOrderNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDealerCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrderForDate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtOrderForDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl InfoGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView InfoGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private DevExpress.XtraEditors.TextEdit txtSUSType;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.DateEdit dtOrderDate;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.TextEdit txtOrderNo;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.TextEdit txtDealerName;
        private DevExpress.XtraEditors.LabelControl label15;
        private DevExpress.XtraEditors.TextEdit txtDealerCode;
        private DevExpress.XtraEditors.DateEdit dtOrderForDate;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}