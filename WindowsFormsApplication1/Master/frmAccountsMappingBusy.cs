using SeqKartLibrary;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Master
{
    public partial class frmAccountsMappingBusy : DevExpress.XtraEditors.XtraForm
    {
        int RowIndex;
        DataTable dt = new DataTable();

        DataSet dsPopUps = new DataSet();
        public frmAccountsMappingBusy()
        {
            InitializeComponent();
            dt.Columns.Add("AccCodeBusy", typeof(String));
            dt.Columns.Add("AccNameBusy", typeof(String));
            dt.Columns.Add("AccCode", typeof(String));
            dt.Columns.Add("AccName", typeof(String));


            dsPopUps = ProjectFunctions.GetDataSet("Select AccCode,AccName,AccCodeBusy from ActMst  order by AccName");
        }


        private void FillGrid()
        {
            DataSet dsAccName = ProjectFunctionsUtils.GetDataSet("Select AccCode,AccName,AccCodeBusy   from ActMst");
            DataSet ds = ProjectFunctionsUtils.GetDataSetBusy("Select Code as AccCodeBusy,Name as AccNameBusy,'' as AccCode,'' as AccName from Master1 ");
            if (ds.Tables[0].Rows.Count > 0)
            {
                dt = ds.Tables[0];
                foreach (DataRow dr in dt.Rows)
                {
                    foreach (DataRow drActMst in dsAccName.Tables[0].Rows)
                    {
                        if (dr["AccCodeBusy"].ToString() == drActMst["AccCodeBusy"].ToString())
                        {
                            dr["AccCode"] = drActMst["AccCode"].ToString();
                            dr["AccName"] = drActMst["AccName"].ToString();
                        }
                    }
                }
                AccountGrid.DataSource = dt;
                AccountGridView.BestFitColumns();
            }
            else
            {
                AccountGrid.DataSource = null;
                AccountGridView.BestFitColumns();
            }
        }

        private void frmAccountsMappingBusy_Load(object sender, EventArgs e)
        {
            FillGrid();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            try

            {
                HelpGridView.CloseEditor();
                HelpGridView.UpdateCurrentRow();
                if (e.KeyCode == Keys.Enter)
                {
                    HelpGrid_DoubleClick(null, e);
                }
                if (e.KeyCode == Keys.Down)
                {
                    HelpGrid.Focus();
                }
                if (e.KeyCode == Keys.Escape)
                {
                    panelControl2.Visible = false;
                }
                e.Handled = true;
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void HelpGrid_DoubleClick(object sender, EventArgs e)
        {
            HelpGridView.CloseEditor();
            HelpGridView.UpdateCurrentRow();
            DataRow row = HelpGridView.GetDataRow(HelpGridView.FocusedRowHandle);


            if (HelpGrid.Text == "AccCode" || HelpGrid.Text == "AccName")
            {
                if (HelpGridView.RowCount > 0)
                {
                    AccountGridView.SetRowCellValue(RowIndex, AccountGridView.Columns["AccCode"], row["AccCode"].ToString());
                    AccountGridView.SetRowCellValue(RowIndex, AccountGridView.Columns["AccName"], row["AccName"].ToString());
                    panelControl2.Visible = false;
                    AccountGridView.Focus();

                    AccountGridView.FocusedRowHandle = RowIndex;
                    txtSearchBox.Text = string.Empty;
                }
            }
        }

        private void AccountGrid_KeyDown(object sender, KeyEventArgs e)
        {
            RowIndex = AccountGridView.FocusedRowHandle;
            if (AccountGridView.FocusedColumn.FieldName == "AccCode" || AccountGridView.FocusedColumn.FieldName == "AccName")
            {
                ProjectFunctions.CreateRohitStylePopUpGridHelp(AccountGrid, AccountGridView, HelpGrid, HelpGridView, "AccCode", txtSearchBox, panelControl2, e);
            }
        }

        private void txtSearchBox_EditValueChanged(object sender, EventArgs e)
        {
            try
            {

                HelpGrid.Show();

                if (HelpGrid.Text == "AccCode")
                {

                    DataTable dtNew = dsPopUps.Tables[0].Clone();
                    DataRow[] dtRow = dsPopUps.Tables[0].Select("AccName like '" + txtSearchBox.Text + "%'");
                    foreach (DataRow dr in dtRow)
                    {

                        DataRow NewRow = dtNew.NewRow();
                        NewRow["AccCode"] = dr["AccCode"];
                        NewRow["AccName"] = dr["AccName"];


                        dtNew.Rows.Add(NewRow);
                    }
                    if (dtNew.Rows.Count > 0)
                    {
                        HelpGridView.Columns.Clear();
                        HelpGrid.DataSource = dtNew;
                        HelpGridView.BestFitColumns();

                    }
                    else
                    {
                        HelpGrid.DataSource = null;
                        HelpGridView.BestFitColumns();
                    }
                }
            }

            catch (Exception)
            {

            }
        }

        private void HelpGrid_KeyDown(object sender, KeyEventArgs e)
        {
            try

            {
                if (e.KeyCode == Keys.Enter)
                {
                    HelpGrid_DoubleClick(null, e);
                }
                if (e.KeyCode == Keys.Escape)
                {
                    panelControl2.Visible = false;
                }
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in (AccountGrid.DataSource as DataTable).Rows)
            {

                ProjectFunctions.GetDataSet("Update ActMst Set AccCodeBusy='" + dr["AccCodeBusy"].ToString() + "' Where AccCode='" + dr["AccCode"].ToString() + "'");
            }
        }

    }
}