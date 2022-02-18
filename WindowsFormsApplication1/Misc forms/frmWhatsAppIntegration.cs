using DevExpress.XtraEditors;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace WindowsFormsApplication1.Misc_forms
{
    public partial class FrmWhatsAppIntegration : DevExpress.XtraEditors.XtraForm
    {
        public FrmWhatsAppIntegration()
        {
            InitializeComponent();
        }

        private void textEdit2_EditValueChanged(object sender, EventArgs e)
        {

        }


        private async Task LoadContactDetailsAsync()
        {
            try
            {
                DataTable dt = new DataTable();
                dt.Columns.Add("Contacts", typeof(String));
                List<string> selectedNumbers = await WAProAPI.Controls.Shared.GetNumbersFromWhatsAppChats();
                if (selectedNumbers != null)
                {
                    StringBuilder sbNumbers = new StringBuilder();
                    foreach (string phoneNumber in selectedNumbers)
                    {
                        if (!string.IsNullOrEmpty(phoneNumber))
                        {
                            dt.Rows.Add(phoneNumber);
                        }
                    }
                }
                if (dt.Rows.Count > 0)
                {
                    ContactGrid.DataSource = dt;
                    ContactGridView.BestFitColumns();
                }
                else
                {
                    ContactGrid.DataSource = null;
                    ContactGridView.BestFitColumns();
                }
            }
            catch (Exception ex)
            {

                //Handle Exception
                MessageBox.Show(ex.Message);
            }
        }

        public async Task WhatsAppchat(String ChatContactNo, String MessageLimit)
        {
            using (var HttpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://103.223.12.170:3000/" + ChatContactNo + "/messages?includeSentMsg=true&limit=" + MessageLimit))
                {
                    request.Headers.TryAddWithoutValidation("accept", "application/json");

                    var response = await HttpClient.SendAsync(request);
                    if (response.IsSuccessStatusCode == true)
                    {
                        string content = await response.Content.ReadAsStringAsync();
                        TextEdit t = new TextEdit
                        {
                            Text = JsonConvert.SerializeObject(content)
                        };
                        DataTable dt = new DataTable();
                        dt = JsonStringToDataTable(t.Text);

                        if (dt.Rows.Count > 0)
                        {
   
                            DataTable dtNew = new DataTable();
                            dtNew.Columns.Add("FROMCHATNO");
                            dtNew.Columns.Add("TOCHATNO");
                            dtNew.Columns.Add("YOU");
                            dtNew.Columns.Add("OTHER");
                            dtNew.Columns.Add("YOUMEDIA");
                            dtNew.Columns.Add("WHATSAPPID");

                            foreach (DataRow dr in dt.Rows)
                            {
                                //if (dr[@"\type\"].ToString().ToUpper() == "\CHAT\"));

                                    DataRow dataRow = dtNew.NewRow();
                              

                                if (dr[@"\fromMe\"].ToString().ToUpper() == "TRUE")
                                {
                                    dataRow["YOU"] = dr[@"\body\"].ToString().Replace(@"\","");
                                    dataRow["FROMCHATNO"] = GlobalVariables.WhatAppMobileNo;
                                }
                                else
                                {
                                    dataRow["YOU"] = "";
                                }
                                if (dr[@"\fromMe\"].ToString().ToUpper() == "FALSE")
                                {
                                    dataRow["OTHER"] = dr[@"\body\"].ToString().Replace(@"\", "");
                                    dataRow["TOCHATNO"] = dr[@"\senderPhoneNumber\"].ToString().Replace(@"\", "");
                                }
                                else
                                {
                                    dataRow["OTHER"] = "";
                                }
                                dataRow["WHATSAPPID"] = dr[@"\id\"].ToString().Replace(@"\", "");
                                dtNew.Rows.Add(dataRow);
                            }
                            if (dtNew.Rows.Count > 0)
                            {
                                foreach (DataRow dr in dtNew.Rows)
                                {
                                  DataSet ds=  ProjectFunctions.GetDataSet("Select FROMCHATNO from CHATDATA where WHATSAPPID='" + dr["WHATSAPPID"].ToString() + "'");
                                    if(ds.Tables[0].Rows.Count>0)
                                    {

                                    }
                                    else
                                    {
                                        String Query = "Insert into CHATDATA(FROMCHATNO,TOCHATNO,FROMCHAT,TOCHAT,WHATSAPPID)values(";
                                        Query = Query + "'" + dr["FROMCHATNO"].ToString() + "',";
                                        Query = Query + "'" + dr["TOCHATNO"].ToString() + "',";
                                        Query = Query + "'" + dr["YOU"].ToString() + "',";
                                        Query = Query + "'" + dr["OTHER"].ToString() + "',";
                                        Query = Query + "'" + dr["WHATSAPPID"].ToString() + "')";

                                        ProjectFunctions.GetDataSet(Query);
                                    }
                                   
                                }
                            }
                        }
                    }
                }
            }
        }
        public static  DataTable JsonStringToDataTable(string jsonString)
        {
            DataTable dt = new DataTable();
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
                        string ColumnsNameString = ColumnsNameData.Substring(0, idx - 1).Replace("\"", "");
                        if (!ColumnsName.Contains(ColumnsNameString))
                        {
                            ColumnsName.Add(ColumnsNameString);
                        }
                    }
                    catch (Exception ex)
                    {
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
                        string RowColumns = rowData.Substring(0, idx - 1).Replace("\"", "");
                        string RowDataString = rowData.Substring(idx + 1).Replace("\"", "");
                        nr[RowColumns] = RowDataString;
                    }
                    catch (Exception ex)
                    {
                        continue;
                    }
                }
                dt.Rows.Add(nr);
            }
            return dt;
        }

        private void FrmWhatsAppIntegration_Load(object sender, EventArgs e)
        {
            ProjectFunctions.TextBoxVisualize(this);
           
            txtStatus.Text = GlobalVariables.WhatAppStatus;
            txtMobileNo.Text = GlobalVariables.WhatAppMobileNo;

           
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            WhatsAppchat(txtSearchBar.Text, txtMessageCount.Text);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {

        }
    }
}