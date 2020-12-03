using DevExpress.XtraSplashScreen;
using SeqKartLibrary;
using System;
using System.Data;
using System.IO;
using System.Net;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{
    public partial class FrmLogins : DevExpress.XtraEditors.XtraForm
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow", SetLastError = true)]

        public static extern IntPtr FindWindow(IntPtr ZeroOnly, string lpWindowName);



        [DllImport("user32.dll")]
        public static extern void Keybd_event(byte bVk, byte bScan, uint dwFlags, IntPtr dwExtraInfo);



        [DllImport("user32.dll")]

        [return: MarshalAs(UnmanagedType.Bool)]

        static extern bool SetForegroundWindow(IntPtr hWnd);


        private readonly bool isDebug = false;
        public FrmLogins()
        {
            InitializeComponent();
            dTP1.Text = DateTime.Now.ToLongDateString();

        }


        private void BtnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private bool ValidateData()
        {
            if (txtUserName.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid UserName");
                txtUserName.Focus();
                return false;
            }
            if (txtPassword.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Password");
                txtPassword.Focus();
                return false;
            }

            DataSet dsGetUser = ProjectFunctions.GetDataSet(SQL_QUERIES.SQL_USERMASTER(txtUserName.Text.Trim(), txtPassword.Text.Trim()));
            if (dsGetUser.Tables[0].Rows.Count > 0)
            {
                GlobalVariables.CurrentUser = txtUserName.Text;
            }
            else
            {

                ProjectFunctions.SpeakError("Invalid Username or Password");
                txtUserName.Focus();
                return false;
            }
            if (DateTime.Now.Date <= GlobalVariables.LicenseToExpireDate.Date)
            {
                if (DateTime.Now.Date >= Convert.ToDateTime("2020-04-1").Date && DateTime.Now.Date <= Convert.ToDateTime("2022-03-31").Date)
                {
                    if (Math.Abs((DateTime.Now.Date - GlobalVariables.LicenseToExpireDate.Date).Days) < 30)
                    {
                        ProjectFunctions.SpeakError("Only " + Math.Abs((DateTime.Now.Date - GlobalVariables.LicenseToExpireDate.Date).Days) + " Days Left For Liscense To Expire,Please Recharge Immediately");
                    }
                }
                else
                {
                    ProjectFunctions.SpeakError("Unauthorised Access");
                    return false;
                }
            }
            else
            {
                ProjectFunctions.SpeakError("License Has Been Expired");
                return false;
            }

            return true;
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateData())
                {
                    DataSet dsCompany = ProjectFunctions.GetDataSet(SQL_QUERIES.SQL_COMCONF_ALL());
                    DataRow dr = dsCompany.Tables[0].Rows[0];

                    GlobalVariables.CAddress1 = dr[SQL_COLUMNS.COMCONF._COMADD].ToString();
                    GlobalVariables.CAddress2 = dr[SQL_COLUMNS.COMCONF._COMADD1].ToString();
                    GlobalVariables.CAddress3 = dr[SQL_COLUMNS.COMCONF._COMADD2].ToString();
                    GlobalVariables.CmpGSTNo = dr[SQL_COLUMNS.COMCONF._COMGST].ToString();
                    GlobalVariables.CompanyName = dr[SQL_COLUMNS.COMCONF._COMNAME].ToString();
                    GlobalVariables.TelNo = dr[SQL_COLUMNS.COMCONF._COMPHONE].ToString();
                    GlobalVariables.CmpEmailID = dr[SQL_COLUMNS.COMCONF._COMEID].ToString();
                    GlobalVariables.CmpZipCode = dr[SQL_COLUMNS.COMCONF._COMZIP].ToString();
                    GlobalVariables.CmpWebSite = dr[SQL_COLUMNS.COMCONF._COMWEBSITE].ToString();

                    DataSet dsFY = ProjectFunctions.GetDataSet(SQL_QUERIES.SQL_FN_YEAR(txtFNYear.Text));
                    DataRow drFY = dsFY.Tables[0].Rows[0];

                    GlobalVariables.CUnitID = txtUnit.SelectedValue.ToString().PadLeft(2, '0');


                    GlobalVariables.FinancialYear = drFY[SQL_COLUMNS.FN_YEAR._FNYearCode].ToString();
                    GlobalVariables.FinYearStartDate = Convert.ToDateTime(drFY[SQL_COLUMNS.FN_YEAR._FNStartDate]).Date;
                    GlobalVariables.FinYearEndDate = Convert.ToDateTime(drFY[SQL_COLUMNS.FN_YEAR._FNEndDate]).Date;

                    GlobalVariables.BarCodePreFix = ProjectFunctions.GetDataSet(SQL_QUERIES.SQL_UNITS(GlobalVariables.CUnitID)).Tables[0].Rows[0][0].ToString();


                    WindowsFormsApplication1.XtraForm1 frm = new WindowsFormsApplication1.XtraForm1();

                    Hide();
                    //  BtnBackup_Click(null, null);
                    ProjectFunctions.Speak("WELCOME TO " + dr[SQL_COLUMNS.COMCONF._COMNAME].ToString());
                    frm.ShowDialog(Parent);
                    frm.BringToFront();

                }
            }

            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void FrmLogincs_Load(object sender, EventArgs e)
        {
            if (System.IO.Directory.Exists("C:\\Application"))
            {

            }
            else
            {
                System.IO.Directory.CreateDirectory("C:\\Application");
            }
            if (System.IO.Directory.Exists("C:\\Temp"))
            {

            }
            else
            {
                System.IO.Directory.CreateDirectory("C:\\Temp");
            }

            if (System.IO.Directory.Exists(Application.StartupPath + "\\PTFile"))
            {

            }
            else
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\PTFile");
            }
            if (System.IO.Directory.Exists(Application.StartupPath + "\\LABEL"))
            {

            }
            else
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\LABEL");
            }
            if (System.IO.Directory.Exists(Application.StartupPath + "\\PI"))
            {

            }
            else
            {
                System.IO.Directory.CreateDirectory(Application.StartupPath + "\\PI");
            }

            defaultLookAndFeel1.LookAndFeel.SkinName = "McSkin";
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ButtonVisualize(this);


            DataSet dsCompany = ProjectFunctionsUtils.GetDataSet(SQL_QUERIES.SQL_COMCONF());
            if (ComparisonUtils.IsNotNull_DataSet(dsCompany))
            {
                txtCompany.DataSource = dsCompany.Tables[0];
                txtCompany.ValueMember = SQL_COLUMNS.COMCONF._COMSYSID;// "COMSYSID";
                txtCompany.DisplayMember = SQL_COLUMNS.COMCONF._COMNAME;// "COMNAME";
            }

            //DataSet dsFNYear = ProjectFunctionsUtils.GetDataSet(SQL_QUERIES.SQL_FN_YEAR_ACTIVE("Y"));
            //if (ComparisonUtils.IsNotNull_DataSet(dsFNYear))
            //{
            //    txtFNYear.DataSource = dsFNYear.Tables[0];
            //    txtFNYear.ValueMember = SQL_COLUMNS.FN_YEAR._FNYearCode;
            //    txtFNYear.DisplayMember = SQL_COLUMNS.FN_YEAR._FNYearCode;
            //}
            if (isDebug)
            {
                //MessageBox.Show(dsFNYear.Tables[0].Rows.Count.ToString());
                txtPassword.Text = "123";
                txtUserName.Text = "HAPPY";
                SendKeys.Send("{Enter}");

                txtUserName.Focus();


                TxtUserName_KeyDown(null, null);
                BtnLogin_Click(null, null);
            }



        }

        private void TxtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                DataSet dsGetUser = ProjectFunctionsUtils.GetDataSet(SQL_QUERIES.SQL_USERMASTER_BY_USER(txtUserName.Text.Trim()));
                if (ComparisonUtils.IsNotNull_DataSet(dsGetUser))
                {
                    GlobalVariables.CurrentUser = txtUserName.Text;
                    DataSet dsUnit = ProjectFunctionsUtils.GetDataSet(SQL_QUERIES.SQL_UNITS_BY_USER(txtUserName.Text));
                    if (ComparisonUtils.IsNotNull_DataSet(dsUnit))
                    {
                        txtUnit.DataSource = dsUnit.Tables[0];
                        txtUnit.ValueMember = SQL_COLUMNS.UNITS._UNITID;
                        txtUnit.DisplayMember = SQL_COLUMNS.UNITS._UNITNAME;
                    }
                    DataSet dsFNYear = ProjectFunctionsUtils.GetDataSet(SQL_QUERIES.SQL_USER_FN_ACCESS_BY_USER(txtUserName.Text));
                    if (ComparisonUtils.IsNotNull_DataSet(dsFNYear))
                    {
                        txtFNYear.DataSource = dsFNYear.Tables[0];
                        txtFNYear.ValueMember = SQL_COLUMNS.FN_YEAR._FNYearCode;
                        txtFNYear.DisplayMember = SQL_COLUMNS.FN_YEAR._FNYearCode;
                    }

                    DataSet dsFNYear2 = ProjectFunctionsUtils.GetDataSet(SQL_QUERIES.SQL_FN_YEAR_ACTIVE("Y"));
                    if (ComparisonUtils.IsNotNull_DataSet(dsFNYear2))
                    {
                        txtFNYear.SelectedValue = dsFNYear2.Tables[0].Rows[0]["FNYearCode"].ToString();
                        //txtFNYear.ValueMember = SQL_COLUMNS.FN_YEAR._FNYearCode;
                        //txtFNYear.DisplayMember = SQL_COLUMNS.FN_YEAR._FNYearCode;
                    }
                }
                else
                {
                    ProjectFunctions.SpeakError("Invalid UserName");
                }
            }
        }

        private void TxtCompany_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtUnit.Focus();
            }
        }

        private void TxtUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                txtFNYear.Focus();
                txtFNYear.Text = "2020-2021";
            }
        }

        private void TxtFNYear_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                btnLogin.Focus();
            }
        }

        private void TxtUserName_DoubleClick(object sender, EventArgs e)
        {

            txtUserName.Text = "HAPPY";

            SendKeys.Send("{Enter}");
            dTP1.Text = DateTime.Now.ToLongDateString();


        }

        private void BtnBackup_Click(object sender, EventArgs e)


        {


            DevExpress.XtraSplashScreen.SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false, true);
            DevExpress.XtraSplashScreen.SplashScreenManager.Default.SetWaitFormDescription("Backing Up Initialized");



            {
                NetworkCredential theNetworkCredential = new NetworkCredential(@"cserver\c server", "Rohit@123");
                if (System.IO.Directory.Exists(@"\\cserver\F\Backupseqkart\" + DateTime.Now.DayOfWeek.ToString()))
                {

                    string srcDir = @"\\cserver\F\Backupseqkart\" + DateTime.Now.DayOfWeek.ToString();
                    string[] bakList = Directory.GetFiles(srcDir, "*.bak");

                    if (Directory.Exists(srcDir))
                    {
                        foreach (string f in bakList)
                        {
                            File.Delete(f);
                        }

                    }

                    Task.Run(() => ProjectFunctions.GetDataSet("BACKUP DATABASE SEQKARTNew TO DISK ='" + @"\\cserver\F\Backupseqkart\" + DateTime.Now.DayOfWeek.ToString() + @"\SEQ_" + DateTime.Now.ToShortDateString() + ".bak'"));
                    Task.Run(() => ProjectFunctions.GetDataSet("BACKUP DATABASE EFileSeqKart TO DISK ='" + @"\\cserver\F\Backupseqkart\" + DateTime.Now.DayOfWeek.ToString() + @"\Efile_" + DateTime.Now.ToShortDateString() + ".bak'"));
                    SplashScreenManager.CloseForm();
                }
                else
                {
                    NetworkCredential theNetworkCredential1 = new NetworkCredential(@"cserver\c server", "Rohit@123");
                    System.IO.Directory.CreateDirectory(@"\\cserver\F\Backupseqkart\" + DateTime.Now.DayOfWeek.ToString());
                    ProjectFunctions.Speak("BACKUP FOLDER CREATED SUCCESSFULLY");
                    string srcDir = @"\\cserver\F\Backupseqkart\" + DateTime.Now.DayOfWeek.ToString();
                    string[] bakList = Directory.GetFiles(srcDir, "*.bak");
                    if (Directory.Exists(srcDir))
                    {
                        foreach (string f in bakList)
                        {
                            File.Delete(f);
                        }

                    }
                    Task.Run(() => ProjectFunctions.GetDataSet("BACKUP DATABASE SEQKARTNew TO DISK ='" + @"\\cserver\F\Backupseqkart\" + DateTime.Now.DayOfWeek.ToString() + @"\SEQ_" + DateTime.Now.ToShortDateString() + ".bak'"));
                    Task.Run(() => ProjectFunctions.GetDataSet("BACKUP DATABASE EFileSeqKart TO DISK ='" + @"\\cserver\F\Backupseqkart\" + DateTime.Now.DayOfWeek.ToString() + @"\Efile_" + DateTime.Now.ToShortDateString() + ".bak'"));
                    SplashScreenManager.CloseForm();
                }
             


                ProjectFunctions.Speak("Database Successfully backed up on Server dated" + DateTime.Now.ToShortDateString());

            }
        }
    }
}