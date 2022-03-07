
namespace WindowsFormsApplication1.Administration
{
    partial class frmShippingMethods
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmShippingMethods));
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtTitle = new DevExpress.XtraEditors.TextEdit();
            this.txtDescription = new DevExpress.XtraEditors.TextEdit();
            this.txt_Links = new DevExpress.XtraEditors.TextEdit();
            this.txtCollection = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnClose = new System.Windows.Forms.ToolStripButton();
            this.lbl = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Links.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCollection.Properties)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(180, 73);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(647, 22);
            this.txtID.TabIndex = 0;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(180, 105);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(647, 22);
            this.txtTitle.TabIndex = 1;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(180, 137);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(647, 22);
            this.txtDescription.TabIndex = 2;
            // 
            // txt_Links
            // 
            this.txt_Links.Location = new System.Drawing.Point(180, 169);
            this.txt_Links.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Links.Name = "txt_Links";
            this.txt_Links.Size = new System.Drawing.Size(647, 22);
            this.txt_Links.TabIndex = 3;
            // 
            // txtCollection
            // 
            this.txtCollection.Location = new System.Drawing.Point(180, 201);
            this.txtCollection.Margin = new System.Windows.Forms.Padding(4);
            this.txtCollection.Name = "txtCollection";
            this.txtCollection.Size = new System.Drawing.Size(647, 22);
            this.txtCollection.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(88, 76);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(13, 16);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "ID";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(87, 107);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 16);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "Title";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(88, 140);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(68, 16);
            this.labelControl3.TabIndex = 7;
            this.labelControl3.Text = "Description";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(87, 172);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 16);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Link";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(87, 204);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(4);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(59, 16);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "Collection";
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
            this.lbl});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(919, 31);
            this.Menu_ToolStrip.TabIndex = 200;
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
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lbl
            // 
            this.lbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 28);
            // 
            // frmShippingMethods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 265);
            this.ControlBox = false;
            this.Controls.Add(this.Menu_ToolStrip);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtCollection);
            this.Controls.Add(this.txt_Links);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmShippingMethods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Load += new System.EventHandler(this.frmShippingMethods_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTitle.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txt_Links.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCollection.Properties)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtTitle;
        private DevExpress.XtraEditors.TextEdit txtDescription;
        private DevExpress.XtraEditors.TextEdit txt_Links;
        private DevExpress.XtraEditors.TextEdit txtCollection;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnClose;
        private System.Windows.Forms.ToolStripLabel lbl;
    }
}