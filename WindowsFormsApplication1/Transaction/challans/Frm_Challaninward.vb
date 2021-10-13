Imports SeqKartLibrary
Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Windows.Forms

Namespace WindowsFormsApplication1.Transaction.challans
    Public Partial Class Frm_Challaninward
        Inherits DevExpress.XtraEditors.XtraForm

        Public Property S1 As String
        Public Property ImNo As String
        Public Property ImDate As Date
        Private dt As DataTable = New DataTable()
        Private dsPopUps As DataSet = New DataSet()
        Private RowIndex As Integer = 0
        Private UpdateTag As String = "N"
        Private ProductFeedTag As String = "N"

        Public Sub New()
            Me.InitializeComponent()
            dt.Columns.Add("AgnstChallanType", GetType(String))
            dt.Columns.Add("AgnstChallanNo", GetType(String))
            dt.Columns.Add("PrdCode", GetType(String))
            dt.Columns.Add("PrdName", GetType(String))
            dt.Columns.Add("ARTNO", GetType(String))
            dt.Columns.Add("ARTDESC", GetType(String))
            dt.Columns.Add("ARTID", GetType(String))
            dt.Columns.Add("IssuedQty", GetType(Decimal))
            dt.Columns.Add("IssuedQtyInKgs", GetType(Decimal))
            dt.Columns.Add("UomCode", GetType(String))
            dt.Columns.Add("UomDesc", GetType(String))
            dt.Columns.Add("Bal", GetType(Decimal))
            dt.Columns.Add("ReceivedQty", GetType(Decimal))
            dt.Columns.Add("ReceivedQtyInKgs", GetType(Decimal))
            dt.Columns.Add("WastageQty", GetType(Decimal))
            dt.Columns.Add("WastageQtyInKgs", GetType(Decimal))
            dt.Columns.Add("ProcessCode", GetType(String))
            dt.Columns.Add("ProcessName", GetType(String))
            dt.Columns.Add("Rate", GetType(Decimal))
            dt.Columns.Add("CalculationType", GetType(String))
            dt.Columns.Add("CalcAmount", GetType(Decimal))
            dt.Columns.Add("Remarks", GetType(String))
            dt.Columns.Add("ActualQty", GetType(Decimal))
            dt.Columns.Add("ActualQtyInKgs", GetType(Decimal))
            dt.Columns.Add("TransID", GetType(Decimal))
            dsPopUps = ProjectFunctionsUtils.GetDataSet("sp_LoadBarPrintPopUps")
        End Sub

        Private Sub GetOurwardData()
            Dim ds As DataSet = WindowsFormsApplication1.ProjectFunctions.GetDataSet("select CHOTYPE,CHONO,CHODATE from CHOUTMain Where CHOPARTYCODE='" & Me.txtDebitPartyCode.Text & "'")

            If ds.Tables(0).Rows.Count > 0 Then
                ds.Tables(0).Columns.Add("Select", GetType(Boolean))

                For Each dr As DataRow In ds.Tables(0).Rows
                    dr("Select") = False
                Next

                Me.ChallanGrid.DataSource = ds.Tables(0)
                Me.ChallanGridView.BestFitColumns()
            Else
                Me.ChallanGrid.DataSource = Nothing
                Me.ChallanGridView.BestFitColumns()
            End If
        End Sub

        Private Sub GetOurwardDataFProcess()
            dt.Clear()
            Me.ChallanGridView.CloseEditor()
            Me.ChallanGridView.UpdateCurrentRow()

            For Each drchallan As DataRow In TryCast(Me.ChallanGrid.DataSource, DataTable).Rows

                If Equals(drchallan("Select").ToString().ToUpper(), "TRUE") Then
                    Dim ds As DataSet = WindowsFormsApplication1.ProjectFunctions.GetDataSet("sp_LoadChallanDataFProcess '" & drchallan("CHOTYPE").ToString() & "','" & drchallan("CHONO").ToString() & "','" & Convert.ToDateTime(drchallan("CHODATE")).ToString("yyyy-MM-dd") & "'")

                    If ds.Tables(0).Rows.Count > 0 Then
                        For Each dr As DataRow In ds.Tables(0).Rows
                            dt.ImportRow(dr)
                        Next
                    End If
                End If
            Next

            If dt.Rows.Count > 0 Then
                Me.BarCodeGrid.DataSource = dt
                Me.BarCodeGridView.BestFitColumns()
            Else
                Me.BarCodeGrid.DataSource = Nothing
                Me.BarCodeGridView.BestFitColumns()
            End If
        End Sub

        Private Sub Frm_Challaninward_Load(ByVal sender As Object, ByVal e As EventArgs)
            WindowsFormsApplication1.ProjectFunctions.ToolStripVisualize(Me.Menu_ToolStrip)
            WindowsFormsApplication1.ProjectFunctions.TextBoxVisualize(Me.groupControl1)

            If Equals(S1, "&Add") Then
                Me.txtTransDate.EditValue = Date.Now
                Me.txtReceivingDate.EditValue = Date.Now
                Me.txtGateEntryNo.Focus()
            End If

            If Equals(S1, "Edit") Then
                Dim ds As DataSet = WindowsFormsApplication1.ProjectFunctions.GetDataSet("sp_LoadCHINDataFEdit '" & ImNo & "','" & ImDate.Date.ToString("yyyy-MM-dd") & "','" & WindowsFormsApplication1.GlobalVariables.CUnitID & "'")

                If ds.Tables(0).Rows.Count > 0 Then
                    Me.txtDocNo.Text = ds.Tables(0).Rows(0)("DocNo").ToString()
                    Me.txtDocDate.EditValue = Convert.ToDateTime(ds.Tables(0).Rows(0)("DocDate"))
                    Me.txtGateEntryNo.Text = ds.Tables(0).Rows(0)("CHIGateEntryNo").ToString()
                    Me.txtTransNo.Text = ds.Tables(0).Rows(0)("CHINO").ToString()
                    Me.txtDocType.Text = ds.Tables(0).Rows(0)("CHITYPE").ToString()
                    Me.txtTransDate.EditValue = Convert.ToDateTime(ds.Tables(0).Rows(0)("CHIDATE"))
                    Me.txtReceivingDate.EditValue = Convert.ToDateTime(ds.Tables(0).Rows(0)("CHIReceiveDate"))
                    Me.txtDebitPartyCode.Text = ds.Tables(0).Rows(0)("CHIPARTYCODE").ToString()
                    Me.txtRemarks.Text = ds.Tables(0).Rows(0)("CHOREMARKS").ToString()
                    Me.txtTransporterCode.Text = ds.Tables(0).Rows(0)("CHOTRPID").ToString()
                    Me.txtTransporterName.Text = ds.Tables(0).Rows(0)("TrpName").ToString()
                    Me.txtDebitPartyName.Text = ds.Tables(0).Rows(0)("AccName").ToString()
                    Me.txtBillingAddress1.Text = ds.Tables(0).Rows(0)("AccAddress1").ToString()
                    Me.txtBillingAddress2.Text = ds.Tables(0).Rows(0)("AccAddress2").ToString()
                    Me.txtBillingAddress3.Text = ds.Tables(0).Rows(0)("AccAddress3").ToString()
                    Me.txtContactDetails.Text = ds.Tables(0).Rows(0)("AccTeleFax").ToString()
                    Me.txtBillingCity.Text = ds.Tables(0).Rows(0)("CTNAME").ToString()

                    If ds.Tables(1).Rows.Count > 0 Then
                        dt = ds.Tables(1)
                        Me.BarCodeGrid.DataSource = dt
                        Me.BarCodeGridView.BestFitColumns()
                        GetOurwardData()
                    Else
                        Me.BarCodeGrid.DataSource = Nothing
                        Me.BarCodeGridView.BestFitColumns()
                    End If
                End If
            End If
        End Sub

        Private Sub TxtDebitPartyCode_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.txtDebitPartyName.Text = String.Empty
            Me.txtBillingAddress1.Text = String.Empty
            Me.txtBillingAddress2.Text = String.Empty
            Me.txtBillingAddress3.Text = String.Empty
            Me.txtBillingCity.Text = String.Empty
        End Sub

        Private Sub PrepareActMstHelpGrid()
            Me.HelpGridView.Columns.Clear()
            Dim col1 As DevExpress.XtraGrid.Columns.GridColumn = New DevExpress.XtraGrid.Columns.GridColumn With {
                .FieldName = "AccName",
                .Visible = True,
                .VisibleIndex = 0
            }
            Me.HelpGridView.Columns.Add(col1)
            Dim col2 As DevExpress.XtraGrid.Columns.GridColumn = New DevExpress.XtraGrid.Columns.GridColumn With {
                .FieldName = "AccCode",
                .Visible = True,
                .VisibleIndex = 1
            }
            Me.HelpGridView.Columns.Add(col2)
            Dim col3 As DevExpress.XtraGrid.Columns.GridColumn = New DevExpress.XtraGrid.Columns.GridColumn With {
                .FieldName = "AccAddress1",
                .Visible = False
            }
            'col3.VisibleIndex = 2;
            Me.HelpGridView.Columns.Add(col3)
            Dim col4 As DevExpress.XtraGrid.Columns.GridColumn = New DevExpress.XtraGrid.Columns.GridColumn With {
                .FieldName = "AccAddress2",
                .Visible = False
            }
            'col4.VisibleIndex = 3;
            Me.HelpGridView.Columns.Add(col4)
            Dim col5 As DevExpress.XtraGrid.Columns.GridColumn = New DevExpress.XtraGrid.Columns.GridColumn With {
                .FieldName = "AccAddress3",
                .Visible = False
            }
            'col5.VisibleIndex = 4;
            Me.HelpGridView.Columns.Add(col5)
            Dim col6 As DevExpress.XtraGrid.Columns.GridColumn = New DevExpress.XtraGrid.Columns.GridColumn With {
                .FieldName = "CTNAME",
                .Visible = False
            }
            'col6.VisibleIndex = 5;
            Me.HelpGridView.Columns.Add(col6)
            Dim col7 As DevExpress.XtraGrid.Columns.GridColumn = New DevExpress.XtraGrid.Columns.GridColumn With {
                .FieldName = "STNAME",
                .Visible = False
            }
            Me.HelpGridView.Columns.Add(col7)
            Dim col8 As DevExpress.XtraGrid.Columns.GridColumn = New DevExpress.XtraGrid.Columns.GridColumn With {
                .FieldName = "AccZipCode",
                .Visible = False
            }
            Me.HelpGridView.Columns.Add(col8)
        End Sub

        Private Sub TxtDebitPartyCode_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode <> Keys.Back Then
                If e.KeyCode <> Keys.Delete Then
                    If e.KeyCode <> Keys.Up Then
                        If e.KeyCode <> Keys.Down Then
                            If e.KeyCode <> Keys.Left Then
                                If e.KeyCode <> Keys.Right Then
                                    If e.KeyCode <> Keys.F12 Then
                                        If e.KeyCode <> Keys.Enter Then
                                            PrepareActMstHelpGrid()
                                            Me.HelpGrid.Text = "txtDebitPartyCode"
                                            Me.txtSearchBox.Text = String.Empty
                                            Me.txtSearchBox.Text = Me.txtSearchBox.Text & WindowsFormsApplication1.ProjectFunctions.ValidateKeysForSearchBox(e)
                                            Me.HelpGrid.Show()
                                            Me.panelControl2.Visible = True
                                            Me.HelpGrid.Visible = True
                                            Me.txtSearchBox.Focus()
                                            Me.txtSearchBox.SelectionStart = Me.txtSearchBox.Text.Length
                                            Me.txtSearchBox.SelectionLength = 0
                                            Me.txtDebitPartyCode.Text = String.Empty
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If


            'e.Handled = true;

        End Sub

        Private Sub TxtTransporterCode_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Me.txtTransporterName.Text = String.Empty
        End Sub

        Private Sub TxtTransporterCode_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            If e.KeyCode <> Keys.Back Then
                If e.KeyCode <> Keys.Delete Then
                    If e.KeyCode <> Keys.Up Then
                        If e.KeyCode <> Keys.Down Then
                            If e.KeyCode <> Keys.Left Then
                                If e.KeyCode <> Keys.Right Then
                                    If e.KeyCode <> Keys.F12 Then
                                        If e.KeyCode <> Keys.Enter Then
                                            Me.HelpGrid.Text = "txtTransporterCode"
                                            Me.HelpGridView.Columns.Clear()
                                            Me.txtSearchBox.Text = String.Empty
                                            Me.txtSearchBox.Text = Me.txtSearchBox.Text & WindowsFormsApplication1.ProjectFunctions.ValidateKeysForSearchBox(e)
                                            Me.HelpGrid.Show()
                                            Me.panelControl2.Visible = True
                                            Me.HelpGrid.Visible = True
                                            Me.txtSearchBox.Focus()
                                            Me.txtSearchBox.SelectionStart = Me.txtSearchBox.Text.Length
                                            Me.txtSearchBox.SelectionLength = 0
                                        End If
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If

            e.Handled = True
            'if (e.KeyCode == Keys.Enter)
            '{

            '    HelpGridView.Columns.Clear();
            '    HelpGrid.Text = "txtTransporterCode";
            '    if (txtTransporterCode.Text.Trim().Length == 0)
            '    {
            '        DataSet ds = ProjectFunctions.GetDataSet("select TRPRSYSID,TRPRNAME,TRPRADD from TRANSPORTMASTER");
            '        if (ds.Tables[0].Rows.Count > 0)
            '        {
            '            HelpGrid.DataSource = ds.Tables[0];
            '            HelpGrid.Show();
            '            panelControl1.Visible = true;
            '            HelpGrid.Visible = true;
            '            HelpGrid.Focus();
            '            HelpGridView.BestFitColumns();
            '        }
            '        else
            '        {
            '            ProjectFunctions.SpeakError("No Records To Display");
            '        }
            '    }
            '    else
            '    {
            '        DataSet ds = ProjectFunctions.GetDataSet(" select TRPRSYSID,TRPRNAME,TRPRADD from TRANSPORTMASTER Where  TRPRSYSID='" + txtTransporterCode.Text.Trim() + "'");
            '        if (ds.Tables[0].Rows.Count > 0)
            '        {
            '            txtTransporterCode.Text = ds.Tables[0].Rows[0]["TRPRSYSID"].ToString();
            '            txtTransporterName.Text = ds.Tables[0].Rows[0]["TRPRNAME"].ToString();

            '            txtTransporterCode.Focus();
            '            panelControl1.Visible = false;
            '        }

            '        else
            '        {
            '            DataSet ds1 = ProjectFunctions.GetDataSet("select TRPRSYSID,TRPRNAME,TRPRADD from TRANSPORTMASTER");
            '            if (ds1.Tables[0].Rows.Count > 0)
            '            {
            '                HelpGrid.DataSource = ds.Tables[0];
            '                HelpGrid.Show();
            '                panelControl1.Visible = true;
            '                HelpGrid.Visible = true;
            '                HelpGrid.Focus();
            '                HelpGridView.BestFitColumns();
            '            }
            '            else
            '            {
            '                ProjectFunctions.SpeakError("No Records To Display");
            '            }
            '        }
            '    }
            '}
            'e.Handled = true;
        End Sub

        Private Sub HelpGrid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            Try

                If e.KeyCode = Keys.Enter Then
                    HelpGrid_DoubleClick(Nothing, e)
                End If

                If e.KeyCode = Keys.Escape Then
                    Me.panelControl1.Visible = False
                End If

            Catch ex As Exception
                WindowsFormsApplication1.ProjectFunctions.SpeakError(ex.Message)
            End Try
        End Sub

        Private Sub TxtSearchBox_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            Try
                Me.HelpGridView.CloseEditor()
                Me.HelpGridView.UpdateCurrentRow()

                If e.KeyCode = Keys.Enter Then
                    HelpGrid_DoubleClick(Nothing, e)
                End If

                If e.KeyCode = Keys.Down Then
                    Me.HelpGrid.Focus()
                End If

                If e.KeyCode = Keys.Escape Then
                    Me.panelControl1.Visible = False
                End If

                e.Handled = True
            Catch ex As Exception
                WindowsFormsApplication1.ProjectFunctions.SpeakError(ex.Message)
            End Try
        End Sub

        Private Sub HelpGrid_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            Me.HelpGridView.CloseEditor()
            Me.HelpGridView.UpdateCurrentRow()
            Dim row As DataRow = Me.HelpGridView.GetDataRow(Me.HelpGridView.FocusedRowHandle)

            If Equals(Me.HelpGrid.Text, "txtTransporterCode") Then
                Me.txtTransporterCode.Text = row("TRPRSYSID").ToString()
                Me.txtTransporterName.Text = row("TRPRNAME").ToString()
                Me.HelpGrid.Visible = False
                Me.panelControl2.Visible = False
                Me.txtTransporterCode.Focus()
            End If

            If Equals(Me.HelpGrid.Text, "txtDebitPartyCode") Then
                Me.txtDebitPartyCode.Text = row("AccCode").ToString()
                Me.txtDebitPartyName.Text = row("AccName").ToString()
                Me.txtBillingAddress1.Text = row("AccAddress1").ToString()
                Me.txtBillingAddress2.Text = row("AccAddress2").ToString()
                Me.txtBillingAddress3.Text = row("AccAddress3").ToString()
                Me.txtBillingCity.Text = row("CTNAME").ToString()
                Me.HelpGrid.Visible = False
                Me.panelControl2.Visible = False
                Me.txtTransporterCode.Focus()
                GetOurwardData()
            End If

            If Me.HelpGridView.RowCount > 0 Then
                If Equals(Me.HelpGrid.Text, "ProcessName") Then
                    Me.BarCodeGridView.UpdateCurrentRow()
                    Me.BarCodeGridView.SetRowCellValue(RowIndex, Me.BarCodeGridView.Columns("ProcessCode"), row("ProcessCode").ToString())
                    Me.BarCodeGridView.SetRowCellValue(RowIndex, Me.BarCodeGridView.Columns("ProcessName"), row("ProcessName").ToString())
                    Me.BarCodeGridView.SetRowCellValue(RowIndex, Me.BarCodeGridView.Columns("Rate"), Convert.ToDecimal(row("Rate")))
                    Me.BarCodeGridView.Focus()
                    Me.panelControl2.Visible = False
                    Me.BarCodeGridView.FocusedColumn = Me.BarCodeGridView.Columns("Rate")
                    Me.BarCodeGridView.FocusedRowHandle = RowIndex
                    Me.txtSearchBox.Text = String.Empty
                    dt.AcceptChanges()

                    If Equals(Me.BarCodeGridView.FocusedColumn.FieldName, "Rate") Then
                        Me.BarCodeGridView.ShowEditor()
                    End If
                End If

                If Equals(Me.HelpGrid.Text, "UomDesc") Then
                    Me.BarCodeGridView.UpdateCurrentRow()
                    Me.BarCodeGridView.SetRowCellValue(RowIndex, Me.BarCodeGridView.Columns("UomCode"), row("UomCode").ToString())
                    Me.BarCodeGridView.SetRowCellValue(RowIndex, Me.BarCodeGridView.Columns("UomDesc"), row("UomDesc").ToString())
                    Me.BarCodeGridView.Focus()
                    Me.panelControl2.Visible = False
                    Me.BarCodeGridView.FocusedColumn = Me.BarCodeGridView.Columns("Rate")
                    Me.BarCodeGridView.FocusedRowHandle = RowIndex
                    Me.txtSearchBox.Text = String.Empty
                    dt.AcceptChanges()

                    If Equals(Me.BarCodeGridView.FocusedColumn.FieldName, "Rate") Then
                        Me.BarCodeGridView.ShowEditor()
                    End If
                End If

                If Equals(Me.HelpGrid.Text, "ARTNO") Then
                    ProductFeedTag = "Y"

                    If Equals(ProductFeedTag, "N") Then
                        Dim dtNewRow As DataRow = dt.NewRow()
                        dtNewRow("ARTNO") = row("ARTNO").ToString()
                        dtNewRow("ARTDESC") = row("ARTDESC").ToString()
                        dtNewRow("ARTID") = row("ARTSYSID").ToString()
                        dt.Rows.Add(dtNewRow)

                        If dt.Rows.Count > 0 Then
                            Me.BarCodeGrid.DataSource = dt
                            Me.BarCodeGridView.BestFitColumns()
                        End If

                        Me.panelControl2.Visible = False
                        Me.BarCodeGridView.Focus()
                        Me.BarCodeGridView.MoveLast()
                        Me.BarCodeGridView.FocusedColumn = Me.BarCodeGridView.Columns("CHOColName")
                        Me.txtSearchBox.Text = String.Empty
                    Else
                        Me.BarCodeGridView.UpdateCurrentRow()
                        Me.BarCodeGridView.SetRowCellValue(RowIndex, Me.BarCodeGridView.Columns("ARTNO"), row("ARTNO").ToString())
                        Me.BarCodeGridView.SetRowCellValue(RowIndex, Me.BarCodeGridView.Columns("ARTDESC"), row("ARTDESC").ToString())
                        Me.BarCodeGridView.SetRowCellValue(RowIndex, Me.BarCodeGridView.Columns("ARTID"), row("ARTSYSID").ToString())
                        Me.BarCodeGridView.Focus()
                        Me.panelControl2.Visible = False
                        Me.BarCodeGridView.FocusedColumn = Me.BarCodeGridView.Columns("UOMDesc")
                        Me.BarCodeGridView.FocusedRowHandle = RowIndex
                        Me.txtSearchBox.Text = String.Empty
                        dt.AcceptChanges()
                        ProductFeedTag = "N"
                    End If
                End If

                If Equals(Me.HelpGrid.Text, "PrdName") Then
                    ProductFeedTag = "Y"
                    Dim dtNewRow As DataRow = dt.NewRow()
                    dtNewRow("PrdCode") = row("PrdCode").ToString()
                    dtNewRow("PrdName") = row("PrdName").ToString()
                    dt.Rows.Add(dtNewRow)

                    If dt.Rows.Count > 0 Then
                        Me.BarCodeGrid.DataSource = dt
                        Me.BarCodeGridView.BestFitColumns()
                    End If

                    Me.panelControl2.Visible = False
                    Me.BarCodeGridView.Focus()
                    Me.BarCodeGridView.MoveLast()
                    Me.BarCodeGridView.FocusedColumn = Me.BarCodeGridView.Columns("UOMDesc")
                    Me.txtSearchBox.Text = String.Empty

                    'if (BarCodeGridView.FocusedColumn.FieldName == "CHOManualDesc")
                    '{
                    '    BarCodeGridView.ShowEditor();
                    '}


                    ProductFeedTag = "Y"
                End If
            End If
        End Sub

        Private Sub BarCodeGrid_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
            Try
                Me.HelpGridView.Columns.Clear()
                Dim currentrow As DataRow = Me.BarCodeGridView.GetDataRow(Me.BarCodeGridView.FocusedRowHandle)

                If e.KeyCode <> Keys.Up Then
                    If e.KeyCode <> Keys.Down Then
                        If e.KeyCode <> Keys.Left Then
                            If e.KeyCode <> Keys.Right Then
                                If e.KeyCode <> Keys.F12 Then
                                    If e.KeyCode <> Keys.Enter Then
                                        If Equals(Me.BarCodeGridView.FocusedColumn.FieldName, "PrdName") Then
                                            If currentrow Is Nothing Then
                                                Me.HelpGrid.Text = "PrdName"
                                                Me.txtSearchBox.Text = Me.txtSearchBox.Text & WindowsFormsApplication1.ProjectFunctions.ValidateKeysForSearchBox(e)
                                                Me.panelControl2.Visible = True
                                                Me.panelControl2.Select()
                                                Me.txtSearchBox.Focus()
                                                Me.txtSearchBox.SelectionStart = Me.txtSearchBox.Text.Length
                                                Me.txtSearchBox.SelectionLength = 0
                                            Else
                                                Dim dsCheck As DataSet = WindowsFormsApplication1.ProjectFunctions.GetDataSet("Select * from PrdMst where PrdCode='" & WindowsFormsApplication1.ProjectFunctions.CheckNull(currentrow("PrdCode").ToString()) & "'")

                                                If dsCheck.Tables(0).Rows.Count > 0 Then
                                                    UpdateTag = "Y"
                                                    Me.HelpGrid.Text = "PrdName"
                                                    Me.txtSearchBox.Text = Me.txtSearchBox.Text & WindowsFormsApplication1.ProjectFunctions.ValidateKeysForSearchBox(e)
                                                    Me.panelControl2.Visible = True
                                                    Me.panelControl2.Select()
                                                    Me.txtSearchBox.Focus()
                                                    Me.txtSearchBox.SelectionStart = Me.txtSearchBox.Text.Length
                                                    Me.txtSearchBox.SelectionLength = 0
                                                    RowIndex = Me.BarCodeGridView.FocusedRowHandle
                                                Else
                                                    Me.HelpGrid.Text = "PrdName"
                                                    Me.txtSearchBox.Text = Me.txtSearchBox.Text & WindowsFormsApplication1.ProjectFunctions.ValidateKeysForSearchBox(e)
                                                    Me.panelControl2.Visible = True
                                                    Me.panelControl2.Select()
                                                    Me.txtSearchBox.Focus()
                                                    Me.txtSearchBox.SelectionStart = Me.txtSearchBox.Text.Length
                                                    Me.txtSearchBox.SelectionLength = 0
                                                    RowIndex = Me.BarCodeGridView.FocusedRowHandle
                                                End If
                                            End If
                                        End If

                                        If Equals(Me.BarCodeGridView.FocusedColumn.FieldName, "ARTNO") Then
                                            If currentrow Is Nothing Then
                                                Me.HelpGrid.Text = "ARTNO"
                                                Me.txtSearchBox.Text = Me.txtSearchBox.Text & WindowsFormsApplication1.ProjectFunctions.ValidateKeysForSearchBox(e)
                                                Me.panelControl2.Visible = True
                                                Me.panelControl2.Select()
                                                Me.txtSearchBox.Focus()
                                                Me.txtSearchBox.SelectionStart = Me.txtSearchBox.Text.Length
                                                Me.txtSearchBox.SelectionLength = 0
                                            Else
                                                Dim dsCheck As DataSet = WindowsFormsApplication1.ProjectFunctions.GetDataSet("Select * from ARTICLE where ARTNO='" & WindowsFormsApplication1.ProjectFunctions.CheckNull(currentrow("ARTNO").ToString()) & "'")

                                                If dsCheck.Tables(0).Rows.Count > 0 Then
                                                    UpdateTag = "Y"
                                                    Me.HelpGrid.Text = "ARTNO"
                                                    Me.txtSearchBox.Text = Me.txtSearchBox.Text & WindowsFormsApplication1.ProjectFunctions.ValidateKeysForSearchBox(e)
                                                    Me.panelControl2.Visible = True
                                                    Me.panelControl2.Select()
                                                    Me.txtSearchBox.Focus()
                                                    Me.txtSearchBox.SelectionStart = Me.txtSearchBox.Text.Length
                                                    Me.txtSearchBox.SelectionLength = 0
                                                    RowIndex = Me.BarCodeGridView.FocusedRowHandle
                                                Else
                                                    Me.HelpGrid.Text = "ARTNO"
                                                    Me.txtSearchBox.Text = Me.txtSearchBox.Text & WindowsFormsApplication1.ProjectFunctions.ValidateKeysForSearchBox(e)
                                                    Me.panelControl2.Visible = True
                                                    Me.panelControl2.Select()
                                                    Me.txtSearchBox.Focus()
                                                    Me.txtSearchBox.SelectionStart = Me.txtSearchBox.Text.Length
                                                    Me.txtSearchBox.SelectionLength = 0
                                                    RowIndex = Me.BarCodeGridView.FocusedRowHandle
                                                End If
                                            End If
                                        End If

                                        If Equals(Me.BarCodeGridView.FocusedColumn.FieldName, "UomDesc") Then
                                            If currentrow Is Nothing Then
                                                Me.HelpGrid.Text = "UomDesc"
                                                Me.txtSearchBox.Text = Me.txtSearchBox.Text & WindowsFormsApplication1.ProjectFunctions.ValidateKeysForSearchBox(e)
                                                Me.panelControl2.Visible = True
                                                Me.panelControl2.Select()
                                                Me.txtSearchBox.Focus()
                                                Me.txtSearchBox.SelectionStart = Me.txtSearchBox.Text.Length
                                                Me.txtSearchBox.SelectionLength = 0
                                            Else
                                                Dim dsCheck As DataSet = WindowsFormsApplication1.ProjectFunctions.GetDataSet("Select * from UomMst where UomCode='" & WindowsFormsApplication1.ProjectFunctions.CheckNull(currentrow("UomCode").ToString()) & "'")

                                                If dsCheck.Tables(0).Rows.Count > 0 Then
                                                    UpdateTag = "Y"
                                                    Me.HelpGrid.Text = "UomDesc"
                                                    Me.txtSearchBox.Text = Me.txtSearchBox.Text & WindowsFormsApplication1.ProjectFunctions.ValidateKeysForSearchBox(e)
                                                    Me.panelControl2.Visible = True
                                                    Me.panelControl2.Select()
                                                    Me.txtSearchBox.Focus()
                                                    Me.txtSearchBox.SelectionStart = Me.txtSearchBox.Text.Length
                                                    Me.txtSearchBox.SelectionLength = 0
                                                    RowIndex = Me.BarCodeGridView.FocusedRowHandle
                                                Else
                                                    Me.HelpGrid.Text = "UomDesc"
                                                    Me.txtSearchBox.Text = Me.txtSearchBox.Text & WindowsFormsApplication1.ProjectFunctions.ValidateKeysForSearchBox(e)
                                                    Me.panelControl2.Visible = True
                                                    Me.panelControl2.Select()
                                                    Me.txtSearchBox.Focus()
                                                    Me.txtSearchBox.SelectionStart = Me.txtSearchBox.Text.Length
                                                    Me.txtSearchBox.SelectionLength = 0
                                                    RowIndex = Me.BarCodeGridView.FocusedRowHandle
                                                End If
                                            End If
                                        End If

                                        If Equals(Me.BarCodeGridView.FocusedColumn.FieldName, "ProcessName") Then
                                            If currentrow Is Nothing Then
                                                Me.HelpGrid.Text = "ProcessName"
                                                Me.txtSearchBox.Text = Me.txtSearchBox.Text & WindowsFormsApplication1.ProjectFunctions.ValidateKeysForSearchBox(e)
                                                Me.panelControl2.Visible = True
                                                Me.panelControl2.Select()
                                                Me.txtSearchBox.Focus()
                                                Me.txtSearchBox.SelectionStart = Me.txtSearchBox.Text.Length
                                                Me.txtSearchBox.SelectionLength = 0
                                            Else
                                                Dim dsCheck As DataSet = WindowsFormsApplication1.ProjectFunctions.GetDataSet("Select * from ProcessMst where ProcessCode='" & WindowsFormsApplication1.ProjectFunctions.CheckNull(currentrow("ProcessCode").ToString()) & "'")

                                                If dsCheck.Tables(0).Rows.Count > 0 Then
                                                    UpdateTag = "Y"
                                                    Me.HelpGrid.Text = "ProcessName"
                                                    Me.txtSearchBox.Text = Me.txtSearchBox.Text & WindowsFormsApplication1.ProjectFunctions.ValidateKeysForSearchBox(e)
                                                    Me.panelControl2.Visible = True
                                                    Me.panelControl2.Select()
                                                    Me.txtSearchBox.Focus()
                                                    Me.txtSearchBox.SelectionStart = Me.txtSearchBox.Text.Length
                                                    Me.txtSearchBox.SelectionLength = 0
                                                    RowIndex = Me.BarCodeGridView.FocusedRowHandle
                                                Else
                                                    Me.HelpGrid.Text = "ProcessName"
                                                    Me.txtSearchBox.Text = Me.txtSearchBox.Text & WindowsFormsApplication1.ProjectFunctions.ValidateKeysForSearchBox(e)
                                                    Me.panelControl2.Visible = True
                                                    Me.panelControl2.Select()
                                                    Me.txtSearchBox.Focus()
                                                    Me.txtSearchBox.SelectionStart = Me.txtSearchBox.Text.Length
                                                    Me.txtSearchBox.SelectionLength = 0
                                                    RowIndex = Me.BarCodeGridView.FocusedRowHandle
                                                End If
                                            End If
                                        End If

                                        dt.AcceptChanges()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If

                WindowsFormsApplication1.ProjectFunctions.DeleteCurrentRowOnKeyDown(Me.BarCodeGrid, Me.BarCodeGridView, e)

                If Equals(Me.BarCodeGridView.FocusedColumn.FieldName, "ReceivedQty") OrElse Equals(Me.BarCodeGridView.FocusedColumn.FieldName, "ReceivedQtyInKgs") OrElse Equals(Me.BarCodeGridView.FocusedColumn.FieldName, "WastageQty") OrElse Equals(Me.BarCodeGridView.FocusedColumn.FieldName, "WastageQtyInKgs") OrElse Equals(Me.BarCodeGridView.FocusedColumn.FieldName, "Rate") OrElse Equals(Me.BarCodeGridView.FocusedColumn.FieldName, "CalculationType") Then
                    Me.BarCodeGridView.ShowEditor()
                End If

            Catch ex As Exception
                WindowsFormsApplication1.ProjectFunctions.SpeakError(ex.Message)
            End Try
        End Sub

        Private Sub TxtSearchBox_EditValueChanged(ByVal sender As Object, ByVal e As EventArgs)
            Try
                Me.HelpGrid.Show()

                If Equals(Me.HelpGrid.Text, "txtTransporterCode") Then
                    Dim dtNew As DataTable = dsPopUps.Tables(7).Clone()
                    Dim dtRow = dsPopUps.Tables(CInt(7)).Select("TRPRNAME like '" & Me.txtSearchBox.Text & "%'")

                    For Each dr In dtRow
                        Dim NewRow As DataRow = dtNew.NewRow()
                        NewRow("TRPRSYSID") = dr("TRPRSYSID")
                        NewRow("TRPRNAME") = dr("TRPRNAME")
                        dtNew.Rows.Add(NewRow)
                    Next

                    If dtNew.Rows.Count > 0 Then
                        Me.HelpGrid.DataSource = dtNew
                        Me.HelpGridView.BestFitColumns()
                    Else
                        Me.HelpGrid.DataSource = Nothing
                        Me.HelpGridView.BestFitColumns()
                    End If
                End If

                If Equals(Me.HelpGrid.Text, "txtDebitPartyCode") Then
                    Dim dtNew As DataTable = dsPopUps.Tables(6).Clone()
                    Dim dtRow = dsPopUps.Tables(CInt(6)).Select("AccName like '" & Me.txtSearchBox.Text & "%'")

                    For Each dr In dtRow
                        Dim NewRow As DataRow = dtNew.NewRow()
                        NewRow("AccCode") = dr("AccCode")
                        NewRow("AccName") = dr("AccName")
                        NewRow("AccAddress1") = dr("AccAddress1")
                        NewRow("AccAddress2") = dr("AccAddress2")
                        NewRow("AccAddress3") = dr("AccAddress3")
                        NewRow("CTNAME") = dr("CTNAME")
                        NewRow("STNAME") = dr("STNAME")
                        NewRow("AccZipCode") = dr("AccZipCode")
                        NewRow("AccTeleFax") = dr("AccTeleFax")
                        dtNew.Rows.Add(NewRow)
                    Next

                    If dtNew.Rows.Count > 0 Then
                        Me.HelpGrid.DataSource = dtNew
                        Me.HelpGridView.BestFitColumns()
                    Else
                        Me.HelpGrid.DataSource = Nothing
                        Me.HelpGridView.BestFitColumns()
                    End If
                End If

                If Equals(Me.HelpGrid.Text, "UomDesc") Then
                    Dim dtNew As DataTable = dsPopUps.Tables(5).Clone()
                    Dim dtRow = dsPopUps.Tables(CInt(5)).Select("UomDesc like '" & Me.txtSearchBox.Text & "%'")

                    For Each dr In dtRow
                        Dim NewRow As DataRow = dtNew.NewRow()
                        NewRow("UomCode") = dr("UomCode")
                        NewRow("UomDesc") = dr("UomDesc")
                        dtNew.Rows.Add(NewRow)
                    Next

                    If dtNew.Rows.Count > 0 Then
                        Me.HelpGrid.DataSource = dtNew
                        Me.HelpGridView.BestFitColumns()
                    Else
                        Me.HelpGrid.DataSource = Nothing
                        Me.HelpGridView.BestFitColumns()
                    End If
                End If

                If Equals(Me.HelpGrid.Text, "ProcessName") Then
                    Dim dtNew As DataTable = dsPopUps.Tables(4).Clone()
                    Dim dtRow = dsPopUps.Tables(CInt(4)).Select("ProcessName like '" & Me.txtSearchBox.Text & "%'")

                    For Each dr In dtRow
                        Dim NewRow As DataRow = dtNew.NewRow()
                        NewRow("ProcessCode") = dr("ProcessCode")
                        NewRow("ProcessName") = dr("ProcessName")
                        NewRow("Rate") = dr("Rate")
                        dtNew.Rows.Add(NewRow)
                    Next

                    If dtNew.Rows.Count > 0 Then
                        Me.HelpGrid.DataSource = dtNew
                        Me.HelpGridView.BestFitColumns()
                    Else
                        Me.HelpGrid.DataSource = Nothing
                        Me.HelpGridView.BestFitColumns()
                    End If
                End If

                If Equals(Me.HelpGrid.Text, "PrdName") Then
                    Dim dtNew As DataTable = dsPopUps.Tables(3).Clone()
                    Dim dtRow = dsPopUps.Tables(CInt(3)).Select("PrdName like '" & Me.txtSearchBox.Text & "%'")

                    For Each dr In dtRow
                        Dim NewRow As DataRow = dtNew.NewRow()
                        NewRow("PrdCode") = dr("PrdCode")
                        NewRow("PrdName") = dr("PrdName")
                        dtNew.Rows.Add(NewRow)
                    Next

                    If dtNew.Rows.Count > 0 Then
                        Me.HelpGrid.DataSource = dtNew
                        Me.HelpGridView.BestFitColumns()
                    Else
                        Me.HelpGrid.DataSource = Nothing
                        Me.HelpGridView.BestFitColumns()
                    End If
                End If

                If Equals(Me.HelpGrid.Text, "ARTNO") Then
                    Dim dtNew As DataTable = dsPopUps.Tables(0).Clone()
                    Dim dtRow = dsPopUps.Tables(CInt(0)).Select("ARTNO like '" & Me.txtSearchBox.Text & "%'")

                    For Each dr In dtRow
                        Dim NewRow As DataRow = dtNew.NewRow()
                        NewRow("ARTNO") = dr("ARTNO")
                        NewRow("ARTDESC") = dr("ARTDESC")
                        NewRow("ARTMRP") = dr("ARTMRP")
                        NewRow("ARTWSP") = dr("ARTWSP")
                        NewRow("ARTSYSID") = dr("ARTSYSID")
                        dtNew.Rows.Add(NewRow)
                    Next

                    If dtNew.Rows.Count > 0 Then
                        Me.HelpGrid.DataSource = dtNew
                        Me.HelpGridView.BestFitColumns()
                    Else
                        Me.HelpGrid.DataSource = Nothing
                        Me.HelpGridView.BestFitColumns()
                    End If
                End If

            Catch __unusedException1__ As Exception
            End Try
        End Sub

        Private Sub GroupControl1_Paint(ByVal sender As Object, ByVal e As PaintEventArgs)
        End Sub

        Private Sub ChallanGrid_DoubleClick(ByVal sender As Object, ByVal e As EventArgs)
            GetOurwardDataFProcess()
        End Sub

        Private Sub BarCodeGridView_CellValueChanged(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs)
            Try

                If Me.BarCodeGrid.DataSource IsNot Nothing Then
                    If Equals(e.Column.FieldName, "ReceivedQty") OrElse Equals(e.Column.FieldName, "ReceivedQtyInKgs") OrElse Equals(e.Column.FieldName, "WastageQty") OrElse Equals(e.Column.FieldName, "WastageQtyInKgs") OrElse Equals(e.Column.FieldName, "Rate") Then
                        Me.BarCodeGridView.CloseEditor()
                        Me.BarCodeGridView.UpdateCurrentRow()
                        Dim row As DataRow = Me.BarCodeGridView.GetDataRow(Me.BarCodeGridView.FocusedRowHandle)
                        Me.BarCodeGridView.SetRowCellValue(Me.BarCodeGridView.FocusedRowHandle, Me.BarCodeGridView.Columns("ActualQty"), Convert.ToDecimal(row("ReceivedQty")) - Convert.ToDecimal(row("WastageQty")))
                        Me.BarCodeGridView.SetRowCellValue(Me.BarCodeGridView.FocusedRowHandle, Me.BarCodeGridView.Columns("ActualQtyInKgs"), Convert.ToDecimal(row("ReceivedQtyInKgs")) - Convert.ToDecimal(row("WastageQtyInKgs")))

                        If Equals(row("CalculationType").ToString().ToUpper(), "D") Then
                            Me.BarCodeGridView.SetRowCellValue(Me.BarCodeGridView.FocusedRowHandle, Me.BarCodeGridView.Columns("CalcAmount"), Convert.ToDecimal(row("ActualQty")) * (Convert.ToDecimal(row("Rate")) / 12))
                        Else

                            If Equals(row("CalculationType").ToString().ToUpper(), "PCS") Then
                                Me.BarCodeGridView.SetRowCellValue(Me.BarCodeGridView.FocusedRowHandle, Me.BarCodeGridView.Columns("CalcAmount"), Convert.ToDecimal(row("ActualQty")) * Convert.ToDecimal(row("Rate")))
                            Else
                                Me.BarCodeGridView.SetRowCellValue(Me.BarCodeGridView.FocusedRowHandle, Me.BarCodeGridView.Columns("CalcAmount"), Convert.ToDecimal(row("ActualQtyInKgs")) * Convert.ToDecimal(row("Rate")))
                            End If
                        End If

                        If Convert.ToDecimal(row("ActualQty")) > Convert.ToDecimal(row("Bal")) Then
                            WindowsFormsApplication1.ProjectFunctions.SpeakError("Actual Quantity Cannot Be Greater Than Issued Quantity")
                        End If
                    End If
                End If

            Catch ex As Exception
                WindowsFormsApplication1.ProjectFunctions.SpeakError(ex.Message)
            End Try
        End Sub

        Private Sub BtnQuit_Click(ByVal sender As Object, ByVal e As EventArgs)
            Close()
        End Sub

        Private Function ValidateDataForSaving() As Boolean
            Return True
        End Function

        Private Sub BtnSave_Click(ByVal sender As Object, ByVal e As EventArgs)
            Try
                dt.AcceptChanges()

                If ValidateDataForSaving() Then
                    Using sqlcon = New SqlConnection(WindowsFormsApplication1.ProjectFunctions.GetConnection())
                        sqlcon.Open()
                        Dim sqlcom = sqlcon.CreateCommand()
                        sqlcom.Connection = sqlcon
                        sqlcom.CommandType = CommandType.StoredProcedure
                        sqlcom.CommandType = CommandType.Text

                        If Equals(S1, "&Add") Then
                            Me.txtTransNo.Text = WindowsFormsApplication1.ProjectFunctions.GetDataSet(CStr("Select isnull(Max(CHINO),0)+1 from CHINMain WHere CHIFYR='" & WindowsFormsApplication1.GlobalVariables.FinancialYear & "' ANd UnitCode='" & WindowsFormsApplication1.GlobalVariables.CUnitID & "'")).Tables(0).Rows(0)(0).ToString()
                            sqlcom.CommandText = " Insert into CHINMain " & " (DocNo,DocDate,CHIReceiveDate,CHIGateEntryNo,CHIFYR,CHINO,CHITYPE,CHIDATE,CHIPARTYCODE,CHOREMARKS,UnitCode,CHOTRPID)values(" & " @DocNo,@DocDate,@CHIReceiveDate,@CHIGateEntryNo,@CHIFYR,@CHINO,@CHITYPE,@CHIDATE,@CHIPARTYCODE,@CHOREMARKS,@UnitCode,@CHOTRPID)"
                            sqlcom.Parameters.Add("@DocNo", SqlDbType.NVarChar).Value = Me.txtDocNo.Text
                            sqlcom.Parameters.Add("@DocDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(CStr(Me.txtDocDate.Text)).ToString("yyyy-MM-dd")
                            sqlcom.Parameters.Add("@CHIReceiveDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(CStr(Me.txtReceivingDate.Text)).ToString("yyyy-MM-dd")
                            sqlcom.Parameters.Add("@CHIGateEntryNo", SqlDbType.NVarChar).Value = Me.txtGateEntryNo.Text
                            sqlcom.Parameters.Add("@CHIFYR", SqlDbType.NVarChar).Value = WindowsFormsApplication1.GlobalVariables.FinancialYear
                            sqlcom.Parameters.Add("@CHINO", SqlDbType.NVarChar).Value = Me.txtTransNo.Text
                            sqlcom.Parameters.Add("@CHITYPE", SqlDbType.NVarChar).Value = Me.txtDocType.Text
                            sqlcom.Parameters.Add("@CHIDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(CStr(Me.txtTransDate.Text)).ToString("yyyy-MM-dd")
                            sqlcom.Parameters.Add("@CHIPARTYCODE", SqlDbType.NVarChar).Value = Me.txtDebitPartyCode.Text
                            sqlcom.Parameters.Add("@CHOREMARKS", SqlDbType.NVarChar).Value = Me.txtRemarks.Text
                            sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = WindowsFormsApplication1.GlobalVariables.CUnitID
                            sqlcom.Parameters.Add("@CHOTRPID", SqlDbType.NVarChar).Value = Me.txtTransporterCode.Text
                            sqlcom.ExecuteNonQuery()
                            sqlcom.Parameters.Clear()
                        End If

                        If Equals(S1, "Edit") Then
                            sqlcom.CommandText = " update CHINMain Set  " & "DocNo=@DocNo,DocDate=@DocDate,CHIReceiveDate=@CHIReceiveDate,CHIGateEntryNo=@CHIGateEntryNo,CHIPARTYCODE=@CHIPARTYCODE,CHOREMARKS=@CHOREMARKS,CHOTRPID=@CHOTRPID " & " where CHINO='" & Me.txtTransNo.Text & "' And CHIDATE='" & Convert.ToDateTime(CStr(Me.txtTransDate.Text)).ToString("yyyy-MM-dd") & "' And UnitCode='" & WindowsFormsApplication1.GlobalVariables.CUnitID & "'"
                            sqlcom.Parameters.Add("@DocNo", SqlDbType.NVarChar).Value = Me.txtDocNo.Text
                            sqlcom.Parameters.Add("@DocDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(CStr(Me.txtDocDate.Text)).ToString("yyyy-MM-dd")
                            sqlcom.Parameters.Add("@CHIReceiveDate", SqlDbType.NVarChar).Value = Convert.ToDateTime(CStr(Me.txtReceivingDate.Text)).ToString("yyyy-MM-dd")
                            sqlcom.Parameters.Add("@CHIGateEntryNo", SqlDbType.NVarChar).Value = Me.txtGateEntryNo.Text
                            sqlcom.Parameters.Add("@CHIFYR", SqlDbType.NVarChar).Value = WindowsFormsApplication1.GlobalVariables.FinancialYear
                            sqlcom.Parameters.Add("@CHINO", SqlDbType.NVarChar).Value = Me.txtTransNo.Text
                            sqlcom.Parameters.Add("@CHITYPE", SqlDbType.NVarChar).Value = Me.txtDocType.Text
                            sqlcom.Parameters.Add("@CHIDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(CStr(Me.txtTransDate.Text)).ToString("yyyy-MM-dd")
                            sqlcom.Parameters.Add("@CHIPARTYCODE", SqlDbType.NVarChar).Value = Me.txtDebitPartyCode.Text
                            sqlcom.Parameters.Add("@CHOREMARKS", SqlDbType.NVarChar).Value = Me.txtRemarks.Text
                            sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = WindowsFormsApplication1.GlobalVariables.CUnitID
                            sqlcom.Parameters.Add("@CHOTRPID", SqlDbType.NVarChar).Value = Me.txtTransporterCode.Text
                            sqlcom.ExecuteNonQuery()
                            sqlcom.Parameters.Clear()
                            WindowsFormsApplication1.ProjectFunctions.GetDataSet("Delete from CHINData Where CHINO='" & Me.txtTransNo.Text & "' And CHIDATE='" & Convert.ToDateTime(CStr(Me.txtTransDate.Text)).ToString("yyyy-MM-dd") & "' And UnitCode='" & WindowsFormsApplication1.GlobalVariables.CUnitID & "'")
                        End If

                        For Each dr As DataRow In dt.Rows

                            If Convert.ToDecimal(dr("ReceivedQty")) > 0 OrElse Convert.ToDecimal(dr("ReceivedQtyInKgs")) > 0 Then
                                sqlcom.CommandText = " Insert into CHINData " & " (CHIFYR,CHINO,CHITYPE,CHIDATE,AgnstChallanType,AgnstChallanNo,PrdCode," & " ARTID,UomCode,ReceivedQty,ReceivedQtyInKgs,WastageQty,WastageQtyInKgs,ProcessCode,Rate," & " CalculationType,CalcAmount,Remarks,ActualQty,ActualQtyInKgs,UnitCode,CHOUTTransID)" & " values(@CHIFYR,@CHINO,@CHITYPE,@CHIDATE,@AgnstChallanType,@AgnstChallanNo,@PrdCode," & " @ARTID,@UomCode,@ReceivedQty,@ReceivedQtyInKgs,@WastageQty,@WastageQtyInKgs,@ProcessCode,@Rate," & " @CalculationType,@CalcAmount,@Remarks,@ActualQty,@ActualQtyInKgs,@UnitCode,@CHOUTTransID)"
                                sqlcom.Parameters.Add("@CHIFYR", SqlDbType.NVarChar).Value = WindowsFormsApplication1.GlobalVariables.FinancialYear
                                sqlcom.Parameters.Add("@CHINO", SqlDbType.NVarChar).Value = Me.txtTransNo.Text
                                sqlcom.Parameters.Add("@CHITYPE", SqlDbType.NVarChar).Value = Me.txtDocType.Text
                                sqlcom.Parameters.Add("@CHIDATE", SqlDbType.NVarChar).Value = Convert.ToDateTime(CStr(Me.txtTransDate.Text)).ToString("yyyy-MM-dd")
                                sqlcom.Parameters.Add("@AgnstChallanType", SqlDbType.NVarChar).Value = dr("AgnstChallanType").ToString()
                                sqlcom.Parameters.Add("@AgnstChallanNo", SqlDbType.NVarChar).Value = dr("AgnstChallanNo").ToString()
                                sqlcom.Parameters.Add("@PrdCode", SqlDbType.NVarChar).Value = dr("PrdCode").ToString()
                                sqlcom.Parameters.Add("@ARTID", SqlDbType.NVarChar).Value = dr("ARTID").ToString()
                                sqlcom.Parameters.Add("@UomCode", SqlDbType.NVarChar).Value = dr("UomCode").ToString()
                                sqlcom.Parameters.Add("@ReceivedQty", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr("ReceivedQty"))
                                sqlcom.Parameters.Add("@ReceivedQtyInKgs", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr("ReceivedQtyInKgs"))
                                sqlcom.Parameters.Add("@WastageQty", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr("WastageQty"))
                                sqlcom.Parameters.Add("@WastageQtyInKgs", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr("WastageQtyInKgs"))
                                sqlcom.Parameters.Add("@ProcessCode", SqlDbType.NVarChar).Value = dr("Rate").ToString()
                                sqlcom.Parameters.Add("@Rate", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr("ReceivedQty"))
                                sqlcom.Parameters.Add("@CalculationType", SqlDbType.NVarChar).Value = dr("CalculationType").ToString()
                                sqlcom.Parameters.Add("@CalcAmount", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr("CalcAmount"))
                                sqlcom.Parameters.Add("@Remarks", SqlDbType.NVarChar).Value = dr("Remarks").ToString()
                                sqlcom.Parameters.Add("@ActualQty", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr("ActualQty"))
                                sqlcom.Parameters.Add("@ActualQtyInKgs", SqlDbType.NVarChar).Value = Convert.ToDecimal(dr("ActualQtyInKgs"))
                                sqlcom.Parameters.Add("@UnitCode", SqlDbType.NVarChar).Value = WindowsFormsApplication1.GlobalVariables.CUnitID
                                sqlcom.Parameters.Add("@CHOUTTransID", SqlDbType.NVarChar).Value = dr("TransID").ToString()
                                sqlcom.ExecuteNonQuery()
                                sqlcom.Parameters.Clear()
                            End If
                        Next

                        WindowsFormsApplication1.ProjectFunctions.SpeakError(" Data Saved Successfully")
                        sqlcon.Close()
                        Close()
                    End Using
                End If

            Catch ex As Exception
                WindowsFormsApplication1.ProjectFunctions.SpeakError(ex.Message)
            End Try
        End Sub
    End Class
End Namespace
