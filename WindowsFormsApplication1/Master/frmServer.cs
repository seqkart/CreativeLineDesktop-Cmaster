using SeqKartLibrary;
using SeqKartSecurity.Connections;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
namespace WindowsFormsApplication1.Master
{
    public partial class FrmServer : DevExpress.XtraEditors.XtraForm
    {
        public FrmServer()
        {
            InitializeComponent();
        }
        private void BtnTestConnection_Click(object sender, EventArgs e)
        {

            string connetionString = @"Data Source=" + txtServerName.Text.Trim() + ";Initial Catalog=" + txtDataBaseName.Text.Trim() + ";User ID=" + txtUserName.Text.Trim() + ";Password=" + txtPassword.Text.Trim();
            SqlConnection cnn = new SqlConnection(connetionString);
            try
            {
                cnn.Open();
                cnn.Close();
                this.Hide();



                StreamWriter sw = new StreamWriter(Application.StartupPath + @"\HO.txt");
                sw.WriteLine(connetionString.Trim());
                sw.Close();


                ConnectionStringsDb.DefaultConnectionString = System.IO.File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"\HO.txt").Trim();
                ProjectFunctions.ConnectionString = ConnectionStringsDb.DefaultConnectionString;
                ProjectFunctionsUtils.ConnectionString = ConnectionStringsDb.DefaultConnectionString;
                WindowsFormsApplication1.FrmLogins frm = new FrmLogins();
                frm.ShowDialog();
                frm.BringToFront();


            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError("Unable To Connect" + ex);
            }


        }

        private void FrmServer_Load(object sender, EventArgs e)
        {
            DataTable table = System.Data.Sql.SqlDataSourceEnumerator.Instance.GetDataSources();
            foreach (DataRow server in table.Rows)
            {
                txtServerName.Properties.Items.Add(server[table.Columns["ServerName"]].ToString());
            }
            txtLoginType.Text = "SQLSERVER";
            txtUserName.Text = "sa";

        }

        private void TxtServerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TxtPassword_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                if (txtUserName.Text.Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Sql Server Login User");
                    txtUserName.Focus();
                    return;
                }
                if (txtPassword.Text.Length == 0)
                {
                    ProjectFunctions.SpeakError("Invalid Sql Server Login User");
                    txtPassword.Focus();
                    return;
                }
                txtDataBaseName.Properties.Items.Clear();
                string connetionString = @"Data Source=" + txtServerName.Text + ";Initial Catalog=master;User ID=" + txtUserName.Text + ";Password=" + txtPassword.Text + ";";
                DataSet dsDatabases = ProjectFunctions.GetDataSet("select name as DatabaseName from sys.databases   where database_id>4", connetionString);
                if (dsDatabases.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dsDatabases.Tables[0].Rows)
                    {
                        txtDataBaseName.Properties.Items.Add(dr["DatabaseName"].ToString());

                    }
                }
            }
        }
        private void TxtLoginType_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (txtLoginType.Text.ToUpper() == "SQLSERVER")
            {
                txtUserName.Text = "sa";
                txtPassword.Enabled = true;
                txtPassword.Focus();
            }
            else
            {
                txtUserName.Text = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                txtPassword.Enabled = false;
                txtDataBaseName.Properties.Items.Clear();

                string connetionString = @"Data Source=" + txtServerName.Text + ";Initial Catalog=master;Integrated Security=true";
                DataSet dsDatabases = ProjectFunctions.GetDataSet("select name as DatabaseName from sys.databases", connetionString);
                if (dsDatabases.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dsDatabases.Tables[0].Rows)
                    {
                        txtDataBaseName.Properties.Items.Add(dr["DatabaseName"].ToString());

                    }
                }

            }
        }

        private void BtnConnect_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}