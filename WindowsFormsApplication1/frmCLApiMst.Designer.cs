﻿
namespace WindowsFormsApplication1
{
    partial class frmCLApiMst
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCLApiMst));
            this.InvoiceGrid = new DevExpress.XtraGrid.GridControl();
            this.InvoiceGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.Menu_ToolStrip = new System.Windows.Forms.ToolStrip();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.btnAdd = new System.Windows.Forms.ToolStripButton();
            this.lbl = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.Menu_ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // InvoiceGrid
            // 
            this.InvoiceGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InvoiceGrid.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InvoiceGrid.Location = new System.Drawing.Point(0, 31);
            this.InvoiceGrid.MainView = this.InvoiceGridView;
            this.InvoiceGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.InvoiceGrid.Name = "InvoiceGrid";
            this.InvoiceGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.InvoiceGrid.Size = new System.Drawing.Size(1264, 529);
            this.InvoiceGrid.TabIndex = 200;
            this.InvoiceGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.InvoiceGridView});
            this.InvoiceGrid.Click += new System.EventHandler(this.InvoiceGrid_Click);
            // 
            // InvoiceGridView
            // 
            this.InvoiceGridView.DetailHeight = 458;
            this.InvoiceGridView.GridControl = this.InvoiceGrid;
            this.InvoiceGridView.Name = "InvoiceGridView";
            this.InvoiceGridView.OptionsBehavior.AllowIncrementalSearch = true;
            this.InvoiceGridView.OptionsBehavior.Editable = false;
            this.InvoiceGridView.OptionsView.ColumnAutoWidth = false;
            this.InvoiceGridView.OptionsView.ShowFooter = true;
            this.InvoiceGridView.OptionsView.ShowGroupPanel = false;
            this.InvoiceGridView.OptionsView.ShowIndicator = false;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            // 
            // Menu_ToolStrip
            // 
            this.Menu_ToolStrip.BackColor = System.Drawing.Color.DodgerBlue;
            this.Menu_ToolStrip.CanOverflow = false;
            this.Menu_ToolStrip.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Menu_ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu_ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnEdit,
            this.btnAdd,
            this.lbl});
            this.Menu_ToolStrip.Location = new System.Drawing.Point(0, 0);
            this.Menu_ToolStrip.Name = "Menu_ToolStrip";
            this.Menu_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.Menu_ToolStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Menu_ToolStrip.Size = new System.Drawing.Size(1264, 31);
            this.Menu_ToolStrip.TabIndex = 199;
            this.Menu_ToolStrip.Text = "Options";
            // 
            // btnEdit
            // 
            this.btnEdit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnEdit.Size = new System.Drawing.Size(50, 28);
            this.btnEdit.Text = "Edit";
            // 
            // btnAdd
            // 
            this.btnAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.btnAdd.Size = new System.Drawing.Size(52, 28);
            this.btnAdd.Text = "&Add";
            // 
            // lbl
            // 
            this.lbl.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lbl.ForeColor = System.Drawing.Color.White;
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(0, 28);
            // 
            // frmCLApiMst
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 560);
            this.ControlBox = false;
            this.Controls.Add(this.InvoiceGrid);
            this.Controls.Add(this.Menu_ToolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmCLApiMst";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCLApiMst_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.Menu_ToolStrip.ResumeLayout(false);
            this.Menu_ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl InvoiceGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView InvoiceGridView;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripButton btnAdd;
        private System.Windows.Forms.ToolStripLabel lbl;
    }
}