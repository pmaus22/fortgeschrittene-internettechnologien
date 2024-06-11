using FAP_Client.Models;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FAP_Client
{
    public static class Program
    {
        // Client object for HTTP requests.
        static readonly HttpClient client = new HttpClient();

        // POST: FAPServer/service/fapservice/addUser
        public static async Task<AddUserResponse> AddUserAsync(User user)
        {
            AddUserResponse data = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("addUser", user);
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsAsync<AddUserResponse>();
            }
            return data;
        }

        // GET: FAPServer/service/fapservice/checkLoginName
        public static async Task<BoolResponse> CheckLoginNameAsync(string id)
        {
            BoolResponse data = null;
            HttpResponseMessage response = await client.GetAsync($"checkLoginName?id={id}");
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsAsync<BoolResponse>();
            }
            return data;
        }

        // GET: FAPServer/service/fapservice/getOrt
        public static async Task<GetOrtResponse> GetOrtAsync(string postalCode, string username)
        {
            GetOrtResponse data = null;
            HttpResponseMessage response = await client.GetAsync($"getOrt?postalcode={postalCode}&username={username}");
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsAsync<GetOrtResponse>();
            }
            return data;
        }

        // POST: FAPServer/service/fapservice/login
        public static async Task<LoginResponse> LoginAsync(LoginBody loginBody)
        {
            LoginResponse data = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("login", loginBody);
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsAsync<LoginResponse>();
            }
            return data;
        }

        // POST: FAPServer/service/fapservice/logout
        static async Task<BoolResponse> LogoutAsync(LogoutBody logoutBody)
        {
            BoolResponse data = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("logout", logoutBody);
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsAsync<BoolResponse>();
            }
            return data;
        }

        // PUT: FAPServer/service/fapservice/setStandort
        public static async Task<BoolResponse> SetStandortAsync(SetStandortBody setStandortBody)
        {
            BoolResponse data = null;
            HttpResponseMessage response = await client.PutAsJsonAsync("setStandort", setStandortBody);
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsAsync<BoolResponse>();
            }
            return data;
        }

        // GET: FAPServer/service/fapservice/getStandort
        public static async Task<Standort> GetStandortAsync(string login, string session, string id)
        {
            Standort data = null;
            HttpResponseMessage response = await client.GetAsync($"getStandort?login={login}&session={session}&id={id}");
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsAsync<Standort>();
            }
            return data;
        }

        // GET: FAPServer/service/fapservice/getBenutzer
        public static async Task<GetBenutzerResponse> GetBenutzerAsync(string login, string session)
        {
            GetBenutzerResponse data = null;
            HttpResponseMessage response = await client.GetAsync($"getBenutzer?login={login}&session={session}");
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsAsync<GetBenutzerResponse>();
            }
            return data;
        }

        // GET: FAPServer/service/fapservice/getStandortPerAdresse
        public static async Task<Standort> GetStandortPerAdresseAsync(string land, string plz, string ort, string strasse)
        {
            Standort data = null;
            HttpResponseMessage response = await client.GetAsync($"getStandortPerAdresse?land={land}&plz={plz}&ort={ort}&strasse={strasse}");
            if (response.IsSuccessStatusCode)
            {
                data = await response.Content.ReadAsAsync<Standort>();
            }
            return data;
        }

        /// The main entry point for the application.
        [STAThread]
        static void Main()
        {
            // Configure HTTP Client.
            client.BaseAddress = new Uri("http://localhost:8080/FAPServer/service/fapservice/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            // Configure and run Windows Forms application.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
