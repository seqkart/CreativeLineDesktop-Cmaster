using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Administration
{
    public partial class frmTaxClasses : DevExpress.XtraEditors.XtraForm
    {
        public String s1 { get; set; }
        public frmTaxClasses()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTaxClasses_Load(object sender, EventArgs e)
        {
            txtslug.Enabled = false;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            if (s1 == "Add")
            {
                txtname.Focus();

            }
            if (s1 == "Edit")
            {
               
                txtname.Focus();
            }
        }
    }
}