using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BioPlugin.CloudScanr.Winform.Model
{
    public class CloudScanrCaptureResult
    {
        /// <summary>
        /// Contains CloudScanr Capture Result
        /// </summary>
        public CloudScanrCaptureResult()
        {
            CloudScanrStatus = new CloudScanrStatus();
        }
        /// <summary>
        /// Request information
        /// </summary>
        public CloudScanrStatus CloudScanrStatus { get; set; }
        /// <summary>
        /// Captured biometric template data in XML format. (Template data itself is Base64 encoded within XML message.). This fields containts FingerPrint, FingerVein, Face templates
        /// </summary>
        public string TemplateData { get; set; }
        /// <summary>
        /// Captured biometric image data in XML format. (Image data itself is Base64 encoded within XML message.). This fields containts Iris capture images and all biometric images
        /// </summary>
        public string BioImageData { get; set; }
        /// <summary>
        /// Captured face image data. (Face image data itself is Base64 encoded.). Default face image format is JPEG
        /// </summary>
        public string FaceImageData { get; set; }
        /// <summary>
        /// Capture ID. This ID should be unique for every capture request
        /// </summary>
        public string CaptureID { get; set; }
        /// <summary>
        /// Unique key. Indicats machine identification
        /// </summary>
        public string MachineKey { get; set; }
        /// <summary>
        /// Details response message
        /// </summary>
        public string Message { get; set; }

    }
    public class CloudScanrStatus
    {
        /// <summary>
        /// Capture Response
        /// </summary>
        public CloudScanrStatus()
        {
            Success = false;
            Message = string.Empty;
            ResponseCode = string.Empty;
            NumOfItemCount = 0;

        }

        /// <summary>
        /// Contain CloudScanr API version
        /// </summary>
        public string CloudScanrAPIVersion { get; set; }
        /// <summary>
        /// Request status. The value will be true/false. If this value is true that means the request has success otherwise you should check message and response code to get the proper information regarding a request.
        /// </summary>
        public bool Success { get; set; }
        /// <summary>
        /// Contains request success/failed message.
        /// </summary>
        public string Message { get; set; }
        /// <summary>
        /// Device name that is being used while capturing biometric data
        /// </summary>
        public string DeviceName { get; set; }
        /// <summary>
        /// Capture tool version
        /// </summary>
        public string CaptureToolVersion { get; set; }
        /// <summary>
        /// This value contains CloudScanr response code.
        /// </summary>
        public string ResponseCode { get; set; }
        /// <summary>
        /// Will be contain total count of a request
        /// </summary>
        public int NumOfItemCount { get; set; }
        /// <summary>
        /// Request elapsed time in seconds
        /// </summary>
        public double ElapsedTimeInSeconds { get; set; }
    }
}
