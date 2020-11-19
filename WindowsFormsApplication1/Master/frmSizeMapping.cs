using System;
using System.Linq;
using System.Data;
using System.Data.Sql;
namespace WindowsFormsApplication1.Master
{
    public partial class frmSizeMapping : DevExpress.XtraEditors.XtraForm
    {
        public frmSizeMapping()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSizeMapping_Load(object sender, EventArgs e)
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.TextBoxVisualize(this);
            DataSet dsGroup = ProjectFunctions.GetDataSet("Select * from GrpMst");
            if(dsGroup.Tables[0].Rows.Count>0)
            {
                dsGroup.Tables[0].Columns.Add("Select", typeof(bool));
                foreach(DataRow dr in dsGroup.Tables[0].Rows)
                {
                    dr["Select"] = false;
                }

                GroupGrid.DataSource = dsGroup.Tables[0];
                GroupGridView.BestFitColumns();
            }
            else
            {
                GroupGrid.DataSource = null;
                GroupGridView.BestFitColumns();
            }


            DataSet dsSize = ProjectFunctions.GetDataSet("Select SZSYSID,SZNAME,SZDESC,'' AS SizeDesc from SIZEMAST");
            if (dsSize.Tables[0].Rows.Count > 0)
            {
                dsSize.Tables[0].Columns.Add("Select", typeof(bool));
                foreach (DataRow dr in dsSize.Tables[0].Rows)
                {
                    dr["Select"] = false;
                }

                SizeGrid.DataSource = dsSize.Tables[0];
                SizeGridView.BestFitColumns();
            }
            else
            {
                SizeGrid.DataSource = null;
                SizeGridView.BestFitColumns();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //if (txtDesc.Text.Length == 0)
            //{
            //    ProjectFunctions.SpeakError("Invalid Desc");
            //    txtDesc.Focus();
            //    return;
            //}


            SizeGridView.CloseEditor();
            SizeGridView.UpdateCurrentRow();

            GroupGridView.CloseEditor();
            GroupGridView.UpdateCurrentRow();
            foreach (DataRow drGroup in (GroupGrid.DataSource as DataTable).Rows)
            {
                if(drGroup["Select"].ToString().ToUpper()=="TRUE")
                {
                    foreach (DataRow drSize in (SizeGrid.DataSource as DataTable).Rows)
                    {
                        if (drSize["Select"].ToString().ToUpper() == "TRUE")
                        {
                            ProjectFunctions.GetDataSet("Insert into SizeMapping (GrpCode,GrpSubCode,SizeId,SizeDesc)values('" + drGroup["GrpCode"].ToString() + "','" + drGroup["GrpSubCode"].ToString() + "','" + drSize["SZSYSID"].ToString() + "','" + drSize["SizeDesc"].ToString() + "')");
                        }
                    }
                }
            }

            this.Close();
        }
    }
}