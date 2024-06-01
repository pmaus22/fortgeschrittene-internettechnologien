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

        static async Task<Uri> AddUserAsync(User user)
        {
            HttpResponseMessage response = await client.PostAsJsonAsync(
                "addUser", user);
            response.EnsureSuccessStatusCode();

            // Return URI of the created resource.
            return response.Headers.Location;
        }

        static async Task<CheckLoginNameResponse> CheckLoginNameAsync(string loginName)
        {
            CheckLoginNameResponse ergebnis = null;
            HttpResponseMessage response = await client.GetAsync($"checkLoginName?id={loginName}");
            if (response.IsSuccessStatusCode)
            {
                ergebnis = await response.Content.ReadAsAsync<CheckLoginNameResponse>();
            }
            // Return the deserialized resource from the response body.
            return ergebnis;
        }

        static async Task<GetOrtResponse> GetOrtAsync(int postalCode, string username)
        {
            GetOrtResponse antwort = null;
            HttpResponseMessage response = await client.GetAsync($"getOrt?postalcode={postalCode}&username={username}");
            if (response.IsSuccessStatusCode)
            {
                antwort = await response.Content.ReadAsAsync<GetOrtResponse>();
            }
            // Return the deserialized resource from the response body.
            return antwort;
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