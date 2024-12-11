using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using DotNetEnv;
using Google.Cloud.Firestore;

namespace CSAMS_WebSys.Services
{
    public static class FirebaseConnectionService
    {
        public static FirestoreDb db;
        public static FirestoreDb GetConnection()
        {
            if (db == null)
            {
                string envPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ".env");

                if (File.Exists(envPath))
                {
                    DotNetEnv.Env.Load(envPath);
                }
                else
                {
                    throw new FileNotFoundException("Environment file (.env) not found.");
                }

                string credentialsPath = Environment.GetEnvironmentVariable("GOOGLE_APPLICATION_CREDENTIALS");
                string firestoreProjectId = Environment.GetEnvironmentVariable("FIRESTORE_PROJECT_ID");

                if (string.IsNullOrWhiteSpace(credentialsPath) || string.IsNullOrWhiteSpace(firestoreProjectId))
                {
                    throw new InvalidOperationException("Firestore credentials or project ID are not set in environment variables.");
                }

                if (!File.Exists(credentialsPath))
                {
                    throw new FileNotFoundException($"Credentials file not found at: {credentialsPath}");
                }

                db = FirestoreDb.Create(firestoreProjectId);
            }

            return db;
        }
    }
}


