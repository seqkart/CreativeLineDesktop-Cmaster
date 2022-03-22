using DevExpress.XtraEditors;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SeqKartLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Master
{
    public partial class frmAreaMaster : DevExpress.XtraEditors.XtraForm
    {
        public string S1 { get; set; }
        public string AreaCode { get; set; }
        public frmAreaMaster()
        {
            InitializeComponent();
        }
        private void SetMyControls()
        {
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            txtAreaName.Properties.MaxLength = 100;
            txtZipCode.Properties.MaxLength = 20;

            txtAreaCode.Enabled = false;
        }
        private void txtCitycode_EditValueChanged(object sender, EventArgs e)
        {
            txtCityName.Text = string.Empty;
        }
        private bool ValidateData()
        {
            if (txtAreaCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Area Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtAreaCode.Focus();
                return false;
            }
            if (txtAreaName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Area Name", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtAreaName.Focus();
                return false;
            }
            if (txtZipCode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid Zip Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtZipCode.Focus();
                return false;
            }
            if (txtCitycode.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid City Code", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtCitycode.Focus();
                return false;
            }
            if (txtCityName.Text.Trim().Length == 0)
            {
                XtraMessageBox.Show("Invalid City Name", "Invalid value", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                txtCityName.Focus();
                return false;
            }
            return true;
        }
        public  string GetNewAreaCode()
        {
            string sql = SQL_QUERIES._frmDesignationAddUpdate._GetNewDesgCode();
            string s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet("select isnull(max(Cast(AreaCode as int)),0000) from AreaMst");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString();
                s2 = (Convert.ToInt32(s2) + 1).ToString();
            }
            return s2;
        }
        private void frmAreaMaster_Load(object sender, EventArgs e)
        {
            SetMyControls();
            if (S1 == "&Add")
            {
                txtAreaName.Focus();
                txtAreaCode.Text = GetNewAreaCode().PadLeft(4,'0');
            }
            if (S1 == "Edit")
            {

                DataSet ds = ProjectFunctions.GetDataSet(" sp_LoadAreaMstFEdit '" + AreaCode + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    txtAreaCode.Text = ds.Tables[0].Rows[0]["AreaCode"].ToString();
                    txtAreaName.Text = ds.Tables[0].Rows[0]["AreaName"].ToString();
                    txtCitycode.Text = ds.Tables[0].Rows[0]["CityID"].ToString();
                    txtCityName.Text = ds.Tables[0].Rows[0]["CTNAME"].ToString();
                    txtZipCode.Text = ds.Tables[0].Rows[0]["ZipCode"].ToString();
                    txtAreaName.Focus();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
                {
                    sqlcon.Open();
                    var sqlcom = sqlcon.CreateCommand();
                    var transaction = sqlcon.BeginTransaction("SaveTransaction");
                    sqlcom.Connection = sqlcon;
                    sqlcom.Transaction = transaction;
                    sqlcom.CommandType = CommandType.Text;
                    try
                    {
                        if (S1 == "&Add")
                        {
                            sqlcom.CommandText = " SET TRANSACTION ISOLATION LEVEL SERIALIZABLE  Begin Transaction "
                                                    + " Insert into AreaMst"
                                                    + " (AreaCode,AreaName,UnderCityID,ZipCode)"
                                                    + " values((SELECT RIGHT('0000'+ CAST( ISNULL( max(Cast(AreaCode as int)),0)+1 AS VARCHAR(4)),4)from AreaMst),@AreaName,@UnderCityID,@ZipCode)"
                                                    + " Commit ";
                        }
                        if (S1 == "Edit")
                        {
                            sqlcom.CommandText = " UPDATE AreaMst SET "
                                                + " AreaName=@AreaName,UnderCityID=@UnderCityID,ZipCode=@ZipCode "
                                                + " Where AreaCode=@AreaCode";
                            sqlcom.Parameters.AddWithValue("@AreaCode", txtAreaCode.Text.Trim());

                        }
                      
                        sqlcom.Parameters.AddWithValue("@AreaName", txtAreaName.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@UnderCityID", txtCitycode.Text.Trim());
                        sqlcom.Parameters.AddWithValue("@ZipCode", txtZipCode.Text.Trim());

                        sqlcom.ExecuteNonQuery();
                        transaction.Commit();
                        sqlcon.Close();
                        ProjectFunctions.SpeakError("Data Saved Successfully");
                        Close();
                    }
                    catch (Exception ex)
                    {
                        XtraMessageBox.Show("Something Wrong. \n I am going to Roll Back." + ex.Message, ex.GetType().ToString());
                        try
                        {
                            transaction.Rollback();
                        }
                        catch (Exception ex2)
                        {
                            XtraMessageBox.Show("Something Wrong. \n Roll Back Failed." + ex2.Message, ex2.GetType().ToString());
                        }
                    }
                }
            }
        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);
            
            if (HelpGrid.Text == "PINCODE")
            {
                foreach(DataColumn dr in (HelpGrid.DataSource as DataTable).Columns)
                {
                    if(dr.ColumnName.ToUpper().Contains("PINCODE"))
                    {
                        txtZipCode.Text = row[@"\Pincode\"].ToString().Replace(@"\", "");
                        break;
                    }
                }

                HelpGrid.Visible = false;
                txtCitycode.Focus();
            }
            if (HelpGrid.Text == "txtCitycode")
            {
                txtCitycode.Text = row["CTSYSID"].ToString();
                txtCityName.Text = row["CTNAME"].ToString();
                HelpGrid.Visible = false;
                txtZipCode.Focus();
            }
          
        }

        private void HelpGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HelpGrid_DoubleClick(null, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                HelpGrid.Visible = false;
            }
        }

        private void txtCitycode_KeyDown(object sender, KeyEventArgs e)
        {
            ProjectFunctions.CreatePopUpForTwoBoxes("Select CTSYSID,CTNAME from CITYMASTER", " Where CTSYSID", txtCitycode, txtCityName, txtZipCode, HelpGrid, HelpGridView, e);
        }



        private void GetPinCodeFromAreaName()
        {
            
            String PinCode = String.Empty;
            var url = "https://api.postalpincode.in/PostOffice/" + txtAreaName.Text + "";
            var httpRequest = (HttpWebRequest)WebRequest.Create(url);
            var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();


                if (httpResponse.StatusCode.ToString().ToUpper() == "OK")
                {
                  

                    TextEdit t = new TextEdit
                    {
                        Text = JsonConvert.SerializeObject(result)
                    };


                    DataTable dt = JsonStringToDataTable(t.Text);
                    if(dt.Rows.Count>0)
                    {
                        HelpGridView.Columns.Clear();
                        HelpGrid.Text = "PINCODE";
                        HelpGrid.DataSource = dt;
                        HelpGridView.BestFitColumns();
                        HelpGrid.Show();
                        HelpGrid.Focus();
                        HelpGrid.Visible = true;
                    }



                }
                else
                {
                    ProjectFunctions.SpeakError("Unable to Locate Online ,Plz Feed Manually");
                    
                }
            }


        }


        public static DataTable JsonStringToDataTable(string jsonString)
        {
            DataTable dt = new DataTable();
            if (jsonString.Length > 5)
            {

                string[] jsonStringArray = Regex.Split(jsonString.Replace("[", "").Replace("]", ""), "},{");
                List<string> ColumnsName = new List<string>();
                foreach (string jSA in jsonStringArray)
                {
                    string[] jsonStringData = Regex.Split(jSA.Replace("{", "").Replace("}", ""), ",");
                    foreach (string ColumnsNameData in jsonStringData)
                    {
                        try
                        {
                            int idx = ColumnsNameData.IndexOf(":");
                            if (idx > 0)
                            {
                                string ColumnsNameString = ColumnsNameData.Substring(0, idx - 1).Replace("\"", "");
                                if (!ColumnsName.Contains(ColumnsNameString))
                                {
                                    ColumnsName.Add(ColumnsNameString);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            throw new Exception(string.Format("Error Parsing Column Name : {0}", ColumnsNameData));
                        }
                    }
                    break;
                }
                foreach (string AddColumnName in ColumnsName)
                {
                    dt.Columns.Add(AddColumnName);
                }
                foreach (string jSA in jsonStringArray)
                {
                    string[] RowData = Regex.Split(jSA.Replace("{", "").Replace("}", ""), ",");
                    DataRow nr = dt.NewRow();
                    foreach (string rowData in RowData)
                    {
                        try
                        {
                            int idx = rowData.IndexOf(":");
                            if (idx > 0)
                            {
                                string RowColumns = rowData.Substring(0, idx - 1).Replace("\"", "");
                                string RowDataString = rowData.Substring(idx + 1).Replace("\"", "");
                                nr[RowColumns] = RowDataString;
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                            continue;
                        }
                    }
                    dt.Rows.Add(nr);
                }
                return dt;
            }
            else
            {
                return dt;
            }
        }
        private void txtAreaName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetPinCodeFromAreaName();
            }
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}