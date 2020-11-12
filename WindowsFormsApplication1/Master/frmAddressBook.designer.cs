namespace WindowsFormsApplication1
{
    partial class frmAddressBook
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
            this.SuspendLayout();
            // 
            // frmAddressBook
            // 
            this.ClientSize = new System.Drawing.Size(284, 259);
            this.Name = "frmAddressBook";
            this.Load += new System.EventHandler(this.frmAddressBook_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        internal DevExpress.XtraEditors.LabelControl label6;
        internal DevExpress.XtraEditors.LabelControl label16;
        internal DevExpress.XtraEditors.LabelControl label17;
        internal DevExpress.XtraEditors.LabelControl label18;
        internal DevExpress.XtraEditors.LabelControl label19;
        internal DevExpress.XtraEditors.LabelControl label22;
        internal DevExpress.XtraEditors.LabelControl label23;
        internal DevExpress.XtraEditors.LabelControl label24;
        internal DevExpress.XtraEditors.LabelControl label25;
        private DevExpress.XtraGrid.GridControl HelpGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView HelpGridView;
        private System.Windows.Forms.ToolStrip Menu_ToolStrip;
        private System.Windows.Forms.ToolStripButton btnQuit;
        private System.Windows.Forms.ToolStripButton btnSave;
        private DevExpress.XtraEditors.TextEdit txtAddress;
        private DevExpress.XtraEditors.TextEdit txtGroupCode;
        private DevExpress.XtraEditors.TextEdit txtGroupDesc;
        private DevExpress.XtraEditors.TextEdit txtFirstName;
        private DevExpress.XtraEditors.TextEdit txtLastName;
        private DevExpress.XtraEditors.TextEdit txtAddress1;
        private DevExpress.XtraEditors.TextEdit txtAddress2;
        private DevExpress.XtraEditors.TextEdit txtLandMark;
        private DevExpress.XtraEditors.TextEdit txtCompany;
        private DevExpress.XtraEditors.TextEdit txtEmailId;
        private DevExpress.XtraEditors.TextEdit txtContactNo;
        internal DevExpress.XtraEditors.LabelControl label1;
        internal DevExpress.XtraEditors.LabelControl label2;
        private DevExpress.XtraEditors.TextEdit txtAddressBookCode;
        internal DevExpress.XtraEditors.LabelControl label3;
        private DevExpress.XtraEditors.ComboBoxEdit txtTitle;
        private DevExpress.XtraEditors.TextEdit txtCountry;
        internal DevExpress.XtraEditors.LabelControl label12;
        private DevExpress.XtraEditors.TextEdit txtCityName;
        private DevExpress.XtraEditors.TextEdit txtState;
        private DevExpress.XtraEditors.TextEdit txtCityCode;
        internal DevExpress.XtraEditors.LabelControl Label5;
        internal DevExpress.XtraEditors.LabelControl Label4;
    }
}