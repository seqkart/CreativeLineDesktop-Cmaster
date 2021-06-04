using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class frmMessageBuilder : DevExpress.XtraEditors.XtraForm
    {
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

        private void ColumnGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = ColumnGridView.GetDataRow(ColumnGridView.FocusedRowHandle);
            txtMessage.Text = txtMessage.Text + "<" + row["ColumnName"].ToString() + ">  ";
            txtMessage.SelectAll();
        }
    }
}