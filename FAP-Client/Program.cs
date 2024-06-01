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

        static async Task<Response> CheckLoginNameAsync(string loginName)
        {
            Response ergebnis = null;
            HttpResponseMessage response = await client.GetAsync($"checkLoginName?id={loginName}");
            if (response.IsSuccessStatusCode)
            {
                // Deserialize the resource from the response body.
                ergebnis = await response.Content.ReadAsAsync<Response>();
            }
            return ergebnis;
        }

        static async Task<User> UpdateUserAsync(User user)
        {
            HttpResponseMessage response = await client.PutAsJsonAsync(
                $"api/users/{user.LoginName}", user);
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