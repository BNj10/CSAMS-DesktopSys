using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Drawing.Diagrams;
using DPFP;
using DPFP.Capture;

namespace CSAMS_WebSys.Services
{
    public class FingerprintService : DPFP.Capture.EventHandler
    {
        public event EventHandler<Sample> ReceivingEnd;

        private DPFP.Capture.Capture Capturer;
        private bool isInitialized;
        private static bool capturing = false;

        public FingerprintService()
        {
            InitializeCapture();
        }

        private void InitializeCapture()
        {
            try
            {
                Capturer = new DPFP.Capture.Capture();

                if (Capturer != null)
                {
                    Capturer.EventHandler = this;
                    isInitialized = true;
                }
                else
                {
                    MessageBox.Show("Failed to initialize capture device!");
                    throw new InvalidOperationException("Cannot initialize capture device.");
                }
            }
            catch (Exception ex)
            {
                isInitialized = false;
                throw new InvalidOperationException("Failed to initialize capture device.", ex);
            }
        }

        public virtual void StartCapture()
        {
            if (!isInitialized)
            {
                MessageBox.Show("Capture device not initialized!");
                return;
            }

            try
            {
                if (!capturing)
                {
                    Capturer.StartCapture();
                    capturing = true;
                } 
                else
                {
                    Capturer.StopCapture();
                    capturing = false;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred during StartCapture", ex);
            }
        }

        public virtual void StopCapture()
        {
            if (!isInitialized)
            {
                return;
            }

            try
            {
                Capturer.StopCapture();
            }
            catch (Exception ex)
            {
                throw new Exception("Error occurred during StopCapture", ex);
            }
        }

        public void OnComplete(object Capture, string ReaderSerialNumber, Sample Sample)
        {
            try
            {
                ReceivingEnd?.Invoke(this, Sample);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error in OnComplete: {ex.Message}");
            }
        }

        public void OnFingerGone(object Capture, string ReaderSerialNumber)
        {
            Console.WriteLine("Finger gone");
        }

        public void OnFingerTouch(object Capture, string ReaderSerialNumber)
        {
            Console.WriteLine("Finger touched");
        }

        public void OnReaderConnect(object Capture, string ReaderSerialNumber)
        {
            Console.WriteLine("Reader connected");
        }

        public void OnReaderDisconnect(object Capture, string ReaderSerialNumber)
        {
            Console.WriteLine("Reader disconnected");
        }

        public void OnSampleQuality(object Capture, string ReaderSerialNumber, CaptureFeedback CaptureFeedback)
        {
            Console.WriteLine($"Sample quality: {CaptureFeedback}");
        }

        protected DPFP.FeatureSet ExtractFeatures(Sample Sample, DPFP.Processing.DataPurpose Purpose)
        {
            try
            {
                DPFP.Processing.FeatureExtraction Extractor = new DPFP.Processing.FeatureExtraction();
                DPFP.Capture.CaptureFeedback feedback = DPFP.Capture.CaptureFeedback.None;
                DPFP.FeatureSet features = new DPFP.FeatureSet();

                Extractor.CreateFeatureSet(Sample, Purpose, ref feedback, ref features);

                return feedback == DPFP.Capture.CaptureFeedback.Good ? features : null;
            }
            catch
            {
                MessageBox.Show("An error occurred while capturing the fingerprint.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}