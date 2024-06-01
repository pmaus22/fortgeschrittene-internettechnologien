using System;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Net;
using System.Threading.Tasks;
using FAP_Client.Models;
using System.Windows.Forms;

namespace FAP_Client
{
    internal class Program
    {
        static readonly HttpClient client = new HttpClient();

        static async Task<AddUserResponse> AddUserAsync(User user)
        {
            AddUserResponse ergebnis = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("addUser", user);
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<AddUserResponse>();
            }
            // Return the deserialized resource from the response body.
            return ergebnis;
        }

        static async Task<BoolResponse> CheckLoginNameAsync(string id)
        {
            BoolResponse ergebnis = null;
            HttpResponseMessage response = await client.GetAsync($"checkLoginName?id={id}");
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<BoolResponse>();
            }
            // Return the deserialized resource from the response body.
            return ergebnis;
        }

        static async Task<GetOrtResponse> GetOrtAsync(int postalCode, string username)
        {
            GetOrtResponse ergebnis = null;
            HttpResponseMessage response = await client.GetAsync($"getOrt?postalcode={postalCode}&username={username}");
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<GetOrtResponse>();
            }
            // Return the deserialized resource from the response body.
            return ergebnis;
        }

        static async Task<LoginResponse> LoginAsync(LoginBody loginBody)
        {
            LoginResponse ergebnis = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("login", loginBody);
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<LoginResponse>();
            }
            // Return the deserialized resource from the response body.
            return ergebnis;
        }

        static async Task<BoolResponse> LogoutAsync(LogoutBody logoutBody)
        {
            BoolResponse ergebnis = null;
            HttpResponseMessage response = await client.PostAsJsonAsync("logout", logoutBody);
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<BoolResponse>();
            }
            // Return the deserialized resource from the response body.
            return ergebnis;
        }

        static async Task<User> UpdateUserAsync(User user)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/users/{user.loginName}", user);
            response.EnsureSuccessStatusCode();

            // Deserialize the updated product from the response body.
            user = await response.Content.ReadAsAsync<User>();
            return user;
        }

        static async Task<HttpStatusCode> DeleteuserAsync(long id)
        {
            HttpResponseMessage response = await client.DeleteAsync(
                $"api/users/{id}");
            return response.StatusCode;
        }

        static void Main()
        {
            client.BaseAddress = new Uri("http://localhost:8080/FAPServer/service/fapservice");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}