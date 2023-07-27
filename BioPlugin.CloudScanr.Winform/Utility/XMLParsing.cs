using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BioPlugin.CloudScanr.Winform.Utility
{
    public static class XMLParsing
    {
        public static (string,string) Frotonic50Parse(string xmlString)
        {
            // Create an instance of XmlDocument
            XmlDocument xmlDoc = new XmlDocument();
            string leftNodeValue=string.Empty, rightNodeValue = string.Empty;
            try
            {
                // Load the XML string into the XmlDocument
                xmlDoc.LoadXml(xmlString);

                // Find all "Finger" elements
                XmlNodeList fingerNodes = xmlDoc.SelectNodes("/Fingers/Finger");
                foreach (XmlNode fingerNode in fingerNodes)
                {
                    // Access attribute values of each "Finger" element
                    string pos = fingerNode.Attributes["POS"].Value;
                    string source = fingerNode.Attributes["SOURCE"].Value;
                    string format = fingerNode.Attributes["FORMAT"].Value;
                    if (source == "LEFT") leftNodeValue = fingerNode.InnerText;
                    if(source=="RIGHT") rightNodeValue = fingerNode.InnerText;
                }
                return (leftNodeValue,rightNodeValue);
            }
            catch (XmlException ex)
            {
                Console.WriteLine("Error while parsing the XML string: " + ex.Message);
                return (null,null);
            }
        }

    }
}
