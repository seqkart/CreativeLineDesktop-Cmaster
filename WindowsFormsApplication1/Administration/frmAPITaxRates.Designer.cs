
namespace School_Management_System
{
    partial class frmAPITaxRates
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAPITaxRates));
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.lbl = new System.Windows.Forms.ToolStripLabel();
            this.txtstate = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcity = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.txtshipping = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtrate = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpostcode = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcountry = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtstate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipping.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpostcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcountry.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 320;
            this.label7.Text = "country";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(197, 51);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(316, 20);
            this.txtid.TabIndex = 319;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 318;
            this.label1.Text = "state";
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.Menu_ToolStrip.CanOverflow = false;
            this.Menu_ToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu_ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClose,
            this.btnDelete,
            this.btnSave,
            this.lbl});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(600, 26);
            this.Menu_ToolStrip.TabIndex = 317;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnClose
            // 
            this.btnClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnClose.Name = "btnClose";
            this.btnClose.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnClose.Size = new System.Drawing.Size(56, 23);
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnDelete.Size = new System.Drawing.Size(61, 23);
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnSave.Size = new System.Drawing.Size(49, 23);
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbl
            // 
            this.lbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 23);
            // 
            // txtstate
            // 
            this.txtstate.Location = new System.Drawing.Point(197, 130);
            this.txtstate.Name = "txtstate";
            this.txtstate.Size = new System.Drawing.Size(316, 20);
            this.txtstate.TabIndex = 316;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 322;
            this.label2.Text = "city";
            // 
            // txtcity
            // 
            this.txtcity.Location = new System.Drawing.Point(197, 156);
            this.txtcity.Name = "txtcity";
            this.txtcity.Size = new System.Drawing.Size(316, 20);
            this.txtcity.TabIndex = 321;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 324;
            this.label3.Text = "name";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(197, 77);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(316, 20);
            this.txtname.TabIndex = 323;
            // 
            // txtshipping
            // 
            this.txtshipping.Location = new System.Drawing.Point(197, 207);
            this.txtshipping.Name = "txtshipping";
            this.txtshipping.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtshipping.Properties.Items.AddRange(new object[] {
            "true",
            "false"});
            this.txtshipping.Size = new System.Drawing.Size(100, 20);
            this.txtshipping.TabIndex = 326;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(96, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 325;
            this.label4.Text = "shipping";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 13);
            this.label5.TabIndex = 328;
            this.label5.Text = "rate";
            // 
            // txtrate
            // 
            this.txtrate.Location = new System.Drawing.Point(197, 233);
            this.txtrate.Name = "txtrate";
            this.txtrate.Size = new System.Drawing.Size(316, 20);
            this.txtrate.TabIndex = 327;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(96, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 330;
            this.label6.Text = "pincode";
            // 
            // txtpostcode
            // 
            this.txtpostcode.Location = new System.Drawing.Point(197, 182);
            this.txtpostcode.Name = "txtpostcode";
            this.txtpostcode.Size = new System.Drawing.Size(316, 20);
            this.txtpostcode.TabIndex = 329;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(96, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 13);
            this.label8.TabIndex = 332;
            this.label8.Text = "id";
            // 
            // txtcountry
            // 
            this.txtcountry.Location = new System.Drawing.Point(197, 100);
            this.txtcountry.Name = "txtcountry";
            this.txtcountry.Size = new System.Drawing.Size(316, 20);
            this.txtcountry.TabIndex = 331;
            // 
            // frmAPITaxRates
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 313);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtcountry);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtpostcode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtrate);
            this.Controls.Add(this.txtshipping);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcity);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtstate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmAPITaxRates";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmAPITaxRates_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtstate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipping.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtrate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpostcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcountry.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        public DevExpress.XtraEditors.TextEdit txtid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripLabel lbl;
        public DevExpress.XtraEditors.TextEdit txtstate;
        private System.Windows.Forms.Label label2;
        public DevExpress.XtraEditors.TextEdit txtcity;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.TextEdit txtname;
        public DevExpress.XtraEditors.ComboBoxEdit txtshipping;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public DevExpress.XtraEditors.TextEdit txtrate;
        private System.Windows.Forms.Label label6;
        public DevExpress.XtraEditors.TextEdit txtpostcode;
        private System.Windows.Forms.Label label8;
        public DevExpress.XtraEditors.TextEdit txtcountry;
    }
}