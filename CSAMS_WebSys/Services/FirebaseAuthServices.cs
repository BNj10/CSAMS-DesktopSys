using Newtonsoft.Json;
using System;
using System.Diagnostics.Eventing.Reader;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSAMS_WebSys.Services;
using Guna.UI2.WinForms;
using Newtonsoft.Json.Linq;

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
            try
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


                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        return JsonConvert.DeserializeObject<FirebaseAuthResponse>(responseContent);
                    }
                    else
                    {
                        string errorContent = await response.Content.ReadAsStringAsync();
                        var errorDetails = JsonConvert.DeserializeObject<JObject>(errorContent);
                        string errorMessage = errorDetails?["error"]?["message"]?.ToString();

                        if (errorMessage == "INVALID_LOGIN_CREDENTIALS")
                        {
                            throw new Exception("The email or password you entered is incorrect. Please try again.");
                        }
                        else
                        {
                            throw new LoginException("A network error occurred while attempting to log in. Please check your connection.");
                        }
                    }
                }
            }
            catch (HttpRequestException)
            {
                throw new LoginException("A network error occurred while attempting to log in. Please check your connection.");
            }
        }
    }

    public class LoginException : Exception
    {
        public LoginException(string message, Exception innerException = null) : base(message, innerException) { }
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
