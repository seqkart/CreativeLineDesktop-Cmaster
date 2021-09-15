using System;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Transaction
{
    public partial class frmDesignDataTemplates : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();

        string SourceTable;
        public frmDesignDataTemplates()
        {
            InitializeComponent();
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmDesignDataTemplates_Load(object sender, EventArgs e)
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            DataSet dsSource = ProjectFunctions.GetDataSet("Select name as TableName from Sys.tables");
            if (dsSource.Tables[0].Rows.Count > 0)
            {
                STableGrid.DataSource = dsSource.Tables[0];
            }
            else
            {
                STableGrid.DataSource = null;
            }
        }

        private void STableGrid_DoubleClick(object sender, EventArgs e)
        {
            DataRow row = STableGridView.GetDataRow(STableGridView.FocusedRowHandle);

            SourceTable = row["TableName"].ToString();
            DataSet dsSource = ProjectFunctions.GetDataSet("SELECT COLUMN_NAME as ColumnName FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = N'" + row["TableName"].ToString() + "'");
            if (dsSource.Tables[0].Rows.Count > 0)
            {
                SColumnGrid.DataSource = dsSource.Tables[0];
            }
            else
            {
                SColumnGrid.DataSource = null;
            }
        }

        private void BtnLoadExcel_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = " .xlsx files(*.xlsx)|*.xlsx";
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            DColumnGrid.Refresh();
            var xlConn = string.Empty;
            xlConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + openFileDialog1.FileName + ";Extended Properties=\"Excel 12.0;\";";
            using (var myCommand = new OleDbDataAdapter("SELECT * FROM [Sheet1$]", xlConn))
            {
                myCommand.Fill(dt);

                if (dt.Columns.Count > 0)
                {
                    DataTable dtFinal = new DataTable();
                    dtFinal.Columns.Add("ColumnName", typeof(string));
                    dtFinal.Columns.Add("Source", typeof(string));
                    foreach (DataColumn dr in dt.Columns)
                    {
                        DataRow drNewRow = dtFinal.NewRow();
                        drNewRow["ColumnName"] = dr.ColumnName;
                        dtFinal.Rows.Add(drNewRow);
                    }

                    foreach (DataRow dr in (SColumnGrid.DataSource as DataTable).Rows)
                    {
                        repositoryItemComboBox1.Items.Add(dr["ColumnName"].ToString());
                    }

                    if (dtFinal.Rows.Count > 0)
                    {
                        DColumnGrid.DataSource = dtFinal;
                        DColumnGridVIew.BestFitColumns();
                    }
                    else
                    {
                        DColumnGrid.DataSource = null;
                        DColumnGridVIew.BestFitColumns();
                    }
                }

            }
        }

        private void TxtDebitPartyCode_EditValueChanged(object sender, EventArgs e)
        {
            txtDebitPartyName.Text = string.Empty;
        }

        private void TxtDebitPartyCode_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        private void PrepareActMstHelpGrid()
        {
            HelpGridView.Columns.Clear();
            DevExpress.XtraGrid.Columns.GridColumn col1 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "AccName",
                Visible = true,
                VisibleIndex = 0
            };
            HelpGridView.Columns.Add(col1);

            DevExpress.XtraGrid.Columns.GridColumn col2 = new DevExpress.XtraGrid.Columns.GridColumn
            {
                FieldName = "AccCode",
                Visible = true,
                VisibleIndex = 1
            };
            HelpGridView.Columns.Add(col2);


        }

        private void TxtDebitPartyCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                PrepareActMstHelpGrid();
                HelpGrid.Text = "txtDebitPartyCode";
                if (txtDebitPartyCode.Text.Trim().Length == 0)
                {
                    DataSet ds = ProjectFunctions.GetDataSet("sp_LoadActMstHelp");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        HelpGrid.DataSource = ds.Tables[0];
                        HelpGrid.Show();
                        HelpGrid.Visible = true;
                        HelpGrid.Focus();
                        HelpGridView.BestFitColumns();
                    }
                    else
                    {
                        ProjectFunctions.SpeakError("No Records To Display");
                    }
                }
                else
                {
                    DataSet ds = ProjectFunctions.GetDataSet(" sp_LoadActMstHelpWithCode '" + txtDebitPartyCode.Text.Trim() + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        txtDebitPartyCode.Text = ds.Tables[0].Rows[0]["AccCode"].ToString();
                        txtDebitPartyName.Text = ds.Tables[0].Rows[0]["AccName"].ToString();
                        txtDocType.Focus();
                    }

                    else
                    {
                        DataSet ds1 = ProjectFunctions.GetDataSet("sp_LoadActMstHelp");
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            HelpGrid.DataSource = ds.Tables[0];
                            HelpGrid.Show();
                            HelpGrid.Visible = true;
                            HelpGrid.Focus();
                            HelpGridView.BestFitColumns();
                        }
                        else
                        {
                            ProjectFunctions.SpeakError("No Records To Display");
                        }
                    }
                }
            }
            e.Handled = true;
        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            HelpGridView.CloseEditor();
            HelpGridView.UpdateCurrentRow();
            DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);

            if (HelpGrid.Text == "txtDebitPartyCode")
            {
                txtDebitPartyCode.Text = row["AccCode"].ToString();
                txtDebitPartyName.Text = row["AccName"].ToString();

                HelpGrid.Visible = false;
                txtDocType.Focus();
            }
        }

        private void HelpGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                HelpGrid_DoubleClick(null, e);
            }
            if (e.KeyCode == Keys.Enter)
            {
                HelpGrid.Visible = false;
            }
        }
        private bool ValidateData()
        {
            if (txtDebitPartyCode.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Party Code");
                txtDebitPartyCode.Focus();
                return false;
            }
            if (txtDebitPartyName.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Party Code");
                txtDebitPartyCode.Focus();
                return false;
            }
            if (txtDocType.Text.Trim().Length == 0)
            {
                ProjectFunctions.SpeakError("Invalid Document Type");
                txtDocType.Focus();
                return false;
            }


            return true;
        }

        private string GetTemplateCode()
        {
            string s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet("select isnull(max(Cast(TemplateCode as int)),0000) from DataTemplates");
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString();
                s2 = (Convert.ToInt32(s2) + 1).ToString();
            }
            return s2;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidateData())
            {
                string DocNo = GetTemplateCode().PadLeft(4, '0');
                foreach (DataRow dr in (DColumnGrid.DataSource as DataTable).Rows)
                {
                    if (dr["Source"].ToString().Length > 0)
                    {
                        string Query = "Insert into DataTemplates( TemplateCode,TemplateName,AccCode,DocType,DFieldName,SFieldName,DTableName)Values(";
                        Query = Query + "'" + DocNo + "',";


                        Query = Query + "'" + txtTemplateName.Text + "',";
                        Query = Query + "'" + txtDebitPartyCode.Text + "',";
                        Query = Query + "'" + txtDocType.Text + "',";
                        Query = Query + "'" + dr["Source"].ToString() + "',";
                        Query = Query + "'" + dr["ColumnName"].ToString() + "',";
                        Query = Query + "'" + SourceTable + "')";

                        ProjectFunctions.GetDataSet(Query);
                        Close();

                    }
                }
            }
        }
    }
}