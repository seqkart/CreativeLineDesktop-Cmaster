package TaxProEInvoiceApiIntigration;
import TaxProEInvoice.Java.API.*;

import com.google.gson.*;
import com.google.zxing.WriterException;
import com.google.zxing.common.BitMatrix;

import javax.imageio.ImageIO;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.awt.image.BufferedImage;
import java.io.*;
import java.nio.file.Files;
import java.nio.file.Paths;
import java.util.ArrayList;

public class TaxProEInvoiceDemoForm implements AuthTokenListner {
    private JTextField txtBaseUrl;
    private JTextField txtAspPassword;
    private JTextField txtAspUserID;
    private JButton btnGetEwbDetailByIrn;
    private JTextField txtGSPName;
    private JButton btnGetAuthToken;
    private JButton btnGenIRN;
    private JButton btnCancelIrn;
    private JButton btnGetInvDetailByIRN;
    private JButton btnGetInvDetailByDocDetail;
    private JTextArea txtResponce;
    private JButton btnGetGSTINDetail;
    private JTextField txtGSTIN;
    private JTextField txtPassword;
    private JTextField txtUserName;
    private JButton btnSaveSettings;
    private JButton btnSaveLoginDetails;
    private JPanel f;
    private JPanel ParentPanel;
    private JTextField txtClientId;
    private JTextField txtClientSecret;
    private JTextField txtAuthUrl;
    private JTextField txtAppKey;
    private JTextField txtAuthToken;
    private JTextField txtTokenExp;
    private JTextField txtSek;
    private JTextField txtHdr;
    private JTextField txtEwbBaseUrl;
    private JButton btnGenEwbByIRN;
    private JButton btnCancelEWB;
    private JTextField txtCancelEwbUrl;
    private JButton btnSyncGSTINDetails;
    private JButton btnGetIRNDetailsByDocDetails;

    public EInvoiceSession eInvoiceSession = new EInvoiceSession();
    public Gson gson  = new GsonBuilder().create();
    public EInvoiceApiCall apiCall = new EInvoiceApiCall();


    //Impliment this event handler to save refreshed auth token - library internally refreshesh auth token
    @Override
    public  void  ReceivedAuthToken(){
        (new Shared()).SaveApiLoginDetail(eInvoiceSession.eInvoiceAPILoginDetails);
        DisplayLoginDetail();
    }

    public TaxProEInvoiceDemoForm() {
        AuthTokenHandler.addListner(this);

        loadApiSetting();
        loadApiLoginDetails();


        //IMP NOTE: user of the library need not call GetAuthToken API
        //Other API calls, internally checks validity of auth token and calls GetAuthToken API if required
        //only handle ReceivedAuthToken event by implimenting listner as shown above
        //The call to GetAuthToken here is for demo purpose only
        //pass second param to GethAuthToken method as 'True' if ForcedRefresh is required for some reason.
        btnGetAuthToken.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                APITxnModel.TxnRespWithObj<EInvoiceSession> txnRespWithObj = apiCall.GetAuthToken(eInvoiceSession);
                if(txnRespWithObj.IsSuccess)
                {
                    DisplayLoginDetail();
                }
                txtHdr.setText("Auth Api Responce");
                txtResponce.setText(txnRespWithObj.TxnOutcome);
            }
        });
        btnSaveSettings.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if(eInvoiceSession != null){
                    eInvoiceSession.einvoiceAPISetting = new E_InvoiceAPISetting();
                    eInvoiceSession.einvoiceAPISetting.client_id = txtClientId.getText();
                    eInvoiceSession.einvoiceAPISetting.client_secret = txtClientSecret.getText();
                    eInvoiceSession.einvoiceAPISetting.GSPName = txtGSPName.getText();
                    eInvoiceSession.einvoiceAPISetting.AspUserId = txtAspUserID.getText();
                    eInvoiceSession.einvoiceAPISetting.AspPassword = txtAspPassword.getText();
                    eInvoiceSession.einvoiceAPISetting.BaseUrl = txtBaseUrl.getText();
                    eInvoiceSession.einvoiceAPISetting.AuthUrl = txtAuthUrl.getText();
                    eInvoiceSession.einvoiceAPISetting.EwbUrl = txtEwbBaseUrl.getText();
                    eInvoiceSession.einvoiceAPISetting.CancelEwbUrl = txtCancelEwbUrl.getText();
                    try (Writer writer = new FileWriter("E_InvoiceApiSetting.json"))
                    {
                        Gson gson = new GsonBuilder().create();
                        gson.toJson(eInvoiceSession.einvoiceAPISetting,writer);
                        JOptionPane.showMessageDialog(null,"eInvoice Api Setting Saved Successfully");
                    }
                    catch (Exception Ex){
                        JOptionPane.showMessageDialog(null,Ex.getMessage());
                    }
                }
                else
                    JOptionPane.showMessageDialog(null,"eInvoiceSession is null");
            }
        });
        btnSaveLoginDetails.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if(eInvoiceSession != null){
                    eInvoiceSession.eInvoiceAPILoginDetails = new E_InvoiceAPILoginDetails();
                    eInvoiceSession.eInvoiceAPILoginDetails.UserName=txtUserName.getText();
                    eInvoiceSession.eInvoiceAPILoginDetails.Password=txtPassword.getText();
                    eInvoiceSession.eInvoiceAPILoginDetails.GSTIN=txtGSTIN.getText();
                    eInvoiceSession.eInvoiceAPILoginDetails.AppKey=txtAppKey.getText();
                    eInvoiceSession.eInvoiceAPILoginDetails.AuthToken=txtAuthToken.getText();
                    eInvoiceSession.eInvoiceAPILoginDetails.E_InvoiceTokenExp=txtTokenExp.getText();
                    eInvoiceSession.eInvoiceAPILoginDetails.Sek=txtSek.getText();
                    try (Writer writer = new FileWriter("E_InvoiceApiLoginDetails.json"))
                    {
                        Gson gson = new GsonBuilder().create();
                        gson.toJson(eInvoiceSession.eInvoiceAPILoginDetails,writer);
                        JOptionPane.showMessageDialog(null,"eInvoice login details Saved Successfully");
                    }
                    catch (Exception Ex){
                        JOptionPane.showMessageDialog(null,Ex.getMessage());
                    }
                }
                else
                    JOptionPane.showMessageDialog(null,"eInvoiceSession is null");
            }
        });
        btnGenIRN.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                //PayLoad in Json Format reading file Json.
                APITxnModel.TxnRespWithObj<E_InvoiceCommon.RespPlGenIRN> txnResp1 = null;
                E_InvoiceCommon.ReqPlGenIRN reqPlGenIRN = new E_InvoiceCommon.ReqPlGenIRN();
//                reqPlGenIRN.Version = "1.03";
//                reqPlGenIRN.TranDtls = new E_InvoiceCommon.ReqPlGenIRN.TranDetails();
//                reqPlGenIRN.TranDtls.TaxSch = "GST";
//                reqPlGenIRN.TranDtls.SupTyp = "B2B";
//                reqPlGenIRN.TranDtls.RegRev = "Y";
//                reqPlGenIRN.TranDtls.EcmGstin = null;
//                reqPlGenIRN.TranDtls.IgstOnIntra = "N";
//                reqPlGenIRN.DocDtls = new E_InvoiceCommon.ReqPlGenIRN.DocDetails();
//                reqPlGenIRN.DocDtls.Typ = "INV";
//                reqPlGenIRN.DocDtls.No = "DOC-NO/71";
//                reqPlGenIRN.DocDtls.Dt = "13/03/2020";
//                reqPlGenIRN.SellerDtls = new E_InvoiceCommon.ReqPlGenIRN.SellerDetails();
//                reqPlGenIRN.SellerDtls.Gstin = "34AACCC1596Q002";
//                reqPlGenIRN.SellerDtls.LglNm = "ABC company pvt ltd";
//                reqPlGenIRN.SellerDtls.TrdNm = null;
//                reqPlGenIRN.SellerDtls.Addr1 = "5th block, kuvempu layout";
//                reqPlGenIRN.SellerDtls.Addr2 = null;
//                reqPlGenIRN.SellerDtls.Loc = "GANDHINAGAR";
//                reqPlGenIRN.SellerDtls.Pin = 605001;
//                reqPlGenIRN.SellerDtls.Stcd = "34";
//                reqPlGenIRN.SellerDtls.Ph = null;
//                reqPlGenIRN.SellerDtls.Em = null;
//                reqPlGenIRN.BuyerDtls = new E_InvoiceCommon.ReqPlGenIRN.BuyerDetails();
//                reqPlGenIRN.BuyerDtls.Gstin = "29AWGPV7107B1Z1";
//                reqPlGenIRN.BuyerDtls.LglNm = "XYZ company pvt ltd";
//                reqPlGenIRN.BuyerDtls.TrdNm = null;
//                reqPlGenIRN.BuyerDtls.Pos = "12";
//                reqPlGenIRN.BuyerDtls.Addr1 = "7th block, kuvempu layout";
//                reqPlGenIRN.BuyerDtls.Addr2 = null;
//                reqPlGenIRN.BuyerDtls.Loc = "GANDHINAGAR";
//                reqPlGenIRN.BuyerDtls.Pin = 562160;
//                reqPlGenIRN.BuyerDtls.Stcd = "29";
//                reqPlGenIRN.BuyerDtls.Ph = null;
//                reqPlGenIRN.BuyerDtls.Em = null;
//                reqPlGenIRN.DispDtls = new E_InvoiceCommon.ReqPlGenIRN.DispatchedDetails();
//                reqPlGenIRN.DispDtls.Nm = "ABC company pvt ltd";
//                reqPlGenIRN.DispDtls.Addr1 = "7th block, kuvempu layout";
//                reqPlGenIRN.DispDtls.Addr2 = null;
//                reqPlGenIRN.DispDtls.Loc = "Banagalore";
//                reqPlGenIRN.DispDtls.Pin = 562160;
//                reqPlGenIRN.DispDtls.Stcd = "29";
//                reqPlGenIRN.ShipDtls = new E_InvoiceCommon.ReqPlGenIRN.ShippedDetails();
//                reqPlGenIRN.ShipDtls.Gstin =  null;
//                reqPlGenIRN.ShipDtls.LglNm =  "CBE company pvt ltd";
//                reqPlGenIRN.ShipDtls.TrdNm = null;
//                reqPlGenIRN.ShipDtls.Addr1 = "7th block, kuvempu layout";
//                reqPlGenIRN.ShipDtls.Addr2 = null;
//                reqPlGenIRN.ShipDtls.Loc = "Banagalore";
//                reqPlGenIRN.ShipDtls.Pin = 562160;
//                reqPlGenIRN.ShipDtls.Stcd = "29";
//                reqPlGenIRN.ItemList = new ArrayList<E_InvoiceCommon.ReqPlGenIRN.ItmList>();
//                E_InvoiceCommon.ReqPlGenIRN.ItmList itm = new E_InvoiceCommon.ReqPlGenIRN.ItmList();
//                itm.SlNo = "1";
//                itm.IsServc = "N";
//                itm.PrdDesc = "Rice";
//                itm.HsnCd = "1001";
//                itm.BchDtls = null;
//                itm.Qty = 100.345;
//                itm.Unit = "BAG";
//                itm.UnitPrice = 99.545;
//                itm.TotAmt = 9988.84;
//                itm.Discount =  10;
//                itm.AssAmt = 9978.84;
//                itm.GstRt = 12.00;
//                itm.SgstAmt = 0.0;
//                itm.IgstAmt = 1197.46;
//                itm.CgstAmt = 0.0;
//                itm.CesRt = 5;
//                itm.CesAmt = 498.94;
//                itm.CesNonAdvlAmt =  10;
//                itm.StateCesRt = 12;
//                itm.StateCesAmt = 1197.46;
//                itm.StateCesNonAdvlAmt = 5;
//                itm.OthChrg = 10;
//                itm.TotItemVal = 12897.7;
//                itm.AttribDtls = null;
//                reqPlGenIRN.ItemList.add(itm);
//                reqPlGenIRN.PayDtls = null;
//                reqPlGenIRN.RefDtls = null;
//                reqPlGenIRN.AddlDocDtls = null;
//                reqPlGenIRN.ExpDtls = null;
//                reqPlGenIRN.EwbDtls = null;
//                reqPlGenIRN.ValDtls = new E_InvoiceCommon.ReqPlGenIRN.ValDetails();
//                reqPlGenIRN.ValDtls.AssVal = 9978.84;
//                reqPlGenIRN.ValDtls.CgstVal = 0.0;
//                reqPlGenIRN.ValDtls.SgstVal = 0.0;
//                reqPlGenIRN.ValDtls.IgstVal = 1197.46;
//                reqPlGenIRN.ValDtls.CesVal = 508.94;
//                reqPlGenIRN.ValDtls.StCesVal = 1202.46;
//                reqPlGenIRN.ValDtls.RndOffAmt = 0.3;
//                reqPlGenIRN.ValDtls.TotInvVal =  12908;
//                reqPlGenIRN.ValDtls.TotInvValFc =  12897.7;
                String text = "";

                try {
                    text = new String(Files.readAllBytes(Paths.get("C:\\Users\\Pallavi\\Desktop\\ProductionSampleJsonGenIRN.txt")));
                    //txnResp1 = apiCall.GenIRN(eInvoiceSession,reqPlGenIRN,150);
                }catch (FileNotFoundException ex){
                    JOptionPane.showMessageDialog(null,ex.getMessage());
                }
                catch (IOException ex){
                    ex.getMessage();
                }
                txnResp1 = apiCall.GenIRN(eInvoiceSession,text,250);

                if (txnResp1.IsSuccess){
                    txtResponce.setText(gson.toJson(txnResp1.RespObj));
                    E_InvoiceCommon.RespPlGenIRN respPlGenIRN = new E_InvoiceCommon.RespPlGenIRN();
                    respPlGenIRN = txnResp1.RespObj;

                    //Generate QR Code
                    //Showing the below code only for validation need not to store
                    File qrFile = new File("C:\\Users\\Pallavi\\Desktop\\qrJava.png");
                    try {
                        createQRImage(qrFile, txnResp1.RespObj.QrCodeImage, "png");
                    }
                    catch (IOException ex){
                        txtResponce.setText(ex.getMessage());
                    }

                    //Store respPlGenIRN (manditory - AckDate and SignedInvoice) to verify signed invoice
                    //below code is to show how to verify signed invoice

                    respPlGenIRN.QrCodeImage = null;
                    APITxnModel.TxnRespWithObj<E_InvoiceCommon.VerifyRespPl> txnRespWithObj1 = apiCall.VerifySignedInvoice(eInvoiceSession, respPlGenIRN);

                    E_InvoiceCommon.VerifyRespPl verifyRespPl = new E_InvoiceCommon.VerifyRespPl();
                    if(txnRespWithObj1.IsSuccess){
                        verifyRespPl.IsVerified = txnRespWithObj1.RespObj.IsVerified;
                        verifyRespPl.JwtIssuerIRP = txnRespWithObj1.RespObj.JwtIssuerIRP;
                        verifyRespPl.VerifiedWithCertificateEffectiveFrom = txnRespWithObj1.RespObj.VerifiedWithCertificateEffectiveFrom;
                        verifyRespPl.CertificateName = txnRespWithObj1.RespObj.CertificateName;
                        verifyRespPl.CertStartDate = txnRespWithObj1.RespObj.CertStartDate;
                        verifyRespPl.CertExpiryDate = txnRespWithObj1.RespObj.CertExpiryDate;
                    }

                }
                else{
                    if(txnResp1.ErrorDetails != null){
                        ArrayList<E_InvoiceCommon.RespErrDetailsPl> err = new ArrayList<E_InvoiceCommon.RespErrDetailsPl>();
                        err = txnResp1.ErrorDetails;
                    }
                    if (txnResp1.InfoDetails != null)
                    {
                        for (E_InvoiceCommon.RespInfoDtlsPl infoPl : txnResp1.InfoDetails)
                        {
                            String strDupIrnPl = gson.toJson(infoPl.Desc);   //Convert object type to json string
                            switch (infoPl.InfCd)
                            {
                                case "DUPIRN":
                                    E_InvoiceCommon.DupIrnPl dupIrnPl = gson.fromJson(strDupIrnPl,E_InvoiceCommon.DupIrnPl.class);
                                    break;
                                case "EWBERR":
                                    E_InvoiceCommon.EwbErrPl ewbErrPl = gson.fromJson(strDupIrnPl,E_InvoiceCommon.EwbErrPl.class);
                                    break;
                                case "ADDNLNFO":
                                    //Deserialize infoPl.Desc as string type and then if this string contains json object, it may be desirilized again as per future releases
                                    String strDesc = (String) infoPl.Desc;
                                    break;
                            }
                        }
                    }
                    txtResponce.setText(txnResp1.TxnOutcome);
                }
            }
        });
        btnCancelIrn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                E_InvoiceCommon.ReqPlCancelIRN reqPlCancelIRN = new E_InvoiceCommon.ReqPlCancelIRN();
                reqPlCancelIRN.CnlRem = "Wrong entry";
                reqPlCancelIRN.CnlRsn = "1";
                reqPlCancelIRN.Irn = "68897a70ded75c34556239be5beb118142e45c6dc5aa959ced4931698e8e4e1c";
                APITxnModel.TxnRespWithObj<E_InvoiceCommon.RespPlCancelIRN> txnRespWithObj = apiCall.CancelIRN(eInvoiceSession,reqPlCancelIRN);

                if (txnRespWithObj.IsSuccess)
                {
                    txtResponce.setText(gson.toJson(txnRespWithObj.RespObj));
                }
                else
                    txtResponce.setText(txnRespWithObj.TxnOutcome);

                txtHdr.setText("Cancel IRN Responce...");
            }
        });

        //R
        btnGetInvDetailByIRN.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e){
                String IrnNo = "0e4aca9d29dc1d8e30fa943bd2947bd0b463acf5725a1adb23650c87c813ebb5";
                try {
                    APITxnModel.TxnRespWithObj<E_InvoiceCommon.RespPlGenIRN> txnRespWithObj = apiCall.GetEInvDetailsByIRN(eInvoiceSession, IrnNo, 150);
                    if (txnRespWithObj.IsSuccess)
                    {
                        txtResponce.setText(gson.toJson(txnRespWithObj.RespObj));
                        E_InvoiceCommon.RespPlGenIRN respPlGenIRN = new E_InvoiceCommon.RespPlGenIRN();
                        respPlGenIRN = txnRespWithObj.RespObj;
                        String AckNo = respPlGenIRN.AckNo;
                    }
                    else
                        txtResponce.setText(txnRespWithObj.TxnOutcome);

                    txtHdr.setText("Get Invoice Details by IRN Response...");
                }catch (IOException ex){
                    txtHdr.setText(ex.getMessage());
                }catch (WriterException ex){
                    txtHdr.setText(ex.getMessage());
                }
            }
        });
        btnGetIRNDetailsByDocDetails.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e){
                String DocType = "INV";
                String DocNum = "DOC/165629621";
                String DocDate = "01/02/2021";
                try {
                    APITxnModel.TxnRespWithObj<E_InvoiceCommon.RespPlGenIRN> txnRespWithObj = apiCall.GetIRNDetailsByDocDetails(eInvoiceSession, DocType, DocNum, DocDate, 250);
                    if (txnRespWithObj.IsSuccess)
                    {
                        txtResponce.setText(gson.toJson(txnRespWithObj.RespObj));
                        E_InvoiceCommon.RespPlGenIRN respPlGenIRN = new E_InvoiceCommon.RespPlGenIRN();
                        respPlGenIRN = txnRespWithObj.RespObj;
                        String AckNo = respPlGenIRN.AckNo;
                    }
                    else
                        txtResponce.setText(txnRespWithObj.TxnOutcome);

                    txtHdr.setText("Get IRN Details by Document Detail Response...");
                }catch (IOException ex){
                    txtHdr.setText(ex.getMessage());
                }catch (WriterException ex){
                    txtHdr.setText(ex.getMessage());
                }
            }
        });
        btnGetEwbDetailByIrn.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String Irn_no = "8e55580cd881b247553423c31e8708e39a07c8f2163d533443578e142d98d8ba";
                APITxnModel.TxnRespWithObj<E_InvoiceCommon.RespGetEWBByIRN> txnRespWithObj = apiCall.GetEWBDetailsByIRN(eInvoiceSession, Irn_no);
                if (txnRespWithObj.IsSuccess)
                {
                    txtResponce.setText(gson.toJson(txnRespWithObj.RespObj));
                }
                else
                    txtResponce.setText(txnRespWithObj.TxnOutcome);

                txtHdr.setText("Get EWB Details by IRN...");
            }
        });
        btnGetGSTINDetail.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {

            }
        });
        btnGetGSTINDetail.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {

                String GSTIN = "29AACCC1596Q000";
                APITxnModel.TxnRespWithObj<E_InvoiceCommon.RespPlGetGSTIN> txnRespWithObj = apiCall.GetGSTINDetails(eInvoiceSession, GSTIN);
                if (txnRespWithObj.IsSuccess)
                {
                    txtResponce.setText(gson.toJson(txnRespWithObj.RespObj));
                }
                else
                    txtResponce.setText(txnRespWithObj.TxnOutcome);

                txtHdr.setText("Get GSTIN Detail Responce...");
            }
        });
        btnSyncGSTINDetails.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {

                String GSTIN = "33GSPTN1882G1Z3";
                APITxnModel.TxnRespWithObj<E_InvoiceCommon.RespPlGetGSTIN> txnRespWithObj = apiCall.SyncGSTINDetails(eInvoiceSession, GSTIN);
                if (txnRespWithObj.IsSuccess)
                {
                    txtResponce.setText(gson.toJson(txnRespWithObj.RespObj));
                }
                else
                    txtResponce.setText(txnRespWithObj.TxnOutcome);

                txtHdr.setText("Get Sync GSTIN Detail Responce...");
            }
        });

        btnGenEwbByIRN.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                E_InvoiceCommon.RespPlGenEwbByIRN respPlGenEwbByIRN = new E_InvoiceCommon.RespPlGenEwbByIRN();
                E_InvoiceCommon.ReqPlGenEwbByIRN reqPlGenEwbByIRN = new E_InvoiceCommon.ReqPlGenEwbByIRN();
                reqPlGenEwbByIRN.Irn = "09e6ba45eac89793353487bfe3d3a2b310c70222a9f499a2a713b5c6ab2283e8";
                reqPlGenEwbByIRN.TransId = "29DPZPS4403C1ZF";
                reqPlGenEwbByIRN.TransMode = "1";
                reqPlGenEwbByIRN.TransDocNo = "12/22";
                reqPlGenEwbByIRN.TransDocDt = "07/11/2020";
                reqPlGenEwbByIRN.VehNo = "KA01AB1234";
                reqPlGenEwbByIRN.Distance = 100;
                reqPlGenEwbByIRN.VehType = "R";
                reqPlGenEwbByIRN.TransName = "ree";
                reqPlGenEwbByIRN.ExpShipDtls = new E_InvoiceCommon.ReqPlGenEwbByIRN().new ExportShipDetails();
               reqPlGenEwbByIRN.ExpShipDtls.Addr1 = "7th block, kuvempu layout";
                reqPlGenEwbByIRN.ExpShipDtls.Addr2 =  "kuvempu layout";
               reqPlGenEwbByIRN.ExpShipDtls.Loc = "Banagalore";
               reqPlGenEwbByIRN.ExpShipDtls.Pin = 562160;
               reqPlGenEwbByIRN.ExpShipDtls.Stcd ="29";
               reqPlGenEwbByIRN.DispDtls = new E_InvoiceCommon.ReqPlGenEwbByIRN().new DispatchedDetails();
                reqPlGenEwbByIRN.DispDtls.Nm =  "ABC company pvt ltd";
                reqPlGenEwbByIRN.DispDtls.Addr1 = "7th block, kuvempu layout";
                reqPlGenEwbByIRN.DispDtls.Addr2 = "kuvempu layout";
                reqPlGenEwbByIRN.DispDtls.Loc = "Banagalore";
                reqPlGenEwbByIRN.DispDtls.Pin = 562160;
                reqPlGenEwbByIRN.DispDtls.Stcd = "29";

                APITxnModel.TxnRespWithObj<E_InvoiceCommon.RespPlGenEwbByIRN> txnRespWithObj = apiCall.GenEwbByIRN(eInvoiceSession, reqPlGenEwbByIRN);
                String ErrorCodes = "";
                String ErrorDesc = "";
                if (txnRespWithObj.IsSuccess)
                {
                    txtResponce.setText(gson.toJson(txnRespWithObj.RespObj));
                    respPlGenEwbByIRN.EwbDt = txnRespWithObj.RespObj.EwbDt;
                    respPlGenEwbByIRN.EwbNo = txnRespWithObj.RespObj.EwbNo;
                    respPlGenEwbByIRN.EwbValidTill = txnRespWithObj.RespObj.EwbValidTill;
                }
                else{
                    if (txnRespWithObj.ErrorDetails != null)
                    {

                        for (E_InvoiceCommon.RespErrDetailsPl errPl : txnRespWithObj.ErrorDetails)
                        {
                            //Process errPl item here
                            ErrorCodes += errPl.ErrorCode + ",";
                            ErrorDesc += errPl.ErrorCode + ": " + errPl.ErrorMessage;
                            txtResponce.setText(ErrorDesc);
                        }
                    }
                }


                txtHdr.setText("Generate EWB By IRN Responce...");
            }
        });
        btnCancelEWB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String action = "CANEWB";
                E_InvoiceCommon.ReqPlCancelEWB reqPlCancelEWB = new E_InvoiceCommon.ReqPlCancelEWB();
                reqPlCancelEWB.ewbNo = 101008701277L;
                reqPlCancelEWB.cancelRsnCode = 2;
                reqPlCancelEWB.cancelRmrk = "Cancelled the order";
                APITxnModel.TxnRespWithObj<E_InvoiceCommon.RespPlCancelEWB> txnRespWithObj = apiCall.CancelEWB(eInvoiceSession, reqPlCancelEWB);
                if (txnRespWithObj.IsSuccess)
                {
                    txtResponce.setText(gson.toJson(txnRespWithObj.RespObj));
                }
                else
                    txtResponce.setText(txnRespWithObj.TxnOutcome);

                txtHdr.setText("Cancel EWB");
            }
        });
    }
    public static void main(String[] args){
        JFrame jf = new JFrame("TaxPro EInvoice Api Intigration Demo");
        jf.setContentPane(new TaxProEInvoiceDemoForm().f);
        jf.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        jf.pack();
        jf.setVisible(true);

    }
    public  void loadApiSetting(){
        try (Reader reader = new FileReader("E_InvoiceApiSetting.json"))
        {
            Gson gson = new Gson();
            eInvoiceSession.einvoiceAPISetting= gson.fromJson(reader,E_InvoiceAPISetting.class);
            txtClientId.setText(eInvoiceSession.einvoiceAPISetting.client_id);
            txtGSPName.setText(eInvoiceSession.einvoiceAPISetting.GSPName);
            txtAspUserID.setText(eInvoiceSession.einvoiceAPISetting.AspUserId);
            txtClientSecret.setText(eInvoiceSession.einvoiceAPISetting.client_secret);
            txtAspPassword.setText(eInvoiceSession.einvoiceAPISetting.AspPassword);
            txtBaseUrl.setText(eInvoiceSession.einvoiceAPISetting.BaseUrl);
            txtAuthUrl.setText(eInvoiceSession.einvoiceAPISetting.AuthUrl);
            txtEwbBaseUrl.setText(eInvoiceSession.einvoiceAPISetting.EwbUrl);
            txtCancelEwbUrl.setText(eInvoiceSession.einvoiceAPISetting.CancelEwbUrl);
        }catch (Exception ex){}
    }
    public  void loadApiLoginDetails(){

       try(Reader reader = new FileReader("E_InvoiceApiLoginDetails.json"))
       {
           Gson gson = new Gson();
               eInvoiceSession.eInvoiceAPILoginDetails= gson.fromJson(reader,   E_InvoiceAPILoginDetails.class);
            txtUserName.setText(eInvoiceSession.eInvoiceAPILoginDetails.UserName);
            txtPassword.setText( eInvoiceSession.eInvoiceAPILoginDetails.Password);
            txtGSTIN.setText(eInvoiceSession.eInvoiceAPILoginDetails.GSTIN);
            txtAppKey.setText( eInvoiceSession.eInvoiceAPILoginDetails.AppKey);
            txtAuthToken.setText(eInvoiceSession.eInvoiceAPILoginDetails.AuthToken);
            txtTokenExp.setText( eInvoiceSession.eInvoiceAPILoginDetails.E_InvoiceTokenExp);
            txtSek.setText(eInvoiceSession.eInvoiceAPILoginDetails.Sek);
       }catch (Exception ex){}
    }
    public void DisplayLoginDetail(){
        txtUserName.setText(eInvoiceSession.eInvoiceAPILoginDetails.UserName);
        txtPassword.setText( eInvoiceSession.eInvoiceAPILoginDetails.Password);
        txtGSTIN.setText(eInvoiceSession.eInvoiceAPILoginDetails.GSTIN);
        txtAppKey.setText( eInvoiceSession.eInvoiceAPILoginDetails.AppKey);
        txtAuthToken.setText(eInvoiceSession.eInvoiceAPILoginDetails.AuthToken);
        txtTokenExp.setText( eInvoiceSession.eInvoiceAPILoginDetails.E_InvoiceTokenExp);
        txtSek.setText(eInvoiceSession.eInvoiceAPILoginDetails.Sek);
    }
    private  void createQRImage(File qrFile, BitMatrix qrCodeText, String fileType) throws IOException{
        // Make the BufferedImage that are to hold the QRCode
        int matrixWidth = qrCodeText.getWidth();
        BufferedImage image = new BufferedImage(matrixWidth, matrixWidth, BufferedImage.TYPE_INT_RGB);
        image.createGraphics();

        Graphics2D graphics = (Graphics2D) image.getGraphics();
        graphics.setColor(Color.WHITE);
        graphics.fillRect(0, 0, matrixWidth, matrixWidth);
        // Paint and save the image using the ByteMatrix
        graphics.setColor(Color.BLACK);

        for (int i = 0; i < matrixWidth; i++) {
            for (int j = 0; j < matrixWidth; j++) {
                if (qrCodeText.get(i, j)) {
                    graphics.fillRect(i, j, 1, 1);
                }
            }
        }
        ImageIO.write(image, fileType, qrFile);
    }

    private void createUIComponents() {
        // TODO: place custom component creation code here
    }
}
