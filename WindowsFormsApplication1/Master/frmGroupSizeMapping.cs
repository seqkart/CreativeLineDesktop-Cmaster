using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraSplashScreen;

namespace WindowsFormsApplication1.Master
{
    public partial class frmGroupSizeMapping : DevExpress.XtraEditors.XtraForm
    {
        public frmGroupSizeMapping()
        {
         
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGroupSizeMapping_Load(object sender, EventArgs e)
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            DataSet ds = ProjectFunctions.GetDataSet("sp_LoadGroupSizeMapping ");
            if(ds.Tables[0].Rows.Count>0)
            {
                foreach(DataRow drOuter in ds.Tables[0].Rows)
                {
                    if (ds.Tables[1].Rows.Count > 0)
                    {
                        foreach (DataRow drInner in ds.Tables[1].Rows)
                        {
                            if(drInner["GrpCode"].ToString()== drOuter["GrpCode"].ToString() && drInner["GrpSubCode"].ToString() == drOuter["GrpSubCode"].ToString() &&  drInner["SZSYSID"].ToString() == drOuter["SZSYSID"].ToString())
                            {
                                drOuter["SizeDesc"] = drInner["SizeDesc"];
                            }
                        }
                    }
                }

                GridControl1.DataSource = ds.Tables[0];
                GridView1.BestFitColumns();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SplashScreenManager.ShowForm(this, typeof(WaitForm1), true, true, false);
            int i = 0;
            foreach (DataRow dr in (GridControl1.DataSource as DataTable).Rows)
            {

                i++;
                SplashScreenManager.Default.SetWaitFormDescription("Saving Item " + i.ToString() + " / " + (GridControl1.DataSource as DataTable).Rows.Count);

                DataSet dsCheck = ProjectFunctions.GetDataSet("Select * from SizeMapping Where GrpCode='" + dr["GrpCode"].ToString() + "' And GrpSubCode='" + dr["GrpSubCode"].ToString() + "' And SizeId='" + dr["SZSYSID"].ToString() + "'");
                if(dsCheck.Tables[0].Rows.Count>0)
                {
                    String Query = "Update SizeMapping Set SizeDesc='" + dr["SizeDesc"].ToString() + "' Where GrpCode='" + dr["GrpCode"].ToString() + "' And GrpSubCode='" + dr["GrpSubCode"].ToString() + "' And SizeId='" + dr["SZSYSID"].ToString() + "'";
                    ProjectFunctions.GetDataSet(Query);
                }
                else
                {
                    if(dr["SizeDesc"].ToString().Trim().Length>0)
                    {
                        String Query = "Insert into  SizeMapping (GrpCode,GrpSubCode,SizeId, SizeDesc)values('" + dr["GrpCode"].ToString() + "','" + dr["GrpSubCode"].ToString() + "','" + dr["SZSYSID"].ToString() + "','" + dr["SizeDesc"].ToString() + "')";
                        ProjectFunctions.GetDataSet(Query);
                    }
                   
                }
            }
            SplashScreenManager.CloseForm(false);
            this.Close();
        }
    }
}