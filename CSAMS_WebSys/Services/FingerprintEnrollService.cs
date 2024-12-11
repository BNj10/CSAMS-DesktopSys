using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSAMS_WebSys.Services
{
    public class FingerprintEnrollService : FingerprintService
    {
        private DPFP.Processing.Enrollment Enroller;
        public event Action<string> LogInfo;
        public event Action Complete;
        public event Action Halfway;
        private string fingerprintData1;
        private string fingerprintData2;
        private int fingerprintCount;
        private bool isEnrollmentActive;

        public FingerprintEnrollService() : base()
        {
            InitializeEnrollment();
        }

        private void InitializeEnrollment()
        {
            try
            {
                Enroller = new DPFP.Processing.Enrollment();
                fingerprintCount = 1;
                isEnrollmentActive = true;

                base.ReceivingEnd -= OnReceivingEnd;
                base.ReceivingEnd += OnReceivingEnd;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error initializing enrollment: {ex.Message}");
                throw;
            }
        }

        public override void StartCapture()
        {
            try
            {
                isEnrollmentActive = true;
                base.StartCapture();
                UpdateStatus("Capture Attempted");
            }
            catch (Exception ex)
            {
                UpdateStatus("Error starting capture. Please check the scanner and try again.");
                throw new Exception($"Error starting capture: {ex.Message}", ex);
            }
        }

        public override void StopCapture()
        {
            try
            {
                isEnrollmentActive = false;
                base.StopCapture();
                UpdateStatus("Capture stopped.");
            }
            catch (Exception ex)
            {
                UpdateStatus("Error stopping capture.");
                throw new Exception($"Error stopping capture: {ex.Message}", ex);
            }
        }

        private void OnReceivingEnd(object sender, DPFP.Sample sample)
        {
            if (!isEnrollmentActive) return;

            try
            {
                CreateTemplate(sample);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error processing fingerprint: {ex.Message}");
                UpdateStatus("Error occurred while processing fingerprint.");
            }
        }

        private void CreateTemplate(DPFP.Sample sample)
        {
            try
            {
                DPFP.FeatureSet features = ExtractFeatures(sample, DPFP.Processing.DataPurpose.Enrollment);

                if (features != null)
                {
                    Enroller.AddFeatures(features);
                    UpdateStatus($" {4 - Enroller.FeaturesNeeded} of 4 captured.");

                    if (Enroller.TemplateStatus == DPFP.Processing.Enrollment.Status.Ready)
                    {
                        SaveFingerprint();

                        if (fingerprintCount > 2)
                        {
                            StopCapture();
                            fingerprintCount = 1;
                            UpdateStatus("Enrollment complete!");
                            Complete?.Invoke();
                        }
                        else
                        {
                            Enroller = new DPFP.Processing.Enrollment();
                            UpdateStatus($" Ready to capture sample {fingerprintCount}.");
                        }
                    }
                }
                else
                {
                    UpdateStatus("Poor quality sample. Please try again.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error creating template: {ex.Message}", ex);
            }
        }

        private void SaveFingerprint()
        {
            try
            {
                if (Enroller.TemplateStatus == DPFP.Processing.Enrollment.Status.Ready)
                {
                    using (MemoryStream data = new MemoryStream())
                    {
                        Enroller.Template.Serialize(data);
                        string fingerprint = Convert.ToBase64String(data.ToArray());

                        if (fingerprintCount == 1)
                        {
                            fingerprintData1 = fingerprint;
                            UpdateStatus("First fingerprint saved successfully!");
                        }
                        else if (fingerprintCount == 2)
                        {
                            fingerprintData2 = fingerprint;
                            UpdateStatus("Second fingerprint saved successfully!");
                        }

                        fingerprintCount++;
                    }
                }
                else if (Enroller.TemplateStatus == DPFP.Processing.Enrollment.Status.Failed)
                {
                    Enroller.Clear();
                    UpdateStatus("Enrollment failed. Starting over...");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error saving fingerprint: {ex.Message}", ex);
            }
        }

        public (string fingerprintData1, string fingerprintData2) GetFingerprintData()
        {
            if (string.IsNullOrEmpty(fingerprintData1) || string.IsNullOrEmpty(fingerprintData2))
            {
                throw new InvalidOperationException("Enrollment not complete. Both fingerprints are required.");
            }
            return (fingerprintData1, fingerprintData2);
        }

        private void UpdateStatus(string info)
        {
            try
            {
                LogInfo?.Invoke(info);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating status: {ex.Message}");
            }
        }
    }
}
