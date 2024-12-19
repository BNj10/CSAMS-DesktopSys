using CSAMS_WebSys.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSAMS_WebSys.Services;
using System.Security.Cryptography;
using Google.Cloud.Firestore;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Timers;
using System.Security.Policy;
using System.Windows.Forms;
using CSAMS_WebSys.UserControls;

namespace CSAMS_WebSys.Services
{
    public class FingerprintVerificationService : FingerprintService
    {

        private DPFP.Verification.Verification Verificator;
/*        public event Action<MemberModel> MemberVerified;*/
        public event Action<MemberModel> Confirmation;
        public event Action UpdateAttendees;
        private static List<MemberModel> memberModels;
        private static DocumentSnapshot lastVisible;
        private static bool checkedAllMembers = false;
        private int pageSize = 2;

        public FingerprintVerificationService() : base()
        {
            Initialize();
            memberModels = new List<MemberModel>();
        }
        private void Initialize()
        {
            Verificator = new DPFP.Verification.Verification();

            base.ReceivingEnd -= OnReceivingEnd;
            base.ReceivingEnd += OnReceivingEnd;
        }

        public override void StartCapture()
        {
            base.StartCapture();
        }

        public override void StopCapture()
        {
            base.StopCapture();
        }

        private void OnReceivingEnd(object sender, DPFP.Sample sample)
        {
            _ = VerifyAsync(sample);
        }

        private async Task VerifyAsync(DPFP.Sample sample)
        {
            try
            {
                DPFP.FeatureSet features = ExtractFeatures(sample, DPFP.Processing.DataPurpose.Verification);

                if (features == null)
                {
                    Console.WriteLine("Failed to create a valid feature set from the sample.");
                    return;
                }

                MemberService memberService = new MemberService();
                List<MemberModel> tempList = new List<MemberModel>();
                DocumentSnapshot newLastVisible = null;

                do
                {
                    if (memberModels.Count == 0 || !checkedAllMembers)
                    {
                        (tempList, newLastVisible) = await memberService.RetrieveActiveMembersWithFingerprintAsync(pageSize, lastVisible);
                        if (tempList != null || tempList.Count != 0)
                        {
                            memberModels.AddRange(tempList);
                            checkedAllMembers = false;
                        }

                        if (tempList == null || tempList.Count == 0)
                        {
                            checkedAllMembers = true;
                            return;
                        }
                    }

                    lastVisible = newLastVisible;

                    foreach (var member in memberModels)
                    {
                        try
                        {
                            DPFP.Template template1 = new DPFP.Template();
                            DPFP.Template template2 = new DPFP.Template();

                            if (member.FingerprintData[0] == null && member.FingerprintData[1] == null)
                            {
                                break;
                            }

                            template1.DeSerialize(Convert.FromBase64String(member.FingerprintData[0]));
                            template2.DeSerialize(Convert.FromBase64String(member.FingerprintData[1]));

                            var result1 = new DPFP.Verification.Verification.Result();
                            var result2 = new DPFP.Verification.Verification.Result();

                            Verificator.Verify(features, template1, ref result1);
                            Verificator.Verify(features, template2, ref result2);

                            if (result1.Verified || result2.Verified)
                            {
                                this.Confirmation?.Invoke(member);
                                return;
                            }
                            else
                            {
                                Console.WriteLine("No match found for this template.");
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine($"Error verifying member: {ex.Message}", ex);
                        }
                    }
                } while(null != newLastVisible);

                Console.WriteLine("No matching fingerprints found for the sample.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Verification error: {ex.Message}");
                if (ex.InnerException != null)
                {
                    Console.WriteLine($"Inner Exception: {ex.InnerException.Message}");
                }
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void Update()
        {
            this.UpdateAttendees?.Invoke();
        }
    }
}
