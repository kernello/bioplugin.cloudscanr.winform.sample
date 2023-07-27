using BioPlugin.CloudScanr.Winform.Model;
using BioPlugin.CloudScanr.Winform.Utility;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace BioPlugin.CloudScanr.Winform.Service
{
    public static class FingerPrintCapture
    {

        public static string CaptureRequestJson()
        {
            var body = new
            {
                QuickScan = BioPluginConstant.QuickScan,
                DeviceName = BioPluginConstant.DeviceName,
                CaptureTimeOut = BioPluginConstant.CaptureTimeOut,
                TemplateFormat = BioPluginConstant.TemplateFormat
            };
            return System.Text.Json.JsonSerializer.Serialize(body);
        }

        public static async Task<CloudScanrCaptureResult> FrutonicCapture(string json)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri(BioPluginConstant.CloudScanrURL);
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var content = new StringContent(json, Encoding.UTF8, "application/json");

                    var result = await client.PostAsync("Fingerprint", content);
                    if(result.StatusCode== HttpStatusCode.OK)
                    {
                        var captureResult = JsonConvert.DeserializeObject<CloudScanrCaptureResult>(result.Content.ReadAsStringAsync().Result);
                        return captureResult;
                    }
                    else
                    {
                        return JsonConvert.DeserializeObject<CloudScanrCaptureResult>(result.Content.ReadAsStringAsync().Result);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
