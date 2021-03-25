using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using TaxProEInvoice.API;

namespace TaxProEinvoiceApiIntigrationDemo.NET
{
    public partial class Form1 : Form
    {
        string WorkingFilesPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        //====================== IMPORTANT NOTE ON WORKING OF eInvoiceSession AND IT'S DEFAULT PARAMATERS  ============================================
        //eInvoiceSession object has two main settings objects eInvoiceAPISetting and eInvoiceAPILoginDetails, and some more public properties
        //Default constructor of eInvoiceSession uses json config files to store eInvoiceAPISetting and eInvoiceAPILoginDetails
        //eInvoiceSession constructor has 2 paramaters viz.LoadAPISettingsFromConfigFile and LoadAPILoginDetailsFromConfigFile with default value as True.
        //Thus paramaterless constructor below assums that ASP wants to use config file to store eInvoiceAPISetting and eInvoiceAPILoginDetails
        //in default case, the TaxProEInvoice.API library will take care of storing AuthToken and Expiary of authtoken internally in json config files.
        //Getting AuthToken, if null or expired, and storing in eInvoiceAPILoginDetails is concealed calls handled by library.
        //In case ASP needs to change store for eInvoiceAPISetting and eInvoiceAPILoginDetails, pleae refer to "Handling Multiple Taxpayers" section of eWay Bill API Users Guide
        //We have also dipicted the same in EWB Integration DEMO Project. Refer to TPEWBSession (TaxPayer EWBSession created by injecting TaxPayerID or say Co. ID)

        eInvoiceSession eInvSession = new eInvoiceSession(true,true);

        //IMPORTANT: If you are not storing eInvSession settings in json file and loading it yourself
        //Please handle event RefreshAuthTokenCompleted of above eInvSession object
        //eInvoiceSession.RefreshAuthTokenCompleted += MyMethodToSaveNewRefreshedAuthTokenAndSEK
        //The same has been shown in class TPEWBSession in EWB Integration DEMO project.
        //Just rename from TPEWBSession to TPeInvoiceSession and respective renames.

        public Form1()
        {
            //for .Net framework 4.5
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;
            InitializeComponent();
            loadApiSetting();
            loadApiLoginDetail();
            eInvSession.RefreshAuthTokenCompleted += RefreshLoginDetailsDisplay;
        }
        private void RefreshLoginDetailsDisplay(object sender, EventArgs e)
        {
            DisplayLoginDetail();
        }
        private void DisplayLoginDetail()
        {
            txtUserName.Text = eInvSession.eInvApiLoginDetails.UserName;
            txtPassword.Text = eInvSession.eInvApiLoginDetails.Password;
            txtGstin.Text = eInvSession.eInvApiLoginDetails.GSTIN;
            txtAppKey.Text = eInvSession.eInvApiLoginDetails.AppKey;
            txtAuthToken.Text = eInvSession.eInvApiLoginDetails.AuthToken;
            txtSek.Text = eInvSession.eInvApiLoginDetails.Sek;
            txtTokenExp.Text = eInvSession.eInvApiLoginDetails.E_InvoiceTokenExp.ToString();
        }
        private void btnApiSetting_Click(object sender, EventArgs e)
        {
            try
            {
                eInvSession.eInvApiSetting = new eInvoiceAPISetting();
                eInvSession.eInvApiSetting.GSPName = txtGspName.Text;
                eInvSession.eInvApiSetting.AspUserId = txtAspUserId.Text;
                eInvSession.eInvApiSetting.AspPassword = txtAspPassword.Text;
                eInvSession.eInvApiSetting.client_id = txtClientId.Text;
                eInvSession.eInvApiSetting.client_secret = txtClientSecret.Text;
                eInvSession.eInvApiSetting.AuthUrl = txtAuthUrl.Text;
                eInvSession.eInvApiSetting.BaseUrl = txtBaseUrl.Text;
                eInvSession.eInvApiSetting.EwbByIRN  = txtEwbBaseUrl.Text;
                eInvSession.eInvApiSetting.CancelEwbUrl = txtCancelEWB.Text;
                Shared.SaveAPISetting(eInvSession.eInvApiSetting);
                MessageBox.Show("API Setting saved successfully...");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnSaveLoginDetails_Click(object sender, EventArgs e)
        {
            try
            {
                eInvSession.eInvApiLoginDetails = new eInvoiceAPILoginDetails();
                eInvSession.eInvApiLoginDetails.UserName = txtUserName.Text;
                eInvSession.eInvApiLoginDetails.Password = txtPassword.Text;
                eInvSession.eInvApiLoginDetails.GSTIN = txtGstin.Text;
                eInvSession.eInvApiLoginDetails.AppKey = txtAppKey.Text;
                eInvSession.eInvApiLoginDetails.AuthToken = txtAuthToken.Text;
                eInvSession.eInvApiLoginDetails.Sek = txtSek.Text;
                eInvSession.eInvApiLoginDetails.E_InvoiceTokenExp = Convert.ToDateTime(txtTokenExp.Text);
                Shared.SaveAPILoginDetails(eInvSession.eInvApiLoginDetails);
                MessageBox.Show("API Login Details saved successfully...");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadApiSetting()
        {
            txtGspName.Text = eInvSession.eInvApiSetting.GSPName;
            txtAspUserId.Text = eInvSession.eInvApiSetting.AspUserId;
            txtAspPassword.Text = eInvSession.eInvApiSetting.AspPassword;
            txtClientId.Text = eInvSession.eInvApiSetting.client_id;
            txtClientSecret.Text = eInvSession.eInvApiSetting.client_secret;
            txtAuthUrl.Text = eInvSession.eInvApiSetting.AuthUrl;
            txtBaseUrl.Text = eInvSession.eInvApiSetting.BaseUrl;
            txtEwbBaseUrl.Text = eInvSession.eInvApiSetting.EwbByIRN;
            txtCancelEWB.Text = eInvSession.eInvApiSetting.CancelEwbUrl;
        }
        public void loadApiLoginDetail()
        {
            txtUserName.Text = eInvSession.eInvApiLoginDetails.UserName;
            txtPassword.Text = eInvSession.eInvApiLoginDetails.Password;
            txtGstin.Text = eInvSession.eInvApiLoginDetails.GSTIN;
            txtAppKey.Text = eInvSession.eInvApiLoginDetails.AppKey;
            txtAuthToken.Text = eInvSession.eInvApiLoginDetails.AuthToken;
            txtSek.Text = eInvSession.eInvApiLoginDetails.Sek;
            txtTokenExp.Text = eInvSession.eInvApiLoginDetails.E_InvoiceTokenExp?.ToString("yyyy-MM-dd HH:mm:ss");
        }
        private async void btnAuthToken_Click(object sender, EventArgs e)
        {
            TxnRespWithObj<eInvoiceSession> txnRespWithObj = await eInvoiceAPI.GetAuthTokenAsync(eInvSession);
            if (txnRespWithObj.IsSuccess)
            {
                DisplayLoginDetail();
                //rtbResponce.Text = JsonConvert.SerializeObject(rtbResponce.Text);
            }
            txtResponceHdr.Text = "Auth Api Responce";
            rtbResponce.Text = txnRespWithObj.TxnOutcome;
        }
        private async void btnGenIRN_Click(object sender, EventArgs e)
        {

            ReqPlGenIRN reqPlGenIRN = new ReqPlGenIRN();
            //reqPlGenIRN.Version = "1.01";
            //reqPlGenIRN.TranDtls = new ReqPlGenIRN.TranDetails();
            //reqPlGenIRN.TranDtls.TaxSch = "GST";
            //reqPlGenIRN.TranDtls.SupTyp = "B2B";
            //reqPlGenIRN.DocDtls = new ReqPlGenIRN.DocSetails();
            //reqPlGenIRN.DocDtls.Typ = "INV";
            //reqPlGenIRN.DocDtls.No = "DOC-NO/64";
            //reqPlGenIRN.DocDtls.Dt = "11/03/2020";
            //reqPlGenIRN.SellerDtls = new ReqPlGenIRN.SellerDetails();
            //reqPlGenIRN.SellerDtls.Gstin = "************";
            //reqPlGenIRN.SellerDtls.LglNm = "ABC company pvt ltd";
            //reqPlGenIRN.SellerDtls.TrdNm = null;
            //reqPlGenIRN.SellerDtls.Addr1 = "5th block, kuvempu layout";
            //reqPlGenIRN.SellerDtls.Addr2 = null;
            //reqPlGenIRN.SellerDtls.Loc = "GANDHINAGAR";
            //reqPlGenIRN.SellerDtls.Pin = "560002";
            //reqPlGenIRN.SellerDtls.State = "KARNATAKA";
            //reqPlGenIRN.SellerDtls.Ph = null;
            //reqPlGenIRN.SellerDtls.Em = null;
            //reqPlGenIRN.BuyerDtls = new ReqPlGenIRN.BuyerDetails();
            //reqPlGenIRN.BuyerDtls.Gstin = "37BZNPM9430M1kl";
            //reqPlGenIRN.BuyerDtls.LglNm = "XYZ company pvt ltd";
            //reqPlGenIRN.BuyerDtls.TrdNm = null;
            //reqPlGenIRN.BuyerDtls.Pos = "37";
            //reqPlGenIRN.BuyerDtls.Addr1 = "7th block, kuvempu layout";
            //reqPlGenIRN.BuyerDtls.Addr2 = null;
            //reqPlGenIRN.BuyerDtls.Loc = "GANDHINAGAR";
            //reqPlGenIRN.BuyerDtls.Pin = null;
            //reqPlGenIRN.BuyerDtls.State = null;
            //reqPlGenIRN.BuyerDtls.Ph = null;
            //reqPlGenIRN.BuyerDtls.Em = null;
            //reqPlGenIRN.DispDtls = new ReqPlGenIRN.DispatchedDetails();
            //reqPlGenIRN.DispDtls.Nm = "ABC company pvt ltd";
            //reqPlGenIRN.DispDtls.Addr1 = "7th block, kuvempu layout";
            //reqPlGenIRN.DispDtls.Addr2 = null;
            //reqPlGenIRN.DispDtls.Loc = "Banagalore";
            //reqPlGenIRN.DispDtls.Pin = "560043";
            //reqPlGenIRN.DispDtls.Stcd = "29";
            //reqPlGenIRN.ShipDtls = new ReqPlGenIRN.ShippedDetails();
            //reqPlGenIRN.ShipDtls.Gstin = null;
            //reqPlGenIRN.ShipDtls.LglNm = "CBE company pvt ltd";
            //reqPlGenIRN.ShipDtls.TrdNm = null;
            //reqPlGenIRN.ShipDtls.Addr1 = "7th block, kuvempu layout";
            //reqPlGenIRN.ShipDtls.Addr2 = null;
            //reqPlGenIRN.ShipDtls.Loc = "Banagalore";
            //reqPlGenIRN.ShipDtls.Pin = "560043";
            //reqPlGenIRN.ShipDtls.Stcd = "29";
            //reqPlGenIRN.ItemList = new List<ReqPlGenIRN.ItmList>();
            //ReqPlGenIRN.ItmList itm = new ReqPlGenIRN.ItmList();
            //itm.SlNo = "1";
            //itm.IsServc = "N";
            //itm.PrdDesc = null;
            //itm.HsnCd = "1001";
            //itm.BchDtls = null;
            //itm.Qty = null;
            //itm.Unit = null;
            //itm.UnitPrice = 10.00;
            //itm.TotAmt = 10.00;
            //itm.Discount = 0.0;
            //itm.AssAmt = 10.00;
            //itm.GstRt = 10.00;
            //itm.SgstAmt = 0.0;
            //itm.IgstAmt = 0.0;
            //itm.CgstAmt = 0.0;
            //itm.CesRt = 0.0;
            //itm.CesAmt = 0.0;
            //itm.CesNonAdvlAmt = 0.0;
            //itm.StateCesRt = 0.0;
            //itm.StateCesAmt = 0.0;
            //itm.StateCesNonAdvlAmt = 0.0;
            //itm.OthChrg = 0.0;
            //itm.TotItemVal = 10.00;
            //itm.AttribDtls = null;
            //reqPlGenIRN.ItemList.Add(itm);
            //reqPlGenIRN.PayDtls = null;
            //reqPlGenIRN.RefDtls = null;
            //reqPlGenIRN.AddlDocDtls = null;
            //reqPlGenIRN.ExpDtls = null;
            //reqPlGenIRN.EwbDtls = null;
            //reqPlGenIRN.ValDtls = new ReqPlGenIRN.ValDetails();
            //reqPlGenIRN.ValDtls.AssVal = 0.0;
            //reqPlGenIRN.ValDtls.CgstVal = 0.0;
            //reqPlGenIRN.ValDtls.SgstVal = 0.0;
            //reqPlGenIRN.ValDtls.IgstVal = 0.0;
            //reqPlGenIRN.ValDtls.CesVal = 0.0;
            //reqPlGenIRN.ValDtls.StCesVal = 0.0;
            //reqPlGenIRN.ValDtls.RndOffAmt = 0.0;
            //reqPlGenIRN.ValDtls.TotInvVal = 0.0;

            //TxnRespWithObj<RespPlGenIRN> txnRespWithObj = await eInvoiceAPI.GenIRNAsync(eInvSession, reqPlGenIRN);



            //PayLoad in Json Format reading file Json.
            //string ReqJson = File.ReadAllText(WorkingFilesPath + @"\ProductionSampleJsonGenIRN.txt");
            //TxnRespWithObj<RespPlGenIRN> txnRespWithObj = await eInvoiceAPI.GenIRNAsync(eInvSession, ReqJson, 250);

            string ReqJson = File.ReadAllText(txtResponceHdr.Text);



            TxnRespWithObj<RespPlGenIRN> txnRespWithObj = await eInvoiceAPI.GenIRNAsync(eInvSession, rtbResponce.Text, 250);

            RespPlGenIRN respPlGenIRN = txnRespWithObj.RespObj;
            string ErrorCodes = "";
            string ErrorDesc = "";
            rtbResponce.Text = "";
            if (txnRespWithObj.IsSuccess)
            {
                //Process the Response here
                //For DEMO, just showing the searilized Response Object in text box
                rtbResponce.Text = JsonConvert.SerializeObject(respPlGenIRN);
                //respPlGenIRN.QrCodeImage.Save(@"C:\Users\Desktop\qr1.png");

                //Store respPlGenIRN (manditory - AckDate and SignedInvoice) to verify signed invoice
                //below code is to show how to verify signed invoice
                respPlGenIRN.QrCodeImage = null;
                TxnRespWithObj<VerifyRespPl> txnRespWithObj1 = await eInvoiceAPI.VerifySignedInvoice(eInvSession, respPlGenIRN);


                VerifyRespPl verifyRespPl = new VerifyRespPl();
                if (txnRespWithObj.IsSuccess)
                {
                    verifyRespPl.IsVerified = txnRespWithObj1.RespObj.IsVerified;
                    verifyRespPl.JwtIssuerIRP = txnRespWithObj1.RespObj.JwtIssuerIRP;
                    verifyRespPl.VerifiedWithCertificateEffectiveFrom = txnRespWithObj1.RespObj.VerifiedWithCertificateEffectiveFrom;
                    verifyRespPl.CertificateName = txnRespWithObj1.RespObj.CertificateName;
                    verifyRespPl.CertStartDate = txnRespWithObj1.RespObj.CertStartDate;
                    verifyRespPl.CertExpiryDate = txnRespWithObj1.RespObj.CertExpiryDate;
                }

            }
            else
            {
                //Error has occured
                //Display TxnOutCome in text box - process or show msg to user

                //Process error codes
                if (txnRespWithObj.ErrorDetails != null) {
                    foreach (RespErrDetailsPl errPl in txnRespWithObj.ErrorDetails)
                    {
                        //Process errPl item here
                        ErrorCodes += errPl.ErrorCode + ",";
                        ErrorDesc += errPl.ErrorCode + ": " + errPl.ErrorMessage + Environment.NewLine;
                        rtbResponce.Text = ErrorDesc;
                    }
                }
               
                //Process InfoDetails here
                RespInfoDtlsPl respInfoDtlsPl = new RespInfoDtlsPl();
                //Serialize Desc object from InfoDtls as per InfCd
                if (txnRespWithObj.InfoDetails != null)
                {
                    foreach (RespInfoDtlsPl infoPl in txnRespWithObj.InfoDetails)
                    {
                        var strDupIrnPl = JsonConvert.SerializeObject(infoPl.Desc);   //Convert object type to json string
                        switch (infoPl.InfCd)
                        {
                            case "DUPIRN":
                                DupIrnPl dupIrnPl = JsonConvert.DeserializeObject<DupIrnPl>(strDupIrnPl); 
                                break;
                            case "EWBERR":
                                List<EwbErrPl> ewbErrPl = JsonConvert.DeserializeObject<List<EwbErrPl>>(strDupIrnPl);
                                break;
                            case "ADDNLNFO":
                                //Deserialize infoPl.Desc as string type and then if this string contains json object, it may be desirilized again as per future releases
                                string strDesc = (string)infoPl.Desc;
                                break;
                        }
                    }
                }
            }
            txtResponceHdr.Text = "Generate IRN Responce...";
        }

        private async void btnVerifySignedInv_Click(object sender, EventArgs e)
        {
            string RespJson = File.ReadAllText(WorkingFilesPath + @"\RespPlGenIRN.txt");
            VerifyRespPl verifyRespPl = new VerifyRespPl();

            RespPlGenIRN respPlGenIRN = new RespPlGenIRN();
            respPlGenIRN = JsonConvert.DeserializeObject<RespPlGenIRN>(RespJson);
            TxnRespWithObj<VerifyRespPl> txnRespWithObj = await eInvoiceAPI.VerifySignedInvoice(eInvSession, respPlGenIRN);

            if (txnRespWithObj.IsSuccess)
            {
                verifyRespPl.IsVerified = txnRespWithObj.RespObj.IsVerified;
                verifyRespPl.JwtIssuerIRP = txnRespWithObj.RespObj.JwtIssuerIRP;
                verifyRespPl.VerifiedWithCertificateEffectiveFrom = txnRespWithObj.RespObj.VerifiedWithCertificateEffectiveFrom;
                verifyRespPl.CertificateName = txnRespWithObj.RespObj.CertificateName;
                verifyRespPl.CertStartDate = txnRespWithObj.RespObj.CertStartDate;
                verifyRespPl.CertExpiryDate = txnRespWithObj.RespObj.CertExpiryDate;
            }
            else
            {
                verifyRespPl = txnRespWithObj.RespObj;

            }
        }
        private async void btnGetEDetails_Click(object sender, EventArgs e)
        {
            string IrnNo = "745df0b4855ee4afb167152bb9d4c4879c496988892027f51fc5bf14be6fc02e";
            TxnRespWithObj<RespPlGenIRN> txnRespWithObj = await eInvoiceAPI.GetEInvDetailsAsync(eInvSession, IrnNo);
            if (txnRespWithObj.IsSuccess)
            {
                rtbResponce.Text = JsonConvert.SerializeObject(txnRespWithObj.RespObj);
            }
            else
                rtbResponce.Text = txnRespWithObj.TxnOutcome;
            txtResponceHdr.Text = "Get IRN Detail Responce...";
        }
     

        private async void btnGSTINDet_Click(object sender, EventArgs e)
        {
            string GSTIN = "************";
            TxnRespWithObj<RespPlGetGSTIN> txnRespWithObj = await eInvoiceAPI.GetGSTINDetailsAsync(eInvSession, GSTIN);
            if (txnRespWithObj.IsSuccess)
            {
                rtbResponce.Text = JsonConvert.SerializeObject(txnRespWithObj.RespObj);
            }
            else
                rtbResponce.Text = txnRespWithObj.TxnOutcome;

            txtResponceHdr.Text = "Get GSTIN Detail Responce...";
        }

        private async void btnCancelIRN_Click(object sender, EventArgs e)
        {
            ReqPlCancelIRN reqPlCancelIRN = new ReqPlCancelIRN();
            reqPlCancelIRN.CnlRem = "Data Entry Mystake";
            reqPlCancelIRN.CnlRsn = "2";
            reqPlCancelIRN.Irn = "87463ea6314450564f9325083bcbd7c47509a864908b130c15270794e707f907";
            TxnRespWithObj<RespPlCancelIRN> txnRespWithObj = await eInvoiceAPI.CancelIRNIRNAsync(eInvSession, reqPlCancelIRN);

            if (txnRespWithObj.IsSuccess)
            {
                rtbResponce.Text = JsonConvert.SerializeObject(txnRespWithObj.RespObj);
            }
            else
                rtbResponce.Text = txnRespWithObj.TxnOutcome;

            txtResponceHdr.Text = "Generate IRN Responce...";
        }

        private async void btnGetEDetailbyAck_Click(object sender, EventArgs e)
        {
            //long AckNo = 21100000187;
            //TxnRespWithObj<RespPlGetIRNByAck> txnRespWithObj = await eInvoiceAPI.GetEInvDetailsByAckAsync(eInvSession, AckNo);
            //if (txnRespWithObj.IsSuccess)
            //{
            //    rtbResponce.Text = JsonConvert.SerializeObject(txnRespWithObj.RespObj);
            //}
            //else
            //    rtbResponce.Text = txnRespWithObj.TxnOutcome;
            //txtResponceHdr.Text = "Get IRN Detail Responce by Ack...";
        }



        

        private async void btnDecryptedAuthToken_Click(object sender, EventArgs e)
        {
            //RestClient client = new RestClient("http://testapi.taxprogsp.co.in/eivital/dec/v1.03/auth?aspid=1234568817&password=$RadhaMadhav1&Gstin=29AACCC1596Q000&Username=TaxProEnvSB&eInvPwd=abcd1234*");
            RestClient client = new RestClient("https://api.taxprogsp.co.in/eivital/dec/v1.03/auth?aspid=1234568817&password=$RadhaMadhav1&Gstin=27AACCC1596Q1Z2&Username=CHARTEREDINFO_7&eInvPwd=*88Taxpro");

            RestRequest request = new RestRequest(Method.GET);

            request.AddHeader("Gstin", "27AACCC1596Q1Z2");
            //request.AddHeader("Gstin", "*****");
            request.AddHeader("user_name", "CHARTEREDINFO_7");
            //request.AddHeader("user_name", "****");
            request.AddHeader("aspid", "1234568817");
            request.AddHeader("password", "$RadhaMadhav1");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.RequestFormat = DataFormat.Json;

            IRestResponse response = await client.ExecuteTaskAsync(request);
            rtbResponce.Text = response.Content;
        }

        private async void btnDecGenIRN_Click(object sender, EventArgs e)
        {
            //string strJson = File.ReadAllText(WorkingFilesPath + @"\SandBoxSampleJsonGenIRN.txt");
            string strJson = File.ReadAllText(WorkingFilesPath + @"\ProductionSampleJsonGenIRN.txt");
            RestClient client = new RestClient("https://api.taxprogsp.co.in/eicore/dec/v1.03/Invoice?aspid=************&password=************&Gstin=************&AuthToken=jSNGkXqh8RshEAf91CAFMMdcp&user_name=************&QrCodeSize=250");
            //RestClient client = new RestClient("http://testapi.taxprogsp.co.in/eicore/dec/v1.03/Invoice?aspid=************&password=************&Gstin=************&AuthToken=7wTMc7VccewQSqraD46qz2lCd&user_name=************&QrCodeSize=150");

            RestRequest request = new RestRequest(Method.POST);
            request.AddHeader("Gstin", "************");
            request.AddHeader("user_name", "************");

            //request.AddHeader("Gstin", "************");
            //request.AddHeader("user_name", "************");
            request.AddHeader("AuthToken", "jSNGkXqh8RshEAf91CAFMMdcp");
            request.AddHeader("aspid", "************");
            request.AddHeader("password", "************");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.RequestFormat = DataFormat.Json;
            //ReqPlGenIRN reqPlGenIRN = new ReqPlGenIRN();
            //reqPlGenIRN = JsonConvert.DeserializeObject<ReqPlGenIRN>(strJson);
            //request.AddBody(reqPlGenIRN);
            request.AddParameter("application/json", strJson, ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteTaskAsync(request);

            RespPl respPl = new RespPl();
            respPl = JsonConvert.DeserializeObject<RespPl>(response.Content);

            RespPlGenIRNDec respPlGenIRNDec = new RespPlGenIRNDec();
            respPlGenIRNDec = JsonConvert.DeserializeObject<RespPlGenIRNDec>(respPl.Data);
            rtbResponce.Text = respPlGenIRNDec.Irn;

            byte[] qrImg = Convert.FromBase64String(respPlGenIRNDec.QrCodeImage);
            TypeConverter tc = TypeDescriptor.GetConverter(typeof(Bitmap));
            Bitmap bitmap1 = (Bitmap)tc.ConvertFrom(qrImg);


            bitmap1.Save(WorkingFilesPath + @"\qr.png");
        }

        private void btnDecCancelIRN_Click(object sender, EventArgs e)
        {

        }

        private async void btnGetEinvDetailByDec_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient("http://testapi.taxprogsp.co.in/gstcore/dec/v1.01/Invoice/irn/b27676323d37f357c02495580677d434be958a77870b7b5636d6d551c479818b?aspid=******&password=******&Gstin=************&AuthToken=fBM4dCRuLSrMI8SwyR1kYm0Mc&user_name=************");
            RestRequest request = new RestRequest(Method.GET);
            request.AddHeader("Gstin", "************");
            request.AddHeader("user_name", "************");
            request.AddHeader("AuthToken", "fBM4dCRuLSrMI8SwyR1kYm0Mc");
            request.AddHeader("aspid", "******");
            request.AddHeader("password", "*******");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.RequestFormat = DataFormat.Json;
            IRestResponse response = await client.ExecuteTaskAsync(request);
            RespPl respPl = new RespPl();
            respPl = JsonConvert.DeserializeObject<RespPl>(response.Content);

            RespPlGenIRNDec respPlGenIRNDec = new RespPlGenIRNDec();
            respPlGenIRNDec = JsonConvert.DeserializeObject<RespPlGenIRNDec>(respPl.Data);
            rtbResponce.Text = JsonConvert.SerializeObject(respPlGenIRNDec);
        }

        private async void btnGenEWB_Click(object sender, EventArgs e)
        {
            //Generate Ewb By IRN
            ReqPlGenEwbByIRN reqPlGenEwbByIRN = new ReqPlGenEwbByIRN();
            reqPlGenEwbByIRN.Irn = "48004d31b8f2afd2bb660911fd58602753c069cfec3bca58eda300822ce0b540";
            reqPlGenEwbByIRN.TransId = "27AACFM5833D1ZH";//12AWGPV7107B1Z1
            reqPlGenEwbByIRN.TransMode = "3";
            reqPlGenEwbByIRN.TransDocNo = "DOC7";
            reqPlGenEwbByIRN.TransDocDt = "18/11/2020";//
            reqPlGenEwbByIRN.VehNo = "ka123458";// 
            reqPlGenEwbByIRN.Distance = 100;
            reqPlGenEwbByIRN.VehType = "R";//R
            reqPlGenEwbByIRN.TransName = "DFHGF";
            reqPlGenEwbByIRN.ExpShipDtls = new ExportShipDetails();
            reqPlGenEwbByIRN.ExpShipDtls.Addr1 = "7th block, kuvempu layout";
            reqPlGenEwbByIRN.ExpShipDtls.Addr2 = "kuvempu layout";
            reqPlGenEwbByIRN.ExpShipDtls.Loc = "Banagalore";
            reqPlGenEwbByIRN.ExpShipDtls.Pin = 562160;
            reqPlGenEwbByIRN.ExpShipDtls.Stcd = "29";
            reqPlGenEwbByIRN.DispDtls = new DispatchedDetails();
            reqPlGenEwbByIRN.DispDtls.Nm = "ABC company pvt ltd";
            reqPlGenEwbByIRN.DispDtls.Addr1 = "7th block, kuvempu layout";
            reqPlGenEwbByIRN.DispDtls.Addr2 = "kuvempu layout";
            reqPlGenEwbByIRN.DispDtls.Loc= "Banagalore";
            reqPlGenEwbByIRN.DispDtls.Pin = 562160;
            reqPlGenEwbByIRN.DispDtls.Stcd = "29";

            TxnRespWithObj<RespPlGenEwbByIRN> txnRespWithObj = await eInvoiceAPI.GenEwbByIRNAsync(eInvSession, reqPlGenEwbByIRN);
            string ErrorCodes = "";
            string ErrorDesc = "";
            rtbResponce.Text = "";
            if (txnRespWithObj.IsSuccess)
            {
                rtbResponce.Text = JsonConvert.SerializeObject(txnRespWithObj.RespObj);
            }
            else
            {
               // rtbResponce.Text = txnRespWithObj.TxnOutcome;
                if (txnRespWithObj.ErrorDetails != null)
                {
                    foreach (RespErrDetailsPl errPl in txnRespWithObj.ErrorDetails)
                    {
                        //Process errPl item here
                        ErrorCodes += errPl.ErrorCode + ",";
                        ErrorDesc += errPl.ErrorCode + ": " + errPl.ErrorMessage + Environment.NewLine;
                        rtbResponce.Text = ErrorDesc;
                    }
                }
            }
                

            txtResponceHdr.Text = "Generate IRN Responce...";


        }

        private async void btnDecGenEwbByIRN_Click(object sender, EventArgs e)
        {
            //string strJson = File.ReadAllText(WorkingFilesPath + @"\SampleJsonGenEwbByIRN.txt");

            ReqPlGenEwbByIRN reqPlGenEwbByIRN = new ReqPlGenEwbByIRN();
            reqPlGenEwbByIRN.Irn = "cc47964d094e5efa9813ca1f5d1822a67e55995c5800f979598dac8669ab5d51";
            reqPlGenEwbByIRN.TransId = "27AACFM5833D1ZH";//12AWGPV7107B1Z1
            reqPlGenEwbByIRN.TransMode = "1";
            reqPlGenEwbByIRN.TransDocNo = "DOC113";
            reqPlGenEwbByIRN.TransDocDt = "21/09/2020";//
            reqPlGenEwbByIRN.VehNo = "ka123458";// 
            reqPlGenEwbByIRN.Distance = 100;
            reqPlGenEwbByIRN.VehType = "R";//R
            reqPlGenEwbByIRN.TransName = "DFHGF";

           // RestClient client = new RestClient("https://api.taxprogsp.co.in/eiewb/dec/v1.03/ewaybill?aspid=************&password=************&Gstin=************&AuthToken=sxvB4Ocu1kikcSuu4dwDE75RN&user_name=************");
            RestClient client = new RestClient("https://api.taxprogsp.co.in/eiewb/dec/v1.03/ewaybill?aspid=************&password=************&Gstin=************&AuthToken=jSNGkXqh8RshEAf91CAFMMdcp&user_name=************");

            //RestClient client = new RestClient("http://testapi.taxprogsp.co.in/eiewb/dec/v1.03/ewaybill?aspid=************&password=************&Gstin=************&AuthToken=7wTMc7VccewQSqraD46qz2lCd&user_name=************");
            RestRequest request = new RestRequest(Method.POST);
            //request.AddHeader("Gstin", "************");
            //request.AddHeader("user_name", "************");
            request.AddHeader("Gstin", "************");
            request.AddHeader("user_name", "************");
            request.AddHeader("AuthToken", "jSNGkXqh8RshEAf91CAFMMdcp");
            request.AddHeader("aspid", "************");
            request.AddHeader("password", "************");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.RequestFormat = DataFormat.Json;
            //ReqPlGenIRN reqPlGenIRN = new ReqPlGenIRN();
            //reqPlGenIRN = JsonConvert.DeserializeObject<ReqPlGenIRN>(strJson);
            //request.AddBody(reqPlGenIRN); 
            string jsonStr = JsonConvert.SerializeObject(reqPlGenEwbByIRN);
            request.AddBody(reqPlGenEwbByIRN);
            IRestResponse response = await client.ExecuteTaskAsync(request);

           

            RespPl respPl = new RespPl();
            respPl = JsonConvert.DeserializeObject<RespPl>(response.Content);

            RespPlGenEwbByIRN resp = new RespPlGenEwbByIRN();
            resp = JsonConvert.DeserializeObject<RespPlGenEwbByIRN>(respPl.Data.Replace("\"{", "{").Replace("}\"", "}").Replace("\\\"", "\""));     

            rtbResponce.Text = JsonConvert.SerializeObject(resp);
        }
        private async void btnCancelEwbByDec_Click(object sender, EventArgs e)
        {
            string action = "CANEWB";
            ReqPlCancelEWB reqPlCancelEWB = new ReqPlCancelEWB();
            reqPlCancelEWB.ewbNo = 211223256570;
            reqPlCancelEWB.cancelRsnCode = 2;
            reqPlCancelEWB.cancelRmrk = "Cancelled the order";

            RestClient client = new RestClient("https://api.taxprogsp.co.in/v1.03/dec/ewayapi?action=CANEWB&aspid=************&password=************&gstin=************&authtoken=jSNGkXqh8RshEAf91CAFMMdcp&username=************");

            //RestClient client = new RestClient("http://testapi.taxprogsp.co.in/eiewb/dec/v1.03/ewaybill?aspid=************&password=************&Gstin=************&AuthToken=7wTMc7VccewQSqraD46qz2lCd&user_name=************");
            RestRequest request = new RestRequest(Method.POST);
            //request.AddHeader("Gstin", "************");
            //request.AddHeader("user_name", "************");
            request.AddHeader("Gstin", "************");
            request.AddHeader("username", "************");
            request.AddHeader("AuthToken", "jSNGkXqh8RshEAf91CAFMMdcp");
            request.AddHeader("aspid", "************");
            request.AddHeader("password", "************");
            request.AddHeader("Content-Type", "application/json; charset=utf-8");
            request.RequestFormat = DataFormat.Json;
            //ReqPlGenIRN reqPlGenIRN = new ReqPlGenIRN();
            string strJson = JsonConvert.SerializeObject(reqPlCancelEWB);
            //request.AddBody(reqPlGenIRN); 
            request.AddParameter("application/json", strJson, ParameterType.RequestBody);
            IRestResponse response = await client.ExecuteTaskAsync(request);

             //RespPl respPl = new RespPl();
            //respPl = JsonConvert.DeserializeObject<RespPl>(response.Content);

            RespPlCancelEWB resp = new RespPlCancelEWB();
            resp = JsonConvert.DeserializeObject<RespPlCancelEWB>(response.Content);

            rtbResponce.Text = JsonConvert.SerializeObject(resp);


        }

        private async void btnCancelEwayBill_Click(object sender, EventArgs e)
        {
            string action = "CANEWB";
            ReqPlCancelEWB reqPlCancelEWB = new ReqPlCancelEWB();
            reqPlCancelEWB.ewbNo = 251221608254;
            reqPlCancelEWB.cancelRsnCode = 2;
            reqPlCancelEWB.cancelRmrk = "Cancelled the order";
            TxnRespWithObj<RespPlCancelEWB> txnRespWithObj = await eInvoiceAPI.CancelEWBAsync(eInvSession, reqPlCancelEWB,action);

            if (txnRespWithObj.IsSuccess)
            {
                rtbResponce.Text = JsonConvert.SerializeObject(txnRespWithObj.RespObj);
            }
            else
                rtbResponce.Text = txnRespWithObj.TxnOutcome;

            txtResponceHdr.Text = "Generate IRN Responce...";
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                txtResponceHdr.Text = file;

                try
                {
                    rtbResponce.Text = File.ReadAllText(file);
                    //size = text.Length;
                }
                catch (IOException)
                {
                }
            }
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            txtGspName.Text = "TaxPro_Production";
            txtAuthUrl.Text = "https://api.taxprogsp.co.in/eivital/v1.03";
            txtBaseUrl.Text = "https://api.taxprogsp.co.in/eicore/v1.03";
            txtEwbBaseUrl.Text = "https://api.taxprogsp.co.in/eiewb/v1.03";
            txtCancelEWB.Text = "https://api.taxprogsp.co.in/v1.03";
        }

        private void btnSandBoxSetting_Click(object sender, EventArgs e)
        {
            txtGspName.Text = "TaxPro_Sandbox";
            txtAuthUrl.Text = "http://testapi.taxprogsp.co.in/eivital/v1.03";
            txtBaseUrl.Text = "http://testapi.taxprogsp.co.in/eicore/v1.03";
            txtEwbBaseUrl.Text = "http://testapi.taxprogsp.co.in/eiewb/v1.03";
            txtCancelEWB.Text = "http://testapi.taxprogsp.co.in/v1.03";
            txtUserName.Text = "************";
            txtPassword.Text = "abcd1234*";
            txtGstin.Text = "************";

        }

		private async void btnGetEWBByIRN_Click(object sender, EventArgs e)
		{
			{
				string IRN_No = "37d86afc1379fc963c1488a1bcf3c781f0011a920fc6ee7e1cd5ffc177bc7e18";
				TxnRespWithObj<RespGetEWBByIRN> txnRespWithObj = await eInvoiceAPI.GetEWBByIRNAsync(eInvSession, IRN_No);
				if (txnRespWithObj.IsSuccess)
				{
					rtbResponce.Text = JsonConvert.SerializeObject(txnRespWithObj.RespObj);
				}
				else
					rtbResponce.Text = txnRespWithObj.TxnOutcome;

				txtResponceHdr.Text = "Get EWB By IRN Responce...";
			}

		}

		private async void btnGetSyncGSTINDetails_Click(object sender, EventArgs e)
		{
			{
				string GSTIN = "33GSPTN1882G1Z3";
				TxnRespWithObj<RespPlGetGSTIN> txnRespWithObj = await eInvoiceAPI.SyncGSTINAsync(eInvSession, GSTIN);
				if (txnRespWithObj.IsSuccess)
				{
					rtbResponce.Text = JsonConvert.SerializeObject(txnRespWithObj.RespObj);
				}
				else
					rtbResponce.Text = txnRespWithObj.TxnOutcome;

				txtResponceHdr.Text = "Get Sync GSTIN Detail Responce...";
			}


		}

        private async void btnGetIRNDetailsByDocDetails_Click(object sender, EventArgs e)
        {
            {
                string DocType = "INV";
                string DocNum = "DOC/189661";
                string DocDate = "01/02/2021";
          
              TxnRespWithObj<RespPlGenIRN> txnRespWithObj = await eInvoiceAPI.GetIRNDetailsByDocDetailsAsync(eInvSession, DocType,  DocNum, DocDate, 250);
                if (txnRespWithObj.IsSuccess)
                {
                    rtbResponce.Text = JsonConvert.SerializeObject(txnRespWithObj.RespObj);
                }
                else
                    rtbResponce.Text = txnRespWithObj.TxnOutcome;

                txtResponceHdr.Text = "Get IRN Details By Doc Detail Responce...";
            }

        }
    }
    
    }



