using System;
namespace WindowsFormsApplication1.Administration
{
    public partial class FrmShippingMethods : DevExpress.XtraEditors.XtraForm
    {
        public String S1 { get; set; }
        public String ID { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public String Link { get; set; }
        public String Collection { get; set; }
        public FrmShippingMethods()
        {
            InitializeComponent();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmShippingMethods_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            if (S1 == "Add")
            {
                txtTitle.Focus();

            }
            if (S1 == "Edit")
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