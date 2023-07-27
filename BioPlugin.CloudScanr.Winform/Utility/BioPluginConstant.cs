using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioPlugin.CloudScanr.Winform.Utility
{
    public class BioPluginConstant
    {
        public const string CloudScanrURL = "http://localhost:15896/api/CloudABISV10Captures/";


        public const string QuickScan = "Enable";
        public const string DeviceName = "TwoPrintFutronic";
        public const int CaptureTimeOut = 300;
        public const string TemplateFormat = "M2ICS";
        public const string EngineName = "FP2";

        #region information and error message
        public const string REGISTRATION_ID_NOT_FOUND = "Registration ID not found.";
        public const string EMPTY_REGISTRATION_ID = "Please provide a registration ID number.";
        public const string CHANGE_ID = "Please provide both registration ID number and old registration number.";
        public const string CAPTUREFAILED = "Capture Failed. ";
        #endregion
    }
}
