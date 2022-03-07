﻿using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text.RegularExpressions;
using WindowsFormsApplication1.Administration;

namespace WindowsFormsApplication1
{
    public partial class FrmCLApiMst : DevExpress.XtraEditors.XtraForm
    {
        public FrmCLApiMst()
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

        private void MakeApiProductGrid()
        {
            InvoiceGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col0 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "id",
                Visible = true,
                SortOrder = (DevExpress.Data.ColumnSortOrder.Ascending),
                VisibleIndex = 0
            };
            InvoiceGridView.Columns.Add(col0);
            DevExpress.XtraGrid.Columns.GridColumn co11 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "name",
                Visible = true,
                SortOrder = (DevExpress.Data.ColumnSortOrder.Ascending),
                VisibleIndex = 1
            };
            InvoiceGridView.Columns.Add(co11);
            DevExpress.XtraGrid.Columns.GridColumn co12 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "slug",
                Visible = true,
                SortOrder = (DevExpress.Data.ColumnSortOrder.Ascending),
                VisibleIndex = 2
            };
            InvoiceGridView.Columns.Add(co12);
            DevExpress.XtraGrid.Columns.GridColumn co13 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "type",
                Visible = true,
                SortOrder = (DevExpress.Data.ColumnSortOrder.Ascending),
                VisibleIndex =3            
            };
            InvoiceGridView.Columns.Add(co13);
           
            DevExpress.XtraGrid.Columns.GridColumn col6 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "price",
                Visible = true,
                SortOrder = (DevExpress.Data.ColumnSortOrder.Ascending),
                VisibleIndex = 6
            };
            InvoiceGridView.Columns.Add(col6);
            DevExpress.XtraGrid.Columns.GridColumn co17 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "regular_price",
                Visible = true,
                SortOrder = (DevExpress.Data.ColumnSortOrder.Ascending),
                VisibleIndex = 7
            };
            InvoiceGridView.Columns.Add(co17);
            DevExpress.XtraGrid.Columns.GridColumn co18 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "sale_price",
                Visible = true,
                SortOrder = (DevExpress.Data.ColumnSortOrder.Ascending),
                VisibleIndex = 8
            };
            InvoiceGridView.Columns.Add(co18);
            DevExpress.XtraGrid.Columns.GridColumn co19 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "description",
                Visible = true,
                SortOrder = (DevExpress.Data.ColumnSortOrder.Ascending),
                VisibleIndex = 9
            };
            InvoiceGridView.Columns.Add(co19);
        }

        private void MakeAPIGridForProduct()
        {
            InvoiceGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "id",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col1);
            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "name",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col2);
            DevExpress.XtraGrid.Columns.GridColumn col3 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "type",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col3);
            DevExpress.XtraGrid.Columns.GridColumn col4 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "regular_price",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col4);
            DevExpress.XtraGrid.Columns.GridColumn col5 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "description",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col5);
            DevExpress.XtraGrid.Columns.GridColumn col6 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "short_description",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col6);

        }

        private void MakeAPIGridForTaxRate()
        {
            InvoiceGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "id",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col1);
            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "city",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col2);
            DevExpress.XtraGrid.Columns.GridColumn col3 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "country",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col3);
            DevExpress.XtraGrid.Columns.GridColumn col4 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "name",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col4);
            DevExpress.XtraGrid.Columns.GridColumn col5 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "postcode",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col5);
            DevExpress.XtraGrid.Columns.GridColumn col6 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "rate",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col6);
            DevExpress.XtraGrid.Columns.GridColumn col7 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "shipping",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col7);
            DevExpress.XtraGrid.Columns.GridColumn col8 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "state",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col8);

        }

        private void MakeAPIGridForCoupon()
        {
            InvoiceGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "id",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col1);
            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "code",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col2);
            DevExpress.XtraGrid.Columns.GridColumn col3 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "discount_type",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col3);
            DevExpress.XtraGrid.Columns.GridColumn col4 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "name",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col4);
            DevExpress.XtraGrid.Columns.GridColumn col5 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "exclude_sale_items",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col5);
            DevExpress.XtraGrid.Columns.GridColumn col6 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "individual_use",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col6);
            DevExpress.XtraGrid.Columns.GridColumn col7 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "minimum_amount",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col7);
            DevExpress.XtraGrid.Columns.GridColumn col8 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "amount",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col8);

        }

        private void MakeAPIGridForShippingMethods()
        {
            InvoiceGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "id",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col1);
            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "title",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col2);
            DevExpress.XtraGrid.Columns.GridColumn col3 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "description",
                Visible = true,
            };
        }
        private void MakeAPIGridForShippingZone()
        {
            InvoiceGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "id",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col1);
            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "name",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col2);
        }

        private void MakeAPIGridForProductRreview()
        {

            InvoiceGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "id",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col1);
            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "product_id",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col2);
            DevExpress.XtraGrid.Columns.GridColumn col3 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "status",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col3);
            DevExpress.XtraGrid.Columns.GridColumn col4 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "reviewer",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col4);
            DevExpress.XtraGrid.Columns.GridColumn col5 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "reviewer_email",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col5);
            DevExpress.XtraGrid.Columns.GridColumn col6 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "review",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col6);
            DevExpress.XtraGrid.Columns.GridColumn col7 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "rating",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col7);
        }


        private void MakeAPIGridForProductCategory()
        {

            InvoiceGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "id",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col1);
            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "name",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col2);
            DevExpress.XtraGrid.Columns.GridColumn col3 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "slug",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col3);
            DevExpress.XtraGrid.Columns.GridColumn col4 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "description",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col4);
        }

        private void MakeAPIGridForCustomer()
        {

            InvoiceGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "id",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col1);
            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "first_name",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col2);
            DevExpress.XtraGrid.Columns.GridColumn col3 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "last_name",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col3);
            DevExpress.XtraGrid.Columns.GridColumn col4 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "country",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col4);
            DevExpress.XtraGrid.Columns.GridColumn col5 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "city",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col5);
            DevExpress.XtraGrid.Columns.GridColumn col6 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "email",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col6);
            DevExpress.XtraGrid.Columns.GridColumn col7 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "phone",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col7);
            DevExpress.XtraGrid.Columns.GridColumn col8 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "postcode",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col8);
            DevExpress.XtraGrid.Columns.GridColumn col9 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "state",
                Visible = true,
            };
            InvoiceGridView.Columns.Add(col9);
        }

        private void FillGrid()
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
                        DataTable dtNew = new DataTable();
                        dtNew = dt.Clone();
                        if (GlobalVariables.ProgCode == "PROG253")
                        {
                            MakeAPIGridForCoupon();
                            foreach (DataRow dr in dt.Rows)
                            {

                                dtNew.ImportRow(dr);
                            }
                        }
                        if (GlobalVariables.ProgCode == "PROG254")
                        {
                            MakeAPIGridForCustomer();
                            foreach(DataRow dr in dt.Rows)
                            {
                                if(dr["first_name"].ToString().Trim()!="")
                                {
                                    dtNew.ImportRow(dr);
                                }
                            }

                        }
                        if (GlobalVariables.ProgCode == "PROG258")
                        {
                            MakeAPIGridForProduct();
                        }
                        if (GlobalVariables.ProgCode == "PROG260")
                        {
                            MakeAPIGridForProductCategory();
                        }
                        if (GlobalVariables.ProgCode == "PROG261")
                        {
                            MakeAPIGridForProductRreview();
                        }
                        if (GlobalVariables.ProgCode == "PROG262")
                        {
                            MakeAPIGridForTaxRate();
                        }
                        if (GlobalVariables.ProgCode == "PROG263")
                        {
                            MakeAPIGridForShippingZone();
                        }

                        InvoiceGrid.DataSource = dtNew;
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
        private void FrmCLApiMst_Load(object sender, EventArgs e)
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            FillGrid();
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
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled)
            {
                if (GlobalVariables.ProgCode == "PROG258")
                {
                    FrmAPIProducts frm = new FrmAPIProducts() { S1 = btnAdd.Text, Text = " Product Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG262")
                {
                    FrmAPITaxRates frm = new FrmAPITaxRates() { S1 = btnAdd.Text, Text = " Tax Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG253")
                {
                    FrmAPICoupon frm = new FrmAPICoupon() { S1 = btnAdd.Text, Text = " Coupon Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG267")
                {
                    FrmTaxClasses frm = new FrmTaxClasses() { S1 = btnAdd.Text, Text = " Tax Classes Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG266")
                {
                    FrmShippingMethods frm = new FrmShippingMethods() { S1 = btnAdd.Text, Text = " Shipping Methods Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG263")
                {
                    FrmShippingZones frm = new FrmShippingZones() { S1 = btnAdd.Text, Text = " Shipping Zone Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG261")
                {
                    frmProductReview frm = new frmProductReview() { S1 = btnAdd.Text, Text = " Product  Review Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG260")
                {
                    FrmProductCategories frm = new FrmProductCategories() { S1 = btnAdd.Text, Text = " Product  Category Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG254")
                {
                    frmAPICustomers frm = new frmAPICustomers() { S1 = btnAdd.Text, Text = " Customer Addition" };
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Enabled)
            {
                if (GlobalVariables.ProgCode == "PROG258")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmAPIProducts frm = new FrmAPIProducts() { S1 = btnEdit.Text, Text = " Product Edition" };
                    frm.txtdescription.Text = CurrentRow["description"].ToString();
                    frm.txtid.Text = CurrentRow["id"].ToString();
                    frm.txtname.Text = CurrentRow["name"].ToString();
                    frm.txtregular_price.Text = CurrentRow["regular_price"].ToString();
                    frm.txtprice.Text = CurrentRow["price"].ToString();
                    frm.txtsale_price.Text = CurrentRow["sale_price"].ToString();
                    frm.txtshort_description.Text = CurrentRow["short_description"].ToString();
                    frm.txttype.Text = CurrentRow["type"].ToString();
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG262")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmAPITaxRates frm = new FrmAPITaxRates() { S1 = btnEdit.Text, Text = " Tax Edition" };
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

                    FrmAPICoupon frm = new FrmAPICoupon() { S1 = btnEdit.Text, Text = " Coupon Edition" };
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

                    FrmTaxClasses frm = new FrmTaxClasses() { S1 = btnEdit.Text, Text = " Tax Classes Edition" };
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
                    FrmShippingMethods frm = new FrmShippingMethods() { S1 = btnEdit.Text, Text = " Shipping Methods Edition" };
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

                    FrmShippingZones frm = new FrmShippingZones() { S1 = btnEdit.Text, Text = " Shipping Zone Edition" };
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
                    frmProductReview frm = new frmProductReview() { S1 = btnEdit.Text, Text = " Product Review Edition" };
                    frm.Id = CurrentRow["id"].ToString();
                    frm.Date_created = CurrentRow["date_created"].ToString();
                    frm.Date_created_gmt = CurrentRow["date_created_gmt"].ToString();
                    frm.Product_id = CurrentRow["product_id"].ToString();
                    frm.Status = CurrentRow["status"].ToString();
                    frm.Reviewer = CurrentRow["reviewer"].ToString();
                    frm.Reviewer_email = CurrentRow["reviewer_email"].ToString();
                    frm.Review = CurrentRow["review"].ToString();
                    frm.Rating = CurrentRow["rating"].ToString();
                    frm.Verified = CurrentRow["verified"].ToString();
                    frm.Reviewer_avatar_urls = CurrentRow["reviewer_avatar_urls"].ToString();
                    frm.A48 = CurrentRow["48"].ToString();
                    frm.A96 = CurrentRow["96"].ToString();
                    frm._links = CurrentRow["_links"].ToString();
                    frm.Collection = CurrentRow["collection"].ToString();
                    frm.Up = CurrentRow["up"].ToString();
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);

                }
                if (GlobalVariables.ProgCode == "PROG260")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmProductCategories frm = new FrmProductCategories() { S1 = btnEdit.Text, Text = " Product  Category Edition" };
                    frm.Id = CurrentRow["id"].ToString();
                    frm.Name = CurrentRow["name"].ToString();
                    frm.Slug = CurrentRow["slug"].ToString();
                    frm.Parent = CurrentRow["parent"].ToString();
                    frm.Description = CurrentRow["description"].ToString();
                    frm.Display = CurrentRow["display"].ToString();
                    frm.Image = CurrentRow["image"].ToString();
                    frm.Date_created = CurrentRow["date_created"].ToString();
                    frm.Date_created_gmt = CurrentRow["date_created_gmt"].ToString();
                    frm.Date_modified_gmt = CurrentRow["date_modified_gmt"].ToString();
                    frm.Src = CurrentRow["src"].ToString();
                    frm.Alt = CurrentRow["alt"].ToString();
                    frm.Menu_order = CurrentRow["menu_order"].ToString();
                    frm.Count = CurrentRow["count"].ToString();
                    frm.Links = CurrentRow["_links"].ToString();
                    frm.Collection = CurrentRow["collection"].ToString();
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }


                if (GlobalVariables.ProgCode == "PROG254")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    frmAPICustomers frm = new frmAPICustomers() { S1 = btnEdit.Text, Text = " Customer Edition" };
                    frm.txtaddress_1.Text = CurrentRow["address_1"].ToString();
                    frm.txtaddress_2.Text = CurrentRow["address_2"].ToString();
                    
                    frm.txtcity.Text = CurrentRow["city"].ToString();
                    frm.txtcompany.Text = CurrentRow["company"].ToString();
                    frm.txtcountry.Text = CurrentRow["country"].ToString();
                   
                    frm.txtemail.Text = CurrentRow["email"].ToString();
                    frm.txtfirst_name.Text = CurrentRow["first_name"].ToString();
                    frm.txtid.Text = CurrentRow["id"].ToString();
                   
                    frm.txtlast_name.Text = CurrentRow["last_name"].ToString();
                   
                    frm.txtphone.Text = CurrentRow["phone"].ToString();
                    frm.txtpostcode.Text = CurrentRow["postcode"].ToString();
                  
                    frm.txtstate.Text = CurrentRow["state"].ToString();
                   
                    var P = ProjectFunctions.GetPositionInForm(this);
                    frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                    frm.ShowDialog(Parent);
                }
            }
        }

        private void BtnRefresh_Click(object sender, EventArgs e)
        {
            FillGrid();
        }
    }
}