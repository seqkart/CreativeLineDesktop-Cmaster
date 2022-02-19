﻿namespace WindowsFormsApplication1.Administration
{
    partial class FrmAutomaticPrograms
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
            this.btnCreateAssemblies = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrimaryKey = new DevExpress.XtraEditors.SimpleButton();
            this.btnSetMyCotrolsFunction = new DevExpress.XtraEditors.SimpleButton();
            this.btnGetNewMasterDocNo = new DevExpress.XtraEditors.SimpleButton();
            this.txtMDNTable = new DevExpress.XtraEditors.TextEdit();
            this.txtMDNField = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMDNTable.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMDNField.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateAssemblies
            // 
            this.btnCreateAssemblies.Location = new System.Drawing.Point(31, 58);
            this.btnCreateAssemblies.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCreateAssemblies.Name = "btnCreateAssemblies";
            this.btnCreateAssemblies.Size = new System.Drawing.Size(215, 39);
            this.btnCreateAssemblies.TabIndex = 0;
            this.btnCreateAssemblies.Text = "Include Assemblies";
            this.btnCreateAssemblies.Click += new System.EventHandler(this.BtnCreateAssemblies_Click);
            // 
            // btnPrimaryKey
            // 
            this.btnPrimaryKey.Location = new System.Drawing.Point(253, 58);
            this.btnPrimaryKey.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimaryKey.Name = "btnPrimaryKey";
            this.btnPrimaryKey.Size = new System.Drawing.Size(252, 39);
            this.btnPrimaryKey.TabIndex = 1;
            this.btnPrimaryKey.Text = "Generate Primary Key For Add Edit";
            this.btnPrimaryKey.Click += new System.EventHandler(this.BtnPrimaryKey_Click);
            // 
            // btnSetMyCotrolsFunction
            // 
            this.btnSetMyCotrolsFunction.Location = new System.Drawing.Point(31, 105);
            this.btnSetMyCotrolsFunction.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSetMyCotrolsFunction.Name = "btnSetMyCotrolsFunction";
            this.btnSetMyCotrolsFunction.Size = new System.Drawing.Size(215, 39);
            this.btnSetMyCotrolsFunction.TabIndex = 2;
            this.btnSetMyCotrolsFunction.Text = "Set My Controls";
            this.btnSetMyCotrolsFunction.Click += new System.EventHandler(this.BtnSetMyCotrolsFunction_Click);
            // 
            // btnGetNewMasterDocNo
            // 
            this.btnGetNewMasterDocNo.Location = new System.Drawing.Point(253, 105);
            this.btnGetNewMasterDocNo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGetNewMasterDocNo.Name = "btnGetNewMasterDocNo";
            this.btnGetNewMasterDocNo.Size = new System.Drawing.Size(252, 103);
            this.btnGetNewMasterDocNo.TabIndex = 3;
            this.btnGetNewMasterDocNo.Text = "Get New Master Doc No";
            this.btnGetNewMasterDocNo.Click += new System.EventHandler(this.BtnGetNewMasterDocNo_Click);
            // 
            // txtMDNTable
            // 
            this.txtMDNTable.Location = new System.Drawing.Point(89, 183);
            this.txtMDNTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMDNTable.Name = "txtMDNTable";
            this.txtMDNTable.Size = new System.Drawing.Size(156, 22);
            this.txtMDNTable.TabIndex = 4;
            // 
            // txtMDNField
            // 
            this.txtMDNField.Location = new System.Drawing.Point(89, 151);
            this.txtMDNField.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMDNField.Name = "txtMDNField";
            this.txtMDNField.Size = new System.Drawing.Size(156, 22);
            this.txtMDNField.TabIndex = 5;
            // 
            // FrmAutomaticPrograms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 244);
            this.Controls.Add(this.txtMDNField);
            this.Controls.Add(this.txtMDNTable);
            this.Controls.Add(this.btnGetNewMasterDocNo);
            this.Controls.Add(this.btnSetMyCotrolsFunction);
            this.Controls.Add(this.btnPrimaryKey);
            this.Controls.Add(this.btnCreateAssemblies);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAutomaticPrograms";
            ((System.ComponentModel.ISupportInitialize)(this.txtMDNTable.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMDNField.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnCreateAssemblies;
        private DevExpress.XtraEditors.SimpleButton btnPrimaryKey;
        private DevExpress.XtraEditors.SimpleButton btnSetMyCotrolsFunction;
        private DevExpress.XtraEditors.SimpleButton btnGetNewMasterDocNo;
        private DevExpress.XtraEditors.TextEdit txtMDNTable;
        private DevExpress.XtraEditors.TextEdit txtMDNField;
    }
}