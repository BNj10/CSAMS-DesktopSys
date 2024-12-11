using Newtonsoft.Json;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSAMS_WebSys.Services;

namespace YourNamespace
{
    public class FirebaseAuthService
    {
        private const string FirebaseAuthUrl = "https://identitytoolkit.googleapis.com/v1/accounts:signInWithPassword?key={0}";
        private readonly string _firebaseApiKey;

        public FirebaseAuthService(string firebaseApiKey)
        {
            _firebaseApiKey = firebaseApiKey;
        }

        public async Task<FirebaseAuthResponse> LoginAsync(string email, string password)
        {
            using (HttpClient client = new HttpClient())
            {
                var requestBody = new
                {
                    email = email,
                    password = password,
                    returnSecureToken = true
                };

                var jsonRequestBody = JsonConvert.SerializeObject(requestBody);
                var content = new StringContent(jsonRequestBody, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(string.Format(FirebaseAuthUrl, _firebaseApiKey), content);

                string responseContent = await response.Content.ReadAsStringAsync();
                var firebaseAuthResponse = JsonConvert.DeserializeObject<FirebaseAuthResponse>(responseContent);

                return firebaseAuthResponse;
            }
        }
    }

    public class FirebaseAuthErrorResponse
    {
        [JsonProperty("error")]
        public FirebaseAuthError Error { get; set; }
    }
    public class FirebaseAuthError
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; }
    }
    public class FirebaseAuthResponse
    {
        [JsonProperty("idToken")]
        public string IdToken { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("expiresIn")]
        public string ExpiresIn { get; set; }

        [JsonProperty("refreshToken")]
        public string RefreshToken { get; set; }

        [JsonProperty("localId")]
        public string LocalId { get; set; }

        [JsonProperty("kind")]
        public string Kind { get; set; }
    }
}
