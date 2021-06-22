using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace WindowsFormsApplication1.Transaction
{
    public partial class frmMessageBuilder : DevExpress.XtraEditors.XtraForm
    {
        public String s1 { get; set; }
        public String MessageCode { get; set; }
        public String SourceTable { get; set; }
        public frmMessageBuilder()
        {
            InitializeComponent();
        }

        private void richEditControl1_Click(object sender, EventArgs e)
        {

        }

        private void TableGrid_DockChanged(object sender, EventArgs e)
        {

        }

        private void TableGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = TableGridView.GetDataRow(TableGridView.FocusedRowHandle);

            SourceTable = row["TableName"].ToString();
            DataSet dsSource = ProjectFunctions.GetDataSet("SELECT COLUMN_NAME as ColumnName FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + row["TableName"].ToString() + "'", ProjectFunctions.GetConnection());
            if (dsSource.Tables[0].Rows.Count > 0)
            {

                ColumnGrid.DataSource = dsSource.Tables[0];
                ColumnGridView.BestFitColumns();
            }
            else
            {
                ColumnGrid.DataSource = null;
                ColumnGridView.BestFitColumns();
            }

            txtQuery.Text = "Select FROM " + SourceTable;

            DataSet dsColumns = ProjectFunctions.GetDataSet("SELECT COLUMN_NAME as ColumnName FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + row["TableName"].ToString() + "'", ProjectFunctions.GetConnection());
            if (dsColumns.Tables[0].Rows.Count > 0)
            {
                dsColumns.Tables[0].Columns.Add("Select", typeof(bool));
                foreach (DataRow dr in dsColumns.Tables[0].Rows)
                {
                    dr["Select"] = false;
                }
                ParameterGrid.DataSource = dsColumns.Tables[0];
            }
            else
            {
                ParameterGrid.DataSource = null;
            }
        }

        private void btnSource_Click(object sender, EventArgs e)
        {
            DataSet dsSource = ProjectFunctions.GetDataSet("Select name as TableName from Sys.tables", ProjectFunctions.GetConnection());
            if (dsSource.Tables[0].Rows.Count > 0)
            {
                TableGrid.DataSource = dsSource.Tables[0];
            }
            else
            {
                TableGrid.DataSource = null;
            }
        }

        private void btnMakeQuery_Click(object sender, EventArgs e)
        {

        }


        private void MakeQuery()
        {
            String Query = "Select ";
            string[] authorsList = txtMessage.Text.Split('<');
            foreach (string author in authorsList)
            {
                if (author.Contains(">"))
                {
                    int i = 0;
                    string[] innerstringList = author.Split('>');
                    foreach (string innerstring in innerstringList)
                    {
                        if (i == 0)
                        {
                            Query = Query + " (cast " + innerstring.Replace(">", string.Empty) + " as varchar) + ";
                            i++;
                        }
                        else
                        {
                            Query = Query + " '" + innerstring + " ' + ";
                            i++;
                        }

                    }

                }
                else
                {
                    Query = Query + " '" + author + " ' + ";
                }

            }
            Query = Query.Trim();

            Query = Query.Remove(Query.Length - 1, 1);
            txtQuery.Text = Query.Trim() + " From " + SourceTable;

        }
        private void ColumnGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = ColumnGridView.GetDataRow(ColumnGridView.FocusedRowHandle);
            txtMessage.Text = txtMessage.Text + "<" + row["ColumnName"].ToString() + ">  ";
            txtMessage.SelectAll();
            MakeQuery();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtMessage.Text.Length == 0)
            {
                XtraMessageBox.Show("Invalid Message");
                return;
            }
            using (var sqlcon = new SqlConnection(ProjectFunctions.GetConnection()))
            {

                var MaxRow = (ParameterGrid.KeyboardFocusView as GridView).RowCount;
                //(InfoGrid.FocusedView as GridView).RowCount;
                sqlcon.Open();
                var sqlcom = sqlcon.CreateCommand();
                sqlcom.Connection = sqlcon;
                sqlcom.CommandType = CommandType.Text;
                try
                {
                    if (s1 == "&Add")
                    {

                        MessageCode = ProjectFunctions.GetDataSet("select isnull(max(MessageCode),0)+1 from SMSAutomationMst").Tables[0].Rows[0][0].ToString().PadLeft(6, '0');
                        txtQueryNo.Text = MessageCode;

                        sqlcom.CommandText = "Insert into SMSAutomationMst(MessageCode,MessageQuery,MessageDetail)values(" +
                            "@MessageCode,@MessageQuery,@MessageDetail)";
                        sqlcom.Parameters.Add("@MessageCode", SqlDbType.NVarChar).Value = txtQueryNo.Text.Trim();
                        sqlcom.Parameters.Add("@MessageQuery", SqlDbType.NVarChar).Value = txtQuery.Text.Trim();
                        sqlcom.Parameters.Add("@MessageDetail", SqlDbType.NVarChar).Value = txtMessage.Text.Trim();


                        sqlcom.ExecuteNonQuery();
                        sqlcom.Parameters.Clear();
                    }
                    if (s1 == "Edit")
                    {
                        sqlcom.CommandText = "Update SMSAutomationMst Set MessageQuery=@MessageQuery,MessageDetail=@MessageDetail" +
                            " Where MessageCode=@MessageCode";

                        sqlcom.Parameters.Add("@MessageCode", SqlDbType.NVarChar).Value = txtQueryNo.Text.Trim();
                        sqlcom.Parameters.Add("@MessageQuery", SqlDbType.NVarChar).Value = txtQuery.Text.Trim();
                        sqlcom.Parameters.Add("@MessageDetail", SqlDbType.NVarChar).Value = txtMessage.Text.Trim();
                        sqlcom.ExecuteNonQuery();
                        sqlcom.Parameters.Clear();

                        sqlcom.CommandType = CommandType.Text;
                        sqlcom.CommandText = "Delete from SMSAutomationData Where MessageCode=@MessageCode ";
                        sqlcom.Parameters.Add("@MessageCode", SqlDbType.NVarChar).Value = txtQueryNo.Text.Trim();

                        sqlcom.ExecuteNonQuery();
                        sqlcom.Parameters.Clear();
                    }
                    for (var i = 0; i < MaxRow; i++)
                    {
                        sqlcom.CommandType = CommandType.Text;

                        var currentrow = ParameterGridView.GetDataRow(i);


                        if (currentrow["Select"].ToString().ToUpper() == "TRUE")

                        {
                            sqlcom.CommandText = " Insert into SMSAutomationData "
                                + " (MessageCode,ParameterName)"
                                + " values(@MessageCode,@ParameterName)";
                            sqlcom.Parameters.Add("@MessageCode", SqlDbType.NVarChar).Value = txtQueryNo.Text.Trim();
                            sqlcom.Parameters.Add("@ParameterName", SqlDbType.NVarChar).Value = currentrow["ParameterName"].ToString();
                            sqlcom.ExecuteNonQuery();
                            sqlcom.Parameters.Clear();
                        }
                    }

                    ProjectFunctions.SpeakError("Invoice Data Saved Successfully");
                    sqlcon.Close();

                    Close();
                }
                catch (Exception ex)

                {
                    Close();
                }
            }
        }

        private void frmMessageBuilder_Load(object sender, EventArgs e)
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip); ;
            if (s1 == "&Add")
            {



            }
            if (s1 == "Edit")
            {
                txtQueryNo.Enabled = false;
                DataSet ds = ProjectFunctions.GetDataSet(string.Format("sp_LoadMessageAutomationDataFEdit '{0}'", MessageCode));
                txtQueryNo.Text = ds.Tables[0].Rows[0]["MessageCode"].ToString();
                txtQuery.Text = ds.Tables[0].Rows[0]["MessageQuery"].ToString();
                txtMessage.Text = ds.Tables[0].Rows[0]["MessageDetail"].ToString();

            }
        }
    }
}