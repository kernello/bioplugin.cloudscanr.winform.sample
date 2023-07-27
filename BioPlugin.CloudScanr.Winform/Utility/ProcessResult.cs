using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BioPlugin.CloudScanr.Winform.Utility
{
    public static class ProcessResult
    {

        public enum BPOperationName
        {
            None = 0,
            Register = 1,
            Identify = 2,
            Verify = 3,
            Update = 4,
            IsRegister = 5,
            DeleteID = 6,
            ChangeID = 7
        }
        public static string ProcessServerResult(string result, BPOperationName operationName)
        {
            //string value = GetResultValue(result);
            string serverResult = string.Empty;

            switch (result)
            {

                case "SUCCESS":
                    serverResult = string.Format("{0} successfull.", operationName.ToString());
                    break;
                case "LICENSE_ERROR":
                    serverResult = "License related problem orccured.";
                    break;
                case "11":
                    serverResult = "Duplicate found.";
                    break;
                case "27":
                    serverResult = "Duplicate found.";
                    break;
                case "16":
                    serverResult = "Duplicate found.";
                    break;
                case "38":
                    serverResult = "Duplicate found.";
                    break;
                case "INVALID_ENGINE":
                    serverResult = "Requested engine is invalid.";
                    break;
                case "-1":
                    if (operationName == BPOperationName.Register)
                        serverResult = "Registration ID exist in the system";
                    else if (operationName == BPOperationName.Identify)
                        serverResult = "Your Biometric is not in the system.";
                    else if (operationName == BPOperationName.IsRegister)
                        serverResult = "Duplicate not found";
                    else if (operationName == BPOperationName.Verify)
                        serverResult = "Verify Id not found in the system";
                    else if (operationName == BPOperationName.DeleteID
                        || operationName == BPOperationName.ChangeID
                        || operationName == BPOperationName.Update)
                        serverResult = "Registration Id not exist in the system";
                    else
                        serverResult = "Biometric operation failed.";
                    break;
                case "DS":
                    serverResult = "Delete was completed successfully.";
                    break;
                case "DF":
                    serverResult = "Delete failed.";
                    break;
                case "CS":
                    serverResult = "Change was completed successfully.";
                    break;
                case "CF":
                    serverResult = "ChangeID failed.";
                    break;
                case "VS":
                    serverResult = "Verify was completed successfully.";
                    break;
                case "VF":
                    serverResult = "Verify failed.";
                    break;
                case "":
                    serverResult = "Web service connection failed.";
                    break;
                case "-411":
                    serverResult = "Bioplugin server connection timeout. Please try again.";
                    break;
                default:

                    serverResult = "Biometric record found in the system with ID - " + result;
                    break;
            }

            return serverResult;
        }

        private static string GetResultValue(string result)
        {
            string value = string.Empty;

            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(result);

                XmlNode node = xmlDoc.SelectSingleNode("Results");
                if (node != null && node.HasChildNodes)
                {
                    foreach (XmlNode childNode in node.ChildNodes)
                    {
                        if (childNode.Name.Equals("result"))
                        {
                            value = childNode.Attributes["value"].Value.ToString();
                            break;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                if (result.Contains("empty")) throw new Exception("BioPlugin Server not responding");
                else throw ex;
            }
            return value;
        }
    }
}
