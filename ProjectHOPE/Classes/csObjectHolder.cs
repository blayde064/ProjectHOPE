using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.IO;
using System.IO.Ports;
using System.Data.SqlClient;
using System.Data.Common;
using System.Data.OleDb;
using System.Collections;
using System.Drawing.Printing;
using System.Diagnostics;
using Microsoft.Win32;
using System.Globalization;

namespace csObjectHolder
{
    public class csObjectHolder
    {

        #region Instances
        //**
        //instance for this class
        private static csObjectHolder ObjectHolder_instance = null;
        public static csObjectHolder ObjectHolderInstance()
        {
            if (ObjectHolder_instance == null)
                ObjectHolder_instance = new csObjectHolder();
            return ObjectHolder_instance;
        }

        private static csObjectHolder ObjectHolder_instanceLeft = null;
        public static csObjectHolder ObjectHolderInstanceLeft()
        {
            if (ObjectHolder_instanceLeft == null)
                ObjectHolder_instanceLeft = new csObjectHolder();
            return ObjectHolder_instanceLeft;
        }

        private static csObjectHolder ObjectHolder_instanceRight = null;
        public static csObjectHolder ObjectHolderInstanceRight()
        {
            if (ObjectHolder_instanceRight == null)
                ObjectHolder_instanceRight = new csObjectHolder();
            return ObjectHolder_instanceRight;
        }

        //instance for frmBarcodeCenter

        //**
        #endregion



        #region Xducer Test Variables

        private string xducerSerialNum;
        public string XducerSerialNum //serial number for xducer
        {
            get { return xducerSerialNum; }
            set { xducerSerialNum = value; }
        }

        private bool autoClosefrmMessageBox = false; //want to be able to close this form automatically
        public bool AutoClosefrmMessageBox
        {
            get { return autoClosefrmMessageBox; }
            set { autoClosefrmMessageBox = value; }
        }

        private string sonarString = string.Empty;
        public string SonarString
        {
            get { return sonarString; }
            set { sonarString = value; }
        }

        #endregion


        //***
        #region AS 360SSI Burn In
        private bool bunit1PassFail = false;
        public bool bUnit1PassFail //
        {
            get { return bunit1PassFail; }
            set { bunit1PassFail = value; }
        }

        private bool bunit1TestInProgress = false;
        public bool bUnit1TestInProgress //
        {
            get { return bunit1TestInProgress; }
            set { bunit1TestInProgress = value; }
        }

        private bool bunit2PassFail = false;
        public bool bUnit2PassFail //
        {
            get { return bunit2PassFail; }
            set { bunit2PassFail = value; }
        }

        private bool bunit2TestInProgress = false;
        public bool bUnit2TestInProgress //
        {
            get { return bunit2TestInProgress; }
            set { bunit2TestInProgress = value; }
        }

        private bool bunit3PassFail = false;
        public bool bUnit3PassFail //
        {
            get { return bunit3PassFail; }
            set { bunit3PassFail = value; }
        }

        private bool bunit3TestInProgress = false;
        public bool bUnit3TestInProgress //
        {
            get { return bunit3TestInProgress; }
            set { bunit3TestInProgress = value; }
        }

        private bool bunit4PassFail = false;
        public bool bUnit4PassFail //
        {
            get { return bunit4PassFail; }
            set { bunit4PassFail = value; }
        }

        private bool bunit4TestInProgress = false;
        public bool bUnit4TestInProgress //
        {
            get { return bunit4TestInProgress; }
            set { bunit4TestInProgress = value; }
        }

        private bool bunit5PassFail = false;
        public bool bUnit5PassFail //
        {
            get { return bunit5PassFail; }
            set { bunit5PassFail = value; }
        }

        private bool bunit5TestInProgress = false;
        public bool bUnit5TestInProgress //
        {
            get { return bunit5TestInProgress; }
            set { bunit5TestInProgress = value; }
        }

        private int inumberofTestsUnit1 = 0;
        public int iNumberofTestsUnit1 //
        {
            get { return inumberofTestsUnit1; }
            set { inumberofTestsUnit1 = value; }
        }

        private int inumberofTestsUnit2 = 0;
        public int iNumberofTestsUnit2 //
        {
            get { return inumberofTestsUnit2; }
            set { inumberofTestsUnit2 = value; }
        }

        private int inumberofTestsUnit3 = 0;
        public int iNumberofTestsUnit3 //
        {
            get { return inumberofTestsUnit3; }
            set { inumberofTestsUnit3 = value; }
        }

        private int inumberofTestsUnit4 = 0;
        public int iNumberofTestsUnit4 //
        {
            get { return inumberofTestsUnit4; }
            set { inumberofTestsUnit4 = value; }
        }

        private int inumberofTestsUnit5 = 0;
        public int iNumberofTestsUnit5 //
        {
            get { return inumberofTestsUnit5; }
            set { inumberofTestsUnit5 = value; }
        }

        private bool babortTest = false;
        public bool bAbortTest //
        {
            get { return babortTest; }
            set { babortTest = value; }
        }

        private ArrayList alipAddress = new ArrayList();
        public ArrayList alIPAddress
        {
            get { return alipAddress; }
            set { alipAddress = value; }
        }

        private ArrayList alserverReturnData1 = new ArrayList();
        public ArrayList alServerReturnData1
        {
            get { return alserverReturnData1; }
            set { alserverReturnData1 = value; }
        }

        private ArrayList alserverReturnData2 = new ArrayList();
        public ArrayList alServerReturnData2
        {
            get { return alserverReturnData2; }
            set { alserverReturnData2 = value; }
        }

        private ArrayList alserverReturnData3 = new ArrayList();
        public ArrayList alServerReturnData3
        {
            get { return alserverReturnData3; }
            set { alserverReturnData3 = value; }
        }

        private ArrayList alserverReturnData4 = new ArrayList();
        public ArrayList alServerReturnData4
        {
            get { return alserverReturnData4; }
            set { alserverReturnData4 = value; }
        }

        private ArrayList alserverReturnData5 = new ArrayList();
        public ArrayList alServerReturnData5
        {
            get { return alserverReturnData5; }
            set { alserverReturnData5 = value; }
        }

        private string sunitIpAddress1;
        public string sUnitIpAddress1 //
        {
            get { return sunitIpAddress1; }
            set { sunitIpAddress1 = value; }
        }

        private string sunitIpAddress2;
        public string sUnitIpAddress2 //
        {
            get { return sunitIpAddress2; }
            set { sunitIpAddress2 = value; }
        }

        private string sunitIpAddress3;
        public string sUnitIpAddress3 //
        {
            get { return sunitIpAddress3; }
            set { sunitIpAddress3 = value; }
        }

        private string sunitIpAddress4;
        public string sUnitIpAddress4 //
        {
            get { return sunitIpAddress4; }
            set { sunitIpAddress4 = value; }
        }

        private string sunitIpAddress5;
        public string sUnitIpAddress5 //
        {
            get { return sunitIpAddress5; }
            set { sunitIpAddress5 = value; }
        }

        private int icurrentUnitToSearch = 0;
        public int iCurrentUnitToSearch //
        {
            get { return icurrentUnitToSearch; }
            set { icurrentUnitToSearch = value; }
        }

        private string sserial1;
        public string sSerial1 //
        {
            get { return sserial1; }
            set { sserial1 = value; }
        }

        private string sserial2 = "";
        public string sSerial2//
        {
            get { return sserial2; }
            set { sserial2 = value; }
        }

        private string sserial3 = "";
        public string sSerial3 //
        {
            get { return sserial3; }
            set { sserial3 = value; }
        }

        private string sserial4 = "";
        public string sSerial4 //
        {
            get { return sserial4; }
            set { sserial4 = value; }
        }

        private string sserial5 = "";
        public string sSerial5 //
        {
            get { return sserial5; }
            set { sserial5 = value; }
        }
        #endregion
        //



        private bool _ActuatorsInitialized = false; //for checking to see if we made connection with the actuators
        public bool ActuatorsInitialized //Product Test
        {
            get { return _ActuatorsInitialized; }
            set { _ActuatorsInitialized = value; }
        }

        private bool automaticUPCPrint = false; //used so i can print UPC labels automatically at packing
        public bool AutomaticUPCPrint //HB Packing Center
        {
            get { return automaticUPCPrint; }
            set { automaticUPCPrint = value; }
        }

        private bool automaticReprint = false; //used so i can reprint labels automatically after scan
        public bool AutomaticReprint //HB Shipping Labels
        {
            get { return automaticReprint; }
            set { automaticReprint = value; }
        }

        private int baudRate;
        public int BaudRate //
        {
            get { return baudRate; }
            set { baudRate = value; }
        }

        private bool _BenchTestReTest;
        public bool BenchTestReTest // 
        {
            get { return _BenchTestReTest; }
            set { _BenchTestReTest = value; }
        }

        private bool bgps_ProgrammingComplete;
        public bool bGPS_ProgrammingInProgress // 
        {
            get { return bgps_ProgrammingComplete; }
            set { bgps_ProgrammingComplete = value; }
        }

        private string btninputFromIO;
        public string btnInputFromIO //
        {
            get { return btninputFromIO; }
            set { btninputFromIO = value; }
        }

        private bool _CameraSetupInTestMode;
        public bool CameraSetupInTestMode
        {
            get { return _CameraSetupInTestMode; }
            set { _CameraSetupInTestMode = value; }
        }

        private bool changeInstructionFont = false;
        public bool ChangeInstructionFont //Change instruction font
        {
            get { return changeInstructionFont; }
            set { changeInstructionFont = value; }
        }

        private bool changeInstructionFontTuning = false;
        public bool ChangeInstructionFontTuning //Change instruction font for Tuning
        {
            get { return changeInstructionFontTuning; }
            set { changeInstructionFontTuning = value; }
        }


        private bool changetoUCC = false; //used so i can use the same form and do two different labels
        public bool ChangeToUCC //HB UCC labels and HB UPC labels
        {
            get { return changetoUCC; }
            set { changetoUCC = value; }
        }

        private bool changetoXducer = false; //used so i can use the same form and do two different labels
        public bool ChangeToXducer //xducer label and HB Serial labels
        {
            get { return changetoXducer; }
            set { changetoXducer = value; }
        }

        private bool changetoGeoSerial = false; //used so i can use the same form and do two different labels
        public bool ChangeToGeoSerial //Geo Serial Labels
        {
            get { return changetoGeoSerial; }
            set { changetoGeoSerial = value; }
        }

        private bool _ChangeModelNumberONIX = false;
        public bool ChangeModelNumberONIX
        {
            get { return _ChangeModelNumberONIX; }
            set { _ChangeModelNumberONIX = value; }
        }

        private string _CognexCameraJobsPath = ""; //@"\\eudb01\Cognex Camera Jobs\";
        public string CognexCameraJobspath
        {
            get { return _CognexCameraJobsPath; }
            set { _CognexCameraJobsPath = value; }
        }

        private Color _HumminbirdGold = Color.FromArgb(254, 186, 18);
        public Color HumminbirdGold
        {
            get { return _HumminbirdGold; }
            set { _HumminbirdGold = value; }
        }

        private bool bcontinueFromGPStoTesting = false;
        public bool bContinueFromGPStoTesting //
        {
            get { return bcontinueFromGPStoTesting; }
            set { bcontinueFromGPStoTesting = value; }
        }

        private string currentSectionOfTest;
        public string CurrentSectionOfTest //
        {
            get { return currentSectionOfTest; }
            set { currentSectionOfTest = value; }
        }

        private string currentSerialNum;
        public string CurrentSerialNum //
        {
            get { return currentSerialNum; }
            set { currentSerialNum = value; }
        }

        private string currentTestID;
        public string CurrentTestID //
        {
            get { return currentTestID; }
            set { currentTestID = value; }
        }

        private bool dontConfirm = false;
        public bool DontConfirm //used for confirming the process when uploading serial numbers to the registration file
        {
            get { return dontConfirm; }
            set { dontConfirm = value; }
        }

        private bool _DualTesting;
        public bool DualTesting
        {
            get { return _DualTesting; }
            set { _DualTesting = value; }
        }

        private bool bemailSentStatus = false;
        public bool bEmailSentStatus //
        {
            get { return bemailSentStatus; }
            set { bemailSentStatus = value; }
        }

        private bool extButtonPressed = false;
        public bool ExtButtonPressed //used for confirming the process when uploading serial numbers to the registration file
        {
            get { return extButtonPressed; }
            set { extButtonPressed = value; }
        }

        #region Duplicate Variables
        private string dup_sn;
        public string dup_SN
        {
            get { return dup_sn; }
            set { dup_sn = value; }
        }

        private string dup_wo;
        public string dup_WO
        {
            get { return dup_wo; }
            set { dup_wo = value; }
        }

        private string dup_date;
        public string dup_Date
        {
            get { return dup_date; }
            set { dup_date = value; }
        }

        private string dup_assy;
        public string dup_Assy
        {
            get { return dup_assy; }
            set { dup_assy = value; }
        }

        private string dup_boxnum;
        public string dup_BoxNum
        {
            get { return dup_boxnum; }
            set { dup_boxnum = value; }
        }
        #endregion   

        private int gpsmaxCNO = 0;
        public int gpsMaxCNO //for GPS testing
        {
            get { return gpsmaxCNO; }
            set { gpsmaxCNO = value; }
        }

        private int gpsminCNO = 0;
        public int gpsMinCNO //for GPS testing
        {
            get { return gpsminCNO; }
            set { gpsminCNO = value; }
        }

        private int gpsMessagecount = 0;
        public int gpsMessageCount //for GPS testing
        {
            get { return gpsMessagecount; }
            set { gpsMessagecount = value; }
        }

        private bool gps_Programming = false;
        public bool GPS_Programming
        {
            get { return gps_Programming; }
            set { gps_Programming = value; }
        }

        private int gpssat1 = 0;
        public int gpsSat1 //for GPS testing
        {
            get { return gpssat1; }
            set { gpssat1 = value; }
        }

        private int gpssat2 = 0;
        public int gpsSat2 //for GPS testing
        {
            get { return gpssat2; }
            set { gpssat2 = value; }
        }

        private int gpssat3 = 0;
        public int gpsSat3 //for GPS testing
        {
            get { return gpssat3; }
            set { gpssat3 = value; }
        }

        private int gpssat4 = 0;
        public int gpsSat4 //for GPS testing
        {
            get { return gpssat4; }
            set { gpssat4 = value; }
        }
        private int gpssat5 = 0;
        public int gpsSat5 //for GPS testing
        {
            get { return gpssat5; }
            set { gpssat5 = value; }
        }

        private int gpssat6 = 0;
        public int gpsSat6 //for GPS testing
        {
            get { return gpssat6; }
            set { gpssat6 = value; }
        }

        private int gpssat7 = 0;
        public int gpsSat7 //for GPS testing
        {
            get { return gpssat7; }
            set { gpssat7 = value; }
        }

        private int gpssat8 = 0;
        public int gpsSat8 //for GPS testing
        {
            get { return gpssat8; }
            set { gpssat8 = value; }
        }

        private int gpssat9 = 0;
        public int gpsSat9 //for GPS testing
        {
            get { return gpssat9; }
            set { gpssat9 = value; }
        }

        private int gpssat10 = 0;
        public int gpsSat10 //for GPS testing
        {
            get { return gpssat10; }
            set { gpssat10 = value; }
        }

        private int gpssat11 = 0;
        public int gpsSat11 //for GPS testing
        {
            get { return gpssat11; }
            set { gpssat11 = value; }
        }

        private int gpssat12 = 0;
        public int gpsSat12 //for GPS testing
        {
            get { return gpssat12; }
            set { gpssat12 = value; }
        }

        private string _SqlServerName;
        public string SqlServerName
        {
            get { return _SqlServerName; }
            set { _SqlServerName = value; }
        }

        private string hummingBirdConnectionString = "Data Source=<SQLSERVERNAME>; Initial Catalog=HummingBird;Persist Security Info=True;User ID=inhouse;Password=Password1";
        public string HummingBirdConnectionString //
        {
            get { return hummingBirdConnectionString; }
            set { hummingBirdConnectionString = value; }
        }

        private string _HB_ECO_ConnectionString = "Data Source=<SQLSERVERNAME>;Initial Catalog=HB_ECO;Persist Security Info=True;User ID=inhouse;Password=Password1";
        public string HB_ECO_ConnectionString //
        {
            get { return _HB_ECO_ConnectionString; }
            set { _HB_ECO_ConnectionString = value; }
        }

        private string eEPTConnectionString = "Data Source=<SQLSERVERNAME>;Initial Catalog=EEPT;Persist Security Info=True;User ID=inhouse;Password=Password1";
        public string EEPTConnectionString //
        {
            get { return eEPTConnectionString; }
            set { eEPTConnectionString = value; }
        }

        private string hOPEConnectionString = "Data Source=<SQLSERVERNAME>;Initial Catalog=HOPE;Persist Security Info=True;User ID=inhouse;Password=Password1; MultipleActiveResultSets = True";
        public string HOPEConnectionString //
        {
            get { return hOPEConnectionString; }
            set { hOPEConnectionString = value; }
        }

        private string purchasingConnectionString = "Data Source=<SQLSERVERNAME>;Initial Catalog=Purchasing;Persist Security Info=True;User ID=inhouse;Password=Password1";
        public string PurchasingConnectionString //
        {
            get { return purchasingConnectionString; }
            set { purchasingConnectionString = value; }
        }

        private string trainingConnectionString = "Data Source=<SQLSERVERNAME>;Initial Catalog=Training;Persist Security Info=True;User ID=inhouse;Password=Password1";
        public string TrainingConnectionString //
        {
            get { return trainingConnectionString; }
            set { trainingConnectionString = value; }
        }

        private string productTestConnectionString = "Data Source=<SQLSERVERNAME>;Initial Catalog=ProductTest;Persist Security Info=True;User ID=inhouse;Password=Password1";
        public string ProductTestConnectionString //
        {
            get { return productTestConnectionString; }
            set { productTestConnectionString = value; }
        }

        private string _RepairConnectionString = "Data Source=<SQLSERVERNAME>;Initial Catalog=Repair;Persist Security Info=True;User ID=inhouse;Password=Password1";
        public string RepairConnectionString //
        {
            get { return _RepairConnectionString; }
            set { _RepairConnectionString = value; }
        }

        private string _YesDBConnectionString = "Data Source=<SQLSERVERNAME>;Initial Catalog=YesDB;Persist Security Info=True;User ID=inhouse;Password=Password1";
        public string YesDBConnectionString //
        {
            get { return _YesDBConnectionString; }
            set { _YesDBConnectionString = value; }
        }

        private string _TestConnectionString = "Data Source=<SQLSERVERNAME>;Initial Catalog=Test;Persist Security Info=True;User ID=inhouse;Password=Password1";
        public string TestConnectionString //
        {
            get { return _TestConnectionString; }
            set { _TestConnectionString = value; }
        }

        private string _VisitorPortalConnectionString = "Data Source=<SQLSERVERNAME>;Initial Catalog=VisitorPortal;Persist Security Info=True;User ID=inhouse;Password=Password1";
        public string VisitorPortalConnectionString //
        {
            get { return _VisitorPortalConnectionString; }
            set { _VisitorPortalConnectionString = value; }
        }

        private string _SQLServerConnectionString = "Data Source=<SQLSERVERNAME>;Persist Security Info=True;User ID=inhouse;Password=Password1";
        public string SQLServerConnectionString //
        {
            get { return _SQLServerConnectionString; }
            set { _SQLServerConnectionString = value; }
        }

        private int icurrentBeam = 0;
        public int iCurrentBeam //for GPS testing
        {
            get { return icurrentBeam; }
            set { icurrentBeam = value; }
        }

        private bool iceMotorDirectionOK = false;
        public bool ICEMotorDirectionOK
        {
            get { return iceMotorDirectionOK; }
            set { iceMotorDirectionOK = value; }
        }

        private int ieolRowCount = 0;
        public int iEolRowCount //
        {
            get { return ieolRowCount; }
            set { ieolRowCount = value; }
        }

        private int ipreRowCount = 0;
        public int iPreRowCount //
        {
            get { return ipreRowCount; }
            set { ipreRowCount = value; }
        }

        private int ipostRowCount = 0;
        public int iPostRowCount //
        {
            get { return ipostRowCount; }
            set { ipostRowCount = value; }
        }

        private bool _IO_Available;
        public bool IO_Available
        {
            get { return _IO_Available; }
            set { _IO_Available = value; }
        }

        private bool ignoreIOInputs = false;
        public bool IgnoreIOInputs
        {
            get { return ignoreIOInputs; }
            set { ignoreIOInputs = value; }
        }

        private int _LogErrorCount;
        public int LogErrorCount
        {
            get { return _LogErrorCount; }
            set { _LogErrorCount = value; }
        }

        private bool isStepperMotor = false;
        public bool IsStepperMotor
        {
            get { return isStepperMotor; }
            set { isStepperMotor = value; }
        }

        private bool itemdeleted = false;
        public bool ItemDeleted
        {
            get { return itemdeleted; }
            set { itemdeleted = value; }
        }

        //private string[] largeClass = { "H07", "H19", "H20", "H23", "H29", "H25" };
        private string[] largeClass = { "NNE", "ELN", "G12", "EGT", "G10" }; //this is ProdModel from ItemMaster table
        public string[] largeclass
        {
            get { return largeClass; }
            set { largeClass = value; }
        }

        private DateTime lastTestTime;
        public DateTime LastTestTime //
        {
            get { return lastTestTime; }
            set { lastTestTime = value; }
        }

        private bool _LogClassStandAlone;
        public bool bStandAlone
        {
            get { return _LogClassStandAlone; }
            set { _LogClassStandAlone = value; }
        }

        private string mACAddress;
        public string MACAddress //
        {
            get { return mACAddress; }
            set { mACAddress = value; }
        }

        private string meterReading5;
        public string MeterReading5 //the reading that is displayed on the meter (COM5)
        {
            get { return meterReading5; }
            set { meterReading5 = value; }
        }

        private string meterReading8;
        public string MeterReading8 //the reading that is displayed on the meter (COM8)
        {
            get { return meterReading8; }
            set { meterReading8 = value; }
        }

        private int multiplyvoltageby = 0;
        public int MultiplyVoltageBy //number to multiply transmit voltage by
        {
            get { return multiplyvoltageby; }
            set { multiplyvoltageby = value; }
        }

        private string currentOS;
        public string CurrentOS //Operating System
        {
            get { return currentOS; }
            set { currentOS = value; }
        }

        private string packAmount;
        public string PackAmount //the amount of boxes that are inside a master box
        {
            get { return packAmount; }
            set { packAmount = value; }
        }

        private string packID;
        public string PackID //the unique ID for a particular box
        {
            get { return packID; }
            set { packID = value; }
        }

        private string partDescription;
        public string PartDescription //units part name/description
        {
            get { return partDescription; }
            set { partDescription = value; }
        }

        private string partNumber;
        public string PartNumber //units part number
        {
            get { return partNumber; }
            set { partNumber = value; }
        }

        private bool bpauseTimerUnitConnected;
        public bool bPauseTimerUnitConnected // pauses timer
        {
            get { return bpauseTimerUnitConnected; }
            set { bpauseTimerUnitConnected = value; }
        }

        private bool personalCable;
        public bool PersonalCable
        {
            get { return personalCable; }
            set { personalCable = value; }
        }

        private string programNameForLogFiles;
        public string ProgramNameForLogFiles //name that the log folder will be named
        {
            get { return programNameForLogFiles; }
            set { programNameForLogFiles = value; }
        }

        private string prodCat;
        public string ProdCat //stores the ProdCat from ItemMaster
        {
            get { return prodCat; }
            set { prodCat = value; }
        }

        private bool _EraseSPI = false;
        public bool EraseSPI
        {
            get { return _EraseSPI; }
            set { _EraseSPI = value; }
        }

        private bool _IsREWORK = false;
        public bool IsREWORK
        {
            get { return _IsREWORK; }
            set { _IsREWORK = value; }
        }

        private bool scopeControllerError;
        public bool ScopeControllerError // set this if there is an error in the scope controller class
        {
            get { return scopeControllerError; }
            set { scopeControllerError = value; }
        }

        private string _SerialLabelType = "";
        public string SerialLabelType
        {
            get { return _SerialLabelType; }
            set { _SerialLabelType = value; }
        }

        private string shift;
        public string Shift //current shift working
        {
            get { return shift; }
            set { shift = value; }
        }

        private bool showDebugForm;
        public bool ShowDebugForm // set this if i want the debug form to show up
        {
            get { return showDebugForm; }
            set { showDebugForm = value; }
        }

        private string softwareVersion;
        public string SoftwareVersion //used to hold the units software version
        {
            get { return softwareVersion; }
            set { softwareVersion = value; }
        }

        private bool _SonarHold;
        public bool SonarHold
        {
            get { return _SonarHold; }
            set { _SonarHold = value; }
        }

        private bool bsqlError;
        public bool bSqlError // set this if there has been a sql problem
        {
            get { return bsqlError; }
            set { bsqlError = value; }
        }

        private ArrayList tempAssyList = new ArrayList();
        public ArrayList TempAssyList
        {
            get { return tempAssyList; }
            set { tempAssyList = value; }
        }

        private bool _TestInProgressLeft = false;
        public bool TestInProgress
        {
            get { return _TestInProgressLeft; }
            set { _TestInProgressLeft = value; }
        }

        private string testLogEndString = "\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\";
        public string TestLogEndString //string that is used to end a log for a new test
        {
            get { return testLogEndString; }
            set { testLogEndString = value; }
        }

        private string testLogStartString = "////////////////////";
        public string TestLogStartString //string that is used to start a log for a new test
        {
            get { return testLogStartString; }
            set { testLogStartString = value; }
        }

        private double[] transmitInfo = new double[4];
        public double[] TransmitInfo
        {
            get { return transmitInfo; }
            set { transmitInfo = value; }
        }

        private int transmitPulsesReceived = 0;
        public int TransmitPulsesReceived //for sonar tuning check test
        {
            get { return transmitPulsesReceived; }
            set { transmitPulsesReceived = value; }
        }

        private string tuningValue = "";
        public string TuningValue //bool to see what the tuning value
        {
            get { return tuningValue; }
            set { tuningValue = value; }
        }

        private string uccNum;
        public string UCCNum //UCC number for the master label
        {
            get { return uccNum; }
            set { uccNum = value; }
        }

        private string _UDP_TalkerAddress = "192.168.1.255";
        public string UDP_TalkerAddress
        {
            get { return _UDP_TalkerAddress; }
            set { _UDP_TalkerAddress = value; }
        }


        private bool _UnitConnected;
        public bool UnitConnected // whether unit is connected or not
        {
            get
            {
                return _UnitConnected;
            }
            set
            {
                if (_UnitConnected != value)
                {
#if Win7Debug || Win7Release
                    debugForm = Product_Test.frmDebug.Instance(); 
                    if (value == false)
                        debugForm.frmMainLog("UNIT IS NOT CONNECTED");
                    else if (value == true)
                        debugForm.frmMainLog("UNIT IS CONNECTED"); 
#endif
                }

                _UnitConnected = value;
            }
        }

        /// <summary>
        /// Use only for old Product Test
        /// </summary>
        private bool _bUnitConnected;
        public bool bUnitConnected
        {
            get { return _bUnitConnected; }
            set { _bUnitConnected = value; }
        }

        private string userlevel = "";
        public string UserLevel //HB ECO
        {
            get { return userlevel; }
            set { userlevel = value; }
        }

        private bool warehouseUser;
        public bool WarehouseUser // is the user from the Warehouse or not
        {
            get { return warehouseUser; }
            set { warehouseUser = value; }
        }

        private string whichDisplay_OptrexOrTianma;
        public string WhichDisplay_OptrexOrTianma //Need to know which display is being used on monochrome units
        {
            get { return whichDisplay_OptrexOrTianma; }
            set { whichDisplay_OptrexOrTianma = value; }
        }

        private string _WhichSide = "";
        public string WhichSide
        {
            get { return _WhichSide; }
            set { _WhichSide = value; }
        }

        private bool wo_Complete = false;
        public bool WO_Complete //bool to ask the user if they are through with the WO or not
        {
            get { return wo_Complete; }
            set { wo_Complete = value; }
        }

        private string _WONumber = "";
        public string WONumber
        {
            get { return _WONumber; }
            set { _WONumber = value; }
        }

        public void vGetServerName(string sPath)
        {
            using (StreamReader sr = new StreamReader((string.IsNullOrEmpty(sPath) ? @"\\joi\eu\Collaboration\EEPT\SQL Server Information.txt" : sPath), true))
            {
                string sServerInformation = sr.ReadToEnd();
                string[] sa;
                char[] delimiterChars = { '\r', '\n' };
                sa = sServerInformation.Split(delimiterChars, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < sa.Length; i++)
                {
                    if (sa[i].Contains("Server Name"))
                    {
                        SqlServerName = sa[i].Replace("\r", "").Replace("\n", "").Replace("Server Name = ", "").Trim();

                        if (!string.IsNullOrEmpty(SqlServerName))
                        {
                            EEPTConnectionString = EEPTConnectionString.Replace("<SQLSERVERNAME>", SqlServerName);
                            HOPEConnectionString = HOPEConnectionString.Replace("<SQLSERVERNAME>", SqlServerName);
                            HB_ECO_ConnectionString = HB_ECO_ConnectionString.Replace("<SQLSERVERNAME>", SqlServerName);
                            HummingBirdConnectionString = HummingBirdConnectionString.Replace("<SQLSERVERNAME>", SqlServerName);
                            ProductTestConnectionString = ProductTestConnectionString.Replace("<SQLSERVERNAME>", SqlServerName);
                            PurchasingConnectionString = PurchasingConnectionString.Replace("<SQLSERVERNAME>", SqlServerName);
                            TrainingConnectionString = TrainingConnectionString.Replace("<SQLSERVERNAME>", SqlServerName);
                            YesDBConnectionString = YesDBConnectionString.Replace("<SQLSERVERNAME>", SqlServerName);
                            RepairConnectionString = RepairConnectionString.Replace("<SQLSERVERNAME>", SqlServerName);
                            TestConnectionString = TestConnectionString.Replace("<SQLSERVERNAME>", SqlServerName);
                            VisitorPortalConnectionString = VisitorPortalConnectionString.Replace("<SQLSERVERNAME>", SqlServerName);
                            SQLServerConnectionString = SQLServerConnectionString.Replace("<SQLSERVERNAME>", SqlServerName);
                        }
                    }
                }
            }
        }
    }
}
