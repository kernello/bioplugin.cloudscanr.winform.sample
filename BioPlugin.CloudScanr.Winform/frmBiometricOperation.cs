using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text.Json;
using System.Text.RegularExpressions;
using BioPlugin.CloudScanr.Winform.Service;
using BioPlugin.CloudScanr.Winform.Utility;
using static BioPlugin.CloudScanr.Winform.Utility.ProcessResult;
using BioPlugin.CloudScanr.Winform.Sample.BiopluginService;

namespace BioPlugin.CloudScanr.Winform
{
    public partial class frmBiometricOperation : Form
    {
        BioPluginServiceSoapClient _bioPluginServiceSoapClient;
        public frmBiometricOperation()
        {
            InitializeComponent();
            _bioPluginServiceSoapClient = new BioPluginServiceSoapClient();
        }

        private async void btnIsRegistered_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(registrationId.Text))
                {
                    var matchingResult = await _bioPluginServiceSoapClient.IsRegisteredAsync(registrationId.Text, BioPluginConstant.EngineName);
                    var returnResult = ProcessServerResult(matchingResult.Body.IsRegisteredResult, BPOperationName.IsRegister);

                    txtBiometricOperationStatus.AppendText(">> Is Register Result: " + returnResult + "\n");
                }
                else
                {
                    txtBiometricOperationStatus.AppendText(BioPluginConstant.EMPTY_REGISTRATION_ID + "\n");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception) { throw; }
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(registrationId.Text))
                {
                    string json = FingerPrintCapture.CaptureRequestJson();

                    var captureResult = await FingerPrintCapture.FrutonicCapture(json);

                    if (captureResult.CloudScanrStatus.Success)
                    {
                        var (left, right) = XMLParsing.Frotonic50Parse(captureResult.TemplateData);
                        var matchingResult = await _bioPluginServiceSoapClient.RegisterAsync(left, 1, right, 1, registrationId.Text, 1);
                        var returnResult = ProcessServerResult(matchingResult.Body.RegisterResult, BPOperationName.Register);
                        txtBiometricOperationStatus.AppendText(">> Register Result: " + returnResult + "\n");
                    }
                    else
                    {
                        txtBiometricOperationStatus.AppendText(BioPluginConstant.CAPTUREFAILED + captureResult.CloudScanrStatus.Message + "\n");
                    }
                }
                else
                {
                    txtBiometricOperationStatus.AppendText(BioPluginConstant.EMPTY_REGISTRATION_ID + "\n");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async void btnIdentify_Click(object sender, EventArgs e)
        {
            try
            {
                string json = FingerPrintCapture.CaptureRequestJson();

                var captureResult = await FingerPrintCapture.FrutonicCapture(json);

                if (captureResult.CloudScanrStatus.Success)
                {
                    var (left, right) = XMLParsing.Frotonic50Parse(captureResult.TemplateData);
                    var matchingResult = await _bioPluginServiceSoapClient.IdentifyAsync(left, 1, 1, right, 1, 1, 1);
                    var returnResult = ProcessServerResult(matchingResult.Body.IdentifyResult, BPOperationName.Identify);
                    txtBiometricOperationStatus.AppendText(">> Identify Result: " + returnResult + "\n");
                }
                else
                {
                    txtBiometricOperationStatus.AppendText(BioPluginConstant.CAPTUREFAILED + captureResult.CloudScanrStatus.Message + "\n");
                }
            }
            catch (Exception) { throw; }
        }

        private async void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(registrationId.Text))
                {
                    string json = FingerPrintCapture.CaptureRequestJson();

                    var captureResult = await FingerPrintCapture.FrutonicCapture(json);

                    if (captureResult.CloudScanrStatus.Success)
                    {
                        var (left, right) = XMLParsing.Frotonic50Parse(captureResult.TemplateData);
                        var matchingResult = await _bioPluginServiceSoapClient.VerifyAsync(left, right, registrationId.Text, 1);
                        var returnResult = ProcessServerResult(matchingResult.Body.VerifyResult, BPOperationName.Verify);
                        txtBiometricOperationStatus.AppendText(">> Verify Result: " + returnResult + "\n");
                    }
                    else
                    {
                        txtBiometricOperationStatus.AppendText(BioPluginConstant.CAPTUREFAILED + captureResult.CloudScanrStatus.Message + "\n");
                    }
                }
                else
                {
                    txtBiometricOperationStatus.AppendText(BioPluginConstant.EMPTY_REGISTRATION_ID + "\n");
                }
            }
            catch (Exception) { throw; }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(registrationId.Text))
                {
                    string json = FingerPrintCapture.CaptureRequestJson();

                    var captureResult = await FingerPrintCapture.FrutonicCapture(json);

                    if (captureResult.CloudScanrStatus.Success)
                    {
                        var (left, right) = XMLParsing.Frotonic50Parse(captureResult.TemplateData);
                        var matchingResult = await _bioPluginServiceSoapClient.UpdateAsync(left, 1, right, 1, registrationId.Text, 1);
                        var returnResult = ProcessServerResult(matchingResult.Body.UpdateResult, BPOperationName.Update);
                        txtBiometricOperationStatus.AppendText(">> Update Result: " + returnResult + "\n");
                    }
                    else
                    {
                        txtBiometricOperationStatus.AppendText(BioPluginConstant.CAPTUREFAILED + captureResult.CloudScanrStatus.Message + "\n");
                    }
                }
                else
                {
                    txtBiometricOperationStatus.AppendText(BioPluginConstant.EMPTY_REGISTRATION_ID + "\n");
                }
            }
            catch (Exception) { throw; }
        }

        private async void btnChangeId_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(registrationId.Text) && !string.IsNullOrEmpty(txtOldID.Text))
                {
                    var matchingResult = await _bioPluginServiceSoapClient.ChangeIDAsync(txtOldID.Text, registrationId.Text, BioPluginConstant.EngineName);
                    var returnResult = ProcessServerResult(matchingResult.Body.ChangeIDResult, BPOperationName.ChangeID);
                    txtBiometricOperationStatus.AppendText(">> Change ID Result: " + returnResult + "\n");
                }
                else
                {
                    txtBiometricOperationStatus.AppendText(BioPluginConstant.CHANGE_ID + "\n");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(registrationId.Text))
                {
                    var matchingResult = await _bioPluginServiceSoapClient.DeleteIDAsync(registrationId.Text, BioPluginConstant.EngineName);
                    var returnResult = ProcessServerResult(matchingResult.Body.DeleteIDResult, BPOperationName.DeleteID);
                    txtBiometricOperationStatus.AppendText(">> Delete ID Result: " + returnResult + "\n");
                }
                else
                {
                    txtBiometricOperationStatus.AppendText(BioPluginConstant.EMPTY_REGISTRATION_ID + "\n");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
