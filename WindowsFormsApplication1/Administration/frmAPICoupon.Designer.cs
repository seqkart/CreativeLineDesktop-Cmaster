
namespace School_Management_System
{
    partial class frmAPICoupon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAPICoupon));
            this.label3 = new System.Windows.Forms.Label();
            this.txtamount = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.lbl = new System.Windows.Forms.ToolStripLabel();
            this.txtcode = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtminimum_amount = new DevExpress.XtraEditors.TextEdit();
            this.txtexclude_sale_items = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtindividual_use = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtdiscount_type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtamount.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtminimum_amount.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtexclude_sale_items.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtindividual_use.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiscount_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 306;
            this.label3.Text = "amount";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(179, 139);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(316, 20);
            this.txtamount.TabIndex = 305;
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtamount_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 304;
            this.label2.Text = "discount_type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 303;
            this.label1.Text = "code";
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(562, 26);
            this.Menu_ToolStrip.TabIndex = 302;
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
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(179, 87);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(316, 20);
            this.txtcode.TabIndex = 300;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 173);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 307;
            this.label4.Text = "individual_use";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 308;
            this.label5.Text = "exclude_sale_items";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 309;
            this.label6.Text = "minimum_amount";
            // 
            // txtminimum_amount
            // 
            this.txtminimum_amount.Location = new System.Drawing.Point(179, 232);
            this.txtminimum_amount.Name = "txtminimum_amount";
            this.txtminimum_amount.Size = new System.Drawing.Size(316, 20);
            this.txtminimum_amount.TabIndex = 310;
            this.txtminimum_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit1_KeyPress);
            // 
            // txtexclude_sale_items
            // 
            this.txtexclude_sale_items.Location = new System.Drawing.Point(179, 199);
            this.txtexclude_sale_items.Name = "txtexclude_sale_items";
            this.txtexclude_sale_items.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtexclude_sale_items.Properties.Items.AddRange(new object[] {
            "true",
            "false"});
            this.txtexclude_sale_items.Size = new System.Drawing.Size(100, 20);
            this.txtexclude_sale_items.TabIndex = 311;
            // 
            // txtindividual_use
            // 
            this.txtindividual_use.Location = new System.Drawing.Point(179, 174);
            this.txtindividual_use.Name = "txtindividual_use";
            this.txtindividual_use.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtindividual_use.Properties.Items.AddRange(new object[] {
            "true",
            "false"});
            this.txtindividual_use.Size = new System.Drawing.Size(100, 20);
            this.txtindividual_use.TabIndex = 312;
            // 
            // txtdiscount_type
            // 
            this.txtdiscount_type.Location = new System.Drawing.Point(179, 113);
            this.txtdiscount_type.Name = "txtdiscount_type";
            this.txtdiscount_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdiscount_type.Properties.Items.AddRange(new object[] {
            "percent",
            "fixed_cart",
            "fixed_product"});
            this.txtdiscount_type.Size = new System.Drawing.Size(100, 20);
            this.txtdiscount_type.TabIndex = 313;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 315;
            this.label7.Text = "id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(179, 61);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(316, 20);
            this.txtid.TabIndex = 314;
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
            // frmAPICoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 296);
            this.ControlBox = false;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtdiscount_type);
            this.Controls.Add(this.txtindividual_use);
            this.Controls.Add(this.txtexclude_sale_items);
            this.Controls.Add(this.txtminimum_amount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtamount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtcode);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAPICoupon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmAPICoupon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtamount.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtminimum_amount.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtexclude_sale_items.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtindividual_use.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdiscount_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.TextEdit txtamount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripLabel lbl;
        public DevExpress.XtraEditors.TextEdit txtcode;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        public DevExpress.XtraEditors.TextEdit txtminimum_amount;
        private System.Windows.Forms.Label label7;
        public DevExpress.XtraEditors.TextEdit txtid;
        public DevExpress.XtraEditors.ComboBoxEdit txtexclude_sale_items;
        public DevExpress.XtraEditors.ComboBoxEdit txtindividual_use;
        public DevExpress.XtraEditors.ComboBoxEdit txtdiscount_type;
        private System.Windows.Forms.ToolStripButton btnDelete;
    }
}