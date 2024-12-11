using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSAMS_WebSys.Models;
using CSAMS_WebSys.Services;

namespace CSAMS_WebSys.Forms
{
    public partial class FingerPrintScan : Form
    {
        FingerprintVerificationService FVS;
        private DPFP.Capture.ReadersCollection readers;
        private bool IsConnected = false;
        private bool previousConnectionState = false;
        private bool isCurrentlyConnected = false;
        public FingerPrintScan(FingerprintVerificationService fp)
        {
            InitializeComponent();
            timer1.Interval = 1000;
            timer1.Tick += CheckConnectedReaders;
            timer1.Start();
        }

        public void CheckConnectedReaders(object sender, EventArgs e)
        {
            try
            {
                readers = new DPFP.Capture.ReadersCollection();
                isCurrentlyConnected = readers.Count > 0;

                if (isCurrentlyConnected != previousConnectionState)
                {
                    IsConnected = isCurrentlyConnected;
                    previousConnectionState = isCurrentlyConnected;

                    UpdateConnectedDevice(isCurrentlyConnected ?
                        "Fingerprint Scanner \nConnected." :
                        "No device connected.");
                }
            }
            catch (Exception ex)
            {
                LogError($"Error in CheckConnectedReaders(): {ex.Message}");
            }
        }

        private void LogError(string message, Exception ex = null)
        {
            Console.WriteLine($"ERROR: {message}\n{ex}");
        }

        private void UpdateConnectedDevice(string message)
        {
            if (noOfTimes_gunaLabel.InvokeRequired)
            {
                noOfTimes_gunaLabel.Invoke(new Action(() => noOfTimes_gunaLabel.Text = message));
            }
            else
            {
                noOfTimes_gunaLabel.Text = message;
            }
        }

        private void FingerPrintScan_FormClosing(object sender, FormClosingEventArgs e)
        {
            timer1.Stop();
        }

        private void FingerPrintScan_Load(object sender, EventArgs e)
        {
           
        }
    }
}
