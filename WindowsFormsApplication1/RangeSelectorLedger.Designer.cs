namespace WindowsFormsApplication1
{
    partial class RangeSelectorLedger
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RangeSelectorLedger));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.DtFrom = new DevExpress.XtraEditors.DateEdit();
            this.DtEnd = new DevExpress.XtraEditors.DateEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.BtnLoad = new DevExpress.XtraEditors.SimpleButton();
            this.MyValidationProvider = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.chParty = new DevExpress.XtraEditors.CheckEdit();
            this.chBSHead = new DevExpress.XtraEditors.CheckEdit();
            this.chLedger = new DevExpress.XtraEditors.CheckEdit();
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.DtFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyValidationProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chParty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chBSHead.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chLedger.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(236, 8);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(178, 24);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Statement Of Accounts";
            // 
            // DtFrom
            // 
            this.DtFrom.EditValue = null;
            this.DtFrom.EnterMoveNextControl = true;
            this.DtFrom.Location = new System.Drawing.Point(59, 51);
            this.DtFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtFrom.Properties.Appearance.Options.UseFont = true;
            this.DtFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DtFrom.Size = new System.Drawing.Size(117, 26);
            this.DtFrom.TabIndex = 0;
            // 
            // DtEnd
            // 
            this.DtEnd.EditValue = null;
            this.DtEnd.EnterMoveNextControl = true;
            this.DtEnd.Location = new System.Drawing.Point(207, 51);
            this.DtEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtEnd.Name = "DtEnd";
            this.DtEnd.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DtEnd.Properties.Appearance.Options.UseFont = true;
            this.DtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DtEnd.Size = new System.Drawing.Size(135, 26);
            this.DtEnd.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(18, 54);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 20);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "From";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(185, 54);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 20);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "To";
            // 
            // BtnLoad
            // 
            this.BtnLoad.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLoad.Appearance.Options.UseFont = true;
            this.BtnLoad.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnLoad.ImageOptions.Image")));
            this.BtnLoad.Location = new System.Drawing.Point(512, 493);
            this.BtnLoad.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BtnLoad.Name = "BtnLoad";
            this.BtnLoad.Size = new System.Drawing.Size(135, 37);
            this.BtnLoad.TabIndex = 6;
            this.BtnLoad.Text = "Load Report";
            this.BtnLoad.Click += new System.EventHandler(this.BtnLoad_Click);
            // 
            // MyValidationProvider
            // 
            this.MyValidationProvider.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Auto;
            // 
            // simpleButton1
            // 
            this.simpleButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(590, 8);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(35, 36);
            this.simpleButton1.TabIndex = 5;
            this.simpleButton1.Click += new System.EventHandler(this.SimpleButton1_Click);
            // 
            // chParty
            // 
            this.chParty.Location = new System.Drawing.Point(356, 52);
            this.chParty.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chParty.Name = "chParty";
            this.chParty.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chParty.Properties.Appearance.Options.UseFont = true;
            this.chParty.Properties.Caption = "Party";
            this.chParty.Size = new System.Drawing.Size(61, 24);
            this.chParty.TabIndex = 2;
            this.chParty.CheckedChanged += new System.EventHandler(this.ChParty_CheckedChanged);
            // 
            // chBSHead
            // 
            this.chBSHead.Location = new System.Drawing.Point(430, 52);
            this.chBSHead.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chBSHead.Name = "chBSHead";
            this.chBSHead.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chBSHead.Properties.Appearance.Options.UseFont = true;
            this.chBSHead.Properties.Caption = "BSHead";
            this.chBSHead.Size = new System.Drawing.Size(87, 24);
            this.chBSHead.TabIndex = 3;
            this.chBSHead.CheckedChanged += new System.EventHandler(this.ChBSHead_CheckedChanged);
            // 
            // chLedger
            // 
            this.chLedger.Location = new System.Drawing.Point(530, 52);
            this.chLedger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chLedger.Name = "chLedger";
            this.chLedger.Properties.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chLedger.Properties.Appearance.Options.UseFont = true;
            this.chLedger.Properties.Caption = "Group";
            this.chLedger.Properties.ImageOptions.SvgImageChecked = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("chLedger.Properties.ImageOptions.SvgImageChecked")));
            this.chLedger.Size = new System.Drawing.Size(87, 24);
            this.chLedger.TabIndex = 4;
            this.chLedger.CheckedChanged += new System.EventHandler(this.ChLedger_CheckedChanged);
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(3, 94);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(644, 391);
            this.HelpGrid.TabIndex = 5;
            this.HelpGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.HelpGridView});
            // 
            // HelpGridView
            // 
            this.HelpGridView.Appearance.EvenRow.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpGridView.Appearance.EvenRow.Options.UseFont = true;
            this.HelpGridView.Appearance.HotTrackedRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.HelpGridView.Appearance.HotTrackedRow.Options.UseForeColor = true;
            this.HelpGridView.Appearance.Row.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpGridView.Appearance.Row.Options.UseFont = true;
            this.HelpGridView.DetailHeight = 458;
            this.HelpGridView.GridControl = this.HelpGrid;
            this.HelpGridView.Name = "HelpGridView";
            this.HelpGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.HelpGridView.OptionsView.ShowGroupPanel = false;
            this.HelpGridView.OptionsView.ShowIndicator = false;
            // 
            // RangeSelectorLedger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.chLedger);
            this.Controls.Add(this.chBSHead);
            this.Controls.Add(this.chParty);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.BtnLoad);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.DtEnd);
            this.Controls.Add(this.DtFrom);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "RangeSelectorLedger";
            this.Size = new System.Drawing.Size(650, 542);
            this.Load += new System.EventHandler(this.RangeSelector_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DtFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyValidationProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chParty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chBSHead.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chLedger.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        public DevExpress.XtraEditors.DateEdit DtFrom;
        public DevExpress.XtraEditors.DateEdit DtEnd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        public DevExpress.XtraEditors.SimpleButton BtnLoad;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider MyValidationProvider;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        public DevExpress.XtraEditors.CheckEdit chParty;
        public DevExpress.XtraEditors.CheckEdit chBSHead;
        public DevExpress.XtraEditors.CheckEdit chLedger;
        public DevExpress.XtraGrid.GridControl HelpGrid;
        public DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
    }
}
