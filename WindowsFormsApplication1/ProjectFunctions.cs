﻿using DevExpress.Utils.Menu;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Menu;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraReports.UI;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using SeqKartLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;

using System.Net;
using System.Net.Http;
using System.Speech.Synthesis;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaxProEWB.API;

namespace WindowsFormsApplication1
{

    class ProjectFunctions
    {

        public static SpeechSynthesizer _synthesizer = new SpeechSynthesizer();
        // public static String ImageConnectionString = "Data Source = seqkart.ddns.net; Initial Catalog = EFileSeqKart; User ID = sa; pwd=Seq@2021";


        public static string ConnectionString = ProjectFunctionsUtils.ConnectionString;
        public static string ImageConnectionString = ProjectFunctionsUtils.ImageConnectionString;
        ////@"Data Source=cserver;Initial Catalog=SEQKART;User ID=sa;pwd=Seq@2021";


        //public static void SendSMS(string uid, string password, string message, string no)
        //{
        //    HttpWebRequest myReq = (HttpWebRequest)WebRequest.Create("http://ubaid.tk/sms/sms.aspx?uid=" + uid + "&pwd=" + password + "&msg=" + message + "&phone=" + no + "&provider=way2sms");
        //    myReq.Credentials = CredentialCache.DefaultNetworkCredentials;
        //    HttpWebResponse myResp = (HttpWebResponse)myReq.GetResponse();
        //    System.IO.StreamReader respStreamReader = new System.IO.StreamReader(myResp.GetResponseStream());
        //    string responseString = respStreamReader.ReadToEnd();
        //    respStreamReader.Close();
        //    myResp.Close();
        //}
        //public static GsmCommMain comm;
        //public static SmsServer;
        //public static void ConnectModem()
        //{
        //    comm = new GsmCommMain(GlobalVariables.PortNo, 9600, 150);
        //    Cursor.Current = Cursors.Default;
        //    bool retry;
        //    do
        //    {
        //        retry = false;
        //        try
        //        {
        //            Cursor.Current = Cursors.WaitCursor;
        //            comm.Open();
        //            Cursor.Current = Cursors.Default;

        //        }
        //        catch (Exception ex)
        //        {
        //            ProjectFunctions.SpeakError(ex.Message);
        //            comm.Close();
        //        }
        //    }
        //    while (retry);

        //}
        public static DialogResult SpeakConfirmation(string message, string caption, MessageBoxButtons messageBoxButtons)
        {

            Task.Run(() => _synthesizer.Speak(message));

            return XtraMessageBox.Show(message, caption, messageBoxButtons);

        }
        public static void SpeakError(string Error)
        {

            Task.Run(() => _synthesizer.Speak(Error));

            XtraMessageBox.Show(Error);

        }

        public static void Speak(string MSG)
        {

            Task.Run(() => _synthesizer.Speak(MSG));

        }




        public static string CheckNull(string Value)
        {
            if (Value.Trim().Length == 0)
            {
                Value = "0";
            }
            return Value;
        }
        public static DataTable GetDataTable(string Query, bool flag = true)
        {
            try
            {
                var dt = new DataTable();
                var _VarSqlConnection = new SqlConnection(ProjectFunctions.ConnectionString);
                try
                {
                    _VarSqlConnection.Open();
                    var cmd = new SqlCommand(Query, _VarSqlConnection) { CommandTimeout = 600 };
                    dt.Load(cmd.ExecuteReader());
                    return dt;
                }
                finally
                {
                    if (_VarSqlConnection != null)
                    {
                        _VarSqlConnection.Dispose();
                        dt.Dispose();
                    }
                }
            }
            catch (Exception ex)
            {
                if (flag)
                {
                    MessageBox.Show("Unable To Fetch Data.\n" + ex.Message);
                }
                return null;
            }
        }
        public static bool CheckRange(DateTime dateToCheck, DateTime startDate, DateTime endDate)
        {
            return dateToCheck.Date >= startDate.Date && dateToCheck.Date <= endDate.Date;
        }

        internal static void CreatePopUpForFourBoxes(string v1, string v2, TextEdit txtCityCode, TextEdit txtCityName, TextEdit txtState, GridControl helpGrid, GridView helpGridView, KeyEventArgs e)
        {
            throw new NotImplementedException();
        }

        //public static void SendSMS(String sms,String MobileNo)
        //{
        //    try
        //    {

        //        SmsSubmitPdu pdu;
        //        byte dcs = (byte)DataCodingScheme.GeneralCoding.Alpha7BitDefault;
        //        pdu = new SmsSubmitPdu(sms, MobileNo, "");

        //        comm.SendMessage(pdu);
        //        comm.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        ProjectFunctions.SpeakError(ex.Message);
        //        comm.Close();
        //    }
        //}

        public static string GetConnection()
        {



            return ConnectionString;

        }
        public static void NumberOnly(KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) != true && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        public static void NumericWithDecimal(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back);
        }
        public static decimal NetRateCalculation(decimal TAXRATE, decimal SURCHARGERATE, decimal RATE)
        {
            var netrate = Math.Round((Convert.ToDecimal(RATE) * 100) / (100 + Convert.ToDecimal(TAXRATE) + (Convert.ToDecimal(TAXRATE) * Convert.ToDecimal(SURCHARGERATE)) / 100), 2);
            return netrate;
        }
        public static string ClipFYearN(string finyear)
        {
            return (finyear.Substring(2, 2) + finyear.Substring(7, 2));
        }

        public static void SalePopUPForAllWindows(XtraForm frmUpper, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Escape)
            //{
            //    frmUpper.Close();
            //}
            if (e.KeyCode == Keys.F2)
            {
                frmSaleReportF2 frm = new frmSaleReportF2() { Text = "Sale Report", WorkingTag = "Today" };
                var P = ProjectFunctions.GetPositionInForm(frmUpper);
                frm.Location = new Point(P.X + (frmUpper.ClientSize.Width / 2 - frm.Size.Width / 2), P.Y + (frmUpper.Height / 2 - frm.Size.Height / 2));
                frm.ShowDialog(frmUpper.Parent);
            }
            if (e.KeyCode == Keys.F4)
            {
                frmSaleReportF2 frm = new frmSaleReportF2() { Text = "Sale Report", WorkingTag = "Month" };
                var P = ProjectFunctions.GetPositionInForm(frmUpper);
                frm.Location = new Point(P.X + (frmUpper.Width / 2 - frm.Size.Width / 2), P.Y + (frmUpper.Height / 2 - frm.Size.Height / 2));
                frm.ShowDialog(frmUpper.Parent);
            }
            if (e.KeyCode == Keys.F6)
            {
                frmSaleReportF2 frm = new frmSaleReportF2() { Text = "Sale Report", WorkingTag = "Year" };
                var P = ProjectFunctions.GetPositionInForm(frmUpper);
                frm.Location = new Point(P.X + (frmUpper.Width / 2 - frm.Size.Width / 2), P.Y + (frmUpper.Height / 2 - frm.Size.Height / 2));
                frm.ShowDialog(frmUpper.Parent);
            }
        }
        public static string ClipFYearBarCode(string finyear)
        {
            return (finyear.Substring(2, 2));
        }

        public static Tuple<decimal, decimal, decimal, decimal> TaxCalculationData(decimal CGSTRate, decimal SGSTRate, decimal IGSTRate, decimal RATE, decimal RDC, decimal Quantity)
        {
            var disc = Convert.ToDecimal(RDC); ;
            var AmountATRDC = Math.Round((Quantity * RATE * disc) / 100, 2);
            AmountATRDC = (Quantity * RATE) - AmountATRDC;
            var taxableamount = AmountATRDC;
            var CGST = Math.Round((taxableamount * CGSTRate / 100), 2);
            var SGST = Math.Round((taxableamount * SGSTRate / 100), 2);
            var IGST = Math.Round((taxableamount * IGSTRate / 100), 2);
            var RESULT = Tuple.Create(taxableamount, CGST, SGST, IGST);
            return (RESULT);
        }

        public static Tuple<decimal, decimal, decimal, decimal> ReplacementTaxCalculatioData(decimal TAXRATE, decimal SURCHARGERATE, decimal QUANTITY, decimal RATE, decimal RDC, decimal REPL, decimal WSB, decimal ForQuantity, decimal freeQuantity, decimal free)
        {
            decimal s7, s2, s3, s4, s5, s6, s8, s9, s10, taxableamount, NetRateR;
            s7 = Convert.ToDecimal(RATE);
            s2 = Convert.ToDecimal(REPL);
            s3 = Convert.ToDecimal(RDC);
            s4 = Convert.ToDecimal(WSB);
            s5 = Convert.ToDecimal(ForQuantity) + Convert.ToDecimal(freeQuantity);
            s6 = Convert.ToDecimal(ForQuantity);
            s7 = (s7 - (s7 * s2 / 100));
            s8 = (s7 - (s7 * s3 / 100));
            s9 = (s8 - (s8 * s4 / 100));
            if (Convert.ToInt32(ForQuantity) == 0)
            {
                s10 = s9;
            }
            else
            {
                s10 = (s9 * (s6 / s5));
            }
            NetRateR = Math.Round(s10, 2);
            taxableamount = Math.Round(s10, 2) * Convert.ToDecimal(QUANTITY);
            var taxamount = Math.Round((taxableamount * TAXRATE / 100), 2);
            var surchargeamount = Math.Round((taxamount * SURCHARGERATE / 100), 2);
            var RESULT = Tuple.Create(taxableamount, taxamount, surchargeamount, NetRateR);
            return (RESULT);

        }
        public static void TextOnly(KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        public static DataSet GetDataSet(string Query)
        {
            using (var _VarDataSet = new DataSet())
            {
                try
                {
                    using (var _VarSqlDataAdapter = new SqlDataAdapter(Query, new SqlConnection(GetConnection())))
                    {
                        _VarSqlDataAdapter.SelectCommand.CommandTimeout = 1200;
                        _VarSqlDataAdapter.Fill(_VarDataSet);
                    }
                    return _VarDataSet;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("ProjectFunction => GetDataSet => " + Query);
                    System.Diagnostics.Debug.WriteLine("ProjectFunction => GetDataSet => " + ex);
                    return null;
                }
            }
        }


        public static DataSet GetDataSet(string Query, string ConnectionString)
        {
            using (var _VarDataSet = new DataSet())
            {
                try
                {
                    using (var _VarSqlDataAdapter = new SqlDataAdapter(Query, new SqlConnection(ConnectionString)))
                    {
                        _VarSqlDataAdapter.SelectCommand.CommandTimeout = 1200;
                        _VarSqlDataAdapter.Fill(_VarDataSet);
                    }
                    return _VarDataSet;
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.WriteLine("ProjectFunction => GetDataSet => " + Query);
                    System.Diagnostics.Debug.WriteLine("ProjectFunction => GetDataSet => " + ex);
                    return null;
                }
            }
        }
        public static void DeleteCurrentRowOnKeyDown(DevExpress.XtraGrid.GridControl ReportGrid, DevExpress.XtraGrid.Views.Grid.GridView ReportGridView, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.T)
            {
                ReportGridView.DeleteRow(ReportGridView.FocusedRowHandle);
            }
        }
        public static void DeleteCurrentRowOnRightClick(DevExpress.XtraGrid.GridControl ReportGrid, DevExpress.XtraGrid.Views.Grid.GridView ReportGridView)
        {
            ReportGridView.DeleteRow(ReportGridView.FocusedRowHandle);
        }
        public static string SqlString(string Text)
        {
            return string.Concat(Text.Select(c => @"'()%#!<>{};:?/\-[]+@".IndexOf(c) >= 0 ? '_' : c));
        }
        public static void GroupCtrlVisualize(GroupControl C)
        {
            C.AppearanceCaption.Font = new Font("Tahoma", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            C.AppearanceCaption.ForeColor = Color.Gray;
            C.AppearanceCaption.Options.UseFont = true;
            C.AppearanceCaption.Options.UseForeColor = true;
        }


        public static void SendMessage(string smsMessage, string SenderId, string MobileNos)
        {
            smsMessage.Replace('#', '_');

            //////////////-----   //http://msg.smscluster.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=YourAuthKey&message=message&senderId=dddddd&routeId=1&mobileNos=9999999999&smsContentType=english


            var uri = @"http://msg.smscluster.com/rest/services/sendSMS/sendGroupSms?AUTH_KEY=8ef012ac2bbcaaf804bd6e9c7a5712b&message=" + smsMessage + "&senderId=" + SenderId + "&routeId=1&mobileNos=" + MobileNos + "&smsContentType=english";

            var request = HttpWebRequest.Create(uri) as HttpWebRequest;
            try
            {
                //request.Method = "GET";
                //if (request.Method == "GET")
                //{
                //    var response = (HttpWebResponse)request.GetResponse();
                //    var receiveStream = response.GetResponseStream();

                //    var readStream = new StreamReader(receiveStream, Encoding.UTF8);
                //    if (readStream.ReadToEnd().ToString().Contains("3001"))
                //    {
                //        ProjectFunctions.SpeakError(smsMessage + "/ Message Send Successfully");

                //    }
                //    else
                //    {
                //ProjectFunctions.SpeakError(smsMessage + "/ Unable To Send Message");

                //    }
                //    response.Close();
                //    readStream.Close();
                //}

                ProjectFunctions.SpeakError("Unable To Send Message");
            }
            catch (Exception ex)
            {
                ProjectFunctions.SpeakError(ex.Message);
            }
            finally
            {
                request = null;
                GC.Collect();
            }
        }

#pragma warning disable S125 // Sections of code should not be commented out
        /*
                        public static void sendsmsviagatepass(String Message)
                        {
                            string serverURL1 = "167.114.117.218";//eg IP or Domain
                            string authkey1 = "d93f366bc185af6158755201ab143ab"; // "Sample Auth key" 'eg -- 16 digits alphanumeric;
                            string message1 = "Sample message"; //eg "message hello ";
                            string senderId1 = "testing";//eg -- TestinG 6 Alphabet'
                            string routeId1 = "1";// eg 1;
                            string mobileNos1 = "9855630394";//eg '99999999xx,99999998xx
                            string smsContentType1 = "english";//or Unicode
                            string groupId1 = "1";// eg 1

                            string scheduledate1 = string.Empty; //optional if(scheduledate  eg “26/08/2015 17:00”);
                            string signature1 = string.Empty; //optional if(signature available  eg “1”);
                            string groupName = string.Empty;//optional if(groupName available eg “1”);

                            Sendsms.HitApi hitAPI = new Sendsms.HitApi();
                            hitAPI.hitGetApi(serverURL1, authkey1, Message, senderId1, routeId1, mobileNos1, smsContentType1, groupId1, null, signature1, groupName);

                        }
                */
        public static DataSet GetMasterFormAdd()
#pragma warning restore S125 // Sections of code should not be commented out
        {
            DataSet dsMaster = GetDataSet("Select ProgCode,Mode,Caption,FormName from MasterAddEdit Where ProgCode='" + GlobalVariables.ProgCode + "' And Mode='ADD'");
            if (dsMaster.Tables[0].Rows.Count > 0)
            { return dsMaster; }
            return null;
        }
        public static DataSet GetMasterFormEdit()
        {
            DataSet dsMaster = GetDataSet("Select ProgCode,Mode,Caption,FormName from MasterAddEdit Where ProgCode='" + GlobalVariables.ProgCode + "' And Mode='EDIT'");
            if (dsMaster.Tables[0].Rows.Count > 0)
            { return dsMaster; }
            return null;
        }
        public static void SetMasterAddEditFromTextBoxLengths(string TableName, XtraForm FormName)
        {
            TextBoxVisualize(FormName);
            ButtonVisualize(FormName);
            DatePickerVisualize(FormName);

            DataSet dsMaster = GetDataSet("select column_name, data_type, character_maximum_length from information_schema.columns   where table_name = '" + TableName + "'");
            if (dsMaster.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in dsMaster.Tables[0].Rows)
                {
                    foreach (Control C in FormName.Controls)
                    {
                        if (C is TextEdit)
                        {
                            if (dr["column_name"].ToString().ToUpper() == C.Name.Replace("TextEdit", string.Empty).Trim().ToUpper())
                            {
                                (C as TextEdit).Properties.MaxLength = Convert.ToInt32(dr["character_maximum_length"]);
                            }
                        }
                    }
                }
            }
        }

        public static void SetMasterAddEditFromTextBoxValues(string ProcedureName, XtraForm FormName)
        {
            //DataSet dsMaster = GetDataSet(ProcedureName + " '" + GlobalVariables.MasterCode + "'");
            //if (dsMaster.Tables[0].Rows.Count > 0)
            //{
            //    foreach (DataColumn dr in dsMaster.Tables[0].Columns)
            //    {
            //        foreach (Control C in FormName.Controls)
            //        {
            //            if (C is TextEdit)
            //            {
            //                if (dr.ColumnName.ToUpper() == C.Name.Replace("TextEdit", "").Trim().ToUpper())
            //                {
            //                    (C as TextEdit).EditValue = dsMaster.Tables[0].Rows[0][dr.ColumnName];
            //                }
            //            }
            //        }
            //    }
            //}
        }




        public static bool ControlsToValidate(Control[] A)
        {
            foreach (Control a in A)
            {
                if (a is TextEdit)
                {
                    if ((a as TextEdit).EditValue.ToString().Trim().Length == 0)
                    {
                        ProjectFunctions.SpeakError("Invalid Value : " + a.Name);
                        return false;
                    }
                }
            }
            return true;
        }

        public static void SaveNewMasterRecord(string ProcedureName, XtraForm FormName)
        {
            DataSet dsMaster = GetDataSet("select PARAMETER_NAME from information_schema.parameters where specific_name='" + ProcedureName + "'");
            using (var sqlcon = new SqlConnection(GetConnection()))
            {
                sqlcon.Open();
                var sqlcom = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = ProcedureName,
                    Connection = sqlcon
                };
                if (dsMaster.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dr in dsMaster.Tables[0].Rows)
                    {
                        foreach (Control C in FormName.Controls)
                        {
                            if (dr["PARAMETER_NAME"].ToString().Replace("@", string.Empty).ToUpper() == C.Name.Replace("TextEdit", string.Empty).Trim().ToUpper())
                            {
                                sqlcom.Parameters.AddWithValue(dr["PARAMETER_NAME"].ToString(), (C as TextEdit).EditValue);
                            }
                        }
                    }
                    sqlcom.ExecuteNonQuery();
                    sqlcon.Close();
                }
            }
        }


        public static void SaveDataTable(string ProcedureName, DataTable dtFinal)
        {
            DataSet dsMaster = GetDataSet("select PARAMETER_NAME from information_schema.parameters where specific_name='" + ProcedureName + "'");
            using (var sqlcon = new SqlConnection(GetConnection()))
            {
                sqlcon.Open();
                var sqlcom = new SqlCommand
                {
                    Connection = sqlcon
                };
                if (dsMaster.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow dtOuter in dtFinal.Rows)
                    {
                        sqlcom.CommandType = CommandType.StoredProcedure;
                        sqlcom.CommandText = ProcedureName;
                        foreach (DataRow dr in dsMaster.Tables[0].Rows)
                        {
                            foreach (DataColumn C in dtFinal.Columns)
                            {
                                if (dr["PARAMETER_NAME"].ToString().Replace("@", string.Empty).ToUpper() == C.ColumnName.ToUpper())
                                {
                                    sqlcom.Parameters.AddWithValue(dr["PARAMETER_NAME"].ToString(), dr[C.ColumnName]);
                                }
                            }
                        }
                        sqlcom.ExecuteNonQuery();
                        sqlcom.Parameters.Clear();
                    }
                    sqlcon.Close();
                }
            }
        }


        public static string ValidateKeysForSearchBox(KeyEventArgs e)
        {
            string Value = string.Empty;
            switch (e.KeyCode)
            {
                case Keys.NumPad1:
                    Value = "1";
                    break;
                case Keys.NumPad2:
                    Value = "2";
                    break;
                case Keys.NumPad3:
                    Value = "3";
                    break;
                case Keys.NumPad4:
                    Value = "4";
                    break;
                case Keys.NumPad5:
                    Value = "5";
                    break;
                case Keys.NumPad6:
                    Value = "6";
                    break;
                case Keys.NumPad7:
                    Value = "7";
                    break;
                case Keys.NumPad8:
                    Value = "8";
                    break;
                case Keys.NumPad9:
                    Value = "9";
                    break;
                case Keys.NumPad0:
                    Value = "0";
                    break;

                default:
                    Value = ((char)e.KeyValue).ToString();
                    break;
            }
            return Value;
        }


        public static void ShowImage(string ArticleID, DevExpress.XtraEditors.PictureEdit PictureBox)
        {
            try
            {
                DataSet dsImage = ProjectFunctions.GetDataSet("Select ARTIMAGE from ARTICLE Where ARTSYSID='" + ArticleID + "'");
                if (dsImage.Tables[0].Rows[0]["ARTIMAGE"].ToString().Trim() != string.Empty)
                {
                    Byte[] MyData = new byte[0];
                    MyData = (Byte[])dsImage.Tables[0].Rows[0]["ARTIMAGE"];
                    MemoryStream stream = new MemoryStream(MyData)
                    {
                        Position = 0
                    };

                    PictureBox.Image = System.Drawing.Image.FromStream(stream);
                }
                else
                {
                    PictureBox.Image = null;
                }
            }
#pragma warning disable CS0168 // The variable 'ex' is declared but never used
            catch (Exception ex)
#pragma warning restore CS0168 // The variable 'ex' is declared but never used
            {

            }
        }
        public static void BindReportToPivotGrid(string ProcedureName, DateTime From, DateTime To, DevExpress.XtraPivotGrid.PivotGridControl ReportGrid)
        {
            ReportGrid.Fields.Clear();
            DataSet dsMaster = GetDataSet(ProcedureName + "'" + From.Date.ToString("yyyy-MM-dd") + "','" + To.Date.ToString("yyyy-MM-dd") + "'");
            if (dsMaster.Tables[0].Rows.Count > 0)
            {
                if (dsMaster.Tables[0].Columns.Count > 0)
                {
                    foreach (DataColumn dr in dsMaster.Tables[0].Columns)
                    {
                        DevExpress.XtraPivotGrid.PivotGridField Field = new DevExpress.XtraPivotGrid.PivotGridField
                        {
                            Area = DevExpress.XtraPivotGrid.PivotArea.FilterArea,
                            Caption = dr.ColumnName,
                            FieldName = dr.ColumnName,
                            Name = "F" + dr.ColumnName
                        };
                        if (dr.DataType.ToString().ToUpper().Contains("DECIMAL"))
                        {
                            Field.CellFormat.FormatString = "n2";
                            Field.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                            Field.TotalCellFormat.FormatString = "n2";
                            Field.TotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                            Field.TotalValueFormat.FormatString = "n2";
                            Field.TotalValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                            Field.ValueFormat.FormatString = "n2";
                            Field.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
                        }
                        if (dr.DataType.ToString().ToUpper().Contains("DATE"))
                        {
                            Field.CellFormat.FormatString = "dd-MM-yyyy";
                            Field.CellFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                            Field.ValueFormat.FormatString = "dd-MM-yyyy";
                            Field.ValueFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                        }
                        ReportGrid.Fields.AddRange(new DevExpress.XtraPivotGrid.PivotGridField[] { Field });
                    }
                }
                if (dsMaster.Tables[0].Rows.Count > 0)
                {
                    ReportGrid.DataSource = dsMaster.Tables[0];
                    ReportGrid.BestFit();
                }
                else
                {
                    ReportGrid.DataSource = null;
                }
            }
        }
        public static Point GetPositionInForm(Control ctrl)
        {
            var p = ctrl.Location;
            try
            {
                var parent = ctrl.Parent;
                //while (!(parent is Form))
                //{
                //    p.Offset(parent.Location.X, parent.Location.Y);
                //    parent = parent.Parent;
                //}
                return p;
            }

            catch (Exception)

            {
                return p;
            }
        }
        public static void XtraFormVisualize(Control C)
        {

            (C as XtraForm).ControlBox = false;
            (C as XtraForm).FormBorderStyle = FormBorderStyle.FixedToolWindow;
            (C as XtraForm).StartPosition = FormStartPosition.CenterParent;
        }
        public static void ToolStripVisualize(ToolStrip C)
        {
            C.BackColor = Color.FromArgb(0x15, 0x60, 0xA9);
            C.CanOverflow = false;
            C.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            C.GripStyle = ToolStripGripStyle.Hidden;
            C.RenderMode = ToolStripRenderMode.System;
            C.Renderer.RenderButtonBackground += new ToolStripItemRenderEventHandler(Renderer_RenderButtonBackground);
            foreach (ToolStripItem I in C.Items)
            {
                if (I.GetType() == typeof(ToolStripButton))
                {
                    var thisItem = I as ToolStripButton;
                    thisItem.MouseHover += ThisItem_MouseHover;
                    thisItem.MouseLeave += ThisItem_MouseLeave;

                    thisItem.DisplayStyle = ToolStripItemDisplayStyle.Text;
                    thisItem.ForeColor = Color.White;
                    thisItem.ImageTransparentColor = Color.Magenta;
                    thisItem.Name = "Save";
                    thisItem.Padding = new Padding(5, 2, 5, 2);
                }
                if (I.GetType() == typeof(ToolStripTextBox))
                {
                    var thisItem = I as ToolStripTextBox;
                    (thisItem.Control as TextBox).UseSystemPasswordChar = true;
                }
            }
        }
        public static int GetRowHandleByColumnValue(DevExpress.XtraGrid.Views.Grid.GridView view, string ColumnFieldName, object value)
        {
            var result = -1;
            for (var i = 0; i < view.RowCount; i++)
            {
                if (view.GetDataRow(i)[ColumnFieldName].Equals(value))
                {
                    result = i;
                    break;
                }
            }
            return result;
        }

        static void Renderer_RenderButtonBackground(object sender, ToolStripItemRenderEventArgs e)
        {
            if (e.Item.GetType() == typeof(ToolStripButton))
            {
                var thisItem = e.Item as ToolStripButton;
                if (thisItem.Selected)
                {
                    thisItem.BackColor = Color.White;
                    thisItem.ForeColor = Color.FromArgb(0x15, 0x60, 0xA9);
                }
                else
                {
                    thisItem.ForeColor = Color.White;
                    thisItem.BackColor = Color.FromArgb(0x15, 0x60, 0xA9);
                }

            }
        }


        static void ThisItem_MouseLeave(object sender, EventArgs e)
        {
            var thisItem = sender as ToolStripButton;
            thisItem.ForeColor = Color.White;
            thisItem.BackColor = Color.FromArgb(0x15, 0x60, 0xA9);
        }

        static void ThisItem_MouseHover(object sender, EventArgs e)
        {
            var thisItem = sender as ToolStripButton;
            thisItem.BackColor = Color.White;
            thisItem.ForeColor = Color.FromArgb(0x15, 0x60, 0xA9);
        }
        public static void LoadFormDataForEditing(string Query, XtraForm FormName)
        {
            //DataSet dsMain = GetDataSet(Query);
            //if (dsMain.Tables[0].Rows.Count > 0)
            //{
            //    foreach (Control c in FormName.Controls)
            //    {
            //        DataSet ds = GetDataSet("Select * from ProgramControls Where MainProgCode='" + GlobalVariables.MainProgCode + "' And ProgCode='" + GlobalVariables.ProgCode + "' And ControlName='" + c.Name + "' And ProgValidation='Y'");
            //        if (ds.Tables[0].Rows.Count > 0)
            //        {
            //            c.Text = dsMain.Tables[0].Rows[0][ds.Tables[0].Rows[0]["ProgFieldName"].ToString()].ToString();
            //        }
            //    }
            //}
        }
        public static void MakeFormCursorMovements(KeyEventArgs e, XtraForm Form)
        {
            if (e.KeyCode == Keys.Up)
            {
                System.Windows.Forms.SendKeys.Send("+{TAB}");
            }
            if (e.KeyCode == Keys.Escape)
            {
                Form.Close();
            }
        }
        public static void SetMyControls(XtraForm FormName, ToolStrip T)
        {
            TextBoxVisualize(FormName);
            DatePickerVisualize(FormName);
            ButtonVisualize(FormName);
            XtraFormVisualize(FormName);
            ToolStripVisualize(T);

            foreach (PanelControl P in FormName.Controls)
            {
                if (P is PanelControl)
                {
                    TextBoxVisualize(P);
                    DatePickerVisualize(P);
                    ButtonVisualize(P);
                }
            }
        }
        public static string GetNewTransactionCode(string Query)
        {
            string s2 = string.Empty;
            DataSet ds = ProjectFunctions.GetDataSet(Query);
            if (ds.Tables[0].Rows.Count > 0)
            {
                s2 = ds.Tables[0].Rows[0][0].ToString();
                s2 = (Convert.ToInt32(s2) + 1).ToString();
            }
            return s2;
        }

        public static bool MakeMasterFormValidations(XtraForm Form)
        {
            //foreach (Control c in Form.Controls)
            //{
            //    DataSet ds = GetDataSet("Select * from ProgramControls Where MainProgCode='" + GlobalVariables.MainProgCode + "' And ProgCode='" + GlobalVariables.ProgCode + "' And ControlName='" + c.Name + "' And ProgValidation='Y'");
            //    if (ds.Tables[0].Rows.Count > 0)
            //    {
            //        if (c.Text.Trim().Length == 0)
            //        {
            //            ProjectFunctions.SpeakError(ds.Tables[0].Rows[0]["ProgValidationMessage"].ToString());
            //            c.Focus();
            //            return false;
            //        }
            //    }
            //}
            return true;
        }
        public static void MakeMasterFormControlsVisible(XtraForm Form)
        {
            //foreach (Control c in Form.Controls)
            //{
            //    DataSet ds = GetDataSet("Select * from ProgramControls Where MainProgCode='" + GlobalVariables.MainProgCode + "' And ProgCode='" + GlobalVariables.ProgCode + "' And ControlName='" + c.Name + "'");
            //    if (ds.Tables[0].Rows.Count > 0)
            //    {
            //        c.Visible = true;
            //    }
            //    else
            //    {
            //        c.Visible = false;
            //    }
            //}
        }
        public static decimal RoundFive(decimal No)
        {
            No = ((int)(No / 5)) * 5;
            return No;
        }


        public static void BindMasterFormToGrid(string ProcedureName, DevExpress.XtraGrid.GridControl ReportGrid, DevExpress.XtraGrid.Views.Grid.GridView ReportGridView)
        {
            bool editBtn = false;
            ReportGridView.Columns.Clear();
            DataSet dsMaster = GetDataSet(ProcedureName);
            if (dsMaster.Tables[0].Rows.Count > 0)
            {
                if (dsMaster.Tables[0].Columns.Count > 0)
                {
                    int Count = 0;
                    foreach (DataColumn dr in dsMaster.Tables[0].Columns)
                    {
                        ReportGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
                        ReportGridView.Columns[Count].OptionsColumn.AllowEdit = false;
                        ReportGridView.Columns[Count].Visible = true;
                        ReportGridView.Columns[Count].Caption = dr.ColumnName;
                        ReportGridView.Columns[Count].FieldName = dr.ColumnName;
                        if (Count == 0)
                        {
                            ReportGridView.Columns[Count].Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, dr.ColumnName, "{0}") });
                        }
                        Count = Count + 1;
                    }
                    if (editBtn)
                    {
                        ReportGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
                        ReportGridView.Columns[Count].OptionsColumn.AllowEdit = false;
                        ReportGridView.Columns[Count].Visible = true;
                        ReportGridView.Columns[Count].Caption = "Edit_Link";
                        ReportGridView.Columns[Count].FieldName = "Edit_Link";


                    }

                }
                if (dsMaster.Tables[0].Rows.Count > 0)
                {
                    ReportGrid.DataSource = dsMaster.Tables[0];
                    ReportGridView.BestFitColumns();
                    ReportGridView.UserCellPadding = new Padding(1, 1, 1, 1);

                    //RepositoryItemButtonEdit tran = new RepositoryItemButtonEdit();
                    //tran.Name = "TranButton";
                    //tran.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
                    //tran.Buttons[0].Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Right;
                    //tran.Buttons[0].IsLeft = true;
                    //

                }
                else
                {
                    ReportGrid.DataSource = null;
                }
            }
        }

        public static void CreatePopUpForOneBox(string Query, string WhereClause, TextEdit TextBox1, TextEdit TextBox2, DevExpress.XtraGrid.GridControl ReportGrid, DevExpress.XtraGrid.Views.Grid.GridView ReportGridView)
        {
            ReportGrid.Text = TextBox1.Name;
            if (TextBox1.Text.Trim().Length == 0)
            {
                DataSet ds = ProjectFunctions.GetDataSet(Query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ReportGrid.DataSource = ds.Tables[0];
                    ReportGrid.Show();
                    ReportGrid.Visible = true;
                    ReportGrid.Focus();
                    ReportGridView.BestFitColumns();
                }
                else
                {
                    ProjectFunctions.SpeakError("No Records To Display");
                }
            }
            else
            {
                DataSet ds = ProjectFunctions.GetDataSet(Query + WhereClause + "='" + TextBox1.Text + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    TextBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                    TextBox2.Focus();
                }
                else
                {
                    DataSet ds1 = ProjectFunctions.GetDataSet(Query);
                    if (ds1.Tables[0].Rows.Count > 0)
                    {
                        ReportGrid.DataSource = ds1.Tables[0];
                        ReportGrid.Show();
                        ReportGrid.Visible = true;
                        ReportGrid.Focus();
                        ReportGridView.BestFitColumns();
                    }
                    else
                    {
                        ProjectFunctions.SpeakError("No Records To Display");
                    }
                }
            }
        }

        public static void CreatePopUpForTwoBoxes(string Query, string WhereClause, TextEdit TextBox1, TextEdit TextBox2, TextEdit TextBox3, DevExpress.XtraGrid.GridControl ReportGrid, DevExpress.XtraGrid.Views.Grid.GridView ReportGridView, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReportGridView.Columns.Clear();
                ReportGrid.Text = TextBox1.Name;
                if (TextBox1.Text.Trim().Length == 0)
                {
                    DataSet ds = ProjectFunctionsUtils.GetDataSet(Query);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ReportGrid.DataSource = ds.Tables[0];
                        ReportGrid.Show();
                        ReportGrid.Visible = true;
                        ReportGrid.Focus();
                        ReportGridView.BestFitColumns();
                    }
                    else
                    {
                        ProjectFunctions.SpeakError("No Records To Display");
                    }
                }
                else
                {
                    DataSet ds = ProjectFunctionsUtils.GetDataSet(Query + WhereClause + "='" + TextBox1.Text + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        TextBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                        TextBox2.Text = ds.Tables[0].Rows[0][1].ToString();
                        TextBox3.Focus();
                    }
                    else
                    {
                        DataSet ds1 = ProjectFunctionsUtils.GetDataSet(Query);
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            ReportGrid.DataSource = ds1.Tables[0];
                            ReportGrid.Show();
                            ReportGrid.Visible = true;
                            ReportGrid.Focus();
                            ReportGridView.BestFitColumns();
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



        public static void CreatePopUpForThreeBoxes(string Query, string WhereClause, TextEdit TextBox1, TextEdit TextBox2, TextEdit TextBox3, TextEdit TextBox4, DevExpress.XtraGrid.GridControl ReportGrid, DevExpress.XtraGrid.Views.Grid.GridView ReportGridView, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReportGridView.Columns.Clear();
                ReportGrid.Text = TextBox1.Name;
                if (TextBox1.Text.Trim().Length == 0)
                {
                    DataSet ds = ProjectFunctions.GetDataSet(Query);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ReportGrid.DataSource = ds.Tables[0];
                        ReportGrid.Show();
                        ReportGrid.Visible = true;
                        ReportGrid.Focus();
                        ReportGridView.BestFitColumns();
                    }
                    else
                    {
                        ProjectFunctions.SpeakError("No Records To Display");
                    }
                }
                else
                {
                    DataSet ds = ProjectFunctions.GetDataSet(Query + WhereClause + "='" + TextBox1.Text + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        TextBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                        TextBox2.Text = ds.Tables[0].Rows[0][1].ToString();
                        TextBox3.Text = ds.Tables[0].Rows[0][2].ToString();
                        TextBox4.Focus();
                    }
                    else
                    {
                        DataSet ds1 = ProjectFunctions.GetDataSet(Query);
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            ReportGrid.DataSource = ds1.Tables[0];
                            ReportGrid.Show();
                            ReportGrid.Visible = true;
                            ReportGrid.Focus();
                            ReportGridView.BestFitColumns();
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
        public static void CreatePopUpForFourBoxes(string Query, string WhereClause, TextEdit TextBox1, TextEdit TextBox2, TextEdit TextBox3, TextEdit TextBox4, TextEdit TextBox5, DevExpress.XtraGrid.GridControl ReportGrid, DevExpress.XtraGrid.Views.Grid.GridView ReportGridView, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReportGridView.Columns.Clear();
                ReportGrid.Text = TextBox1.Name;
                if (TextBox1.Text.Trim().Length == 0)
                {
                    DataSet ds = ProjectFunctions.GetDataSet(Query);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ReportGrid.DataSource = ds.Tables[0];
                        ReportGrid.Show();
                        ReportGrid.Visible = true;
                        ReportGrid.Focus();
                        ReportGridView.BestFitColumns();
                    }
                    else
                    {
                        ProjectFunctions.SpeakError("No Records To Display");
                    }
                }
                else
                {
                    DataSet ds = ProjectFunctions.GetDataSet(Query + WhereClause + "='" + TextBox1.Text + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        TextBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                        TextBox2.Text = ds.Tables[0].Rows[0][1].ToString();
                        TextBox3.Text = ds.Tables[0].Rows[0][2].ToString();
                        TextBox4.Text = ds.Tables[0].Rows[0][3].ToString();
                        TextBox5.Focus();
                    }
                    else
                    {
                        DataSet ds1 = ProjectFunctions.GetDataSet(Query);
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            ReportGrid.DataSource = ds1.Tables[0];
                            ReportGrid.Show();
                            ReportGrid.Visible = true;
                            ReportGrid.Focus();
                            ReportGridView.BestFitColumns();
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
        public static void CreatePopUpForFiveBoxes(string Query, string WhereClause, TextEdit TextBox1, TextEdit TextBox2, TextEdit TextBox3, TextEdit TextBox4, TextEdit TextBox5, TextEdit TextBox6, DevExpress.XtraGrid.GridControl ReportGrid, DevExpress.XtraGrid.Views.Grid.GridView ReportGridView, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ReportGridView.Columns.Clear();
                ReportGrid.Text = TextBox1.Name;
                if (TextBox1.Text.Trim().Length == 0)
                {
                    DataSet ds = ProjectFunctions.GetDataSet(Query);
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        ReportGrid.DataSource = ds.Tables[0];
                        ReportGrid.Show();
                        ReportGrid.Visible = true;
                        ReportGrid.Focus();
                        ReportGridView.BestFitColumns();
                    }
                    else
                    {
                        ProjectFunctions.SpeakError("No Records To Display");
                    }
                }
                else
                {
                    DataSet ds = ProjectFunctions.GetDataSet(Query + WhereClause + "='" + TextBox1.Text + "'");
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        TextBox1.Text = ds.Tables[0].Rows[0][0].ToString();
                        TextBox2.Text = ds.Tables[0].Rows[0][1].ToString();
                        TextBox3.Text = ds.Tables[0].Rows[0][2].ToString();
                        TextBox4.Text = ds.Tables[0].Rows[0][3].ToString();
                        TextBox5.Text = ds.Tables[0].Rows[0][4].ToString();
                        TextBox6.Focus();
                    }
                    else
                    {
                        DataSet ds1 = ProjectFunctions.GetDataSet(Query);
                        if (ds1.Tables[0].Rows.Count > 0)
                        {
                            ReportGrid.DataSource = ds1.Tables[0];
                            ReportGrid.Show();
                            ReportGrid.Visible = true;
                            ReportGrid.Focus();
                            ReportGridView.BestFitColumns();
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
        public static void BindReportToGrid(string ProcedureName, DateTime From, DateTime To, DevExpress.XtraGrid.GridControl ReportGrid, DevExpress.XtraGrid.Views.Grid.GridView ReportGridView)
        {
            //ReportGridView.Columns.Clear();
            DataSet dsMaster = GetDataSet(ProcedureName + "'" + From.Date.ToString("yyyy-MM-dd") + "','" + To.Date.ToString("yyyy-MM-dd") + "','" + GlobalVariables.CUnitID + "'");
            if (dsMaster.Tables[0].Rows.Count > 0)
            {
                if (dsMaster.Tables[0].Columns.Count > 0)
                {
                    int Count = 0;
                    foreach (DataColumn dr in dsMaster.Tables[0].Columns)
                    {
                        ReportGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
                        ReportGridView.Columns[Count].OptionsColumn.AllowEdit = false;
                        ReportGridView.Columns[Count].Visible = true;
                        ReportGridView.Columns[Count].Caption = dr.ColumnName;
                        ReportGridView.Columns[Count].FieldName = dr.ColumnName;
                        if (Count == 0)
                        {
                            ReportGridView.Columns[Count].Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, dr.ColumnName, "{0}") });
                        }
                        Count = Count + 1;
                    }
                }
                if (dsMaster.Tables[0].Rows.Count > 0)
                {
                    ReportGrid.DataSource = dsMaster.Tables[0];
                    ReportGridView.BestFitColumns();



                }
                else
                {
                    ReportGrid.DataSource = null;
                }
            }
        }
        public static void BindTransactionDataToGrid1(string ProcedureName, DateTime From, DateTime To, DevExpress.XtraGrid.GridControl ReportGrid, DevExpress.XtraGrid.Views.Grid.GridView ReportGridView)
        {
            if (From.ToString().Trim().Length > 0 && From.ToString().Trim().Length > 0)
            {
                ReportGridView.OptionsBehavior.Editable = true;
                ReportGridView.Columns.Clear();
                DataSet dsMaster = GetDataSet(ProcedureName + "'" + From.Date.ToString("yyyy-MM-dd") + "','" + To.Date.ToString("yyyy-MM-dd") + "','" + GlobalVariables.CUnitID + "'");
                if (dsMaster.Tables[0].Rows.Count > 0)
                {
                    int Count = 0;
                    if (dsMaster.Tables[0].Columns.Count > 0)
                    {

                        foreach (DataColumn dr in dsMaster.Tables[0].Columns)
                        {
                            ReportGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
                            ReportGridView.Columns[Count].OptionsColumn.AllowEdit = false;
                            ReportGridView.Columns[Count].Visible = true;
                            ReportGridView.Columns[Count].Caption = dr.ColumnName;
                            ReportGridView.Columns[Count].FieldName = dr.ColumnName;
                            if (Count == 0)
                            {
                                ReportGridView.Columns[Count].Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, dr.ColumnName, "{0}") });
                            }
                            Count = Count + 1;
                        }
                    }
                    if (dsMaster.Tables[0].Rows.Count > 0)
                    {
                        dsMaster.Tables[0].Columns.Add("Select", typeof(bool));
                        foreach (DataRow dr in dsMaster.Tables[0].Rows)
                        {
                            dr["Select"] = false;
                        }
                        ReportGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
                        ReportGridView.Columns[Count].OptionsColumn.AllowEdit = true;
                        ReportGridView.Columns[Count].Visible = true;
                        ReportGridView.Columns[Count].Caption = "Select";
                        ReportGridView.Columns[Count].FieldName = "Select";
                        ReportGrid.DataSource = dsMaster.Tables[0];
                        ReportGridView.BestFitColumns();
                    }
                    else
                    {
                        ReportGrid.DataSource = null;
                    }
                }
            }
            else
            {
                ProjectFunctions.SpeakError("Please Select Data Range First");
            }
        }

        public static void BindTransactionDataToGrid(DataSet dsMaster, DevExpress.XtraGrid.GridControl ReportGrid, DevExpress.XtraGrid.Views.Grid.GridView ReportGridView)
        {
            if (dsMaster != null)
            {
                ReportGridView.OptionsBehavior.Editable = true;
                ReportGridView.Columns.Clear();
                //DataSet dsMaster = GetDataSet(ProcedureName + "'" + From.Date.ToString("yyyy-MM-dd") + "','" + To.Date.ToString("yyyy-MM-dd") + "','" + GlobalVariables.CUnitID + "'");
                if (dsMaster.Tables[0].Rows.Count > 0)
                {
                    int Count = 0;
                    if (dsMaster.Tables[0].Columns.Count > 0)
                    {

                        foreach (DataColumn dr in dsMaster.Tables[0].Columns)
                        {
                            ReportGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
                            ReportGridView.Columns[Count].OptionsColumn.AllowEdit = false;
                            ReportGridView.Columns[Count].Visible = true;
                            ReportGridView.Columns[Count].Caption = dr.ColumnName;
                            ReportGridView.Columns[Count].FieldName = dr.ColumnName;
                            if (Count == 0)
                            {
                                ReportGridView.Columns[Count].Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, dr.ColumnName, "{0}") });
                            }
                            Count = Count + 1;
                        }
                    }
                    if (dsMaster.Tables[0].Rows.Count > 0)
                    {
                        dsMaster.Tables[0].Columns.Add("Select", typeof(bool));
                        foreach (DataRow dr in dsMaster.Tables[0].Rows)
                        {
                            dr["Select"] = false;
                        }
                        ReportGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
                        ReportGridView.Columns[Count].OptionsColumn.AllowEdit = true;
                        ReportGridView.Columns[Count].Visible = true;
                        ReportGridView.Columns[Count].Caption = "Select";
                        ReportGridView.Columns[Count].FieldName = "Select";
                        ReportGrid.DataSource = dsMaster.Tables[0];
                        ReportGridView.BestFitColumns();
                    }
                    else
                    {
                        ReportGrid.DataSource = null;
                    }
                }
            }
            else
            {
                ProjectFunctions.SpeakError("Please Select Data Range First");
            }
        }
        public static void BindMonthYearTransactionDataToGrid(string ProcedureName, DateTime From, DevExpress.XtraGrid.GridControl ReportGrid, DevExpress.XtraGrid.Views.Grid.GridView ReportGridView)
        {
            ReportGridView.OptionsBehavior.Editable = true;
            ReportGridView.Columns.Clear();
            DataSet dsMaster = GetDataSet(ProcedureName + "'" + From.Date.ToString("yyMM") + "'");
            if (dsMaster.Tables[0].Rows.Count > 0)
            {
                int Count = 0;
                if (dsMaster.Tables[0].Columns.Count > 0)
                {

                    foreach (DataColumn dr in dsMaster.Tables[0].Columns)
                    {
                        ReportGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
                        ReportGridView.Columns[Count].OptionsColumn.AllowEdit = false;
                        ReportGridView.Columns[Count].Visible = true;
                        ReportGridView.Columns[Count].Caption = dr.ColumnName;
                        ReportGridView.Columns[Count].FieldName = dr.ColumnName;
                        if (Count == 0)
                        {
                            ReportGridView.Columns[Count].Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] { new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, dr.ColumnName, "{0}") });
                        }
                        Count = Count + 1;
                    }
                }
                if (dsMaster.Tables[0].Rows.Count > 0)
                {
                    dsMaster.Tables[0].Columns.Add("Select", typeof(bool));
                    foreach (DataRow dr in dsMaster.Tables[0].Rows)
                    {
                        dr["Select"] = false;
                    }
                    ReportGridView.Columns.Add(new DevExpress.XtraGrid.Columns.GridColumn());
                    ReportGridView.Columns[Count].OptionsColumn.AllowEdit = true;
                    ReportGridView.Columns[Count].Visible = true;
                    ReportGridView.Columns[Count].Caption = "Select";
                    ReportGridView.Columns[Count].FieldName = "Select";
                    ReportGrid.DataSource = dsMaster.Tables[0];
                    ReportGridView.BestFitColumns();
                }
                else
                {
                    ReportGrid.DataSource = null;
                }
            }
        }


        public static bool CheckAllPossible(string ArticleID, decimal MRP, string ColorID, string SizeID)
        {
            DataSet dsCheckART = ProjectFunctions.GetDataSet("sp_CheckSKUData '" + ArticleID + "','" + ColorID + "','" + SizeID + "' ");
            if (dsCheckART.Tables[0].Rows.Count > 0)
            {
                if (MRP == Convert.ToDecimal(dsCheckART.Tables[0].Rows[0]["ARTMRP"]))
                {

                }
                else
                {
                    ProjectFunctions.SpeakError("Wrong MRP Found");
                    return false;
                }
            }
            else
            {
                ProjectFunctions.SpeakError("No Article Found");
                return false;
            }

            if (dsCheckART.Tables[1].Rows.Count > 0)
            {

            }
            else
            {
                ProjectFunctions.SpeakError("No Color Found");
                return false;
            }
            if (dsCheckART.Tables[2].Rows.Count > 0)
            {

            }
            else
            {
                ProjectFunctions.SpeakError("No Size Found");
                return false;
            }
            return true;

        }
        public static void TextBoxVisualize(Control C)
        {
            foreach (Control c in C.Controls)
            {
                if (c.GetType() == typeof(TextEdit) || c.GetType() == typeof(CalcEdit))
                {
                    var thiscontrol = (TextEdit)c;


                    thiscontrol.Properties.Appearance.BorderColor = Color.FromArgb(224, 224, 224);
                    thiscontrol.Properties.Appearance.Options.UseBorderColor = true;
                    thiscontrol.Properties.AppearanceFocused.BackColor = Color.AliceBlue;
                    thiscontrol.Properties.AppearanceFocused.BorderColor = Color.FromArgb(0x15, 0x60, 0xA9);
                    thiscontrol.Properties.AppearanceFocused.ForeColor = Color.Black;
                    thiscontrol.Properties.AppearanceDisabled.BackColor = Color.Lavender;
                    thiscontrol.Properties.AppearanceDisabled.Options.UseBackColor = true;
                    thiscontrol.Properties.AppearanceDisabled.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);

                    thiscontrol.Properties.AppearanceReadOnly.BackColor = Color.Lavender;
                    thiscontrol.Properties.AppearanceReadOnly.Options.UseBackColor = true;
                    thiscontrol.Properties.AppearanceReadOnly.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);

                    thiscontrol.Properties.AppearanceFocused.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
                    thiscontrol.Properties.AppearanceFocused.Options.UseBackColor = true;
                    thiscontrol.Properties.AppearanceFocused.Options.UseBorderColor = true;
                    thiscontrol.Properties.AppearanceFocused.Options.UseForeColor = true;
                    thiscontrol.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                    thiscontrol.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.UltraFlat;
                    thiscontrol.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
                    thiscontrol.EnterMoveNextControl = true;
                    thiscontrol.Properties.CharacterCasing = CharacterCasing.Upper;

                    thiscontrol.Enter += (o, e) =>
                    {
                        thiscontrol.SelectAll();
                    };
                }
            }
        }


        public static void ButtonVisualize(Control C)
        {
            foreach (Control c in C.Controls)
            {
                if (c.GetType() == typeof(SimpleButton))
                {
                    var thiscontrol = (SimpleButton)c;
                    thiscontrol.Appearance.BackColor = Color.FromArgb(0x15, 0x60, 0xA9);
                    thiscontrol.Appearance.ForeColor = Color.White;
                    thiscontrol.Appearance.Options.UseBackColor = true;
                    thiscontrol.Appearance.Options.UseForeColor = true;
                    thiscontrol.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
                    thiscontrol.LookAndFeel.UseDefaultLookAndFeel = false;
                }
            }
        }

        public static void GirdViewVisualize(GridView C)
        {
            C.RowCellClick += new RowCellClickEventHandler(C_RowCellClick);
            C.GridControl.LookAndFeel.UseDefaultLookAndFeel = true;
            C.OptionsBehavior.Editable = true;
            C.OptionsBehavior.AllowIncrementalSearch = true;
            C.OptionsSelection.EnableAppearanceFocusedCell = true;
            C.FocusRectStyle = DrawFocusRectStyle.RowFocus;
            C.OptionsView.ShowGroupPanel = false;
            C.OptionsView.ShowIndicator = false;
            C.OptionsView.WaitAnimationOptions = WaitAnimationOptions.Indicator;
            C.OptionsFilter.ShowAllTableValuesInCheckedFilterPopup = false;
            C.OptionsFilter.ShowAllTableValuesInFilterPopup = false;
            C.OptionsView.AllowCellMerge = false;
            C.OptionsView.ShowHorizontalLines = DevExpress.Utils.DefaultBoolean.True;
            C.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.True;

            C.OptionsView.GroupDrawMode = DevExpress.XtraGrid.Views.Grid.GroupDrawMode.Office;
            C.OptionsView.ShowGroupedColumns = false;
            C.OptionsView.ShowVerticalLines = DevExpress.Utils.DefaultBoolean.False;
            foreach (DevExpress.XtraGrid.Columns.GridColumn c in C.Columns)
            {
                c.OptionsFilter.FilterPopupMode = DevExpress.XtraGrid.Columns.FilterPopupMode.CheckedList;
            }

            C.Appearance.Row.FontSizeDelta = 1;
            C.Appearance.Row.FontStyleDelta = FontStyle.Bold;
            C.Appearance.HeaderPanel.ForeColor = Color.Black;
            C.Appearance.HeaderPanel.FontSizeDelta = 1;
            C.Appearance.HeaderPanel.FontStyleDelta = FontStyle.Bold;

            C.UserCellPadding = new Padding(1, 1, 1, 1);

        }

        public static void C_RowCellClick(object sender, RowCellClickEventArgs e)
        {
            var formatRulesMenu = new DXPopupMenu();
            var view = sender as GridView;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                DXMenuItem Copy;
#pragma warning disable CS0168 // The variable 'Print' is declared but never used
                DXMenuItem Print;
#pragma warning restore CS0168 // The variable 'Print' is declared but never used
                DXMenuItem SAR;
                Copy = new DXMenuItem("Copy", (o1, e1) =>
                {
                    view.OptionsSelection.MultiSelect = true;
                    view.CopyToClipboard();
                });
                SAR = new DXMenuItem("Select All Records", (o1, e1) =>
                {
                    view.OptionsSelection.MultiSelect = true;
                    view.SelectAll();
                });

                var items = new GridFormatRuleMenuItems(view, e.Column, formatRulesMenu.Items);
                formatRulesMenu.Items.Add(Copy);
                formatRulesMenu.Items.Add(SAR);
                if (items.Count > 0)
                {
                    MenuManagerHelper.ShowMenu(formatRulesMenu, view.GridControl.LookAndFeel, view.GridControl.MenuManager, view.GridControl, new Point(e.X, e.Y));
                }
            }
        }


        public static void EventTracker(string ProcessName)
        {
            using (var sqlcon = new SqlConnection(GetConnection()))
            {
                sqlcon.Open();
                var sqlcom = new SqlCommand
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandText = "sp_InsertEventData",
                    Connection = sqlcon
                };
                sqlcom.Parameters.AddWithValue("@ProgCode", GlobalVariables.ProgCode);
                sqlcom.Parameters.AddWithValue("@EventDesc", ProcessName);
                sqlcom.Parameters.AddWithValue("@UserName", GlobalVariables.CurrentUser);
                sqlcom.Parameters.AddWithValue("@EventDatetime", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
                sqlcom.ExecuteNonQuery();
                sqlcon.Close();
            }
        }


        public static void SendToSpecificPrinter(string filename, string PrinterName)
        {
            try

            {
                using (var pdfViewer = new DevExpress.XtraPdfViewer.PdfViewer())
                {
                    pdfViewer.LoadDocument(filename);

                    //PrinterSettings settings = new PrinterSettings();


                    DevExpress.Pdf.PdfPrinterSettings printerSettings = new DevExpress.Pdf.PdfPrinterSettings();
                    printerSettings.Settings.PrinterName = PrinterName;
                    printerSettings.Settings.PrintFileName = filename;
                    pdfViewer.ShowPrintStatusDialog = false;

                    pdfViewer.Print(printerSettings);
                    pdfViewer.CloseDocument();
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }

        }
        public static void SendToDirectPrint(string filename)
        {

            using (var pdfViewer = new DevExpress.XtraPdfViewer.PdfViewer())
            {
                pdfViewer.LoadDocument(filename);

                PrinterSettings settings = new PrinterSettings();


                DevExpress.Pdf.PdfPrinterSettings printerSettings = new DevExpress.Pdf.PdfPrinterSettings();
                printerSettings.Settings.PrinterName = settings.PrinterName;
                printerSettings.Settings.PrintFileName = filename;
                pdfViewer.ShowPrintStatusDialog = false;

                pdfViewer.Print(printerSettings);
                pdfViewer.CloseDocument();
            }

        }



        public static async Task WhatsAppConnectionStatus()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://seqkartsolution:3000/state"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "application/json");

                    var response = await httpClient.SendAsync(request);
                    if (response.IsSuccessStatusCode == true)
                    {
                        string content = await response.Content.ReadAsStringAsync();

                        var myDetails = JsonConvert.DeserializeObject<WhatsAppClasses.WhatsAppLoginStatus>(content);
                        GlobalVariables.WhatAppStatus = myDetails.state;
                        GlobalVariables.WhatAppMobileNo = myDetails.user;
                    }
                    else
                    {
                        GlobalVariables.WhatAppStatus = "Disconnected";
                        GlobalVariables.WhatAppMobileNo = "No User";
                    }

                }

            }
        }

        public static async Task WhatsAppStatusspeak()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("GET"), "http://seqkartsolution:3000/state"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "application/json");

                    var response = await httpClient.SendAsync(request);
                    if (response.IsSuccessStatusCode == true)
                    {
                        Speak("Whats App connected");
                    }
                    else
                    {

                    }

                }

            }
        }

        public static async Task WhatsAppDisConnection()
        {
            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("DELETE"), "http://seqkartsolution:3000/disconnect"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "application/json");

                    var response = await httpClient.SendAsync(request);
                    if (response.IsSuccessStatusCode == true)
                    {
                        SpeakError("Whats App Disconnected");
                    }
                }
            }
        }


        public static async Task SendBillMessageAsync(String BillNo, DateTime BillDate, String BillSeries)
        {
            DataSet ds = ProjectFunctions.GetDataSet("Select SIMGRANDTOT,simseries,SIMNO,SIMDATE from SALEINVMAIN where SIMDATE='" + BillDate.Date.ToString("yyyy-MM-dd") + "' And SIMNO='" + BillNo + "' And SIMSERIES='" + BillSeries + "' And UnitCode='" + GlobalVariables.CUnitID + "' ");
            String Message;
            if (BillSeries == "GST")
            {
                Message = "You have been billed for Rs. " + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIMGRANDTOT"]).ToString("0.00") + " for Invoice No . " + BillSeries + "-" + BillNo + " dated - " + BillDate.Date.ToString("dd-MM-yyyy");
            }
            else
            {
                Message = "Your challan has been issued for Rs. " + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIMGRANDTOT"]).ToString("0.00") + " against challan No . " + BillSeries + "-" + BillNo + " dated - " + BillDate.Date.ToString("dd-MM-yyyy");
            }


            if (ds.Tables[0].Rows.Count > 0)
            {
                using (var httpClient = new HttpClient())
                {
                    using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://seqkartsolution:3000/918591115444/sendText"))
                    {
                        request.Headers.TryAddWithoutValidation("accept", "application/json");

                        request.Content = new StringContent("{\"text\":\"" + Message + "\",\"sendLinkPreview\":false}");
                        request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");

                        var response = await httpClient.SendAsync(request);

                        //XtraMessageBox.Show(response.StatusCode.ToString());
                    }
                }
            }
        }

        public static async Task SendBillImageAsync(String MobileNo)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes("C://Temp//abc.pdf");

            string base64String = Convert.ToBase64String(imageBytes);

            using (var httpClient = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://seqkartsolution:3000/" + MobileNo + "/sendMedia"))
                {
                    request.Headers.TryAddWithoutValidation("accept", "application/json");

                    request.Content = new StringContent("{\"base64data\":\"" + base64String + "\",\"mimeType\":\"application/pdf\",\"caption\":\"i'm a media caption!\",\"filename\":\"test.pdf\"}");
                    request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");

                    var response = await httpClient.SendAsync(request);
                }
            }



            //DataSet ds = ProjectFunctions.GetDataSet("Select SIMGRANDTOT,simseries,SIMNO,SIMDATE from SALEINVMAIN where SIMDATE='" + BillDate.Date.ToString("yyyy-MM-dd") + "' And SIMNO='" + BillNo + "' And SIMSERIES='" + BillSeries + "' And UnitCode='" + GlobalVariables.CUnitID + "' ");
            //String Message;
            //if (BillSeries == "GST")
            //{
            //    Message = "You have been billed for Rs. " + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIMGRANDTOT"]).ToString("0.00") + " for Invoice No . " + BillSeries + "-" + BillNo + " dated - " + BillDate.Date.ToString("dd-MM-yyyy");
            //}
            //else
            //{
            //    Message = "Your challan has been issued for Rs. " + Convert.ToDecimal(ds.Tables[0].Rows[0]["SIMGRANDTOT"]).ToString("0.00") + " against challan No . " + BillSeries + "-" + BillNo + " dated - " + BillDate.Date.ToString("dd-MM-yyyy");
            //}


            //if (ds.Tables[0].Rows.Count > 0)
            //{
            //    using (var httpClient = new HttpClient())
            //    {
            //        using (var request = new HttpRequestMessage(new HttpMethod("POST"), "http://seqkartsolution:3000/918591115444/sendText"))
            //        {
            //            request.Headers.TryAddWithoutValidation("accept", "application/json");

            //            request.Content = new StringContent("{\"text\":\"" + Message + "\",\"sendLinkPreview\":false}");
            //            request.Content.Headers.ContentType = System.Net.Http.Headers.MediaTypeHeaderValue.Parse("application/json");

            //            var response = await httpClient.SendAsync(request);

            //            //XtraMessageBox.Show(response.StatusCode.ToString());
            //        }
            //    }
            //}
        }

        public static async void GenerateAPIToken()
        {
            //if (MessageBox.Show("Calling any API method will internally check for valid AuthToken and would try to obtain AuthToken if its is expired.  You don't need to explicitly call GetAuthTokenAsync method. Do you want to proceed?", "AuthToken is Automatic", MessageBoxButtons.YesNo) == DialogResult.Yes)
            //{

            //    TxnRespWithObjAndInfo<EWBSession> TxnResp = await EWBAPI.GetAuthTokenAsync(EwbSession);

            //    //// Below is the code to call Api Synchroniously
            //    //TxnRespWithObjAndInfo<EWBSession> TxnResp = Task.Run(() => EWBAPI.GetAuthTokenAsync(EwbSession)).Result;

            //    if (TxnResp.IsSuccess)
            //    {
            //        ProjectFunctions.Speak("Got Token");
            //    }
            //    else
            //    {
            //        ProjectFunctions.Speak("Token not found ! Check Server");
            //    }
            //}

        }

        public static async void CancelEWaybill(String BillNo, DateTime BillDate)
        {
            EWBSession EwbSession = new EWBSession();
            EwbSession.EwbApiLoginDetails.EwbGstin = GlobalVariables.EWBGSTIN;
            EwbSession.EwbApiLoginDetails.EwbUserID = GlobalVariables.EWBUserID;
            EwbSession.EwbApiLoginDetails.EwbPassword = GlobalVariables.EWBPassword;
            EwbSession.EwbApiSetting.GSPName = GlobalVariables.GSPName;
            EwbSession.EwbApiSetting.AspPassword = GlobalVariables.ASPPassword;
            EwbSession.EwbApiSetting.AspUserId = GlobalVariables.ASPNetUser;
            EwbSession.EwbApiSetting.BaseUrl = GlobalVariables.BaseUrl;
            DataSet ds = ProjectFunctions.GetDataSet("Select SIMTRDPRMWYBLNO from SALEINVMAIN where SIMNO='" + BillNo + "' And SIMDATE='" + BillDate.Date.ToString("yyyy-MM-dd") + "' and SIMSERIES='GST' and UnitCode='" + GlobalVariables.CUnitID + "'");
            if (ds.Tables[0].Rows[0]["SIMTRDPRMWYBLNO"].ToString().Trim().Length > 0)
            {
                ReqCancelEwbPl reqCancelEWB = new ReqCancelEwbPl();
                //reqCancelEWB.ewbNo = 101008701277;
                reqCancelEWB.ewbNo = Convert.ToInt64(ds.Tables[0].Rows[0]["SIMTRDPRMWYBLNO"]);
                reqCancelEWB.cancelRsnCode = 2;
                reqCancelEWB.cancelRmrk = "Cancelled the order";

                TxnRespWithObjAndInfo<RespCancelEwbPl> respCancelEWB = await EWBAPI.CancelEWBAsync(EwbSession, reqCancelEWB);
                if (respCancelEWB.IsSuccess)
                {
                    XtraMessageBox.Show(JsonConvert.SerializeObject(respCancelEWB.RespObj));
                    ProjectFunctions.GetDataSet("update SALEINVMAIN Set SIMTRDPRMWYBLNO=null  where SIMNO='" + BillNo + "' And SIMDATE='" + BillDate.Date.ToString("yyyy-MM-dd") + "' and SIMSERIES='GST' and UnitCode='" + GlobalVariables.CUnitID + "'");
                }

                else
                {
                    XtraMessageBox.Show(respCancelEWB.TxnOutcome);
                }

            }
            else
            {
                XtraMessageBox.Show("EWay Bill is not generated then how to cancel");
                return;
            }



        }
        public static async void PrintEWaybill(String BillNo, DateTime BillDate)
        {



            DataSet ds = ProjectFunctions.GetDataSet("Select SIMTRDPRMWYBLNO from SALEINVMAIN where SIMNO='" + BillNo + "' And SIMDATE='" + BillDate.Date.ToString("yyyy-MM-dd") + "' and SIMSERIES='GST' and UnitCode='" + GlobalVariables.CUnitID + "'");
            if (ds.Tables[0].Rows[0]["SIMTRDPRMWYBLNO"].ToString().Trim().Length > 0)
            {
                EWBSession EwbSession = new EWBSession();
                EwbSession.EwbApiLoginDetails.EwbGstin = GlobalVariables.EWBGSTIN;
                EwbSession.EwbApiLoginDetails.EwbUserID = GlobalVariables.EWBUserID;
                EwbSession.EwbApiLoginDetails.EwbPassword = GlobalVariables.EWBPassword;
                EwbSession.EwbApiSetting.GSPName = GlobalVariables.GSPName;
                EwbSession.EwbApiSetting.AspPassword = GlobalVariables.ASPPassword;
                EwbSession.EwbApiSetting.AspUserId = GlobalVariables.ASPNetUser;
                EwbSession.EwbApiSetting.BaseUrl = GlobalVariables.BaseUrl;
                long EwbNo = Convert.ToInt64(ds.Tables[0].Rows[0]["SIMTRDPRMWYBLNO"]);
                TxnRespWithObjAndInfo<RespGetEWBDetail> TxnResp = await EWBAPI.GetEWBDetailAsync(EwbSession, EwbNo);

                var a = JsonConvert.SerializeObject(TxnResp.RespObj);
                if (TxnResp.IsSuccess == true)
                {
                    if (System.IO.Directory.Exists(Application.StartupPath + "\\EWAY"))
                    {
                        string pdfFolderPath = Application.StartupPath + "\\EWAY\\";
                        EWBAPI.PrintEWB(EwbSession, TxnResp.RespObj, pdfFolderPath, false, false);

                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(Application.StartupPath + "\\EWAY");
                        string pdfFolderPath = Application.StartupPath + "\\EWAY\\";
                        EWBAPI.PrintEWB(EwbSession, TxnResp.RespObj, pdfFolderPath, false, false);

                    }

                    //if (System.IO.File.Exists(Application.StartupPath + "\\EWAY\\" + (ds.Tables[0].Rows[0]["SIMTRDPRMWYBLNO"].ToString() + ".pdf")))
                    //{
                    //    System.IO.File.Copy(Application.StartupPath + "\\EWAY\\" + ds.Tables[0].Rows[0]["SIMTRDPRMWYBLNO"].ToString() + ".pdf", Application.StartupPath + "\\EWAY\\GST-" + BillNo + ".pdf");
                    //   //// System.IO.File.Delete(Application.StartupPath + "\\EWAY\\" + ds.Tables[0].Rows[0]["SIMTRDPRMWYBLNO"].ToString() + ".pdf");
                    //}
                }
                else
                {
                    XtraMessageBox.Show(TxnResp.TxnOutcome);
                }
            }
            else
            {
                XtraMessageBox.Show("EWay Bill is not generated then how to print");
                return;
            }
        }
        public static async void PrintEWaybillDetail(String BillNo, DateTime BillDate)
        {



            DataSet ds = ProjectFunctions.GetDataSet("Select SIMTRDPRMWYBLNO from SALEINVMAIN where SIMNO='" + BillNo + "' And SIMDATE='" + BillDate.Date.ToString("yyyy-MM-dd") + "' and SIMSERIES='GST' and UnitCode='" + GlobalVariables.CUnitID + "'");
            if (ds.Tables[0].Rows[0]["SIMTRDPRMWYBLNO"].ToString().Trim().Length > 0)
            {
                EWBSession EwbSession = new EWBSession();
                EwbSession.EwbApiLoginDetails.EwbGstin = GlobalVariables.EWBGSTIN;
                EwbSession.EwbApiLoginDetails.EwbUserID = GlobalVariables.EWBUserID;
                EwbSession.EwbApiLoginDetails.EwbPassword = GlobalVariables.EWBPassword;
                EwbSession.EwbApiSetting.GSPName = GlobalVariables.GSPName;
                EwbSession.EwbApiSetting.AspPassword = GlobalVariables.ASPPassword;
                EwbSession.EwbApiSetting.AspUserId = GlobalVariables.ASPNetUser;
                EwbSession.EwbApiSetting.BaseUrl = GlobalVariables.BaseUrl;
                long EwbNo = Convert.ToInt64(ds.Tables[0].Rows[0]["SIMTRDPRMWYBLNO"]);
                TxnRespWithObjAndInfo<RespGetEWBDetail> TxnResp = await EWBAPI.GetEWBDetailAsync(EwbSession, EwbNo);

                var a = JsonConvert.SerializeObject(TxnResp.RespObj);
                if (TxnResp.IsSuccess == true)
                {
                    if (System.IO.Directory.Exists(Application.StartupPath + "\\EWayDetailed"))
                    {
                        string pdfFolderPath = Application.StartupPath + "\\EWayDetailed";
                        EWBAPI.PrintEWB(EwbSession, TxnResp.RespObj, pdfFolderPath, false, true);
                    }
                    else
                    {
                        System.IO.Directory.CreateDirectory(Application.StartupPath + "\\EWayDetailed");
                        string pdfFolderPath = Application.StartupPath + "\\EWayDetailed";
                        EWBAPI.PrintEWB(EwbSession, TxnResp.RespObj, pdfFolderPath, false, true);
                    }
                    //if (System.IO.File.Exists(Application.StartupPath + "\\EWayDetailed\\" + (ds.Tables[0].Rows[0]["SIMTRDPRMWYBLNO"].ToString() + ".pdf")))
                    //{
                    //    System.IO.File.Copy(Application.StartupPath + "\\EWayDetailed\\" + ds.Tables[0].Rows[0]["SIMTRDPRMWYBLNO"].ToString() + ".pdf", Application.StartupPath + "\\EWayDetailed\\GST-" + BillNo + ".pdf");
                    //   // System.IO.File.Delete(Application.StartupPath + "\\EWayDetailed\\" + ds.Tables[0].Rows[0]["SIMTRDPRMWYBLNO"].ToString() + ".pdf");
                    //}
                }
                else
                {
                    XtraMessageBox.Show(TxnResp.TxnOutcome);
                }
            }
            else
            {
                XtraMessageBox.Show("EWay Bill is not generated then how to print");
                return;
            }
        }
        public static async void GenerateEWaybill(String BillNo, DateTime BillDate)
        {
            DataSet ds = ProjectFunctions.GetDataSet("[sp_LoadInvoiceFEWayBill] '" + BillDate.Date.ToString("yyyy-MM-dd") + "','" + BillNo + "','GST','" + GlobalVariables.CUnitID + "','" + GlobalVariables.FinancialYear + "'");

            if (ds.Tables[0].Rows[0]["SIMTRDPRMWYBLNO"].ToString().Trim().Length < 10 && ds.Tables[0].Rows[0]["BillSeries"].ToString() == "GST" && Convert.ToDecimal(ds.Tables[0].Rows[0]["SIMGRANDTOT"]) >= 50000)
            {
                if (ds.Tables[0].Rows[0]["AccGSTNo"].ToString().Trim().Length < 10)
                {
                    ProjectFunctions.SpeakError("Kindly Update GST No First");
                    return;
                }
            }

            //GlobalVariables.CmpGSTNo = "34AACCC1596Q002";
            //ReqGenEwbPl ewbGen = new ReqGenEwbPl();
            //ewbGen.supplyType = "O";
            //ewbGen.subSupplyType = "1";
            //ewbGen.subSupplyDesc = "";
            //ewbGen.docType = "INV";
            //ewbGen.docNo = "GST-" + ds.Tables[0].Rows[0]["BillNo"].ToString();
            ////ewbGen.docDate = Convert.ToDateTime("2021-04-23").ToString("dd/MM/yyyy");
            //ewbGen.docDate = Convert.ToDateTime(ds.Tables[0].Rows[0]["BillDate"]).ToString("dd/MM/yyyy");
            ////ewbGen.fromGstin = GlobalVariables.CmpGSTNo;
            //ewbGen.fromGstin = "34AACCC1596Q002";
            //ewbGen.fromTrdName = GlobalVariables.CompanyName;
            //ewbGen.fromAddr1 = GlobalVariables.CAddress1;
            //ewbGen.fromAddr2 = GlobalVariables.CAddress2;
            //ewbGen.fromPlace = "ludhiana";
            ////ewbGen.fromPincode = Convert.ToInt32(GlobalVariables.CmpZipCode);
            //ewbGen.fromPincode = 605001;
            ////ewbGen.fromStateCode = Convert.ToInt32(GlobalVariables.CmpGSTNo.Substring(0, 2));
            ////ewbGen.actFromStateCode = Convert.ToInt32(GlobalVariables.CmpGSTNo.Substring(0, 2));
            //ewbGen.fromStateCode = 34;
            //ewbGen.actFromStateCode = 34;
            //ewbGen.toGstin = ds.Tables[0].Rows[0]["AccGSTNo"].ToString();
            //ewbGen.toTrdName = ds.Tables[0].Rows[0]["DebitPartyName"].ToString();
            //ewbGen.toAddr1 = ds.Tables[0].Rows[0]["DelieveryPartyAddress1"].ToString();
            //ewbGen.toAddr2 = ds.Tables[0].Rows[0]["DelieveryPartyAddress2"].ToString();
            //ewbGen.toPlace = ds.Tables[0].Rows[0]["DebitPartyCity"].ToString();
            //ewbGen.toPincode = Convert.ToInt32(ds.Tables[0].Rows[0]["DebitPartyZipCode"]);
            //ewbGen.toStateCode = Convert.ToInt32(ds.Tables[0].Rows[0]["AccGSTNo"].ToString().Substring(0, 2));
            //ewbGen.actToStateCode = Convert.ToInt32(ds.Tables[0].Rows[0]["AccGSTNo"].ToString().Substring(0, 2));
            //ewbGen.transactionType = 1;
            //ewbGen.dispatchFromGSTIN = "";
            //ewbGen.dispatchFromTradeName = GlobalVariables.CompanyName;
            //ewbGen.shipToGSTIN = ds.Tables[0].Rows[0]["AccGSTNo"].ToString();
            //ewbGen.shipToTradeName = ds.Tables[0].Rows[0]["DebitPartyName"].ToString();



            ReqGenEwbPl ewbGen = new ReqGenEwbPl();

            ewbGen.supplyType = "O";
            ewbGen.subSupplyType = "1";
            ewbGen.subSupplyDesc = string.Empty;
            ewbGen.docType = "INV";
            ewbGen.docNo = "235";
            ewbGen.docDate = "21/04/2021";
            ewbGen.fromGstin = "34AACCC1596Q002";//"07AACCC1596Q1Z4";
            ewbGen.fromTrdName = "welton";
            ewbGen.fromAddr1 = "2ND CROSS NO 59  19  A";
            ewbGen.fromAddr2 = "GROUND FLOOR OSBORNE ROAD";
            ewbGen.fromPlace = "FRAZER TOWN";
            ewbGen.fromPincode = 605001;//263652;/*110001;*/
            ewbGen.fromStateCode = 34;
            ewbGen.actFromStateCode = 34;
            ewbGen.toGstin = "05AAACG0904A1ZL";
            ewbGen.toTrdName = "sthuthya";
            ewbGen.toAddr1 = "Shree Nilaya";
            ewbGen.toAddr2 = "Dasarahosahalli";
            ewbGen.toPlace = "Beml Nagar";
            ewbGen.toPincode = 263652;/*110005;*/
            ewbGen.toStateCode = 05;
            ewbGen.actToStateCode = 05;
            ewbGen.transactionType = 1;
            ewbGen.dispatchFromGSTIN = string.Empty; /*29AAAAA1303P1ZV*/
            ewbGen.dispatchFromTradeName = "ABC Traders";
            ewbGen.shipToGSTIN = "05AAACG0904A1ZL"; //29ALSPR1722R1Z3
            ewbGen.shipToTradeName = "XYZ Traders";


            //ewbGen.toGstin = ds.Tables[0].Rows[0]["AccGSTNo"].ToString();
            //ewbGen.toTrdName = ds.Tables[0].Rows[0]["DebitPartyName"].ToString();
            //ewbGen.toAddr1 = ds.Tables[0].Rows[0]["DelieveryPartyAddress1"].ToString();
            //ewbGen.toAddr2 = ds.Tables[0].Rows[0]["DelieveryPartyAddress2"].ToString();
            //ewbGen.toPlace = ds.Tables[0].Rows[0]["DebitPartyCity"].ToString();
            //ewbGen.toPincode = Convert.ToInt32(ds.Tables[0].Rows[0]["DebitPartyZipCode"]);
            //ewbGen.toStateCode = Convert.ToInt32(ds.Tables[0].Rows[0]["AccGSTNo"].ToString().Substring(0, 2));
            //ewbGen.actToStateCode = Convert.ToInt32(ds.Tables[0].Rows[0]["AccGSTNo"].ToString().Substring(0, 2));
            //ewbGen.transactionType = 1;
            //ewbGen.dispatchFromGSTIN = "";
            //ewbGen.dispatchFromTradeName = GlobalVariables.CompanyName;
            //ewbGen.shipToGSTIN = ds.Tables[0].Rows[0]["AccGSTNo"].ToString();
            //ewbGen.shipToTradeName = ds.Tables[0].Rows[0]["DebitPartyName"].ToString();




            ewbGen.otherValue = Convert.ToDouble(ds.Tables[0].Rows[0]["SIMROFFAMT"]);
            // ewbGen.totalValue = Convert.ToDouble(ds.Tables[0].Rows[0]["SIMGRANDTOT"]);
            ewbGen.totalValue = Convert.ToDouble("0");
            ewbGen.cgstValue = Convert.ToDouble(ds.Tables[0].Rows[0]["CGSTAmount"]);
            ewbGen.sgstValue = Convert.ToDouble(ds.Tables[0].Rows[0]["SGSTAmount"]);
            ewbGen.igstValue = Convert.ToDouble(ds.Tables[0].Rows[0]["IGSTAmount"]);
            ewbGen.cessValue = Convert.ToDouble("0");
            ewbGen.cessNonAdvolValue = Convert.ToDouble("0");
            ewbGen.transporterId = string.Empty;
            ewbGen.transporterName = string.Empty;
            ewbGen.transDocNo = string.Empty;
            ewbGen.totInvValue = Convert.ToDouble(ds.Tables[0].Rows[0]["SIMGRANDTOT"]); ;
            ewbGen.transMode = "1";//1
            ewbGen.transDistance = "0"; /*1200*/
            ewbGen.transDocDate = string.Empty;
            ewbGen.vehicleNo = "PVC1234";
            ewbGen.vehicleType = "R";//R
            ewbGen.itemList = new List<ReqGenEwbPl.ItemListInReqEWBpl>();

            foreach (DataRow dr in ds.Tables[1].Rows)
            {
                ewbGen.itemList.Add(new ReqGenEwbPl.ItemListInReqEWBpl
                {
                    productName = dr["GrpSubDesc"].ToString(),
                    productDesc = dr["GrpSubDesc"].ToString(),
                    hsnCode = Convert.ToInt32(dr["GrpHSNCode"]),
                    quantity = Convert.ToDouble(dr["SIDSCANQTY"]),
                    qtyUnit = dr["UomDesc"].ToString(),
                    cgstRate = Convert.ToDouble(dr["SIDCGSTPRCN"]),
                    sgstRate = Convert.ToDouble(dr["SIDSGSTPRCN"]),
                    igstRate = Convert.ToDouble(dr["SIDIGSTPRCN"]),
                    cessRate = 0,
                    cessNonAdvol = 0,
                    taxableAmount = Convert.ToDouble(dr["SIDITMNETAMT"]),
                });

            }



            EWBSession EwbSession = new EWBSession();
            //calculation done
            EwbSession.EwbApiLoginDetails.EwbGstin = GlobalVariables.EWBGSTIN;
            EwbSession.EwbApiLoginDetails.EwbUserID = GlobalVariables.EWBUserID;
            EwbSession.EwbApiLoginDetails.EwbPassword = GlobalVariables.EWBPassword;
            EwbSession.EwbApiSetting.GSPName = GlobalVariables.GSPName;
            EwbSession.EwbApiSetting.AspPassword = GlobalVariables.ASPPassword;
            EwbSession.EwbApiSetting.AspUserId = GlobalVariables.ASPNetUser;
            EwbSession.EwbApiSetting.BaseUrl = GlobalVariables.BaseUrl;

            string a = JsonConvert.SerializeObject(ewbGen);
            TxnRespWithObjAndInfo<RespGenEwbPl> TxnResp = await EWBAPI.GenEWBAsync(EwbSession, ewbGen);
            if (TxnResp.IsSuccess)
            {
                XtraMessageBox.Show(JsonConvert.SerializeObject(TxnResp.RespObj));

                TextEdit t = new TextEdit();
                t.Text = JsonConvert.SerializeObject(TxnResp.RespObj);

                var details = JObject.Parse(t.Text);

                ProjectFunctions.GetDataSet("update SALEINVMAIN Set SIMTRDPRMWYBLNO='" + details["ewayBillNo"].ToString() + "'  where SIMNO='" + BillNo + "' And SIMDATE='" + BillDate.Date.ToString("yyyy-MM-dd") + "' and SIMSERIES='GST' and UnitCode='" + GlobalVariables.CUnitID + "'");
            }
            else
            {

                XtraMessageBox.Show(TxnResp.TxnOutcome);
                //Check for error "The distance between the pincodes given is too high"



                if (TxnResp.TxnOutcome.Contains("702") && !string.IsNullOrEmpty(TxnResp.Info))
                {
                    RespInfoPl respInfoPl = new RespInfoPl();

                    respInfoPl = JsonConvert.DeserializeObject<RespInfoPl>(TxnResp.Info);
                    //You can retrive respInfoPl attributes here
                    ewbGen.transDistance = respInfoPl.distance;
                    //Call GenEWB API again
                    TxnResp = await EWBAPI.GenEWBAsync(EwbSession, ewbGen);
                    if (TxnResp.IsSuccess)
                    {


                        //String EWauBillNo= details[""]


                        XtraMessageBox.Show(JsonConvert.SerializeObject(TxnResp.RespObj));
                    }
                    else
                        XtraMessageBox.Show(TxnResp.TxnOutcome);
                }

            }


            // XtraMessageBox.Show("Generate e-Way Bill Responce");




        }
        public static void PrintDocument(string DocNo, DateTime DocDate, string DocType, DevExpress.XtraReports.UI.XtraReport Report)
        {
            try

            {
                DataSet ds = ProjectFunctions.GetDataSet(" sp_DocPrint '" + DocNo + "','" + Convert.ToDateTime(DocDate).Date.ToString("yyyy-MM-dd") + "','" + DocType + "','" + GlobalVariables.CUnitID + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ds.WriteXmlSchema("C://Temp//abc.xml");
                    Report.DataSource = ds;
                    foreach (XRSubreport sub in Report.AllControls<XRSubreport>())
                    {
                        sub.ReportSource.DataSource = ds;
                    }
                    Report.CreateDocument();



                    if (GlobalVariables.ProgCode == "PROG132")
                    {
                        Report.ExportToPdf("C:\\Application\\CashMemo.pdf");
                        SendToDirectPrint("C:\\Application\\CashMemo.pdf");
                    }

                    else
                    {

                        payroll.FormReports.PrintReportViewer frm = new payroll.FormReports.PrintReportViewer();
                        frm.documentViewer1.DocumentSource = Report;

                        if (ds.Tables[0].Rows[0]["SIMTRDPRMWYBLNO"].ToString().Trim().Length < 10 && DocType == "GST" && Convert.ToDecimal(ds.Tables[0].Rows[0]["SIMGRANDTOT"]) >= 50000)
                        {
                            if (ds.Tables[0].Rows[0]["AccGSTNo"].ToString().Trim().Length < 10)
                            {
                                ProjectFunctions.SpeakError("Kindly Update GST No First");

                            }
                            frm.documentViewer1.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.Print, DevExpress.XtraPrinting.CommandVisibility.None);
                            frm.documentViewer1.PrintingSystem.SetCommandVisibility(DevExpress.XtraPrinting.PrintingSystemCommand.PrintDirect, DevExpress.XtraPrinting.CommandVisibility.None);
                        }


                        frm.ShowDialog();
                        frm.documentViewer1.PrintingSystem.ExportToPdf("C:\\Temp\\" + "GST\\" + DocNo + ".pdf");

                        ///////////mobile number from fetch
                        SendBillImageAsync("  ");
                    }



                }
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void PrintPDFDocument(string DocNo, DateTime DocDate, string DocType, DevExpress.XtraReports.UI.XtraReport Report)
        {
            try

            {
                DataSet ds = ProjectFunctions.GetDataSet(" sp_DocPrint '" + DocNo + "','" + Convert.ToDateTime(DocDate).Date.ToString("yyyy-MM-dd") + "','" + DocType + "','" + GlobalVariables.CUnitID + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ds.WriteXmlSchema("C://Temp//abc.xml");
                    Report.DataSource = ds;
                    foreach (XRSubreport sub in Report.AllControls<XRSubreport>())
                    {
                        sub.ReportSource.DataSource = ds;
                    }
                    Report.CreateDocument();
                    //Report.ExportToPdf("C:\\Application\\CashMemo.pdf");



                    Report.ExportToPdf("C:\\Application\\" + ds.Tables[0].Rows[0]["FileName"].ToString() + ".pdf");
                }
            }

            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

        }
        public static void CRPrintDocument(string DocNo, DateTime DocDate, string DocType, DevExpress.XtraReports.UI.XtraReport Report)
        {
            try

            {
                DataSet ds = ProjectFunctions.GetDataSet(" [sp_CRPrint] '" + DocNo + "','" + Convert.ToDateTime(DocDate).Date.ToString("yyyy-MM-dd") + "','" + DocType + "','" + GlobalVariables.CUnitID + "'");
                if (ds.Tables[0].Rows.Count > 0)
                {
                    ds.WriteXmlSchema("C://Temp//abc.xml");
                    Report.DataSource = ds;
                    foreach (XRSubreport sub in Report.AllControls<XRSubreport>())
                    {
                        sub.ReportSource.DataSource = ds;
                    }
                    Report.CreateDocument();

                    payroll.FormReports.PrintReportViewer frm = new payroll.FormReports.PrintReportViewer();
                    frm.documentViewer1.DocumentSource = Report;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }



        public static void TimePickerVisualize(Control C)
        {
            foreach (Control c in C.Controls)
            {
                if (c.GetType() == typeof(TimeEdit))
                {
                    var thiscontrol = (TimeEdit)c;
                    thiscontrol.EditValue = null;
                    thiscontrol.EnterMoveNextControl = true;
                    thiscontrol.Properties.Mask.BeepOnError = true;
                    thiscontrol.Properties.Mask.EditMask = "HH:mm:ss";
                    thiscontrol.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
                    thiscontrol.Properties.Mask.UseMaskAsDisplayFormat = true;
                    thiscontrol.Properties.Appearance.BorderColor = Color.FromArgb(224, 224, 224);
                    thiscontrol.Properties.Appearance.Options.UseBorderColor = true;
                    thiscontrol.Properties.AppearanceFocused.BackColor = Color.AliceBlue;
                    thiscontrol.Properties.AppearanceFocused.BorderColor = Color.FromArgb(0x15, 0x60, 0xA9);
                    thiscontrol.Properties.AppearanceDisabled.BackColor = Color.Bisque;
                    thiscontrol.Properties.AppearanceDisabled.Options.UseBackColor = true;
                    thiscontrol.Properties.AppearanceDisabled.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    thiscontrol.Properties.AppearanceFocused.Options.UseBackColor = true;
                    thiscontrol.Properties.AppearanceFocused.Options.UseBorderColor = true;
                    thiscontrol.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                    thiscontrol.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
                    thiscontrol.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
                    thiscontrol.Enter += (o, e) =>
                    {
                        thiscontrol.SelectAll();
                    };
                }
            }
        }

        public static void TimeSpanVisualize(Control C)
        {
            foreach (Control c in C.Controls)
            {
                if (c.GetType() == typeof(TimeSpanEdit))
                {
                    var thiscontrol = (TimeSpanEdit)c;
                    thiscontrol.EditValue = null;
                    thiscontrol.EnterMoveNextControl = true;
                    thiscontrol.Properties.Mask.BeepOnError = true;
                    thiscontrol.Properties.Mask.EditMask = "HH:mm";
                    thiscontrol.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
                    thiscontrol.Properties.Mask.UseMaskAsDisplayFormat = true;
                    thiscontrol.Properties.Appearance.BorderColor = Color.FromArgb(224, 224, 224);
                    thiscontrol.Properties.Appearance.Options.UseBorderColor = true;
                    thiscontrol.Properties.AppearanceFocused.BackColor = Color.AliceBlue;
                    thiscontrol.Properties.AppearanceFocused.BorderColor = Color.FromArgb(0x15, 0x60, 0xA9);
                    thiscontrol.Properties.AppearanceDisabled.BackColor = Color.Bisque;
                    thiscontrol.Properties.AppearanceDisabled.Options.UseBackColor = true;
                    thiscontrol.Properties.AppearanceDisabled.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    thiscontrol.Properties.AppearanceFocused.Options.UseBackColor = true;
                    thiscontrol.Properties.AppearanceFocused.Options.UseBorderColor = true;
                    thiscontrol.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                    thiscontrol.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
                    thiscontrol.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
                    thiscontrol.Enter += (o, e) =>
                    {
                        thiscontrol.SelectAll();
                    };
                }
            }
        }
        public static void DatePickerVisualize(Control C)
        {
            foreach (Control c in C.Controls)
            {
                if (c.GetType() == typeof(DateEdit))
                {
                    var thiscontrol = (DateEdit)c;
                    thiscontrol.EditValue = null;
                    thiscontrol.EnterMoveNextControl = true;
                    thiscontrol.Properties.Mask.BeepOnError = true;
                    thiscontrol.Properties.Mask.EditMask = "dd/MM/yyyy";
                    thiscontrol.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
                    thiscontrol.Properties.Mask.UseMaskAsDisplayFormat = true;
                    thiscontrol.Properties.Appearance.BorderColor = Color.FromArgb(224, 224, 224);
                    thiscontrol.Properties.Appearance.Options.UseBorderColor = true;
                    thiscontrol.Properties.AppearanceFocused.BackColor = Color.AliceBlue;
                    thiscontrol.Properties.AppearanceFocused.BorderColor = Color.FromArgb(0x15, 0x60, 0xA9);
                    thiscontrol.Properties.AppearanceDisabled.BackColor = Color.Bisque;
                    thiscontrol.Properties.AppearanceDisabled.Options.UseBackColor = true;
                    thiscontrol.Properties.AppearanceDisabled.Font = new Font("Segoe UI", 8.5F, FontStyle.Bold, GraphicsUnit.Point, 0);
                    thiscontrol.Properties.AppearanceFocused.Options.UseBackColor = true;
                    thiscontrol.Properties.AppearanceFocused.Options.UseBorderColor = true;
                    thiscontrol.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
                    thiscontrol.Properties.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat;
                    thiscontrol.Properties.LookAndFeel.UseDefaultLookAndFeel = false;
                    thiscontrol.Enter += (o, e) =>
                    {
                        thiscontrol.SelectAll();
                    };
                }
            }
        }

    }
}