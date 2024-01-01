using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RDRestService.Constants
{
    public static class Instruction
    {
        public const string RunApplication = "129";
        public const string SetAxisParameter = "5";
        public const string GetAxisParameter = "6";
        public const string StoreAxisParameter = "7";
        public const string SetGlobalParameter = "9";
        public const string GetGlobalParameter = "10";
        public const string StoreGlobalParameter = "11";
        public const string SetSwitchOutput = "14";
        public const string GetGlobalInOut = "15";
        public const string ResetRobotSoftware = "131";
    }
    public static class AddressBank
    {
        public const string MainBank = "1";
        public const string GetParameterBank = "2";
    }
    public static class Motors
    {
        public const string Vertical = "0";
        public const string PigHolder = "1";
        public const string CapHolder = "2";
        public const string Piston = "3";
        public const string HeadRoatate = "4";
        public const string extra = "5";
        public const string Motor0 = "0";
        public const string Motor1 = "1";
        public const string Motor2 = "2";
        public const string Motor3 = "3";
        public const string Motor4 = "4";
        public const string RightLimitSwitch = "10";
        public const string LeftLimitSwitch = "11";

    }
    public static class MotorsCurrentPositions
    {
        public const string Vertical = "0";
        public const string PigHolder = "1";
        public const string CapHolder = "2";
        public const string Piston = "3";
        public const string HeadRoatate = "4";
    }
    public static class SwitchInputs
    {
        public const string VialShieldInPlace = "0";
        public const string VerticalHomeSensor = "1";
        public const string CapHolderHomeNeedle = "3";
        public const string VialShieldOpen = "5";
        public const string NeeldeInPosition = "6";
        public const string PigInPlace = "7";
        public const string SyringeInPlace = "11";
    }
    public static class SwitchOutputs
    {
        public const string GreenLED = "0";
        public const string RedLED = "1";
        public const string NeedlePowerSensor = "2";
        public const string ShieldVial = "3";
        public const string Out_4 = "4";
        public const string Out_5 = "5";
        public const string VertialLock = "6";
        public const string VialShieldCover = "7";
    }
    // When adding new System Variables, you have to add them in three places to make them show up on the return
    //First, add them there as a variable.
    //Second, if you need to load them you need to add it to the TMCConn LoadGlobalIndividualValue()
    //Third you need to add them to TMCConn LoadAllGlobalVariables
    //Last you need to add them to RobotSystemVariables below
    //This will then make them show up on the list of global values.
    public static class SystemVariables
    {
        //Negative Values are stored in the appconfig 
        //Positive values are stored in the robot hardware
        public const string MaxVolume = "-1";                                                                                                       // change to GB_Max_Volume_current = 160
        public const string FirmwareCurrentVersion = "0";    // Current version
        public const string SyringeType = "1";       // {BD_syringe = 1, HenryShine_syringe = 2, DPS_3 = 3, Syringe_4  =  4}
        public const string DrawWaitTime = "2";      // 200 - 2s                                                                                    // i'd like to move it // and use this location for SOMETHING ELSE
        public const string InitDone = "3";          // Do not Use (Automatic when robot is started)
        public const string HomingDone = "4";        // Find_Home - Only at power up                                                                // i'd like to move it // and use this location for SOMETHING ELSE
        public const string CurrentState = "5";                                                                                                     // i'd like to move it // and use this location for "installed FW version" .. currently - V1.47
        // WAITING_INIT_DRAW_DOSE = 10    this the state after the power up as well
        // RUNNING_INIT_DRAW_DOSE = 20
        // WAITING_DRAW_DOSE      = 30    at this state it is possible as well to run INIT_DRAW_DOSE (6)
        // RUNNING_DRAW_DOSE      = 40
        // WAITING_CHECK_DONE     = 50
        // RUNNING_CHECK_DONE     = 60
        // STOPPED_ON_ERROR       = 70
        // STOPPED_TIME_OUT       = 80
        public const string HardwareSerialNumber = "6";
        public const string VerticalHomePosition = "7";   //Position for the rotation adjustment
        public const string LoadingHomePosition = "8";   //Position for Suringe Loading
        public const string BumpPositionVertical = "9";  //Needle touches the vial rubber
        public const string NeedleLength = "10"; //[mm]
        public const string NeedleGauge = "11"; //21,22,23,25
        public const string CyclesTotal = "12";    //  
        public const string AdjustCyclesTotal = "13";    // 
        public const string ReadyToDraw = "14";    // After VerifyReady                                                                             // i'd like to move it // and use this location for SOMETHING ELSE
        public const string InitialVolume = "15";    // Including PreFill + DrawVolume + adjust
        public const string MotorIsMoving = "16";    //Detect that the motors are running
        public const string DoseCalibratorDepth = "17";  //Dose Calibrator Depth
        public const string HomingShortDone = "18";   //Not sure what this does           --- YOU don't use it                                      // i'd like to move it // and use this location for SOMETHING ELSE
        public const string UnitsToMove = "19";     // Used for Manual Move or dechange on                                                          // i'd like to move it // and use this location for SOMETHING ELSE
        public const string ShowOverride = "20";     //1 = will not check for pig removal (GP 28 error)
        public const string AirToPullBefore = "21";    // in Percentage. Normal is 70%
        public const string ActivityIsCorrect = "22";    // the results from the dosimeter are OK {1 = good, 2 = no}                                // i'd like to move it // and use this location for SOMETHING ELSE
        public const string PreFillVolume = "23";    // [micro Litter]                                                                             // i'd like to move it // and use this location for SOMETHING ELSE
        public const string PreFillRequest = "24";    // prefill =  1 / no prefill =  0                                                                             // i'd like to move it // and use this location for SOMETHING ELSE
        public const string RandomNeedleInsertion = "26";  //Used for the random needle insertion
        public const string MicroLToWithdraw = "27";    // microL to withdraw. If to return to vail, reduce this number to the required amount
                                                        //errors are here
        public const string OperationError = "28";
            //BitEr_pigWasNotReplaced   = %00000000001 // bit    1  left ref sensor
            //BitEr_syringePoppedOut    = %00000000010 // bit    2  syringe popped out during cycle
            //BitEr_VialPoppedOut       = %00000000100 // bit    4  vial popped out during cycle
            //BitEr_PigPoppedOut        = %00000001000 // bit    8
            //BitEr_pigHolderNotAtHome  = %00000010000 // bit   16
            //BitEr_machineAborted      = %00000100000 // bit   32
            //BitEr_needleBentRotate    = %00001000000 // bit   64
            //BitEr_doseCalibDipper     = %00010000000 // bit  128
            //BitEr_DipperSensorBlocked = %00100000000 // bit  256
            //BitEr_needleBentCap       = %01000000000 // bit  512
            //BitEr_capSensorBlocked    = %10000000000 // bit 1024  check that the vertical did not move down on the cap holder
            //BitEr_bentCapBeforePIG   = %100000000000 // bit 2048  before entering syringe into pig, found bent syring with cap

        public const string AnyError = "29";    // any error occured
        public const string MotorVertical = "30";
        public const string MotorPigHolder = "31";
        public const string MotorCapHolder = "32";
        public const string MotorPiston = "33";
        public const string MotorHeadRotate = "34";
        public const string SyringeIsIn = "35";     //FIND_HOMES or INIT_DRAW -- There is a Syring in the system and this cannot be done
        public const string NeedleInVial = "36";        //FIND_HOMES or INIT_DRAW -- There is a hand in the way
        public const string SyringeMissing = "37";  //DRAW_DOSE -- Missing the Syring
        public const string VialMissing = "38";     //DRAW_DOSE -- Missing the Vial
        public const string PigMissing = "39";      //DRAW_DOSE -- Missing the PIG
        public const string VolumeExceedsLimits = "40";
        public const string PreFillExceedsLimit = "41";
        public const string VialShieldNotOpen = "42";
        public const string FindHomeError = "43";
        //BitError
        // 00001 = Syringe Is In While Find Home
        // 00010 = Pig Holder Is In While Find Home
        // 00100 = Cap Holder Is In While Find Home
        public const string WrongPCCommand = "44";
        //BitError
        //  0000001 = Expecting Initi Draw Dose
        //  0000010 = Expecting Draw Dose
        //  0000100 = Expecting Check Done
        //  0001000 = Error Adjus Or Again
        public const string PigBelowSyringe = "45";
        public const string RecapPositionPig = "46";
        public const string CapHoldsSyringe = "47";
        public const string PistonHomePosition = "48";
        public const string HeadRotateHomePosition = "49";
        public const string CenterOfVial = "50";
        public const string AdditionalBump = "51";
        public const string TryDrawAgain = "52";
        public const string SqueezeCapHeight = "53";
        public const string NeedleAtCapOffset = "55";
        public const string PigWasChanged = "190";
        public const string SyringeWOCapInPig = "197";
        public const string RetreatMovementComplete = "198";
    }
    public static class GeneralFunctions
    {
      //  public const string INIT = "0"; //Runs on power on
        public const string FindHomes = "2";   // Will test all axis 
        public const string ClearAllErros = "4";
        public const string InitDrawDose = "6";
        public const string DrawDose = "8";
        public const string CheckDone = "10";
        public const string Abort = "12";
        public const string VerifyReady = "14";
        public const string FindHomesShort = "18";
        public const string LedsOff = "22";
        public const string RedLedOn = "24";
        public const string GreenLedOn = "26";
        public const string YellowLedOn = "28";
        public const string HomeHeadRotateMotor = "58";
        public const string HomeVerticalMotor = "102";
        public const string SetCenterOfSeptum = "106";
        public const string SetCenterOfReCap = "108";
        public const string HomePistionMotor = "104";
        public const string HomePigHolderMotor = "120";
        public const string HomeCapHolderMotor = "122";
        public const string LowerDipper = "126";
        public const string RetretFromVial = "134";
        public const string VerticalManual = "136";
        public const string PigHolderManual = "138";
        public const string CapHolderManual = "140";
        public const string PistonManual = "142";
        public const string RotationManual = "144";
        public const string RobotReset = "131";
        public const string DoseCalibratorCheck = "146";
        public const string capVibrate = "148";
        public const string ExtractFromDoseCalibrator = "150";
        
    }
}
namespace RDRestService
{
    public class Parameters
    {
        public RobotSystemVariables SystemVariables;

        public Parameters()
        {
            SystemVariables = new RobotSystemVariables();
        }
        public class RobotSystemVariables
        {
            public string MaxVolume { get; set; } = "";    // Current version
            public string FirmwareCurrentVersion { get; set; } = "";    // Current version
            public string ServiceCurrentVersion { get; set; } = "1.3.0";
            public string SyringeType { get; set; } = "";    // {BD_syringe = 1, HenryShine_syringe = 2, Syringe_3 = 3, Syringe_4  =  4}
            public string DrawWaitTime { get; set; } = "";
            public string InitDone { get; set; } = "";    //
            public string HomingDone { get; set; } = "";    //
            public string CurrentState { get; set; } = ""; //possible
            public string HardwareSerialNumber { get; set; } = "";
            public string VerticalHomePosition { get; set; } = "";
            public string LoadingHomePosition { get; set; } = "";
            public string BumpPositionVertical { get; set; } = "";
            public string NeedleLength { get; set; } = ""; //[mm]
            public string NeedleGauge { get; set; } = ""; //21,22,23,25
            public string CyclesTotal { get; set; } = "";    //  
            public string AdjustCyclesTotal { get; set; } = "";    // 
            public string ReadyToDraw { get; set; } = "";
            public string InitialVolume { get; set; } = "";    // Including PreFill + Draw Dose + adjust
            public string MotorIsMoving { get; set; } = "";
            public string DoseCalibratorDepth { get; set; } = "";
            public string HomingShortDone { get; set; } = "";
            public string UnitsToMove { get; set; } = "";    // Percent of regular draw speed 0 = normal speed 2000 uL/s
            public string ShowOverride { get; set; } = "";    // in Percentage. Normal is 70%
            public string AirToPullBefore { get; set; } = "";    // in Percentage. Normal is 70%
            public string ActivityIsCorrect { get; set; } = "";    // the results from the dosimeter are OK {1 = good, 2 = no}
            public string PreFillVolume { get; set; } = "";    // [micro Litter]
            public string PreFillRequest { get; set; } = "";    //  1 / 0
            public string RandomNeedleInsertion { get; set; } = "";
            public string MicroLToWithdraw { get; set; } = "";    // microL to withdraw. If to return to vail, reduce this number to the required amount
            public string PigBelowSyringe { get; set; } = "";
            public string RecapPositionPig { get; set; } = "";
            public string CapHoldsSyringe { get; set; } = "";
            public string PistonHomePosition { get; set; } = "";
            public string HeadRotateHomePosition { get; set; } = "";
            public string CenterOfVial { get; set; } = "";
            public string AdditionalBump { get; set; } = "";
            public string TryDrawAgain { get; set; } = "";
            public string NeedleAtCapOffset { get; set; } = "";
            public string PigWasChanged { get; set; } = "";
            public string RetreatMovementComplete { get; set;} = "";
            public string SqueezeCapHeight { get; set; } = "";


            //errors are here
            public string AnyError { get; set; } = "";    // any error occured
            public string MotorVertical { get; set; } = "";
            public string MotorPigHolder { get; set; } = "";
            public string MotorCapHolder { get; set; } = "";
            public string MotorPiston { get; set; } = "";
            public string MotorHeadRotate { get; set; } = "";
            public string SyringeIsIn { get; set; } = "";     //FIND_HOMES or INIT_DRAW -- There is a Syring in the system and this cannot be done
            public string NeedleInVial { get; set; } = "";        //FIND_HOMES or INIT_DRAW -- There is a hand in the way
            public string SyringeMissing { get; set; } = "";  //DRAW_DOSE -- Missing the Syring
            public string VialMissing { get; set; } = "";     //DRAW_DOSE -- Missing the Vial
            public string PigMissing { get; set; } = "";     //DRAW_DOSE -- Missing the PIG
            public string VolumeExceedsLimits { get; set; } = "";
            public string PreFillExceedsLimit { get; set; } = "";
            public string VialShieldNotOpen { get; set; } = "";
            public string OperationError { get; set; } = "";
            // BitEr_pigWasNotReplaced   = %0000000001 // bit  1  left ref sensor
            // BitEr_syringePoppedOut    = %0000000010 // bit  2  syringe popped out during cycle
            // BitEr_VialPoppedOut       = %0000000100 // bit  4  vial popped out during cycle
            // BitEr_PigPoppedOut        = %0000001000 // bit  8
            // BitEr_pigHolderNotAtHome  = %0000010000 // bit  16
            // BitEr_machineAborted      = %0000100000 // bit  32
            // BitEr_needleBent          = %0001000000 // bit  64
            // Biter_doseCalibDipper     = %0010000000 // bit  128
            // Biter_DipperSensorBlocked = %0100000000 // bit  256
            // Biter_needleBentCap       = %1000000000


            public string FindHomeError { get; set; } = "";
            //BitError
            // 00001 = Syringe Is In While Find Home
            // 00010 = Pig Holder Is In While Find Home
            // 00100 = Cap Holder Is In While Find Home
            public string WrongPCCommand { get; set; } = "";
            //BitError
            //  00001 = Expecting Initi Draw Dose
            //  00010 = Expecting Draw Dose
            //  00100 = Expecting Check Done
            //  01000 = Error Adjust Or Again
         }
    }
    //-------------------------------------------------------------------------
    public class ErrorsValues
    {
        public string AnyError { get; set; } = "29";    // any error occured

        public MotorErrors MotorError;
        public GeneralErrors GeneralError;

        public ErrorsValues()
        {
            MotorError = new MotorErrors();
            GeneralError = new GeneralErrors();
        }

        public class MotorErrors
        {
            /*
                motor_errors for each of parameters 30-34
                BitEr_leftRefSensor  =  %00000001 // bit  0  left ref sensor
                BitEr_rightRefSensor =  %00000010 // bit  1  right ref sensor
                BitEr_homeNotFound   =  %00000100 // bit  2  did not find home
                BitEr_TimeOut        =  %00001000 // bit  4
                BitEr_CalibrationErr =  %00010000 // bit  5
                BitEr_RetreatFromVialErr =  %00100000 // bit  6
                BitEr_7              =  %01000000 // bit  7
            */
            public string Vertical { get; set; } = "";
            public string PigHolder { get; set; } = "";
            public string CapHolder { get; set; } = "";
            public string Piston { get; set; } = "";
            public string HeadRotate { get; set; } = "";
        }
        public class GeneralErrors
        {
            public string SyringeIsIn { get; set; } = "";     //FIND_HOMES or INIT_DRAW -- There is a Syring in the system and this cannot be done
            public string NeedleInVial { get; set; } = "";        //FIND_HOMES or INIT_DRAW -- There is a hand in the way
            public string SyringeMissing { get; set; } = "";  //DRAW_DOSE -- Missing the Syring
            public string VialMissing { get; set; } = "";     //DRAW_DOSE -- Missing the Vial
            public string PigMissing { get; set; } = "";      //DRAW_DOSE -- Missing the PIG
            public string VolumeExceedsLimits { get; set; } = "";
            public string PreFillExceedsLimit { get; set; } = "";
            public string VialShieldNotOpen { get; set; } = "";
            public string OperationError { get; set; } = "";
            // BitEr_pigWasNotReplaced  =  %00000001 // bit  1  left ref sensor
            // BitEr_syringePoppedOut   =  %00000010 // bit  2  syringe popped out during cycle
            // BitEr_VialPoppedOut      =  %00000100 // bit  4  vial popped out during cycle
            // BitEr_PigPoppedOut       =  %00001000 // bit  8
            // BitEr_pigHolderNotAtHome =  %00010000 // bit  16
            // BitEr_machineAborted     =  %00100000 // bit  32
            // BitEr_needleBent         =  %01000000 // bit  64
            // Biter_doseCalibDipper    =  %10000000 // bit  128
            // Biter_DipperSensorBlocked = %100000000 // bit  256

            public string FindHome { get; set; } = "";
            // BitError
            // BitEr_syringeIsInwhileFindHome      =  %00000001 // bit  0  
            // BitEr_pigHolderIsInWhileFindHome    =  %00000010 // bit  1 
            // BitEr_capHolderIsInWhileFindHome    =  %00000100 // bit  2  
            public string WrongPCCommand { get; set; } = "";
            // BitError
            // BitEr_expecting_InitDrawDose        =  %00000001 // bit  0  
            // BitEr_expecting_drawDose            =  %00000010 // bit  1 
            // BitEr_expecting_CheckDone           =  %00000100

        }
    }
    //-------------------------------------------------------------------------
    public class SystemStatus
    {
        /*
            //In_VailShieldInPlace = 0 //
            In_VerticalHomeSensor = 1 // Home switch input for motor 0
            In_handDetected       = 2 // not there, just for future adding
            //In_CapHolderHomeNeedle     = 3 // the syringe is in place
            In_VailShieldLock     = 4 //
            In_VailShieldOpen     = 5 // the solenoid shield is open
            In_NeedleInPosition   = 6 // Needle is in place to enter vail
            //In_PigInPlace         = 7 // The Pig is in place
           */
        public string PigInPlace { get; set; } = "";
        public string CapHolderHomeNeedle { get; set; } = "";
        public string SyringeInPlace { get; set; } = "";
        public string VialInPlace { get; set; } = "";
        public string VerticalHomeSensor { get; set; } = "";
        public string VialShieldOpen { get; set; } = "";
        public string NeedleInPosition { get; set; } = ""; //Needle is below the system.
        public string GeneralError { get; set; } = "";
        public string CurrentState { get; set; } = "";
        public string Status { get; set; } = "";
        public string SyringeInPigWithOutCap { get; set; } = "";
        public string Motor0RightLimitSwitch { get; set; } = "";
        public string Motor0LeftLimitSwich { get; set; } = "";
        public string Motor1RightLimitSwitch { get; set; } = "";
        public string Motor1LeftLimitSwich { get; set; } = "";
        public string Motor2RightLimitSwitch { get; set; } = "";
        public string Motor2LeftLimitSwich { get; set; } = "";
        public string Motor3RightLimitSwitch { get; set; } = "";
        public string Motor3LeftLimitSwich { get; set; } = "";
        public string Motor4LeftLimitSwich { get; set; } = "";
    }
    /// <summary>
    /// Returns the system simple values.  These are designed for a short messages about the status of the system, and in non-blocking.
    /// </summary>
    /// <remarks>The following are the possible returns from the system.  Each item can be different depending on the calling function: <br/><br/>
    /// Note:  Setter Communications:<br/>
    ///     {"Status": "Register [RegisterNumber] Set to [value]","Success": true }<br/>
    ///     {"Status": "Set Register Failed","Success": false } <br/>
    ///     {"Status": "Needle Length set to [value]","Success": true } <br/>
    ///     {"Status": "Needle Length set failed","Success": false } <br/>
    ///     {"Status": "Needle Gauge set to [value]","Success": true } <br/>
    ///     {"Status": "Needle Gauge set failed","Success": false } <br/>
    ///     {"Status": "Vertical Home Position set to [value]","Success": true } <br/>
    ///     {"Status": "Vertical Home Position set failed","Success": false } <br/>
    ///     {"Status": "Syringe type set to [value]","Success": true } <br/>
    ///     {"Status": "Syringe type set failed","Success": false } <br/>
    ///     {"Status": "Loading Position set to [value]","Success": true } <br/>
    ///     {"Status": "Loading Position set failed","Success": false } <br/>
    ///     {"Status": "Bump Position Vertical Position set to [value]","Success": true } <br/>
    ///     {"Status": "Bump Position Vertical Position set failed","Success": false } <br/>
    ///     {"Status": "Pig Below Syringe Position set to [value]","Success": true } <br/>
    ///     {"Status": "Pig Below Syringe Position set failed","Success": false } <br/>
    ///     {"Status": "Recap pig Position set to [value]","Success": true } <br/>
    ///     {"Status": "Recap pig Position set failed","Success": false } <br/>
    ///     {"Status": "Cap Holder Position set to [value]","Success": true } <br/>
    ///     {"Status": "Cap Holder Position set failed","Success": false } <br/>
    ///     {"Status": "Piston Home Position set to [value]","Success": true } <br/>
    ///     {"Status": "Piston Home Position set failed","Success": false } <br/>
    ///     {"Status": "Head Rotate Home Position set to [value]","Success": true } <br/>
    ///     {"Status": "Head Rotate Home Position set failed","Success": false } <br/>
    ///     {"Status": "Center of Vial Position set to [value]","Success": true } <br/>
    ///     {"Status": "Center of Vial Position set failed","Success": false } <br/>
    ///     {"Status": "Show Override set to [value]","Success": true } <br/>
    ///     {"Status": "Show Override set failed","Success": false } <br/>
    ///     {"Status": "Dose Calibrator Depth set to [value]","Success": true } <br/>
    ///     {"Status": "Dose Calibrator Depth set failed","Success": false } <br/>
    ///     {"Status": "Needle At Cap Offset set to [value]","Success": true } <br/>
    ///     {"Status": "Needle At Cap Offset set failed","Success": false } <br/><br/>
    /// Note: These are system errors and require a clear error and initialization:<br/>
    ///     {"Status": "Cap Holder Motor Error - [Motor error number]","Success": false } <br/>
    ///     {"Status": "Head Rotate Motor Error - [Motor error number]","Success": false } <br/>
    ///     {"Status": "Pig Holder Motor Error -  [Motor error number]","Success": false } <br/>
    ///     {"Status": "Piston Motor Error -  [Motor error number]","Success": false } <br/>
    ///     {"Status": "Vertical Motor Error -  [Motor error number]","Success": false } <br/>
    ///     {"Status": "Operation Error -  [General Operation Error Value]","Success": false } <br/>
    ///     {"Status": "Hand is in the way error","Success": false } <br/>
    ///     {"Status": "Pig is missing error","Success": false } <br/>
    ///     {"Status": "Syringe is in error","Success": false } <br/>
    ///     {"Status": "Syringe is missing error","Success": false } <br/>
    ///     {"Status": "Vial is missing error","Success": false } <br/><br/>
    /// Note: These are warnings and do not require a clear error and initialization:<br/>
    ///     {"Status": "Aborted","Success": true } <br/>
    ///     {"Status": "Abort Failed","Success": false } <br/>
    ///     {"Status": "Waiting For Initialization","Success": false } <br/>
    ///     {"Status": "Pig Was Not Changed","Success": false } <br/>
    ///     {"Status": "Pig is Missing","Success": false } <br/>
    ///     {"Status": "Vial is Missing","Success": false } <br/>
    ///     {"Status": "Syringe is Missing","Success": false } <br/><br/>
    /// Note: These are operational messages:<br/>
    ///     {"Status": "Ready","Success": true } <br/>
    ///     {"Status": "Value to large - [Value]","Success": false } <br/>
    ///     {"Status": "Value to small - [Value]","Success": false } <br/>
    ///     {"Status": "In Chamber [Value]","Success": true } <br/>
    ///     {"Status": "PreCal Volume [Value]","Success": true } <br/>
    ///     {"Status": "Running FillingDose","Success": true } <br/>
    ///     {"Status": "Running AdjustDoseByVolume","Success": true } <br/>
    ///     {"Status": "Running Complete","Success": true } <br/>
    ///     {"Status": "Running PreCalibrate","Success": true } <br/>
    ///     {"Status": "System Error","Success": false } <br/>
    ///     {"Status": "Running FillingDose","Success": true } <br/>
    ///     {"Status": "Running FillingDose","Success": true } <br/>
    ///     {"Status": "Running FillingDose","Success": true } <br/>
    /// </remarks>
    /// <example> On the computer running the service:
    ///     http://127.0.0.1:8733/RDService/GetStatus 
    /// </example>
    public class SimpleSystemStatus
    {
        public string Status { get; set; } = "";
        public bool Success { get; set; } = true;
    }
    public class ReadMotorPositions
    {
        public string Vertical { get; set; } = "";
        public string PigHolder { get; set; } = "";
        public string CapHolder { get; set; } = "";
        public string Piston { get; set; } = "";
        public string HeadRoatate { get; set; } = "";
    }
    public class GetGlobalValue
    {
        public string GlobalRegister { get; set; } = "";
        public string GlobalValue { get; set; } = "";
    }
    public class GetDigitalValue
    {
        public string DigitalRegister { get; set; } = "";
        public string DigitalValue { get; set; } = "";
    }


}
//-------------------------------------------------------------------------




