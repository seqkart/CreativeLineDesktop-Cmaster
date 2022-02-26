
namespace School_Management_System
{
    partial class frmAPIProducts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAPIProducts));
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.txttype = new DevExpress.XtraEditors.ComboBoxEdit();
            this.lbl = new System.Windows.Forms.ToolStripLabel();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtregular_price = new DevExpress.XtraEditors.TextEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtdescription = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtshort_description = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtregular_price.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshort_description.Properties)).BeginInit();
            this.SuspendLayout();
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 330;
            this.label7.Text = "id";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(189, 73);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(316, 20);
            this.txtid.TabIndex = 329;
            // 
            // txttype
            // 
            this.txttype.Location = new System.Drawing.Point(189, 125);
            this.txttype.Name = "txttype";
            this.txttype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txttype.Properties.Items.AddRange(new object[] {
            "simple"});
            this.txttype.Size = new System.Drawing.Size(100, 20);
            this.txttype.TabIndex = 328;
            // 
            // lbl
            // 
            this.lbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 23);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 321;
            this.label3.Text = "regular_price";
            // 
            // txtregular_price
            // 
            this.txtregular_price.Location = new System.Drawing.Point(189, 151);
            this.txtregular_price.Name = "txtregular_price";
            this.txtregular_price.Size = new System.Drawing.Size(316, 20);
            this.txtregular_price.TabIndex = 320;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 319;
            this.label2.Text = "type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 318;
            this.label1.Text = "name";
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
            this.Menu_ToolStrip.Size = new System.Drawing.Size(744, 26);
            this.Menu_ToolStrip.TabIndex = 317;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(189, 99);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(316, 20);
            this.txtname.TabIndex = 316;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 332;
            this.label4.Text = "description";
            // 
            // txtdescription
            // 
            this.txtdescription.Location = new System.Drawing.Point(189, 177);
            this.txtdescription.Name = "txtdescription";
            this.txtdescription.Size = new System.Drawing.Size(508, 20);
            this.txtdescription.TabIndex = 331;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 334;
            this.label5.Text = "short_description";
            // 
            // txtshort_description
            // 
            this.txtshort_description.Location = new System.Drawing.Point(189, 203);
            this.txtshort_description.Name = "txtshort_description";
            this.txtshort_description.Size = new System.Drawing.Size(508, 20);
            this.txtshort_description.TabIndex = 333;
            // 
            // frmAPIProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 276);
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtshort_description);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtdescription);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txttype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtregular_price);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.txtname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmAPIProducts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmAPIProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txttype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtregular_price.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshort_description.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.Label label7;
        public DevExpress.XtraEditors.TextEdit txtid;
        public DevExpress.XtraEditors.ComboBoxEdit txttype;
        private System.Windows.Forms.ToolStripLabel lbl;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.Label label3;
        public DevExpress.XtraEditors.TextEdit txtregular_price;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        public DevExpress.XtraEditors.TextEdit txtname;
        private System.Windows.Forms.Label label4;
        public DevExpress.XtraEditors.TextEdit txtdescription;
        private System.Windows.Forms.Label label5;
        public DevExpress.XtraEditors.TextEdit txtshort_description;
    }
}