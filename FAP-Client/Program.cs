using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Threading.Tasks;
using FAP_Client.Models;
using System.Windows.Forms;

namespace FAP_Client
{
    internal class Program
    {
        static readonly HttpClient client = new HttpClient();

        // POST: FAPServer/service/fapservice/addUser
        static async Task<AddUserResponse> AddUserAsync(User user)
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
        static async Task<BoolResponse> CheckLoginNameAsync(string id)
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
        static async Task<GetOrtResponse> GetOrtAsync(int postalCode, string username)
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
        static async Task<LoginResponse> LoginAsync(LoginBody loginBody)
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
        static async Task<BoolResponse> SetStandortAsync(SetStandortBody setStandortBody)
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
        static async Task<GetBenutzerResponse> GetBenutzerAsync(string login, string session)
        {
            GetBenutzerResponse ergebnis = null;
            HttpResponseMessage response = await client.GetAsync($"getBenutzer?login={login}&session={session}");
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<GetBenutzerResponse>();
            }
            return ergebnis;
        }

        static void Main()
        {
            client.BaseAddress = new Uri("http://localhost:8080/FAPServer/service/fapservice");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}