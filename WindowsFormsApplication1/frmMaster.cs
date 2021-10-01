using DevExpress.Utils.Menu;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmMaster : DevExpress.XtraEditors.XtraForm
    {
        public frmMaster() { InitializeComponent(); }

        private void FillGrid()
        {
            PrintLogWin.PrintLog("FillGrid ******************** " + GlobalVariables.ProgCode);

            try
            {
                DataSet ds = ProjectFunctions.GetDataSet("Select ProgProcName,ProgDesc from ProgramMaster Where ProgCode='" +
                    GlobalVariables.ProgCode +
                    "'");
                string ProcedureName = ds.Tables[0].Rows[0]["ProgProcName"].ToString();


                PrintLogWin.PrintLog("FillGrid => ProcedureName ******************** " + ProcedureName);

                ProjectFunctions.BindMasterFormToGrid(ProcedureName, InvoiceGrid, InvoiceGridView);
                lbl.Text = ds.Tables[0].Rows[0]["ProgDesc"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox_Debug.ShowBox("frmMaster => FillGrid() => " + ex);
            }
        }

        private void InvoiceGrid_Load(object sender, EventArgs e)
        {
            ProjectFunctions.ToolStripVisualize(Menu_ToolStrip);
            ProjectFunctions.GirdViewVisualize(InvoiceGridView);
            FillGrid();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (btnAdd.Enabled)
            {


                if (GlobalVariables.ProgCode == "PROG241")
                {
                    WindowsFormsApplication1.Production.FrmFabricStock frm = new WindowsFormsApplication1.Production.FrmFabricStock()
                    { S1 = btnAdd.Text, Text = "Fabric Stock Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG240")
                {
                    WindowsFormsApplication1.Production.FrmFabricTypeMst frm = new WindowsFormsApplication1.Production.FrmFabricTypeMst()
                    { S1 = btnAdd.Text, Text = "Fabric Type Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG239")
                {
                    WindowsFormsApplication1.Production.FrmFabricMaster frm = new WindowsFormsApplication1.Production.FrmFabricMaster()
                    { S1 = btnAdd.Text, Text = "Fabric Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }




                if (GlobalVariables.ProgCode == "PROG238")
                {
                    WindowsFormsApplication1.Production.FrmYarnStock frm = new WindowsFormsApplication1.Production.FrmYarnStock()
                    { S1 = btnAdd.Text, Text = "Yarn Stock Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG237")
                {
                    WindowsFormsApplication1.Production.frmYarnTypeMst frm = new WindowsFormsApplication1.Production.frmYarnTypeMst()
                    { S1 = btnAdd.Text, Text = "Yarn Type Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG236")
                {
                    WindowsFormsApplication1.Production.FrmYarnMaster frm = new WindowsFormsApplication1.Production.FrmYarnMaster()
                    { S1 = btnAdd.Text, Text = "Yarn Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG235")
                {
                    WindowsFormsApplication1.Master.FrmHOlidayMst frm = new WindowsFormsApplication1.Master.FrmHOlidayMst()
                    { S1 = btnAdd.Text, Text = "Holiday Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG234")
                {
                    WindowsFormsApplication1.Master.FrmAttendanceStatusMst frm = new WindowsFormsApplication1.Master.FrmAttendanceStatusMst()
                    { S1 = btnAdd.Text, Text = "Attendance Status  Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG233")
                {
                    WindowsFormsApplication1.Transaction.FrmMessageBuilder frm = new WindowsFormsApplication1.Transaction.FrmMessageBuilder()
                    { S1 = btnAdd.Text, Text = "Message  Builder Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG229")
                {
                    WindowsFormsApplication1.Master.FrmSubProcessMst frm = new WindowsFormsApplication1.Master.FrmSubProcessMst()
                    { S1 = btnAdd.Text, Text = "Sub Process Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG228")
                {
                    WindowsFormsApplication1.Master.FrmMachineTypeMst frm = new WindowsFormsApplication1.Master.FrmMachineTypeMst()
                    { S1 = btnAdd.Text, Text = "Machine Type Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG227")
                {
                    WindowsFormsApplication1.Master.FrmMachineBrandMst frm = new WindowsFormsApplication1.Master.FrmMachineBrandMst()
                    { S1 = btnAdd.Text, Text = "Machine Brand Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG226")
                {
                    WindowsFormsApplication1.Master.FrmMachineMst frm = new WindowsFormsApplication1.Master.FrmMachineMst()
                    { S1 = btnAdd.Text, Text = "Machine Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG225")
                {
                    WindowsFormsApplication1.Master.frmContractorMst frm = new WindowsFormsApplication1.Master.frmContractorMst()
                    { S1 = btnAdd.Text, Text = "Contractor Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG221")
                {
                    WindowsFormsApplication1.Master.FrmProcessMst frm = new WindowsFormsApplication1.Master.FrmProcessMst()
                    { S1 = btnAdd.Text, Text = "Process Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG212")
                {
                    WindowsFormsApplication1.Master.FrmSizeMapping frm = new WindowsFormsApplication1.Master.FrmSizeMapping()
                    { Text = "Size Mapping Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG180")
                {
                    WindowsFormsApplication1.Transaction.FrmDesignDataTemplates frm = new WindowsFormsApplication1.Transaction.FrmDesignDataTemplates()
                    { Text = "Create Data Template" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG176")
                {
                    WindowsFormsApplication1.Master.FrmBranchMst frm = new WindowsFormsApplication1.Master.FrmBranchMst()
                    { S1 = btnAdd.Text, Text = "Branch Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG175")
                {
                    WindowsFormsApplication1.Master.FrmCityMst frm = new WindowsFormsApplication1.Master.FrmCityMst()
                    { S1 = btnAdd.Text, Text = "City Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG174")
                {
                    WindowsFormsApplication1.Master.frmStateMst frm = new WindowsFormsApplication1.Master.frmStateMst()
                    { S1 = btnAdd.Text, Text = "State Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG200")
                {
                    WindowsFormsApplication1.frmFYCreation frm = new WindowsFormsApplication1.frmFYCreation()
                    { S1 = btnAdd.Text, Text = "Financial Year Creation" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG170")
                {
                    Master.frmMeasurementMappingWithArt frm = new Master.frmMeasurementMappingWithArt()
                    { S1 = btnAdd.Text, Text = "Measurement Mapping With Art Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG169")
                {
                    Master.frmMeasurementMapping frm = new Master.frmMeasurementMapping()
                    { S1 = btnAdd.Text, Text = "Measurement Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG135")
                {
                    Transaction.Pos.SchemeSetup frm = new Transaction.Pos.SchemeSetup()
                    { S1 = btnAdd.Text, Text = "Scheme Setup Addition" };

                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG127")
                {
                    FrmWorkerMaster frm = new FrmWorkerMaster() { S1 = btnAdd.Text, Text = "Worker Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }

                if (GlobalVariables.ProgCode == "PROG126")
                {
                    FrmProductMstAddEdit frm = new FrmProductMstAddEdit()
                    { S1 = btnAdd.Text, Text = "Item Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }

                if (GlobalVariables.ProgCode == "PROG125")
                {
                    FrmArticleMst frm = new FrmArticleMst() { S1 = btnAdd.Text, Text = "User Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }

                if (GlobalVariables.ProgCode == "PROG122")
                {
                    FrmBrand frm = new FrmBrand() { S1 = btnAdd.Text, Text = "Brand Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG124")
                {
                    FrmSizeMMaster frm = new FrmSizeMMaster() { S1 = btnAdd.Text, Text = "Size Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }

                if (GlobalVariables.ProgCode == "PROG123")
                {
                    FrmColors frm = new FrmColors() { S1 = btnAdd.Text, Text = "Colors Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG121")
                {
                    FrmCustomerMst frm = new FrmCustomerMst() { S1 = btnAdd.Text, Text = "Customer Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG120")
                {
                    FrmCompanyMaster frm = new FrmCompanyMaster() { S1 = btnAdd.Text, Text = "Company Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG119")
                {
                    FrmTransporterMaster frm = new FrmTransporterMaster()
                    { S1 = btnAdd.Text, Text = "Transporter Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG118")
                {
                    FrmAddressBook frm = new FrmAddressBook() { S1 = btnAdd.Text, Text = "Address Book Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG117")
                {
                    FrmAddressBookGroup frm = new FrmAddressBookGroup()
                    { S1 = btnAdd.Text, Text = "Address Book Groups Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG115")
                {
                    Administration.FrmRoleMst frm = new Administration.FrmRoleMst()
                    { S1 = btnAdd.Text, Text = "Role Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG106")
                {
                    FrmBomMstAddEdit frm = new FrmBomMstAddEdit()
                    { S1 = btnAdd.Text, Text = "Bill Of Material Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (ComparisonUtils.IsEqualTo_String(GlobalVariables.ProgCode, WIN_APP_TABS._frmNewFormAAddEdit))
                {
                    FrmNewFormAAddEdit frm = new FrmNewFormAAddEdit() { S1 = btnAdd.Text, Text = "Program Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (ComparisonUtils.IsEqualTo_String(GlobalVariables.ProgCode, WIN_APP_TABS._frmUserDetails))
                {
                    FrmUserDetails frm = new FrmUserDetails() { S1 = btnAdd.Text, Text = "User Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }

                if (GlobalVariables.ProgCode == "PROG8")
                {
                    FrmAccountMstAddEdit frm = new FrmAccountMstAddEdit()
                    { S1 = btnAdd.Text, Text = "Account Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG9")
                {
                    frmDepartmentAddUpdate frm = new frmDepartmentAddUpdate()
                    { S1 = btnAdd.Text, Text = "Department Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG10")
                {
                    FrmDesignationAddEdit frm = new FrmDesignationAddEdit()
                    { S1 = btnAdd.Text, Text = "Designation Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }

                if (GlobalVariables.ProgCode == "PROG12")
                {
                    frmLedgerAddEdit frm = new frmLedgerAddEdit() { S1 = btnAdd.Text, Text = "Ledger Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }

                if (GlobalVariables.ProgCode == "PROG14")
                {
                    FrmUOMAddEdit frm = new FrmUOMAddEdit() { S1 = btnAdd.Text, Text = "Unit Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }


                if (GlobalVariables.ProgCode == "PROG246")
                {
                    WindowsFormsApplication1.Master.FrmGrpMstBSHeads frm = new WindowsFormsApplication1.Master.FrmGrpMstBSHeads() { S1 = btnAdd.Text, Text = "Group Head Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG16")
                {
                    FrmGroupMstAddEdit frm = new FrmGroupMstAddEdit() { S1 = btnAdd.Text, Text = "Group Head Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG17")
                {
                    frmTdsAddEdit frm = new frmTdsAddEdit() { S1 = btnAdd.Text, Text = "TDS Group Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG18")
                {
                    frmTaxMasterAddEdit frm = new frmTaxMasterAddEdit()
                    { S1 = btnAdd.Text, Text = "Tax Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }

                if (GlobalVariables.ProgCode == "PROG20")
                {
                    FrmProductMstAddEdit frm = new FrmProductMstAddEdit()
                    { S1 = btnAdd.Text, Text = "Product Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG21")
                {
                    FrmEmployeeMstAddEdit frm = new FrmEmployeeMstAddEdit()
                    { S1 = btnAdd.Text, Text = "Employee Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG29")
                {
                    Master.FrmCategoryMst frm = new Master.FrmCategoryMst()
                    { S1 = btnAdd.Text, Text = "Category Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG30")
                {
                    FrmEmployeeMstAddEdit frm = new FrmEmployeeMstAddEdit()
                    { S1 = btnAdd.Text, Text = "Employee Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG34")
                {
                    Master.frmBalanceSheetHeads frm = new Master.frmBalanceSheetHeads()
                    { S1 = btnAdd.Text, Text = "Balance Sheet Head Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }

                if (GlobalVariables.ProgCode == "PROG160")
                {
                    FrmEmployeeMstAddEdit frm = new FrmEmployeeMstAddEdit()
                    { S1 = btnAdd.Text, Text = "Employee Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG155")
                {
                    Master.FrmCategoryMst frm = new Master.FrmCategoryMst()
                    { S1 = btnAdd.Text, Text = "Category Master Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG156")
                {
                    frmDepartmentAddUpdate frm = new frmDepartmentAddUpdate()
                    { S1 = btnAdd.Text, Text = "Department Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG157")
                {
                    FrmDesignationAddEdit frm = new FrmDesignationAddEdit()
                    { S1 = btnAdd.Text, Text = "Designation Addition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
            }
            FillGrid();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            if (btnEdit.Enabled)
            {
                if (GlobalVariables.ProgCode == "PROG241")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Production.FrmFabricStock frm = new WindowsFormsApplication1.Production.FrmFabricStock()
                    { S1 = btnEdit.Text, Text = "Fabric Stock Edition", FabricCode = CurrentRow["FabricCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG240")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Production.FrmFabricTypeMst frm = new WindowsFormsApplication1.Production.FrmFabricTypeMst()
                    { S1 = btnEdit.Text, Text = "Fabric Type Edition", FabricTypeCode = CurrentRow["FabricTypeCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG239")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Production.FrmFabricMaster frm = new WindowsFormsApplication1.Production.FrmFabricMaster()
                    { S1 = btnEdit.Text, Text = "Fabric Master Edition", FabricCode = CurrentRow["FabricCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }


                if (GlobalVariables.ProgCode == "PROG238")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Production.FrmYarnStock frm = new WindowsFormsApplication1.Production.FrmYarnStock()
                    { S1 = btnEdit.Text, Text = "Yarn Stock Edition", YarnCode = CurrentRow["YarnCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG237")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Production.frmYarnTypeMst frm = new WindowsFormsApplication1.Production.frmYarnTypeMst()
                    { S1 = btnEdit.Text, Text = "Yarn Type Edition", YarnTypeCode = CurrentRow["YarnTypeCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG236")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Production.FrmYarnMaster frm = new WindowsFormsApplication1.Production.FrmYarnMaster()
                    { S1 = btnEdit.Text, Text = "Yarn Master Edition", YarnCode = CurrentRow["YarnCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG235")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Master.FrmHOlidayMst frm = new WindowsFormsApplication1.Master.FrmHOlidayMst()
                    { S1 = btnEdit.Text, Text = "Holiday Master Edition", HolidaySysID = CurrentRow["serial_id"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG234")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Master.FrmAttendanceStatusMst frm = new WindowsFormsApplication1.Master.FrmAttendanceStatusMst()
                    { S1 = btnEdit.Text, Text = "Attendance Status  Edition", StatusID = CurrentRow["status_id"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG233")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Transaction.FrmMessageBuilder frm = new WindowsFormsApplication1.Transaction.FrmMessageBuilder()
                    { S1 = btnEdit.Text, Text = "Message  Builder Edition", MessageCode = CurrentRow["MessageCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG232")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Administration.FrmAPIIntegrationInfo frm = new WindowsFormsApplication1.Administration.FrmAPIIntegrationInfo()
                    { Text = "API Integration Edition", TransId = CurrentRow["TransId"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG229")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Master.FrmSubProcessMst frm = new WindowsFormsApplication1.Master.FrmSubProcessMst()
                    { S1 = btnEdit.Text, Text = "Sub Process Master Edition", SubProcessCode = CurrentRow["SubProcessCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG228")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Master.FrmMachineTypeMst frm = new WindowsFormsApplication1.Master.FrmMachineTypeMst()
                    { S1 = btnEdit.Text, Text = "Machine Type Master Edition", TypeCode = CurrentRow["TypeCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG227")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Master.FrmMachineBrandMst frm = new WindowsFormsApplication1.Master.FrmMachineBrandMst()
                    { S1 = btnEdit.Text, Text = "Machine Brand Master Edition", BrandCode = CurrentRow["BrandCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG226")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Master.FrmMachineMst frm = new WindowsFormsApplication1.Master.FrmMachineMst()
                    { S1 = btnEdit.Text, Text = "Machine Master Edition", MachineCode = CurrentRow["MachineCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG225")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Master.frmContractorMst frm = new WindowsFormsApplication1.Master.frmContractorMst()
                    { S1 = btnEdit.Text, Text = "Contractor Master Edition", CNTSYSID = CurrentRow["CNTSYSID"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG221")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Master.FrmProcessMst frm = new WindowsFormsApplication1.Master.FrmProcessMst()
                    { S1 = btnEdit.Text, Text = "Process Master Edition", ProcessCode = CurrentRow["ProcessCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG176")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Master.FrmBranchMst frm = new WindowsFormsApplication1.Master.FrmBranchMst()
                    { S1 = btnEdit.Text, Text = "Branch Editing", BranchCode = CurrentRow["UNITID"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG175")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Master.FrmCityMst frm = new WindowsFormsApplication1.Master.FrmCityMst()
                    { S1 = btnEdit.Text, Text = "City Editing", CityCode = CurrentRow["CTSYSID"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG174")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.Master.frmStateMst frm = new WindowsFormsApplication1.Master.frmStateMst()
                    { S1 = btnEdit.Text, Text = "State Editing", StateCode = CurrentRow["STSYSID"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG200")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    WindowsFormsApplication1.frmFYCreation frm = new WindowsFormsApplication1.frmFYCreation()
                    {
                        S1 = btnEdit.Text,
                        Text = "Financial Year Editing",
                        TransId = Convert.ToInt32(CurrentRow["TransID"])
                    };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG170")
                {
                    Master.frmMeasurementMappingWithArt frm = new Master.frmMeasurementMappingWithArt()
                    { S1 = btnEdit.Text, Text = "Measurement Mapping With Art Edition" };
                    frm.StartPosition = FormStartPosition.CenterScreen;
                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG169")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    Master.frmMeasurementMapping frm = new Master.frmMeasurementMapping()
                    { S1 = btnEdit.Text, Text = "Measurement Edition", MCode = CurrentRow["MCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG135")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    Transaction.Pos.SchemeSetup frm = new Transaction.Pos.SchemeSetup()
                    { S1 = btnEdit.Text, Text = "Scheme Setup Edition", SchemeID = CurrentRow["SchmID"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG127")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmWorkerMaster frm = new FrmWorkerMaster()
                    { S1 = btnEdit.Text, Text = "Worker Addition", WRKSYSID = CurrentRow["WRKSYSID"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG126")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmProductMstAddEdit frm = new FrmProductMstAddEdit()
                    { S1 = btnEdit.Text, Text = "Item Master Edition", PrdCode = CurrentRow["PrdCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG125")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmArticleMst frm = new FrmArticleMst()
                    { S1 = btnEdit.Text, Text = "Article Edition", PrdCode = CurrentRow["ARTSYSID"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG122")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmBrand frm = new FrmBrand()
                    { S1 = btnEdit.Text, Text = "Brand Edition", BrandCode = CurrentRow["BRSYSID"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG124")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmSizeMMaster frm = new FrmSizeMMaster()
                    { S1 = btnEdit.Text, Text = "Size Edition", SZSYSID = CurrentRow["SZSYSID"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG123")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmColors frm = new FrmColors()
                    { S1 = btnEdit.Text, Text = "Colors Edition", COLSYSID = CurrentRow["COLSYSID"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG121")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmCustomerMst frm = new FrmCustomerMst()
                    { S1 = btnEdit.Text, Text = "Customer Edition", CAFSYSID = CurrentRow["CAFSYSID"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG120")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmCompanyMaster frm = new FrmCompanyMaster()
                    { S1 = btnEdit.Text, Text = "Company Editing", COMSYSID = CurrentRow["COMSYSID"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG119")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmTransporterMaster frm = new FrmTransporterMaster()
                    { S1 = btnEdit.Text, Text = "Transporter Edition", TRPRSYSID = CurrentRow["TRPRSYSID"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                    FillGrid();
                }
                if (GlobalVariables.ProgCode == "PROG118")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmAddressBook frm = new FrmAddressBook()
                    {
                        S1 = btnEdit.Text,
                        Text = "Address Book Edition",
                        AddressBookCode = CurrentRow["ADBSYSID"].ToString()
                    };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG117")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmAddressBookGroup frm = new FrmAddressBookGroup()
                    {
                        S1 = btnEdit.Text,
                        Text = "Address Book Groups Edition",
                        AddressBookGroupCode = CurrentRow["AddressBookGroupCode"].ToString()
                    };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (ComparisonUtils.IsEqualTo_String(GlobalVariables.ProgCode, WIN_APP_TABS._frmRoleMst))
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);

                    Administration.FrmRoleMst frm = new Administration.FrmRoleMst()
                    { S1 = btnEdit.Text, Text = "Role Addition", RoleCode = CurrentRow["RoleCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG106")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmBomMstAddEdit frm = new FrmBomMstAddEdit()
                    {
                        S1 = btnEdit.Text,
                        Text = "Bill Of Material Editing",
                        Bomno = CurrentRow["bomNo"].ToString(),
                        BomPrdId = CurrentRow["bomPrdId"].ToString()
                    };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG1")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmNewFormAAddEdit frm = new FrmNewFormAAddEdit()
                    { S1 = btnEdit.Text, Text = "Program Editing", ProgCode = CurrentRow["ProgCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                //*******************//
                //This Code Moved To XtraForm_UserMaster
                if (GlobalVariables.ProgCode == WIN_APP_TABS._frmUserDetails)
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmUserDetails frm = new FrmUserDetails()
                    { S1 = btnEdit.Text, Text = "User Editing", UserName = CurrentRow["UserName"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    /////
                    ///frm.ShowDialog(Parent);
                }

                if (GlobalVariables.ProgCode == "PROG8")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmAccountMstAddEdit frm = new FrmAccountMstAddEdit()
                    { S1 = btnEdit.Text, Text = "Account Editing", AccCode = CurrentRow["AccCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG9")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    frmDepartmentAddUpdate frm = new frmDepartmentAddUpdate()
                    { S1 = btnEdit.Text, Text = "Department Editing", DeptCode = CurrentRow["DeptCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG10")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmDesignationAddEdit frm = new FrmDesignationAddEdit()
                    { S1 = btnEdit.Text, Text = "Designation Editing", DesgCode = CurrentRow["DesgCode"].ToString() };


                    frm.ShowDialog(Parent);
                }

                if (GlobalVariables.ProgCode == "PROG12")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    frmLedgerAddEdit frm = new frmLedgerAddEdit()
                    { S1 = btnEdit.Text, Text = "Ledger  Editing", LgrCode = CurrentRow["LgrCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }

                if (GlobalVariables.ProgCode == "PROG14")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmUOMAddEdit frm = new FrmUOMAddEdit()
                    { S1 = btnEdit.Text, Text = "Unit  Editing", UomCode = CurrentRow["UomCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                
                if (GlobalVariables.ProgCode == "PROG246")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    WindowsFormsApplication1.Master.FrmGrpMstBSHeads frm = new WindowsFormsApplication1.Master.FrmGrpMstBSHeads()
                    {
                        S1 = btnEdit.Text,
                        Text = "Group Head Editing",
                        GrpCode = CurrentRow["GrpCode"].ToString(),
                        SubGrpCode = CurrentRow["GrpSubCode"].ToString()
                    };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG16")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmGroupMstAddEdit frm = new FrmGroupMstAddEdit()
                    {
                        S1 = btnEdit.Text,
                        Text = "Group Head Editing",
                        GrpCode = CurrentRow["GrpCode"].ToString(),
                        SubGrpCode = CurrentRow["GrpSubCode"].ToString()
                    };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG17")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    frmTdsAddEdit frm = new frmTdsAddEdit()
                    { S1 = btnEdit.Text, Text = "TDS Group Editing", TdsCode = CurrentRow["TdsCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG18")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    frmTaxMasterAddEdit frm = new frmTaxMasterAddEdit()
                    { S1 = btnEdit.Text, Text = "Tax Master Editing", TaxCode = CurrentRow["TaxCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }

                if (GlobalVariables.ProgCode == "PROG20")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmProductMstAddEdit frm = new FrmProductMstAddEdit()
                    { S1 = btnEdit.Text, Text = "Dealer Master Editing", PrdCode = CurrentRow["PrdCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG22")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmEmployeeMstAddEdit frm = new FrmEmployeeMstAddEdit()
                    { S1 = btnEdit.Text, Text = "Employee Master Editing", EmpCode = CurrentRow["EmpCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG29")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    Master.FrmCategoryMst frm = new Master.FrmCategoryMst()
                    {
                        S1 = btnEdit.Text,
                        Text = "Category Master Editing",
                        CatgCode = CurrentRow["CatgCode"].ToString()
                    };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG30")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmEmployeeMstAddEdit frm = new FrmEmployeeMstAddEdit()
                    { S1 = btnEdit.Text, Text = "Employee Master Editing", EmpCode = CurrentRow["EmpCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG34")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    Master.frmBalanceSheetHeads frm = new Master.frmBalanceSheetHeads()
                    {
                        S1 = btnEdit.Text,
                        Text = "Balance Sheet Head  Editing",
                        BSCode = CurrentRow["BSCode"].ToString()
                    };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }

                if (GlobalVariables.ProgCode == "PROG156")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    frmDepartmentAddUpdate frm = new frmDepartmentAddUpdate()
                    { S1 = btnEdit.Text, Text = "Department Editing", DeptCode = CurrentRow["DeptCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG157")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmDesignationAddEdit frm = new FrmDesignationAddEdit()
                    { S1 = btnEdit.Text, Text = "Designation Editing", DesgCode = CurrentRow["DesgCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG160")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    FrmEmployeeMstAddEdit frm = new FrmEmployeeMstAddEdit()
                    { S1 = btnEdit.Text, Text = "Employee Master Editing", EmpCode = CurrentRow["EmpCode"].ToString() };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
                if (GlobalVariables.ProgCode == "PROG155")
                {
                    DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                    Master.FrmCategoryMst frm = new Master.FrmCategoryMst()
                    {
                        S1 = btnEdit.Text,
                        Text = "Category Master Editing",
                        CatgCode = CurrentRow["CatgCode"].ToString()
                    };
                    frm.StartPosition = FormStartPosition.CenterScreen;


                    frm.ShowDialog(Parent);
                }
            }
            FillGrid();
        }

        private void InvoiceGrid_DoubleClick(object sender, EventArgs e) { BtnEdit_Click(null, e); }

        private void InvoiceGrid_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                BtnEdit_Click(null, e);
            }
        }

        private void InvoiceGridView_PopupMenuShowing(object sender, PopupMenuShowingEventArgs e)
        {
            try
            {
                var formatRulesMenu = new DXPopupMenu();
                var view = sender as GridView;

                DXMenuItem Copy;
                DXMenuItem SAR;
                DXMenuItem Collapse;
                DXMenuItem Expand;
                DXMenuItem FixLeft;
                DXMenuItem FixRight;
                DXMenuItem UnFix;
                DXMenuItem PartyAccount;
                DXMenuItem XMLData;
                DXMenuItem XMLSCHEMA;
                DXMenuItem APICount;
                DXMenuItem HSNCodeInfo;
                DataRow CurrentRow = InvoiceGridView.GetDataRow(InvoiceGridView.FocusedRowHandle);
                PartyAccount = new DXMenuItem("View Party Account",
                                              (o1, e1) =>
                                              {
                                                  DataSet ds = ProjectFunctions.GetDataSet("[sp_ZoomPartyAct] '2019-01-01','" +
                                                      DateTime.Now.ToString("yyyy-MM-dd") +
                                                      "','" +
                                                      CurrentRow["AccCode"].ToString() +
                                                      "'");
                                                  if (ds.Tables[0].Rows.Count > 0)
                                                  {
                                                      FormReports.FrmPartyAccounts frm = new FormReports.FrmPartyAccounts()
                                                      {
                                                          Text =
                                                          "Zoom Party Account - [" +
                                                              CurrentRow["AccName"].ToString() +
                                                              " - " +
                                                              CurrentRow["AccCode"].ToString() +
                                                              " ]",
                                                          DsGetData = ds
                                                      };
                                                      var P = ProjectFunctions.GetPositionInForm(this);
                                                      frm.Location = new Point(P.X +
                                                          (ClientSize.Width / 2 - frm.Size.Width / 2),
                                                                               P.Y +
                                                          (ClientSize.Height / 2 - frm.Size.Height / 2));
                                                      frm.ShowDialog(Parent);
                                                  }
                                              });
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
                Expand = new DXMenuItem("Expand All",
                                        (o1, e1) =>
                                        {
                                            InvoiceGridView.ExpandAllGroups();
                                        });
                Collapse = new DXMenuItem("Collapse All",
                                          (o1, e1) =>
                                          {
                                              InvoiceGridView.CollapseAllGroups();
                                          });
                FixLeft = new DXMenuItem("Fix Column Left",
                                         (o1, e1) =>
                                         {
                                             InvoiceGridView.OptionsView.ColumnAutoWidth = false;
                                             var hitInfo = InvoiceGridView.CalcHitInfo(InvoiceGrid.PointToClient(Control.MousePosition));
                                             if (hitInfo.InRowCell)
                                             {
                                                 int rowHandle = hitInfo.RowHandle;
                                                 DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
                                                 column = hitInfo.Column;
                                                 column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Left;
                                             }
                                         });
                FixRight = new DXMenuItem("Fix Column Right",
                                          (o1, e1) =>
                                          {
                                              InvoiceGridView.OptionsView.ColumnAutoWidth = false;
                                              var hitInfo = InvoiceGridView.CalcHitInfo(InvoiceGrid.PointToClient(Control.MousePosition));
                                              if (hitInfo.InRowCell)
                                              {
                                                  int rowHandle = hitInfo.RowHandle;
                                                  DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
                                                  column = hitInfo.Column;
                                                  column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.Right;
                                              }
                                          });
                UnFix = new DXMenuItem("Unfix Column",
                                       (o1, e1) =>
                                       {
                                           InvoiceGridView.OptionsView.ColumnAutoWidth = false;
                                           var hitInfo = InvoiceGridView.CalcHitInfo(InvoiceGrid.PointToClient(Control.MousePosition));
                                           if (hitInfo.InRowCell)
                                           {
                                               int rowHandle = hitInfo.RowHandle;
                                               DevExpress.XtraGrid.Columns.GridColumn column = new DevExpress.XtraGrid.Columns.GridColumn();
                                               column = hitInfo.Column;
                                               column.Fixed = DevExpress.XtraGrid.Columns.FixedStyle.None;
                                           }
                                       });


                XMLData = new DXMenuItem("XML Schema With Data",
                                      (o1, e1) =>
                                      {
                                          (InvoiceGridView.DataSource as DataTable).WriteXml("C:\\Temp\\Data.xml");
                                      });
                XMLSCHEMA = new DXMenuItem("XML Schema",
                                        (o1, e1) =>
                                        {
                                            (InvoiceGridView.DataSource as DataTable).WriteXmlSchema("C:\\Temp\\Data.xml");
                                        });
                APICount = new DXMenuItem("API PENDING HITS",
                                       (o1, e1) =>
                                       {
                                           ProjectFunctions.GetAPIPendingHitsAsync();
                                       });
                HSNCodeInfo = new DXMenuItem("HSN Code Information",
                                       (o1, e1) =>
                                       {
                                           ProjectFunctions.GetAPIHSNCodeInfo(CurrentRow["GrpHSNCode"].ToString());
                                       });


                e.Menu.Items.Add(Copy);
                e.Menu.Items.Add(SAR);
                e.Menu.Items.Add(Collapse);
                e.Menu.Items.Add(Expand);
                e.Menu.Items.Add(FixLeft);
                e.Menu.Items.Add(FixRight);
                e.Menu.Items.Add(UnFix);
                e.Menu.Items.Add(XMLData);
                e.Menu.Items.Add(XMLSCHEMA);
                if (GlobalVariables.ProgCode == "PROG8")
                {
                    e.Menu.Items.Add(PartyAccount);
                }

                if (GlobalVariables.ProgCode == "PROG232")
                {
                    e.Menu.Items.Add(APICount);
                }
                if (GlobalVariables.ProgCode == "PROG16")
                {
                    e.Menu.Items.Add(HSNCodeInfo);
                }

            }
            catch (Exception ex)

            {
                MessageBox_Debug.ShowBox(ex);
            }
        }

        private void InvoiceGrid_Click(object sender, EventArgs e)
        {

        }

        private void FrmMaster_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                frmSaleReportF2 frm = new frmSaleReportF2() { Text = "Sale Report", WorkingTag = "Today" };
                var P = ProjectFunctions.GetPositionInForm(this);
                frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2),
                                         P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                frm.ShowDialog(Parent);
            }
            if (e.KeyCode == Keys.F4)
            {
                frmSaleReportF2 frm = new frmSaleReportF2() { Text = "Sale Report", WorkingTag = "Month" };
                var P = ProjectFunctions.GetPositionInForm(this);
                frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2),
                                         P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                frm.ShowDialog(Parent);
            }
            if (e.KeyCode == Keys.F6)
            {
                frmSaleReportF2 frm = new frmSaleReportF2() { Text = "Sale Report", WorkingTag = "Year" };
                var P = ProjectFunctions.GetPositionInForm(this);
                frm.Location = new Point(P.X + (ClientSize.Width / 2 - frm.Size.Width / 2),
                                         P.Y + (ClientSize.Height / 2 - frm.Size.Height / 2));
                frm.ShowDialog(Parent);
            }
        }

        private void Menu_ToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}