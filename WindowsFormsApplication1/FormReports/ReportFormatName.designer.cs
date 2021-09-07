namespace WindowsFormsApplication1.FormReports
{
    partial class ReportFormatName
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.quitBtn = new DevExpress.XtraEditors.SimpleButton();
            this.FileName = new DevExpress.XtraEditors.TextEdit();
            this.SaveBtn = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.Title = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.FileName.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // quitBtn
            // 
            this.quitBtn.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.quitBtn.Appearance.Options.UseFont = true;
            this.quitBtn.Location = new System.Drawing.Point(357, 1);
            this.quitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(27, 30);
            this.quitBtn.TabIndex = 0;
            this.quitBtn.Text = "X";
            this.quitBtn.Click += new System.EventHandler(this.QuitBtn_Click);
            // 
            // FileName
            // 
            this.FileName.Location = new System.Drawing.Point(10, 78);
            this.FileName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(273, 24);
            this.FileName.TabIndex = 1;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(306, 78);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(65, 26);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "&Save";
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 51);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 17);
            this.labelControl1.TabIndex = 3;
            this.labelControl1.Text = "Layout Name";
            // 
            // Title
            // 
            this.Title.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.Title.Appearance.Options.UseFont = true;
            this.Title.Location = new System.Drawing.Point(3, 7);
            this.Title.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(92, 18);
            this.Title.TabIndex = 3;
            this.Title.Text = "Save Layout";
            // 
            // ReportFormatName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Title);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.quitBtn);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ReportFormatName";
            this.Size = new System.Drawing.Size(387, 132);
            ((System.ComponentModel.ISupportInitialize)(this.FileName.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton quitBtn;
        private DevExpress.XtraEditors.TextEdit FileName;
        private DevExpress.XtraEditors.SimpleButton SaveBtn;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl Title;
    }
}
