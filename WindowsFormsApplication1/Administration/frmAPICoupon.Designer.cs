
namespace WindowsFormsApplication1.Administration
{
    partial class FrmAPICoupon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAPICoupon));
            this.label3 = new DevExpress.XtraEditors.LabelControl();
            this.txtamount = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new DevExpress.XtraEditors.LabelControl();
            this.label1 = new DevExpress.XtraEditors.LabelControl();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.lbl = new System.Windows.Forms.ToolStripLabel();
            this.txtcode = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new DevExpress.XtraEditors.LabelControl();
            this.label5 = new DevExpress.XtraEditors.LabelControl();
            this.label6 = new DevExpress.XtraEditors.LabelControl();
            this.txtminimum_amount = new DevExpress.XtraEditors.TextEdit();
            this.txtexclude_sale_items = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtindividual_use = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtdiscount_type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label7 = new DevExpress.XtraEditors.LabelControl();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
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
            this.label3.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Appearance.Options.UseFont = true;
            this.label3.Location = new System.Drawing.Point(89, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 306;
            this.label3.Text = "amount";
            // 
            // txtamount
            // 
            this.txtamount.Location = new System.Drawing.Point(147, 158);
            this.txtamount.Margin = new System.Windows.Forms.Padding(4);
            this.txtamount.Name = "txtamount";
            this.txtamount.Size = new System.Drawing.Size(133, 22);
            this.txtamount.TabIndex = 305;
            this.txtamount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txtamount_KeyPress);
            // 
            // label2
            // 
            this.label2.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Appearance.Options.UseFont = true;
            this.label2.Location = new System.Drawing.Point(48, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 304;
            this.label2.Text = "discount_type";
            // 
            // label1
            // 
            this.label1.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Appearance.Options.UseFont = true;
            this.label1.Location = new System.Drawing.Point(109, 89);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(334, 31);
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
            this.btnClose.Size = new System.Drawing.Size(67, 28);
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.Text = "DELETE";
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnSave.Size = new System.Drawing.Size(59, 28);
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // lbl
            // 
            this.lbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 28);
            // 
            // txtcode
            // 
            this.txtcode.Location = new System.Drawing.Point(147, 88);
            this.txtcode.Margin = new System.Windows.Forms.Padding(4);
            this.txtcode.Name = "txtcode";
            this.txtcode.Size = new System.Drawing.Size(133, 22);
            this.txtcode.TabIndex = 300;
            // 
            // label4
            // 
            this.label4.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Appearance.Options.UseFont = true;
            this.label4.Location = new System.Drawing.Point(45, 194);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 307;
            this.label4.Text = "individual_use";
            // 
            // label5
            // 
            this.label5.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Appearance.Options.UseFont = true;
            this.label5.Location = new System.Drawing.Point(15, 229);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 308;
            this.label5.Text = "exclude_sale_items";
            // 
            // label6
            // 
            this.label6.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Appearance.Options.UseFont = true;
            this.label6.Location = new System.Drawing.Point(18, 264);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 20);
            this.label6.TabIndex = 309;
            this.label6.Text = "minimum_amount";
            // 
            // txtminimum_amount
            // 
            this.txtminimum_amount.Location = new System.Drawing.Point(147, 263);
            this.txtminimum_amount.Margin = new System.Windows.Forms.Padding(4);
            this.txtminimum_amount.Name = "txtminimum_amount";
            this.txtminimum_amount.Size = new System.Drawing.Size(133, 22);
            this.txtminimum_amount.TabIndex = 310;
            this.txtminimum_amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextEdit1_KeyPress);
            // 
            // txtexclude_sale_items
            // 
            this.txtexclude_sale_items.Location = new System.Drawing.Point(147, 228);
            this.txtexclude_sale_items.Margin = new System.Windows.Forms.Padding(4);
            this.txtexclude_sale_items.Name = "txtexclude_sale_items";
            this.txtexclude_sale_items.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtexclude_sale_items.Properties.Items.AddRange(new object[] {
            "true",
            "false"});
            this.txtexclude_sale_items.Size = new System.Drawing.Size(133, 22);
            this.txtexclude_sale_items.TabIndex = 311;
            // 
            // txtindividual_use
            // 
            this.txtindividual_use.Location = new System.Drawing.Point(147, 193);
            this.txtindividual_use.Margin = new System.Windows.Forms.Padding(4);
            this.txtindividual_use.Name = "txtindividual_use";
            this.txtindividual_use.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtindividual_use.Properties.Items.AddRange(new object[] {
            "true",
            "false"});
            this.txtindividual_use.Size = new System.Drawing.Size(133, 22);
            this.txtindividual_use.TabIndex = 312;
            // 
            // txtdiscount_type
            // 
            this.txtdiscount_type.Location = new System.Drawing.Point(147, 123);
            this.txtdiscount_type.Margin = new System.Windows.Forms.Padding(4);
            this.txtdiscount_type.Name = "txtdiscount_type";
            this.txtdiscount_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtdiscount_type.Properties.Items.AddRange(new object[] {
            "percent",
            "fixed_cart",
            "fixed_product"});
            this.txtdiscount_type.Size = new System.Drawing.Size(133, 22);
            this.txtdiscount_type.TabIndex = 313;
            // 
            // label7
            // 
            this.label7.Appearance.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Appearance.Options.UseFont = true;
            this.label7.Location = new System.Drawing.Point(129, 54);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 20);
            this.label7.TabIndex = 315;
            this.label7.Text = "id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(147, 53);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(133, 22);
            this.txtid.TabIndex = 314;
            // 
            // FrmAPICoupon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 316);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmAPICoupon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.FrmAPICoupon_Load);
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

        private DevExpress.XtraEditors.LabelControl label3;
        public DevExpress.XtraEditors.TextEdit txtamount;
        private DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.LabelControl label1;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripLabel lbl;
        public DevExpress.XtraEditors.TextEdit txtcode;
        private DevExpress.XtraEditors.LabelControl label4;
        private DevExpress.XtraEditors.LabelControl label5;
        private DevExpress.XtraEditors.LabelControl label6;
        public DevExpress.XtraEditors.TextEdit txtminimum_amount;
        private DevExpress.XtraEditors.LabelControl label7;
        public DevExpress.XtraEditors.TextEdit txtid;
        public DevExpress.XtraEditors.ComboBoxEdit txtexclude_sale_items;
        public DevExpress.XtraEditors.ComboBoxEdit txtindividual_use;
        public DevExpress.XtraEditors.ComboBoxEdit txtdiscount_type;
        private System.Windows.Forms.ToolStripButton btnDelete;
    }
}