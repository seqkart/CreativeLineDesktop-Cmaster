using System;

namespace WindowsFormsApplication1.Administration
{
    public partial class FrmTaxClasses : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public FrmTaxClasses()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmTaxClasses_Load(object sender, EventArgs e)
        {
            txtslug.Enabled = false;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            if (S1 == "Add")
            {
                txtname.Focus();

            }
            if (S1 == "Edit")
            {

                txtname.Focus();
            }
        }
    }
}