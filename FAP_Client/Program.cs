using FAP_Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
            AddUserResponse ergebnis = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("addUser", user);
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<AddUserResponse>();
            }
            return ergebnis;
        }

        // GET: FAPServer/service/fapservice/checkLoginName
        public static async Task<BoolResponse> CheckLoginNameAsync(string id)
        {
            BoolResponse ergebnis = null;
            HttpResponseMessage response = await client.GetAsync($"checkLoginName?id={id}");
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<BoolResponse>();
            }
            return ergebnis;
        }

        // GET: FAPServer/service/fapservice/getOrt
        public static async Task<GetOrtResponse> GetOrtAsync(string postalCode, string username)
        {
            GetOrtResponse ergebnis = null;
            HttpResponseMessage response = await client.GetAsync($"getOrt?postalcode={postalCode}&username={username}");
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<GetOrtResponse>();
            }
            return ergebnis;
        }

        // POST: FAPServer/service/fapservice/login
        public static async Task<LoginResponse> LoginAsync(LoginBody loginBody)
        {
            LoginResponse ergebnis = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("login", loginBody);
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<LoginResponse>();
            }
            return ergebnis;
        }

        // POST: FAPServer/service/fapservice/logout
        static async Task<BoolResponse> LogoutAsync(LogoutBody logoutBody)
        {
            BoolResponse ergebnis = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("logout", logoutBody);
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<BoolResponse>();
            }
            return ergebnis;
        }

        // PUT: FAPServer/service/fapservice/setStandort
        public static async Task<BoolResponse> SetStandortAsync(SetStandortBody setStandortBody)
        {
            BoolResponse ergebnis = null;
            HttpResponseMessage response = await client.PutAsJsonAsync("setStandort", setStandortBody);
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<BoolResponse>();
            }
            return ergebnis;
        }

        // GET: FAPServer/service/fapservice/getStandort
        static async Task<Standort> GetStandortAsync(string login, string session, string id)
        {
            Standort ergebnis = null;
            HttpResponseMessage response = await client.GetAsync($"getStandort?login={login}&session={session}&id={id}");
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<Standort>();
            }
            return ergebnis;
        }

        // GET: FAPServer/service/fapservice/getBenutzer
        public static async Task<GetBenutzerResponse> GetBenutzerAsync(string login, string session)
        {
            GetBenutzerResponse ergebnis = null;
            HttpResponseMessage response = await client.GetAsync($"getBenutzer?login={login}&session={session}");
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<GetBenutzerResponse>();
            }
            return ergebnis;
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
            Application.Run(new RegisterForm());
        }
    }
}
