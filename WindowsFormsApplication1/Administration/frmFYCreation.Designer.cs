namespace WindowsFormsApplication1
{
    partial class frmFYCreation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFYCreation));
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnQuit = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.cmbFY = new System.Windows.Forms.ComboBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.DtEnd = new DevExpress.XtraEditors.DateEdit();
            this.DtFrom = new DevExpress.XtraEditors.DateEdit();
            this.label12 = new DevExpress.XtraEditors.LabelControl();
            this.txtStatusTag = new System.Windows.Forms.ComboBox();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtEnd.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEnd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFrom.Properties)).BeginInit();
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(268, 31);
            this.Menu_ToolStrip.TabIndex = 317;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnQuit
            // 
            this.btnQuit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnQuit.Image = ((System.Drawing.Image)(resources.GetObject("btnQuit.Image")));
            this.btnQuit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(43, 28);
            this.btnQuit.Text = "&Quit";
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(10, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 318;
            this.label1.Text = "Financial Year";
            // 
            // cmbFY
            // 
            this.cmbFY.FormattingEnabled = true;
            this.cmbFY.Items.AddRange(new object[] {
            "2020-2021",
            "2021-2022",
            "2022-2023",
            "2023-2024",
            "2024-2025",
            "2025-2026"});
            this.cmbFY.Location = new System.Drawing.Point(102, 37);
            this.cmbFY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbFY.Name = "cmbFY";
            this.cmbFY.Size = new System.Drawing.Size(140, 25);
            this.cmbFY.TabIndex = 316;
            this.cmbFY.SelectedIndexChanged += new System.EventHandler(this.CmbSelectUser_SelectedIndexChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(43, 116);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 17);
            this.labelControl3.TabIndex = 320;
            this.labelControl3.Text = "To Date";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(28, 79);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(61, 17);
            this.labelControl2.TabIndex = 321;
            this.labelControl2.Text = "From Date";
            // 
            // DtEnd
            // 
            this.DtEnd.EditValue = null;
            this.DtEnd.EnterMoveNextControl = true;
            this.DtEnd.Location = new System.Drawing.Point(102, 112);
            this.DtEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtEnd.Name = "DtEnd";
            this.DtEnd.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtEnd.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DtEnd.Size = new System.Drawing.Size(141, 24);
            this.DtEnd.TabIndex = 322;
            // 
            // DtFrom
            // 
            this.DtFrom.EditValue = null;
            this.DtFrom.EnterMoveNextControl = true;
            this.DtFrom.Location = new System.Drawing.Point(102, 75);
            this.DtFrom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DtFrom.Name = "DtFrom";
            this.DtFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.DtFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.DtFrom.Size = new System.Drawing.Size(141, 24);
            this.DtFrom.TabIndex = 319;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(55, 153);
            this.label12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(34, 17);
            this.label12.TabIndex = 331;
            this.label12.Text = "Active";
            // 
            // txtStatusTag
            // 
            this.txtStatusTag.FormattingEnabled = true;
            this.txtStatusTag.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.txtStatusTag.Location = new System.Drawing.Point(102, 149);
            this.txtStatusTag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtStatusTag.Name = "txtStatusTag";
            this.txtStatusTag.Size = new System.Drawing.Size(140, 25);
            this.txtStatusTag.TabIndex = 332;
            // 
            // frmFYCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(268, 198);
            this.ControlBox = false;
            this.Controls.Add(this.txtStatusTag);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.DtEnd);
            this.Controls.Add(this.DtFrom);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbFY);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFYCreation";
            this.Load += new System.EventHandler(this.FrmFYCreation_Load);
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtEnd.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtEnd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DtFrom.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.LabelControl label1;
        private System.Windows.Forms.ComboBox cmbFY;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        public DevExpress.XtraEditors.DateEdit DtEnd;
        public DevExpress.XtraEditors.DateEdit DtFrom;
        private DevExpress.XtraEditors.LabelControl label12;
        private System.Windows.Forms.ComboBox txtStatusTag;
    }
}