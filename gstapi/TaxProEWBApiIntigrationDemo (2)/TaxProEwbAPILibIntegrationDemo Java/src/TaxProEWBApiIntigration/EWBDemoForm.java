package TaxProEWBApiIntigration;
import TaxProEwb.Java.API.EWBSession;
import TaxProEwb.Java.API.*;
import javax.swing.*;
import java.awt.*;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;
import java.io.*;
import java.lang.reflect.Type;
import java.util.ArrayList;
import java.util.List;

import com.google.gson.*;
import org.joda.time.DateTime;
import org.joda.time.format.ISODateTimeFormat;

public class EWBDemoForm implements AuthTokenListner {
    public JPanel ParentPanel;
    private JTextField txtClientID;
    private JButton btnSaveSettings;
    private JTextField txtClientSecret;
    private JTextField txtGSPUserID;
    private JTextField txtGSPName;
    private JTextField txtAspUserID;
    private JTextField txtAspPassword;
    private JTextField txtBaseUrl;
    private JTextField txtEWBGstin;
    private JTextField txtEwbUserId;
    private JTextField txtEwbPassword;
    private JTextField txtAppKey;
    private JTextField txtAuthToken;
    private JTextField txtTokenExp;
    private JTextField txtSEK;
    private JButton btnSaveLoginDetails;
    private JButton btnGetAuthToken;
    private JTextArea txtResponce ;
    private JButton btnGenEWB;
    private JButton btnUpdtVehNo;
    private JButton btnGenCEWB;
    private JButton btnCancelEWB;
    private JButton btnRejectEWB;
    private JButton getEWBDetailButton;
    private JButton btnEwbAssignForTrans;
    private JButton btnAssToTransByGSTIN;
    private JButton getCEWBButton;
    private JButton btnUpdateTrans;
    private JButton btnEWBGenReqOnOthParty;
    private JButton btnExtendValidity;
    private JButton btnReGenCEWB;
    private JButton btnGetGSTINDetail;
    private JButton btnTransinDetail;
    private JButton btnHSNDetail;
    private JButton initiateMulVehMovButton;
    private JButton addMultiVehButton;
    private JButton btnUpdtMulVeh;
    private JButton getErrorListButton;
    private JButton btnGetEwbGenByConsignor;
    private JButton btnEWBApiBal;
    private JButton btnGetEWBForTransByState;
    private JButton btnGetEwbDetByDate;
    private JButton btnRejectedEwbByDate;
    private JButton printEWBButton;
    private JButton btnPrint;
    private JComboBox cmbSupplyType;


    public EWBSession EwbSession = new EWBSession();
   // public Shared shared = new Shared();
    public SharedApiMethod apiMethods  = new SharedApiMethod();
    public EwbApiCall apiCall  = new EwbApiCall();
    public Gson gson  = new GsonBuilder().create();
    public EWBJson ewbJson = new EWBJson();
    SharedLists sl = new SharedLists();

    public static void main(String[] args) {
        JFrame jf = new JFrame("TaxPro EWB Api Intigration Demo");
        jf.setContentPane(new EWBDemoForm().ParentPanel);
        jf.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        jf.pack();
        jf.setVisible(true);
    }

    public EWBDemoForm() {
        AuthTokenHandler.addListner(this);
//==================initially load EWB settings======================
        DisplayApiSettings();
        LoadLoginDetails();
        //===============-====Save Api Settings On button Click & write "EwbApiSettings.json" File============================================
        btnSaveSettings.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                EwbSession.EWBSettings.GSPName = txtGSPName.getText();
                EwbSession.EWBSettings.AspUserId = txtAspUserID.getText();
                EwbSession.EWBSettings.AspPassword = txtAspPassword.getText();
                EwbSession.EWBSettings.EWBClientId = txtClientID.getText();
                EwbSession.EWBSettings.EWBClientSecret = txtClientSecret.getText();
                EwbSession.EWBSettings.EWBGSPUserID = txtGSPUserID.getText();
                EwbSession.EWBSettings.BaseUrl = txtBaseUrl.getText();
                try (Writer writer = new FileWriter("EwbApiSettings.json"))
                {
                    Gson gson = new GsonBuilder().create();
                    gson.toJson(EwbSession.EWBSettings,writer);
                    JOptionPane.showMessageDialog(null,"Ewb ApiSetting Saved Successfully");
                }
                catch (Exception E){}
            }
        });
        //===============-===Save login Detail on button click and write "EwbApiLoginDetails.json" File============================================

        btnSaveLoginDetails.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                EwbSession.EWBLoginDetails = new EWBAPILoginDetails();
                EwbSession.EWBLoginDetails.EwbGstin = txtEWBGstin.getText();
                EwbSession.EWBLoginDetails.EwbUserID = txtEwbUserId.getText();
                EwbSession.EWBLoginDetails.EwbPassword = txtEwbPassword.getText();
                EwbSession.EWBLoginDetails.EwbAppKey = txtAppKey.getText();
                EwbSession.EWBLoginDetails.EwbAuthToken = txtAuthToken.getText();
                EwbSession.EWBLoginDetails.EwbSEK = txtSEK.getText();
                try (Writer writer = new FileWriter("EwbApiLoginDetails.json"))
                {
                    Gson gson = new GsonBuilder().create();
                    gson.toJson(EwbSession.EWBLoginDetails,writer);
                    JOptionPane.showMessageDialog(null,"Ewb Login Details Saved Successfully");
                }
                catch (Exception E){}
            }
        });
        //===============-===Get Auth Token on button click============================================
        btnGetAuthToken.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                if (JOptionPane.showConfirmDialog(null,"Calling any API method will internally check for valid AuthToken and would try to obtain AuthToken if its is expired.  You don't need to explicitly call GetAuthTokenAsync method. Do you want to proceed?","AuthToken is Automatic",JOptionPane.YES_NO_OPTION) == 0)
                {
                    GetAuthToken();
                }
            }
        });
        //===============-===Function to generate Eway bill on "Generate EWB" Button click============================================
        btnGenEWB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                EWBJson.ReqGenEwbPl ewbGen = new EWBJson.ReqGenEwbPl();
                ewbGen.supplyType = "O";
                ewbGen.subSupplyType = "1";
                ewbGen.subSupplyDesc = "Supply";
                ewbGen.docType = "INV";
                ewbGen.docNo = "SD19Y-1211125";
                ewbGen.docDate = "21/11/2019";
                ewbGen.fromGstin = "05AAACG0904A1ZL";
                ewbGen.fromTrdName = "ANKIT PULPS \\u0026 BOARDS PRIVATE LIMITED";
                ewbGen.fromAddr1 = "39/2 BHILGAON";
                ewbGen.fromAddr2 = "KAMPTEE ROAD";
                ewbGen.fromPlace = "NAV";
                ewbGen.fromPincode = 263652;
                ewbGen.fromStateCode = 05;
                ewbGen.actFromStateCode = 05;
                ewbGen.toGstin = "02EHFPS5910D2Z0";
                ewbGen.toTrdName = "sthuthya";
                ewbGen.toAddr1 = "Shree Nilaya";
                ewbGen.toAddr2 = "Dasarahosahalli";
                ewbGen.toPlace = "Beml Nagar";
                ewbGen.toPincode = 174021;
                ewbGen.toStateCode = 02;
                ewbGen.actToStateCode = 02;
                ewbGen.transactionType = 2;
                ewbGen.dispatchFromGSTIN = "";
                ewbGen.dispatchFromTradeName = "ABC Traders";
                ewbGen.shipToGSTIN = "05AAACG0904A1ZL";
                ewbGen.shipToTradeName = "XYZ Traders";
                ewbGen.otherValue = 0.0;
                ewbGen.totalValue = 0.0;
                ewbGen.cgstValue = 0.0;
                ewbGen.sgstValue = 0.0;
                ewbGen.igstValue = 0.0;
                ewbGen.cessValue = 0.0;
                ewbGen.cessNonAdvolValue = 0.0;
                ewbGen.transporterId = "";
                ewbGen.transporterName = "Nagpur Bombay Roadlines , Pune";
                ewbGen.transDocNo = "";
                    ewbGen.totInvValue = 0.0;
                ewbGen.transMode = "1";//1
                ewbGen.transDistance = "1000";
                ewbGen.transDocDate = "";
                ewbGen.vehicleNo = "PVC1234";//PVC1234
                ewbGen.vehicleType = "R";//R
                ewbGen.itemList = new ArrayList<EWBJson.ReqGenEwbPl.ItemList>();

                EWBJson.ReqGenEwbPl.ItemList item = new EWBJson.ReqGenEwbPl.ItemList() ;

                item.productName = "MICCEL-103 BP Domestic(SM)";
                item.productDesc = "MICCEL-103 BP Domestic(SM)";
                item.hsnCode = 7006;
                item.quantity = 1.0;
                item.qtyUnit = "KGS";
                item.cgstRate = 0.0;
                item.sgstRate = 0.0;
                item.igstRate = 0.0;
                item.cessRate = 0.0;
                item.cessNonAdvol = 0.0;
                item.taxableAmount = 0.0;
                ewbGen.itemList.add(item);

//                String ewbGen = "{\n" +
//                        "\"supplyType\":\"O\",\n" +
//                        "\"subSupplyType\":\"1\",\n" +
//                        "\"subSupplyDesc\":\"\",\n" +
//                        "\"docType\":\"INV\",\n" +
//                        "\"docNo\":\"123-8\",\n" +
//                        "\"docDate\":\"15/12/2017\",\n" +
//                        "\"fromGstin\":\"05AAACG0904A1ZL\",\n" +
//                        "\"fromTrdName\":\"welton\",\n" +
//                        "\"fromAddr1\":\"2ND CROSS NO 59  19  A\",\n" +
//                        "\"fromAddr2\":\"GROUND FLOOR OSBORNE ROAD\",\n" +
//                        "\"fromPlace\":\"FRAZER TOWN\",\n" +
//                        "\"fromPincode\":560042,\n" +
//                        "\"actFromStateCode\":05,\"fromStateCode\":05,\n" +
//                        "\"toGstin\":\"02EHFPS5910D2Z0\",\n" +
//                        "\"toTrdName\":\"sthuthya\",\n" +
//                        "\"toAddr1\":\"Shree Nilaya\",\n" +
//                        "\"toAddr2\":\"Dasarahosahalli\",\n" +
//                        "\"toPlace\":\"Beml Nagar\",\n" +
//                        "\"toPincode\":689788,\n" +
//                        "\"actToStateCode\":02,\n" +
//                        "\"toStateCode\":02,\n" +
//                        "\"totalValue\":5609889,\n" +
//                        "\"cgstValue\":\"0\",\n" +
//                        "\"sgstValue\":\"0\",\n" +
//                        "\"igstValue\":168296.67,\n" +
//                        "\"cessValue\":224395.56,\n" +
//                        "\"totInvValue\":435678,\n" +
//                        "\"transporterId\":\"\",\n" +
//                        "\"transporterName\":\"\",\n" +
//                        "\"transDocNo\":\"\",\n" +
//                        "\"transMode\":\"1\",\n" +
//                        "\"transDistance\":\"656\",\n" +
//                        "\"transDocDate\":\"\",\n" +
//                        "\"vehicleNo\":\"PVC1234\",\n" +
//                        "\"vehicleType\":\"R\",\n" +
//                        "\"itemList\":\n" +
//                        "[{\n" +
//                        "\"productName\":\"Wheat\",\n" +
//                        "\"productDesc\":\"Wheat\",\n" +
//                        "\"hsnCode\":1001,\n" +
//                        "\"quantity\":4,\n" +
//                        "\"qtyUnit\":\"BOX\",\n" +
//                        "\"cgstRate\":\"0\",\n" +
//                        "\"sgstRate\":\"0\",\n" +
//                        "\"igstRate\":3,\n" +
//                        "\"cessRate\":4,\n" +
//                        "\"cessAdvol\":\"0\",\n" +
//                        "\"taxableAmount\":5609889\n" +
//                        "}\n" +
//                        "]\n" +
//                        "}";
//
//                String a = "";
//                EWBJson.ReqGenEwbPl ewbGen = new EWBJson.ReqGenEwbPl();
//try {
//    Reader reader = new FileReader("C:\\Users\\Pallavi\\Desktop\\Navneet.txt");
//     a = reader.toString();
//
//
//    ewbGen = gson.fromJson(reader, EWBJson.ReqGenEwbPl.class);
//}catch (FileNotFoundException ex){
//
//}



                TxnRespWithObjAndInfo<EWBJson.RespGenEwbPl> RespObj = apiCall.GenerateEwb(EwbSession, ewbGen);
                if (RespObj.IsSuccess == true)
                    txtResponce.setText(gson.toJson(RespObj.RespObj));
                else{
                    txtResponce.setText(RespObj.TxnOutcome + "\n" + RespObj.RespObj);
                    if(RespObj.TxnOutcome.contains("702")){
                        EC.RespInfoPl respInfoPl = new EC.RespInfoPl();
                        respInfoPl = gson.fromJson(RespObj.Info, EC.RespInfoPl.class);
                        ewbGen.transDistance = respInfoPl.distance;
                        RespObj = apiCall.GenerateEwb(EwbSession, ewbGen);
                        if (RespObj.IsSuccess == true)
                            txtResponce.setText(gson.toJson(RespObj.RespObj));
                        else
                            txtResponce.setText(RespObj.TxnOutcome);

                    }
                }

            }
        });
        //Update vehicle no on button cick
        btnUpdtVehNo.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                EWBJson.ReqVehicleNoUpdtPl reqVehicleNo = new EWBJson.ReqVehicleNoUpdtPl();
                reqVehicleNo.ewbNo = 381001436550L;
                reqVehicleNo.vehicleNo = "PVC1234";
                reqVehicleNo.fromPlace = "BANGALORE";
                reqVehicleNo.fromState = 05;
                reqVehicleNo.reasonCode = "1";
                reqVehicleNo.reasonRem = "vehicle broke down";
                reqVehicleNo.transDocNo = "LR180321";
                reqVehicleNo.transDocDate = "";
                reqVehicleNo.transMode = "1";
                reqVehicleNo.vehicleType = "R";

                TxnRespWithObjAndInfo<EWBJson.RespVehicleNoUpdtPl> txnResp = apiCall.UpdtVehNo(EwbSession, reqVehicleNo);

                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else
                    txtResponce.setText(txnResp.TxnOutcome);
            }
        });
        //Generate consolidated EWB on button click
        btnGenCEWB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                EWBJson.ReqGenCEwbPl reqCEWB = new EWBJson.ReqGenCEwbPl();
                reqCEWB.fromPlace = "Vihar town";
                reqCEWB.fromState = "05";
                reqCEWB.vehicleNo = "PVC1234";
                reqCEWB.transMode = "1";
                reqCEWB.TransDocNo = "1234";
                reqCEWB.TransDocDate = "26/03/2018";
                reqCEWB.tripSheetEwbBills = new ArrayList<EWBJson.ReqGenCEwbPl.TripSheetEwbBills>();
                EWBJson.ReqGenCEwbPl.TripSheetEwbBills item = new EWBJson.ReqGenCEwbPl.TripSheetEwbBills();
                item.ewbNo = 341000898267L;
                reqCEWB.tripSheetEwbBills.add(item);
                TxnRespWithObjAndInfo<EWBJson.RespGenCEwbPl> txnResp = apiCall.GenerateCEWB(EwbSession, reqCEWB);

                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else
                    txtResponce.setText(txnResp.TxnOutcome);
            }
        });
        //cancel EWB On button Click
        btnCancelEWB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                EWBJson.ReqCancelEwbPl reqCancelEWB = new EWBJson.ReqCancelEwbPl();
                reqCancelEWB.ewbNo = 341000867270L;
                reqCancelEWB.cancelRsnCode = 2;
                reqCancelEWB.cancelRmrk = "Cancelled the order";
                TxnRespWithObjAndInfo<EWBJson.RespCancelEwbPl> txnResp = apiCall.CancelEWB(EwbSession, reqCancelEWB);

                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else
                    txtResponce.setText(txnResp.TxnOutcome);
            }
        });
        //Reject EWB On button click
        btnRejectEWB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                EWBJson.ReqRejectEwbPl reqRejectEWB = new EWBJson.ReqRejectEwbPl();
                reqRejectEWB.ewbNo = 481000612981L;
                TxnRespWithObjAndInfo<EWBJson.RespRejectEwbPl> txnResp = apiCall.RejectEWB(EwbSession, reqRejectEWB);

                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else
                    txtResponce.setText(txnResp.TxnOutcome);
            }
        });
        //Get EWBDetail on buttn click
        getEWBDetailButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String EwbNo = "301002180467";
                TxnRespWithObjAndInfo<EWBJson.RespGetEWBDetail> txnResp = apiCall.GetEWBDetail(EwbSession, EwbNo);
                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else
                    txtResponce.setText(txnResp.TxnOutcome);
            }
        });
        // Get EWB Detail assign for transporter on button click
        btnEwbAssignForTrans.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String Date = "27/03/2018";
                TxnRespWithObjAndInfo<List<EWBJson.AssignedEWBItem>> txnResp = apiCall.GetEWBAssignedForTrans(EwbSession, Date);
                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else
                    txtResponce.setText(txnResp.TxnOutcome);
            }
        });
        //Get EWB Detail assign to transporter by GSTIN on button click
        btnAssToTransByGSTIN.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String genGSTIN = "08AABCW0619D1ZO";
                String Date = "27/03/2018";
                TxnRespWithObjAndInfo<List<EWBJson.AssignedEWBItem>> txnResp = apiCall.GetEWBForTranSByGstin(EwbSession, Date, genGSTIN);
                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else
                    txtResponce.setText(txnResp.TxnOutcome);

            }
        });
        //gET CEWB On button click
        getCEWBButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String tripSheetNo = "3310002612";
                TxnRespWithObjAndInfo<EWBJson.GetConsolidatedEWB> txnResp = apiCall.GetConsolidatedEWB(EwbSession, tripSheetNo);
                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else
                    txtResponce.setText(txnResp.TxnOutcome);
            }
        });
        //Get ewb gen on req of other party on button click
        btnEWBGenReqOnOthParty.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String Date = "27/03/2018";
                TxnRespWithObjAndInfo<List<EWBJson.EwayBillsofOtherParty>> txnResp = apiCall.GetEWBofOthParty(EwbSession, Date);
                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else
                    txtResponce.setText(txnResp.TxnOutcome);

            }
        });
        //Update Transporter
        btnUpdateTrans.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                EWBJson.ReqUpdtTransporterPl reqUpdtTrans = new EWBJson.ReqUpdtTransporterPl();
                reqUpdtTrans.ewbNo = 121212121212L;
                reqUpdtTrans.transporterId = "12121212121212";
                TxnRespWithObjAndInfo<EWBJson.RespUpdtTransporterPl> txnResp = apiCall.UpdtTransporter(EwbSession, reqUpdtTrans);
                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else
                    txtResponce.setText(txnResp.TxnOutcome);
            }
        });
        btnExtendValidity.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
               EWBJson.ReqExtendValidityEWBPl reqExtValidity = new EWBJson.ReqExtendValidityEWBPl();
                reqExtValidity.ewbNo = 771082861592L;
                reqExtValidity.vehicleNo = "PVC1234";
                reqExtValidity.fromPlace = "Bengaluru";
                reqExtValidity.fromState = 23;
                reqExtValidity.remainingDistance = 7000;
                reqExtValidity.transDocNo = "1234";
                reqExtValidity.transDocDate = "";
                reqExtValidity.extnRemarks = "Flood";
                reqExtValidity.extnRsnCode = 1;
                reqExtValidity.transMode = "5";
                reqExtValidity.fromPincode = 450001;
                reqExtValidity.consignmentStatus = "T";
                reqExtValidity.transitType = "R";
                reqExtValidity.addressLine1 = "Bengaluru";
                reqExtValidity.addressLine2 = "Bengaluru";
                reqExtValidity.addressLine3 = "Bengaluru";
                TxnRespWithObjAndInfo<EWBJson.RespExtendValidityEWBPl> txnResp = apiCall.ExtendValidityOfEWB(EwbSession, reqExtValidity);
                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else{
                    txtResponce.setText(txnResp.TxnOutcome + "\n" + txnResp.RespObj);
                    if(txnResp.TxnOutcome.contains("702")) {
                        EC.RespInfoPl respInfoPl = new EC.RespInfoPl();
                        respInfoPl = gson.fromJson(txnResp.Info, EC.RespInfoPl.class);
                        reqExtValidity.remainingDistance = (Integer.valueOf(respInfoPl.distance));
                        txnResp = apiCall.ExtendValidityOfEWB(EwbSession, reqExtValidity);
                        if (txnResp.IsSuccess == true)
                            txtResponce.setText(gson.toJson(txnResp.RespObj));
                        else
                            txtResponce.setText(txnResp.TxnOutcome);

                    }
                }
            }
        });
        btnReGenCEWB.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                EWBJson.ReqReGenerateCEWBPl reqReGenCEWB = new EWBJson.ReqReGenerateCEWBPl();
                reqReGenCEWB.tripSheetNo = 1710001952;
                reqReGenCEWB.vehicleNo = "PQR1234";
                reqReGenCEWB.fromPlace = "Bengaluru";
                reqReGenCEWB.fromState = 29;
                reqReGenCEWB.transDocNo = "1234 ";
                reqReGenCEWB.transDocDate = "26/04/2018 ";
                reqReGenCEWB.transMode = "1";
                reqReGenCEWB.reasonCode = 1;
                reqReGenCEWB.reasonRem = "Flood";
                TxnRespWithObjAndInfo<EWBJson.RespReGenerateCEWBPl> txnResp = apiCall.ReGenCEWB(EwbSession, reqReGenCEWB);
                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else
                    txtResponce.setText(txnResp.TxnOutcome);
            }
        });
        btnGetGSTINDetail.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String GSTIN = "05AAACG1078M1ZL";
                TxnRespWithObjAndInfo<EWBJson.GSTINDetail> txnResp = apiCall.GetGSTNDetail(EwbSession, GSTIN);
                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else
                    txtResponce.setText(txnResp.TxnOutcome);
            }
        });
        btnTransinDetail.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String trn_no = "01AMDPA2430P1ZK";
                TxnRespWithObjAndInfo<EWBJson.TransinDetail> txnResp = apiCall.GetTransinDetail(EwbSession, trn_no);
                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else
                    txtResponce.setText(txnResp.TxnOutcome);
            }
        });
        btnHSNDetail.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String Hsncode = "1001";
                TxnRespWithObjAndInfo<EWBJson.HSNDetail> txnResp = apiCall.GetHSNDetail(EwbSession, Hsncode);
                if (txnResp.IsSuccess)
                    txtResponce.setText(gson.toJson(txnResp.RespObj));
                else
                    txtResponce.setText(txnResp.TxnOutcome);
            }
        });
        //Multi Vehicle Movement APIs
        initiateMulVehMovButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                EWBJson.ReqIniMultiVehicleMov objIniMultiVehUpd = new EWBJson.ReqIniMultiVehicleMov();
                objIniMultiVehUpd.ewbNo = 311001444888L;
                objIniMultiVehUpd.reasonCode = "1";
                objIniMultiVehUpd.reasonRem = "vehicle broke down";
                objIniMultiVehUpd.fromPlace = "BANGALORE";
                objIniMultiVehUpd.fromState = 29;
                objIniMultiVehUpd.toPlace = "Chennai";
                objIniMultiVehUpd.toState = 33;
                objIniMultiVehUpd.transMode = "1";
                objIniMultiVehUpd.totalQuantity = 33;
                objIniMultiVehUpd.unitCode = "BOX";

                TxnRespWithObjAndInfo<EWBJson.RespIniMultiVehicleMov> TxnResp = apiCall.InitiateMultiVehMovnt(EwbSession, objIniMultiVehUpd);
                if(TxnResp.IsSuccess == true)
                    txtResponce.setText(gson.toJson(TxnResp.RespObj));
                else
                    txtResponce.setText(TxnResp.TxnOutcome);

            }
        });
        addMultiVehButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                EWBJson.ReqMultiVehAdd objReqMulVehAdd = new EWBJson.ReqMultiVehAdd();
                objReqMulVehAdd.ewbNo = 311001444888L;
                objReqMulVehAdd.groupNo = "1";
                objReqMulVehAdd.vehicleNo = "PQR1234";
                objReqMulVehAdd.transDocNo = "1234";
                objReqMulVehAdd.transDocDate = "12/10/2017";
                objReqMulVehAdd.quantity = 15;

                TxnRespWithObjAndInfo<EWBJson.RespMultiVehAdd> TxnResp = apiCall.AddVehDetail(EwbSession, objReqMulVehAdd);
                if(TxnResp.IsSuccess == true)
                    txtResponce.setText(gson.toJson(TxnResp.RespObj));
                else
                    txtResponce.setText(TxnResp.TxnOutcome);
            }
        });
        btnUpdtMulVeh.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                EWBJson.ReqMultiVehUpdt objReqMulVehUpdt = new EWBJson.ReqMultiVehUpdt();
                objReqMulVehUpdt.ewbNo = 311001444888L;
                objReqMulVehUpdt.groupNo = "1";
                objReqMulVehUpdt.oldvehicleNo = "PQR1234";
                objReqMulVehUpdt.newVehicleNo = "PQR1234";
                objReqMulVehUpdt.oldTranNo = "ABC123";
                objReqMulVehUpdt.newTranNo = "PQR123";
                objReqMulVehUpdt.fromPlace = "Lucknow";
                objReqMulVehUpdt.fromState = 9;
                objReqMulVehUpdt.reasonCode = "1";
                objReqMulVehUpdt.reasonRem = "vehicle broke down";
                TxnRespWithObjAndInfo<EWBJson.RespMultiVehUpdt> TxnResp = apiCall.UpdtMultiVeh(EwbSession, objReqMulVehUpdt);
                if(TxnResp.IsSuccess == true)
                    txtResponce.setText(gson.toJson(TxnResp.RespObj));
                else
                    txtResponce.setText(TxnResp.TxnOutcome);
            }
        });
        getErrorListButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {

                TxnRespWithObjAndInfo<List<EWBJson.RespError>> TxnResp = apiCall.GetErrorList(EwbSession);
                if(TxnResp.IsSuccess == true)
                    txtResponce.setText(gson.toJson(TxnResp.RespObj));
                else
                    txtResponce.setText(TxnResp.TxnOutcome);
            }
        });
        btnGetEwbGenByConsignor.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String strDocType = "INV";
                String strDocNo = "111-33";
                TxnRespWithObjAndInfo<EWBJson.RespEwbDetGenByConsigner> TxnResp = apiCall.GetEwayBillGeneratedByConsignor(EwbSession, strDocType, strDocNo);
                if(TxnResp.IsSuccess == true)
                    txtResponce.setText(gson.toJson(TxnResp.RespObj));
                else
                    txtResponce.setText(TxnResp.TxnOutcome);
            }
        });
        btnEWBApiBal.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                TxnRespWithObjAndInfo<EWBJson.EwbApiBalance> TxnResp = apiCall.GetEwbBal(EwbSession);
                if(TxnResp.IsSuccess == true)
                    txtResponce.setText(gson.toJson(TxnResp.RespObj));
                else
                    txtResponce.setText(TxnResp.TxnOutcome);
            }
        });
        btnGetEWBForTransByState.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String strDate= "14/03/2019";
                int strStateCode = 05;
                TxnRespWithObjAndInfo<List<EWBJson.RespGetEwayBillsForTranByState>> TxnResp = apiCall.GetEwayBillsForTransporterByState(EwbSession,strDate, strStateCode);
                if(TxnResp.IsSuccess == true)
                    txtResponce.setText(gson.toJson(TxnResp.RespObj));
                else
                    txtResponce.setText(TxnResp.TxnOutcome);
            }
        });
        btnGetEwbDetByDate.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String strDate= "28/03/2019";
                TxnRespWithObjAndInfo<List<EWBJson.RespGetEwayBillsByDate>> TxnResp = apiCall.GetEwayBillsByDate(EwbSession,strDate);
                if(TxnResp.IsSuccess == true)
                    txtResponce.setText(gson.toJson(TxnResp.RespObj));
                else
                    txtResponce.setText(TxnResp.TxnOutcome);
            }
        });

        btnRejectedEwbByDate.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                String strDate= "14/03/2019";
                TxnRespWithObjAndInfo<List<EWBJson.RespGetEwayBillsRejectedByOthers>> TxnResp = apiCall.GetEwayBillsRejectedByOthers(EwbSession,strDate);
                if(TxnResp.IsSuccess == true)
                    txtResponce.setText(gson.toJson(TxnResp.RespObj));
                else
                    txtResponce.setText(TxnResp.TxnOutcome);
            }
        });

        printEWBButton.addActionListener(new ActionListener() {
            @Override
            public void actionPerformed(ActionEvent e) {
                long EwbNo = 331001764133L;
                byte[] pdfFileResp = null;
                String strPath = String.valueOf(EwbNo) + ".pdf";

                TxnRespWithObjAndInfo<EWBJson.RespGetEWBDetail> TxnResp = apiCall.GetEWBDetail(EwbSession, Long.toString(EwbNo));
                if (TxnResp.IsSuccess == true)
                {
                    pdfFileResp = apiCall.PrintEWB(EwbSession, TxnResp.RespObj, true);
                    try{
                        File file = new File(strPath);
                        OutputStream os = new FileOutputStream(file);
                        os.write(pdfFileResp);
                        os.close();
                        Desktop.getDesktop().open(file);
                    }catch (IOException ex){
                        ex.getMessage();
                    }
                }
                else
                    txtResponce.setText(TxnResp.TxnOutcome);
            }
        });
    }
    public void SaveLoginDetail(){

        try (Writer writer = new FileWriter("EwbApiLoginDetails.json"))
        {
//            Gson gson = new GsonBuilder()
//                    .registerTypeAdapter(DateTime.class, new JsonSerializer<DateTime>(){
//                        @Override
//                        public JsonElement serialize(DateTime json, Type typeOfSrc, JsonSerializationContext context) {
//                            return new JsonPrimitive(ISODateTimeFormat.dateTime().print(json));
//                        }
//                    })
//                    .create();

            Gson gson = new GsonBuilder().create();

            gson.toJson(EwbSession.EWBLoginDetails,writer);
            JOptionPane.showMessageDialog(null,"Ewb ApiLoginDetails Saved Successfully.");
        }
        catch (Exception E){
           String a = E.getMessage();
        }
    }
    public void DisplayApiSettings(){

        try (Reader reader = new FileReader("EwbApiSettings.json"))
        {
            Gson gson = new Gson();
            EwbSession.EWBSettings= gson.fromJson(reader,EWBAPISetting.class);
            txtGSPName.setText(EwbSession.EWBSettings.GSPName);
            txtAspUserID.setText(EwbSession.EWBSettings.AspUserId);
            txtAspPassword.setText(EwbSession.EWBSettings.AspPassword);
            txtClientID.setText(EwbSession.EWBSettings.EWBClientId);
            txtClientSecret.setText(EwbSession.EWBSettings.EWBClientSecret);
            txtGSPUserID.setText(EwbSession.EWBSettings.EWBGSPUserID);
            txtBaseUrl.setText(EwbSession.EWBSettings.BaseUrl);
        }
        catch (Exception E){}
    }
    public void LoadLoginDetails(){

//        try (Reader reader = new FileReader("EwbApiLoginDetails.json"))
//        {
//            Gson gson = new Gson();
//            EwbSession.EWBLoginDetails= gson.fromJson(reader,EWBAPILoginDetails.class);
//        }
//        catch (Exception E){}

        try (Reader reader = new FileReader("EwbApiLoginDetails.json"))
        {
//            Gson gson = new GsonBuilder()
//                    .registerTypeAdapter(DateTime.class, new JsonDeserializer<DateTime>(){
//                        @Override
//                        public DateTime deserialize(JsonElement je, Type type, JsonDeserializationContext jdc) throws JsonParseException
//                        {
//                            return je.getAsString().length() == 0 ? null : ISODateTimeFormat.dateTime().withZoneUTC().parseDateTime(je.getAsString());
//                        }
//                    })
//                    .create();
            Gson gson = new GsonBuilder().create();
            EwbSession.EWBLoginDetails= gson.fromJson(reader,EWBAPILoginDetails.class);
            if(EwbSession.EWBLoginDetails != null){
                txtEWBGstin.setText(EwbSession.EWBLoginDetails.EwbGstin);
                txtEwbUserId.setText(EwbSession.EWBLoginDetails.EwbUserID);
                txtEwbPassword.setText(EwbSession.EWBLoginDetails.EwbPassword);
                txtAppKey.setText(EwbSession.EWBLoginDetails.EwbAppKey);
                txtAuthToken.setText(EwbSession.EWBLoginDetails.EwbAuthToken);
        //       txtTokenExp.setText(EwbSession.EWBLoginDetails.EwbTokenExp.toString());
                txtEWBGstin.setText(EwbSession.EWBLoginDetails.EwbGstin);
                txtSEK.setText(EwbSession.EWBLoginDetails.EwbSEK);
            }

        }
        catch (Exception E){}

    }
    public void DisplayLoginDetails(){
        txtEWBGstin.setText(EwbSession.EWBLoginDetails.EwbGstin);
        txtEwbUserId.setText(EwbSession.EWBLoginDetails.EwbUserID);
        txtEwbPassword.setText(EwbSession.EWBLoginDetails.EwbPassword);
        txtAppKey.setText(EwbSession.EWBLoginDetails.EwbAppKey);
        txtAuthToken.setText(EwbSession.EWBLoginDetails.EwbAuthToken);
//        txtTokenExp.setText((EwbSession.EWBLoginDetails.EwbTokenExp).toString());
        txtEWBGstin.setText(EwbSession.EWBLoginDetails.EwbGstin);
        txtSEK.setText(EwbSession.EWBLoginDetails.EwbSEK);
    }

    private void createUIComponents() {
        // TODO: place custom component creation code here
    }
    @Override
    public  void  ReceivedAuthToken(){
        SaveLoginDetail();
        DisplayLoginDetails();
    }

    public void GetAuthToken(){
        TxnRespWithObjAndInfo<EWBSession> TxnResp = apiCall.GetAuthToken(EwbSession);
        if (TxnResp.IsSuccess) {
            // Call Refresh Display Api Login Details to refresh auth token and Exp Time in display & DisplayLoginDetails Setting also saved
            SaveLoginDetail();
            DisplayLoginDetails();
        }
        txtResponce.append(TxnResp.TxnOutcome);
    }

}

