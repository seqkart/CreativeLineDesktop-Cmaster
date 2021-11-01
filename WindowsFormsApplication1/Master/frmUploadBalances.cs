using System;
using System.Data;
using System.IO;

namespace WindowsFormsApplication1.Master
{
    public partial class FrmUploadBalances : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = new DataTable();
        public FrmUploadBalances()
        {
            InitializeComponent();
            dt.Columns.Add("Account", typeof(string));
            dt.Columns.Add("Debit", typeof(Decimal));
            dt.Columns.Add("Credit", typeof(Decimal));
            dt.Columns.Add("AccCode", typeof(string));
        }
        private void SetMyControls()
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            ProjectFunctions.ButtonVisualize(this);
        }

        private void BtnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmUploadBalances_Load(object sender, EventArgs e)
        {
            SetMyControls();
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = " .xlsx files(*.xlsx)|*.xlsx";
            openFileDialog1.ShowDialog();
        }

        private void OpenFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            dt.Rows.Clear();


            var path = openFileDialog1.FileName;

            StreamReader sr = new StreamReader(path);
            int j = 0;

            while (sr.Peek() > 0)
            {

                int i = 0;
                string[] cols = sr.ReadLine().Split('\t');
                if (j > 0)
                {
                    DataRow newrow = dt.NewRow();

                    foreach (string str in cols)
                    {
                        newrow[i] = str.Trim();
                        i++;

                    }

                    dt.Rows.Add(newrow);
                }
                j++;
            }



            if (dt.Rows.Count > 0)
            {
                foreach (DataRow dr in dt.Rows)
                {
                    String AccCode = string.Empty;
                    DataSet dsActMst = ProjectFunctions.GetDataSet(" Select AccCode from ActMst where upper(AccName)='" + dr["Account"].ToString().Trim().ToUpper().Replace("'", string.Empty) + "'");
                    if (dsActMst.Tables[0].Rows.Count > 0)
                    {
                        dr["AccCode"] = dsActMst.Tables[0].Rows[0][0].ToString();
                    }
                }
                InfoGrid.DataSource = dt;
                InfoGridView.BestFitColumns();
            }
            else
            {
                InfoGrid.DataSource = null;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in (InfoGrid.DataSource as DataTable).Rows)
            {
                Decimal Balance = 0;
                if (Convert.ToDecimal(dr["Debit"]) != 0 || Convert.ToDecimal(dr["Credit"]) != 0)
                {

                    if (Convert.ToDecimal(dr["Debit"]) > 0)
                    {
                        Balance = Convert.ToDecimal(dr["Debit"]);
                    }
                    else
                    {
                        Balance = -Convert.ToDecimal(dr["[Credit]"]);
                    }
                }

                ProjectFunctions.GetDataSet("Update ActMst Set ActOpBal='" + Balance + "' Where AccCode='" + dr["AccCode"].ToString() + "'");

            }
        }
    }

}
