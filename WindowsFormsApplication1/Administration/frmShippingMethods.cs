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
using WindowsFormsApplication1;
namespace School_Management_System
{
    public partial class frmShippingMethods : DevExpress.XtraEditors.XtraForm
    {
        public String s1 { get; set; }
        public String ID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Link { get; set; }
        public String Collection { get; set; }
        public frmShippingMethods()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmShippingMethods_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            if (s1 == "Add")
            {
                txtTitle.Focus();

            }
            if (s1 == "Edit")
            {
                txtID.Text = ID;
                txtTitle.Text = Title;
                txtDescription.Text = Description;
                txt_Links.Text = Link;
                txtCollection.Text = Collection;
                txtTitle.Focus();

            }
        }

        
    }
}