using DevExpress.XtraEditors;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WindowsFormsApplication1
{
    public partial class frmCLApiMst : DevExpress.XtraEditors.XtraForm
    {
        public frmCLApiMst()
        {
            InitializeComponent();
        }

        private void InvoiceGrid_Click(object sender, EventArgs e)
        {

        }
        //private static DataSet ReadDataFromJson(string jsonString, XmlReadMode mode = XmlReadMode.Auto)
        //{
        //    //// Note:Json convertor needs a json with one node as root
        //    jsonString = $"{{ \"rootNode\": {{{jsonString.Trim().TrimStart('{').TrimEnd('}')}}} }}";
        //    //// Now it is secure that we have always a Json with one node as root 
        //    var xd = JsonConvert.DeserializeXmlNode(jsonString);

        //    //// DataSet is able to read from XML and return a proper DataSet
        //    var result = new DataSet();
        //    result.ReadXml(new XmlNodeReader(xd), mode);
        //    return result;
        //}

        public static DataTable JsonStringToDataTable(string jsonString)
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
                        string RowColumns = rowData.Substring(0, idx - 1).Replace("\"", "");
                        string RowDataString = rowData.Substring(idx + 1).Replace("\"", "");
                        nr[RowColumns] = RowDataString;
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
        private void fillGrid()
        {
            DataSet ds = ProjectFunctions.GetDataSet("Select ProgAPI from ProgramMaster where ProgCode='" + GlobalVariables.ProgCode + "'");
            if (ds.Tables[0].Rows.Count > 0)
            {
                var url = ds.Tables[0].Rows[0][0].ToString().Trim();
                var httpRequest = (HttpWebRequest)WebRequest.Create(url);
                httpRequest.Headers["Authorization"] = "Basic Y2tfMWQzZjdhOWE4ZGQ1NTI5NTQwN2M3ZDUxMmJiY2Y3ODA1Y2YzMTY2Yjpjc184NzE2ODQ5MmQ2YzA4OWQyYmY4NGJhZTVkNWZkNGE5Y2UzZTQ4NTJm";
                var httpResponse = (HttpWebResponse)httpRequest.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    var result = streamReader.ReadToEnd();
                    DataTable dt = JsonStringToDataTable(result.ToString());
                    //DataSet dsInner = ReadDataFromJson(result.ToString());
                    if(dt.Rows.Count>0)
                    {
                        InvoiceGrid.DataSource = dt;
                        InvoiceGridView.BestFitColumns();
                    }
                    else
                    {
                        InvoiceGrid.DataSource = null;
                        InvoiceGridView.BestFitColumns();
                    }
                }
                Console.WriteLine(httpResponse.StatusCode);
            }
        }
        private void frmCLApiMst_Load(object sender, EventArgs e)
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            fillGrid();
        }
    }
}