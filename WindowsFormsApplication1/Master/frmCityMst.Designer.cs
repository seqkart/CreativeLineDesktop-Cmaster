namespace WindowsFormsApplication1.Master
{
    partial class frmCityMst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCityMst));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.txtCItyName = new DevExpress.XtraEditors.TextEdit();
            this.txtCityCode = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.HelpGrid = new DevExpress.XtraGrid.GridControl();
            this.HelpGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.txtStateCode = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new System.Windows.Forms.Label();
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
            this.Menu_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnQuit,
            this.btnSave});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(588, 25);
            this.Menu_ToolStrip.TabIndex = 204;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(35, 22);
            this.btnQuit.Text = "Quit";
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(38, 22);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtCItyName
            // 
            this.txtCItyName.EnterMoveNextControl = true;
            this.txtCItyName.Location = new System.Drawing.Point(88, 69);
            this.txtCItyName.Name = "txtCItyName";
            this.txtCItyName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCItyName.Properties.MaxLength = 30;
            this.txtCItyName.Size = new System.Drawing.Size(325, 20);
            this.txtCItyName.TabIndex = 200;
            // 
            // txtCityCode
            // 
            this.txtCityCode.Location = new System.Drawing.Point(88, 43);
            this.txtCityCode.Name = "txtCityCode";
            this.txtCityCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCityCode.Size = new System.Drawing.Size(56, 20);
            this.txtCityCode.TabIndex = 201;
            this.txtCityCode.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 203;
            this.label3.Text = "City Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 202;
            this.label1.Text = "City Code";
            // 
            // HelpGrid
            // 
            this.HelpGrid.Location = new System.Drawing.Point(373, 28);
            this.HelpGrid.MainView = this.HelpGridView;
            this.HelpGrid.Name = "HelpGrid";
            this.HelpGrid.Size = new System.Drawing.Size(350, 221);
            this.HelpGrid.TabIndex = 409;
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
            // txtStateCode
            // 
            this.txtStateCode.EnterMoveNextControl = true;
            this.txtStateCode.Location = new System.Drawing.Point(90, 95);
            this.txtStateCode.Name = "txtStateCode";
            this.txtStateCode.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.False;
            this.txtStateCode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtStateCode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStateCode.Properties.MaxLength = 4;
            this.txtStateCode.Size = new System.Drawing.Size(69, 20);
            this.txtStateCode.TabIndex = 410;
            this.txtStateCode.EditValueChanged += new System.EventHandler(this.txtStateCode_EditValueChanged);
            this.txtStateCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtStateCode_KeyDown);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(21, 99);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(68, 13);
            this.label13.TabIndex = 412;
            this.label13.Text = "Under State";
            // 
            // txtStateName
            // 
            this.txtStateName.Location = new System.Drawing.Point(166, 95);
            this.txtStateName.Name = "txtStateName";
            this.txtStateName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtStateName.Properties.ReadOnly = true;
            this.txtStateName.Size = new System.Drawing.Size(247, 20);
            this.txtStateName.TabIndex = 411;
            this.txtStateName.TabStop = false;
            // 
            // frmCityMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 279);
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
            this.Name = "frmCityMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmCityMst_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCityMst_KeyDown);
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private DevExpress.XtraEditors.TextEdit txtStateCode;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.TextEdit txtStateName;
    }
}