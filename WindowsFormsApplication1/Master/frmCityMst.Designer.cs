namespace WindowsFormsApplication1.Master
{
    partial class FrmCityMst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCityMst));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtCItyName = new DevExpress.XtraEditors.TextEdit();
            this.txtCityCode = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtStateCode = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new DevExpress.XtraEditors.LabelControl();
            this.txtStateName = new DevExpress.XtraEditors.TextEdit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCItyName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStateCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStateName.Properties)).BeginInit();
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(486, 27);
            this.Menu_ToolStrip.TabIndex = 204;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(43, 24);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.BtnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(45, 24);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtCItyName
            // 
            this.txtCItyName.EnterMoveNextControl = true;
            this.txtCItyName.Location = new System.Drawing.Point(85, 70);
            this.txtCItyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCItyName.Name = "txtCItyName";
            this.txtCItyName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCItyName.Properties.MaxLength = 30;
            this.txtCItyName.Size = new System.Drawing.Size(379, 22);
            this.txtCItyName.TabIndex = 200;
            // 
            // txtCityCode
            // 
            this.txtCityCode.Location = new System.Drawing.Point(85, 36);
            this.txtCityCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCityCode.Name = "txtCityCode";
            this.txtCityCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCityCode.Size = new System.Drawing.Size(65, 22);
            this.txtCityCode.TabIndex = 201;
            this.txtCityCode.TabStop = false;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 203;
            this.label3.Text = "City Name";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(18, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 16);
            this.label1.TabIndex = 202;
            this.label1.Text = "City Code";
            // 
            // HelpGrid
            // 
            this.HelpGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Location = new System.Drawing.Point(40, 40);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(408, 191);
            this.HelpGrid.TabIndex = 409;
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
            // txtStateCode
            // 
            this.txtStateCode.EnterMoveNextControl = true;
            this.txtStateCode.Location = new System.Drawing.Point(85, 104);
            this.txtStateCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStateCode.Name = "txtStateCode";
            this.txtStateCode.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.txtStateCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStateCode.Properties.MaxLength = 4;
            this.txtStateCode.Size = new System.Drawing.Size(65, 22);
            this.txtStateCode.TabIndex = 410;
            this.txtStateCode.EditValueChanged += new System.EventHandler(this.TxtStateCode_EditValueChanged);
            this.txtStateCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TxtStateCode_KeyDown);
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(4, 109);
            this.label13.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 16);
            this.label13.TabIndex = 412;
            this.label13.Text = "Under State";
            // 
            // txtStateName
            // 
            this.txtStateName.Location = new System.Drawing.Point(157, 104);
            this.txtStateName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStateName.Name = "txtStateName";
            this.txtStateName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStateName.Properties.ReadOnly = true;
            this.txtStateName.Size = new System.Drawing.Size(307, 22);
            this.txtStateName.TabIndex = 411;
            this.txtStateName.TabStop = false;
            // 
            // FrmCityMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(486, 237);
            this.ControlBox = false;
            this.Controls.Add(this.HelpGrid);
            this.Controls.Add(this.txtStateCode);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtStateName);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtCItyName);
            this.Controls.Add(this.txtCityCode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmCityMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmCityMst_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmCityMst_KeyDown);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCItyName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCityCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HelpGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStateCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtStateName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtCItyName;
        private DevExpress.XtraEditors.TextEdit txtCityCode;
        private DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.LabelControl label1;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraEditors.TextEdit txtStateCode;
        private DevExpress.XtraEditors.LabelControl label13;
        private DevExpress.XtraEditors.TextEdit txtStateName;
    }
}