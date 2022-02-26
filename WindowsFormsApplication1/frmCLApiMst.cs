using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
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
                    if (dt.Rows.Count > 0)
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

        private void InvoiceGridView_PopupMenuShowing(object sender, DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs e)
        {
            try
            {
                var formatRulesMenu = new DXPopupMenu();
                var view = sender as GridView;

                DXMenuItem Copy;
                DXMenuItem SAR;


                Copy = new DXMenuItem("Copy",
                                      (o1, e1) =>
                                      {
                                          view.OptionsSelection.MultiSelect = true;
                                          view.CopyToClipboard();
                                      });
                SAR = new DXMenuItem("Select All Records",
                                     (o1, e1) =>
                                     {
                                         view.OptionsSelection.MultiSelect = true;
                                         view.SelectAll();
                                     });

                e.Menu.Items.Add(Copy);
                e.Menu.Items.Add(SAR);
            }
            catch (Exception ex)

            {

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled)
            {
                if (GlobalVariables.ProgCode == "PROG258")
                {
                    School_Management_System.frmAPIProducts frm = new School_Management_System.frmAPIProducts() { s1 = btnAdd.Text, Text = " Product Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG262")
                {
                    School_Management_System.frmAPITaxRates frm = new School_Management_System.frmAPITaxRates() { s1 = btnAdd.Text, Text = " Tax Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG253")
                {
                    School_Management_System.frmAPICoupon frm = new School_Management_System.frmAPICoupon() { s1 = btnAdd.Text, Text = " Coupon Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG267")
                {
                    School_Management_System.frmTaxClasses frm = new School_Management_System.frmTaxClasses() { s1 = btnAdd.Text, Text = " Tax Classes Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG266")
                {
                    School_Management_System.frmShippingMethods frm = new School_Management_System.frmShippingMethods() { s1 = btnAdd.Text, Text = " Shipping Methods Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG263")
                {
                    School_Management_System.frmShippingZones frm = new School_Management_System.frmShippingZones() { s1 = btnAdd.Text, Text = " Shipping Zone Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG261")
                {
                    School_Management_System.frmProductReview frm = new School_Management_System.frmProductReview() { s1 = btnAdd.Text, Text = " Product  Review Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG260")
                {
                    School_Management_System.frmProductCategories frm = new School_Management_System.frmProductCategories() { s1 = btnAdd.Text, Text = " Product  Category Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG254")
                {
                    School_Management_System.frmAPICustomers frm = new School_Management_System.frmAPICustomers() { s1 = btnAdd.Text, Text = " Customer Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Enabled)
            {
                if (GlobalVariables.ProgCode == "PROG258")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    School_Management_System.frmAPIProducts frm = new School_Management_System.frmAPIProducts() { s1 = btnEdit.Text, Text = " Product Edition" };
                    frm.txtdescription.Text = CurrentRow["description"].ToString();
                    frm.txtid.Text = CurrentRow["id"].ToString();
                    frm.txtname.Text = CurrentRow["name"].ToString();
                    frm.txtregular_price.Text = CurrentRow["regular_price"].ToString();
                    frm.txtshort_description.Text = CurrentRow["short_description"].ToString();
                    frm.txttype.Text = CurrentRow["type"].ToString();
                     var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG262")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    School_Management_System.frmAPITaxRates frm = new School_Management_System.frmAPITaxRates() { s1 = btnEdit.Text, Text = " Tax Edition" };
                    frm.txtid.Text = CurrentRow["id"].ToString();
                    frm.txtcity.Text = CurrentRow["city"].ToString();
                    frm.txtcountry.Text = CurrentRow["country"].ToString();
                    frm.txtname.Text = CurrentRow["name"].ToString();
                    frm.txtpostcode.Text = CurrentRow["postcode"].ToString();
                    frm.txtrate.Text = CurrentRow["rate"].ToString();
                    frm.txtshipping.Text = CurrentRow["shipping"].ToString();
                    frm.txtstate.Text = CurrentRow["state"].ToString();
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG253")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    School_Management_System.frmAPICoupon frm = new School_Management_System.frmAPICoupon() { s1 = btnEdit.Text, Text = " Coupon Edition" };
                    frm.txtid.Text = CurrentRow["id"].ToString();
                    frm.txtamount.Text = CurrentRow["amount"].ToString();
                    frm.txtcode.Text = CurrentRow["code"].ToString();
                    frm.txtdiscount_type.Text = CurrentRow["discount_type"].ToString();
                    frm.txtexclude_sale_items.Text = CurrentRow["exclude_sale_items"].ToString();
                    frm.txtindividual_use.Text = CurrentRow["individual_use"].ToString();
                    frm.txtminimum_amount.Text = CurrentRow["minimum_amount"].ToString();
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG267")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    School_Management_System.frmTaxClasses frm = new School_Management_System.frmTaxClasses() { s1 = btnEdit.Text, Text = " Tax Classes Edition" };
                    frm.txtslug.Text = CurrentRow["slug"].ToString();
                    frm.txtname.Text = CurrentRow["name"].ToString();
                    frm.txtlinks.Text = CurrentRow["_links"].ToString();
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG266")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    School_Management_System.frmShippingMethods frm = new School_Management_System.frmShippingMethods() { s1 = btnEdit.Text, Text = " Shipping Methods Edition" };
                    frm.ID = CurrentRow["id"].ToString();
                    frm.Title = CurrentRow["title"].ToString();
                    frm.Description = CurrentRow["description"].ToString();
                    frm.Link = CurrentRow["_links"].ToString();
                    frm.Collection = CurrentRow["collection"].ToString();
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG263")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    School_Management_System.frmShippingZones frm = new School_Management_System.frmShippingZones() { s1 = btnEdit.Text, Text = " Shipping Zone Edition" };
                    frm.ID = CurrentRow["id"].ToString();
                    frm.Name = CurrentRow["name"].ToString();
                    frm.Order = CurrentRow["order"].ToString();
                    frm.Link = CurrentRow["_links"].ToString();
                    frm.Collection = CurrentRow["collection"].ToString();
                    frm.DescribedBy = CurrentRow["describedby"].ToString();
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG261")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    School_Management_System.frmProductReview frm = new School_Management_System.frmProductReview() { s1 = btnEdit.Text, Text = " Product Review Edition" };
                    frm.id = CurrentRow["id"].ToString();
                    frm.date_created = CurrentRow["date_created"].ToString();
                    frm.date_created_gmt = CurrentRow["date_created_gmt"].ToString();
                    frm.product_id = CurrentRow["product_id"].ToString();
                    frm.status = CurrentRow["status"].ToString();
                    frm.reviewer = CurrentRow["reviewer"].ToString();
                    frm.reviewer_email = CurrentRow["reviewer_email"].ToString();
                    frm.review = CurrentRow["review"].ToString();
                    frm.rating = CurrentRow["rating"].ToString();
                    frm.verified = CurrentRow["verified"].ToString();
                    frm.reviewer_avatar_urls = CurrentRow["reviewer_avatar_urls"].ToString();
                    frm.A48 = CurrentRow["48"].ToString();
                    frm.A96 = CurrentRow["96"].ToString();
                    frm._links = CurrentRow["_links"].ToString();
                    frm.collection = CurrentRow["collection"].ToString();
                    frm.up = CurrentRow["up"].ToString();
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);

                }
                if (GlobalVariables.ProgCode == "PROG260")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    School_Management_System.frmProductCategories frm = new School_Management_System.frmProductCategories() { s1 = btnEdit.Text, Text = " Product  Category Edition" };
                    frm.id = CurrentRow["id"].ToString();
                    frm.name = CurrentRow["name"].ToString();
                    frm.slug = CurrentRow["slug"].ToString();
                    frm.parent = CurrentRow["parent"].ToString();
                    frm.description = CurrentRow["description"].ToString();
                    frm.display = CurrentRow["display"].ToString();
                    frm.image = CurrentRow["image"].ToString();
                    frm.date_created = CurrentRow["date_created"].ToString();
                    frm.date_created_gmt = CurrentRow["date_created_gmt"].ToString();
                    frm.date_modified_gmt = CurrentRow["date_modified_gmt"].ToString();
                    frm.src = CurrentRow["src"].ToString();
                    frm.alt = CurrentRow["alt"].ToString();
                    frm.menu_order = CurrentRow["menu_order"].ToString();
                    frm.count = CurrentRow["count"].ToString();
                    frm._links = CurrentRow["_links"].ToString();
                    frm.collection = CurrentRow["collection"].ToString();
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }


                if (GlobalVariables.ProgCode == "PROG254")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    School_Management_System.frmAPICustomers frm = new School_Management_System.frmAPICustomers() { s1 = btnEdit.Text, Text = " Customer Edition" };
                    frm.txtaddress_1.Text = CurrentRow["address_1"].ToString();
                    frm.txtaddress_2.Text = CurrentRow["address_2"].ToString();
                    frm.txtavatar_url.Text = CurrentRow["avatar_url"].ToString();
                    frm.txtbilling.Text = CurrentRow["billing"].ToString();
                    frm.txtcity.Text = CurrentRow["city"].ToString();
                    frm.txtcompany.Text = CurrentRow["company"].ToString();
                    frm.txtcountry.Text = CurrentRow["country"].ToString();
                    frm.txtdate_created.Text = CurrentRow["date_created"].ToString();
                    frm.txtdate_created_gmt.Text = CurrentRow["date_created_gmt"].ToString();
                    frm.txtdate_modified.Text = CurrentRow["date_modified"].ToString();
                    frm.txtdate_modified_gmt.Text = CurrentRow["date_modified_gmt"].ToString();
                    frm.txtemail.Text = CurrentRow["email"].ToString();
                    frm.txtfirst_name.Text = CurrentRow["first_name"].ToString();
                    frm.txtid.Text = CurrentRow["id"].ToString();
                    frm.txtkey.Text = CurrentRow["key"].ToString();
                    frm.txtlast_name.Text = CurrentRow["last_name"].ToString();
                    frm.txtmeta_data.Text = CurrentRow["meta_data"].ToString();
                    frm.txtphone.Text = CurrentRow["phone"].ToString();
                    frm.txtpostcode.Text = CurrentRow["postcode"].ToString();
                    frm.txtrole.Text = CurrentRow["role"].ToString();
                    frm.txtshipping.Text = CurrentRow["shipping"].ToString();
                    frm.txtstate.Text = CurrentRow["state"].ToString();
                    frm.txtusername.Text = CurrentRow["username"].ToString();
                    frm.txtvalue.Text = CurrentRow["value"].ToString();
                    frm.txt_is_paying_customer.Text = CurrentRow["is_paying_customer"].ToString();
                 
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            fillGrid();
        }
    }
}