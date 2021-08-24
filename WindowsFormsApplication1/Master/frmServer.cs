using System;
using System.Data.SqlClient;
using System.Linq;

namespace WindowsFormsApplication1.Master
{
    public partial class frmServer : DevExpress.XtraEditors.XtraForm
    {
        public frmServer()
        {
            InitializeComponent();
        }
        private void btnTestConnection_Click(object sender, EventArgs e)
        {

            string connetionString = @"Data Source=;Initial Catalog=;User ID=;Password=";
            SqlConnection cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                cnn.Close();


            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError("Unable To Connect");
            }


        }

    }
}