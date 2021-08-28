using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;

namespace WindowsFormsApplication1.Transaction
{
    public partial class frmImportSaleFromExcel : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public frmImportSaleFromExcel()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " .xlsx files(*.xlsx)|*.xlsx";
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            dt.Rows.Clear();
            var xlConn = string.Empty;
            xlConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFileDialog1.FileName + ";Extended Properties=\"Excel 12.0;\";";
            using (var myCommand = new OleDbDataAdapter("SELECT '' as AccCode,[BILL DATE],[NET SALE VALUE] ,[NET SALE AFTER ADJ],[DISCOUNT],[USER ITEM CODE] FROM Sheet1$", xlConn))
            {
                myCommand.Fill(dt);

                InfoGrid.DataSource = dt;
                InfoGridView.BestFitColumns();
            }
        }

        private bool ValidateData()
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["NET SALE VALUE"].ToString().Trim().Length == 0)
                {
                    dr["NET SALE VALUE"] = "0";
                }
                if (dr["NET SALE AFTER ADJ"].ToString().Trim().Length == 0)
                {
                    dr["NET SALE AFTER ADJ"] = "0";
                }
                if (dr["DISCOUNT"].ToString().Trim().Length == 0)
                {
                    dr["DISCOUNT"] = "0";
                }

                if (dr["AccCode"].ToString().Trim().Length == 0)
                {
                    ProjectFunctions.Speak("Invalid Party Code");
                    return false;
                }
                if (dr["USER ITEM CODE"].ToString().Trim().Length == 0)
                {
                    ProjectFunctions.Speak("Invalid Bar Code");
                    return false;
                }
            }
            return true;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                foreach (DataRow dr in dt.Rows)
                {
                    string Query = "Insert into PartySalesData(AccCode,SaleDate,BarCode,SalesAmount,Discount,NetSalesAmount)values(";
                    Query = Query + "'" + dr["AccCode"].ToString() + "',";
                    Query = Query + "'" + Convert.ToDateTime(dr["BILL DATE"]).ToString("yyyy-MM-dd") + "',";
                    Query = Query + "'" + dr["USER ITEM CODE"].ToString() + "',";
                    Query = Query + "'" + Convert.ToDecimal(dr["NET SALE VALUE"]) + "',";
                    Query = Query + "'" + Convert.ToDecimal(dr["DISCOUNT"]) + "',";
                    Query = Query + "'" + Convert.ToDecimal(dr["NET SALE AFTER ADJ"]) + "')";
                    ProjectFunctions.GetDataSet(Query);
                }
                Close();
            }
        }
    }
}

