namespace WindowsFormsApplication1.Misc_forms
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.radTitleBar1 = new Telerik.WinControls.UI.RadTitleBar();
            this.roundRectShapeTitle = new Telerik.WinControls.RoundRectShape(this.components);
            this.roundRectShapeForm = new Telerik.WinControls.RoundRectShape(this.components);
            this.radPanel1 = new Telerik.WinControls.UI.RadPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.radButton1 = new Telerik.WinControls.UI.RadButton();
            this.radChat1 = new Telerik.WinControls.UI.RadChat();
            this.radPanel2 = new Telerik.WinControls.UI.RadPanel();
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).BeginInit();
            this.radPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            this.SuspendLayout();
            // 
            // radTitleBar1
            // 
            this.radTitleBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radTitleBar1.Location = new System.Drawing.Point(-2, 1);
            this.radTitleBar1.Name = "radTitleBar1";
            // 
            // 
            // 
            this.radTitleBar1.RootElement.ApplyShapeToControl = true;
            this.radTitleBar1.RootElement.Shape = this.roundRectShapeTitle;
            this.radTitleBar1.Size = new System.Drawing.Size(511, 23);
            this.radTitleBar1.TabIndex = 0;
            this.radTitleBar1.TabStop = false;
            this.radTitleBar1.Text = "ShapedForm1";
            // 
            // roundRectShapeTitle
            // 
            this.roundRectShapeTitle.BottomLeftRounded = false;
            this.roundRectShapeTitle.BottomRightRounded = false;
            // 
            // radPanel1
            // 
            this.radPanel1.Controls.Add(this.radPanel2);
            this.radPanel1.Controls.Add(this.radButton1);
            this.radPanel1.Controls.Add(this.radChat1);
            this.radPanel1.Controls.Add(this.tableLayoutPanel1);
            this.radPanel1.Location = new System.Drawing.Point(12, 30);
            this.radPanel1.Name = "radPanel1";
            this.radPanel1.Size = new System.Drawing.Size(486, 523);
            this.radPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(301, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(161, 100);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // radButton1
            // 
            this.radButton1.Location = new System.Drawing.Point(325, 188);
            this.radButton1.Name = "radButton1";
            this.radButton1.Size = new System.Drawing.Size(137, 30);
            this.radButton1.TabIndex = 2;
            this.radButton1.Text = "radButton1";
            // 
            // radChat1
            // 
            this.radChat1.Location = new System.Drawing.Point(14, 40);
            this.radChat1.Name = "radChat1";
            this.radChat1.Size = new System.Drawing.Size(281, 481);
            this.radChat1.TabIndex = 3;
            this.radChat1.Text = "radChat1";
            this.radChat1.TimeSeparatorInterval = System.TimeSpan.Parse("1.00:00:00");
            // 
            // radPanel2
            // 
            this.radPanel2.Location = new System.Drawing.Point(313, 298);
            this.radPanel2.Name = "radPanel2";
            this.radPanel2.Size = new System.Drawing.Size(149, 125);
            this.radPanel2.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 603);
            this.Controls.Add(this.radPanel1);
            this.Controls.Add(this.radTitleBar1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            // 
            // 
            // 
            this.RootElement.ApplyShapeToControl = true;
            this.Text = "ShapedForm1";
            ((System.ComponentModel.ISupportInitialize)(this.radTitleBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel1)).EndInit();
            this.radPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.radButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radChat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.radPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.WinControls.UI.RadTitleBar radTitleBar1;
        private Telerik.WinControls.RoundRectShape roundRectShapeForm;
        private Telerik.WinControls.RoundRectShape roundRectShapeTitle;
        private Telerik.WinControls.UI.RadPanel radPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Telerik.WinControls.UI.RadButton radButton1;
        private Telerik.WinControls.UI.RadChat radChat1;
        private Telerik.WinControls.UI.RadPanel radPanel2;
    }
}
